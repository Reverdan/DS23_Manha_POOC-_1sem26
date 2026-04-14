namespace TemperaturaFC
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
            lblTemperatura = new Label();
            txbTemperatura = new TextBox();
            rdbCF = new RadioButton();
            rdbFC = new RadioButton();
            brnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(28, 26);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(112, 15);
            lblTemperatura.TabIndex = 0;
            lblTemperatura.Text = "Insira a temperatura";
            // 
            // txbTemperatura
            // 
            txbTemperatura.Location = new Point(28, 44);
            txbTemperatura.Name = "txbTemperatura";
            txbTemperatura.Size = new Size(144, 23);
            txbTemperatura.TabIndex = 1;
            // 
            // rdbCF
            // 
            rdbCF.AutoSize = true;
            rdbCF.Checked = true;
            rdbCF.Location = new Point(28, 84);
            rdbCF.Name = "rdbCF";
            rdbCF.Size = new Size(129, 19);
            rdbCF.TabIndex = 2;
            rdbCF.TabStop = true;
            rdbCF.Text = "Celsius - Fahrenheit";
            rdbCF.UseVisualStyleBackColor = true;
            // 
            // rdbFC
            // 
            rdbFC.AutoSize = true;
            rdbFC.Location = new Point(28, 109);
            rdbFC.Name = "rdbFC";
            rdbFC.Size = new Size(132, 19);
            rdbFC.TabIndex = 3;
            rdbFC.Text = "Fahrenheit - Celsius ";
            rdbFC.UseVisualStyleBackColor = true;
            // 
            // brnCalcular
            // 
            brnCalcular.Location = new Point(28, 144);
            brnCalcular.Name = "brnCalcular";
            brnCalcular.Size = new Size(144, 23);
            brnCalcular.TabIndex = 4;
            brnCalcular.Text = "Calcular";
            brnCalcular.UseVisualStyleBackColor = true;
            brnCalcular.Click += brnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(28, 184);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(54, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resposta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 224);
            Controls.Add(lblResultado);
            Controls.Add(brnCalcular);
            Controls.Add(rdbFC);
            Controls.Add(rdbCF);
            Controls.Add(txbTemperatura);
            Controls.Add(lblTemperatura);
            Name = "Form1";
            Text = "Temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperatura;
        private TextBox txbTemperatura;
        private RadioButton rdbCF;
        private RadioButton rdbFC;
        private Button brnCalcular;
        private Label lblResultado;
    }
}
