namespace Proyecto_ENE.Forms
{
    partial class CalcularSueldo
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
            txt_horasTrabajadas = new TextBox();
            txt_horasextras = new TextBox();
            cmb_afp = new ComboBox();
            cmb_salud = new ComboBox();
            btn_calcular = new Button();
            btn_guardar = new Button();
            btn_limpiar = new Button();
            btn_listar = new Button();
            label3 = new Label();
            label4 = new Label();
            lbl_sueldoBruto = new Label();
            lbl_sueldoLiquido = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 0;
            label1.Text = "Horas Trabajadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 1;
            label2.Text = "Horas Extras";
            // 
            // txt_horasTrabajadas
            // 
            txt_horasTrabajadas.Location = new Point(146, 31);
            txt_horasTrabajadas.Name = "txt_horasTrabajadas";
            txt_horasTrabajadas.Size = new Size(100, 23);
            txt_horasTrabajadas.TabIndex = 2;
            txt_horasTrabajadas.TextChanged += txt_horasTrabajadas_TextChanged;
            txt_horasTrabajadas.KeyPress += txt_horasTrabajadas_KeyPress;
            // 
            // txt_horasextras
            // 
            txt_horasextras.Location = new Point(146, 74);
            txt_horasextras.Name = "txt_horasextras";
            txt_horasextras.Size = new Size(100, 23);
            txt_horasextras.TabIndex = 3;
            txt_horasextras.TextChanged += txt_horasextras_TextChanged;
            txt_horasextras.KeyPress += txt_horasextras_KeyPress;
            // 
            // cmb_afp
            // 
            cmb_afp.FormattingEnabled = true;
            cmb_afp.Items.AddRange(new object[] { "CUPRUM", "MODELO", "CAPITAL", "PROVIDA" });
            cmb_afp.Location = new Point(339, 36);
            cmb_afp.Name = "cmb_afp";
            cmb_afp.Size = new Size(121, 23);
            cmb_afp.TabIndex = 4;
            // 
            // cmb_salud
            // 
            cmb_salud.FormattingEnabled = true;
            cmb_salud.Items.AddRange(new object[] { "FONASA", "CONSALUD", "MASVIDA ", "BANMEDICA" });
            cmb_salud.Location = new Point(339, 79);
            cmb_salud.Name = "cmb_salud";
            cmb_salud.Size = new Size(121, 23);
            cmb_salud.TabIndex = 5;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(48, 138);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(75, 23);
            btn_calcular.TabIndex = 6;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(48, 181);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(48, 222);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 52);
            btn_limpiar.TabIndex = 8;
            btn_limpiar.Text = "Limpiar Campos";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_listar
            // 
            btn_listar.Location = new Point(48, 280);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(75, 23);
            btn_listar.TabIndex = 9;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += btn_listar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(271, 216);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 10;
            label3.Text = "Sueldo Bruto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 255);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 11;
            label4.Text = "Sueldo Liquido";
            // 
            // lbl_sueldoBruto
            // 
            lbl_sueldoBruto.AutoSize = true;
            lbl_sueldoBruto.Font = new Font("Segoe UI", 12F);
            lbl_sueldoBruto.Location = new Point(397, 216);
            lbl_sueldoBruto.Name = "lbl_sueldoBruto";
            lbl_sueldoBruto.Size = new Size(28, 21);
            lbl_sueldoBruto.TabIndex = 12;
            lbl_sueldoBruto.Text = "$0";
            lbl_sueldoBruto.Click += lbl_sueldoBruto_Click;
            // 
            // lbl_sueldoLiquido
            // 
            lbl_sueldoLiquido.AutoSize = true;
            lbl_sueldoLiquido.Font = new Font("Segoe UI", 12F);
            lbl_sueldoLiquido.Location = new Point(397, 255);
            lbl_sueldoLiquido.Name = "lbl_sueldoLiquido";
            lbl_sueldoLiquido.Size = new Size(28, 21);
            lbl_sueldoLiquido.TabIndex = 13;
            lbl_sueldoLiquido.Text = "$0";
            // 
            // CalcularSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 385);
            Controls.Add(lbl_sueldoLiquido);
            Controls.Add(lbl_sueldoBruto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_listar);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_calcular);
            Controls.Add(cmb_salud);
            Controls.Add(cmb_afp);
            Controls.Add(txt_horasextras);
            Controls.Add(txt_horasTrabajadas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalcularSueldo";
            Text = "CalcularSueldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_horasTrabajadas;
        private TextBox txt_horasextras;
        private ComboBox cmb_afp;
        private ComboBox cmb_salud;
        private Button btn_calcular;
        private Button btn_guardar;
        private Button btn_limpiar;
        private Button btn_listar;
        private Label label3;
        private Label label4;
        private Label lbl_sueldoBruto;
        private Label lbl_sueldoLiquido;
    }
}