using Language.Model.Structures;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Language.Model.Interfaces;

namespace Language.Model
{

    public class Message : IModel
    {
        public Object_Key object_Key { get; private set; } 
        private readonly Date_Time _dateTime;
        private readonly Package _package;
        private readonly Principal _sender;
        private readonly Principal _receiver;

        public Message(Date_Time dateTime, Package package, Principal sender, Principal receiver, Object_Key id)
        {
            _dateTime = dateTime;
            _package = package;
            _sender = sender;
            _receiver = receiver; 
            object_Key = id;
        }

        public Package GetPackage() => _package;
        public Principal GetReceiver() => _receiver;
        public Principal GetSender() => _sender;
        public Date_Time GetMessageDateTime() => _dateTime;


    }
}
