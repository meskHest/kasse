using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shoppinglist
/// </summary>
public class Shoppinglist
{
    public int id { get; set; }
    public string name { get; set; }
    public DateTime date { get; set; }
    public int totalPrice { get; set; }
    public int userId { get; set; }
    public List<Product> lstProducts { get; set; }

	public Shoppinglist()
	{
		
	}
}