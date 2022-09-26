using MongoDB.Driver;

namespace testdotnet.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
