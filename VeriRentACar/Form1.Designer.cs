﻿namespace VeriRentACar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiyat = new System.Windows.Forms.Button();
            this.lstArac = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gunluk Fiyat";
            this.columnHeader2.Width = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Araclar:";
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Location = new System.Drawing.Point(139, 20);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(133, 21);
            this.cmbAracTipi.TabIndex = 11;
            this.cmbAracTipi.SelectedIndexChanged += new System.EventHandler(this.cmbAracTipi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Arac Tipi:";
            // 
            // btnFiyat
            // 
            this.btnFiyat.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiyat.Location = new System.Drawing.Point(328, 220);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(168, 55);
            this.btnFiyat.TabIndex = 19;
            this.btnFiyat.Text = "Toplam Fiyat Goster";
            this.btnFiyat.UseVisualStyleBackColor = true;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // lstArac
            // 
            this.lstArac.FormattingEnabled = true;
            this.lstArac.Location = new System.Drawing.Point(328, 81);
            this.lstArac.Name = "lstArac";
            this.lstArac.Size = new System.Drawing.Size(168, 134);
            this.lstArac.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Karar Verilen Arac:";
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracKirala.Location = new System.Drawing.Point(39, 216);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(233, 55);
            this.btnAracKirala.TabIndex = 16;
            this.btnAracKirala.Text = "Araci Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = true;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(145, 190);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(126, 20);
            this.txtGunSayisi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gun Sayisi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAracTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiyat);
            this.Controls.Add(this.lstArac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.ListBox lstArac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Label label3;
    }
}

