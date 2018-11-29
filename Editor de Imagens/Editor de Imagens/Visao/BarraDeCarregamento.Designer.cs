namespace Editor_de_Imagens.Visao
{
    partial class BarraDeCarregamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarraDeCarregamento));
            this.pgb_progresso = new System.Windows.Forms.ProgressBar();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb_progresso
            // 
            this.pgb_progresso.BackColor = System.Drawing.Color.White;
            this.pgb_progresso.Location = new System.Drawing.Point(12, 21);
            this.pgb_progresso.Name = "pgb_progresso";
            this.pgb_progresso.Size = new System.Drawing.Size(215, 23);
            this.pgb_progresso.TabIndex = 0;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(234, 25);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(60, 13);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "1000/1000";
            // 
            // BarraDeCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 71);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.pgb_progresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarraDeCarregamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_progresso;
        private System.Windows.Forms.Label lbl_valor;
    }
}