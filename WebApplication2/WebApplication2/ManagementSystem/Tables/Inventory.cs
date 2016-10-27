using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "Inventory")]
    public class Inventory
    {
            private int? _ProductID;
            [Column(Storage = "_ProductID")]
            public int? ProductID
            {
                get
                {
                    return this._ProductID;
                }
                set
                {
                    this._ProductID = value;
                }
            }
            private string _ProductName;
            [Column(Storage = "_ProductName")]
            public string ProductName
            {
                get
                {
                    return this._ProductName;
                }
                set
                {
                    this._ProductName = value;
                }
            }
            private string _SectionNumber;
            [Column(Storage = "_SectionNumber")]
            public string SectionNumber
            {
                get
                {
                    return this._SectionNumber;
                }
                set
                {
                    this._SectionNumber = value;
                }
            }
            private string _Brand;
            [Column(Storage = "_Brand")]
            public string Brand
            {
                get
                {
                    return this._Brand;
                }
                set
                {
                    this._Brand = value;
                }
            }
            private string _Model;
            [Column(Storage = "_Model")]
            public string Model
            {
                get
                {
                    return this._Model;
                }
                set
                {
                    this._Model = value;
                }
            }
            private int? _Qty;
            [Column(Storage = "_Qty")]
            public int? Qty
            {
                get
                {
                    return this._Qty;
                }
                set
                {
                    this._Qty = value;
                }
            }
        }
    }

