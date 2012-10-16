using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart
{
    public int id { get; set; }
    public User user { get; set; }
    public List<Product> lstProducts { get; set; }


	public Cart()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}