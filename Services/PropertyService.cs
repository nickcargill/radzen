using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.AllDropDownValues;
using static Destination.Shared.DTO.MainResponse;

namespace Destination.Services
{
    public class PropertyService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public PropertyService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<PagedResult<Property>> GetPropertiesPagedAsync(Query query)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Properties
                .Include(i => i.Agent)
                .Include(i => i.PropertyCleaner)
                .Include(i => i.Status1)
                .AsQueryable();

            // Apply filtering, sorting, skip, and take
            var filteredItems = items;

            if (!string.IsNullOrEmpty(query.Filter))
            {
                filteredItems = filteredItems.Where(query.Filter, query.FilterParameters);
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

            var data = await filteredItems.Where(x => x.Name !=null).ToListAsync();

            return new PagedResult<Property>
            {
                Items = data,
                Count = count
            };
        }

        public async Task<List<AgentDropDownValues>> GetAgentDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Agents
                .Where(x => x.FirstName != null)
                .Select(x => new AgentDropDownValues
                {
                    AgID = x.AgId,
                    Name = x.FirstName
                })
                .ToList();

            return items;
        }

        public async Task<List<AgentStatusDropDownValues>> GetAgentStatusDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.AgentStatuses
                .Select(x => new AgentStatusDropDownValues
                {
                    StatusId = x.Statusid,
                    StatusName = x.Status
                })
                .ToList();

            return items;
        }

        public async Task<List<PropertyTypeDropDownValues>> GetPropertyTypesDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = context.PropertyTypes.Select(x => new PropertyTypeDropDownValues
            {
                TypeId = x.Typeid,
                Type = x.Type
            }).ToList();

            return items;
        }

        public async Task<List<OwnerLoginDDValues>> GetOwnerDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = context.Tenants.Where(x=>x.Role > 23).Select(x => new OwnerLoginDDValues
            {
                TenantId = x.Tenantid,
                OwnerName = x.Firstname
            }).ToList();

            return items;
        }

        public async Task<List<PropertyCleanerDDValues>> GetPropertyCleanerDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = context.PropertyCleaners.Select(x => new PropertyCleanerDDValues
            {
                CleanerId = x.Cleanerid,
                Name = x.Firstname
            }).ToList();

            return items;
        }

        public async Task<bool> Updateproperty(Property prop)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                context.Properties.Update(prop);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public async Task<bool> UpdaterPopertyRates(PropertyRate prop, bool isEdit)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                if (isEdit)
                {
                    context.PropertyRates.Update(prop);
                }
                else
                {
                    context.PropertyRates.Add(prop);
                }

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<AllDropDownValues.PropertyDropDownData>> GetPropertiesForDropDown(Query query = null)
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = await context.Properties
                .Where(x => x.Name != null)
                .Select(x => new AllDropDownValues.PropertyDropDownData
                {
                    Propid = x.Propid,
                    Name = x.Name
                }).ToListAsync();

            return items;
        }

        public async Task<bool> UpdateVrboRates(PropertyRatesVrbo prop, bool isEdit)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                if (isEdit)
                {
                    context.PropertyRatesVrbos.Update(prop);
                }
                else
                {
                    context.PropertyRatesVrbos.Add(prop);
                }

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<VwMaintenanceNextDateFrom>> GetTasksByPropId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.VwMaintenanceNextDateFroms
                        .FromSqlRaw("EXEC RDZ_proc_getTasksListPerProperty @PropID = {0}", id)
                            .AsNoTracking()
                            .ToListAsync();
            return result;
        }

        public async Task<PropertyMgt> GetPropertyMgtByPropId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.PropertyMgts.Where(x => x.Propid == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<PropertyImprovementDto>> GetImprovementsByPropId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.PropertyImprovementResults
                .FromSqlRaw("EXEC RDZ_proc_getImprovementsDataPerProp @propid = {0}", id)
                    .AsNoTracking()
                    .ToListAsync();
            return result;
        }

        public async Task<List<PropertyAnnualLogDto>> GetPropertyAnnualLogs(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.PropertyAnnualLogResults
                .FromSqlRaw("EXEC proc_GetPropertyAnnualLog @PropID = {0}", id)
                    .AsNoTracking()
                    .ToListAsync();
            return result;
        }

        public async Task<bool> UpdatePropertyAnnualLogs(PropertyAnnualLogDto data)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();

                PropertyAnnualLog pal = new PropertyAnnualLog();
                pal.Id = data.ID;
                pal.TaskId = data.TaskID;
                pal.PropId = data.PropID;
                pal.Notes = data.Notes;
                pal.OpenClosedStatus = data.OpenClosedStatus == "Open" ? true : false;
                pal.LastUpdated = DateTime.Now;

                context.PropertyAnnualLogs.Update(pal);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> CreateUpdaterPopertymgt(PropertyMgt pmgt, bool isEdit)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                if (isEdit)
                {
                    context.PropertyMgts.Update(pmgt);
                }
                else
                {
                    context.PropertyMgts.Add(pmgt);
                }

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
