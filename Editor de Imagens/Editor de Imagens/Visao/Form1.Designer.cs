namespace Editor_de_Imagens
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbx_folder = new System.Windows.Forms.TextBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.tbx_width = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.tbx_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.ckb_transparent = new System.Windows.Forms.CheckBox();
            this.btn_trata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_folder
            // 
            this.tbx_folder.Location = new System.Drawing.Point(13, 13);
            this.tbx_folder.Name = "tbx_folder";
            this.tbx_folder.Size = new System.Drawing.Size(234, 20);
            this.tbx_folder.TabIndex = 1;
            // 
            // btn_folder
            // 
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_folder.Location = new System.Drawing.Point(254, 13);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(46, 20);
            this.btn_folder.TabIndex = 2;
            this.btn_folder.Text = "Folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // tbx_width
            // 
            this.tbx_width.Location = new System.Drawing.Point(13, 39);
            this.tbx_width.Name = "tbx_width";
            this.tbx_width.Size = new System.Drawing.Size(32, 20);
            this.tbx_width.TabIndex = 3;
            this.tbx_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_estoqueProd_KeyPress);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(52, 43);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(35, 13);
            this.lbl_width.TabIndex = 2;
            this.lbl_width.Text = "Width";
            // 
            // tbx_height
            // 
            this.tbx_height.Location = new System.Drawing.Point(13, 65);
            this.tbx_height.Name = "tbx_height";
            this.tbx_height.Size = new System.Drawing.Size(32, 20);
            this.tbx_height.TabIndex = 4;
            this.tbx_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_estoqueProd_KeyPress);
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(52, 69);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(38, 13);
            this.lbl_height.TabIndex = 2;
            this.lbl_height.Text = "Height";
            // 
            // ckb_transparent
            // 
            this.ckb_transparent.AutoSize = true;
            this.ckb_transparent.Location = new System.Drawing.Point(13, 92);
            this.ckb_transparent.Name = "ckb_transparent";
            this.ckb_transparent.Size = new System.Drawing.Size(110, 17);
            this.ckb_transparent.TabIndex = 5;
            this.ckb_transparent.Text = "Transparent-back";
            this.ckb_transparent.UseVisualStyleBackColor = true;
            // 
            // btn_trata
            // 
            this.btn_trata.Location = new System.Drawing.Point(39, 118);
            this.btn_trata.Name = "btn_trata";
            this.btn_trata.Size = new System.Drawing.Size(231, 32);
            this.btn_trata.TabIndex = 6;
            this.btn_trata.Text = "Tratar";
            this.btn_trata.UseVisualStyleBackColor = true;
            this.btn_trata.Click += new System.EventHandler(this.btn_trata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 160);
            this.Controls.Add(this.btn_trata);
            this.Controls.Add(this.ckb_transparent);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.tbx_height);
            this.Controls.Add(this.tbx_width);
            this.Controls.Add(this.tbx_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Imagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_folder;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.TextBox tbx_width;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.TextBox tbx_height;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.CheckBox ckb_transparent;
        private System.Windows.Forms.Button btn_trata;
    }
}

