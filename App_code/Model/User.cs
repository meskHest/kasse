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
		public int Id { get; set; }
        public string Fname { get; set; }
        public string Ename { get; set; }
        public string pass { get; set; }
        public int socialNumber { get; set; }
	    public string email { get; set; }
        public int cellphone { get; set; }
        public int homeNr { get; set; }
        public bool gender { get; set; }
        public string adress { get; set; }
        public int zipCode { get; set; }
        public int roleId { get; set; }
        public List<role> roles { get; set; }
    }
}