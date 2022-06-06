namespace Demo_Cizgi_Proje
{
    partial class FrmDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAktifEmanet = new System.Windows.Forms.Button();
            this.BtnGecmisEmanet = new System.Windows.Forms.Button();
            this.BtnCeza = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnEmanetVer = new System.Windows.Forms.Button();
            this.BtnEmanetAl = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye:";
            // 
            // txtMember
            // 
            this.txtMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMember.Location = new System.Drawing.Point(103, 41);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(271, 32);
            this.txtMember.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(412, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // BtnAktifEmanet
            // 
            this.BtnAktifEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAktifEmanet.Location = new System.Drawing.Point(12, 230);
            this.BtnAktifEmanet.Name = "BtnAktifEmanet";
            this.BtnAktifEmanet.Size = new System.Drawing.Size(191, 42);
            this.BtnAktifEmanet.TabIndex = 5;
            this.BtnAktifEmanet.Text = "Aktif Emanetler";
            this.BtnAktifEmanet.UseVisualStyleBackColor = true;
            this.BtnAktifEmanet.Click += new System.EventHandler(this.BtnAktifEmanet_Click);
            // 
            // BtnGecmisEmanet
            // 
            this.BtnGecmisEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGecmisEmanet.Location = new System.Drawing.Point(220, 230);
            this.BtnGecmisEmanet.Name = "BtnGecmisEmanet";
            this.BtnGecmisEmanet.Size = new System.Drawing.Size(182, 42);
            this.BtnGecmisEmanet.TabIndex = 6;
            this.BtnGecmisEmanet.Text = "GeçmişEmanetler";
            this.BtnGecmisEmanet.UseVisualStyleBackColor = true;
            this.BtnGecmisEmanet.Click += new System.EventHandler(this.BtnGecmisEmanet_Click);
            // 
            // BtnCeza
            // 
            this.BtnCeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCeza.Location = new System.Drawing.Point(418, 230);
            this.BtnCeza.Name = "BtnCeza";
            this.BtnCeza.Size = new System.Drawing.Size(182, 42);
            this.BtnCeza.TabIndex = 7;
            this.BtnCeza.Text = "Cezalar";
            this.BtnCeza.UseVisualStyleBackColor = true;
            this.BtnCeza.Click += new System.EventHandler(this.BtnCeza_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(606, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnEmanetVer
            // 
            this.BtnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEmanetVer.Location = new System.Drawing.Point(12, 171);
            this.BtnEmanetVer.Name = "BtnEmanetVer";
            this.BtnEmanetVer.Size = new System.Drawing.Size(191, 42);
            this.BtnEmanetVer.TabIndex = 9;
            this.BtnEmanetVer.Text = "Emanet Ver";
            this.BtnEmanetVer.UseVisualStyleBackColor = true;
            this.BtnEmanetVer.Click += new System.EventHandler(this.BtnEmanetVer_Click);
            // 
            // BtnEmanetAl
            // 
            this.BtnEmanetAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEmanetAl.Location = new System.Drawing.Point(220, 171);
            this.BtnEmanetAl.Name = "BtnEmanetAl";
            this.BtnEmanetAl.Size = new System.Drawing.Size(182, 42);
            this.BtnEmanetAl.TabIndex = 10;
            this.BtnEmanetAl.Text = "Emanet Al";
            this.BtnEmanetAl.UseVisualStyleBackColor = true;
            this.BtnEmanetAl.Click += new System.EventHandler(this.BtnEmanetAl_Click);
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBook.Location = new System.Drawing.Point(506, 44);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(261, 32);
            this.txtBook.TabIndex = 11;
            // 
            // txtıd
            // 
            this.txtıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Location = new System.Drawing.Point(496, 122);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(271, 32);
            this.txtıd.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(418, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.BtnEmanetAl);
            this.Controls.Add(this.BtnEmanetVer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnCeza);
            this.Controls.Add(this.BtnGecmisEmanet);
            this.Controls.Add(this.BtnAktifEmanet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeposit";
            this.Text = "FrmDeposit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAktifEmanet;
        private System.Windows.Forms.Button BtnGecmisEmanet;
        private System.Windows.Forms.Button BtnCeza;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnEmanetVer;
        private System.Windows.Forms.Button BtnEmanetAl;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label3;
    }
}