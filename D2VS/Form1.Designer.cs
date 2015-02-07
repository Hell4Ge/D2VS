namespace D2VS
{
    partial class Form1
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
            this.TB_D2Path = new System.Windows.Forms.TextBox();
            this.LB_Path = new System.Windows.Forms.Label();
            this.BTN_SELECT_PATH = new System.Windows.Forms.Button();
            this.LB_Version = new System.Windows.Forms.Label();
            this.CB_Patch = new System.Windows.Forms.ComboBox();
            this.DiabloPathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.BTN_Gate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PB_Download = new System.Windows.Forms.ProgressBar();
            this.BTN_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_D2Path
            // 
            this.TB_D2Path.Location = new System.Drawing.Point(82, 2);
            this.TB_D2Path.Name = "TB_D2Path";
            this.TB_D2Path.Size = new System.Drawing.Size(291, 20);
            this.TB_D2Path.TabIndex = 1;
            // 
            // LB_Path
            // 
            this.LB_Path.AutoSize = true;
            this.LB_Path.Location = new System.Drawing.Point(12, 9);
            this.LB_Path.Name = "LB_Path";
            this.LB_Path.Size = new System.Drawing.Size(64, 13);
            this.LB_Path.TabIndex = 2;
            this.LB_Path.Text = "Diablo path:";
            // 
            // BTN_SELECT_PATH
            // 
            this.BTN_SELECT_PATH.Location = new System.Drawing.Point(13, 26);
            this.BTN_SELECT_PATH.Name = "BTN_SELECT_PATH";
            this.BTN_SELECT_PATH.Size = new System.Drawing.Size(360, 23);
            this.BTN_SELECT_PATH.TabIndex = 3;
            this.BTN_SELECT_PATH.Text = "Wybierz ścieżke do folderu Diablo II";
            this.BTN_SELECT_PATH.UseVisualStyleBackColor = true;
            this.BTN_SELECT_PATH.Click += new System.EventHandler(this.BTN_SELECT_PATH_Click);
            // 
            // LB_Version
            // 
            this.LB_Version.AutoSize = true;
            this.LB_Version.Location = new System.Drawing.Point(10, 64);
            this.LB_Version.Name = "LB_Version";
            this.LB_Version.Size = new System.Drawing.Size(43, 13);
            this.LB_Version.TabIndex = 4;
            this.LB_Version.Text = "Wersja:";
            // 
            // CB_Patch
            // 
            this.CB_Patch.FormattingEnabled = true;
            this.CB_Patch.Items.AddRange(new object[] {
            "1.07",
            "1.08",
            "1.09",
            "1.10",
            "1.11b",
            "1.12a",
            "1.13c",
            "1.13d"});
            this.CB_Patch.Location = new System.Drawing.Point(59, 61);
            this.CB_Patch.Name = "CB_Patch";
            this.CB_Patch.Size = new System.Drawing.Size(63, 21);
            this.CB_Patch.TabIndex = 5;
            // 
            // BTN_Gate
            // 
            this.BTN_Gate.Location = new System.Drawing.Point(298, 67);
            this.BTN_Gate.Name = "BTN_Gate";
            this.BTN_Gate.Size = new System.Drawing.Size(75, 85);
            this.BTN_Gate.TabIndex = 6;
            this.BTN_Gate.Text = "Edytor bramek";
            this.BTN_Gate.UseVisualStyleBackColor = true;
            this.BTN_Gate.Click += new System.EventHandler(this.BTN_Gate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "*Pobierz i zainstaluj pliki wersji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PB_Download
            // 
            this.PB_Download.Location = new System.Drawing.Point(15, 115);
            this.PB_Download.Name = "PB_Download";
            this.PB_Download.Size = new System.Drawing.Size(277, 36);
            this.PB_Download.Step = 1;
            this.PB_Download.TabIndex = 8;
            // 
            // BTN_Run
            // 
            this.BTN_Run.Location = new System.Drawing.Point(13, 158);
            this.BTN_Run.Name = "BTN_Run";
            this.BTN_Run.Size = new System.Drawing.Size(360, 38);
            this.BTN_Run.TabIndex = 9;
            this.BTN_Run.Text = "Uruchom";
            this.BTN_Run.UseVisualStyleBackColor = true;
            this.BTN_Run.Click += new System.EventHandler(this.BTN_Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(128, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "<- Opcjonalnie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Run);
            this.Controls.Add(this.PB_Download);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Gate);
            this.Controls.Add(this.CB_Patch);
            this.Controls.Add(this.LB_Version);
            this.Controls.Add(this.BTN_SELECT_PATH);
            this.Controls.Add(this.LB_Path);
            this.Controls.Add(this.TB_D2Path);
            this.Name = "Form1";
            this.Text = "Diablo II Cooltool by InFlames for D2Trade.pl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_D2Path;
        private System.Windows.Forms.Label LB_Path;
        private System.Windows.Forms.Button BTN_SELECT_PATH;
        private System.Windows.Forms.Label LB_Version;
        private System.Windows.Forms.ComboBox CB_Patch;
        private System.Windows.Forms.FolderBrowserDialog DiabloPathBrowser;
        private System.Windows.Forms.Button BTN_Gate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar PB_Download;
        private System.Windows.Forms.Button BTN_Run;
        private System.Windows.Forms.Label label1;
    }
}

