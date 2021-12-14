using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private float precio;
        private int categoria;
        private int stock;
        private string img;

        public Producto()
        {

        }

        public Producto(int idProducto, string nombre, float precio, int categoria, int stock, string img)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.stock = stock;
            this.img = img;
        }

        public int getIdProducto()
        {
            return idProducto;
        }

        public void setIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public float getPrecio()
        {
            return precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }

        public int getCategoria()
        {
            return categoria;
        }

        public void setCategoria(int categoria)
        {
            this.categoria = categoria;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public string getImg()
        {
            return img;
        }

        public void setImg(string img)
        {
            this.img = img;
        }

        public override string ToString()
        {
            return "\n~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
            "ID Producto = " + idProducto + "\n" +
            "Nombre = " + nombre + "\n" +
            "Precio = " + precio + "\n" +
            "Categoria = " + categoria + "\n" +
            "Stock = " + stock;
        }
    }
}
