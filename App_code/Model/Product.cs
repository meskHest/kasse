
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string producer { get; set; }
    public int stockNumber { get; set; }
    public string description { get; set; }
    public Department department { get; set; }
    public string tableOfContent { get; set; }
    public decimal price { get; set; }
    public List<Image> image { get; set; }

	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}