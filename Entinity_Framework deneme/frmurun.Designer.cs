namespace Entinity_Framework_deneme
{
    partial class frmurun
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngunc = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(120, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(120, 62);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(159, 30);
            this.txturunad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(120, 112);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(159, 30);
            this.txtmarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(120, 160);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(159, 30);
            this.txtstok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(120, 212);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(159, 30);
            this.txtfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(120, 268);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(159, 30);
            this.txtdurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori:";
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(120, 312);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(159, 33);
            this.cmbkategori.TabIndex = 13;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.White;
            this.btnlist.Location = new System.Drawing.Point(364, 21);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(226, 40);
            this.btnlist.TabIndex = 14;
            this.btnlist.Text = "LİSTELE";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(364, 163);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(226, 40);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(364, 86);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(226, 40);
            this.btnekle.TabIndex = 16;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngunc
            // 
            this.btngunc.BackColor = System.Drawing.Color.White;
            this.btngunc.Location = new System.Drawing.Point(364, 234);
            this.btngunc.Name = "btngunc";
            this.btngunc.Size = new System.Drawing.Size(226, 40);
            this.btngunc.TabIndex = 17;
            this.btngunc.Text = "GÜNCELLE";
            this.btngunc.UseVisualStyleBackColor = false;
            this.btngunc.Click += new System.EventHandler(this.btngunc_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.BackColor = System.Drawing.Color.White;
            this.btntemiz.Location = new System.Drawing.Point(364, 305);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(226, 40);
            this.btntemiz.TabIndex = 18;
            this.btntemiz.Text = "TEMİZLE";
            this.btntemiz.UseVisualStyleBackColor = false;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 205);
            this.dataGridView1.TabIndex = 19;
            // 
            // frmurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(605, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntemiz);
            this.Controls.Add(this.btngunc);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmurun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmurun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngunc;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}