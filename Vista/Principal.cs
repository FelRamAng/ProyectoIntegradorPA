using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class Principal : Form
    {
        private int role = 0;
        private int id_user = 0;
        private DataSet usuarios;
        DataSet consultaProductos = new DataSet();
        private List<Producto> listaProductos;
        private List<string> carrito = new List<string>();

        public int notifCount = 7;
        private int totProducts = 0;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Principal()
        {
            
        }

        public Principal(int role, int id_user, DataSet user)
        {
            this.role = role;
            this.id_user = id_user;
            this.usuarios = user;
            InitializeComponent();
            cargarProductos();
            PanelProductos.AutoScroll = false;
            PanelProductos.HorizontalScroll.Enabled = false;
            PanelProductos.HorizontalScroll.Visible = false;
            PanelProductos.HorizontalScroll.Maximum = 0;
            PanelProductos.AutoScroll = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(Convert.ToDouble(lTotal.Text.Substring(1)));
            compras.ShowDialog();
        }

        private void bAlmacen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cerrar Sesión", "¿Seguro que Desea Cerrar Sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bAlmacen_Click_1(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog();
        }

        private void bAdmUs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Trabajo en Proceso", "Esta Ventana está Aún en Contrucción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Trabajo en Proceso", "Esta Ventana está Aún en Contrucción", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        public void cargarProductos()
        {
            try
            {
                consultaProductos = Libreria.Herramientas("SELECT * FROM productos;");
                listaProductos = new List<Producto>();
                listaProductos.Clear();

                int id, categoria, stock;
                string nombre, img;
                float precio;

                for (int i = 0; i < consultaProductos.Tables[0].Rows.Count; i ++)
                {
                    id = Int32.Parse(consultaProductos.Tables[0].Rows[i]["id_producto"].ToString().Trim());
                    nombre = consultaProductos.Tables[0].Rows[i]["nombre_producto"].ToString().Trim();
                    precio = float.Parse(consultaProductos.Tables[0].Rows[i]["precio_producto"].ToString().Trim());
                    categoria = Int32.Parse(consultaProductos.Tables[0].Rows[i]["id_categoria"].ToString().Trim());
                    stock = Int32.Parse(consultaProductos.Tables[0].Rows[i]["cant_producto"].ToString().Trim());
                    img = consultaProductos.Tables[0].Rows[i]["img_producto"].ToString().Trim();
                    listaProductos.Add(new Producto(id, nombre, precio, categoria, stock, img));
                }
                Console.WriteLine("");
                Console.WriteLine("Los productos se cargaron exitosamente.");
            }
            catch (Exception error)
            {
                Console.WriteLine("");
                Console.Out.WriteLine("Error al cargar los productos: " + error.Message);
            }
        }

        public void updateTotals()
        {
            double sub = 0.0;
            double iva = 0.0;
            double total = 0.0;
            for (int i = 0; i < PanelCarrito.Controls.Count; i++)
            {
                sub += Convert.ToDouble(PanelCarrito.Controls[i].Controls[1].Text.Substring(1)) * Convert.ToInt32(PanelCarrito.Controls[i].Controls[2].Text);
                iva += (Convert.ToDouble(PanelCarrito.Controls[i].Controls[1].Text.Substring(1)) * 0.16) * Convert.ToInt32(PanelCarrito.Controls[i].Controls[2].Text);
                total = sub + iva;
            }
            total = Math.Round(total, 2);
            sub = Math.Round(sub, 2);
            iva = Math.Round(iva, 2);
            lSubtotal.Text = "$" + sub;
            lIVA.Text = "$" + iva;
            lTotal.Text = "$" + total;
        }

        public void AddProduct()
        {
            if (tCodigo.Text.Length > 0 && tCodigo.Text != "CODIGO PRODUCTO")
            {
                try
                {
                    int select = searchProduct(tCodigo.Text);
                    if (select != -1)
                    {
                        totProducts++;
                        Panel prod = new Panel();
                        TextBox PCant = new System.Windows.Forms.TextBox();
                        Label PLCant = new System.Windows.Forms.Label();
                        Button Prod_BRemove = new System.Windows.Forms.Button();
                        Button Prod_BAdd = new System.Windows.Forms.Button();
                        Label Prod_LPrice = new System.Windows.Forms.Label();
                        Label Prod_LName = new System.Windows.Forms.Label();

                        PCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        PCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        PCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
                        PCant.Location = new System.Drawing.Point(339, 11);
                        PCant.Name = "prod_TCant_" + totProducts;
                        PCant.Size = new System.Drawing.Size(53, 22);
                        PCant.TabIndex = 5;
                        PCant.Text = "1";
                        PCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        PCant.Leave += new System.EventHandler(this.txtChangeCant);
                        PCant.Tag = Prod_BRemove;

                        PLCant.AutoSize = true;
                        PLCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PLCant.Location = new System.Drawing.Point(295, 14);
                        PLCant.Name = "prod_LCant";
                        PLCant.Size = new System.Drawing.Size(38, 16);
                        PLCant.TabIndex = 4;
                        PLCant.Text = "Cant:";
                        PLCant.Tag = Prod_BRemove;

                        Prod_BRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        Prod_BRemove.FlatAppearance.BorderSize = 0;
                        Prod_BRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        Prod_BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_BRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
                        Prod_BRemove.Location = new System.Drawing.Point(463, 4);
                        Prod_BRemove.Name = "prod_BRemove_" + totProducts;
                        Prod_BRemove.Size = new System.Drawing.Size(35, 35);
                        Prod_BRemove.TabIndex = 3;
                        Prod_BRemove.Text = "X";
                        Prod_BRemove.UseVisualStyleBackColor = false;
                        Prod_BRemove.Click += new System.EventHandler(this.btnRemove_Click);

                        Prod_BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
                        Prod_BAdd.FlatAppearance.BorderSize = 0;
                        Prod_BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        Prod_BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_BAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(218)))), ((int)(((byte)(105)))));
                        Prod_BAdd.Location = new System.Drawing.Point(422, 4);
                        Prod_BAdd.Name = "prod_BAdd_" + totProducts;
                        Prod_BAdd.Size = new System.Drawing.Size(35, 35);
                        Prod_BAdd.TabIndex = 2;
                        Prod_BAdd.Text = "+";
                        Prod_BAdd.UseVisualStyleBackColor = false;
                        Prod_BAdd.Click += new System.EventHandler(this.btnAdd_Click);
                        Prod_BAdd.Tag = Prod_BRemove;

                        Prod_LPrice.AutoSize = true;
                        Prod_LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_LPrice.Location = new System.Drawing.Point(3, 22);
                        Prod_LPrice.Name = "prod_LPrice";
                        Prod_LPrice.Size = new System.Drawing.Size(38, 15);
                        Prod_LPrice.TabIndex = 1;
                        Prod_LPrice.Text = "$" + listaProductos.ElementAt(select).getPrecio();
                        Prod_LPrice.Tag = Prod_BRemove;

                        Prod_LName.AutoSize = false;
                        Prod_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        Prod_LName.Location = new System.Drawing.Point(3, 5);
                        Prod_LName.Name = "prod_LName";
                        Prod_LName.Size = new System.Drawing.Size(270, 16);
                        Prod_LName.TabIndex = 0;
                        Prod_LName.Text = listaProductos.ElementAt(select).getNombre();
                        Prod_LName.AutoEllipsis = true;
                        Prod_LName.Tag = Prod_BRemove;

                        prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
                        prod.Controls.Add(Prod_LName);
                        prod.Controls.Add(Prod_LPrice);
                        prod.Controls.Add(PCant);
                        prod.Controls.Add(PLCant);
                        prod.Controls.Add(Prod_BAdd);
                        prod.Controls.Add(Prod_BRemove);
                        prod.Location = new System.Drawing.Point(3, 3);
                        prod.Name = "prod_" + totProducts;
                        prod.Size = new System.Drawing.Size(508, 44);
                        prod.TabIndex = 11;
                        prod.Tag = Prod_BRemove;


                        PanelCarrito.Controls.Add(prod);
                        showPreviewProduct(listaProductos.ElementAt(select).getNombre(), listaProductos.ElementAt(select).getPrecio(), listaProductos.ElementAt(select).getImg(), listaProductos.ElementAt(select).getIdProducto(), listaProductos.ElementAt(select).getStock());
                        
                        tCodigo.Text = "";
                        carrito.Add(listaProductos.ElementAt(select).getNombre() + "," + listaProductos.ElementAt(select).getPrecio() + ",1");
                    }
                    else
                    {
                        
                    }
                }
                catch (Exception error)
                {
                    
                }
            }
            else
            {
                
            }
            updateTotals();
        }

        private void tCodigo_Enter(object sender, EventArgs e)
        {
            tCodigo.Text = "";
        }
        private void tCodigo_Leave(object sender, EventArgs e)
        {
            if (tCodigo.Text == "")
            {
                tCodigo.Text = "Escribe el Codigo del Producto";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < PanelCarrito.Controls.Count; i++)
            {
                if (btn.Name.Equals(PanelCarrito.Controls[i].Controls[4].Name))
                {
                    int cant = Convert.ToInt32(PanelCarrito.Controls[i].Controls[2].Text);
                    cant++;
                    PanelCarrito.Controls[i].Controls[2].Text = cant.ToString();
                    string[] datos = carrito[i].Split(',');
                    carrito[i] = datos[0] + "," + datos[1] + "," + cant;

                    updateTotals();
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < PanelCarrito.Controls.Count; i++)
            {
                if (btn.Name.Equals(PanelCarrito.Controls[i].Controls[5].Name))
                {
                    foreach (Control item in PanelCarrito.Controls.OfType<Control>().ToList())
                    {
                        if (item.Tag == sender || item == sender)
                        {
                            PanelCarrito.Controls.Remove(item);
                        }
                    }
                }
            }
            Console.WriteLine("Total de articulos en carrito: " + PanelCarrito.Controls.Count);
            updateTotals();
            clearPreviewProducts();
        }
        private void txtChangeCant(object sender, EventArgs e)
        {
            updateTotals();
        }

        public void showPreviewProduct(string Name, float price, string img_producto, int id, int stock)
        {
            prevImage.ImageLocation = img_producto;
            if (Name.Length > 10)
            {
                prevName.Text = Name.Substring(0, 13) + "...";
            }
            else
            {
                prevName.Text = Name;
            }
            prevCode.Text = "#" + id;
            prevPrice.Text = "$" + price;
            prevCant.Text = "x " + stock;
        }
        public void clearPreviewProducts()
        {
            prevImage.ImageLocation = "";
            prevName.Text = "";
            prevCode.Text = "";
            prevPrice.Text = "";
            prevCant.Text = "";
        }
        public int searchProduct(string codigo)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos.ElementAt(i).getIdProducto().Equals(Int32.Parse(codigo)))
                {
                    return i;
                }
            }
            return -1;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void lTotal_Click(object sender, EventArgs e)
        {

        }

        private void bImpRec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
