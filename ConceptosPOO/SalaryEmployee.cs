namespace ConceptosPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue to pay........:{$"{GetValueToPay():c2}",18}\n";
        }
    }
}