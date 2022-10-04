using MongoDB.Driver;

namespace klbhvg.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
