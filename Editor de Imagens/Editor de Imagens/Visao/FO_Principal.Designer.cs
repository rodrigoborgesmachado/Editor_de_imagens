namespace Editor_de_Imagens
{
    partial class FO_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_Principal));
            this.tbx_folder = new System.Windows.Forms.TextBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.tbx_width = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.tbx_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.ckb_transparent = new System.Windows.Forms.CheckBox();
            this.btn_trata = new System.Windows.Forms.Button();
            this.pan_top_folder = new System.Windows.Forms.Panel();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txb_folder_output = new System.Windows.Forms.TextBox();
            this.btn_folder_out = new System.Windows.Forms.Button();
            this.pan_tamanho_tipo = new System.Windows.Forms.Panel();
            this.pan_tipos = new System.Windows.Forms.Panel();
            this.cbx_tipos = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.pan_tamanho = new System.Windows.Forms.Panel();
            this.pan_transparent = new System.Windows.Forms.Panel();
            this.pan_botao_tratar = new System.Windows.Forms.Panel();
            this.btn_file = new System.Windows.Forms.Button();
            this.tbx_file_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_top_folder.SuspendLayout();
            this.pan_tamanho_tipo.SuspendLayout();
            this.pan_tipos.SuspendLayout();
            this.pan_tamanho.SuspendLayout();
            this.pan_transparent.SuspendLayout();
            this.pan_botao_tratar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_folder
            // 
            this.tbx_folder.Location = new System.Drawing.Point(83, 52);
            this.tbx_folder.Name = "tbx_folder";
            this.tbx_folder.Size = new System.Drawing.Size(200, 20);
            this.tbx_folder.TabIndex = 1;
            // 
            // btn_folder
            // 
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_folder.Location = new System.Drawing.Point(289, 52);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(46, 20);
            this.btn_folder.TabIndex = 2;
            this.btn_folder.Text = "Folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // tbx_width
            // 
            this.tbx_width.Location = new System.Drawing.Point(13, 5);
            this.tbx_width.Name = "tbx_width";
            this.tbx_width.Size = new System.Drawing.Size(32, 20);
            this.tbx_width.TabIndex = 5;
            this.tbx_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_estoqueProd_KeyPress);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(52, 9);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(35, 13);
            this.lbl_width.TabIndex = 2;
            this.lbl_width.Text = "Width";
            // 
            // tbx_height
            // 
            this.tbx_height.Location = new System.Drawing.Point(13, 31);
            this.tbx_height.Name = "tbx_height";
            this.tbx_height.Size = new System.Drawing.Size(32, 20);
            this.tbx_height.TabIndex = 6;
            this.tbx_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_estoqueProd_KeyPress);
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(52, 35);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(38, 13);
            this.lbl_height.TabIndex = 2;
            this.lbl_height.Text = "Height";
            // 
            // ckb_transparent
            // 
            this.ckb_transparent.AutoSize = true;
            this.ckb_transparent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckb_transparent.Location = new System.Drawing.Point(13, 6);
            this.ckb_transparent.Name = "ckb_transparent";
            this.ckb_transparent.Size = new System.Drawing.Size(108, 17);
            this.ckb_transparent.TabIndex = 8;
            this.ckb_transparent.Text = "Transparent-back";
            this.ckb_transparent.UseVisualStyleBackColor = true;
            // 
            // btn_trata
            // 
            this.btn_trata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_trata.Location = new System.Drawing.Point(39, 3);
            this.btn_trata.Name = "btn_trata";
            this.btn_trata.Size = new System.Drawing.Size(266, 32);
            this.btn_trata.TabIndex = 9;
            this.btn_trata.Text = "Tratar";
            this.btn_trata.UseVisualStyleBackColor = true;
            this.btn_trata.Click += new System.EventHandler(this.btn_trata_Click);
            // 
            // pan_top_folder
            // 
            this.pan_top_folder.Controls.Add(this.lbl_output);
            this.pan_top_folder.Controls.Add(this.label1);
            this.pan_top_folder.Controls.Add(this.lbl_input);
            this.pan_top_folder.Controls.Add(this.txb_folder_output);
            this.pan_top_folder.Controls.Add(this.btn_folder_out);
            this.pan_top_folder.Controls.Add(this.tbx_file_in);
            this.pan_top_folder.Controls.Add(this.btn_file);
            this.pan_top_folder.Controls.Add(this.tbx_folder);
            this.pan_top_folder.Controls.Add(this.btn_folder);
            this.pan_top_folder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top_folder.Location = new System.Drawing.Point(0, 0);
            this.pan_top_folder.Name = "pan_top_folder";
            this.pan_top_folder.Size = new System.Drawing.Size(347, 120);
            this.pan_top_folder.TabIndex = 7;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(10, 81);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(42, 13);
            this.lbl_output.TabIndex = 2;
            this.lbl_output.Text = "Output:";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 56);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(59, 13);
            this.lbl_input.TabIndex = 2;
            this.lbl_input.Text = "Input Path:";
            // 
            // txb_folder_output
            // 
            this.txb_folder_output.Location = new System.Drawing.Point(83, 78);
            this.txb_folder_output.Name = "txb_folder_output";
            this.txb_folder_output.Size = new System.Drawing.Size(200, 20);
            this.txb_folder_output.TabIndex = 3;
            // 
            // btn_folder_out
            // 
            this.btn_folder_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_folder_out.Location = new System.Drawing.Point(289, 78);
            this.btn_folder_out.Name = "btn_folder_out";
            this.btn_folder_out.Size = new System.Drawing.Size(46, 20);
            this.btn_folder_out.TabIndex = 4;
            this.btn_folder_out.Text = "Folder";
            this.btn_folder_out.UseVisualStyleBackColor = true;
            this.btn_folder_out.Click += new System.EventHandler(this.btn_folder_out_Click);
            // 
            // pan_tamanho_tipo
            // 
            this.pan_tamanho_tipo.Controls.Add(this.pan_tipos);
            this.pan_tamanho_tipo.Controls.Add(this.pan_tamanho);
            this.pan_tamanho_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_tamanho_tipo.Location = new System.Drawing.Point(0, 120);
            this.pan_tamanho_tipo.Name = "pan_tamanho_tipo";
            this.pan_tamanho_tipo.Size = new System.Drawing.Size(347, 64);
            this.pan_tamanho_tipo.TabIndex = 8;
            // 
            // pan_tipos
            // 
            this.pan_tipos.Controls.Add(this.cbx_tipos);
            this.pan_tipos.Controls.Add(this.lbl_tipo);
            this.pan_tipos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_tipos.Location = new System.Drawing.Point(147, 0);
            this.pan_tipos.Name = "pan_tipos";
            this.pan_tipos.Size = new System.Drawing.Size(200, 64);
            this.pan_tipos.TabIndex = 6;
            // 
            // cbx_tipos
            // 
            this.cbx_tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_tipos.FormattingEnabled = true;
            this.cbx_tipos.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".ico",
            ".jpeg"});
            this.cbx_tipos.Location = new System.Drawing.Point(90, 5);
            this.cbx_tipos.Name = "cbx_tipos";
            this.cbx_tipos.Size = new System.Drawing.Size(105, 21);
            this.cbx_tipos.TabIndex = 7;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(3, 8);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(76, 13);
            this.lbl_tipo.TabIndex = 2;
            this.lbl_tipo.Text = "Tipo de saída:";
            // 
            // pan_tamanho
            // 
            this.pan_tamanho.Controls.Add(this.lbl_width);
            this.pan_tamanho.Controls.Add(this.tbx_width);
            this.pan_tamanho.Controls.Add(this.lbl_height);
            this.pan_tamanho.Controls.Add(this.tbx_height);
            this.pan_tamanho.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_tamanho.Location = new System.Drawing.Point(0, 0);
            this.pan_tamanho.Name = "pan_tamanho";
            this.pan_tamanho.Size = new System.Drawing.Size(121, 64);
            this.pan_tamanho.TabIndex = 5;
            // 
            // pan_transparent
            // 
            this.pan_transparent.Controls.Add(this.ckb_transparent);
            this.pan_transparent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_transparent.Location = new System.Drawing.Point(0, 184);
            this.pan_transparent.Name = "pan_transparent";
            this.pan_transparent.Size = new System.Drawing.Size(347, 26);
            this.pan_transparent.TabIndex = 9;
            // 
            // pan_botao_tratar
            // 
            this.pan_botao_tratar.Controls.Add(this.btn_trata);
            this.pan_botao_tratar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_botao_tratar.Location = new System.Drawing.Point(0, 210);
            this.pan_botao_tratar.Name = "pan_botao_tratar";
            this.pan_botao_tratar.Size = new System.Drawing.Size(347, 38);
            this.pan_botao_tratar.TabIndex = 10;
            // 
            // btn_file
            // 
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_file.Location = new System.Drawing.Point(289, 26);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(46, 20);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "Folder";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // tbx_file_in
            // 
            this.tbx_file_in.Location = new System.Drawing.Point(83, 26);
            this.tbx_file_in.Name = "tbx_file_in";
            this.tbx_file_in.Size = new System.Drawing.Size(200, 20);
            this.tbx_file_in.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File:";
            // 
            // FO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(347, 245);
            this.Controls.Add(this.pan_botao_tratar);
            this.Controls.Add(this.pan_transparent);
            this.Controls.Add(this.pan_tamanho_tipo);
            this.Controls.Add(this.pan_top_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FO_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Imagens";
            this.pan_top_folder.ResumeLayout(false);
            this.pan_top_folder.PerformLayout();
            this.pan_tamanho_tipo.ResumeLayout(false);
            this.pan_tipos.ResumeLayout(false);
            this.pan_tipos.PerformLayout();
            this.pan_tamanho.ResumeLayout(false);
            this.pan_tamanho.PerformLayout();
            this.pan_transparent.ResumeLayout(false);
            this.pan_transparent.PerformLayout();
            this.pan_botao_tratar.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pan_top_folder;
        private System.Windows.Forms.Panel pan_tamanho_tipo;
        private System.Windows.Forms.Panel pan_tamanho;
        private System.Windows.Forms.Panel pan_tipos;
        private System.Windows.Forms.Panel pan_transparent;
        private System.Windows.Forms.Panel pan_botao_tratar;
        private System.Windows.Forms.ComboBox cbx_tipos;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txb_folder_output;
        private System.Windows.Forms.Button btn_folder_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_file_in;
        private System.Windows.Forms.Button btn_file;
    }
}

