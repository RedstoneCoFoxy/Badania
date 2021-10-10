
namespace BadaniaNFZ
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
            this.components = new System.ComponentModel.Container();
            this.DodajBadanie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoweBadanie_Datomierz = new System.Windows.Forms.DateTimePicker();
            this.NoweBadanie_Nazwa = new System.Windows.Forms.TextBox();
            this.NoweBadanie_Imie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DebugText = new System.Windows.Forms.Label();
            this.Sekundownik10 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NastepneDni = new System.Windows.Forms.Label();
            this.PoprzednieDni = new System.Windows.Forms.Label();
            this.ObecneDni = new System.Windows.Forms.Label();
            this.ButtonMoveDown1 = new System.Windows.Forms.Button();
            this.ButtonMoveUp1 = new System.Windows.Forms.Button();
            this.ButtonUsunBadanie = new System.Windows.Forms.Button();
            this.LabelWybranaPozycja = new System.Windows.Forms.Label();
            this.ButtonPoprzednieBadanie = new System.Windows.Forms.Button();
            this.ButtonNastepneBadanie = new System.Windows.Forms.Button();
            this.NastepneBadanie = new System.Windows.Forms.Label();
            this.PoprzednieBadanie = new System.Windows.Forms.Label();
            this.ObecneBadanie = new System.Windows.Forms.Label();
            this.DataCzasLabel = new System.Windows.Forms.Label();
            this.Zapisywanie = new System.Windows.Forms.GroupBox();
            this.FileSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Zapisywanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // DodajBadanie
            // 
            this.DodajBadanie.Location = new System.Drawing.Point(60, 116);
            this.DodajBadanie.Name = "DodajBadanie";
            this.DodajBadanie.Size = new System.Drawing.Size(75, 23);
            this.DodajBadanie.TabIndex = 0;
            this.DodajBadanie.Text = "Dodaj Badanie";
            this.DodajBadanie.UseVisualStyleBackColor = true;
            this.DodajBadanie.Click += new System.EventHandler(this.DodajBadanie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoweBadanie_Datomierz);
            this.groupBox1.Controls.Add(this.NoweBadanie_Nazwa);
            this.groupBox1.Controls.Add(this.NoweBadanie_Imie);
            this.groupBox1.Controls.Add(this.DodajBadanie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nowe Badanie";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NoweBadanie_Datomierz
            // 
            this.NoweBadanie_Datomierz.Location = new System.Drawing.Point(7, 87);
            this.NoweBadanie_Datomierz.Name = "NoweBadanie_Datomierz";
            this.NoweBadanie_Datomierz.Size = new System.Drawing.Size(187, 23);
            this.NoweBadanie_Datomierz.TabIndex = 9;
            this.NoweBadanie_Datomierz.ValueChanged += new System.EventHandler(this.NoweBadanie_Datomierz_ValueChanged);
            // 
            // NoweBadanie_Nazwa
            // 
            this.NoweBadanie_Nazwa.Location = new System.Drawing.Point(94, 58);
            this.NoweBadanie_Nazwa.Name = "NoweBadanie_Nazwa";
            this.NoweBadanie_Nazwa.Size = new System.Drawing.Size(100, 23);
            this.NoweBadanie_Nazwa.TabIndex = 8;
            this.NoweBadanie_Nazwa.TextChanged += new System.EventHandler(this.NoweBadanie_Nazwa_TextChanged);
            // 
            // NoweBadanie_Imie
            // 
            this.NoweBadanie_Imie.Location = new System.Drawing.Point(94, 22);
            this.NoweBadanie_Imie.Name = "NoweBadanie_Imie";
            this.NoweBadanie_Imie.Size = new System.Drawing.Size(100, 23);
            this.NoweBadanie_Imie.TabIndex = 7;
            this.NoweBadanie_Imie.TextChanged += new System.EventHandler(this.NoweBadanie_Imie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa";
            // 
            // DebugText
            // 
            this.DebugText.AutoSize = true;
            this.DebugText.Location = new System.Drawing.Point(18, 397);
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(0, 15);
            this.DebugText.TabIndex = 2;
            // 
            // Sekundownik10
            // 
            this.Sekundownik10.Enabled = true;
            this.Sekundownik10.Interval = 1000;
            this.Sekundownik10.Tick += new System.EventHandler(this.Sekundownik10_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NastepneDni);
            this.groupBox2.Controls.Add(this.PoprzednieDni);
            this.groupBox2.Controls.Add(this.ObecneDni);
            this.groupBox2.Controls.Add(this.ButtonMoveDown1);
            this.groupBox2.Controls.Add(this.ButtonMoveUp1);
            this.groupBox2.Controls.Add(this.ButtonUsunBadanie);
            this.groupBox2.Controls.Add(this.LabelWybranaPozycja);
            this.groupBox2.Controls.Add(this.ButtonPoprzednieBadanie);
            this.groupBox2.Controls.Add(this.ButtonNastepneBadanie);
            this.groupBox2.Controls.Add(this.NastepneBadanie);
            this.groupBox2.Controls.Add(this.PoprzednieBadanie);
            this.groupBox2.Controls.Add(this.ObecneBadanie);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 425);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Badania";
            // 
            // NastepneDni
            // 
            this.NastepneDni.AutoSize = true;
            this.NastepneDni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NastepneDni.Location = new System.Drawing.Point(21, 90);
            this.NastepneDni.Name = "NastepneDni";
            this.NastepneDni.Size = new System.Drawing.Size(24, 32);
            this.NastepneDni.TabIndex = 11;
            this.NastepneDni.Text = "/";
            this.NastepneDni.Click += new System.EventHandler(this.NastepneDni_Click);
            // 
            // PoprzednieDni
            // 
            this.PoprzednieDni.AutoSize = true;
            this.PoprzednieDni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PoprzednieDni.Location = new System.Drawing.Point(21, 21);
            this.PoprzednieDni.Name = "PoprzednieDni";
            this.PoprzednieDni.Size = new System.Drawing.Size(24, 32);
            this.PoprzednieDni.TabIndex = 10;
            this.PoprzednieDni.Text = "/";
            this.PoprzednieDni.Click += new System.EventHandler(this.PoprzednieDni_Click);
            // 
            // ObecneDni
            // 
            this.ObecneDni.AutoSize = true;
            this.ObecneDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObecneDni.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ObecneDni.Location = new System.Drawing.Point(21, 53);
            this.ObecneDni.Name = "ObecneDni";
            this.ObecneDni.Size = new System.Drawing.Size(28, 37);
            this.ObecneDni.TabIndex = 9;
            this.ObecneDni.Text = "/";
            this.ObecneDni.Click += new System.EventHandler(this.ObecneDni_Click);
            // 
            // ButtonMoveDown1
            // 
            this.ButtonMoveDown1.Location = new System.Drawing.Point(325, 384);
            this.ButtonMoveDown1.Name = "ButtonMoveDown1";
            this.ButtonMoveDown1.Size = new System.Drawing.Size(39, 23);
            this.ButtonMoveDown1.TabIndex = 8;
            this.ButtonMoveDown1.Text = "-";
            this.ButtonMoveDown1.UseVisualStyleBackColor = true;
            this.ButtonMoveDown1.Click += new System.EventHandler(this.ButtonMoveDown1_Click);
            // 
            // ButtonMoveUp1
            // 
            this.ButtonMoveUp1.Location = new System.Drawing.Point(280, 384);
            this.ButtonMoveUp1.Name = "ButtonMoveUp1";
            this.ButtonMoveUp1.Size = new System.Drawing.Size(39, 23);
            this.ButtonMoveUp1.TabIndex = 7;
            this.ButtonMoveUp1.Text = "+";
            this.ButtonMoveUp1.UseVisualStyleBackColor = true;
            this.ButtonMoveUp1.Click += new System.EventHandler(this.ButtonMoveUp1_Click);
            // 
            // ButtonUsunBadanie
            // 
            this.ButtonUsunBadanie.Location = new System.Drawing.Point(199, 384);
            this.ButtonUsunBadanie.Name = "ButtonUsunBadanie";
            this.ButtonUsunBadanie.Size = new System.Drawing.Size(75, 23);
            this.ButtonUsunBadanie.TabIndex = 6;
            this.ButtonUsunBadanie.Text = "Usun";
            this.ButtonUsunBadanie.UseVisualStyleBackColor = false;
            this.ButtonUsunBadanie.Click += new System.EventHandler(this.ButtonUsunBadanie_Click);
            // 
            // LabelWybranaPozycja
            // 
            this.LabelWybranaPozycja.Location = new System.Drawing.Point(168, 384);
            this.LabelWybranaPozycja.Name = "LabelWybranaPozycja";
            this.LabelWybranaPozycja.Size = new System.Drawing.Size(49, 23);
            this.LabelWybranaPozycja.TabIndex = 5;
            this.LabelWybranaPozycja.Text = "0";
            // 
            // ButtonPoprzednieBadanie
            // 
            this.ButtonPoprzednieBadanie.Location = new System.Drawing.Point(6, 384);
            this.ButtonPoprzednieBadanie.Name = "ButtonPoprzednieBadanie";
            this.ButtonPoprzednieBadanie.Size = new System.Drawing.Size(75, 23);
            this.ButtonPoprzednieBadanie.TabIndex = 4;
            this.ButtonPoprzednieBadanie.Text = "<";
            this.ButtonPoprzednieBadanie.UseVisualStyleBackColor = true;
            this.ButtonPoprzednieBadanie.Click += new System.EventHandler(this.ButtonPoprzednieBadanie_Click);
            // 
            // ButtonNastepneBadanie
            // 
            this.ButtonNastepneBadanie.Location = new System.Drawing.Point(87, 384);
            this.ButtonNastepneBadanie.Name = "ButtonNastepneBadanie";
            this.ButtonNastepneBadanie.Size = new System.Drawing.Size(75, 23);
            this.ButtonNastepneBadanie.TabIndex = 3;
            this.ButtonNastepneBadanie.Text = ">";
            this.ButtonNastepneBadanie.UseVisualStyleBackColor = true;
            this.ButtonNastepneBadanie.Click += new System.EventHandler(this.ButtonNastepneBadanie_Click);
            // 
            // NastepneBadanie
            // 
            this.NastepneBadanie.AutoSize = true;
            this.NastepneBadanie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NastepneBadanie.Location = new System.Drawing.Point(168, 90);
            this.NastepneBadanie.Name = "NastepneBadanie";
            this.NastepneBadanie.Size = new System.Drawing.Size(23, 32);
            this.NastepneBadanie.TabIndex = 2;
            this.NastepneBadanie.Text = "/";
            // 
            // PoprzednieBadanie
            // 
            this.PoprzednieBadanie.AutoSize = true;
            this.PoprzednieBadanie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoprzednieBadanie.Location = new System.Drawing.Point(168, 21);
            this.PoprzednieBadanie.Name = "PoprzednieBadanie";
            this.PoprzednieBadanie.Size = new System.Drawing.Size(23, 32);
            this.PoprzednieBadanie.TabIndex = 1;
            this.PoprzednieBadanie.Text = "/";
            // 
            // ObecneBadanie
            // 
            this.ObecneBadanie.AutoSize = true;
            this.ObecneBadanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObecneBadanie.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ObecneBadanie.Location = new System.Drawing.Point(168, 53);
            this.ObecneBadanie.Name = "ObecneBadanie";
            this.ObecneBadanie.Size = new System.Drawing.Size(29, 37);
            this.ObecneBadanie.TabIndex = 0;
            this.ObecneBadanie.Text = "/";
            // 
            // DataCzasLabel
            // 
            this.DataCzasLabel.AutoSize = true;
            this.DataCzasLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataCzasLabel.Location = new System.Drawing.Point(35, 159);
            this.DataCzasLabel.Name = "DataCzasLabel";
            this.DataCzasLabel.Size = new System.Drawing.Size(152, 25);
            this.DataCzasLabel.TabIndex = 4;
            this.DataCzasLabel.Text = "...................................";
            // 
            // Zapisywanie
            // 
            this.Zapisywanie.Controls.Add(this.FileSave);
            this.Zapisywanie.Controls.Add(this.label3);
            this.Zapisywanie.Controls.Add(this.FileName);
            this.Zapisywanie.Location = new System.Drawing.Point(12, 228);
            this.Zapisywanie.Name = "Zapisywanie";
            this.Zapisywanie.Size = new System.Drawing.Size(200, 90);
            this.Zapisywanie.TabIndex = 5;
            this.Zapisywanie.TabStop = false;
            this.Zapisywanie.Text = "Zapisywanie";
            // 
            // FileSave
            // 
            this.FileSave.Location = new System.Drawing.Point(94, 51);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(75, 23);
            this.FileSave.TabIndex = 6;
            this.FileSave.Text = "Zapisz";
            this.FileSave.UseVisualStyleBackColor = true;
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nazwa Pliku";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(84, 22);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 23);
            this.FileName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.Zapisywanie);
            this.Controls.Add(this.DataCzasLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DebugText);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Zapisywanie.ResumeLayout(false);
            this.Zapisywanie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajBadanie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoweBadanie_Nazwa;
        private System.Windows.Forms.TextBox NoweBadanie_Imie;
        private System.Windows.Forms.Label DebugText;
        private System.Windows.Forms.DateTimePicker NoweBadanie_Datomierz;
        private System.Windows.Forms.Timer Sekundownik10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label DataCzasLabel;
        private System.Windows.Forms.Label NastepneBadanie;
        private System.Windows.Forms.Label PoprzednieBadanie;
        private System.Windows.Forms.Label ObecneBadanie;
        private System.Windows.Forms.Button ButtonPoprzednieBadanie;
        private System.Windows.Forms.Button ButtonNastepneBadanie;
        private System.Windows.Forms.Label LabelWybranaPozycja;
        private System.Windows.Forms.Button ButtonUsunBadanie;
        private System.Windows.Forms.Button ButtonMoveDown1;
        private System.Windows.Forms.Button ButtonMoveUp1;
        private System.Windows.Forms.GroupBox Zapisywanie;
        private System.Windows.Forms.Button FileSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label NastepneDni;
        private System.Windows.Forms.Label PoprzednieDni;
        private System.Windows.Forms.Label ObecneDni;
    }
}

