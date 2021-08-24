using System.Collections.Generic;

namespace WebAPIDemoProject.LiteDB
{
    public interface ILiteDbContactsService
    {
        int Delete(int id);
        IEnumerable<Contacts> FindAll();
        Contacts FindOne(int id);
        int Insert(Contacts contact);
        bool Update(Contacts contact);

    }
}