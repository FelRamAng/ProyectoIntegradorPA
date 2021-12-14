using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        private int idCategoria;
        private string categoria;
        

        public Categoria() { }
        public Categoria(int idCategoria, string categoria)
        {
            this.idCategoria = idCategoria;
            this.categoria = categoria;
        }
        public void setIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public int getIdCategoria()
        {
            return this.idCategoria;
        }
        public string getCategoria()
        {
            return this.categoria;
        }

        public override string ToString()
        {
            return "ID: " + idCategoria +
                "\nCategoría: " + categoria;
        }
    }
}
