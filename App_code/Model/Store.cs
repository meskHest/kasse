using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Store
/// </summary>
public class Store
{
    public int id { get; set; }
    public string name { get; set; }
    public string adress { get; set; }
    public string info { get; set; }
    public bool active { get; set; }
    public List<Image> image { get; set; }
    
    public Store()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}