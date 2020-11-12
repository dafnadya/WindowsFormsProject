namespace Cursach
{
    partial class MainMoviesWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moviesView = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaNameLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesView
            // 
            this.moviesView.AllowUserToAddRows = false;
            this.moviesView.AllowUserToDeleteRows = false;
            this.moviesView.AllowUserToResizeColumns = false;
            this.moviesView.AllowUserToResizeRows = false;
            this.moviesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesView.BackgroundColor = System.Drawing.Color.White;
            this.moviesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moviesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.moviesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesView.ColumnHeadersVisible = false;
            this.moviesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Info,
            this.ExtraInfo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moviesView.DefaultCellStyle = dataGridViewCellStyle1;
            this.moviesView.Location = new System.Drawing.Point(1, 33);
            this.moviesView.MultiSelect = false;
            this.moviesView.Name = "moviesView";
            this.moviesView.ReadOnly = true;
            this.moviesView.RowHeadersVisible = false;
            this.moviesView.RowTemplate.Height = 100;
            this.moviesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesView.Size = new System.Drawing.Size(518, 358);
            this.moviesView.TabIndex = 0;
            this.moviesView.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.HeaderText = "Extra info";
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.ReadOnly = true;
            // 
            // cinemaNameLabel
            // 
            this.cinemaNameLabel.AutoSize = true;
            this.cinemaNameLabel.Location = new System.Drawing.Point(12, 9);
            this.cinemaNameLabel.Name = "cinemaNameLabel";
            this.cinemaNameLabel.Size = new System.Drawing.Size(10, 13);
            this.cinemaNameLabel.TabIndex = 1;
            this.cinemaNameLabel.Text = " ";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(431, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(350, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(431, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(350, 4);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(75, 23);
            this.profileButton.TabIndex = 6;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Visible = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(Cursach.Patterns.Movie);
            // 
            // MainMoviesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 388);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.cinemaNameLabel);
            this.Controls.Add(this.moviesView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainMoviesWindow";
            this.Text = "Cinema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMoviesWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView moviesView;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Label cinemaNameLabel;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraInfo;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button profileButton;
    }
}

