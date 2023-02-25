namespace Examen_1_programacion_3
{
    partial class Segundo_Formulario
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
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPagarTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AgregarCalcular = new System.Windows.Forms.Button();
            this.txt_PrecioProducto = new System.Windows.Forms.TextBox();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_Cantidad.Location = new System.Drawing.Point(248, 211);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(80, 22);
            this.txt_Cantidad.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cantidad:";
            // 
            // TotalPagarTextBox
            // 
            this.TotalPagarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TotalPagarTextBox.Location = new System.Drawing.Point(248, 354);
            this.TotalPagarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPagarTextBox.Name = "TotalPagarTextBox";
            this.TotalPagarTextBox.ReadOnly = true;
            this.TotalPagarTextBox.Size = new System.Drawing.Size(132, 22);
            this.TotalPagarTextBox.TabIndex = 26;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescuentoTextBox.Location = new System.Drawing.Point(248, 309);
            this.DescuentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.ReadOnly = true;
            this.DescuentoTextBox.Size = new System.Drawing.Size(135, 22);
            this.DescuentoTextBox.TabIndex = 25;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubtotalTextBox.Location = new System.Drawing.Point(248, 272);
            this.SubtotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(133, 22);
            this.SubtotalTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total a Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descuento (15%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Subtotal:";
            // 
            // btn_AgregarCalcular
            // 
            this.btn_AgregarCalcular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AgregarCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCalcular.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarCalcular.Location = new System.Drawing.Point(438, 394);
            this.btn_AgregarCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarCalcular.Name = "btn_AgregarCalcular";
            this.btn_AgregarCalcular.Size = new System.Drawing.Size(140, 48);
            this.btn_AgregarCalcular.TabIndex = 20;
            this.btn_AgregarCalcular.Text = "Calcular Descuento";
            this.btn_AgregarCalcular.UseVisualStyleBackColor = false;
            this.btn_AgregarCalcular.Click += new System.EventHandler(this.btn_AgregarCalcular_Click);
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_PrecioProducto.Location = new System.Drawing.Point(251, 175);
            this.txt_PrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(77, 22);
            this.txt_PrecioProducto.TabIndex = 19;
            // 
            // txt_Producto
            // 
            this.txt_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_Producto.Location = new System.Drawing.Point(251, 143);
            this.txt_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(197, 22);
            this.txt_Producto.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Descuento Sobre el Total de la Factura";
            // 
            // Segundo_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 488);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPagarTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AgregarCalcular);
            this.Controls.Add(this.txt_PrecioProducto);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Segundo_Formulario";
            this.Text = "Segundo_Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPagarTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AgregarCalcular;
        private System.Windows.Forms.TextBox txt_PrecioProducto;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}