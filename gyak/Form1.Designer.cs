namespace gyak
{
    partial class frfmfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.btnszamol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbharomsz = new System.Windows.Forms.ListBox();
            this.btntorol = new System.Windows.Forms.Button();
            this.btnfajl = new System.Windows.Forms.Button();
            this.ofdnyit = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A háromszög oldalai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "C:";
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(123, 49);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 29);
            this.tba.TabIndex = 4;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(123, 95);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 29);
            this.tbb.TabIndex = 5;
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(123, 137);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(100, 29);
            this.tbc.TabIndex = 6;
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(267, 202);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(105, 34);
            this.btnkilepes.TabIndex = 7;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            this.btnkilepes.Click += new System.EventHandler(this.btnkilepes_Click);
            // 
            // btnszamol
            // 
            this.btnszamol.Location = new System.Drawing.Point(24, 202);
            this.btnszamol.Name = "btnszamol";
            this.btnszamol.Size = new System.Drawing.Size(105, 34);
            this.btnszamol.TabIndex = 8;
            this.btnszamol.Text = "Számolás";
            this.btnszamol.UseVisualStyleBackColor = true;
            this.btnszamol.Click += new System.EventHandler(this.btnszamol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.tbc);
            this.panel1.Controls.Add(this.tbb);
            this.panel1.Controls.Add(this.tba);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 183);
            this.panel1.TabIndex = 9;
            // 
            // lbharomsz
            // 
            this.lbharomsz.FormattingEnabled = true;
            this.lbharomsz.ItemHeight = 24;
            this.lbharomsz.Location = new System.Drawing.Point(454, 17);
            this.lbharomsz.Name = "lbharomsz";
            this.lbharomsz.Size = new System.Drawing.Size(319, 148);
            this.lbharomsz.TabIndex = 10;
            this.lbharomsz.SelectedIndexChanged += new System.EventHandler(this.lbharomsz_SelectedIndexChanged);
            // 
            // btntorol
            // 
            this.btntorol.Location = new System.Drawing.Point(555, 200);
            this.btntorol.Name = "btntorol";
            this.btntorol.Size = new System.Drawing.Size(132, 35);
            this.btntorol.TabIndex = 11;
            this.btntorol.Text = "Törlés";
            this.btntorol.UseVisualStyleBackColor = true;
            this.btntorol.Click += new System.EventHandler(this.btntorol_Click);
            // 
            // btnfajl
            // 
            this.btnfajl.Location = new System.Drawing.Point(407, 200);
            this.btnfajl.Name = "btnfajl";
            this.btnfajl.Size = new System.Drawing.Size(112, 34);
            this.btnfajl.TabIndex = 12;
            this.btnfajl.Text = "Fájl";
            this.btnfajl.UseVisualStyleBackColor = true;
            this.btnfajl.Click += new System.EventHandler(this.btnfajl_Click);
            // 
            // ofdnyit
            // 
            this.ofdnyit.FileName = "openFileDialog1";
            this.ofdnyit.Filter = "TextFiles|*.txt";
            this.ofdnyit.InitialDirectory = "C:\\Users\\c16TÓTHM\\source\\repos\\gyak\\gyak\\bin\\Debug";
            // 
            // frfmfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 261);
            this.Controls.Add(this.btnfajl);
            this.Controls.Add(this.btntorol);
            this.Controls.Add(this.lbharomsz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnszamol);
            this.Controls.Add(this.btnkilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frfmfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "haromszog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.Button btnszamol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbharomsz;
        private System.Windows.Forms.Button btntorol;
        private System.Windows.Forms.Button btnfajl;
        private System.Windows.Forms.OpenFileDialog ofdnyit;
    }
}

