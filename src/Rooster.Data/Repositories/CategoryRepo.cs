using Microsoft.Data.Entity;
using Rooster.Extensions.Repository;
using Rooster.Model.CRM;

namespace Rooster.Data.Repositories
{
    public class CategoryRepo: Repository<Category>
    {
        public CategoryRepo(DbContext db):base(db)
        {
            
        }
    }
}