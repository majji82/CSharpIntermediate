﻿namespace Classes
{
    public class HttpCookieIndexer
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookieIndexer()
        {
            _dictionary = new Dictionary<string, string>();   
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}