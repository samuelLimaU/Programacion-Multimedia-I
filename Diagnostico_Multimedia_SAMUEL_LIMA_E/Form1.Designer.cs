namespace Diagnostico_Multimedia_SAMUEL_LIMA_E
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
            this.int_inicio = new System.Windows.Forms.TextBox();
            this.int_fin = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_numeros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // int_inicio
            // 
            this.int_inicio.Location = new System.Drawing.Point(23, 145);
            this.int_inicio.Name = "int_inicio";
            this.int_inicio.Size = new System.Drawing.Size(100, 26);
            this.int_inicio.TabIndex = 0;
            // 
            // int_fin
            // 
            this.int_fin.Location = new System.Drawing.Point(176, 145);
            this.int_fin.Name = "int_fin";
            this.int_fin.Size = new System.Drawing.Size(100, 26);
            this.int_fin.TabIndex = 1;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(19, 122);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(46, 20);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Inicio";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(172, 122);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(31, 20);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "Fin";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(176, 216);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(80, 35);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(43, 216);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(80, 35);
            this.btn_borrar.TabIndex = 5;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(19, 287);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(205, 20);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "La cantidad de números es:";
            // 
            // lbl_numeros
            // 
            this.lbl_numeros.AutoSize = true;
            this.lbl_numeros.Location = new System.Drawing.Point(230, 287);
            this.lbl_numeros.Name = "lbl_numeros";
            this.lbl_numeros.Size = new System.Drawing.Size(0, 20);
            this.lbl_numeros.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiempo de ejecución:";
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Location = new System.Drawing.Point(183, 319);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(0, 20);
            this.lbl_tiempo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 80);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alto consejo, ya realice la forma de \r\ndepurar a esos malditos compuestos, \r\nsolo" +
    " escriba numero entero \r\nde inicio y de final\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_numeros);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.int_fin);
            this.Controls.Add(this.int_inicio);
            this.Name = "Form1";
            this.Text = "Identificador de Primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox int_inicio;
        private System.Windows.Forms.TextBox int_fin;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_numeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label label2;
    }
}

