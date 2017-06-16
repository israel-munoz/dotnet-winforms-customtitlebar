namespace CustomTitleBar
{
    partial class myForm
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
            this.titleBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.maximize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Gray;
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Controls.Add(this.buttonsPanel);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(552, 25);
            this.titleBar.TabIndex = 0;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(455, 25);
            this.title.TabIndex = 3;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.maximize);
            this.buttonsPanel.Controls.Add(this.close);
            this.buttonsPanel.Controls.Add(this.minimize);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(455, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(97, 25);
            this.buttonsPanel.TabIndex = 0;
            // 
            // maximize
            // 
            this.maximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maximize.Location = new System.Drawing.Point(25, 0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(27, 25);
            this.maximize.TabIndex = 1;
            this.maximize.Text = "-";
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Location = new System.Drawing.Point(52, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 25);
            this.close.TabIndex = 2;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.minimize.Location = new System.Drawing.Point(0, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 0;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 264);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.Name = "myForm";
            this.titleBar.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label title;
    }
}

