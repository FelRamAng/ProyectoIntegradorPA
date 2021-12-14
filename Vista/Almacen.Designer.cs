
namespace Vista
{
    partial class Almacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bModify = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tImagen = new System.Windows.Forms.TextBox();
            this.tStock = new System.Windows.Forms.TextBox();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.MediumOrchid;
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(747, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(48, 28);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.Black;
            this.bAdd.Location = new System.Drawing.Point(64, 215);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(104, 34);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Añadir Producto";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inventario";
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.DarkOrange;
            this.bModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bModify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.ForeColor = System.Drawing.Color.Black;
            this.bModify.Location = new System.Drawing.Point(348, 215);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(104, 34);
            this.bModify.TabIndex = 6;
            this.bModify.Text = "Editar Producto";
            this.bModify.UseVisualStyleBackColor = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Location = new System.Drawing.Point(602, 215);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(104, 34);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Eliminar Producto";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datos del producto";
            // 
            // tID
            // 
            this.tID.Enabled = false;
            this.tID.Location = new System.Drawing.Point(225, 323);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(165, 20);
            this.tID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID del Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre del Producto:";
            // 
            // t2
            // 
            this.t2.Enabled = false;
            this.t2.Location = new System.Drawing.Point(225, 360);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(165, 20);
            this.t2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio:";
            // 
            // t3
            // 
            this.t3.Enabled = false;
            this.t3.Location = new System.Drawing.Point(225, 399);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(165, 20);
            this.t3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(410, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID de Categoría:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(410, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Imagen del Producto:";
            // 
            // tImagen
            // 
            this.tImagen.Enabled = false;
            this.tImagen.Location = new System.Drawing.Point(621, 402);
            this.tImagen.Name = "tImagen";
            this.tImagen.Size = new System.Drawing.Size(165, 20);
            this.tImagen.TabIndex = 18;
            // 
            // tStock
            // 
            this.tStock.Enabled = false;
            this.tStock.Location = new System.Drawing.Point(621, 362);
            this.tStock.Name = "tStock";
            this.tStock.Size = new System.Drawing.Size(165, 20);
            this.tStock.TabIndex = 20;
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AllowUserToDeleteRows = false;
            this.TablaProductos.AllowUserToResizeColumns = false;
            this.TablaProductos.AllowUserToResizeRows = false;
            this.TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaProductos.ColumnHeadersHeight = 30;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaProductos.EnableHeadersVisualStyles = false;
            this.TablaProductos.Location = new System.Drawing.Point(18, 40);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(768, 169);
            this.TablaProductos.TabIndex = 21;
            this.TablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(621, 323);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 21);
            this.cbCategoria.TabIndex = 22;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.Principal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.tStock);
            this.Controls.Add(this.tImagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tImagen;
        private System.Windows.Forms.TextBox tStock;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}