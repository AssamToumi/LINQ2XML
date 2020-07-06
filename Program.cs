using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ2XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("database\\Products.xml");

            xdoc.Descendants("product").Where(p => p.Element("name").Value.Contains 
            ("Apple")).Select(p => new 
                {
                    id= p.Attribute("id").Value,
                    name= p.Element("name").Value,
                    price= p.Element("Price").Value,
                    currency= p.Element("Price").Attribute("currency").Value
                }).ToList().ForEach(p =>
                {
                    Console.WriteLine("Id:" + p.id);
                    Console.WriteLine("name:" + p.name);
                    Console.WriteLine("Price:" + p.price);
                    Console.WriteLine("currency:" + p.currency);
                    Console.WriteLine("***********");
                });
            /*
                xdoc.Descendants("product").Select(p => (
                id= p.Attribute("id").Value,
                name= p.Element("name").Value,
                price= p.Element("Price").Value,
                currency= p.Element("Price").Attribute("currency").Value
            )).ToList().ForEach(p => {
                Console.WriteLine("Id:" + p.id);
                Console.WriteLine("name:" + p.name);
                Console.WriteLine("Price:" + p.price);
                Console.WriteLine("currency:" + p.currency);
                 Console.WriteLine("***********");
                
            });
            */
            // using conditions

            Console.ReadLine();
        }
    }
}
