using MongoDB.Driver;

namespace jkhugyjfhgdf.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
