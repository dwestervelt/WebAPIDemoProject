using LiteDB;

namespace WebAPIDemoProject.LiteDB
{
    public interface ILiteDbContext
    {
        LiteDatabase Database { get; }
    }
}