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

        public async Task<PagedResult<Property>> GetPropertiesPagedAsync(Query query, PropertyFiltersModel? filterModel = null)
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

            if (filterModel != null)
            {

                if (filterModel.StatusId > 0)
                {
                    filteredItems = filteredItems.Where(b => b.Status == filterModel.StatusId);
                }

                if (!string.IsNullOrWhiteSpace(filterModel.OwnerLastName))
                {
                    filteredItems = filteredItems.Where(b => b.Agent.FirstName.Contains(filterModel.OwnerLastName) );
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Address))
                {
                    filteredItems = filteredItems.Where(b => b.Address.Contains(filterModel.Address));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Sleeps))
                {
                    filteredItems = filteredItems.Where(b => b.Sleeps.Contains(filterModel.Sleeps));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.BedRooms))
                {
                    filteredItems = filteredItems.Where(b => b.Bedrooms.Contains(filterModel.BedRooms));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Baths))
                {
                    filteredItems = filteredItems.Where(b => b.Baths.Contains(filterModel.Baths));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.OwnerEmail))
                {
                    filteredItems = filteredItems.Where(b => b.Agent.Email.Contains(filterModel.OwnerEmail));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.PropertyName))
                {
                    filteredItems = filteredItems.Where(b => b.Name.Contains(filterModel.PropertyName));
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
                .OrderBy(x=>x.Name)
                .ToList();

            return items;
        }

        public async Task<List<AgentStatusDropDownValues>> GetAgentStatusDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Statuses
                .Select(x => new AgentStatusDropDownValues
                {
                    StatusId = x.Statusid,
                    StatusName = x.Status1
                })
                .OrderBy(x=>x.StatusName)
                .ToList();

            return items;
        }

        public async Task<List<AgentStatusDropDownValues>> GetStatusDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Statuses
                .Select(x => new AgentStatusDropDownValues
                {
                    StatusId = x.Statusid,
                    StatusName = x.Status1
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
            }).OrderBy(x=>x.Type).ToList();

            return items;
        }

        public async Task<List<OwnerLoginDDValues>> GetOwnerDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = context.Tenants.Where(x=>x.Role > 23).Select(x => new OwnerLoginDDValues
            {
                TenantId = x.Tenantid,
                OwnerName = x.Firstname +" "+ x.Lastname
            }).OrderBy(x=>x.OwnerName).ToList();

            return items;
        }

        public async Task<List<PropertyCleanerDDValues>> GetPropertyCleanerDropDownValues()
        {
            using var context = dbContextFactory.CreateDbContext();
            var items = context.PropertyCleaners.Where(x=>x.Firstname != null || x.Lastname != null).Select(x => new PropertyCleanerDDValues
            {
                CleanerId = x.Cleanerid,
                Name = x.Firstname + " " + x.Lastname
            }).OrderBy(x=>x.Name).ToList();

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
