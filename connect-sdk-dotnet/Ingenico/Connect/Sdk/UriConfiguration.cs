using System;
using System.Configuration;

namespace Ingenico.Connect.Sdk
{
    class UriConfiguration : ConfigurationElement
    {
        public Uri Uri
        {
            get
            {
                if (_uri != null)
                {
                    return _uri;
                }
                if (Host.Equals(""))
                {
                    // Element not set
                    return null;
                }
                var ub = new UriBuilder();
                ub.Host = Host;
                if (!Scheme.Equals(""))
                {
                    ub.Scheme = Scheme;
                }
                else
                {
                    ub.Scheme = "https";
                }
                if (Port > 0)
                {
                    ub.Port = Port;
                }
                return ub.Uri;
            }
            set
            {
                if (value != null && value.LocalPath != null && value.LocalPath.Length > 1)
                {
                    throw new ArgumentException("apiEndpoint should not contain a path");
                }
                if (value != null && (value.UserInfo != "" || value.Query != ""
                    || value.Fragment != ""))
                {
                    throw new ArgumentException("apiEndpoint should not contain user info, query or fragment");
                }
                _uri = value;
                Scheme = value.Scheme;
                Port = value.Port;
                Host = value.Host;
            }
        }
        Uri _uri;

        [ConfigurationProperty("scheme", IsRequired = false)]
        public string Scheme
        {
            get
            {
                if (_scheme == null)
                {
                    return (string)this["scheme"];

                }
                return _scheme;
            }
            set
            {
                if (IsReadOnly())
                {
                    _scheme = value;
                    return;
                }
                this["scheme"] = value;
            }

        }
        string _scheme;

        [ConfigurationProperty("host", IsRequired = true)]
        public string Host
        {
            get
            {
                if (_host == null)
                {
                    return (string)this["host"];

                }
                return _host;
            }
            set
            {
                if (IsReadOnly())
                {
                    _host = value;
                    return;
                }
                this["host"] = value;
            }

        }
        string _host;

        [ConfigurationProperty("port", IsRequired = false)]
        public int Port
        {
            get
            {
                if (_port == 0)
                {
                    return (int)this["port"];

                }
                return _port;
            }
            set
            {
                if (IsReadOnly())
                {
                    _port = value;
                    return;
                }
                this["port"] = value;
            }

        }
        int _port;

        public UriConfiguration WithScheme(string scheme)
        {
            Scheme = scheme;
            return this;
        }

        public UriConfiguration WithHost(string host)
        {
            Host = host;
            return this;
        }

        public UriConfiguration WithPort(int port)
        {
            Port = port;
            return this;
        }
    }
}
