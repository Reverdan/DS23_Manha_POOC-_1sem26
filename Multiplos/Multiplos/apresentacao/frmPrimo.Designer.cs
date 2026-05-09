namespace Multiplos.apresentacao
{
    partial class frmPrimo
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
            lblResposta = new Label();
            btnCalcular = new Button();
            txbPrimo = new TextBox();
            SuspendLayout();
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(36, 126);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 5;
            lblResposta.Text = "Resposta";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(36, 81);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txbPrimo
            // 
            txbPrimo.Location = new Point(36, 39);
            txbPrimo.Name = "txbPrimo";
            txbPrimo.Size = new Size(156, 23);
            txbPrimo.TabIndex = 3;
            // 
            // frmPrimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 172);
            Controls.Add(lblResposta);
            Controls.Add(btnCalcular);
            Controls.Add(txbPrimo);
            Name = "frmPrimo";
            Text = "Primo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResposta;
        private Button btnCalcular;
        private TextBox txbPrimo;
    }
}