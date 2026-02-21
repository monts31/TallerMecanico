namespace TallerMecanico
{
    partial class servicios
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
            dataGridView1 = new DataGridView();
            Servicio = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtCosto = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 374);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Servicio
            // 
            Servicio.AutoSize = true;
            Servicio.Location = new Point(102, 46);
            Servicio.Name = "Servicio";
            Servicio.Size = new Size(48, 15);
            Servicio.TabIndex = 1;
            Servicio.Text = "Servicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 79);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Clave del servicio";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 146);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 164);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 205);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 223);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(233, 57);
            txtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 289);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Costo base";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(27, 307);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(233, 23);
            txtCosto.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 350);
            label5.Name = "label5";
            label5.Size = new Size(159, 15);
            label5.TabIndex = 10;
            label5.Text = "Tiempo estimado de servicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(27, 368);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 36);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Guardar servicio";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 482);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtCosto);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Servicio);
            Controls.Add(dataGridView1);
            Name = "servicios";
            Text = "servicios";
            Load += servicios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Servicio;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtCosto;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}