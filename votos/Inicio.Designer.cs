namespace ProyectoIntegrador4SA
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Acceder = new System.Windows.Forms.Button();
            this.usr = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Salir = new System.Windows.Forms.Button();
            this.psw = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Acceder
            // 
            this.Acceder.BackColor = System.Drawing.Color.White;
            this.Acceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceder.Location = new System.Drawing.Point(123, 274);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(94, 32);
            this.Acceder.TabIndex = 0;
            this.Acceder.Text = "Acceder";
            this.Acceder.UseVisualStyleBackColor = false;
            this.Acceder.Click += new System.EventHandler(this.Acceder_Click);
            // 
            // usr
            // 
            this.usr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usr.ForeColor = System.Drawing.Color.White;
            this.usr.Location = new System.Drawing.Point(42, 148);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(150, 20);
            this.usr.TabIndex = 1;
            this.usr.Text = "USUARIO";
            this.usr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 5;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.White;
            this.Salir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(12, 274);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(94, 32);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // psw
            // 
            this.psw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.psw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psw.ForeColor = System.Drawing.Color.White;
            this.psw.Location = new System.Drawing.Point(42, 209);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(150, 20);
            this.psw.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::ProyectoIntegrador4SA.Properties.Resources.CALIDAD2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(229, 318);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.Acceder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Acceder;
        private System.Windows.Forms.TextBox usr;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

