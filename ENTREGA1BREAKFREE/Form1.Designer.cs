namespace ENTREGA1BREAKFREE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Ingresar = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.FromArgb(202, 143, 250);
            Ingresar.FlatStyle = FlatStyle.Flat;
            Ingresar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ingresar.ImageAlign = ContentAlignment.MiddleRight;
            Ingresar.Location = new Point(55, 301);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(127, 29);
            Ingresar.TabIndex = 0;
            Ingresar.Text = "INGRESAR";
            Ingresar.TextAlign = ContentAlignment.TopCenter;
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(202, 143, 250);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(431, 301);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 1;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(265, 206);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 18);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "OLVIDO SU CONTRASEÑA?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(211, 250, 143);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(73, 58);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(211, 250, 143);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 130);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 4;
            label2.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 192);
            textBox1.Location = new Point(232, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 192);
            textBox2.Location = new Point(232, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 381);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(Ingresar);
            Name = "Form1";
            Text = "LOGIN";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ingresar;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
