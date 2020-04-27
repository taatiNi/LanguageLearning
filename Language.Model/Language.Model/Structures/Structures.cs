using Language.Infrastructure.Exception;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Language.Model.Structures
{
    public struct Title
    {
        public string Value { get; }

        public Title(string value)
        {
            CheckValue(value);
            Value = value;
        }
        public static implicit operator string(Title title)
        {
            return title.Value;
        }
        public static implicit operator Title(string s)
        {
            CheckValue(s);
            return new Title(s);
        }

        private static void CheckValue(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new NullException("Title must be assigned");
            if (s.Length > 50)
                throw new ExceedCapacityException("Title must be less than 50 character");
        }
    }
    public struct Email
    {
        public string Value { get; }

        public static implicit operator Email(string s)
        {
            CheckValue(s);
            return new Email(s);
        }

        public static implicit operator string(Email p)
        {
            return p.Value;
        }
        public Email(string value)
        {
            CheckValue(value);
            Value = value;
        }
        private static void CheckValue(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new NullException("Email must be assigned");


            if (s.Length > 500)
                throw new ExceedCapacityException("Email must be less than 50 character");

            if (!Regex.IsMatch(s,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                throw new ValueFormatException("Email Format is incorrect");
            }
        }
    }
    public struct Password
    {
        public string Value { get; }

        public Password(string value)
        {
            CheckValue(value);
            Value = value;
        }
        public static implicit operator string(Password p)
        {
            return p.Value;
        }
        public static implicit operator Password(string s)
        {
            CheckValue(s);
            return new Password(s);
        }
        private static void CheckValue(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new NullException("Password must be assigned");

            if (s.Length > 12)
                throw new ExceedCapacityException("Password must be less than 12 character");
        }
    }
    public struct Body
    {
        public string Value { get; }

        public Body(string value)
        {
            CheckValue(value);
            Value = value;
        }
        public static implicit operator string(Body p)
        {
            return p.Value;
        }
        public static implicit operator Body(string s)
        {
            CheckValue(s);
            return new Body(s);
        }
        private static void CheckValue(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new NullException("Body must be assigned");

            if (s.Length > 1000)
                throw new ExceedCapacityException("Title must be less than 1000 character");
        }
    }
    public struct Date_Time
    {
        public DateTime Value { get; }

        public Date_Time(DateTime value)
        {
            Value = value;
        }
        public static implicit operator DateTime(Date_Time p)
        {
            return p.Value;
        }
        public static implicit operator Date_Time(DateTime d)
        {
            return new Date_Time(d);
        }
    }
    public struct Word_Value
    {
        public string Value { get; }

        public Word_Value(string value)
        {
            CheckValue(value);
            Value = value;
        }
        public static implicit operator string(Word_Value p)
        {
            return p.Value;
        }
        public static implicit operator Word_Value(string s)
        {
            CheckValue(s);
            return new Word_Value(s);
        }

        private static void CheckValue(string s)
        {
            if (String.IsNullOrEmpty(s))
                throw new NullException("Value must be assigned");

            if (s.Length > 220)
                throw new ExceedCapacityException("Title must be less than 220 character");
        }
    }
    public class Object_Key
    {
        public object Value { get; private set; }

        public Object_Key(object value)
        {
            Value = value ?? throw new NullException("Key Value must be assigned");
        } 
    }
}
