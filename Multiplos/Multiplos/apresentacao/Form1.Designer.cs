namespace Multiplos
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
            mnsCalculos = new MenuStrip();
            tsmCalculos = new ToolStripMenuItem();
            tsmPrimo = new ToolStripMenuItem();
            tsmTriangulos = new ToolStripMenuItem();
            tsmFatorial = new ToolStripMenuItem();
            mnsCalculos.SuspendLayout();
            SuspendLayout();
            // 
            // mnsCalculos
            // 
            mnsCalculos.Items.AddRange(new ToolStripItem[] { tsmCalculos });
            mnsCalculos.Location = new Point(0, 0);
            mnsCalculos.Name = "mnsCalculos";
            mnsCalculos.Size = new Size(275, 24);
            mnsCalculos.TabIndex = 0;
            mnsCalculos.Text = "menuStrip1";
            // 
            // tsmCalculos
            // 
            tsmCalculos.DropDownItems.AddRange(new ToolStripItem[] { tsmPrimo, tsmTriangulos, tsmFatorial });
            tsmCalculos.Name = "tsmCalculos";
            tsmCalculos.Size = new Size(64, 20);
            tsmCalculos.Text = "Calculos";
            // 
            // tsmPrimo
            // 
            tsmPrimo.Name = "tsmPrimo";
            tsmPrimo.Size = new Size(180, 22);
            tsmPrimo.Text = "Primo";
            tsmPrimo.Click += tsmPrimo_Click;
            // 
            // tsmTriangulos
            // 
            tsmTriangulos.Name = "tsmTriangulos";
            tsmTriangulos.Size = new Size(180, 22);
            tsmTriangulos.Text = "Triangulos";
            tsmTriangulos.Click += tsmTriangulos_Click;
            // 
            // tsmFatorial
            // 
            tsmFatorial.Name = "tsmFatorial";
            tsmFatorial.Size = new Size(180, 22);
            tsmFatorial.Text = "Fatorial";
            tsmFatorial.Click += this.tsmFatorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 210);
            Controls.Add(mnsCalculos);
            MainMenuStrip = mnsCalculos;
            Name = "Form1";
            Text = "Calculos";
            mnsCalculos.ResumeLayout(false);
            mnsCalculos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsCalculos;
        private ToolStripMenuItem tsmCalculos;
        private ToolStripMenuItem tsmPrimo;
        private ToolStripMenuItem tsmTriangulos;
        private ToolStripMenuItem tsmFatorial;
    }
}
