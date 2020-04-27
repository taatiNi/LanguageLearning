using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Interfaces;

namespace Language.Model
{
    public class Package : IModel, IPrincipalContainer
    {

        private Word_Value _wordValue;
        private readonly Title _title;
        private readonly List<Principal> _principals;

        public Object_Key object_Key { get; private set; }


        public Package(Word_Value wordValue, Title title, List<Principal> principals, Object_Key objectKey)
        {
            ChangeWord_Value(wordValue);
            _title = title;
            _principals = principals;
            object_Key = objectKey;
        }
        public void ChangeWord_Value(Word_Value value) => _wordValue = value;
        public Word_Value GetWord_Value() => _wordValue;
        public Title GetTitle() => _title;

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
