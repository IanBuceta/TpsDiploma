namespace Ejercicio_2
{
    partial class Form1
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
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.buttonCrearFiatPalio = new System.Windows.Forms.Button();
            this.buttonCrearFordFocus = new System.Windows.Forms.Button();
            this.buttonCrearFordFiesta = new System.Windows.Forms.Button();
            this.radioButton3Puertas = new System.Windows.Forms.RadioButton();
            this.radioButton5Puertas = new System.Windows.Forms.RadioButton();
            this.buttonCrearFiatSiena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(134, 12);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(451, 329);
            this.listBoxAuto.TabIndex = 7;
            // 
            // buttonCrearFiatPalio
            // 
            this.buttonCrearFiatPalio.Location = new System.Drawing.Point(7, 70);
            this.buttonCrearFiatPalio.Name = "buttonCrearFiatPalio";
            this.buttonCrearFiatPalio.Size = new System.Drawing.Size(102, 23);
            this.buttonCrearFiatPalio.TabIndex = 6;
            this.buttonCrearFiatPalio.Text = "Crear Fiat Palio";
            this.buttonCrearFiatPalio.UseVisualStyleBackColor = true;
            this.buttonCrearFiatPalio.Click += new System.EventHandler(this.buttonCrearFiatPalio_Click);
            // 
            // buttonCrearFordFocus
            // 
            this.buttonCrearFordFocus.Location = new System.Drawing.Point(7, 41);
            this.buttonCrearFordFocus.Name = "buttonCrearFordFocus";
            this.buttonCrearFordFocus.Size = new System.Drawing.Size(102, 23);
            this.buttonCrearFordFocus.TabIndex = 5;
            this.buttonCrearFordFocus.Text = "Crear Ford Focus";
            this.buttonCrearFordFocus.UseVisualStyleBackColor = true;
            this.buttonCrearFordFocus.Click += new System.EventHandler(this.buttonCrearFordFocus_Click);
            // 
            // buttonCrearFordFiesta
            // 
            this.buttonCrearFordFiesta.Location = new System.Drawing.Point(7, 12);
            this.buttonCrearFordFiesta.Name = "buttonCrearFordFiesta";
            this.buttonCrearFordFiesta.Size = new System.Drawing.Size(102, 23);
            this.buttonCrearFordFiesta.TabIndex = 4;
            this.buttonCrearFordFiesta.Text = "Crear Ford Fiesta";
            this.buttonCrearFordFiesta.UseVisualStyleBackColor = true;
            this.buttonCrearFordFiesta.Click += new System.EventHandler(this.buttonCrearFordFiesta_Click);
            // 
            // radioButton3Puertas
            // 
            this.radioButton3Puertas.AutoSize = true;
            this.radioButton3Puertas.Checked = true;
            this.radioButton3Puertas.Location = new System.Drawing.Point(7, 135);
            this.radioButton3Puertas.Name = "radioButton3Puertas";
            this.radioButton3Puertas.Size = new System.Drawing.Size(69, 17);
            this.radioButton3Puertas.TabIndex = 8;
            this.radioButton3Puertas.TabStop = true;
            this.radioButton3Puertas.Text = "3 puertas";
            this.radioButton3Puertas.UseVisualStyleBackColor = true;
            // 
            // radioButton5Puertas
            // 
            this.radioButton5Puertas.AutoSize = true;
            this.radioButton5Puertas.Location = new System.Drawing.Point(7, 158);
            this.radioButton5Puertas.Name = "radioButton5Puertas";
            this.radioButton5Puertas.Size = new System.Drawing.Size(69, 17);
            this.radioButton5Puertas.TabIndex = 9;
            this.radioButton5Puertas.Text = "5 puertas";
            this.radioButton5Puertas.UseVisualStyleBackColor = true;
            // 
            // buttonCrearFiatSiena
            // 
            this.buttonCrearFiatSiena.Location = new System.Drawing.Point(7, 99);
            this.buttonCrearFiatSiena.Name = "buttonCrearFiatSiena";
            this.buttonCrearFiatSiena.Size = new System.Drawing.Size(102, 23);
            this.buttonCrearFiatSiena.TabIndex = 10;
            this.buttonCrearFiatSiena.Text = "Crear Fiat Siena";
            this.buttonCrearFiatSiena.UseVisualStyleBackColor = true;
            this.buttonCrearFiatSiena.Click += new System.EventHandler(this.buttonCrearFiatSiena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 358);
            this.Controls.Add(this.buttonCrearFiatSiena);
            this.Controls.Add(this.radioButton5Puertas);
            this.Controls.Add(this.radioButton3Puertas);
            this.Controls.Add(this.listBoxAuto);
            this.Controls.Add(this.buttonCrearFiatPalio);
            this.Controls.Add(this.buttonCrearFordFocus);
            this.Controls.Add(this.buttonCrearFordFiesta);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.Button buttonCrearFiatPalio;
        private System.Windows.Forms.Button buttonCrearFordFocus;
        private System.Windows.Forms.Button buttonCrearFordFiesta;
        private System.Windows.Forms.RadioButton radioButton3Puertas;
        private System.Windows.Forms.RadioButton radioButton5Puertas;
        private System.Windows.Forms.Button buttonCrearFiatSiena;
    }
}

