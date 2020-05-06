namespace ProyectoIntegrador4SA
{
    partial class Administrador
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
            this.New_Us = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Consul_Resul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Us
            // 
            this.New_Us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.New_Us.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Us.Location = new System.Drawing.Point(30, 98);
            this.New_Us.Name = "New_Us";
            this.New_Us.Size = new System.Drawing.Size(108, 42);
            this.New_Us.TabIndex = 1;
            this.New_Us.Text = "Agregar Nuevo Usuario";
            this.New_Us.UseVisualStyleBackColor = true;
            this.New_Us.Click += new System.EventHandler(this.New_Us_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(30, 216);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 44);
            this.Back.TabIndex = 2;
            this.Back.Text = "Cerrar sesion";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Consul_Resul
            // 
            this.Consul_Resul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Consul_Resul.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consul_Resul.Location = new System.Drawing.Point(30, 40);
            this.Consul_Resul.Name = "Consul_Resul";
            this.Consul_Resul.Size = new System.Drawing.Size(108, 42);
            this.Consul_Resul.TabIndex = 4;
            this.Consul_Resul.Text = "Consultar Resultados";
            this.Consul_Resul.UseVisualStyleBackColor = true;
            this.Consul_Resul.Click += new System.EventHandler(this.Consul_Resul_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar Candidatos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Consul_Resul);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.New_Us);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrador_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button New_Us;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Consul_Resul;
        private System.Windows.Forms.Button button1;
    }
}