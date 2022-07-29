using MongoDB.Driver;

namespace PullReqTest.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
