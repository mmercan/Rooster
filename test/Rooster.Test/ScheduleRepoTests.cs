using System;
using Rooster.Data;
using Rooster.Data.Repositories;
using System.Linq;
using Xunit;
namespace Rooster.Test
{
    public class ScheduleRepoTests
    {
        private ScheduleRepo repo = new ScheduleRepo(new CrmEntities());

        [Fact]
        public void GetAll()
        {
            var items = repo.GetAll().ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }

        [Fact]
        public void Get()
        {
            var item = repo.Find(Guid.Parse("5AC23629-2ADF-E211-9400-00155D010D1C"));
            Assert.False(string.IsNullOrEmpty(item.Name));
        }

        [Fact]
        public void GetSelectedMonth()
        {
            //todo:observe with profiler for performance
            var items = repo.GetMonthSchedule(DateTime.Now).ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }


        [Fact]
        public void GetConfirmedMonthSchedule()
        {
            //todo:observe with profiler for performance
            var items = repo.GetConfirmedMonthSchedule(DateTime.Now).ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
    }
}