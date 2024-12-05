namespace Proyecto_ENE.Forms
{
    partial class AgregarUsuario
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
            label1 = new Label();
            label2 = new Label();
            t = new Label();
            txt_usuario = new TextBox();
            txt_clave = new TextBox();
            btn_agregar = new Button();
            cbx_Tipo = new ComboBox();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 47);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(50, 147);
            t.Name = "t";
            t.Size = new Size(30, 15);
            t.TabIndex = 2;
            t.Text = "Tipo";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(128, 47);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 3;
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(128, 96);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(100, 23);
            txt_clave.TabIndex = 4;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(128, 186);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(79, 36);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // cbx_Tipo
            // 
            cbx_Tipo.FormattingEnabled = true;
            cbx_Tipo.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cbx_Tipo.Location = new Point(128, 139);
            cbx_Tipo.Name = "cbx_Tipo";
            cbx_Tipo.Size = new Size(100, 23);
            cbx_Tipo.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(286, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(104, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(104, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(286, 278);
            Controls.Add(cbx_Tipo);
            Controls.Add(btn_agregar);
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Controls.Add(t);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label t;
        private TextBox txt_usuario;
        private TextBox txt_clave;
        private Button btn_agregar;
        private ComboBox cbx_Tipo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}