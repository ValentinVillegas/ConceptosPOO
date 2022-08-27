namespace Supermercado
{
    public abstract class Producto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public float IVA { get; set; }

        public abstract decimal GetValueToPay();
    }
}
