namespace TallerMecanico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnServicios = new Button();
            btnRefacciones = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 20, 46);
            label1.Location = new Point(105, 27);
            label1.Name = "label1";
            label1.Size = new Size(388, 43);
            label1.TabIndex = 0;
            label1.Text = "Taller mecanico movil ";
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.DarkSlateBlue;
            btnServicios.Font = new Font("Sylfaen", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnServicios.ForeColor = Color.Lavender;
            btnServicios.Location = new Point(90, 127);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(171, 82);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnRefacciones
            // 
            btnRefacciones.BackColor = Color.DarkSlateBlue;
            btnRefacciones.Font = new Font("Sylfaen", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRefacciones.ForeColor = Color.Lavender;
            btnRefacciones.Location = new Point(326, 127);
            btnRefacciones.Name = "btnRefacciones";
            btnRefacciones.Size = new Size(189, 82);
            btnRefacciones.TabIndex = 2;
            btnRefacciones.Text = "Refacciones";
            btnRefacciones.UseVisualStyleBackColor = false;
            btnRefacciones.Click += btnRefacciones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(602, 309);
            Controls.Add(btnRefacciones);
            Controls.Add(btnServicios);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnServicios;
        private Button btnRefacciones;
    }
}
