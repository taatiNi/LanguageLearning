using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Interfaces;

namespace Language.Model
{
    public class Experience : IModel
    {
        public Object_Key object_Key { get; private set; }

        private Date_Time _start;
        private Date_Time _end;
        private readonly Date_Time _dateModify;
        private Body _body;
        public Experience(Date_Time start, Date_Time end, Date_Time dateModify, Body body, Object_Key objectKey)
        {
            if (end.Value <= start)
                throw new CustomException("Start date can not be after that end time");
            _start = start;
            _end = end;
            _dateModify = dateModify;
            _body = body;
            object_Key = objectKey;
        }

        public Date_Time GetStarTime() => _start;

        public void ChangeStartTime(Date_Time dateTime)
        {
            if (dateTime.Value > _end)
                throw new CustomException("Start date can not be after that end time");
            _start = dateTime;
        }
        public Date_Time GetEndTime() => _end;
        public void ChangeEndTime(Date_Time dateTime)
        {
            if (dateTime.Value <= _start)
                throw new CustomException("Start date can not be after that end time");
            _end = dateTime;
        }

        public Date_Time GetDateModify() => _dateModify;
        public Body GetBody() => _body; 
        public void ChangeBody(Body body) => _body = body;
    }

}
