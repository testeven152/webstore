﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Cart
{
    public int ID { get; set; }
    public string ClientID { get; set; }
    public int ProductID { get; set; }
    public int Amount { get; set; }
    public System.DateTime DatePurchased { get; set; }
    public bool IsInCart { get; set; }
}

public partial class Product
{
    public int ID { get; set; }
    public Nullable<int> TypeID { get; set; }
    public string Name { get; set; }
    public Nullable<double> Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Size { get; set; }
}

public partial class ProductType
{
    public int ID { get; set; }
    public string Name { get; set; }
}
