using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Goal
/// </summary>
public class Goal
{
    public int id { get; set; }
    public string product { get; set; }
    public int amount { get; set; }
    public int discount { get; set; }
    public int campaignId { get; set; }


	public Goal()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}