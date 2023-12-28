namespace cinema
{
    partial class update_cat
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
            Tur_ID = new TextBox();
            Tur_Ad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            add = new Button();
            remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tur_ID
            // 
            Tur_ID.Location = new Point(133, 240);
            Tur_ID.Name = "Tur_ID";
            Tur_ID.Size = new Size(125, 27);
            Tur_ID.TabIndex = 18;
            // 
            // Tur_Ad
            // 
            Tur_Ad.Location = new Point(133, 39);
            Tur_Ad.Name = "Tur_Ad";
            Tur_Ad.Size = new Size(125, 27);
            Tur_Ad.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 243);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Tür ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 15;
            label1.Text = "Tür Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 14;
            // 
            // add
            // 
            add.Location = new Point(146, 92);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 19;
            add.Text = "Ekle";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(146, 292);
            remove.Name = "remove";
            remove.Size = new Size(94, 29);
            remove.TabIndex = 20;
            remove.Text = "Sil";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // update_cat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(Tur_ID);
            Controls.Add(Tur_Ad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "update_cat";
            Text = "Tür Güncelle";
            Load += update_cat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tur_ID;
        private TextBox Tur_Ad;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button add;
        private Button remove;
    }
}