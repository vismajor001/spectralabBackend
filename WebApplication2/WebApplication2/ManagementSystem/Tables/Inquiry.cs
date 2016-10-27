using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "Inquiry")]
    public class Inquiry
    {

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
        private string _QuoteNo;
        [Column(Storage = "_QuoteNo")]
        public string QuoteNo
        {
            get
            {
                return this._QuoteNo;
            }
            set
            {
                this._QuoteNo = value;
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
    }
}
