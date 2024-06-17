namespace PruebaFlujo
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
            cbScreenshot = new CheckBox();
            cbLocalhost = new CheckBox();
            cbOpenBrowser = new CheckBox();
            groupBox4 = new GroupBox();
            btnQA_CD_CuotaSimbolica = new Button();
            btnQA_CD_CuotaGratis = new Button();
            btnQA_CD_CuotaNormal = new Button();
            groupBox3 = new GroupBox();
            btnQA_VA_CuotaSimbolica = new Button();
            btnQA_VA_CuotaNormal = new Button();
            btnQA_VA_CuotaGratis = new Button();
            groupBox2 = new GroupBox();
            btnDESA_CD_CuotaSimbolica = new Button();
            btnDESA_CD_CuotaGratis = new Button();
            btnDESA_CD_CuotaNormal = new Button();
            groupBox1 = new GroupBox();
            btnDesa_VA_CuotaSimbolica = new Button();
            btnDesa_VA_CuotaNormal = new Button();
            btnDesa_VA_CuotaGratis = new Button();
            label2 = new Label();
            label1 = new Label();
            btnConfig = new Button();
            gbQA = new GroupBox();
            rbUsadoQA = new RadioButton();
            rbNuevoQA = new RadioButton();
            gbDesa = new GroupBox();
            rbUsadoDesa = new RadioButton();
            rbNuevoDesa = new RadioButton();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            gbQA.SuspendLayout();
            gbDesa.SuspendLayout();
            SuspendLayout();
            // 
            // cbScreenshot
            // 
            cbScreenshot.AutoSize = true;
            cbScreenshot.ImeMode = ImeMode.NoControl;
            cbScreenshot.Location = new Point(77, 282);
            cbScreenshot.Name = "cbScreenshot";
            cbScreenshot.Size = new Size(102, 19);
            cbScreenshot.TabIndex = 28;
            cbScreenshot.Text = "Sacar capturas";
            cbScreenshot.UseVisualStyleBackColor = true;
            // 
            // cbLocalhost
            // 
            cbLocalhost.AutoSize = true;
            cbLocalhost.ImeMode = ImeMode.NoControl;
            cbLocalhost.Location = new Point(21, 69);
            cbLocalhost.Name = "cbLocalhost";
            cbLocalhost.Size = new Size(107, 19);
            cbLocalhost.TabIndex = 27;
            cbLocalhost.Text = "Sobre localhost";
            cbLocalhost.UseVisualStyleBackColor = true;
            // 
            // cbOpenBrowser
            // 
            cbOpenBrowser.AutoSize = true;
            cbOpenBrowser.Checked = true;
            cbOpenBrowser.CheckState = CheckState.Checked;
            cbOpenBrowser.ImeMode = ImeMode.NoControl;
            cbOpenBrowser.Location = new Point(77, 262);
            cbOpenBrowser.Name = "cbOpenBrowser";
            cbOpenBrowser.Size = new Size(111, 19);
            cbOpenBrowser.TabIndex = 26;
            cbOpenBrowser.Text = "Abrir navegador";
            cbOpenBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnQA_CD_CuotaSimbolica);
            groupBox4.Controls.Add(btnQA_CD_CuotaGratis);
            groupBox4.Controls.Add(btnQA_CD_CuotaNormal);
            groupBox4.Location = new Point(12, 388);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(467, 64);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cotizador Directo 2";
            // 
            // btnQA_CD_CuotaSimbolica
            // 
            btnQA_CD_CuotaSimbolica.ImeMode = ImeMode.NoControl;
            btnQA_CD_CuotaSimbolica.Location = new Point(308, 22);
            btnQA_CD_CuotaSimbolica.Name = "btnQA_CD_CuotaSimbolica";
            btnQA_CD_CuotaSimbolica.Size = new Size(139, 23);
            btnQA_CD_CuotaSimbolica.TabIndex = 5;
            btnQA_CD_CuotaSimbolica.Text = "Cuota simbolica";
            btnQA_CD_CuotaSimbolica.UseVisualStyleBackColor = true;
            btnQA_CD_CuotaSimbolica.Click += btnQA_CD_CuotaSimbolica_Click;
            // 
            // btnQA_CD_CuotaGratis
            // 
            btnQA_CD_CuotaGratis.ImeMode = ImeMode.NoControl;
            btnQA_CD_CuotaGratis.Location = new Point(18, 22);
            btnQA_CD_CuotaGratis.Name = "btnQA_CD_CuotaGratis";
            btnQA_CD_CuotaGratis.Size = new Size(139, 23);
            btnQA_CD_CuotaGratis.TabIndex = 3;
            btnQA_CD_CuotaGratis.Text = "Cuota gratis";
            btnQA_CD_CuotaGratis.UseVisualStyleBackColor = true;
            btnQA_CD_CuotaGratis.Click += btnQA_CD_CuotaGratis_Click;
            // 
            // btnQA_CD_CuotaNormal
            // 
            btnQA_CD_CuotaNormal.ImeMode = ImeMode.NoControl;
            btnQA_CD_CuotaNormal.Location = new Point(163, 22);
            btnQA_CD_CuotaNormal.Name = "btnQA_CD_CuotaNormal";
            btnQA_CD_CuotaNormal.Size = new Size(139, 23);
            btnQA_CD_CuotaNormal.TabIndex = 4;
            btnQA_CD_CuotaNormal.Text = "Cuota normal";
            btnQA_CD_CuotaNormal.UseVisualStyleBackColor = true;
            btnQA_CD_CuotaNormal.Click += btnQA_CD_CuotaNormal_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnQA_VA_CuotaSimbolica);
            groupBox3.Controls.Add(btnQA_VA_CuotaNormal);
            groupBox3.Controls.Add(btnQA_VA_CuotaGratis);
            groupBox3.Location = new Point(12, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 62);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Venta Asistida";
            // 
            // btnQA_VA_CuotaSimbolica
            // 
            btnQA_VA_CuotaSimbolica.ImeMode = ImeMode.NoControl;
            btnQA_VA_CuotaSimbolica.Location = new Point(308, 22);
            btnQA_VA_CuotaSimbolica.Name = "btnQA_VA_CuotaSimbolica";
            btnQA_VA_CuotaSimbolica.Size = new Size(139, 23);
            btnQA_VA_CuotaSimbolica.TabIndex = 1;
            btnQA_VA_CuotaSimbolica.Text = "Cuota simbolica";
            btnQA_VA_CuotaSimbolica.UseVisualStyleBackColor = true;
            btnQA_VA_CuotaSimbolica.Click += btnQA_VA_CuotaSimbolica_Click;
            // 
            // btnQA_VA_CuotaNormal
            // 
            btnQA_VA_CuotaNormal.ImeMode = ImeMode.NoControl;
            btnQA_VA_CuotaNormal.Location = new Point(163, 22);
            btnQA_VA_CuotaNormal.Name = "btnQA_VA_CuotaNormal";
            btnQA_VA_CuotaNormal.Size = new Size(139, 23);
            btnQA_VA_CuotaNormal.TabIndex = 1;
            btnQA_VA_CuotaNormal.Text = "Cuota normal";
            btnQA_VA_CuotaNormal.UseVisualStyleBackColor = true;
            btnQA_VA_CuotaNormal.Click += btnQA_VA_CuotaNormal_Click;
            // 
            // btnQA_VA_CuotaGratis
            // 
            btnQA_VA_CuotaGratis.ImeMode = ImeMode.NoControl;
            btnQA_VA_CuotaGratis.Location = new Point(18, 22);
            btnQA_VA_CuotaGratis.Name = "btnQA_VA_CuotaGratis";
            btnQA_VA_CuotaGratis.Size = new Size(139, 23);
            btnQA_VA_CuotaGratis.TabIndex = 2;
            btnQA_VA_CuotaGratis.Text = "Cuota gratis";
            btnQA_VA_CuotaGratis.UseVisualStyleBackColor = true;
            btnQA_VA_CuotaGratis.Click += btnQA_VA_CuotaGratis_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDESA_CD_CuotaSimbolica);
            groupBox2.Controls.Add(btnDESA_CD_CuotaGratis);
            groupBox2.Controls.Add(btnDESA_CD_CuotaNormal);
            groupBox2.Location = new Point(12, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 60);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cotizador Directo 2";
            // 
            // btnDESA_CD_CuotaSimbolica
            // 
            btnDESA_CD_CuotaSimbolica.Enabled = false;
            btnDESA_CD_CuotaSimbolica.ImeMode = ImeMode.NoControl;
            btnDESA_CD_CuotaSimbolica.Location = new Point(308, 22);
            btnDESA_CD_CuotaSimbolica.Name = "btnDESA_CD_CuotaSimbolica";
            btnDESA_CD_CuotaSimbolica.Size = new Size(139, 23);
            btnDESA_CD_CuotaSimbolica.TabIndex = 5;
            btnDESA_CD_CuotaSimbolica.Text = "Cuota simbolica";
            btnDESA_CD_CuotaSimbolica.UseVisualStyleBackColor = true;
            // 
            // btnDESA_CD_CuotaGratis
            // 
            btnDESA_CD_CuotaGratis.Enabled = false;
            btnDESA_CD_CuotaGratis.ImeMode = ImeMode.NoControl;
            btnDESA_CD_CuotaGratis.Location = new Point(18, 22);
            btnDESA_CD_CuotaGratis.Name = "btnDESA_CD_CuotaGratis";
            btnDESA_CD_CuotaGratis.Size = new Size(139, 23);
            btnDESA_CD_CuotaGratis.TabIndex = 3;
            btnDESA_CD_CuotaGratis.Text = "Cuota gratis";
            btnDESA_CD_CuotaGratis.UseVisualStyleBackColor = true;
            // 
            // btnDESA_CD_CuotaNormal
            // 
            btnDESA_CD_CuotaNormal.ImeMode = ImeMode.NoControl;
            btnDESA_CD_CuotaNormal.Location = new Point(163, 22);
            btnDESA_CD_CuotaNormal.Name = "btnDESA_CD_CuotaNormal";
            btnDESA_CD_CuotaNormal.Size = new Size(139, 23);
            btnDESA_CD_CuotaNormal.TabIndex = 4;
            btnDESA_CD_CuotaNormal.Text = "Cuota normal";
            btnDESA_CD_CuotaNormal.UseVisualStyleBackColor = true;
            btnDESA_CD_CuotaNormal.Click += btnDESA_CD_CuotaNormal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDesa_VA_CuotaSimbolica);
            groupBox1.Controls.Add(btnDesa_VA_CuotaNormal);
            groupBox1.Controls.Add(btnDesa_VA_CuotaGratis);
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 62);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Venta Asistida";
            // 
            // btnDesa_VA_CuotaSimbolica
            // 
            btnDesa_VA_CuotaSimbolica.Enabled = false;
            btnDesa_VA_CuotaSimbolica.ImeMode = ImeMode.NoControl;
            btnDesa_VA_CuotaSimbolica.Location = new Point(308, 22);
            btnDesa_VA_CuotaSimbolica.Name = "btnDesa_VA_CuotaSimbolica";
            btnDesa_VA_CuotaSimbolica.Size = new Size(139, 23);
            btnDesa_VA_CuotaSimbolica.TabIndex = 2;
            btnDesa_VA_CuotaSimbolica.Text = "Cuota simbolica";
            btnDesa_VA_CuotaSimbolica.UseVisualStyleBackColor = true;
            // 
            // btnDesa_VA_CuotaNormal
            // 
            btnDesa_VA_CuotaNormal.ImeMode = ImeMode.NoControl;
            btnDesa_VA_CuotaNormal.Location = new Point(163, 22);
            btnDesa_VA_CuotaNormal.Name = "btnDesa_VA_CuotaNormal";
            btnDesa_VA_CuotaNormal.Size = new Size(139, 23);
            btnDesa_VA_CuotaNormal.TabIndex = 1;
            btnDesa_VA_CuotaNormal.Text = "Cuota normal";
            btnDesa_VA_CuotaNormal.UseVisualStyleBackColor = true;
            btnDesa_VA_CuotaNormal.Click += btnDesa_VA_CuotaNormal_Click;
            // 
            // btnDesa_VA_CuotaGratis
            // 
            btnDesa_VA_CuotaGratis.Enabled = false;
            btnDesa_VA_CuotaGratis.ImeMode = ImeMode.NoControl;
            btnDesa_VA_CuotaGratis.Location = new Point(18, 22);
            btnDesa_VA_CuotaGratis.Name = "btnDesa_VA_CuotaGratis";
            btnDesa_VA_CuotaGratis.Size = new Size(139, 23);
            btnDesa_VA_CuotaGratis.TabIndex = 12;
            btnDesa_VA_CuotaGratis.Text = "Cuota gratis";
            btnDesa_VA_CuotaGratis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(59, 40);
            label2.TabIndex = 17;
            label2.Text = "QA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 16;
            label1.Text = "Desarrollo";
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(381, 479);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(98, 23);
            btnConfig.TabIndex = 29;
            btnConfig.Text = "Configuración";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // gbQA
            // 
            gbQA.Controls.Add(rbUsadoQA);
            gbQA.Controls.Add(rbNuevoQA);
            gbQA.Location = new Point(320, 255);
            gbQA.Name = "gbQA";
            gbQA.Size = new Size(159, 59);
            gbQA.TabIndex = 30;
            gbQA.TabStop = false;
            gbQA.Text = "Tipo de auto";
            // 
            // rbUsadoQA
            // 
            rbUsadoQA.AutoSize = true;
            rbUsadoQA.Checked = true;
            rbUsadoQA.Location = new Point(86, 25);
            rbUsadoQA.Name = "rbUsadoQA";
            rbUsadoQA.Size = new Size(58, 19);
            rbUsadoQA.TabIndex = 1;
            rbUsadoQA.TabStop = true;
            rbUsadoQA.Text = "Usado";
            rbUsadoQA.UseVisualStyleBackColor = true;
            // 
            // rbNuevoQA
            // 
            rbNuevoQA.AutoSize = true;
            rbNuevoQA.Location = new Point(17, 24);
            rbNuevoQA.Name = "rbNuevoQA";
            rbNuevoQA.Size = new Size(60, 19);
            rbNuevoQA.TabIndex = 0;
            rbNuevoQA.Text = "Nuevo";
            rbNuevoQA.UseVisualStyleBackColor = true;
            // 
            // gbDesa
            // 
            gbDesa.Controls.Add(rbUsadoDesa);
            gbDesa.Controls.Add(rbNuevoDesa);
            gbDesa.Location = new Point(320, 29);
            gbDesa.Name = "gbDesa";
            gbDesa.Size = new Size(159, 59);
            gbDesa.TabIndex = 31;
            gbDesa.TabStop = false;
            gbDesa.Text = "Tipo de auto";
            // 
            // rbUsadoDesa
            // 
            rbUsadoDesa.AutoSize = true;
            rbUsadoDesa.Checked = true;
            rbUsadoDesa.Location = new Point(86, 25);
            rbUsadoDesa.Name = "rbUsadoDesa";
            rbUsadoDesa.Size = new Size(58, 19);
            rbUsadoDesa.TabIndex = 1;
            rbUsadoDesa.TabStop = true;
            rbUsadoDesa.Text = "Usado";
            rbUsadoDesa.UseVisualStyleBackColor = true;
            // 
            // rbNuevoDesa
            // 
            rbNuevoDesa.AutoSize = true;
            rbNuevoDesa.Location = new Point(17, 24);
            rbNuevoDesa.Name = "rbNuevoDesa";
            rbNuevoDesa.Size = new Size(60, 19);
            rbNuevoDesa.TabIndex = 0;
            rbNuevoDesa.Text = "Nuevo";
            rbNuevoDesa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 518);
            Controls.Add(gbDesa);
            Controls.Add(gbQA);
            Controls.Add(btnConfig);
            Controls.Add(cbScreenshot);
            Controls.Add(cbLocalhost);
            Controls.Add(cbOpenBrowser);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pruebas de flujo";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            gbQA.ResumeLayout(false);
            gbQA.PerformLayout();
            gbDesa.ResumeLayout(false);
            gbDesa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbScreenshot;
        private CheckBox cbLocalhost;
        private CheckBox cbOpenBrowser;
        private GroupBox groupBox4;
        private Button btnQA_CD_CuotaSimbolica;
        private Button btnQA_CD_CuotaGratis;
        private Button btnQA_CD_CuotaNormal;
        private GroupBox groupBox3;
        private Button btnQA_VA_CuotaSimbolica;
        private Button btnQA_VA_CuotaNormal;
        private Button btnQA_VA_CuotaGratis;
        private GroupBox groupBox2;
        private Button btnDESA_CD_CuotaSimbolica;
        private Button btnDESA_CD_CuotaGratis;
        private Button btnDESA_CD_CuotaNormal;
        private GroupBox groupBox1;
        private Button btnDesa_VA_CuotaSimbolica;
        private Button btnDesa_VA_CuotaNormal;
        private Button btnDesa_VA_CuotaGratis;
        private Label label2;
        private Label label1;
        private Button btnConfig;
        private GroupBox gbQA;
        private RadioButton rbUsadoQA;
        private RadioButton rbNuevoQA;
        private GroupBox gbDesa;
        private RadioButton rbUsadoDesa;
        private RadioButton rbNuevoDesa;
    }
}
