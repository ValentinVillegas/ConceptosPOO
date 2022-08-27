namespace Supermercado
{
    public class ProductoPrecioFijo : Producto
    {
        public override decimal GetValueToPay()
        {
            return Precio + (Precio * (decimal)IVA);
        }

        public override string ToString()
        {
            return $"{Id} — {Descripcion}" +
                $"\n\tPrecio:............: {$"{Precio:C2}",18}" +
                $"\n\tIVA................: {$"{Precio * (decimal)IVA:C2}",18}" +
                $"\n\tTotal..............: {$"{GetValueToPay():C2}", 18}" +
                $"\n";
        }
    }
}
