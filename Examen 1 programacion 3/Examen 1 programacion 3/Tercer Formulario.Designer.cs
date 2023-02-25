namespace Examen_1_programacion_3
{
    partial class Tercer_Formulario
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
            this.ValoresListBox = new System.Windows.Forms.ListBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValoresListBox
            // 
            this.ValoresListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ValoresListBox.FormattingEnabled = true;
            this.ValoresListBox.ItemHeight = 16;
            this.ValoresListBox.Location = new System.Drawing.Point(285, 136);
            this.ValoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValoresListBox.Name = "ValoresListBox";
            this.ValoresListBox.Size = new System.Drawing.Size(231, 340);
            this.ValoresListBox.TabIndex = 3;
            // 
            // MostrarButton
            // 
            this.MostrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MostrarButton.Location = new System.Drawing.Point(305, 66);
            this.MostrarButton.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(199, 44);
            this.MostrarButton.TabIndex = 2;
            this.MostrarButton.Text = "Mostrar ";
            this.MostrarButton.UseVisualStyleBackColor = false;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Tercer_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.ValoresListBox);
            this.Controls.Add(this.MostrarButton);
            this.Name = "Tercer_Formulario";
            this.Text = "Tercer_Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ValoresListBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}