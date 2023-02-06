using MongoDB.Driver;

namespace khggjbjmn.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
