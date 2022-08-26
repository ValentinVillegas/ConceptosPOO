using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class CommisionEmployee : Employee
    {
        public decimal Sales { get; set; }

        public float CommissionPercentaje { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje: {CommissionPercentaje:P2}" +
                $"\n\tValue to pay.........: {GetValueToPay():C2}";
        }
    }
}
