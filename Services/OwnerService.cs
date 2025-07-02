using Destination.Components.Pages.BookingComponents;
using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using Destination.Shared.ExternalServices;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text.RegularExpressions;
using static Destination.Shared.DTO.MainResponse;
using Query = Radzen.Query;

namespace Destination.Services
{
    public class OwnerService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;
        private readonly SendGridEmailService _sendGridEmailService;
        public OwnerService(IDbContextFactory<destinationTestContext> dbContextFactory,SendGridEmailService sendGridEmailService)
        {
            this.dbContextFactory = dbContextFactory;
            _sendGridEmailService = sendGridEmailService;
        }

        public async Task<PagedResult<Agent>> GetownersPagedAsync(Query query, OwnerDto? filterModel = null)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Agents.AsQueryable();

            // Apply filtering, sorting, skip, and take
            var filteredItems = items;

            if (!string.IsNullOrEmpty(query.Filter))
            {
                filteredItems = filteredItems.Where(query.Filter, query.FilterParameters);
            }

            if (filterModel != null)
            {

                if (!string.IsNullOrWhiteSpace(filterModel.FirstName))
                {
                    filteredItems = filteredItems.Where(b => b.FirstName.Contains(filterModel.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.LastName))
                {
                    filteredItems = filteredItems.Where(b => b.LastName.Contains(filterModel.LastName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Cell))
                {
                    filteredItems = filteredItems.Where(b => b.Cell.Contains(filterModel.Cell));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Address))
                {
                    filteredItems = filteredItems.Where(b => b.Address.Contains(filterModel.Address));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Email))
                {
                    filteredItems = filteredItems.Where(b => b.Email.Contains(filterModel.Email));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Source))
                {
                    filteredItems = filteredItems.Where(b => b.Source.Contains(filterModel.Source));
                }

                if (filterModel.Newstatus > 0)
                {
                    filteredItems = filteredItems.Where(b => b.Newstatus == filterModel.Newstatus);
                }

                if (filterModel.Touched.HasValue && filterModel.Lasttouched.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Touched >= filterModel.Touched.Value && b.Touched <= filterModel.Lasttouched.Value);
                }
            }


            var count = await filteredItems.CountAsync();

            if (!string.IsNullOrEmpty(query.OrderBy))
            {
                filteredItems = filteredItems.OrderBy(query.OrderBy);
            }

            if (query.Skip.HasValue)
            {
                filteredItems = filteredItems.Skip(query.Skip.Value);
            }

            if (query.Top.HasValue)
            {
                filteredItems = filteredItems.Take(query.Top.Value);
            }

            var data = await filteredItems.ToListAsync();

            return new PagedResult<Agent>
            {
                Items = data,
                Count = count
            };
        }

        public async Task<List<Template>> GetEmailTemplates()
        {
            using var context = dbContextFactory.CreateDbContext();
            return await context.Templates.Where(x => x.StrType == "Home Owner" && x.Strstatus == 1).OrderBy(x => x.StrTemplateName).ToListAsync();
        }

        public async Task<List<Smstemplate>> GetSMSTemplates()
        {
            using var context = dbContextFactory.CreateDbContext();
            return await context.Smstemplates.Where(x => x.Audience == "Owner").OrderBy(x => x.StrTemplateName).ToListAsync();
        }

        public string GenerateSmsContent(SmsOwnerRecordDto dto, string customMessage)
        {
            try
            {
                var content = dto.Content ?? "";

                content = content.Replace("[firstname]", dto.FirstName)
                                 .Replace("[Name]", dto.Name)
                                 .Replace("[Namenospaces]", dto.Name?.Replace(" ", ""))
                                 .Replace("[wildcard1]", "SnowRemoval") // Replace with actual value if needed
                                 .Replace("[address]", dto.Address)
                                 .Replace("[city]", dto.City)
                                 .Replace("[zip]", dto.Zip)
                                 .Replace("[topcontent]", dto.StrTopContent ?? "")
                                 .Replace("[bottomcontent]", (dto.StrBottomContent ?? "").Replace("[id]", dto.Id.ToString()))
                                 .Replace("[propid]", dto.PropId.ToString())
                                 .Replace("[login]", dto.Email)
                                 .Replace("[password]", dto.LastName)
                                 .Replace("[beds]", dto.Bedrooms)
                                 .Replace("[baths]", dto.Baths)
                                 .Replace("[propheadlines]", dto.PropHeadlines)
                                 .Replace("[msg]", customMessage?.Trim());

                return content;
            }
            catch
            {
                return "Error in generating content.";
            }
        }

        public async Task InsertTwilioSmsAsync(string number, string subject, string body, int bookingId)
        {
            using var context = dbContextFactory.CreateDbContext();
            SendTwilioSm sts = new()
            {
                Smsnumber = number,
                Subject = subject,
                Smsbody = body,
                BookingId = bookingId,
                Smsstatus = 0
            };

            await context.SendTwilioSms.AddAsync(sts);
            await context.SaveChangesAsync();
        }

        public async Task<int> UpdateBookingAfterFollowSmsAsync(int id, string commCode, int agent, string text)
        {
            using var context = dbContextFactory.CreateDbContext();

            var parameters = new[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@commCode", commCode),
                new SqlParameter("@agent", agent),
                new SqlParameter("@CommunicationText", text)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC Proc_UpdateBookingAfterFollowSMSNew @id, @commCode, @agent, @CommunicationText", parameters);
        }



        public async Task SendSmsToOwnersAsync(List<SmsOwnerRecordDto> owners, string customMessage)
        {
            foreach (var owner in owners)
            {
                try
                {
                    var smsContent = GenerateSmsContent(owner, customMessage);

                    // Send SMS
                    await InsertTwilioSmsAsync(owner.Cell, string.Empty, smsContent, owner.Id.Value);

                    //await _twilioSmsService.SendSmsAsync("949-355-4810", smsContent);

                    // Log communication
                    await UpdateBookingAfterFollowSmsAsync(owner.Id.Value, owner.Code, owner.Id.Value, smsContent);
                }
                catch (Exception ex)
                {
                    // log error
                }
            }
        }


        public async Task<List<SmsOwnerRecordDto>> GetOwnerRecordsAsync(int agentId, int templateId)
        {
            using var context = dbContextFactory.CreateDbContext();

            var result = await context.SmsOwnerRecords
            .FromSqlRaw("EXEC proc_getRecordsForSMSToOwner_BasedonOwnerID @AgentID = {0}, @intTemplateID = {1}", agentId, templateId)
                .AsNoTracking()
                .ToListAsync();

            return result;
        }

        public async Task<int> SendEmailAsync(int agentId, int templateId, string customMessage)
        {
            using var context = dbContextFactory.CreateDbContext();

            var agentData = context.AgentEmailDetails
                .FromSqlRaw("EXEC Proc_GetAgentDetails @intAgentId = {0}, @intTemplateId = {1}", agentId, templateId)
                .AsNoTracking()
                .AsEnumerable()
                .FirstOrDefault(); // not async, already executed

            if (agentData == null || string.IsNullOrEmpty(agentData.Email))
                return 0;

            if (!IsValidEmail(agentData.Email))
                return 2;

            string subject = agentData.StrSubject?.Replace("[AgID]", agentData.AgID.ToString());
            string body = PopulateTemplate(agentData, customMessage);

            await _sendGridEmailService.SendViaSendGridAsync(agentData.Email, subject, body);

            OwnerCommunication ownerCommunication = new()
            {
                Ownercomm = customMessage.Trim(),
                Ownerid = agentId,
                Type = "Email",
                Cdate = DateTime.Now,
                Agent = agentData.AgID,
                Emailtemplate = body
            };

            await context.OwnerCommunications.AddAsync(ownerCommunication);
            await context.SaveChangesAsync();

            return 1;
        }

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) &&
                   Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private string PopulateTemplate(AgentDetailsForEmailDto dto, string message)
        {
            string content = dto.StrTemplateContent ?? "";

            string safeMessage = message?.Trim() ?? "";

            content = content.Replace("[taskid]", dto.AgID.ToString())
                             .Replace("[firstname]", dto.FirstName ?? "")
                             .Replace("[Name]", $"{dto.FirstName ?? ""} {dto.LastName ?? ""}")
                             .Replace("[id]", dto.AgID.ToString())
                             .Replace("[currentdate]", DateTime.Now.ToShortDateString())
                             .Replace("[address]", dto.Address ?? "")
                             .Replace("[addresses]", dto.Address ?? "")
                             .Replace("[city]", dto.City ?? "")
                             .Replace("[zip]", dto.Zip.ToString())
                             .Replace("[topcontent]", dto.StrTopContent ?? "")
                             .Replace("[bottomcontent]", dto.StrBottomContent ?? "")
                             .Replace("[login]", dto.Email ?? "")
                             .Replace("[password]", dto.Password ?? "")
                             .Replace("[ownercomm]", safeMessage);

            return content;
        }



        public async Task<List<OwnerCommunicationByAgentDTO>> GetOwnersCommunicationByAgent(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();

            var result = await (from oc in context.OwnerCommunications
                                join p in context.Properties on oc.Ownerid equals p.Agentid into propJoin
                                from prop in propJoin.DefaultIfEmpty()
                                join t in context.Tenants on oc.Agent equals t.Tenantid into tenantJoin
                                from tenant in tenantJoin.DefaultIfEmpty()
                                where oc.Ownerid == 6441
                                orderby oc.Id descending
                                select new OwnerCommunicationByAgentDTO
                                {
                                    Id = oc.Id,
                                    Ownercomm = oc.Ownercomm,
                                    Ownerid = oc.Ownerid,
                                    Type = oc.Type,
                                    Cdate = oc.Cdate,
                                    Agent = oc.Agent,
                                    Emailtemplate = oc.Emailtemplate,
                                    ActionReq = oc.ActionReq,
                                    AssignedTo = oc.AssignedTo,
                                    Department = oc.Department,
                                    PropId = oc.PropId,
                                    ShowOnRates = oc.ShowOnRates,
                                    OwnerFlag = oc.OwnerFlag,
                                    TenantId = tenant != null ? tenant.Tenantid : null,
                                    Initials = tenant != null ? tenant.Initials : null,
                                    PropertyName = prop != null ? prop.Name : null,
                                    PptID = prop != null ? prop.Propid : null
                                })
                    .Distinct()
                    .ToListAsync();

            return result;
        }
    }
}
