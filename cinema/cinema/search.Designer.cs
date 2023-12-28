namespace cinema
{
    partial class search
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
            find = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Film_Ad = new TextBox();
            Yayin_Yil = new TextBox();
            Degerlendirme = new TextBox();
            Yayin_Yil2 = new TextBox();
            Degerlendirme2 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // find
            // 
            find.Location = new Point(103, 355);
            find.Name = "find";
            find.Size = new Size(94, 29);
            find.TabIndex = 27;
            find.Text = "Ara";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 252);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 33;
            label4.Text = "IMDB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 32;
            label3.Text = "Yayın Yılı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 31;
            label2.Text = "Film Adı";
            // 
            // Film_Ad
            // 
            Film_Ad.Location = new Point(82, 24);
            Film_Ad.Name = "Film_Ad";
            Film_Ad.Size = new Size(203, 27);
            Film_Ad.TabIndex = 30;
            // 
            // Yayin_Yil
            // 
            Yayin_Yil.Location = new Point(33, 161);
            Yayin_Yil.Name = "Yayin_Yil";
            Yayin_Yil.Size = new Size(77, 27);
            Yayin_Yil.TabIndex = 29;
            // 
            // Degerlendirme
            // 
            Degerlendirme.Location = new Point(33, 249);
            Degerlendirme.Name = "Degerlendirme";
            Degerlendirme.Size = new Size(77, 27);
            Degerlendirme.TabIndex = 28;
            // 
            // Yayin_Yil2
            // 
            Yayin_Yil2.Location = new Point(189, 161);
            Yayin_Yil2.Name = "Yayin_Yil2";
            Yayin_Yil2.Size = new Size(90, 27);
            Yayin_Yil2.TabIndex = 39;
            // 
            // Degerlendirme2
            // 
            Degerlendirme2.Location = new Point(189, 249);
            Degerlendirme2.Name = "Degerlendirme2";
            Degerlendirme2.Size = new Size(90, 27);
            Degerlendirme2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 124);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 41;
            label1.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 124);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 42;
            label5.Text = "To";
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(Degerlendirme2);
            Controls.Add(Yayin_Yil2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Film_Ad);
            Controls.Add(Yayin_Yil);
            Controls.Add(Degerlendirme);
            Controls.Add(find);
            Name = "search";
            Text = "Film Arama";
            Load += search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button find;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox Film_Ad;
        private TextBox Yayin_Yil;
        private TextBox Degerlendirme;
        private TextBox Yayin_Yil2;
        private TextBox Degerlendirme2;
        private Label label1;
        private Label label5;
    }
}