namespace WinFormsApp1
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
            label1 = new Label();
            lblN1 = new Label();
            lblN2 = new Label();
            Res = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtRes = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            groupBox = new GroupBox();
            rBtnDivision = new RadioButton();
            rBtnMultiplicación = new RadioButton();
            rBtnResta = new RadioButton();
            rBtnSuma = new RadioButton();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(257, 26);
            label1.Name = "label1";
            label1.Size = new Size(334, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a C#";
            label1.Click += label1_Click;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblN1.ForeColor = Color.Black;
            lblN1.Location = new Point(89, 114);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(156, 32);
            lblN1.TabIndex = 1;
            lblN1.Text = "Número 1:";
            lblN1.Click += label2_Click;
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblN2.ForeColor = Color.Black;
            lblN2.Location = new Point(89, 196);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(156, 32);
            lblN2.TabIndex = 2;
            lblN2.Text = "Número 2:";
            // 
            // Res
            // 
            Res.AutoSize = true;
            Res.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Res.ForeColor = Color.Black;
            Res.Location = new Point(89, 284);
            Res.Name = "Res";
            Res.Size = new Size(162, 32);
            Res.TabIndex = 3;
            Res.Text = "Resultado:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(257, 114);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 31);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(257, 196);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 31);
            txtNum2.TabIndex = 5;
            // 
            // txtRes
            // 
            txtRes.Enabled = false;
            txtRes.Location = new Point(257, 285);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(125, 31);
            txtRes.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = Color.FromArgb(0, 0, 192);
            btnCalcular.Location = new Point(466, 159);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 35);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(463, 234);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 36);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click_1;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(rBtnDivision);
            groupBox.Controls.Add(rBtnMultiplicación);
            groupBox.Controls.Add(rBtnResta);
            groupBox.Controls.Add(rBtnSuma);
            groupBox.Location = new Point(632, 69);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(250, 177);
            groupBox.TabIndex = 9;
            groupBox.TabStop = false;
            groupBox.Text = "Selecciona Operación";
            // 
            // rBtnDivision
            // 
            rBtnDivision.AutoSize = true;
            rBtnDivision.ForeColor = Color.Black;
            rBtnDivision.Location = new Point(21, 132);
            rBtnDivision.Name = "rBtnDivision";
            rBtnDivision.Size = new Size(107, 27);
            rBtnDivision.TabIndex = 3;
            rBtnDivision.TabStop = true;
            rBtnDivision.Text = "División";
            rBtnDivision.UseVisualStyleBackColor = true;
            // 
            // rBtnMultiplicación
            // 
            rBtnMultiplicación.AutoSize = true;
            rBtnMultiplicación.ForeColor = Color.Black;
            rBtnMultiplicación.Location = new Point(21, 101);
            rBtnMultiplicación.Name = "rBtnMultiplicación";
            rBtnMultiplicación.Size = new Size(165, 27);
            rBtnMultiplicación.TabIndex = 2;
            rBtnMultiplicación.TabStop = true;
            rBtnMultiplicación.Text = "Multiplicación";
            rBtnMultiplicación.UseVisualStyleBackColor = true;
            // 
            // rBtnResta
            // 
            rBtnResta.AutoSize = true;
            rBtnResta.ForeColor = Color.Black;
            rBtnResta.Location = new Point(21, 68);
            rBtnResta.Name = "rBtnResta";
            rBtnResta.Size = new Size(87, 27);
            rBtnResta.TabIndex = 1;
            rBtnResta.TabStop = true;
            rBtnResta.Text = "Resta";
            rBtnResta.UseVisualStyleBackColor = true;
            // 
            // rBtnSuma
            // 
            rBtnSuma.AutoSize = true;
            rBtnSuma.ForeColor = Color.Black;
            rBtnSuma.Location = new Point(21, 35);
            rBtnSuma.Name = "rBtnSuma";
            rBtnSuma.Size = new Size(86, 27);
            rBtnSuma.TabIndex = 0;
            rBtnSuma.TabStop = true;
            rBtnSuma.Text = "Suma";
            rBtnSuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(943, 493);
            Controls.Add(groupBox);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtRes);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(Res);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 0, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Mi Primera Aplicación";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblN1;
        private Label lblN2;
        private Label Res;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtRes;
        private Button btnCalcular;
        private Button btnSalir;
        private GroupBox groupBox;
        private RadioButton rBtnDivision;
        private RadioButton rBtnMultiplicación;
        private RadioButton rBtnResta;
        private RadioButton rBtnSuma;
    }
}
