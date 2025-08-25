namespace Guia2._1
{
    partial class Form1
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(77, 47);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 95);
            this.lb1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(77, 166);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 95);
            this.lb2.TabIndex = 1;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(239, 76);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 2;
            this.btnDatos.Text = "Registrar";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(239, 194);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 39);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar Registros";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lb1;
        public System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button button1;
    }
}

