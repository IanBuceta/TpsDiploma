namespace Ejercicio_1
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
            this.buttonCrearScooter = new System.Windows.Forms.Button();
            this.buttonCrearEnduro = new System.Windows.Forms.Button();
            this.buttonCrearPistero = new System.Windows.Forms.Button();
            this.listBoxMoto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCrearScooter
            // 
            this.buttonCrearScooter.Location = new System.Drawing.Point(12, 12);
            this.buttonCrearScooter.Name = "buttonCrearScooter";
            this.buttonCrearScooter.Size = new System.Drawing.Size(87, 23);
            this.buttonCrearScooter.TabIndex = 0;
            this.buttonCrearScooter.Text = "Crear Scooter";
            this.buttonCrearScooter.UseVisualStyleBackColor = true;
            this.buttonCrearScooter.Click += new System.EventHandler(this.buttonCrearScooter_Click);
            // 
            // buttonCrearEnduro
            // 
            this.buttonCrearEnduro.Location = new System.Drawing.Point(12, 41);
            this.buttonCrearEnduro.Name = "buttonCrearEnduro";
            this.buttonCrearEnduro.Size = new System.Drawing.Size(87, 23);
            this.buttonCrearEnduro.TabIndex = 1;
            this.buttonCrearEnduro.Text = "Crear Enduro";
            this.buttonCrearEnduro.UseVisualStyleBackColor = true;
            this.buttonCrearEnduro.Click += new System.EventHandler(this.buttonCrearEnduro_Click);
            // 
            // buttonCrearPistero
            // 
            this.buttonCrearPistero.Location = new System.Drawing.Point(12, 70);
            this.buttonCrearPistero.Name = "buttonCrearPistero";
            this.buttonCrearPistero.Size = new System.Drawing.Size(87, 23);
            this.buttonCrearPistero.TabIndex = 2;
            this.buttonCrearPistero.Text = "Crear Pistero";
            this.buttonCrearPistero.UseVisualStyleBackColor = true;
            this.buttonCrearPistero.Click += new System.EventHandler(this.buttonCrearPistero_Click);
            // 
            // listBoxMoto
            // 
            this.listBoxMoto.FormattingEnabled = true;
            this.listBoxMoto.Location = new System.Drawing.Point(139, 12);
            this.listBoxMoto.Name = "listBoxMoto";
            this.listBoxMoto.Size = new System.Drawing.Size(451, 329);
            this.listBoxMoto.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.listBoxMoto);
            this.Controls.Add(this.buttonCrearPistero);
            this.Controls.Add(this.buttonCrearEnduro);
            this.Controls.Add(this.buttonCrearScooter);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearScooter;
        private System.Windows.Forms.Button buttonCrearEnduro;
        private System.Windows.Forms.Button buttonCrearPistero;
        private System.Windows.Forms.ListBox listBoxMoto;
    }
}

