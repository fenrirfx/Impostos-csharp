using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name, double anualIncome, double healthExpenses) : base (name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Taxes()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenses * 0.5); 
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
