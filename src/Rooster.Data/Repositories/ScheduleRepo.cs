using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Rooster.Extensions.Repository;
using Rooster.Model.CRM;

namespace Rooster.Data.Repositories
{
    public class ScheduleRepo : Repository<Schedule>
    {
        public ScheduleRepo(DbContext db):base(db)
        {

        }

        public IQueryable<Schedule> GetMonthSchedule(DateTime dateofMonth)
        {
            DateTime startofMonth = dateofMonth.Date.AddDays(1-dateofMonth.Day);
            DateTime endofMonth = dateofMonth.Date.AddMonths(1).AddDays(-dateofMonth.Day);
           return this.GetAll().Where(p => p.StartDate > startofMonth && p.EndDate < endofMonth);
        }

        public IQueryable<Schedule> GetConfirmedMonthSchedule(DateTime dateofMonth)
        {
            DateTime startofMonth = dateofMonth.Date.AddDays(1 - dateofMonth.Day);
            DateTime endofMonth = dateofMonth.Date.AddMonths(1).AddDays(-dateofMonth.Day);
            return this.GetAll().Where(p => p.StartDate > startofMonth && p.EndDate < endofMonth && p.Status== 102880005);
        }

    }
}
