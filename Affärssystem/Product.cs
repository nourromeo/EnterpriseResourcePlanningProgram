﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärssystem
{
    public class Product
    {
        public string Antal { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public string PLatform { get; set; }
        public string Playtime { get; set; }
        public bool Lended { get; internal set; }

        public Product()
        {
            Lended = false;
        }

        public override string ToString()
        {
            return $"{Name} {ISBN}";
        }
    }
}
