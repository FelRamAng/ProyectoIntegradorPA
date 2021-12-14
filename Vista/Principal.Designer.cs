
namespace Vista
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCS = new System.Windows.Forms.Button();
            this.bAdmUs = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bAlmacen = new System.Windows.Forms.Button();
            this.bVender = new System.Windows.Forms.Button();
            this.PanelProductos = new System.Windows.Forms.Panel();
            this.PanelCarrito = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lvlIVA = new System.Windows.Forms.Label();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.lIVA = new System.Windows.Forms.Label();
            this.prevPanel = new System.Windows.Forms.Panel();
            this.prevImage = new System.Windows.Forms.PictureBox();
            this.prevPrice = new System.Windows.Forms.Panel();
            this.prevName = new System.Windows.Forms.Panel();
            this.prevCant = new System.Windows.Forms.Panel();
            this.prevCode = new System.Windows.Forms.Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.PanelProductos.SuspendLayout();
            this.panelTotales.SuspendLayout();
            this.prevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto de Venta";
            // 
            // btnCS
            // 
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.Location = new System.Drawing.Point(351, 46);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(98, 36);
            this.btnCS.TabIndex = 1;
            this.btnCS.Text = "Cerrar Sesión";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // bAdmUs
            // 
            this.bAdmUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdmUs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdmUs.Location = new System.Drawing.Point(29, 46);
            this.bAdmUs.Name = "bAdmUs";
            this.bAdmUs.Size = new System.Drawing.Size(98, 36);
            this.bAdmUs.TabIndex = 2;
            this.bAdmUs.Text = "Administrar Usuarios";
            this.bAdmUs.UseVisualStyleBackColor = true;
            this.bAdmUs.Click += new System.EventHandler(this.bAdmUs_Click);
            // 
            // bSalir
            // 
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(666, 46);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(98, 36);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bAlmacen_Click);
            // 
            // bAlmacen
            // 
            this.bAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAlmacen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlmacen.Location = new System.Drawing.Point(29, 402);
            this.bAlmacen.Name = "bAlmacen";
            this.bAlmacen.Size = new System.Drawing.Size(98, 36);
            this.bAlmacen.TabIndex = 4;
            this.bAlmacen.Text = "Almacén";
            this.bAlmacen.UseVisualStyleBackColor = true;
            this.bAlmacen.Click += new System.EventHandler(this.bAlmacen_Click_1);
            // 
            // bVender
            // 
            this.bVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVender.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.bVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVender.Location = new System.Drawing.Point(666, 402);
            this.bVender.Name = "bVender";
            this.bVender.Size = new System.Drawing.Size(98, 36);
            this.bVender.TabIndex = 6;
            this.bVender.Text = "Vender";
            this.bVender.UseVisualStyleBackColor = true;
            this.bVender.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // PanelProductos
            // 
            this.PanelProductos.BackColor = System.Drawing.Color.Thistle;
            this.PanelProductos.Controls.Add(this.PanelCarrito);
            this.PanelProductos.Controls.Add(this.panelTotales);
            this.PanelProductos.Controls.Add(this.prevPanel);
            this.PanelProductos.Controls.Add(this.btnAgregar);
            this.PanelProductos.Location = new System.Drawing.Point(29, 92);
            this.PanelProductos.Name = "PanelProductos";
            this.PanelProductos.Size = new System.Drawing.Size(734, 300);
            this.PanelProductos.TabIndex = 7;
            // 
            // PanelCarrito
            // 
            this.PanelCarrito.AutoScroll = true;
            this.PanelCarrito.Location = new System.Drawing.Point(124, 61);
            this.PanelCarrito.Name = "PanelCarrito";
            this.PanelCarrito.Size = new System.Drawing.Size(609, 203);
            this.PanelCarrito.TabIndex = 3;
            this.PanelCarrito.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelTotales
            // 
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Controls.Add(this.lTotal);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Controls.Add(this.lvlIVA);
            this.panelTotales.Controls.Add(this.lSubtotal);
            this.panelTotales.Controls.Add(this.lIVA);
            this.panelTotales.Location = new System.Drawing.Point(124, 262);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(609, 37);
            this.panelTotales.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(414, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(536, 12);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(39, 16);
            this.lTotal.TabIndex = 4;
            this.lTotal.Text = "$0.00";
            this.lTotal.Click += new System.EventHandler(this.lTotal_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(16, 12);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 16);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lvlIVA
            // 
            this.lvlIVA.AutoSize = true;
            this.lvlIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlIVA.Location = new System.Drawing.Point(225, 12);
            this.lvlIVA.Name = "lvlIVA";
            this.lvlIVA.Size = new System.Drawing.Size(61, 16);
            this.lvlIVA.TabIndex = 2;
            this.lvlIVA.Text = "IVA 16%:";
            // 
            // lSubtotal
            // 
            this.lSubtotal.AutoSize = true;
            this.lSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.Location = new System.Drawing.Point(104, 12);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(39, 16);
            this.lSubtotal.TabIndex = 1;
            this.lSubtotal.Text = "$0.00";
            // 
            // lIVA
            // 
            this.lIVA.AutoSize = true;
            this.lIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIVA.Location = new System.Drawing.Point(304, 12);
            this.lIVA.Name = "lIVA";
            this.lIVA.Size = new System.Drawing.Size(39, 16);
            this.lIVA.TabIndex = 0;
            this.lIVA.Text = "$0.00";
            // 
            // prevPanel
            // 
            this.prevPanel.Controls.Add(this.prevImage);
            this.prevPanel.Controls.Add(this.prevPrice);
            this.prevPanel.Controls.Add(this.prevName);
            this.prevPanel.Controls.Add(this.prevCant);
            this.prevPanel.Controls.Add(this.prevCode);
            this.prevPanel.Location = new System.Drawing.Point(0, 57);
            this.prevPanel.Name = "prevPanel";
            this.prevPanel.Size = new System.Drawing.Size(122, 240);
            this.prevPanel.TabIndex = 1;
            // 
            // prevImage
            // 
            this.prevImage.Location = new System.Drawing.Point(3, 3);
            this.prevImage.Name = "prevImage";
            this.prevImage.Size = new System.Drawing.Size(118, 95);
            this.prevImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prevImage.TabIndex = 5;
            this.prevImage.TabStop = false;
            // 
            // prevPrice
            // 
            this.prevPrice.AutoSize = true;
            this.prevPrice.Location = new System.Drawing.Point(0, 170);
            this.prevPrice.Name = "prevPrice";
            this.prevPrice.Size = new System.Drawing.Size(122, 34);
            this.prevPrice.TabIndex = 4;
            // 
            // prevName
            // 
            this.prevName.AutoSize = true;
            this.prevName.Location = new System.Drawing.Point(0, 132);
            this.prevName.Name = "prevName";
            this.prevName.Size = new System.Drawing.Size(122, 36);
            this.prevName.TabIndex = 3;
            // 
            // prevCant
            // 
            this.prevCant.AutoSize = true;
            this.prevCant.Location = new System.Drawing.Point(59, 98);
            this.prevCant.Name = "prevCant";
            this.prevCant.Size = new System.Drawing.Size(60, 33);
            this.prevCant.TabIndex = 2;
            // 
            // prevCode
            // 
            this.prevCode.AutoSize = true;
            this.prevCode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.prevCode.Location = new System.Drawing.Point(3, 98);
            this.prevCode.Name = "prevCode";
            this.prevCode.Size = new System.Drawing.Size(53, 33);
            this.prevCode.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(698, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(39, 41);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tCodigo
            // 
            this.tCodigo.BackColor = System.Drawing.Color.Thistle;
            this.tCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCodigo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tCodigo.Location = new System.Drawing.Point(29, 92);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(699, 32);
            this.tCodigo.TabIndex = 1;
            this.tCodigo.Text = "Escribe el Codigo del Producto";
            this.tCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources.Principal;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.PanelProductos);
            this.Controls.Add(this.bVender);
            this.Controls.Add(this.bAlmacen);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAdmUs);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "asdasdasdasdasd";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelProductos.ResumeLayout(false);
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            this.prevPanel.ResumeLayout(false);
            this.prevPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button bAdmUs;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bAlmacen;
        private System.Windows.Forms.Button bVender;
        private System.Windows.Forms.Panel PanelProductos;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Panel prevPanel;
        private System.Windows.Forms.Panel prevName;
        private System.Windows.Forms.Panel prevCant;
        private System.Windows.Forms.Panel prevCode;
        private System.Windows.Forms.Panel prevPrice;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lvlIVA;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.Label lIVA;
        private System.Windows.Forms.FlowLayoutPanel PanelCarrito;
        private System.Windows.Forms.PictureBox prevImage;
    }
}

