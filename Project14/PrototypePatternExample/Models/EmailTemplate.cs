using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.Models
{
    public class EmailTemplate : ICloneable
    {
        public string Header {get;set;}
        public string Footer {get;set;}
        public string Subject {get;set;}
        public string Body {get; set;}

        public EmailTemplate(string header, string footer)
        {
            Header = header;
            Footer = footer;
        }
        public object Clone()
        {
            return (EmailTemplate)this.MemberwiseClone();
        }

        public void Send(string recipient)
        {
            Console.WriteLine($"Sending email to: {recipient}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Footer: {Footer}");
        }

        


    }

}