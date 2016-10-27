﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "SupportDetail")]
    public class SupportDetail
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
        private string _ProblemDescription;
        [Column(Storage = "_ProblemDescription")]
        public string ProblemDescription
        {
            get
            {
                return this._ProblemDescription;
            }
            set
            {
                this._ProblemDescription = value;
            }
        }
        private string _Solution;
        [Column(Storage = "_Solution")]
        public string Solution
        {
            get
            {
                return this._Solution;
            }
            set
            {
                this._Solution = value;
            }
        }
        private string _CloseDate;
        [Column(Storage = "_CloseDate")]
        public string CloseDate
        {
            get
            {
                return this._CloseDate;
            }
            set
            {
                this._CloseDate = value;
            }
        }

    }
}