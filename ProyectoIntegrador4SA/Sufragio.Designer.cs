namespace ProyectoIntegrador4SA
{
    partial class Sufragio
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Volver = new System.Windows.Forms.Button();
            this.Sufragar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Lista 1",
            "Lista 2",
            "Lista 3",
            "Lista 4"});
            this.checkedListBox1.Location = new System.Drawing.Point(22, 34);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(135, 112);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.YellowGreen;
            this.Volver.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ForeColor = System.Drawing.Color.White;
            this.Volver.Location = new System.Drawing.Point(43, 242);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(90, 50);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Sufragar
            // 
            this.Sufragar.BackColor = System.Drawing.Color.YellowGreen;
            this.Sufragar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sufragar.ForeColor = System.Drawing.Color.White;
            this.Sufragar.Location = new System.Drawing.Point(43, 167);
            this.Sufragar.Name = "Sufragar";
            this.Sufragar.Size = new System.Drawing.Size(90, 50);
            this.Sufragar.TabIndex = 2;
            this.Sufragar.Text = "Sufragar";
            this.Sufragar.UseVisualStyleBackColor = false;
            this.Sufragar.Click += new System.EventHandler(this.Sufragar_Click);
            // 
            // Sufragio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(177, 304);
            this.Controls.Add(this.Sufragar);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Sufragio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sufragio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Sufragar;
    }
}