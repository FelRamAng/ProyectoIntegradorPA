
namespace Vista
{
    partial class LoginScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraTB = new System.Windows.Forms.TextBox();
            this.usuarioTB = new System.Windows.Forms.TextBox();
            this.VerContra = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(250, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(174, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constraseña";
            // 
            // ContraTB
            // 
            this.ContraTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraTB.Location = new System.Drawing.Point(394, 343);
            this.ContraTB.Name = "ContraTB";
            this.ContraTB.PasswordChar = 'X';
            this.ContraTB.Size = new System.Drawing.Size(222, 29);
            this.ContraTB.TabIndex = 2;
            this.ContraTB.TextChanged += new System.EventHandler(this.ContraTB_TextChanged);
            // 
            // usuarioTB
            // 
            this.usuarioTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTB.Location = new System.Drawing.Point(392, 281);
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(224, 29);
            this.usuarioTB.TabIndex = 1;
            // 
            // VerContra
            // 
            this.VerContra.BackColor = System.Drawing.Color.Transparent;
            this.VerContra.FlatAppearance.BorderSize = 0;
            this.VerContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerContra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.VerContra.IconColor = System.Drawing.Color.White;
            this.VerContra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.VerContra.Location = new System.Drawing.Point(619, 347);
            this.VerContra.Name = "VerContra";
            this.VerContra.Size = new System.Drawing.Size(53, 30);
            this.VerContra.TabIndex = 3;
            this.VerContra.UseVisualStyleBackColor = false;
            this.VerContra.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.LoginScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerContra);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.ContraTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraTB;
        private System.Windows.Forms.TextBox usuarioTB;
        private FontAwesome.Sharp.IconButton VerContra;
    }
}