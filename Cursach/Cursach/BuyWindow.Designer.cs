namespace Cursach
{
    partial class BuyWindow
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
            this.cardButton = new System.Windows.Forms.RadioButton();
            this.cashButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardButton
            // 
            this.cardButton.AutoSize = true;
            this.cardButton.Checked = true;
            this.cardButton.Location = new System.Drawing.Point(29, 63);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(145, 17);
            this.cardButton.TabIndex = 3;
            this.cardButton.TabStop = true;
            this.cardButton.Text = "Pay via Visa/MasterCard:";
            this.cardButton.UseVisualStyleBackColor = true;
            // 
            // cashButton
            // 
            this.cashButton.AutoSize = true;
            this.cashButton.Location = new System.Drawing.Point(30, 86);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(123, 17);
            this.cashButton.TabIndex = 4;
            this.cashButton.Text = "Pay cash in cashbox";
            this.cashButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose payment method:";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(63, 130);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 6;
            this.payButton.Text = "OK";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ticket cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // BuyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 165);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.cardButton);
            this.Name = "BuyWindow";
            this.Text = "Buy Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton cardButton;
        private System.Windows.Forms.RadioButton cashButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}