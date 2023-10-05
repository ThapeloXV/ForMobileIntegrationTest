﻿namespace IntegrationTest.Models
{
    internal class HttpResponse<T>
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public T Data { get; set; }
    }
}