namespace cinema
{
    partial class cinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cinema));
            update = new Button();
            search = new Button();
            buy = new Button();
            update_cat = new Button();
            update_act = new Button();
            update_dir = new Button();
            update_sal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // update
            // 
            update.BackColor = SystemColors.ButtonHighlight;
            update.BackgroundImage = (Image)resources.GetObject("update.BackgroundImage");
            update.BackgroundImageLayout = ImageLayout.Stretch;
            update.Location = new Point(598, 228);
            update.Name = "update";
            update.Size = new Size(190, 190);
            update.TabIndex = 0;
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.ButtonHighlight;
            search.BackgroundImage = (Image)resources.GetObject("search.BackgroundImage");
            search.BackgroundImageLayout = ImageLayout.Stretch;
            search.Location = new Point(302, 3);
            search.Name = "search";
            search.Size = new Size(190, 190);
            search.TabIndex = 1;
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // buy
            // 
            buy.BackColor = SystemColors.ButtonHighlight;
            buy.BackgroundImage = (Image)resources.GetObject("buy.BackgroundImage");
            buy.BackgroundImageLayout = ImageLayout.Stretch;
            buy.Location = new Point(498, 3);
            buy.Name = "buy";
            buy.Size = new Size(190, 190);
            buy.TabIndex = 2;
            buy.UseVisualStyleBackColor = false;
            buy.Click += buy_Click;
            // 
            // update_cat
            // 
            update_cat.BackColor = SystemColors.ButtonHighlight;
            update_cat.BackgroundImage = (Image)resources.GetObject("update_cat.BackgroundImage");
            update_cat.BackgroundImageLayout = ImageLayout.Stretch;
            update_cat.Location = new Point(12, 228);
            update_cat.Name = "update_cat";
            update_cat.Size = new Size(190, 190);
            update_cat.TabIndex = 3;
            update_cat.TextAlign = ContentAlignment.BottomCenter;
            update_cat.UseVisualStyleBackColor = false;
            update_cat.Click += update_cat_Click;
            // 
            // update_act
            // 
            update_act.BackColor = SystemColors.ButtonHighlight;
            update_act.BackgroundImage = (Image)resources.GetObject("update_act.BackgroundImage");
            update_act.BackgroundImageLayout = ImageLayout.Stretch;
            update_act.Location = new Point(206, 228);
            update_act.Name = "update_act";
            update_act.Size = new Size(190, 190);
            update_act.TabIndex = 4;
            update_act.TextAlign = ContentAlignment.BottomCenter;
            update_act.UseVisualStyleBackColor = false;
            update_act.Click += update_act_Click;
            // 
            // update_dir
            // 
            update_dir.BackColor = SystemColors.ButtonHighlight;
            update_dir.BackgroundImage = (Image)resources.GetObject("update_dir.BackgroundImage");
            update_dir.BackgroundImageLayout = ImageLayout.Stretch;
            update_dir.Location = new Point(402, 228);
            update_dir.Name = "update_dir";
            update_dir.Size = new Size(190, 190);
            update_dir.TabIndex = 5;
            update_dir.TextAlign = ContentAlignment.BottomCenter;
            update_dir.UseVisualStyleBackColor = false;
            update_dir.Click += update_dir_Click;
            // 
            // update_sal
            // 
            update_sal.BackColor = SystemColors.ButtonHighlight;
            update_sal.BackgroundImage = (Image)resources.GetObject("update_sal.BackgroundImage");
            update_sal.BackgroundImageLayout = ImageLayout.Stretch;
            update_sal.Location = new Point(106, 3);
            update_sal.Name = "update_sal";
            update_sal.Size = new Size(190, 190);
            update_sal.TabIndex = 0;
            update_sal.UseVisualStyleBackColor = false;
            update_sal.Click += update_sal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 421);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 6;
            label1.Text = "Tür Güncelle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 422);
            label2.Name = "label2";
            label2.Size = new Size(193, 19);
            label2.TabIndex = 7;
            label2.Text = "Oyuncuları Güncelle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 424);
            label3.Name = "label3";
            label3.Size = new Size(189, 16);
            label3.TabIndex = 8;
            label3.Text = "Yönetmenleri Güncelle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(621, 421);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 9;
            label4.Text = "Film Güncelle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 196);
            label5.Name = "label5";
            label5.Size = new Size(183, 19);
            label5.TabIndex = 10;
            label5.Text = "Salonları Güncelle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(345, 196);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 11;
            label6.Text = "Film Ara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(547, 196);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 12;
            label7.Text = "Bilet Al";
            // 
            // cinema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(update_sal);
            Controls.Add(update_dir);
            Controls.Add(update_act);
            Controls.Add(update_cat);
            Controls.Add(buy);
            Controls.Add(search);
            Controls.Add(update);
            Name = "cinema";
            Text = "Sinema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update;
        private Button search;
        private Button buy;
        private Button update_cat;
        private Button update_act;
        private Button update_dir;
        private Button update_sal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}