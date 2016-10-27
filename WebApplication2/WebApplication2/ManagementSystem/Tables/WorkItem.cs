using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "WellSpring")]
    public class WorkItem
    {

        private string _PMRnumber;
        [Column(Storage = "_PMRnumber")]
        public string PMRnumber
        {
            get
            {
                return this._PMRnumber;
            }
            set
            {
                this._PMRnumber = value;
            }
        }
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
        private string _EngineerName;
        [Column(Storage = "_EngineerName")]
        public string EngineerName
        {
            get
            {
                return this._EngineerName;
            }
            set
            {
                this._EngineerName = value;
            }
        }
        private string _SecondaryResolver;
        [Column(Storage = "_SecondaryResolver")]
        public string SecondaryResolver
        {
            get
            {
                return this._SecondaryResolver;
            }
            set
            {
                this._SecondaryResolver = value;
            }
        }
        private string _IssuedDate;
        [Column(Storage = "_IssuedDate")]
        public string IssuedDate
        {
            get
            {
                return this._IssuedDate;
            }
            set
            {
                this._IssuedDate = value;
            }
        }
        private string _Deadline;
        [Column(Storage = "_Deadline")]
        public string Deadline
        {
            get
            {
                return this._Deadline;
            }
            set
            {
                this._Deadline = value;
            }
        }
    }
}
