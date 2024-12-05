namespace Proyecto_ENE.Forms
{
    partial class ListaTrabajadorSueldo
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
            dvg_resultado = new DataGridView();
            cmb_lista = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_rut = new TextBox();
            txt_nombre = new TextBox();
            txt_direccion = new TextBox();
            btn_ingresar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            txt_sueldo = new TextBox();
            label5 = new Label();
            btn_calcularSueldo = new Button();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dvg_resultado).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dvg_resultado
            // 
            dvg_resultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_resultado.Location = new Point(313, 147);
            dvg_resultado.Name = "dvg_resultado";
            dvg_resultado.Size = new Size(448, 205);
            dvg_resultado.TabIndex = 5;
            dvg_resultado.CellContentClick += dvg_resultado_CellContentClick;
            dvg_resultado.SelectionChanged += dvg_resultado_SelectionChanged;
            // 
            // cmb_lista
            // 
            cmb_lista.FormattingEnabled = true;
            cmb_lista.Items.AddRange(new object[] { "TODOS" });
            cmb_lista.Location = new Point(464, 99);
            cmb_lista.Name = "cmb_lista";
            cmb_lista.Size = new Size(121, 23);
            cmb_lista.TabIndex = 4;
            cmb_lista.SelectedIndexChanged += cmb_lista_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 99);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 3;
            label1.Text = "Trabajador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 187);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 6;
            label2.Text = "Rut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 242);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 297);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Dirección";
            // 
            // txt_rut
            // 
            txt_rut.Location = new Point(108, 179);
            txt_rut.Name = "txt_rut";
            txt_rut.Size = new Size(100, 23);
            txt_rut.TabIndex = 9;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(108, 234);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 10;
            txt_nombre.TextChanged += txt_nombre_TextChanged;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(108, 289);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 11;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(112, 329);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 12;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Visible = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(366, 372);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(104, 49);
            btn_modificar.TabIndex = 13;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(597, 372);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(106, 49);
            btn_eliminar.TabIndex = 14;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txt_sueldo
            // 
            txt_sueldo.Enabled = false;
            txt_sueldo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txt_sueldo.Location = new Point(108, 127);
            txt_sueldo.Name = "txt_sueldo";
            txt_sueldo.Size = new Size(100, 27);
            txt_sueldo.TabIndex = 16;
            txt_sueldo.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 135);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 15;
            label5.Text = "Sueldo Liquido";
            // 
            // btn_calcularSueldo
            // 
            btn_calcularSueldo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_calcularSueldo.Location = new Point(214, 127);
            btn_calcularSueldo.Name = "btn_calcularSueldo";
            btn_calcularSueldo.Size = new Size(93, 27);
            btn_calcularSueldo.TabIndex = 17;
            btn_calcularSueldo.Text = "Calcular";
            btn_calcularSueldo.UseVisualStyleBackColor = true;
            btn_calcularSueldo.Click += btn_calcularSueldo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 65);
            label6.Name = "label6";
            label6.Size = new Size(313, 25);
            label6.TabIndex = 18;
            label6.Text = "Calcule su sueldo y llene sus datos";
            label6.Click += label6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 19;
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
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ListaTrabajadorSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btn_calcularSueldo);
            Controls.Add(txt_sueldo);
            Controls.Add(label5);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_ingresar);
            Controls.Add(txt_direccion);
            Controls.Add(txt_nombre);
            Controls.Add(txt_rut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dvg_resultado);
            Controls.Add(cmb_lista);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListaTrabajadorSueldo";
            Text = "ListaTrabajadorSueldo";
            Load += ListaTrabajadorSueldo_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_resultado).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_resultado;
        private ComboBox cmb_lista;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_rut;
        private TextBox txt_nombre;
        private TextBox txt_direccion;
        private Button btn_ingresar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private TextBox txt_sueldo;
        private Label label5;
        private Button btn_calcularSueldo;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}