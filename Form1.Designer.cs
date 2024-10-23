namespace Simulador_Vehiculos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsumoNafta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTanque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearNaftero = new System.Windows.Forms.Button();
            this.btnCrearHibrido = new System.Windows.Forms.Button();
            this.txtConsumoBateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViajar = new System.Windows.Forms.Button();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCargarCombustible = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lable9 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblKmsRecorridos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Vehículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(16, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(150, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(16, 106);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(150, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // txtConsumoNafta
            // 
            this.txtConsumoNafta.Location = new System.Drawing.Point(16, 191);
            this.txtConsumoNafta.Name = "txtConsumoNafta";
            this.txtConsumoNafta.Size = new System.Drawing.Size(150, 20);
            this.txtConsumoNafta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Consumo Km/Litro";
            // 
            // txtTanque
            // 
            this.txtTanque.Location = new System.Drawing.Point(16, 149);
            this.txtTanque.Name = "txtTanque";
            this.txtTanque.Size = new System.Drawing.Size(150, 20);
            this.txtTanque.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Capacidad Tanque";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCrearNaftero
            // 
            this.btnCrearNaftero.Location = new System.Drawing.Point(36, 217);
            this.btnCrearNaftero.Name = "btnCrearNaftero";
            this.btnCrearNaftero.Size = new System.Drawing.Size(111, 31);
            this.btnCrearNaftero.TabIndex = 10;
            this.btnCrearNaftero.Text = "Crear Auto Nafta";
            this.btnCrearNaftero.UseVisualStyleBackColor = true;
            this.btnCrearNaftero.Click += new System.EventHandler(this.btnCrearNaftero_Click);
            // 
            // btnCrearHibrido
            // 
            this.btnCrearHibrido.Location = new System.Drawing.Point(36, 303);
            this.btnCrearHibrido.Name = "btnCrearHibrido";
            this.btnCrearHibrido.Size = new System.Drawing.Size(111, 31);
            this.btnCrearHibrido.TabIndex = 13;
            this.btnCrearHibrido.Text = "Crear Auto Híbrido";
            this.btnCrearHibrido.UseVisualStyleBackColor = true;
            this.btnCrearHibrido.Click += new System.EventHandler(this.btnCrearHibrido_Click);
            // 
            // txtConsumoBateria
            // 
            this.txtConsumoBateria.Location = new System.Drawing.Point(16, 277);
            this.txtConsumoBateria.Name = "txtConsumoBateria";
            this.txtConsumoBateria.Size = new System.Drawing.Size(150, 20);
            this.txtConsumoBateria.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Consumo Bateria/KM";
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(275, 90);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(111, 31);
            this.btnViajar.TabIndex = 16;
            this.btnViajar.Text = "Simular Viaje";
            this.btnViajar.UseVisualStyleBackColor = true;
            this.btnViajar.Click += new System.EventHandler(this.btnViajar_Click);
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(255, 64);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(150, 20);
            this.txtKms.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kms Recorridos";
            // 
            // btnCargarCombustible
            // 
            this.btnCargarCombustible.Location = new System.Drawing.Point(275, 157);
            this.btnCargarCombustible.Name = "btnCargarCombustible";
            this.btnCargarCombustible.Size = new System.Drawing.Size(111, 31);
            this.btnCargarCombustible.TabIndex = 17;
            this.btnCargarCombustible.Text = "Cargar Combustible";
            this.btnCargarCombustible.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cargar Batería";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Location = new System.Drawing.Point(275, 247);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(97, 13);
            this.lable9.TabIndex = 19;
            this.lable9.Text = "Combustible Actual";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(275, 294);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(93, 13);
            this.lbl9.TabIndex = 20;
            this.lbl9.Text = "Kms Recorridos: 0";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(311, 261);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(29, 20);
            this.lblCombustible.TabIndex = 21;
            this.lblCombustible.Text = "0L";
            // 
            // lblKmsRecorridos
            // 
            this.lblKmsRecorridos.AutoSize = true;
            this.lblKmsRecorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmsRecorridos.Location = new System.Drawing.Point(303, 314);
            this.lblKmsRecorridos.Name = "lblKmsRecorridos";
            this.lblKmsRecorridos.Size = new System.Drawing.Size(44, 20);
            this.lblKmsRecorridos.TabIndex = 23;
            this.lblKmsRecorridos.Text = "0KM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 357);
            this.Controls.Add(this.lblKmsRecorridos);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lable9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargarCombustible);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCrearHibrido);
            this.Controls.Add(this.txtConsumoBateria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCrearNaftero);
            this.Controls.Add(this.txtConsumoNafta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTanque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsumoNafta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTanque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrearNaftero;
        private System.Windows.Forms.Button btnCrearHibrido;
        private System.Windows.Forms.TextBox txtConsumoBateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViajar;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargarCombustible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblKmsRecorridos;
    }
}

