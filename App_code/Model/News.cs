using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for News
/// </summary>
public class News
{
    public int id { get; set; }
    public int storeId { get; set; }
    public int userId { get; set; }
    public DateTime created { get; set; }
    public string headline { get; set; }
    public string message { get; set; }
    public List<Image> image { get; set; }

	public News()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}