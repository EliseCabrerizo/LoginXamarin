using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Reflection;
using System.Xml.Linq;
using Xamarin.Forms;

namespace LoginLinkedIn.Models
{
    class Constante
    {
        internal string GetClientIdL()
        {
            var type = this.GetType();
            var resource = "LoginLinkedIn" + ".config.xml";
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
            using (var reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("LinkedinIdAuth").Element("clientIdL").Value;
            }
        }
        internal string GetClientSecretL()
        {
            var type = this.GetType();
            var resource = "LoginLinkedIn" + ".config.xml";
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
            using (var reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("LinkedinIdAuth").Element("clientSecretL").Value;
            }
        }
        internal string GetRedirectUrlL()
        {
            var type = this.GetType();
            var resource = "LoginLinkedIn" + ".config.xml";
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
            using (var reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("LinkedinIdAuth").Element("redirectUrlL").Value;
            }
        }
        internal string GetClientIdF()
        {
            var type = this.GetType();
            var resource = "LoginLinkedIn" +  ".config.xml";
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
            using (StreamReader reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("FacebookIdAuth").Element("clientIdF").Value;
            }
        }
        internal string GetRedirectUrlF()
        {
            var type = this.GetType();
            var resource = "LoginLinkedIn" + ".config.xml";
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream(resource))
            using (StreamReader reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("FacebookIdAuth").Element("redirectUrlF").Value;
            }
        }
    }
}
