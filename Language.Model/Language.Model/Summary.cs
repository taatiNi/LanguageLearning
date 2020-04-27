using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Text;
using Language.Model.Interfaces;

namespace Language.Model
{

    public class Summary : IModel
    {

        private readonly Date_Time _dateModify;
        private Body _body;
        public Object_Key object_Key { get; private set; } 

        public Summary(Date_Time dateModify, Body body, Object_Key objectKey)
        {
            _dateModify = dateModify;
            _body = body;
            object_Key = objectKey;
        }
        public Date_Time GetDateTime() => _dateModify;
        public Body GetBody() => _body;
        public void ChangeBody(Body body) => _body = body;
    }


}
