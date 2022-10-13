﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto
    {
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string CustomerFullName { get; set; }
    }
}
