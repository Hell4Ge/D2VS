namespace D2VS
{
    partial class GateEditor
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
            this.LB_Realm = new System.Windows.Forms.Label();
            this.LB_IP = new System.Windows.Forms.Label();
            this.GB_RealmAdder = new System.Windows.Forms.GroupBox();
            this.BTN_ADD_REALM = new System.Windows.Forms.Button();
            this.LB_SIP = new System.Windows.Forms.Label();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SName = new System.Windows.Forms.TextBox();
            this.LB_Realms = new System.Windows.Forms.ListBox();
            this.ListBox_IP = new System.Windows.Forms.ListBox();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_RemoveAll = new System.Windows.Forms.Button();
            this.BTN_RestoreDefaults = new System.Windows.Forms.Button();
            this.GB_RealmAdder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Realm
            // 
            this.LB_Realm.AutoSize = true;
            this.LB_Realm.Location = new System.Drawing.Point(12, 18);
            this.LB_Realm.Name = "LB_Realm";
            this.LB_Realm.Size = new System.Drawing.Size(37, 13);
            this.LB_Realm.TabIndex = 2;
            this.LB_Realm.Text = "Realm";
            // 
            // LB_IP
            // 
            this.LB_IP.AutoSize = true;
            this.LB_IP.Location = new System.Drawing.Point(140, 18);
            this.LB_IP.Name = "LB_IP";
            this.LB_IP.Size = new System.Drawing.Size(17, 13);
            this.LB_IP.TabIndex = 3;
            this.LB_IP.Text = "IP";
            // 
            // GB_RealmAdder
            // 
            this.GB_RealmAdder.Controls.Add(this.BTN_ADD_REALM);
            this.GB_RealmAdder.Controls.Add(this.LB_SIP);
            this.GB_RealmAdder.Controls.Add(this.TB_IP);
            this.GB_RealmAdder.Controls.Add(this.label1);
            this.GB_RealmAdder.Controls.Add(this.TB_SName);
            this.GB_RealmAdder.Location = new System.Drawing.Point(295, 38);
            this.GB_RealmAdder.Name = "GB_RealmAdder";
            this.GB_RealmAdder.Size = new System.Drawing.Size(250, 176);
            this.GB_RealmAdder.TabIndex = 4;
            this.GB_RealmAdder.TabStop = false;
            this.GB_RealmAdder.Text = "Bramka";
            // 
            // BTN_ADD_REALM
            // 
            this.BTN_ADD_REALM.Location = new System.Drawing.Point(7, 94);
            this.BTN_ADD_REALM.Name = "BTN_ADD_REALM";
            this.BTN_ADD_REALM.Size = new System.Drawing.Size(237, 76);
            this.BTN_ADD_REALM.TabIndex = 4;
            this.BTN_ADD_REALM.Text = "Dodaj";
            this.BTN_ADD_REALM.UseVisualStyleBackColor = true;
            this.BTN_ADD_REALM.Click += new System.EventHandler(this.BTN_ADD_REALM_Click);
            // 
            // LB_SIP
            // 
            this.LB_SIP.AutoSize = true;
            this.LB_SIP.Location = new System.Drawing.Point(25, 66);
            this.LB_SIP.Name = "LB_SIP";
            this.LB_SIP.Size = new System.Drawing.Size(20, 13);
            this.LB_SIP.TabIndex = 3;
            this.LB_SIP.Text = "IP:";
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(51, 59);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(193, 20);
            this.TB_IP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa:";
            // 
            // TB_SName
            // 
            this.TB_SName.Location = new System.Drawing.Point(51, 33);
            this.TB_SName.Name = "TB_SName";
            this.TB_SName.Size = new System.Drawing.Size(193, 20);
            this.TB_SName.TabIndex = 0;
            // 
            // LB_Realms
            // 
            this.LB_Realms.FormattingEnabled = true;
            this.LB_Realms.Location = new System.Drawing.Point(15, 38);
            this.LB_Realms.Name = "LB_Realms";
            this.LB_Realms.Size = new System.Drawing.Size(120, 173);
            this.LB_Realms.TabIndex = 5;
            // 
            // ListBox_IP
            // 
            this.ListBox_IP.FormattingEnabled = true;
            this.ListBox_IP.Location = new System.Drawing.Point(143, 38);
            this.ListBox_IP.Name = "ListBox_IP";
            this.ListBox_IP.Size = new System.Drawing.Size(120, 173);
            this.ListBox_IP.TabIndex = 6;
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.Location = new System.Drawing.Point(15, 218);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(120, 23);
            this.BTN_Remove.TabIndex = 7;
            this.BTN_Remove.Text = "Usuń zaznaczoną";
            this.BTN_Remove.UseVisualStyleBackColor = true;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // BTN_RemoveAll
            // 
            this.BTN_RemoveAll.Location = new System.Drawing.Point(142, 218);
            this.BTN_RemoveAll.Name = "BTN_RemoveAll";
            this.BTN_RemoveAll.Size = new System.Drawing.Size(121, 23);
            this.BTN_RemoveAll.TabIndex = 8;
            this.BTN_RemoveAll.Text = "Usuń wszystkie";
            this.BTN_RemoveAll.UseVisualStyleBackColor = true;
            this.BTN_RemoveAll.Click += new System.EventHandler(this.BTN_RemoveAll_Click);
            // 
            // BTN_RestoreDefaults
            // 
            this.BTN_RestoreDefaults.Location = new System.Drawing.Point(295, 218);
            this.BTN_RestoreDefaults.Name = "BTN_RestoreDefaults";
            this.BTN_RestoreDefaults.Size = new System.Drawing.Size(237, 23);
            this.BTN_RestoreDefaults.TabIndex = 9;
            this.BTN_RestoreDefaults.Text = "Przywróć domyślne bramki";
            this.BTN_RestoreDefaults.UseVisualStyleBackColor = true;
            this.BTN_RestoreDefaults.Click += new System.EventHandler(this.BTN_RestoreDefaults_Click);
            // 
            // GateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 257);
            this.Controls.Add(this.BTN_RestoreDefaults);
            this.Controls.Add(this.BTN_RemoveAll);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.ListBox_IP);
            this.Controls.Add(this.LB_Realms);
            this.Controls.Add(this.GB_RealmAdder);
            this.Controls.Add(this.LB_IP);
            this.Controls.Add(this.LB_Realm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GateEditor";
            this.ShowIcon = false;
            this.Text = "Gateways Editor Simple";
            this.Load += new System.EventHandler(this.GateEditor_Load);
            this.GB_RealmAdder.ResumeLayout(false);
            this.GB_RealmAdder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_Realm;
        private System.Windows.Forms.Label LB_IP;
        private System.Windows.Forms.GroupBox GB_RealmAdder;
        private System.Windows.Forms.Button BTN_ADD_REALM;
        private System.Windows.Forms.Label LB_SIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SName;
        private System.Windows.Forms.ListBox LB_Realms;
        private System.Windows.Forms.ListBox ListBox_IP;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_RemoveAll;
        private System.Windows.Forms.Button BTN_RestoreDefaults;
        protected System.Windows.Forms.TextBox TB_IP;
    }
}