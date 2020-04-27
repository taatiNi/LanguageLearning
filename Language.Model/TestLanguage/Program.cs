using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Language.Data;
using Language.Domain;

namespace TestLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestProgram(new LanguageEntityContext());
            Console.WriteLine("Test has run successfully!");

        }

        static void TestProgram(LanguageEntityContext _context)
        {
            var principal = new Principal()
            {
                Name = "niloofar", Email = "niloofartaati@gmail.com", Login = "taati_n", Password = "1"
                ,
                Profile =
                    new Profile
                    {
                        Summary = new Summary() { Body = "For Test" },
                        Experiences = new List<Experience>()
                        {

                            new Experience()
                                {Body = "Rayvarz", DateModify = DateTime.Now, StarTime = DateTime.Now.AddDays(-1000)}
                        }
                    }
            };
            var secondprincipal = new Principal()
            {
                Name = "morteza",
                Email = "mortezakhademi@gmail.com",
                Login = "khademi_m",
                Password = "1",
                Profile =
                    new Profile
                    {
                        Summary = new Summary() { Body = "For Test" },
                        Experiences = new List<Experience>()
                        {

                            new Experience()
                                {Body = "FireStation", DateModify = DateTime.Now, StarTime = DateTime.Now.AddDays(-1000)}
                        }
                    }
            };
            _context.Add(principal);
            var package = new Package()
            {
                Title = "It",
                PackagePrincipals = new List<Package_Principal>()
                {
                    //test
                    new Package_Principal(){Principal = principal,}
                },
            };
            var message = new Message()
            {
                Package = package,

                Sender = principal,
                Receiver = secondprincipal
            };
            _context.Add(message);
            package.PackagePrincipals.Add(new Package_Principal() { Principal = secondprincipal, });
            _context.Update(package);
            _context.SaveChanges();


        }
    }
}
