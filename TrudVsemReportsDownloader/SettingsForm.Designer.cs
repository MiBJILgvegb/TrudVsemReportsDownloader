namespace TrudVsemReportsDownloader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDownloadFolderPath = new System.Windows.Forms.TextBox();
            this.bExploreDownloadFolder = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bBrowseDownloadFolder = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbDownloadLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultsFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCSVDelimiter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilterField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bBrowseResultsFolder = new System.Windows.Forms.Button();
            this.bExploreResultsFolder = new System.Windows.Forms.Button();
            this.tbResultsFolderPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbINNList = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAppendDate = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Папка для скачивания";
            // 
            // tbDownloadFolderPath
            // 
            this.tbDownloadFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDownloadFolderPath.Location = new System.Drawing.Point(140, 6);
            this.tbDownloadFolderPath.Name = "tbDownloadFolderPath";
            this.tbDownloadFolderPath.Size = new System.Drawing.Size(194, 20);
            this.tbDownloadFolderPath.TabIndex = 1;
            // 
            // bExploreDownloadFolder
            // 
            this.bExploreDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExploreDownloadFolder.Location = new System.Drawing.Point(371, 3);
            this.bExploreDownloadFolder.Name = "bExploreDownloadFolder";
            this.bExploreDownloadFolder.Size = new System.Drawing.Size(25, 25);
            this.bExploreDownloadFolder.TabIndex = 28;
            this.bExploreDownloadFolder.Text = "...";
            this.bExploreDownloadFolder.UseVisualStyleBackColor = true;
            this.bExploreDownloadFolder.Click += new System.EventHandler(this.bExploreDownloadFolder_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(236, 201);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 31;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.Location = new System.Drawing.Point(317, 201);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 30;
            this.bExit.Text = "Закрыть";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bBrowseDownloadFolder
            // 
            this.bBrowseDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseDownloadFolder.Image = ((System.Drawing.Image)(resources.GetObject("bBrowseDownloadFolder.Image")));
            this.bBrowseDownloadFolder.Location = new System.Drawing.Point(340, 3);
            this.bBrowseDownloadFolder.Name = "bBrowseDownloadFolder";
            this.bBrowseDownloadFolder.Size = new System.Drawing.Size(25, 25);
            this.bBrowseDownloadFolder.TabIndex = 29;
            this.bBrowseDownloadFolder.Text = "...";
            this.bBrowseDownloadFolder.UseVisualStyleBackColor = true;
            this.bBrowseDownloadFolder.Click += new System.EventHandler(this.bBrowseDownloadFolder_Click);
            // 
            // tbDownloadLink
            // 
            this.tbDownloadLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDownloadLink.Location = new System.Drawing.Point(140, 32);
            this.tbDownloadLink.Name = "tbDownloadLink";
            this.tbDownloadLink.Size = new System.Drawing.Size(194, 20);
            this.tbDownloadLink.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ссылка для скачивания";
            // 
            // tbResultsFilename
            // 
            this.tbResultsFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultsFilename.Location = new System.Drawing.Point(140, 162);
            this.tbResultsFilename.Name = "tbResultsFilename";
            this.tbResultsFilename.Size = new System.Drawing.Size(194, 20);
            this.tbResultsFilename.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Имя конечного файла";
            // 
            // tbCSVDelimiter
            // 
            this.tbCSVDelimiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCSVDelimiter.Location = new System.Drawing.Point(140, 208);
            this.tbCSVDelimiter.Name = "tbCSVDelimiter";
            this.tbCSVDelimiter.Size = new System.Drawing.Size(22, 20);
            this.tbCSVDelimiter.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Разделитель";
            // 
            // tbFilterField
            // 
            this.tbFilterField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterField.Location = new System.Drawing.Point(140, 58);
            this.tbFilterField.Name = "tbFilterField";
            this.tbFilterField.Size = new System.Drawing.Size(194, 20);
            this.tbFilterField.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Фильтруемое поле";
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterValue.Location = new System.Drawing.Point(140, 84);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(194, 20);
            this.tbFilterValue.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Фильтруемое значение";
            // 
            // bBrowseResultsFolder
            // 
            this.bBrowseResultsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseResultsFolder.Image = ((System.Drawing.Image)(resources.GetObject("bBrowseResultsFolder.Image")));
            this.bBrowseResultsFolder.Location = new System.Drawing.Point(340, 133);
            this.bBrowseResultsFolder.Name = "bBrowseResultsFolder";
            this.bBrowseResultsFolder.Size = new System.Drawing.Size(25, 25);
            this.bBrowseResultsFolder.TabIndex = 45;
            this.bBrowseResultsFolder.Text = "...";
            this.bBrowseResultsFolder.UseVisualStyleBackColor = true;
            this.bBrowseResultsFolder.Click += new System.EventHandler(this.bBrowseResultsFolder_Click);
            // 
            // bExploreResultsFolder
            // 
            this.bExploreResultsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExploreResultsFolder.Location = new System.Drawing.Point(371, 133);
            this.bExploreResultsFolder.Name = "bExploreResultsFolder";
            this.bExploreResultsFolder.Size = new System.Drawing.Size(25, 25);
            this.bExploreResultsFolder.TabIndex = 44;
            this.bExploreResultsFolder.Text = "...";
            this.bExploreResultsFolder.UseVisualStyleBackColor = true;
            this.bExploreResultsFolder.Click += new System.EventHandler(this.bExploreResultsFolder_Click);
            // 
            // tbResultsFolderPath
            // 
            this.tbResultsFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultsFolderPath.Location = new System.Drawing.Point(140, 136);
            this.tbResultsFolderPath.Name = "tbResultsFolderPath";
            this.tbResultsFolderPath.Size = new System.Drawing.Size(194, 20);
            this.tbResultsFolderPath.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Папка для результатов";
            // 
            // tbINNList
            // 
            this.tbINNList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbINNList.Location = new System.Drawing.Point(140, 110);
            this.tbINNList.Name = "tbINNList";
            this.tbINNList.Size = new System.Drawing.Size(194, 20);
            this.tbINNList.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Список ИНН";
            // 
            // cbAppendDate
            // 
            this.cbAppendDate.AutoSize = true;
            this.cbAppendDate.Location = new System.Drawing.Point(140, 188);
            this.cbAppendDate.Name = "cbAppendDate";
            this.cbAppendDate.Size = new System.Drawing.Size(15, 14);
            this.cbAppendDate.TabIndex = 49;
            this.cbAppendDate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Добавить дату в конце";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 236);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAppendDate);
            this.Controls.Add(this.tbINNList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bBrowseResultsFolder);
            this.Controls.Add(this.bExploreResultsFolder);
            this.Controls.Add(this.tbResultsFolderPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFilterField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCSVDelimiter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResultsFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDownloadLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bBrowseDownloadFolder);
            this.Controls.Add(this.bExploreDownloadFolder);
            this.Controls.Add(this.tbDownloadFolderPath);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDownloadFolderPath;
        private System.Windows.Forms.Button bBrowseDownloadFolder;
        private System.Windows.Forms.Button bExploreDownloadFolder;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TextBox tbDownloadLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultsFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCSVDelimiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilterField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bBrowseResultsFolder;
        private System.Windows.Forms.Button bExploreResultsFolder;
        private System.Windows.Forms.TextBox tbResultsFolderPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbINNList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbAppendDate;
        private System.Windows.Forms.Label label9;
    }
}