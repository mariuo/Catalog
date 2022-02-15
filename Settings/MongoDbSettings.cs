namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public String User { get; set; }
        public String Password { get; set; }

        public string ConnectionString { get
            {
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
                
            }
        }
    }
}
