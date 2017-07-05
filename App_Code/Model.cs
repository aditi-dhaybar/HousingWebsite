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

public partial class Block
{
    public int Id { get; set; }
    public string Status { get; set; }
}

public partial class House
{
    public int house_id { get; set; }
    public Nullable<int> zipcode { get; set; }
    public Nullable<int> property_type { get; set; }
    public int added_by { get; set; }
    public Nullable<int> sqft { get; set; }
    public Nullable<int> bath { get; set; }
    public Nullable<int> bed { get; set; }
    public string street_1 { get; set; }
    public string street_2 { get; set; }
    public Nullable<decimal> price { get; set; }
    public Nullable<System.DateTime> year_built { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public byte[] photo_1 { get; set; }
    public byte[] photot_2 { get; set; }
    public byte[] photo_3 { get; set; }
    public Nullable<bool> sold { get; set; }

    public virtual User User { get; set; }
    public virtual PropertyType PropertyType { get; set; }
}

public partial class PropertyType
{
    public PropertyType()
    {
        this.Houses = new HashSet<House>();
    }

    public int pid { get; set; }
    public string type_of_property { get; set; }

    public virtual ICollection<House> Houses { get; set; }
}

public partial class User
{
    public User()
    {
        this.Houses = new HashSet<House>();
    }

    public int user_id { get; set; }
    public string user_name { get; set; }
    public string password { get; set; }
    public int mobile_no { get; set; }
    public string email { get; set; }
    public int user_role { get; set; }
    public Nullable<decimal> amount_due { get; set; }
    public Nullable<int> user_status { get; set; }

    public virtual ICollection<House> Houses { get; set; }
    public virtual UserRole UserRole { get; set; }
    public virtual UserStatu UserStatu { get; set; }
}

public partial class UserRole
{
    public UserRole()
    {
        this.Users = new HashSet<User>();
    }

    public int user_role_id { get; set; }
    public string user_role { get; set; }

    public virtual ICollection<User> Users { get; set; }
}

public partial class UserStatu
{
    public UserStatu()
    {
        this.Users = new HashSet<User>();
    }

    public int Id { get; set; }
    public string Status { get; set; }

    public virtual ICollection<User> Users { get; set; }
}
