﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int id { get; set; }
    public string fName { get; set; }
    public string lName { get; set; }
    public string pass { get; set; }
    public int socialNumber { get; set; }
    public string email { get; set; }
    public int cellphone { get; set; }
    public int homeNr { get; set; }
    public bool gender { get; set; }
    public string adress { get; set; }
    public int zipCode { get; set; }
    public Role role { get; set; }

	public User()
	{

    }
}