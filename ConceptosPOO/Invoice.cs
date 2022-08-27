namespace ConceptosPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"Invoice # {Id:#######0}" +
                $"\n\t{Quantity:N2}  {Description}  {Price:C2}" +
                $"\n\tValue................: {$"{GetValueToPay():C2}",18}\n";
        }
    }
}
