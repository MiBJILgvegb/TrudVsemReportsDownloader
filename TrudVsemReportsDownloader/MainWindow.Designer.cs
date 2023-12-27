namespace TrudVsemReportsDownloader
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.переменныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.флагиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.bDownload = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bParse = new System.Windows.Forms.Button();
            this.lInfo1 = new System.Windows.Forms.Label();
            this.lInfo2 = new System.Windows.Forms.Label();
            this.lInfo3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переменныеToolStripMenuItem,
            this.флагиToolStripMenuItem});
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(79, 20);
            this.tsmiSettings.Text = "Настройки";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // переменныеToolStripMenuItem
            // 
            this.переменныеToolStripMenuItem.Name = "переменныеToolStripMenuItem";
            this.переменныеToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.переменныеToolStripMenuItem.Text = "Переменные";
            // 
            // флагиToolStripMenuItem
            // 
            this.флагиToolStripMenuItem.Name = "флагиToolStripMenuItem";
            this.флагиToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.флагиToolStripMenuItem.Text = "Флаги";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(54, 20);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatus.Location = new System.Drawing.Point(0, 139);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(339, 13);
            this.pbStatus.TabIndex = 1;
            this.pbStatus.Visible = false;
            // 
            // bDownload
            // 
            this.bDownload.Location = new System.Drawing.Point(12, 27);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(75, 23);
            this.bDownload.TabIndex = 2;
            this.bDownload.Text = "Скачать";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(5, 115);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(35, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.Text = "label1";
            this.lStatus.Visible = false;
            // 
            // bParse
            // 
            this.bParse.Enabled = false;
            this.bParse.Location = new System.Drawing.Point(12, 56);
            this.bParse.Name = "bParse";
            this.bParse.Size = new System.Drawing.Size(75, 23);
            this.bParse.TabIndex = 4;
            this.bParse.Text = "Свод";
            this.bParse.UseVisualStyleBackColor = true;
            this.bParse.Click += new System.EventHandler(this.bParse_Click);
            // 
            // lInfo1
            // 
            this.lInfo1.AutoSize = true;
            this.lInfo1.Location = new System.Drawing.Point(109, 32);
            this.lInfo1.Name = "lInfo1";
            this.lInfo1.Size = new System.Drawing.Size(35, 13);
            this.lInfo1.TabIndex = 5;
            this.lInfo1.Text = "label1";
            this.lInfo1.Visible = false;
            // 
            // lInfo2
            // 
            this.lInfo2.AutoSize = true;
            this.lInfo2.Location = new System.Drawing.Point(109, 61);
            this.lInfo2.Name = "lInfo2";
            this.lInfo2.Size = new System.Drawing.Size(35, 13);
            this.lInfo2.TabIndex = 6;
            this.lInfo2.Text = "label1";
            this.lInfo2.Visible = false;
            // 
            // lInfo3
            // 
            this.lInfo3.AutoSize = true;
            this.lInfo3.Location = new System.Drawing.Point(109, 90);
            this.lInfo3.Name = "lInfo3";
            this.lInfo3.Size = new System.Drawing.Size(35, 13);
            this.lInfo3.TabIndex = 7;
            this.lInfo3.Text = "label1";
            this.lInfo3.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 155);
            this.Controls.Add(this.lInfo3);
            this.Controls.Add(this.lInfo2);
            this.Controls.Add(this.lInfo1);
            this.Controls.Add(this.bParse);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ТрудВсем";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bParse;
        private System.Windows.Forms.Label lInfo1;
        private System.Windows.Forms.Label lInfo2;
        private System.Windows.Forms.Label lInfo3;
        private System.Windows.Forms.ToolStripMenuItem переменныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem флагиToolStripMenuItem;
    }
}

