using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPIDemoProject.LiteDB
{
    public class LiteDbContactsService : ILiteDbContactsService
    {
        private LiteDatabase _liteDb;

        public LiteDbContactsService(ILiteDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }

        public IEnumerable<Contacts> FindAll()
        {
            var result = _liteDb.GetCollection<Contacts>("Contacts")
                 .FindAll();
            return result;
        }

        public Contacts FindOne(int id)
        {
            var collection = _liteDb.GetCollection<Contacts>("Contacts")
            .Find(x => x.Id == id).FirstOrDefault();

            return collection;
        }

        public int Insert(Contacts contact)
        {
            return _liteDb.GetCollection<Contacts>("Contacts")
                .Insert(contact);
        }

        public bool Update(Contacts contact)
        {
            return _liteDb.GetCollection<Contacts>("Contacts")
                .Update(contact);
        }

        public int Delete(int id)
        {
            return _liteDb.GetCollection<Contacts>("Contacts")
                .DeleteMany(x => x.Id == id);
        }

    }

}
