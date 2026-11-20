using System.Collections.Generic;
using CatalogoMaui.Models;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    public List<Producto> Productos { get; } = new()
    {
        new Producto
        {
            Nombre = "Mochila urbana",
            Descripcion = "Con espacio para laptop y cuadernos.",
            Precio = 250.00m,
            Detalle = "Mochila para uso diario. Incluye un compartimento acolchado para laptop y un bolsillo frontal para objetos pequeños.",
            Foto = "mochila.png"
        },
        new Producto
        {
            Nombre = "Libreta A5",
            Descripcion = "80 hojas rayadas con pasta dura.",
            Precio = 65.50m,
            Detalle = "Libreta de tamaño A5 con 80 hojas rayadas. Su pasta dura protege los apuntes dentro de la mochila.",
            Foto = "cuaderno.png"
        },
        new Producto
        {
            Nombre = "Termo de acero",
            Descripcion = "Botella reutilizable de 500 ml.",
            Precio = 200.00m,
            Detalle = "Termo de acero de 500 ml, con tapa de rosca. Su tamaño permite llevarlo en el bolsillo lateral de una mochila.",
            Foto = "termo.png"
        },
    };
}