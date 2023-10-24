namespace CAI.Ej02
{
    partial class Ejercicio02
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            comboBoxMarca = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            txtPrecio = new TextBox();
            lblNombreUsuario = new Label();
            lblFechaActual = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(354, 133);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 32);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(442, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(12, 63);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(197, 23);
            comboBoxMarca.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 45);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 45);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 45);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(215, 63);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 7;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(321, 63);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(427, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 9;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(12, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(109, 15);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Location = new Point(416, 9);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(75, 15);
            lblFechaActual.TabIndex = 11;
            lblFechaActual.Text = "Fecha Actual";
            lblFechaActual.TextAlign = ContentAlignment.TopRight;
            // 
            // Ejercicio02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 177);
            Controls.Add(lblFechaActual);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtPrecio);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMarca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "Ejercicio02";
            Text = "Form1";
            Load += Ejercicio02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox comboBoxMarca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModelo;
        private TextBox txtAño;
        private TextBox txtPrecio;
        private Label lblNombreUsuario;
        private Label lblFechaActual;
    }
}