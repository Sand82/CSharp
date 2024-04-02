namespace Play.catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }

        public int Port { get; init; }

        public string ConectionString => string.Format($"mongodb://{0}:{1}", Host, Port);
    }
}