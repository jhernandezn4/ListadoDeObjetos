
namespace WindowsFormsApp1
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
            this.listAlumnos = new System.Windows.Forms.ListBox();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listAlumnos
            // 
            this.listAlumnos.FormattingEnabled = true;
            this.listAlumnos.Location = new System.Drawing.Point(210, 154);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(766, 264);
            this.listAlumnos.TabIndex = 1;
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(72, 164);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnLeerArchivo.TabIndex = 2;
            this.btnLeerArchivo.Text = "leerArchivos";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(61, 92);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(242, 20);
            this.txtRuta.TabIndex = 3;
            this.txtRuta.Text = "C:\\Users\\GAMERS\\Desktop\\datosTexto.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.listAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAlumnos;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.TextBox txtRuta;
    }
}

