
namespace tapsiriq1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblad = new System.Windows.Forms.Label();
            this.lblyas = new System.Windows.Forms.Label();
            this.lblkurs = new System.Windows.Forms.Label();
            this.llcins = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.numyas = new System.Windows.Forms.NumericUpDown();
            this.cmbkurs = new System.Windows.Forms.ComboBox();
            this.rbqadin = new System.Windows.Forms.RadioButton();
            this.rbkisi = new System.Windows.Forms.RadioButton();
            this.lsttelebeler = new System.Windows.Forms.ListBox();
            this.btnelaveet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpcins = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.numyas)).BeginInit();
            this.grpcins.SuspendLayout();
            this.SuspendLayout();

            // lblad
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblad.Location = new System.Drawing.Point(26, 88);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(27, 20);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Ad";

            // lblyas
            this.lblyas.AutoSize = true;
            this.lblyas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblyas.Location = new System.Drawing.Point(403, 88);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(35, 20);
            this.lblyas.TabIndex = 1;
            this.lblyas.Text = "Yaş";

            // lblkurs
            this.lblkurs.AutoSize = true;
            this.lblkurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblkurs.Location = new System.Drawing.Point(26, 154);
            this.lblkurs.Name = "lblkurs";
            this.lblkurs.Size = new System.Drawing.Size(41, 20);
            this.lblkurs.TabIndex = 2;
            this.lblkurs.Text = "Kurs";

            // llcins
            this.llcins.AutoSize = true;
            this.llcins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llcins.Location = new System.Drawing.Point(18, 0);
            this.llcins.Name = "llcins";
            this.llcins.Size = new System.Drawing.Size(40, 20);
            this.llcins.TabIndex = 3;
            this.llcins.Text = "Cins";

            // txtad
            this.txtad.Location = new System.Drawing.Point(29, 107);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(214, 22);
            this.txtad.TabIndex = 4;

            // numyas
            this.numyas.Location = new System.Drawing.Point(406, 108);
            this.numyas.Name = "numyas";
            this.numyas.Size = new System.Drawing.Size(89, 22);
            this.numyas.TabIndex = 5;

            // cmbkurs
            this.cmbkurs.FormattingEnabled = true;
            this.cmbkurs.Location = new System.Drawing.Point(29, 173);
            this.cmbkurs.Name = "cmbkurs";
            this.cmbkurs.Size = new System.Drawing.Size(121, 24);
            this.cmbkurs.TabIndex = 6;

            // rbqadin
            this.rbqadin.AutoSize = true;
            this.rbqadin.Location = new System.Drawing.Point(18, 21);
            this.rbqadin.Name = "rbqadin";
            this.rbqadin.Size = new System.Drawing.Size(62, 20);
            this.rbqadin.TabIndex = 7;
            this.rbqadin.TabStop = true;
            this.rbqadin.Text = "Qadın";
            this.rbqadin.UseVisualStyleBackColor = true;

            // rbkisi
            this.rbkisi.AutoSize = true;
            this.rbkisi.Location = new System.Drawing.Point(18, 47);
            this.rbkisi.Name = "rbkisi";
            this.rbkisi.Size = new System.Drawing.Size(48, 20);
            this.rbkisi.TabIndex = 8;
            this.rbkisi.TabStop = true;
            this.rbkisi.Text = "Kişi";
            this.rbkisi.UseVisualStyleBackColor = true;

            // lsttelebeler
            this.lsttelebeler.FormattingEnabled = true;
            this.lsttelebeler.ItemHeight = 16;
            this.lsttelebeler.Location = new System.Drawing.Point(29, 326);
            this.lsttelebeler.Name = "lsttelebeler";
            this.lsttelebeler.Size = new System.Drawing.Size(333, 100);
            this.lsttelebeler.TabIndex = 9;

            // btnelaveet
            this.btnelaveet.Location = new System.Drawing.Point(29, 252);
            this.btnelaveet.Name = "btnelaveet";
            this.btnelaveet.Size = new System.Drawing.Size(109, 23);
            this.btnelaveet.TabIndex = 10;
            this.btnelaveet.Text = "Əlavə et";
            this.btnelaveet.UseVisualStyleBackColor = true;

            // btnsil
            this.btnsil.Location = new System.Drawing.Point(168, 252);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(113, 23);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;

            // label5 - tələbə məlumatları
            this.label5.AutoSize = false;
            this.label5.Location = new System.Drawing.Point(390, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 100);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tələbə seçilməyib.";

            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 13;

            // label3 - siyahının başlığı
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tələbə siyahısı";

            // label7 - formanın başlığı
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(258, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tələbə məlumat sistemi";

            // grpcins
            this.grpcins.Controls.Add(this.rbqadin);
            this.grpcins.Controls.Add(this.rbkisi);
            this.grpcins.Controls.Add(this.llcins);
            this.grpcins.Location = new System.Drawing.Point(406, 154);
            this.grpcins.Name = "grpcins";
            this.grpcins.Size = new System.Drawing.Size(200, 78);
            this.grpcins.TabIndex = 17;
            this.grpcins.TabStop = false;
            this.grpcins.Text = "Cins";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.grpcins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnelaveet);
            this.Controls.Add(this.lsttelebeler);
            this.Controls.Add(this.cmbkurs);
            this.Controls.Add(this.numyas);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblkurs);
            this.Controls.Add(this.lblyas);
            this.Controls.Add(this.lblad);

            this.Name = "Form1";
            this.Text = "Tələbə qeydiyyatı";

            ((System.ComponentModel.ISupportInitialize)(this.numyas)).EndInit();
            this.grpcins.ResumeLayout(false);
            this.grpcins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.Label lblkurs;
        private System.Windows.Forms.Label llcins;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.NumericUpDown numyas;
        private System.Windows.Forms.ComboBox cmbkurs;
        private System.Windows.Forms.RadioButton rbqadin;
        private System.Windows.Forms.RadioButton rbkisi;
        private System.Windows.Forms.ListBox lsttelebeler;
        private System.Windows.Forms.Button btnelaveet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpcins;
    }
}
