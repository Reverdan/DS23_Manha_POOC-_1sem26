namespace Multiplos.apresentacao
{
    partial class frmTriangulos
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
            txbLado1 = new TextBox();
            txbLado2 = new TextBox();
            txbLado3 = new TextBox();
            lblLado1 = new Label();
            lblLado2 = new Label();
            lblLado3 = new Label();
            btnVerificar = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // txbLado1
            // 
            txbLado1.Location = new Point(29, 38);
            txbLado1.Name = "txbLado1";
            txbLado1.Size = new Size(147, 23);
            txbLado1.TabIndex = 0;
            // 
            // txbLado2
            // 
            txbLado2.Location = new Point(29, 94);
            txbLado2.Name = "txbLado2";
            txbLado2.Size = new Size(147, 23);
            txbLado2.TabIndex = 1;
            // 
            // txbLado3
            // 
            txbLado3.Location = new Point(29, 150);
            txbLado3.Name = "txbLado3";
            txbLado3.Size = new Size(147, 23);
            txbLado3.TabIndex = 2;
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(29, 20);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(42, 15);
            lblLado1.TabIndex = 3;
            lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Location = new Point(29, 76);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(42, 15);
            lblLado2.TabIndex = 4;
            lblLado2.Text = "Lado 2";
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Location = new Point(29, 132);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(42, 15);
            lblLado3.TabIndex = 5;
            lblLado3.Text = "Lado 3";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(29, 193);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(147, 23);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(33, 236);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 7;
            lblResposta.Text = "Resposta";
            // 
            // frmTriangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 281);
            Controls.Add(lblResposta);
            Controls.Add(btnVerificar);
            Controls.Add(lblLado3);
            Controls.Add(lblLado2);
            Controls.Add(lblLado1);
            Controls.Add(txbLado3);
            Controls.Add(txbLado2);
            Controls.Add(txbLado1);
            Name = "frmTriangulos";
            Text = "Triângulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbLado1;
        private TextBox txbLado2;
        private TextBox txbLado3;
        private Label lblLado1;
        private Label lblLado2;
        private Label lblLado3;
        private Button btnVerificar;
        private Label lblResposta;
    }
}