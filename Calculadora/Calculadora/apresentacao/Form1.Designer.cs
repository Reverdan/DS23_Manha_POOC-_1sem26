namespace Calculadora
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
            lblPrimeiroNumero = new Label();
            txbPrimeiroNumero = new TextBox();
            txbSegundoNumero = new TextBox();
            lblSegundoNumero = new Label();
            btnSomar = new Button();
            lblResultado = new Label();
            btnSubtrair = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(33, 26);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(141, 15);
            lblPrimeiroNumero.TabIndex = 0;
            lblPrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // txbPrimeiroNumero
            // 
            txbPrimeiroNumero.Location = new Point(33, 44);
            txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            txbPrimeiroNumero.Size = new Size(208, 23);
            txbPrimeiroNumero.TabIndex = 1;
            // 
            // txbSegundoNumero
            // 
            txbSegundoNumero.Location = new Point(33, 102);
            txbSegundoNumero.Name = "txbSegundoNumero";
            txbSegundoNumero.Size = new Size(208, 23);
            txbSegundoNumero.TabIndex = 3;
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(33, 84);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(142, 15);
            lblSegundoNumero.TabIndex = 2;
            lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(33, 146);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(33, 231);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(166, 146);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(166, 175);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(33, 175);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 285);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(lblResultado);
            Controls.Add(btnSomar);
            Controls.Add(txbSegundoNumero);
            Controls.Add(lblSegundoNumero);
            Controls.Add(txbPrimeiroNumero);
            Controls.Add(lblPrimeiroNumero);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeiroNumero;
        private TextBox txbPrimeiroNumero;
        private TextBox txbSegundoNumero;
        private Label lblSegundoNumero;
        private Button btnSomar;
        private Label lblResultado;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
    }
}
