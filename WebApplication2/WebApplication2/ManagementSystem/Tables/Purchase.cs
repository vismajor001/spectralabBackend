using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "Purchase")]
    public class Purchase
    {

        private int _ProductID;
        [Column(Storage = "_ProductID")]
        public int ProductID
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
        private int _Qty;
        [Column(Storage = "_Qty")]
        public int Qty
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
        private DateTime? _PurchaseDate;
        [Column(Storage = "_PurchaseDate")]
        public DateTime? PurchaseDate
        {
            get
            {
                return this._PurchaseDate;
            }
            set
            {
                this._PurchaseDate = value;
            }
        }
        private DateTime? _ShipDate;
        [Column(Storage = "_ShipDate")]
        public DateTime? ShipDate
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
        private DateTime? _RecvDate;
        [Column(Storage = "_RecvDate")]
        public DateTime? RecvDate
        {
            get
            {
                return this._RecvDate;
            }
            set
            {
                this._RecvDate = value;
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
        private string _SupplierName;
        [Column(Storage = "_SupplierName")]
        public string SupplierName
        {
            get
            {
                return this._SupplierName;
            }
            set
            {
                this._SupplierName = value;
            }
        }

    }
}