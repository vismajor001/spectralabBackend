using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "Support")]
    public class Support
    {
        private string _InvoiceNo;
        [Column(Storage = "_InvoiceNo")]
        public string InvoiceNo
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
        private string _PurchaseNo;
        [Column(Storage = "_PurchaseNo")]
        public string PurchaseNo
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
        private string _Dir;
        [Column(Storage = "_Dir")]
        public string Dir
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
        private string _SupportTechName;
        [Column(Storage = "_SupportTechName")]
        public string SupportTechName
        {
            get
            {
                return this._SupportTechName;
            }
            set
            {
                this._SupportTechName = value;
            }
        }

    }
}