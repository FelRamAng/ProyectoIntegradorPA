using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class Almacen : Form
    {
        private DataTable tableModel = new DataTable();
        List<Producto> listaProductos = new List<Producto>();
        List<Categoria> listaCategoria = new List<Categoria>();

        public Almacen()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        public void loadColumnsTable(int opcion)
        {
            tableModel.Rows.Clear();
            tableModel.Columns.Clear();

            if (opcion == 1)//Productos
            {
                tableModel.Columns.Add("ID");
                tableModel.Columns.Add("Producto");
                tableModel.Columns.Add("Precio");
                tableModel.Columns.Add("Categoría");
                tableModel.Columns.Add("Stock");
                loadRowsTable(1);

            }

            TablaProductos.DataSource = tableModel;
            bAdd.Enabled = true;
            bModify.Enabled = true;
            bDelete.Enabled = true;
        }

        public void loadRowsTable(int type)
        {
            if (type == 1)//Productos
            {
                inventario_carga();
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    tableModel.Rows.Add(listaProductos.ElementAt(i).getIdProducto(), listaProductos.ElementAt(i).getNombre(), listaProductos.ElementAt(i).getPrecio(), listaProductos.ElementAt(i).getCategoria(), listaProductos.ElementAt(i).getStock());
                }
            }
        }

        public void loadCategorias()
        {
            DataSet categorias = new DataSet();
            listaCategoria.Clear();
            cbCategoria.Items.Clear();
            categorias = Libreria.Herramientas("SELECT * FROM categorias");
            string categoria;
            int id;

            for (int i = 0; i < categorias.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(categorias.Tables[0].Rows[i]["id_categoria"].ToString().Trim());
                categoria = categorias.Tables[0].Rows[i]["categoria"].ToString().Trim();

                listaCategoria.Add(new Categoria(id, categoria));
                cbCategoria.Items.Add(categoria);
            }
        }

        public void inventario_carga()
        {
            DataSet productos = new DataSet();
            listaProductos.Clear();

            productos = Libreria.Herramientas("Select * FROM productos;");
            string nombre, img;
            int id, categoria, stock;
            float precio;

            for (int i = 0; i < productos.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(productos.Tables[0].Rows[i]["id_producto"].ToString().Trim());
                nombre = productos.Tables[0].Rows[i]["nombre_producto"].ToString().Trim();
                precio = float.Parse(productos.Tables[0].Rows[i]["precio_producto"].ToString().Trim());
                categoria = Convert.ToInt32(productos.Tables[0].Rows[i]["id_categoria"].ToString().Trim());
                stock = Convert.ToInt32(productos.Tables[0].Rows[i]["cant_producto"].ToString().Trim());
                img = productos.Tables[0].Rows[i]["img_producto"].ToString().Trim();

                listaProductos.Add(new Producto(id, nombre, precio, categoria, stock, img));
            }
        }



        public int getIDCategory()
        {
            for (int i = 0; i < listaCategoria.Count; i++)
            {
                if (cbCategoria.SelectedItem.ToString().Equals(listaCategoria.ElementAt(i).getCategoria()))
                {
                    return i;
                }
            }
            return 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            loadColumnsTable(1);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (bAdd.Text == "Añadir Producto")
            {
                bAdd.Text = "Guardar Producto";
                bDelete.Text = "Cancelar";
                bModify.Enabled = false;
                tID.Enabled = true;
                t2.Enabled = true;
                t3.Enabled = true;
                cbCategoria.Enabled = true;
                tStock.Enabled = true;
                tImagen.Enabled = true;
            }
            else if (bAdd.Text == "Guardar Producto")
            {
                if (t2.Text != "" && t3.Text != "" && tImagen.Text != "" && tStock.Text != "")
                {
                    try
                    {
                        int id = Convert.ToInt32(tID.Text);
                        string nombre = t2.Text;
                        float precio = float.Parse(t3.Text);
                        int categoria = getIDCategory();
                        int stock = Convert.ToInt32(tStock.Text);
                        int modo = 0;
                        string imagen = tImagen.Text;

                        string mysql = "INSERT INTO productos VALUES('" + id + "', '" + nombre + "', '" + precio + "', '" + categoria + "', '" + stock + "', '" + imagen + "');";
                        Libreria.Herramientas(mysql);
                        loadColumnsTable(1);

                        
                        bAdd.Text = "Agregar";
                        bDelete.Text = "Eliminar";
                        
                        bModify.Enabled = true;
                        
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("[ERROR]: " + error);
                    }
                }
            }
        }
    }
}
