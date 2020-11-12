namespace Cursach
{
    partial class HallWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seanceListBox = new System.Windows.Forms.ListBox();
            this.hallView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.takenSeatLabel1 = new System.Windows.Forms.Label();
            this.takenSeatLabel = new System.Windows.Forms.Label();
            this.hallTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketCostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hallView)).BeginInit();
            this.SuspendLayout();
            // 
            // seanceListBox
            // 
            this.seanceListBox.FormattingEnabled = true;
            this.seanceListBox.HorizontalScrollbar = true;
            this.seanceListBox.Location = new System.Drawing.Point(12, 34);
            this.seanceListBox.Name = "seanceListBox";
            this.seanceListBox.Size = new System.Drawing.Size(120, 199);
            this.seanceListBox.TabIndex = 0;
            this.seanceListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // hallView
            // 
            this.hallView.AllowUserToAddRows = false;
            this.hallView.AllowUserToDeleteRows = false;
            this.hallView.AllowUserToResizeColumns = false;
            this.hallView.AllowUserToResizeRows = false;
            this.hallView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hallView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallView.ColumnHeadersVisible = false;
            this.hallView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.hallView.Location = new System.Drawing.Point(152, 34);
            this.hallView.MultiSelect = false;
            this.hallView.Name = "hallView";
            this.hallView.ReadOnly = true;
            this.hallView.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.hallView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hallView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.hallView.Size = new System.Drawing.Size(385, 173);
            this.hallView.TabIndex = 1;
            this.hallView.Visible = false;
            this.hallView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(322, 248);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Visible = false;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Choose seance:";
            // 
            // takenSeatLabel1
            // 
            this.takenSeatLabel1.AutoSize = true;
            this.takenSeatLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.takenSeatLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.takenSeatLabel1.Location = new System.Drawing.Point(151, 218);
            this.takenSeatLabel1.Name = "takenSeatLabel1";
            this.takenSeatLabel1.Size = new System.Drawing.Size(28, 13);
            this.takenSeatLabel1.TabIndex = 4;
            this.takenSeatLabel1.Text = "       ";
            // 
            // takenSeatLabel
            // 
            this.takenSeatLabel.AutoSize = true;
            this.takenSeatLabel.Location = new System.Drawing.Point(185, 218);
            this.takenSeatLabel.Name = "takenSeatLabel";
            this.takenSeatLabel.Size = new System.Drawing.Size(40, 13);
            this.takenSeatLabel.TabIndex = 5;
            this.takenSeatLabel.Text = "- taken";
            // 
            // hallTypeLabel
            // 
            this.hallTypeLabel.AutoSize = true;
            this.hallTypeLabel.Location = new System.Drawing.Point(319, 13);
            this.hallTypeLabel.Name = "hallTypeLabel";
            this.hallTypeLabel.Size = new System.Drawing.Size(10, 13);
            this.hallTypeLabel.TabIndex = 6;
            this.hallTypeLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ticket cost:";
            // 
            // ticketCostLabel
            // 
            this.ticketCostLabel.AutoSize = true;
            this.ticketCostLabel.Location = new System.Drawing.Point(82, 248);
            this.ticketCostLabel.Name = "ticketCostLabel";
            this.ticketCostLabel.Size = new System.Drawing.Size(10, 13);
            this.ticketCostLabel.TabIndex = 8;
            this.ticketCostLabel.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(231, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "- cheap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(314, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "       ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "- ordinary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "- lux";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(404, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "       ";
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(295, 253);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(127, 13);
            this.enterLabel.TabIndex = 15;
            this.enterLabel.Text = "Please enter to buy ticket";
            this.enterLabel.Visible = false;
            // 
            // HallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 283);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hallTypeLabel);
            this.Controls.Add(this.takenSeatLabel);
            this.Controls.Add(this.takenSeatLabel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.hallView);
            this.Controls.Add(this.seanceListBox);
            this.Name = "HallWindow";
            this.Text = "Hall";
            ((System.ComponentModel.ISupportInitialize)(this.hallView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox seanceListBox;
        private System.Windows.Forms.DataGridView hallView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label takenSeatLabel1;
        private System.Windows.Forms.Label takenSeatLabel;
        private System.Windows.Forms.Label hallTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ticketCostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label enterLabel;
    }
}