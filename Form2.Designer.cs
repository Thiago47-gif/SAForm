
namespace SAMontagem
{
    partial class FormPatio
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
            this.lista2 = new System.Windows.Forms.ListBox();
            this.lista = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista2
            // 
            this.lista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lista2.FormattingEnabled = true;
            this.lista2.ItemHeight = 17;
            this.lista2.Location = new System.Drawing.Point(71, 83);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(279, 327);
            this.lista2.TabIndex = 0;
            // 
            // lista
            // 
            this.lista.AutoSize = true;
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lista.Location = new System.Drawing.Point(128, 44);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(181, 26);
            this.lista.TabIndex = 1;
            this.lista.Text = "Patio de Veículos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.lista2);
            this.Name = "FormPatio";
            this.Text = "Patio";
            this.Load += new System.EventHandler(this.FormPatio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Label lista;
        private System.Windows.Forms.Button button1;
    }
}