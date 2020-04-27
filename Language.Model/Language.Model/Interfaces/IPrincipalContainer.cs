using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Model.Interfaces
{
   public interface IPrincipalContainer
   {
       List<Principal> GetPrincipals();

        void AddPrincipal(Principal principal);

        void RemovePrincipal(Principal principal);
    }
}
