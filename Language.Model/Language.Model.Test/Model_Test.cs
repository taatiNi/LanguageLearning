using System;
using System.Collections.Generic;
using Language.Infrastructure.Exception;
using Language.Model.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Language.Model.Test
{
    [TestClass]
    public class Model
    {
        private Package GetPackage()
        {
            return new Package("and", "æ", new List<Principal>(), GetObjectKey());
        }
        private Person GetPerson()
        {
            return new Person("niloofar", "niloofar@gmail.com", "123456", GetProfile(), new List<Package>(), GetObjectKey());
        }
        private Object_Key GetObjectKey()
        {
            return new Object_Key(Guid.NewGuid());
        }
        private Summary GetSummary()
        {
            return new Summary(dateModify: DateTime.Now,
                "salam", GetObjectKey());
        }
        private Profile GetProfile()
        {
            return new Profile(GetSummary(), new List<Experience>(), DateTime.Now,
                   GetObjectKey());
        }
        private Group GetGroupInstance()
        {
            return new Group("test", "test@yahoo.com", "123456", profile: GetProfile(), new List<Package>(), new List<Principal>(), GetObjectKey());
        }
        private Experience GetExprience()
        {
            return new Experience(DateTime.Now.AddDays(-5), DateTime.Now, DateTime.Now, "test", GetObjectKey());
        }
        #region Group
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_add_Principal()
        {
            GetGroupInstance().AddPrincipal(null);
        }
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_remove_null_from_principals()
        {
            GetGroupInstance().RemovePrincipal(null);
        }
        [TestMethod]
        public void you_can_not_pass_repeated_principal_to_principals()
        {
            var p = GetPerson();
            var g = GetGroupInstance();
            g.AddPrincipal(p);
            g.AddPrincipal(p);
            Xunit.Assert.Single(g.GetPrincipals());
        }
        #endregion

        #region Experience
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void start_date_can_not_be_more_than_end_date()
        {
            var ex = GetExprience();
            ex.ChangeEndTime(DateTime.Now.AddDays(-10));
        }
        public void end_date_can_not_be_less_than_start_date()
        {
            var ex = GetExprience();
            ex.ChangeStartTime(DateTime.Now.AddDays(20));
        }
        #endregion

        #region profile
        public void you_can_not_pass_null_to_add_experiences()
        {
            GetProfile().AddExperience(null);
        }
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_remove_null_from_experiences()
        {
            GetProfile().RemoveExperience(null);
        }
        [TestMethod]
        public void you_can_not_pass_repeated_experience_to_experiences()
        {
            var ex = GetExprience();
            var p = GetProfile();
            p.AddExperience(ex);
            p.AddExperience(ex);
            Xunit.Assert.Single(p.GetExperiences());
        }
        #endregion

        #region Principal
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_add_package()
        {
            GetPerson().RemovePackage(null);
        }
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_remove_null_from_packages()
        {
            GetPerson().RemovePackage(null);
        }
        [TestMethod]
        public void you_can_not_pass_repeated_package_to_packages()
        {
            var person = GetPerson();
            var p = GetPackage();
            person.AddPackage(p);
            person.AddPackage(p);
            Xunit.Assert.Single(person.GetPackages());
        }

        #endregion

        #region Package

        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_add_Principal_to_package()
        {
            GetPackage().AddPrincipal(null);
        }
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_remove_null_from_principals_of_package()
        {
            GetPackage().RemovePrincipal(null);
        }
        [TestMethod]
        public void you_can_not_pass_repeated_principal_to_principals_of_package()
        {
            var person = GetPerson();
            var p = GetPackage();
            p.AddPrincipal(person);
            p.AddPrincipal(person);
            Xunit.Assert.Single(p.GetPrincipals());
        }

        #endregion
    }
}
