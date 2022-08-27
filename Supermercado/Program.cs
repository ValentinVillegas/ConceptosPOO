// See https://aka.ms/new-console-template for more information
using Supermercado;

Producto prod1 = new ProductoPrecioFijo()
{
    Id = 1010,
    Descripcion = "Vino Gato Negro",
    Precio = 460M,
    IVA = 0.08F,
};

Console.WriteLine(prod1);