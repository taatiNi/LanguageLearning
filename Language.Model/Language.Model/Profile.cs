using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Interfaces;
using System.Linq;

namespace Language.Model
{

    public class Profile : IModel, IExperienceContainer
    {
        private readonly List<Experience> _experiences;
        private readonly Principal _principal;
        private readonly Summary _summary;
        private readonly Date_Time _dateModify;

        public Object_Key object_Key { get; private set; }


        public Profile(Summary summary, List<Experience> experiences, Date_Time dateModify, Object_Key objectKey)
        {
            _summary = summary;
            _experiences = experiences;
            _dateModify = dateModify;
            object_Key = objectKey;
        }
        public void AddExperience(Experience experience)
        {
            if (experience == null)
                throw new NullException("experience is null");
            if (_experiences == null)
                throw new NullException("experiences is null");
            if (_experiences.All(x => x.object_Key.Value != experience.object_Key.Value))
                _experiences.Add(experience);
        }

        public void RemoveExperience(Experience experience)
        {
            if (experience == null)
                throw new NullException("experience is null");
            if (_experiences == null)
                throw new NullException("experiences is null");
            if (!_experiences.Contains(experience))
                throw new CustomException("The list don't contain this item");
            _experiences.Remove(experience);
        }
        public List<Experience> GetExperiences() =>
            _experiences;
        public Date_Time GetDateModify() => _dateModify;
        public Summary GetSummary() => _summary;

    }
}
