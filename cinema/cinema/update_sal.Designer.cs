namespace cinema
{
    partial class update_sal
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
            Sinema = new TextBox();
            Kapasite = new TextBox();
            Film = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            add = new Button();
            label4 = new Label();
            Salon = new TextBox();
            remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Sinema
            // 
            Sinema.Location = new Point(101, 12);
            Sinema.Name = "Sinema";
            Sinema.Size = new Size(125, 27);
            Sinema.TabIndex = 0;
            // 
            // Kapasite
            // 
            Kapasite.Location = new Point(101, 85);
            Kapasite.Name = "Kapasite";
            Kapasite.Size = new Size(125, 27);
            Kapasite.TabIndex = 1;
            // 
            // Film
            // 
            Film.FormattingEnabled = true;
            Film.Location = new Point(101, 164);
            Film.Name = "Film";
            Film.Size = new Size(151, 28);
            Film.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Sinema Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 167);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Film Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Kapasite";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 40;
            // 
            // add
            // 
            add.Location = new Point(101, 233);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 41;
            add.Text = "Ekle";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 317);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 42;
            label4.Text = "Salon ID";
            // 
            // Salon
            // 
            Salon.Location = new Point(101, 314);
            Salon.Name = "Salon";
            Salon.Size = new Size(125, 27);
            Salon.TabIndex = 43;
            // 
            // remove
            // 
            remove.Location = new Point(101, 377);
            remove.Name = "remove";
            remove.Size = new Size(94, 29);
            remove.TabIndex = 44;
            remove.Text = "Sil";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // update_sal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remove);
            Controls.Add(Salon);
            Controls.Add(label4);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Film);
            Controls.Add(Kapasite);
            Controls.Add(Sinema);
            Name = "update_sal";
            Text = "Salonları Güncelle";
            Load += update_sal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Sinema;
        private TextBox Kapasite;
        private ComboBox Film;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button add;
        private Label label4;
        private TextBox Salon;
        private Button remove;
    }
}