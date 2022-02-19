namespace TournamentUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orLable = new System.Windows.Forms.Label();
            this.prizePercentageValueTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLable = new System.Windows.Forms.Label();
            this.prizeAmountValueTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountLable = new System.Windows.Forms.Label();
            this.placeNameValueTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLable = new System.Windows.Forms.Label();
            this.placeNumberValueTextBox = new System.Windows.Forms.TextBox();
            this.placeNumberLable = new System.Windows.Forms.Label();
            this.setPrizesLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.AutoSize = true;
            this.createPrizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createPrizeButton.FlatAppearance.BorderSize = 0;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.Location = new System.Drawing.Point(837, 582);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(202, 67);
            this.createPrizeButton.TabIndex = 40;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.BackColor = System.Drawing.Color.Transparent;
            this.orLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.White;
            this.orLable.Location = new System.Drawing.Point(316, 505);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(70, 38);
            this.orLable.TabIndex = 39;
            this.orLable.Text = "-Or-";
            // 
            // prizePercentageValueTextBox
            // 
            this.prizePercentageValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageValueTextBox.Location = new System.Drawing.Point(323, 570);
            this.prizePercentageValueTextBox.Name = "prizePercentageValueTextBox";
            this.prizePercentageValueTextBox.Size = new System.Drawing.Size(268, 43);
            this.prizePercentageValueTextBox.TabIndex = 38;
            this.prizePercentageValueTextBox.Text = "0";
            this.prizePercentageValueTextBox.TextChanged += new System.EventHandler(this.prizePercentageValueTextBox_TextChanged);
            // 
            // prizePercentageLable
            // 
            this.prizePercentageLable.AutoSize = true;
            this.prizePercentageLable.BackColor = System.Drawing.Color.Transparent;
            this.prizePercentageLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLable.ForeColor = System.Drawing.Color.White;
            this.prizePercentageLable.Location = new System.Drawing.Point(24, 567);
            this.prizePercentageLable.Name = "prizePercentageLable";
            this.prizePercentageLable.Size = new System.Drawing.Size(265, 45);
            this.prizePercentageLable.TabIndex = 37;
            this.prizePercentageLable.Text = "Price Percentage:";
            // 
            // prizeAmountValueTextBox
            // 
            this.prizeAmountValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountValueTextBox.Location = new System.Drawing.Point(323, 433);
            this.prizeAmountValueTextBox.Name = "prizeAmountValueTextBox";
            this.prizeAmountValueTextBox.Size = new System.Drawing.Size(268, 43);
            this.prizeAmountValueTextBox.TabIndex = 36;
            this.prizeAmountValueTextBox.Text = "0";
            this.prizeAmountValueTextBox.TextChanged += new System.EventHandler(this.prizeAmountValueTextBox_TextChanged);
            // 
            // prizeAmountLable
            // 
            this.prizeAmountLable.AutoSize = true;
            this.prizeAmountLable.BackColor = System.Drawing.Color.Transparent;
            this.prizeAmountLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLable.ForeColor = System.Drawing.Color.White;
            this.prizeAmountLable.Location = new System.Drawing.Point(24, 430);
            this.prizeAmountLable.Name = "prizeAmountLable";
            this.prizeAmountLable.Size = new System.Drawing.Size(222, 45);
            this.prizeAmountLable.TabIndex = 35;
            this.prizeAmountLable.Text = "Prize Amount:";
            // 
            // placeNameValueTextBox
            // 
            this.placeNameValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameValueTextBox.Location = new System.Drawing.Point(323, 344);
            this.placeNameValueTextBox.Name = "placeNameValueTextBox";
            this.placeNameValueTextBox.Size = new System.Drawing.Size(268, 43);
            this.placeNameValueTextBox.TabIndex = 34;
            // 
            // placeNameLable
            // 
            this.placeNameLable.AutoSize = true;
            this.placeNameLable.BackColor = System.Drawing.Color.Transparent;
            this.placeNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLable.ForeColor = System.Drawing.Color.White;
            this.placeNameLable.Location = new System.Drawing.Point(24, 341);
            this.placeNameLable.Name = "placeNameLable";
            this.placeNameLable.Size = new System.Drawing.Size(198, 45);
            this.placeNameLable.TabIndex = 33;
            this.placeNameLable.Text = "Place Name:";
            // 
            // placeNumberValueTextBox
            // 
            this.placeNumberValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberValueTextBox.Location = new System.Drawing.Point(323, 274);
            this.placeNumberValueTextBox.Name = "placeNumberValueTextBox";
            this.placeNumberValueTextBox.Size = new System.Drawing.Size(268, 43);
            this.placeNumberValueTextBox.TabIndex = 32;
            // 
            // placeNumberLable
            // 
            this.placeNumberLable.AutoSize = true;
            this.placeNumberLable.BackColor = System.Drawing.Color.Transparent;
            this.placeNumberLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLable.ForeColor = System.Drawing.Color.White;
            this.placeNumberLable.Location = new System.Drawing.Point(24, 271);
            this.placeNumberLable.Name = "placeNumberLable";
            this.placeNumberLable.Size = new System.Drawing.Size(230, 45);
            this.placeNumberLable.TabIndex = 31;
            this.placeNumberLable.Text = "Place Number:";
            // 
            // setPrizesLable
            // 
            this.setPrizesLable.AutoSize = true;
            this.setPrizesLable.BackColor = System.Drawing.Color.Transparent;
            this.setPrizesLable.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrizesLable.ForeColor = System.Drawing.Color.White;
            this.setPrizesLable.Location = new System.Drawing.Point(29, 24);
            this.setPrizesLable.Name = "setPrizesLable";
            this.setPrizesLable.Size = new System.Drawing.Size(258, 65);
            this.setPrizesLable.TabIndex = 30;
            this.setPrizesLable.Text = "Set Prizes:";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.prizePercentageValueTextBox);
            this.Controls.Add(this.prizePercentageLable);
            this.Controls.Add(this.prizeAmountValueTextBox);
            this.Controls.Add(this.prizeAmountLable);
            this.Controls.Add(this.placeNameValueTextBox);
            this.Controls.Add(this.placeNameLable);
            this.Controls.Add(this.placeNumberValueTextBox);
            this.Controls.Add(this.placeNumberLable);
            this.Controls.Add(this.setPrizesLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.TextBox prizePercentageValueTextBox;
        private System.Windows.Forms.Label prizePercentageLable;
        private System.Windows.Forms.TextBox prizeAmountValueTextBox;
        private System.Windows.Forms.Label prizeAmountLable;
        private System.Windows.Forms.TextBox placeNameValueTextBox;
        private System.Windows.Forms.Label placeNameLable;
        private System.Windows.Forms.TextBox placeNumberValueTextBox;
        private System.Windows.Forms.Label placeNumberLable;
        private System.Windows.Forms.Label setPrizesLable;
    }
}