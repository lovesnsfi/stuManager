using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace DiDaJiangCheng.Model
{
    //tbUserInfo
    public class tbUserInfo
    {

        /// <summary>
        /// UserId
        /// </summary>		
        private int _userid;
        public int UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// UserName
        /// </summary>		
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// UserPassword
        /// </summary>		
        private string _userpassword;
        public string UserPassword
        {
            get { return _userpassword; }
            set { _userpassword = value; }
        }

    }
}

