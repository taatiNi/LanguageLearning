using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Language.Infrastructure.Exception;
using Language.Model.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using NullException = Language.Infrastructure.Exception.NullException;

namespace Language.Model.Test
{
    [TestClass]
    public class Structurs_Test
    {
        #region Title
        //[Fact]
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_title()
        {
            Title title = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ExceedCapacityException))]
        public void you_can_not_pass_MoreThan50Character_to_title()
        {
            Title title = new StringBuilder(51).Insert(0, "a", 51).ToString();
        }
        #endregion

        #region password
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_password()
        {
            Password password = "";
        }
        [TestMethod]
        [ExpectedException(typeof(ExceedCapacityException))]
        public void you_can_not_pass_more_than_12_to_password()
        {
            Password password = new StringBuilder(13).Insert(0, "a", 13).ToString();
        }
        #endregion

        #region email
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_email()
        {
            Email email = "";
        }
        [TestMethod]
        [ExpectedException(typeof(ExceedCapacityException))]
        public void you_can_not_pass_more_than_500_Character_to_email()
        {
            Email email = new StringBuilder(501).Insert(0, "a", 501).ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ValueFormatException))]
        public void you_can_not_pass_unformatted_character_to_email()
        {
            Email email = new StringBuilder(5).Insert(0, "a", 5).ToString();
        }
        [TestMethod]
        public void you_can_set_email()
        {
            var e = "niloofartaati@gmail.com";
            Email email = e;
            AreEqual(email.Value, e);
        }
        #endregion

        #region body
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_body()
        {
            Body body = "";
        }
        [TestMethod]
        [ExpectedException(typeof(ExceedCapacityException))]
        public void you_can_not_pass_more_than_1000_character_to_body()
        {
            Body body = new StringBuilder(1001).Insert(0, "a", 1001).ToString();
        }
        #endregion
      
        #region word_value
        [TestMethod]
        [ExpectedException(typeof(NullException))]
        public void you_can_not_pass_null_to_word_value()
        {
            Word_Value value = "";
        }
        [TestMethod]
        [ExpectedException(typeof(ExceedCapacityException))]
        public void you_can_not_pass_more_than_220_character_to_word_value()
        {
            Word_Value body = new StringBuilder(221).Insert(0, "a", 221).ToString();
        }
        #endregion
    }

}
