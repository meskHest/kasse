using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
	public User()
	{
		public int userId { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int personalNumber { get; set; }
	    public string email { get; set; }
        public int mobilPhone { get; set; }
        public int homePhone { get; set; }
        public bool gender { get; set; }
    }
}