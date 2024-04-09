namespace Academia_Aisle_Books
{
    partial class BackgroundImage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundImage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePicture1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.dividerPictureBox = new System.Windows.Forms.PictureBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.horrorBookInput = new System.Windows.Forms.TextBox();
            this.romanceBookInput = new System.Windows.Forms.TextBox();
            this.fantasyBookInput = new System.Windows.Forms.TextBox();
            this.fantasyBookLabel = new System.Windows.Forms.Label();
            this.horrorBookLabel = new System.Windows.Forms.Label();
            this.romanceBookLabel = new System.Windows.Forms.Label();
            this.receiptOutputLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.closeShopButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture1)).BeginInit();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dividerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.titlePicture1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(226, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 66);
            this.panel1.TabIndex = 4;
            // 
            // titlePicture1
            // 
            this.titlePicture1.BackColor = System.Drawing.Color.Transparent;
            this.titlePicture1.Image = ((System.Drawing.Image)(resources.GetObject("titlePicture1.Image")));
            this.titlePicture1.Location = new System.Drawing.Point(487, 3);
            this.titlePicture1.Name = "titlePicture1";
            this.titlePicture1.Size = new System.Drawing.Size(109, 63);
            this.titlePicture1.TabIndex = 1;
            this.titlePicture1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(112)))), ((int)(((byte)(84)))));
            this.titleLabel.Location = new System.Drawing.Point(45, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(507, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Academia Aisle Books";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.registerPanel.Controls.Add(this.calculateTotalButton);
            this.registerPanel.Controls.Add(this.subtotalOutputLabel);
            this.registerPanel.Controls.Add(this.printReceiptButton);
            this.registerPanel.Controls.Add(this.changeOutputLabel);
            this.registerPanel.Controls.Add(this.totalOutputLabel);
            this.registerPanel.Controls.Add(this.taxOutputLabel);
            this.registerPanel.Controls.Add(this.changeLabel);
            this.registerPanel.Controls.Add(this.calculateChangeButton);
            this.registerPanel.Controls.Add(this.tenderedInput);
            this.registerPanel.Controls.Add(this.tenderedLabel);
            this.registerPanel.Controls.Add(this.dividerPictureBox);
            this.registerPanel.Controls.Add(this.totalLabel);
            this.registerPanel.Controls.Add(this.taxLabel);
            this.registerPanel.Controls.Add(this.subtotalLabel);
            this.registerPanel.Controls.Add(this.horrorBookInput);
            this.registerPanel.Controls.Add(this.romanceBookInput);
            this.registerPanel.Controls.Add(this.fantasyBookInput);
            this.registerPanel.Controls.Add(this.fantasyBookLabel);
            this.registerPanel.Controls.Add(this.horrorBookLabel);
            this.registerPanel.Controls.Add(this.romanceBookLabel);
            this.registerPanel.Location = new System.Drawing.Point(226, 106);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(289, 638);
            this.registerPanel.TabIndex = 5;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.calculateTotalButton.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.calculateTotalButton.Location = new System.Drawing.Point(53, 161);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(177, 57);
            this.calculateTotalButton.TabIndex = 21;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutputLabel.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.subtotalOutputLabel.Location = new System.Drawing.Point(178, 235);
            this.subtotalOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(98, 25);
            this.subtotalOutputLabel.TabIndex = 15;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.printReceiptButton.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.printReceiptButton.Location = new System.Drawing.Point(53, 563);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(177, 52);
            this.printReceiptButton.TabIndex = 20;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeOutputLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.changeOutputLabel.Location = new System.Drawing.Point(180, 519);
            this.changeOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(96, 27);
            this.changeOutputLabel.TabIndex = 18;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalOutputLabel.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.totalOutputLabel.Location = new System.Drawing.Point(175, 285);
            this.totalOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(84, 30);
            this.totalOutputLabel.TabIndex = 17;
            
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxOutputLabel.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.taxOutputLabel.Location = new System.Drawing.Point(178, 260);
            this.taxOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(68, 25);
            this.taxOutputLabel.TabIndex = 16;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.changeLabel.Location = new System.Drawing.Point(4, 519);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(115, 27);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(156)))));
            this.calculateChangeButton.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.calculateChangeButton.Location = new System.Drawing.Point(43, 444);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(203, 52);
            this.calculateChangeButton.TabIndex = 13;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(180, 399);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(96, 28);
            this.tenderedInput.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.tenderedLabel.Location = new System.Drawing.Point(4, 402);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(115, 27);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered";
            // 
            // dividerPictureBox
            // 
            this.dividerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dividerPictureBox.Image")));
            this.dividerPictureBox.Location = new System.Drawing.Point(-380, 333);
            this.dividerPictureBox.Name = "dividerPictureBox";
            this.dividerPictureBox.Size = new System.Drawing.Size(1045, 50);
            this.dividerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dividerPictureBox.TabIndex = 6;
            this.dividerPictureBox.TabStop = false;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Sitka Banner", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.totalLabel.Location = new System.Drawing.Point(49, 285);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(88, 25);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Sitka Banner", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.taxLabel.Location = new System.Drawing.Point(49, 260);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(89, 25);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Sitka Banner", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.subtotalLabel.Location = new System.Drawing.Point(49, 235);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(88, 25);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            
            // 
            // horrorBookInput
            // 
            this.horrorBookInput.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horrorBookInput.Location = new System.Drawing.Point(244, 109);
            this.horrorBookInput.Name = "horrorBookInput";
            this.horrorBookInput.Size = new System.Drawing.Size(32, 28);
            this.horrorBookInput.TabIndex = 6;
            // 
            // romanceBookInput
            // 
            this.romanceBookInput.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanceBookInput.Location = new System.Drawing.Point(244, 68);
            this.romanceBookInput.Name = "romanceBookInput";
            this.romanceBookInput.Size = new System.Drawing.Size(32, 28);
            this.romanceBookInput.TabIndex = 5;
            // 
            // fantasyBookInput
            // 
            this.fantasyBookInput.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantasyBookInput.Location = new System.Drawing.Point(244, 25);
            this.fantasyBookInput.Name = "fantasyBookInput";
            this.fantasyBookInput.Size = new System.Drawing.Size(32, 28);
            this.fantasyBookInput.TabIndex = 4;
            // 
            // fantasyBookLabel
            // 
            this.fantasyBookLabel.BackColor = System.Drawing.Color.Transparent;
            this.fantasyBookLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantasyBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.fantasyBookLabel.Location = new System.Drawing.Point(4, 28);
            this.fantasyBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fantasyBookLabel.Name = "fantasyBookLabel";
            this.fantasyBookLabel.Size = new System.Drawing.Size(242, 25);
            this.fantasyBookLabel.TabIndex = 3;
            this.fantasyBookLabel.Text = "Number Of Fantasy Books";
            // 
            // horrorBookLabel
            // 
            this.horrorBookLabel.BackColor = System.Drawing.Color.Transparent;
            this.horrorBookLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horrorBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.horrorBookLabel.Location = new System.Drawing.Point(4, 112);
            this.horrorBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horrorBookLabel.Name = "horrorBookLabel";
            this.horrorBookLabel.Size = new System.Drawing.Size(226, 25);
            this.horrorBookLabel.TabIndex = 1;
            this.horrorBookLabel.Text = "Number Of Horror Books";
            this.horrorBookLabel.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // romanceBookLabel
            // 
            this.romanceBookLabel.BackColor = System.Drawing.Color.Transparent;
            this.romanceBookLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanceBookLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.romanceBookLabel.Location = new System.Drawing.Point(4, 71);
            this.romanceBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.romanceBookLabel.Name = "romanceBookLabel";
            this.romanceBookLabel.Size = new System.Drawing.Size(242, 25);
            this.romanceBookLabel.TabIndex = 2;
            this.romanceBookLabel.Text = "Number Of Romance Books";
            // 
            // receiptOutputLabel
            // 
            this.receiptOutputLabel.AutoEllipsis = true;
            this.receiptOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            this.receiptOutputLabel.Image = ((System.Drawing.Image)(resources.GetObject("receiptOutputLabel.Image")));
            this.receiptOutputLabel.Location = new System.Drawing.Point(544, 106);
            this.receiptOutputLabel.Name = "receiptOutputLabel";
            this.receiptOutputLabel.Size = new System.Drawing.Size(278, 546);
            this.receiptOutputLabel.TabIndex = 6;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
            this.newOrderButton.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.newOrderButton.Location = new System.Drawing.Point(536, 669);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(286, 52);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // closeShopButton
            // 
            this.closeShopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(201)))));
            this.closeShopButton.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeShopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.closeShopButton.Location = new System.Drawing.Point(837, 106);
            this.closeShopButton.Name = "closeShopButton";
            this.closeShopButton.Size = new System.Drawing.Size(180, 50);
            this.closeShopButton.TabIndex = 22;
            this.closeShopButton.Text = "Close Shop";
            this.closeShopButton.UseVisualStyleBackColor = false;
            this.closeShopButton.Click += new System.EventHandler(this.closeShopButton_Click);
            // 
            // BackgroundImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 810);
            this.Controls.Add(this.closeShopButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptOutputLabel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackgroundImage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture1)).EndInit();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dividerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label horrorBookLabel;
        private System.Windows.Forms.TextBox horrorBookInput;
        private System.Windows.Forms.TextBox romanceBookInput;
        private System.Windows.Forms.TextBox fantasyBookInput;
        private System.Windows.Forms.Label fantasyBookLabel;
        private System.Windows.Forms.Label romanceBookLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.PictureBox dividerPictureBox;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.PictureBox titlePicture1;
        private System.Windows.Forms.Label receiptOutputLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button closeShopButton;
    }
}

