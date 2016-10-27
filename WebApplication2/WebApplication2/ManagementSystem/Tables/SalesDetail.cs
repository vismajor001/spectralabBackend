using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
   
        [Table(Name = "SalesDetail")]
        public class SalesDetail
        {

            private int _InvoiceNo;
            [Column(Storage = "_InvoiceNo")]
            public int InvoiceNo
            {
                get
                {
                    return this._InvoiceNo;
                }
                set
                {
                    this._InvoiceNo = value;
                }
            }
            private int _PurchaseNo;
            [Column(Storage = "_PurchaseNo")]
            public int PurchaseNo
            {
                get
                {
                    return this._PurchaseNo;
                }
                set
                {
                    this._PurchaseNo = value;
                }
            }
            private string _ClientName;
            [Column(Storage = "_ClientName")]
            public string ClientName
            {
                get
                {
                    return this._ClientName;
                }
                set
                {
                    this._ClientName = value;
                }
            }
            private string _Email;
            [Column(Storage = "_Email")]
            public string Email
            {
                get
                {
                    return this._Email;
                }
                set
                {
                    this._Email = value;
                }
            }
            private string _Cell;
            [Column(Storage = "_Cell")]
            public string Cell
            {
                get
                {
                    return this._Cell;
                }
                set
                {
                    this._Cell = value;
                }
            }
            private double _Price;
            [Column(Storage = "_Price")]
            public double Price
            {
                get
                {
                    return this._Price;
                }
                set
                {
                    this._Price = value;
                }
            }
            private double _SaleDate;
            [Column(Storage = "_SaleDate")]
            public double SalseDate
            {
                get
                {
                    return this._SaleDate;
                }
                set
                {
                    this._SaleDate = value;
                }
            }
            private int _Dir;
            [Column(Storage = "_Dir")]
            public int Dir
            {
                get
                {
                    return this._Dir;
                }
                set
                {
                    this._Dir = value;
                }
            }
            private string _PaymentDate;
            [Column(Storage = "_PaymentDate")]
            public string PaymentDate
            {
                get
                {
                    return this._PaymentDate;
                }
                set
                {
                    this._PaymentDate = value;
                }
            }
            private string _PaymentMethod;
            [Column(Storage = "_PaymentMethod")]
            public string PaymentMethod
            {
                get
                {
                    return this._PaymentMethod;
                }
                set
                {
                    this._PaymentMethod = value;
                }
            }
            private string _ShipDate;
            [Column(Storage = "_ShipDate")]
            public string ShipDate
            {
                get
                {
                    return this._ShipDate;
                }
                set
                {
                    this._ShipDate = value;
                }
            }
            private string _RecivDate;
            [Column(Storage = "_RecivDate")]
            public string RecivDate
            {
                get
                {
                    return this._RecivDate;
                }
                set
                {
                    this._RecivDate = value;
                }
            }
            private int _WarrentyPeriod;
            [Column(Storage = "_WarrentyPeriod")]
            public int WarrentyPeriod
            {
                get
                {
                    return this._WarrentyPeriod;
                }
                set
                {
                    this._WarrentyPeriod = value;
                }
            }
            private string _EndWarranty;
            [Column(Storage = "_EndWarranty")]
            public string EndWarranty
            {
                get
                {
                    return this._EndWarranty;
                }
                set
                {
                    this._EndWarranty = value;
                }
            }
        }
    }
