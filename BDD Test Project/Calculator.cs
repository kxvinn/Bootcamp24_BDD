using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add() // método utilizado para retornar a soma de dois números.
        {
            return FirstNumber + SecondNumber;
        }
    }
}