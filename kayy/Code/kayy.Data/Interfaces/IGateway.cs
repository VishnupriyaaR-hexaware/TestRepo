using MongoDB.Driver;

namespace kayy.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
