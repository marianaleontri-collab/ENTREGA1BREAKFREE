namespace ENTREGA1BREAKFREE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btn_usuarios = new Button();
            btn_asesoria = new Button();
            btn_consultas = new Button();
            dataGridView1 = new DataGridView();
            promp1 = new DataGridViewTextBoxColumn();
            promp2 = new DataGridViewTextBoxColumn();
            promp3 = new DataGridViewTextBoxColumn();
            Datos = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_regresar2 = new Button();
            btn_siguiente2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 187, 252);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 68);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 187, 252);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btn_usuarios);
            panel2.Controls.Add(btn_asesoria);
            panel2.Controls.Add(btn_consultas);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 366);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.FromArgb(250, 252, 187);
            btn_usuarios.FlatAppearance.BorderColor = Color.Black;
            btn_usuarios.FlatAppearance.BorderSize = 2;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btn_usuarios.ForeColor = Color.Black;
            btn_usuarios.Location = new Point(26, 181);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(102, 39);
            btn_usuarios.TabIndex = 2;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btn_asesoria
            // 
            btn_asesoria.BackColor = Color.FromArgb(250, 252, 187);
            btn_asesoria.FlatAppearance.BorderColor = Color.Black;
            btn_asesoria.FlatAppearance.BorderSize = 2;
            btn_asesoria.FlatStyle = FlatStyle.Flat;
            btn_asesoria.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btn_asesoria.ForeColor = Color.Black;
            btn_asesoria.Location = new Point(26, 117);
            btn_asesoria.Name = "btn_asesoria";
            btn_asesoria.Size = new Size(102, 39);
            btn_asesoria.TabIndex = 1;
            btn_asesoria.Text = "Asesoria";
            btn_asesoria.UseVisualStyleBackColor = false;
            btn_asesoria.Click += btn_asesoria_Click;
            // 
            // btn_consultas
            // 
            btn_consultas.BackColor = Color.FromArgb(250, 252, 187);
            btn_consultas.FlatAppearance.BorderColor = Color.Black;
            btn_consultas.FlatAppearance.BorderSize = 2;
            btn_consultas.FlatStyle = FlatStyle.Flat;
            btn_consultas.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultas.ForeColor = Color.Black;
            btn_consultas.Location = new Point(26, 61);
            btn_consultas.Name = "btn_consultas";
            btn_consultas.Size = new Size(102, 39);
            btn_consultas.TabIndex = 0;
            btn_consultas.Text = "Consultas";
            btn_consultas.UseVisualStyleBackColor = false;
            btn_consultas.Click += btn_consultas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(250, 182, 143);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { promp1, promp2, promp3, Datos });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(178, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(435, 143);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // promp1
            // 
            promp1.HeaderText = " Consultas";
            promp1.Name = "promp1";
            // 
            // promp2
            // 
            promp2.HeaderText = "Asesoria";
            promp2.Name = "promp2";
            // 
            // promp3
            // 
            promp3.HeaderText = "Usuarios";
            promp3.Name = "promp3";
            // 
            // Datos
            // 
            Datos.HeaderText = "Reportes";
            Datos.Name = "Datos";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(250, 252, 187);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            button4.Location = new Point(630, 174);
            button4.Name = "button4";
            button4.Size = new Size(119, 34);
            button4.TabIndex = 3;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(250, 252, 187);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            button5.Location = new Point(630, 218);
            button5.Name = "button5";
            button5.Size = new Size(119, 34);
            button5.TabIndex = 4;
            button5.Text = "Exportar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(250, 252, 187);
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            button6.Location = new Point(630, 265);
            button6.Name = "button6";
            button6.Size = new Size(119, 34);
            button6.TabIndex = 5;
            button6.Text = "Crear";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 111);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(444, 30);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_regresar2
            // 
            btn_regresar2.BackColor = Color.FromArgb(143, 228, 250);
            btn_regresar2.FlatStyle = FlatStyle.Flat;
            btn_regresar2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar2.Location = new Point(178, 344);
            btn_regresar2.Name = "btn_regresar2";
            btn_regresar2.Size = new Size(141, 31);
            btn_regresar2.TabIndex = 9;
            btn_regresar2.Text = "REGRESAR";
            btn_regresar2.UseVisualStyleBackColor = false;
            btn_regresar2.Click += btn_regresar_Click;
            // 
            // btn_siguiente2
            // 
            btn_siguiente2.BackColor = Color.FromArgb(143, 228, 250);
            btn_siguiente2.FlatStyle = FlatStyle.Flat;
            btn_siguiente2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_siguiente2.Location = new Point(597, 344);
            btn_siguiente2.Name = "btn_siguiente2";
            btn_siguiente2.Size = new Size(141, 31);
            btn_siguiente2.TabIndex = 10;
            btn_siguiente2.Text = "SIGUIENTE";
            btn_siguiente2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(178, 381);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(141, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(597, 381);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(141, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(761, 434);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btn_siguiente2);
            Controls.Add(btn_regresar2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "DISEÑO INTERFAZ";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_usuarios;
        private Button btn_asesoria;
        private Button btn_consultas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn promp1;
        private DataGridViewTextBoxColumn promp2;
        private DataGridViewTextBoxColumn promp3;
        private DataGridViewTextBoxColumn Datos;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_regresar2;
        private Button btn_siguiente2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}