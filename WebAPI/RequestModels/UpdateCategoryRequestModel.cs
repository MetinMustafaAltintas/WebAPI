﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.RequestModels
{
    public class UpdateCategoryRequestModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}