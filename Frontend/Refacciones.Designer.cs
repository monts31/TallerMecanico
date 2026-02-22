namespace TallerMecanico
{
    partial class Refacciones
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            Servicio = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnRegistrar = new Button();
            txtStockActual = new TextBox();
            txtStockMinimo = new TextBox();
            label6 = new Label();
            label10 = new Label();
            txtProveedor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateBlue;
            btnCancelar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Lavender;
            btnCancelar.Location = new Point(155, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 35);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(-126, 389);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 36);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Guardar servicio";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 20, 46);
            label5.Location = new Point(28, 298);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 24;
            label5.Text = "Stock actual";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(28, 251);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(233, 23);
            txtPrecio.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-126, 268);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 22;
            label4.Text = "Costo base";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(34, 192);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(233, 23);
            txtMarca.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-126, 184);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 20;
            label3.Text = "Descripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-126, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(34, 71);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(233, 23);
            txtCodigo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-126, 58);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 16;
            label1.Text = "Clave del servicio";
            // 
            // Servicio
            // 
            Servicio.AutoSize = true;
            Servicio.Location = new Point(-51, 25);
            Servicio.Name = "Servicio";
            Servicio.Size = new Size(48, 15);
            Servicio.TabIndex = 15;
            Servicio.Text = "Servicio";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(757, 374);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo.ForeColor = Color.FromArgb(19, 20, 46);
            Codigo.Location = new Point(39, 49);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(59, 19);
            Codigo.TabIndex = 28;
            Codigo.Text = "Codigo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(19, 20, 46);
            label7.Location = new Point(34, 112);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 29;
            label7.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(19, 20, 46);
            label8.Location = new Point(34, 170);
            label8.Name = "label8";
            label8.Size = new Size(50, 19);
            label8.TabIndex = 30;
            label8.Text = "Marca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(19, 20, 46);
            label9.Location = new Point(28, 229);
            label9.Name = "label9";
            label9.Size = new Size(111, 19);
            label9.TabIndex = 31;
            label9.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkSlateBlue;
            btnRegistrar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Lavender;
            btnRegistrar.Location = new Point(28, 438);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(93, 35);
            btnRegistrar.TabIndex = 32;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(28, 320);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(100, 23);
            txtStockActual.TabIndex = 33;
            txtStockActual.TextChanged += textBox2_TextChanged;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(155, 320);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 23);
            txtStockMinimo.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(19, 20, 46);
            label6.Location = new Point(155, 298);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 34;
            label6.Text = "Stock minimo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(19, 20, 46);
            label10.Location = new Point(28, 362);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 36;
            label10.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(28, 384);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(227, 23);
            txtProveedor.TabIndex = 37;
            // 
            // Refacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1078, 507);
            Controls.Add(txtProveedor);
            Controls.Add(label10);
            Controls.Add(txtStockMinimo);
            Controls.Add(label6);
            Controls.Add(txtStockActual);
            Controls.Add(btnRegistrar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Codigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(Servicio);
            Controls.Add(dataGridView1);
            Name = "Refacciones";
            Text = "Refacciones";
            Load += Refacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Label Servicio;
        private DataGridView dataGridView1;
        private Label Codigo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnRegistrar;
        private TextBox txtStockActual;
        private TextBox txtStockMinimo;
        private Label label6;
        private Label label10;
        private TextBox txtProveedor;
    }
}