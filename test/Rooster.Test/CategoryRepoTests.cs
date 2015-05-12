using System;
using Rooster.Data;
using Rooster.Data.Repositories;
using System.Linq;
using Xunit;
namespace Rooster.Test
{
    public class CategoryRepoTests
    {
        private CategoryRepo repo = new CategoryRepo(new CrmEntities());

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
    }
}