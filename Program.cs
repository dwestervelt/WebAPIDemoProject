using LiteDB;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemoProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create contact record
            // Opens database (or creates if not exits)
            using (var db = new LiteDatabase(@"LiteDB/MyData.db"))
            {
                // Get user collection
                var contacts = db.GetCollection<Contacts>("Contacts");
                // Create new customer instance

                /////name
                //ContactsName name = new ContactsName
                //{
                //    First = "Harold",
                //    Middle = "Francis",
                //    Last = "Gilkey",
                //};

                //////address
                //ContactsAddress address = new ContactsAddress
                //{
                //    Street = "8360 High Autumn Row",
                //    City = "Cannon",
                //    State = "Delaware",
                //    Zip = "19797"
                //};

                //////phone list of two numbers
                //List<ContactsPhone> phones = new List<ContactsPhone>();
                //ContactsPhone phone = new ContactsPhone();
                //phone.Number = "302-611-9148";
                //phone.Type = "home";
                //phones.Add(phone);
                //phone.Number = "302-532-9427";
                //phone.Type = "mobile";
                //phones.Add(phone);

                //////email
                //ContactsEmail email = new ContactsEmail();
                //email.Email = "harold.gilkey@yahoo.com";

                //var cont = new Contacts
                //{
                //    Name = name,
                //    Address = address,
                //    Phone = phones,
                //    Email = email
                //};

                ////Insert new user document(Id will be auto - incremented)
                //contacts.Insert(cont);

                //var result = contacts.Find(x => x.First == "Harold").FirstOrDefault();

                // Update a document inside a collection
                //cont.First = "Harold";
                //contacts.Update(cont);

                // Index document using a document property
                //contacts.EnsureIndex(x => x.First);
            }


            ////testing collection names and contact list
            using (var db = new LiteDatabase(@"LiteDB/MyData.db"))
            {

                ////var test = db.GetCollectionNames();
                //var collection = db.GetCollection<Contacts>("Contacts");
                //var contact = collection.FindAll();

                ////delete all records
                //var delete = collection.DeleteAll();

                //var blah = contact;
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
