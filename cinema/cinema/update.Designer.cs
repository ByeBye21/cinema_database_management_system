namespace cinema
{
    partial class update
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
            Degerlendirme = new TextBox();
            Yayin_Yil = new TextBox();
            Film_Ad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Yonetmen = new ComboBox();
            Oyuncular = new CheckedListBox();
            dataGridView1 = new DataGridView();
            Tur = new CheckedListBox();
            label1 = new Label();
            add = new Button();
            remove = new Button();
            label7 = new Label();
            Film_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Degerlendirme
            // 
            Degerlendirme.Location = new Point(106, 70);
            Degerlendirme.Name = "Degerlendirme";
            Degerlendirme.Size = new Size(125, 27);
            Degerlendirme.TabIndex = 1;
            Degerlendirme.Text = "0";
            // 
            // Yayin_Yil
            // 
            Yayin_Yil.Location = new Point(106, 34);
            Yayin_Yil.Name = "Yayin_Yil";
            Yayin_Yil.Size = new Size(125, 27);
            Yayin_Yil.TabIndex = 2;
            Yayin_Yil.Text = "0";
            // 
            // Film_Ad
            // 
            Film_Ad.Location = new Point(106, 1);
            Film_Ad.Name = "Film_Ad";
            Film_Ad.Size = new Size(125, 27);
            Film_Ad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 4);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Film Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 37);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Yayın Yılı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 73);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "IMDB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 108);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Yönetmen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 172);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Oyuncular";
            // 
            // Yonetmen
            // 
            Yonetmen.FormattingEnabled = true;
            Yonetmen.Location = new Point(80, 105);
            Yonetmen.Name = "Yonetmen";
            Yonetmen.Size = new Size(151, 28);
            Yonetmen.TabIndex = 10;
            // 
            // Oyuncular
            // 
            Oyuncular.FormattingEnabled = true;
            Oyuncular.Location = new Point(81, 139);
            Oyuncular.Name = "Oyuncular";
            Oyuncular.Size = new Size(150, 92);
            Oyuncular.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 12;
            // 
            // Tur
            // 
            Tur.FormattingEnabled = true;
            Tur.Location = new Point(80, 237);
            Tur.Name = "Tur";
            Tur.Size = new Size(150, 92);
            Tur.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 274);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 14;
            label1.Text = "Tür";
            // 
            // add
            // 
            add.Location = new Point(106, 335);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 15;
            add.Text = "Ekle";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(106, 420);
            remove.Name = "remove";
            remove.Size = new Size(94, 29);
            remove.TabIndex = 16;
            remove.Text = "Sil";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 390);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 17;
            label7.Text = "Film ID";
            // 
            // Film_ID
            // 
            Film_ID.Location = new Point(80, 387);
            Film_ID.Name = "Film_ID";
            Film_ID.Size = new Size(125, 27);
            Film_ID.TabIndex = 18;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Film_ID);
            Controls.Add(label7);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(label1);
            Controls.Add(Tur);
            Controls.Add(dataGridView1);
            Controls.Add(Oyuncular);
            Controls.Add(Yonetmen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Film_Ad);
            Controls.Add(Yayin_Yil);
            Controls.Add(Degerlendirme);
            Name = "update";
            Text = "Film Güncelleme";
            Load += update_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Degerlendirme;
        private TextBox Yayin_Yil;
        private TextBox Film_Ad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Yonetmen;
        private CheckedListBox Oyuncular;
        private DataGridView dataGridView1;
        private CheckedListBox Tur;
        private Label label1;
        private Button add;
        private Button remove;
        private Label label7;
        private TextBox Film_ID;
    }
}