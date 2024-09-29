using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nueva_carpeta.Models
{
    public class Ordenes
    {
        public string? Instrumento {get; set;}
        public decimal? Precio {get; set;}
        public string? TipoPrecio {get; set;}
        public int? Cantidad {get; set;}
        public decimal Costo {get; set;}
        public decimal Impuesto {get; set;}
        public decimal Total {get; set;}

        public Ordenes(string instrumento, decimal precio, string tipoPrecio, int cantidad){
            Instrumento = instrumento;
            Precio = precio;
            TipoPrecio = tipoPrecio;
            Cantidad = cantidad;
            Costo = (decimal)(Precio * Cantidad);
            Impuesto = Costo * 0.18m;
            Total = Costo * Impuesto;
        }
    }
}