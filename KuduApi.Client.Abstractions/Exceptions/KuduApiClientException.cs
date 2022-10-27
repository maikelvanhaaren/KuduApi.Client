using System;

namespace KuduApi.Client.Abstractions.Exceptions
{
    public class KuduApiClientException : Exception
    {
        public KuduApiClientException(string message) : base(message)
        {
        }
    }
}