namespace Cursach
{
    partial class Profile
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.messagesList = new System.Windows.Forms.ListView();
            this.ticketsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardSumLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(50, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(10, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = " ";
            // 
            // messagesList
            // 
            this.messagesList.FullRowSelect = true;
            this.messagesList.GridLines = true;
            this.messagesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.messagesList.Location = new System.Drawing.Point(12, 73);
            this.messagesList.MultiSelect = false;
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(243, 209);
            this.messagesList.TabIndex = 1;
            this.messagesList.UseCompatibleStateImageBehavior = false;
            this.messagesList.View = System.Windows.Forms.View.List;
            this.messagesList.DoubleClick += new System.EventHandler(this.messagesList_DoubleClick);
            // 
            // ticketsList
            // 
            this.ticketsList.Location = new System.Drawing.Point(261, 57);
            this.ticketsList.Name = "ticketsList";
            this.ticketsList.Size = new System.Drawing.Size(243, 225);
            this.ticketsList.TabIndex = 2;
            this.ticketsList.UseCompatibleStateImageBehavior = false;
            this.ticketsList.View = System.Windows.Forms.View.List;
            this.ticketsList.DoubleClick += new System.EventHandler(this.ticketsList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bought tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Messages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "card number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "card sum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "login:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(87, 26);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(10, 13);
            this.cardNumberLabel.TabIndex = 8;
            this.cardNumberLabel.Text = " ";
            // 
            // cardSumLabel
            // 
            this.cardSumLabel.AutoSize = true;
            this.cardSumLabel.Location = new System.Drawing.Point(68, 39);
            this.cardSumLabel.Name = "cardSumLabel";
            this.cardSumLabel.Size = new System.Drawing.Size(10, 13);
            this.cardSumLabel.TabIndex = 9;
            this.cardSumLabel.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Watched",
            "Coming"});
            this.comboBox1.Location = new System.Drawing.Point(352, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ticket expiration:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cardSumLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketsList);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.nameLabel);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListView messagesList;
        private System.Windows.Forms.ListView ticketsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label cardSumLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}