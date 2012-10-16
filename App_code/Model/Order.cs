using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public int id { get; set; }
    public User user { get; set; }
    public Status status { get; set; }
    public int totalPrice { get; set; }
    public DateTime timeForPickup { get; set; }
    public User packedBy { get; set; }
    public DateTime pickupDueTime { get; set; }
    public Cart shoppingCart { get; set; }

	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}