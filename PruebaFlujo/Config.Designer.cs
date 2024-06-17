namespace PruebaFlujo
{
    partial class Config
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
            label3 = new Label();
            txtUrlBaseVA = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            txtUrlBaseCD = new TextBox();
            rbFintoc = new RadioButton();
            rbMercadoPagoDebito = new RadioButton();
            rbKlapDebito = new RadioButton();
            rbPatPass = new RadioButton();
            gbPagos = new GroupBox();
            rbMercadoPagoCredito = new RadioButton();
            rbKlapCredito = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            gbPagos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(295, 30);
            label1.TabIndex = 17;
            label1.Text = "Medio de pago para pruebas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(21, 336);
            label2.Name = "label2";
            label2.Size = new Size(290, 30);
            label2.TabIndex = 22;
            label2.Text = "Configuración de ambientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(23, 371);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 23;
            label3.Text = "Desarrollo";
            // 
            // txtUrlBaseVA
            // 
            txtUrlBaseVA.Location = new Point(105, 395);
            txtUrlBaseVA.Name = "txtUrlBaseVA";
            txtUrlBaseVA.Size = new Size(157, 23);
            txtUrlBaseVA.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(323, 493);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 25;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 399);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 26;
            label4.Text = "Base URL VA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 426);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 28;
            label5.Text = "Base URL CD:";
            // 
            // txtUrlBaseCD
            // 
            txtUrlBaseCD.Location = new Point(105, 422);
            txtUrlBaseCD.Name = "txtUrlBaseCD";
            txtUrlBaseCD.Size = new Size(157, 23);
            txtUrlBaseCD.TabIndex = 27;
            // 
            // rbFintoc
            // 
            rbFintoc.AutoSize = true;
            rbFintoc.Checked = true;
            rbFintoc.Location = new Point(19, 48);
            rbFintoc.Name = "rbFintoc";
            rbFintoc.Size = new Size(58, 19);
            rbFintoc.TabIndex = 29;
            rbFintoc.TabStop = true;
            rbFintoc.Text = "Fintoc";
            rbFintoc.UseVisualStyleBackColor = true;
            // 
            // rbMercadoPagoDebito
            // 
            rbMercadoPagoDebito.AutoSize = true;
            rbMercadoPagoDebito.Location = new Point(20, 105);
            rbMercadoPagoDebito.Name = "rbMercadoPagoDebito";
            rbMercadoPagoDebito.Size = new Size(140, 19);
            rbMercadoPagoDebito.TabIndex = 30;
            rbMercadoPagoDebito.TabStop = true;
            rbMercadoPagoDebito.Text = "Mercado Pago Débito";
            rbMercadoPagoDebito.UseVisualStyleBackColor = true;
            // 
            // rbKlapDebito
            // 
            rbKlapDebito.AutoSize = true;
            rbKlapDebito.Location = new Point(19, 156);
            rbKlapDebito.Name = "rbKlapDebito";
            rbKlapDebito.Size = new Size(86, 19);
            rbKlapDebito.TabIndex = 31;
            rbKlapDebito.TabStop = true;
            rbKlapDebito.Text = "Klap Débito";
            rbKlapDebito.UseVisualStyleBackColor = true;
            // 
            // rbPatPass
            // 
            rbPatPass.AutoSize = true;
            rbPatPass.Location = new Point(19, 210);
            rbPatPass.Name = "rbPatPass";
            rbPatPass.Size = new Size(65, 19);
            rbPatPass.TabIndex = 32;
            rbPatPass.TabStop = true;
            rbPatPass.Text = "PatPass";
            rbPatPass.UseVisualStyleBackColor = true;
            // 
            // gbPagos
            // 
            gbPagos.Controls.Add(rbMercadoPagoCredito);
            gbPagos.Controls.Add(rbKlapCredito);
            gbPagos.Controls.Add(label7);
            gbPagos.Controls.Add(label6);
            gbPagos.Controls.Add(rbMercadoPagoDebito);
            gbPagos.Controls.Add(rbPatPass);
            gbPagos.Controls.Add(rbFintoc);
            gbPagos.Controls.Add(rbKlapDebito);
            gbPagos.Location = new Point(23, 57);
            gbPagos.Name = "gbPagos";
            gbPagos.Size = new Size(239, 256);
            gbPagos.TabIndex = 33;
            gbPagos.TabStop = false;
            gbPagos.Text = "Medios de pagos disponibles";
            // 
            // rbMercadoPagoCredito
            // 
            rbMercadoPagoCredito.AutoSize = true;
            rbMercadoPagoCredito.Location = new Point(19, 130);
            rbMercadoPagoCredito.Name = "rbMercadoPagoCredito";
            rbMercadoPagoCredito.Size = new Size(144, 19);
            rbMercadoPagoCredito.TabIndex = 36;
            rbMercadoPagoCredito.TabStop = true;
            rbMercadoPagoCredito.Text = "Mercado Pago Crédito";
            rbMercadoPagoCredito.UseVisualStyleBackColor = true;
            // 
            // rbKlapCredito
            // 
            rbKlapCredito.AutoSize = true;
            rbKlapCredito.Location = new Point(19, 181);
            rbKlapCredito.Name = "rbKlapCredito";
            rbKlapCredito.Size = new Size(90, 19);
            rbKlapCredito.TabIndex = 35;
            rbKlapCredito.TabStop = true;
            rbKlapCredito.Text = "Klap Crédito";
            rbKlapCredito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 28);
            label7.Name = "label7";
            label7.Size = new Size(161, 15);
            label7.TabIndex = 34;
            label7.Text = "Pago con cuenta (corriente)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 83);
            label6.Name = "label6";
            label6.Size = new Size(190, 15);
            label6.TabIndex = 33;
            label6.Text = "Pago con tarjeta (crédito, débito)";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 542);
            Controls.Add(gbPagos);
            Controls.Add(label5);
            Controls.Add(txtUrlBaseCD);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtUrlBaseVA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Config";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración";
            gbPagos.ResumeLayout(false);
            gbPagos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUrlBaseVA;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox txtUrlBaseCD;
        private RadioButton rbFintoc;
        private RadioButton rbMercadoPagoDebito;
        private RadioButton rbKlapDebito;
        private RadioButton rbPatPass;
        private GroupBox gbPagos;
        private Label label7;
        private Label label6;
        private RadioButton rbMercadoPagoCredito;
        private RadioButton rbKlapCredito;
    }
}