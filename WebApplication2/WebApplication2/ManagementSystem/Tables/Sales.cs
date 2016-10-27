using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    
        [Table(Name = "Sales")]
        public class Sales
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
            private int? _InvoiceNo;
            [Column(Storage = "_InvoiceNo")]
            public int? InvoiceNo
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
