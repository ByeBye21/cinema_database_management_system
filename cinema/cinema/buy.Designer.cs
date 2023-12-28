namespace cinema
{
    partial class buy
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
            Salon = new ComboBox();
            purchase = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            Ad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Salon
            // 
            Salon.FormattingEnabled = true;
            Salon.Location = new Point(102, 165);
            Salon.Name = "Salon";
            Salon.Size = new Size(125, 28);
            Salon.TabIndex = 0;
            // 
            // purchase
            // 
            purchase.Location = new Point(113, 223);
            purchase.Name = "purchase";
            purchase.Size = new Size(94, 29);
            purchase.TabIndex = 6;
            purchase.Text = "Bilet Al";
            purchase.UseVisualStyleBackColor = true;
            purchase.Click += purchase_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 168);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Salon";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 110);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 41;
            label4.Text = "Ad";
            // 
            // Ad
            // 
            Ad.Location = new Point(102, 107);
            Ad.Name = "Ad";
            Ad.Size = new Size(125, 27);
            Ad.TabIndex = 42;
            // 
            // buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ad);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(purchase);
            Controls.Add(Salon);
            Name = "buy";
            Text = "Bilet Al";
            Load += buy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Salon;
        private Button purchase;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox Ad;
    }
}