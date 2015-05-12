using Rooster.Data;
using System.Linq;
using Xunit;

namespace Rooster.Test
{
    public class CrmEntitiesTests
    {
        private CrmEntities db = new CrmEntities();


        [Fact]
        public void GetCategorySet()
        {
            var items = db.CategorySet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }

        [Fact]
        public void GetCitySet()
        {
            var items = db.CitySet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }

        [Fact]
        public void GetCountrySet()
        {
            var items = db.CountrySet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetCurrencySet()
        {
            var items = db.CurrencySet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetDeliveryTypeSet()
        {
            var items = db.DeliveryTypeSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetInstructorSet()
        {
            var items = db.InstructorSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetPriceListSet()
        {
            var items = db.PriceListSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetPriceSet()
        {
            var items = db.PriceSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetProductSet()
        {
            var items = db.ProductSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetRegionSet()
        {
            var items = db.RegionSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetSchedulePublishSet()
        {
            var items = db.SchedulePublishSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetScheduleSet()
        {
            var items = db.ScheduleSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetScheduleStatusSet()
        {
            var items = db.ScheduleStatusSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetScheduleTypeSet()
        {
            var items = db.ScheduleTypeSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetStateSet()
        {
            var items = db.StateSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetStudentFinanceStatusSet()
        {
            var items = db.StudentFinanceStatusSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetStudentOperationStatusSet()
        {
            var items = db.StudentOperationStatusSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetStudentSet()
        {
            var items = db.StudentSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetTechnologySet()
        {
            var items = db.TechnologySet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetUnitSet()
        {
            var items = db.UnitSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
        [Fact]
        public void GetVendorSet()
        {
            var items = db.VendorSet.ToList();
            var count = items.Count;
            Assert.True(count > 0);
        }
    }
}