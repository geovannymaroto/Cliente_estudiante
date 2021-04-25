namespace Cliente_Estudiante
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
            this.txtpregunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnverdadero = new System.Windows.Forms.RadioButton();
            this.btnfalso = new System.Windows.Forms.RadioButton();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpregunta
            // 
            this.txtpregunta.Location = new System.Drawing.Point(157, 48);
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(222, 20);
            this.txtpregunta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "La pregunta es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Su respuesta es:";
            // 
            // btnverdadero
            // 
            this.btnverdadero.AutoSize = true;
            this.btnverdadero.Location = new System.Drawing.Point(199, 93);
            this.btnverdadero.Name = "btnverdadero";
            this.btnverdadero.Size = new System.Drawing.Size(74, 17);
            this.btnverdadero.TabIndex = 2;
            this.btnverdadero.TabStop = true;
            this.btnverdadero.Text = "Verdadero";
            this.btnverdadero.UseVisualStyleBackColor = true;
            // 
            // btnfalso
            // 
            this.btnfalso.AutoSize = true;
            this.btnfalso.Location = new System.Drawing.Point(295, 93);
            this.btnfalso.Name = "btnfalso";
            this.btnfalso.Size = new System.Drawing.Size(50, 17);
            this.btnfalso.TabIndex = 2;
            this.btnfalso.TabStop = true;
            this.btnfalso.Text = "Falso";
            this.btnfalso.UseVisualStyleBackColor = true;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(214, 150);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(119, 23);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "confirmar respuesta ";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(399, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Su respuesta es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estudiante:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(399, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(60, 13);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Estudiante:";
            this.lblnombre.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(73, 150);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 7;
            this.btnSolicitar.Text = "Solicitar pregunta";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 200);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btnfalso);
            this.Controls.Add(this.btnverdadero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpregunta);
            this.Name = "Form1";
            this.Text = "Resolucion del examen ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnverdadero;
        private System.Windows.Forms.RadioButton btnfalso;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnSolicitar;
    }
}

