namespace ServerGotChat
{
    partial class ServerGotChat
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
            this.grdShow = new System.Windows.Forms.DataGridView();
            this.ipClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIpserver = new System.Windows.Forms.TextBox();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).BeginInit();
            this.SuspendLayout();
            // 
            // grdShow
            // 
            this.grdShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipClient,
            this.NameClient});
            this.grdShow.Location = new System.Drawing.Point(252, 44);
            this.grdShow.Name = "grdShow";
            this.grdShow.ReadOnly = true;
            this.grdShow.Size = new System.Drawing.Size(240, 422);
            this.grdShow.TabIndex = 0;
            // 
            // ipClient
            // 
            this.ipClient.HeaderText = "IP Client";
            this.ipClient.Name = "ipClient";
            this.ipClient.ReadOnly = true;
            // 
            // NameClient
            // 
            this.NameClient.HeaderText = "NameClient";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            // 
            // txtIpserver
            // 
            this.txtIpserver.Location = new System.Drawing.Point(12, 12);
            this.txtIpserver.Name = "txtIpserver";
            this.txtIpserver.ReadOnly = true;
            this.txtIpserver.Size = new System.Drawing.Size(240, 20);
            this.txtIpserver.TabIndex = 2;
            // 
            // txtDialog
            // 
            this.txtDialog.Location = new System.Drawing.Point(6, 44);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.ReadOnly = true;
            this.txtDialog.Size = new System.Drawing.Size(240, 422);
            this.txtDialog.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ServerGotChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.txtIpserver);
            this.Controls.Add(this.grdShow);
            this.Name = "ServerGotChat";
            this.Text = "Server GodChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdShow;
        private System.Windows.Forms.TextBox txtIpserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Button button1;
    }
}

