using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Model
{

    public class Person : Principal
    {
        public Person(Title title, Email email, Password password, Profile profile, List<Package> packages,Object_Key objectKey) : base(
            title, email, password, profile, packages,objectKey)
        {
        }
    }
 
   
}
