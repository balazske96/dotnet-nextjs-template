using System;
using System.Diagnostics.SymbolStore;

namespace web_api_with_react.Extensions
{
    public interface INextJsOptions
    {
        public string Port { get; set; }

        public string Host { get; set; }

        public bool Https { get; set; }

        public string BuildConnectionString();
    }
}