namespace Multiplos.apresentacao
{
    partial class frmFatorial
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
            txbFatorial = new TextBox();
            btnCalcular = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // txbFatorial
            // 
            txbFatorial.Location = new Point(35, 22);
            txbFatorial.Name = "txbFatorial";
            txbFatorial.Size = new Size(156, 23);
            txbFatorial.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(35, 64);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(35, 109);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 2;
            lblResposta.Text = "Resposta";
            // 
            // frmFatorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 165);
            Controls.Add(lblResposta);
            Controls.Add(btnCalcular);
            Controls.Add(txbFatorial);
            Name = "frmFatorial";
            Text = "Fatorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbFatorial;
        private Button btnCalcular;
        private Label lblResposta;
    }
}