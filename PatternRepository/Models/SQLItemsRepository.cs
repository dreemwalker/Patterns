using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PatternRepository.Models
{
    public class SQLItemsRepository : IRepository<Item>
    {
        private ItemsContext db;

        public SQLItemsRepository(DbContextOptions<ItemsContext> options)
        {
            this.db = new ItemsContext(options);
        }

        Item IRepository<Item>.GetItem(int id)
        {
            return db.Items.Find(id);
        }

        public IEnumerable<Item> GetItems()
        {
            return db.Items;
        }

        public void Create(Item item)
        {
             db.Add(item);
        }

        public void Update(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        void IRepository<Item>.Delete(int id)
        {
            Item item = db.Items.Find(id);
            if (item != null)
                db.Items.Remove(item);
        }

        void IRepository<Item>.Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

      

      

       

     
    }
}
