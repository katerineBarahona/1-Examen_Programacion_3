namespace Examen_1_programacion_3
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
            this.Txt_InteresesGanadosAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalInteresesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InteresesMensualButton = new System.Windows.Forms.Button();
            this.CantidadDepositadaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MesesListBox = new System.Windows.Forms.ListBox();
            this.InteresMensualTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_InteresesGanadosAño
            // 
            this.Txt_InteresesGanadosAño.Location = new System.Drawing.Point(570, 617);
            this.Txt_InteresesGanadosAño.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_InteresesGanadosAño.Name = "Txt_InteresesGanadosAño";
            this.Txt_InteresesGanadosAño.Size = new System.Drawing.Size(165, 22);
            this.Txt_InteresesGanadosAño.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 620);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Depósito con intereses ganados a fin de año:";
            // 
            // TotalInteresesTextBox
            // 
            this.TotalInteresesTextBox.Location = new System.Drawing.Point(381, 576);
            this.TotalInteresesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalInteresesTextBox.Name = "TotalInteresesTextBox";
            this.TotalInteresesTextBox.Size = new System.Drawing.Size(155, 22);
            this.TotalInteresesTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 580);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total intereses:";
            // 
            // InteresesMensualButton
            // 
            this.InteresesMensualButton.Location = new System.Drawing.Point(647, 251);
            this.InteresesMensualButton.Margin = new System.Windows.Forms.Padding(4);
            this.InteresesMensualButton.Name = "InteresesMensualButton";
            this.InteresesMensualButton.Size = new System.Drawing.Size(133, 46);
            this.InteresesMensualButton.TabIndex = 22;
            this.InteresesMensualButton.Text = "Mostrar Intereses por mes";
            this.InteresesMensualButton.UseVisualStyleBackColor = true;
            this.InteresesMensualButton.Click += new System.EventHandler(this.InteresesMensualButton_Click);
            // 
            // CantidadDepositadaTextBox
            // 
            this.CantidadDepositadaTextBox.Location = new System.Drawing.Point(449, 236);
            this.CantidadDepositadaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadDepositadaTextBox.Name = "CantidadDepositadaTextBox";
            this.CantidadDepositadaTextBox.ReadOnly = true;
            this.CantidadDepositadaTextBox.Size = new System.Drawing.Size(171, 22);
            this.CantidadDepositadaTextBox.TabIndex = 21;
            this.CantidadDepositadaTextBox.Text = "200000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad Depositada:";
            // 
            // MesesListBox
            // 
            this.MesesListBox.FormattingEnabled = true;
            this.MesesListBox.ItemHeight = 16;
            this.MesesListBox.Location = new System.Drawing.Point(226, 304);
            this.MesesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MesesListBox.Name = "MesesListBox";
            this.MesesListBox.Size = new System.Drawing.Size(447, 260);
            this.MesesListBox.TabIndex = 19;
            // 
            // InteresMensualTextBox
            // 
            this.InteresMensualTextBox.Location = new System.Drawing.Point(449, 268);
            this.InteresMensualTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InteresMensualTextBox.Name = "InteresMensualTextBox";
            this.InteresMensualTextBox.Size = new System.Drawing.Size(131, 22);
            this.InteresMensualTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de intereses cada mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "La cantidad depositada es de L.200,000.00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 159);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de depóstio cliente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 798);
            this.Controls.Add(this.Txt_InteresesGanadosAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalInteresesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InteresesMensualButton);
            this.Controls.Add(this.CantidadDepositadaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MesesListBox);
            this.Controls.Add(this.InteresMensualTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_InteresesGanadosAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalInteresesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InteresesMensualButton;
        private System.Windows.Forms.TextBox CantidadDepositadaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox MesesListBox;
        private System.Windows.Forms.TextBox InteresMensualTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}

