using Review.Domain.Configuration;
using StackExchange.Redis;

namespace Review.Domain.Helper
{
    public class ConnectionHelper
    {
        static ConnectionHelper()
        {
            lazyConnection = new Lazy<ConnectionMultiplexer>(() => 
            {
                return ConnectionMultiplexer.Connect(builder.Configuration.AppSetting["RedisURL"]);
            });
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get => lazyConnection.Value;
        }
    }
}
