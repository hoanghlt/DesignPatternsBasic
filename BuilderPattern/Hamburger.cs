﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Hamburger
    {
        public int Size;

        public string Shape { get; set; }

        public string[] Ingredients { get; set; }

        public override string ToString()
        {
            var hamburger = "";
            foreach (var ingredient in Ingredients)
            {
                hamburger += $"{ingredient} ";
            }
            return $"Ingredients: {hamburger}, Size: {Size}, Shape: {Shape}";
        }
    }
}
