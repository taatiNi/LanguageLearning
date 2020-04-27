using System;
using System.Collections.Generic;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Interfaces;
using Language.Model.Structures;
using System.Linq;

namespace Language.Model
{
    public class Group : Principal, IPrincipalContainer
    {
        private readonly List<Principal> _principals;
        public Group(Title title, Email email, Password password, Profile profile, List<Package> packages, List<Principal> principals, Object_Key objectKey) : base(title,
            email, password, profile, packages, objectKey)
        {
            _principals = principals;
        }
        public void AddPrincipal(Principal principal)
        {
            if (principal == null)
                throw new NullException("principal is null");
            if (_principals == null)
                throw new NullException("Principals are null");

            if (_principals.All(x => x.object_Key.Value != principal.object_Key.Value))
                _principals.Add(principal);
        }

        public void RemovePrincipal(Principal principal)
        {
            if (principal == null)
                throw new NullException("principal is null!");
            if (_principals == null)
                throw new NullException("principals are null!");
            if (!_principals.Contains(principal))
                throw new CustomException("this principal is already exists");
            _principals.Remove(principal);
        }
        public List<Principal> GetPrincipals() => _principals;

    }
}
