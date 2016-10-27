using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WebApplication1.ManagementSystem.Tables
{
        [Table(Name = "Detector")]
        public class Detector
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
            private string _DetectorA;
            [Column(Storage = "_DetectorA")]
            public string DetectorA
            {
                get
                {
                    return this._DetectorA;
                }
                set
                {
                    this._DetectorA = value;
                }
            }
            private string _DetectorB;
            [Column(Storage = "_DetectorB")]
            public string DetectorB
            {
                get
                {
                    return this._DetectorB;
                }
                set
                {
                    this._DetectorB = value;
                }
            }
            private string _DetectorC;
            [Column(Storage = "_DetectorC")]
            public string DetectorC
            {
                get
                {
                    return this._DetectorC;
                }
                set
                {
                    this._DetectorC = value;
                }
            }
            private string _DetectorD;
            [Column(Storage = "_DetectorD")]
            public string DetectorD
            {
                get
                {
                    return this._DetectorD;
                }
                set
                {
                    this._DetectorD = value;
                }
            }
            private string _DetectorE;
            [Column(Storage = "_DetectorE")]
            public string DetectorE
            {
                get
                {
                    return this._DetectorE;
                }
                set
                {
                    this._DetectorE = value;
                }
            }
        }
    }
