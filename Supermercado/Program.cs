// See https://aka.ms/new-console-template for more information
using Supermercado;

Producto prod1 = new ProductoPrecioFijo()
{
    Id = 1010,
    Descripcion = "Vino Gato Negro",
    Precio = 460M,
    IVA = 0.16F,
};

Console.WriteLine(prod1);

Producto prod2 = new ProductoPrecioFijo()
{
    Id = 2020,
    Descripcion = "Pan Bimbo Artesanal",
    Precio = 48.5M,
    IVA = 0.16F,
};

Console.WriteLine(prod2);

Producto prod3 = new ProductoPrecioVariable()
{
    Id = 3030,
    Descripcion = "Queso Holandes",
    UnidadDeMedida = "Kg",
    Precio = 87M,
    IVA = 0.16F,
    Cantidad = 1.8F,
};

Console.WriteLine(prod3);

Producto prod4 = new ProductoPrecioVariable()
{
    Id = 4040,
    Descripcion = "Cabano",
    UnidadDeMedida = "Kg",
    Precio = 180M,
    IVA = 0.16F,
    Cantidad = 0.5F,
};

Console.WriteLine(prod4);

Producto prod5 = new ProductoCompuesto()
{
    Id = 5050,
    Descripcion = "Paquete #1",
    Descuento = 0.15F,
    Productos = new List<Producto>() { prod1, prod2, prod3, prod4},
};

Console.WriteLine(prod5);


Factura factura = new Factura();
factura.AgregarProducto(prod1);
factura.AgregarProducto(prod3);
factura.AgregarProducto(prod5);

Console.WriteLine("==================== FACTURA ====================");
Console.WriteLine(factura);