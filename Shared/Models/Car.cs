﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJAuto.Shared.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string NumberPlat { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Imag { get; set;  }
        public double Km { get; set; }
        public int year { get; set; }
        public double Price { get; set; }
    }
}