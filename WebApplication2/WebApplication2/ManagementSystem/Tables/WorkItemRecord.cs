using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
    [Table(Name = "PMR")]
    public class WorkItemRecord
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