﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Assignment
{
    public interface ITaxCalculator
    {
        double CalculateTax(double amount);
    }

    // Standard 18% tax calculation
    public class StandardTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.18; // 18% tax
        }
    }
}
