using System;
using System.Collections.Generic;
using System.Text;

namespace Language.Model.Interfaces
{
   public interface IExperienceContainer
   {
       List<Experience> GetExperiences();

        void AddExperience(Experience experience);

        void RemoveExperience(Experience experience);
    }
}
