namespace GluttonousSnake
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Plane = new System.Windows.Forms.PictureBox();
            this.Progress = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Acc = new System.Windows.Forms.Button();
            this.Dcc = new System.Windows.Forms.Button();
            this.PreyNumber = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(361, 333);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(153, 52);
            this.Start.TabIndex = 0;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Salmon;
            this.Exit.Location = new System.Drawing.Point(361, 410);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(153, 52);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Back.Location = new System.Drawing.Point(636, 32);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(153, 52);
            this.Back.TabIndex = 3;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Plane
            // 
            this.Plane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Plane.Location = new System.Drawing.Point(63, 32);
            this.Plane.Name = "Plane";
            this.Plane.Size = new System.Drawing.Size(550, 450);
            this.Plane.TabIndex = 4;
            this.Plane.TabStop = false;
            this.Plane.Visible = false;
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.Orange;
            this.Progress.Location = new System.Drawing.Point(636, 176);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(153, 52);
            this.Progress.TabIndex = 5;
            this.Progress.Text = "STOP";
            this.Progress.UseVisualStyleBackColor = false;
            this.Progress.Visible = false;
            this.Progress.Click += new System.EventHandler(this.Progress_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Restart.Location = new System.Drawing.Point(636, 101);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(153, 52);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "RESTART";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title.Location = new System.Drawing.Point(140, 171);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(601, 46);
            this.Title.TabIndex = 7;
            this.Title.Text = "Welcome to Gluttonous Snake !!!";
            // 
            // Acc
            // 
            this.Acc.BackColor = System.Drawing.Color.Tomato;
            this.Acc.Location = new System.Drawing.Point(636, 256);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(153, 38);
            this.Acc.TabIndex = 8;
            this.Acc.Text = "Accelerate";
            this.Acc.UseVisualStyleBackColor = false;
            this.Acc.Visible = false;
            this.Acc.Click += new System.EventHandler(this.Acc_Click);
            // 
            // Dcc
            // 
            this.Dcc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Dcc.Location = new System.Drawing.Point(636, 309);
            this.Dcc.Name = "Dcc";
            this.Dcc.Size = new System.Drawing.Size(153, 38);
            this.Dcc.TabIndex = 9;
            this.Dcc.Text = "Decelerate";
            this.Dcc.UseVisualStyleBackColor = false;
            this.Dcc.Visible = false;
            this.Dcc.Click += new System.EventHandler(this.Dcc_Click);
            // 
            // PreyNumber
            // 
            this.PreyNumber.FormattingEnabled = true;
            this.PreyNumber.ItemHeight = 20;
            this.PreyNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PreyNumber.Location = new System.Drawing.Point(636, 378);
            this.PreyNumber.Name = "PreyNumber";
            this.PreyNumber.Size = new System.Drawing.Size(153, 104);
            this.PreyNumber.TabIndex = 10;
            this.PreyNumber.Visible = false;
            this.PreyNumber.SelectedIndexChanged += new System.EventHandler(this.PreyNumber_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(635, 356);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(107, 20);
            this.select.TabIndex = 11;
            this.select.Text = "选择猎物数量：";
            this.select.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(853, 518);
            this.Controls.Add(this.select);
            this.Controls.Add(this.PreyNumber);
            this.Controls.Add(this.Dcc);
            this.Controls.Add(this.Acc);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Plane);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Gluttonous Snake";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox Plane;
        private System.Windows.Forms.Button Progress;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Acc;
        private System.Windows.Forms.Button Dcc;
        private System.Windows.Forms.ListBox PreyNumber;
        private System.Windows.Forms.Label select;
    }
}

