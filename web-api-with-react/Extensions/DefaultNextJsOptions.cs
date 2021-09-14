namespace web_api_with_react.Extensions
{
    public class DefaultNextJsOptions : INextJsOptions
    {
        public string Port { get; set; } = "3000";
        public string Host { get; set; } = "localhost";
        public bool Https { get; set; } = false;

        public string BuildConnectionString()
        {
            return $"http{(Https ? "s" : "")}://{Host}:{Port}";
        }
    }
}