﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class PropertyNameModel
    {
        public int ID { get; set; }
        public int ACateoryID { get; set; }
        public string AssetName { get; set; }
        public string Description { get; set; }
        public int CompanyID { get; set; }
    }
}