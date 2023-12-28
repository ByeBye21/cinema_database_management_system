namespace cinema
{
    partial class update_dir
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
            remove = new Button();
            add = new Button();
            Yonetmen_ID = new TextBox();
            Yonetmen_Ad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // remove
            // 
            remove.Location = new Point(146, 292);
            remove.Name = "remove";
            remove.Size = new Size(94, 29);
            remove.TabIndex = 27;
            remove.Text = "Sil";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // add
            // 
            add.Location = new Point(146, 92);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 26;
            add.Text = "Ekle";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // Yonetmen_ID
            // 
            Yonetmen_ID.Location = new Point(133, 240);
            Yonetmen_ID.Name = "Yonetmen_ID";
            Yonetmen_ID.Size = new Size(125, 27);
            Yonetmen_ID.TabIndex = 25;
            // 
            // Yonetmen_Ad
            // 
            Yonetmen_Ad.Location = new Point(133, 39);
            Yonetmen_Ad.Name = "Yonetmen_Ad";
            Yonetmen_Ad.Size = new Size(125, 27);
            Yonetmen_Ad.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 243);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 23;
            label2.Text = "Yönetmen ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 22;
            label1.Text = "Yönetmen Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 21;
            // 
            // update_dir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(Yonetmen_ID);
            Controls.Add(Yonetmen_Ad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "update_dir";
            Text = "Yönetmen Güncelle";
            Load += update_dir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button remove;
        private Button add;
        private TextBox Yonetmen_ID;
        private TextBox Yonetmen_Ad;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}