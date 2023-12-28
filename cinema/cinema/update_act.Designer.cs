namespace cinema
{
    partial class update_act
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
            Oyuncu_ID = new TextBox();
            Oyuncu_Ad = new TextBox();
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
            remove.TabIndex = 34;
            remove.Text = "Sil";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // add
            // 
            add.Location = new Point(146, 92);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 33;
            add.Text = "Ekle";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // Oyuncu_ID
            // 
            Oyuncu_ID.Location = new Point(133, 240);
            Oyuncu_ID.Name = "Oyuncu_ID";
            Oyuncu_ID.Size = new Size(125, 27);
            Oyuncu_ID.TabIndex = 32;
            // 
            // Oyuncu_Ad
            // 
            Oyuncu_Ad.Location = new Point(133, 39);
            Oyuncu_Ad.Name = "Oyuncu_Ad";
            Oyuncu_Ad.Size = new Size(125, 27);
            Oyuncu_Ad.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 243);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 30;
            label2.Text = "Oyuncu ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 29;
            label1.Text = "Oyuncu Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 28;
            // 
            // update_act
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(Oyuncu_ID);
            Controls.Add(Oyuncu_Ad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "update_act";
            Text = "Oyuncu Güncelle";
            Load += update_act_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button remove;
        private Button add;
        private TextBox Oyuncu_ID;
        private TextBox Oyuncu_Ad;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}