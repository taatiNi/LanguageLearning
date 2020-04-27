using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Interfaces;
using Language.Model.Structures;
using System.Linq;

namespace Language.Model
{
    public abstract class Principal : IModel
    {
        public Object_Key object_Key { get; private set; }

        private Title _title;
        private Email _email;
        private Password _password;
        private readonly Profile _profile;
        private readonly List<Package> _packages;
        protected Principal(Title title, Email email, Password password, Profile profile, List<Package> packages, Object_Key objectKey)
        {
            _title = title;
            _email = email;
            _password = password;
            _profile = profile;
            _packages = packages;
            object_Key = objectKey;
        }

        public void SeTitle(Title title) => _title = title;
        public Title GeTitle() => _title;
        public void SePassword(Password password) => _password = password;
        public Password GetPassword() => _password;
        public void SetEmail(Email email) => _email = email;
        public Email GetEmail() => _email;
        public void AddPackage(Package package)
        {
            if (_packages == null)
                throw new NullException("Packages are null!");
            if (package == null)
                throw new NullException("Package is null!");
            if (_packages.All(p => p.object_Key.Value != package.object_Key.Value))
                _packages.Add(package);
        }

        public void RemovePackage(Package package)
        {
            if (_packages == null)
                throw new NullException("Packages are null!");
            if (package == null)
                throw new NullException("Package is null!");
            if (!_packages.Contains(package))
                throw new CustomException("Packages don't contain this item");
            _packages.Remove(package);
        }

        public List<Package> GetPackages() => _packages;



    }
}
