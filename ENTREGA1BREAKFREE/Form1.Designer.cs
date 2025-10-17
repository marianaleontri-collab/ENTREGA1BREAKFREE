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
            btn_ingresar = new Button();
            btn_registrar = new Button();
            lkl_olvido_su_contraseña = new LinkLabel();
            lb_usuario = new Label();
            lb_contraseña = new Label();
            tx_usuario_data = new TextBox();
            tx_contraseña_data = new TextBox();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(202, 143, 250);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.ImageAlign = ContentAlignment.MiddleRight;
            btn_ingresar.Location = new Point(55, 301);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(127, 29);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.TextAlign = ContentAlignment.TopCenter;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += Ingresar_Click;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.FromArgb(202, 143, 250);
            btn_registrar.FlatStyle = FlatStyle.Flat;
            btn_registrar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_registrar.Location = new Point(431, 301);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(136, 29);
            btn_registrar.TabIndex = 1;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += button2_Click;
            // 
            // lkl_olvido_su_contraseña
            // 
            lkl_olvido_su_contraseña.AutoSize = true;
            lkl_olvido_su_contraseña.BackColor = Color.White;
            lkl_olvido_su_contraseña.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lkl_olvido_su_contraseña.Location = new Point(232, 175);
            lkl_olvido_su_contraseña.Name = "lkl_olvido_su_contraseña";
            lkl_olvido_su_contraseña.Size = new Size(178, 18);
            lkl_olvido_su_contraseña.TabIndex = 2;
            lkl_olvido_su_contraseña.TabStop = true;
            lkl_olvido_su_contraseña.Text = "OLVIDO SU CONTRASEÑA?";
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.BackColor = Color.FromArgb(211, 250, 143);
            lb_usuario.BorderStyle = BorderStyle.Fixed3D;
            lb_usuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_usuario.ForeColor = SystemColors.ControlText;
            lb_usuario.Location = new Point(73, 58);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(88, 24);
            lb_usuario.TabIndex = 3;
            lb_usuario.Text = "USUARIO";
            lb_usuario.Click += label1_Click;
            // 
            // lb_contraseña
            // 
            lb_contraseña.AutoSize = true;
            lb_contraseña.BackColor = Color.FromArgb(211, 250, 143);
            lb_contraseña.BorderStyle = BorderStyle.Fixed3D;
            lb_contraseña.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_contraseña.Location = new Point(73, 130);
            lb_contraseña.Name = "lb_contraseña";
            lb_contraseña.Size = new Size(129, 24);
            lb_contraseña.TabIndex = 4;
            lb_contraseña.Text = "CONTRASEÑA";
            // 
            // tx_usuario_data
            // 
            tx_usuario_data.BackColor = Color.FromArgb(255, 192, 192);
            tx_usuario_data.Location = new Point(232, 57);
            tx_usuario_data.Name = "tx_usuario_data";
            tx_usuario_data.Size = new Size(236, 23);
            tx_usuario_data.TabIndex = 5;
            tx_usuario_data.TextChanged += tx_usuario_data_TextChanged;
            // 
            // tx_contraseña_data
            // 
            tx_contraseña_data.BackColor = Color.FromArgb(255, 192, 192);
            tx_contraseña_data.Location = new Point(232, 129);
            tx_contraseña_data.Name = "tx_contraseña_data";
            tx_contraseña_data.Size = new Size(236, 23);
            tx_contraseña_data.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 381);
            Controls.Add(tx_contraseña_data);
            Controls.Add(tx_usuario_data);
            Controls.Add(lb_contraseña);
            Controls.Add(lb_usuario);
            Controls.Add(lkl_olvido_su_contraseña);
            Controls.Add(btn_registrar);
            Controls.Add(btn_ingresar);
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresar;
        private Button btn_registrar;
        private LinkLabel lkl_olvido_su_contraseña;
        private Label lb_usuario;
        private Label lb_contraseña;
        private TextBox tx_usuario_data;
        private TextBox tx_contraseña_data;
    }
}
