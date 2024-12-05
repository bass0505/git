namespace Proyecto_ENE.Forms
{
    partial class AgregarTrabajador
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            txt_valorHoraExtra = new TextBox();
            txt_valorHora = new TextBox();
            txt_telefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            txt_rut = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            calcularSueldoToolStripMenuItem = new ToolStripMenuItem();
            listaTrabajadoresToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_valorHoraExtra);
            groupBox1.Controls.Add(txt_valorHora);
            groupBox1.Controls.Add(txt_telefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_direccion);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(txt_rut);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Datos Trabajador";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(209, 281);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Listar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(113, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_valorHoraExtra
            // 
            txt_valorHoraExtra.Location = new Point(113, 218);
            txt_valorHoraExtra.Name = "txt_valorHoraExtra";
            txt_valorHoraExtra.Size = new Size(152, 23);
            txt_valorHoraExtra.TabIndex = 11;
            txt_valorHoraExtra.KeyPress += txt_valorHoraExtra_KeyPress;
            // 
            // txt_valorHora
            // 
            txt_valorHora.Location = new Point(113, 181);
            txt_valorHora.Name = "txt_valorHora";
            txt_valorHora.Size = new Size(152, 23);
            txt_valorHora.TabIndex = 10;
            txt_valorHora.KeyPress += txt_valorHora_KeyPress;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(113, 144);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(152, 23);
            txt_telefono.TabIndex = 9;
            txt_telefono.KeyPress += txt_telefono_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 226);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor Hora Extra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 189);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 7;
            label5.Text = "Valor Hora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 152);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 6;
            label6.Text = "Teléfono";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(113, 107);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(152, 23);
            txt_direccion.TabIndex = 5;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(113, 70);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(152, 23);
            txt_nombre.TabIndex = 4;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_rut
            // 
            txt_rut.Location = new Point(113, 33);
            txt_rut.Name = "txt_rut";
            txt_rut.Size = new Size(152, 23);
            txt_rut.TabIndex = 3;
            txt_rut.TextChanged += txt_rut_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 115);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Rut";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(435, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calcularSueldoToolStripMenuItem, listaTrabajadoresToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // calcularSueldoToolStripMenuItem
            // 
            calcularSueldoToolStripMenuItem.Name = "calcularSueldoToolStripMenuItem";
            calcularSueldoToolStripMenuItem.Size = new Size(104, 22);
            calcularSueldoToolStripMenuItem.Text = "Login";
            calcularSueldoToolStripMenuItem.Click += calcularSueldoToolStripMenuItem_Click;
            // 
            // listaTrabajadoresToolStripMenuItem
            // 
            listaTrabajadoresToolStripMenuItem.Name = "listaTrabajadoresToolStripMenuItem";
            listaTrabajadoresToolStripMenuItem.Size = new Size(104, 22);
            listaTrabajadoresToolStripMenuItem.Text = "Salir";
            listaTrabajadoresToolStripMenuItem.Click += listaTrabajadoresToolStripMenuItem_Click;
            // 
            // AgregarTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(435, 435);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AgregarTrabajador";
            Text = "AgregarTrabajador";
            Load += AgregarTrabajador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_nombre;
        private TextBox txt_rut;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_direccion;
        private TextBox txt_valorHoraExtra;
        private TextBox txt_valorHora;
        private TextBox txt_telefono;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem calcularSueldoToolStripMenuItem;
        private ToolStripMenuItem listaTrabajadoresToolStripMenuItem;
        private Button button2;
    }
}