namespace Dapper.Framework
{
    public class ConnectionString
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool IntegratedSecurity { get; set; }

        public ConnectionString()
        {
            if (Port == 0)
                Port = 1344;
        }
    }
}