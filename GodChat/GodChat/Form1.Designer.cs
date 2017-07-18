namespace GodChat
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.txtConnecServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdViewClient = new System.Windows.Forms.DataGridView();
            this.IpClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatusServer = new System.Windows.Forms.Button();
            this.txtIpCom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnerServer = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Location = new System.Drawing.Point(156, 55);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(201, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Message";
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(12, 29);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(345, 20);
            this.txtSend.TabIndex = 2;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // txtDialog
            // 
            this.txtDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDialog.Location = new System.Drawing.Point(12, 93);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.ReadOnly = true;
            this.txtDialog.Size = new System.Drawing.Size(345, 370);
            this.txtDialog.TabIndex = 2;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(12, 63);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(67, 13);
            this.labStatus.TabIndex = 3;
            this.labStatus.Text = "Show Dialog";
            // 
            // txtConnecServer
            // 
            this.txtConnecServer.Location = new System.Drawing.Point(533, 93);
            this.txtConnecServer.Name = "txtConnecServer";
            this.txtConnecServer.Size = new System.Drawing.Size(100, 20);
            this.txtConnecServer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "People Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP Connec Server";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(533, 123);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "8001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // grdViewClient
            // 
            this.grdViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpClient,
            this.name});
            this.grdViewClient.Location = new System.Drawing.Point(390, 242);
            this.grdViewClient.Name = "grdViewClient";
            this.grdViewClient.Size = new System.Drawing.Size(238, 192);
            this.grdViewClient.TabIndex = 8;
            // 
            // IpClient
            // 
            this.IpClient.HeaderText = "IpClinet";
            this.IpClient.Name = "IpClient";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // btnStatusServer
            // 
            this.btnStatusServer.Location = new System.Drawing.Point(390, 164);
            this.btnStatusServer.Name = "btnStatusServer";
            this.btnStatusServer.Size = new System.Drawing.Size(134, 59);
            this.btnStatusServer.TabIndex = 9;
            this.btnStatusServer.Text = "Status Server ME";
            this.btnStatusServer.UseVisualStyleBackColor = true;
            // 
            // txtIpCom
            // 
            this.txtIpCom.Location = new System.Drawing.Point(533, 48);
            this.txtIpCom.Name = "txtIpCom";
            this.txtIpCom.ReadOnly = true;
            this.txtIpCom.Size = new System.Drawing.Size(100, 20);
            this.txtIpCom.TabIndex = 5;
            this.txtIpCom.Text = "IP COM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP Computer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "GodChaT..";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "8001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Port";
            // 
            // btnConnerServer
            // 
            this.btnConnerServer.Location = new System.Drawing.Point(558, 149);
            this.btnConnerServer.Name = "btnConnerServer";
            this.btnConnerServer.Size = new System.Drawing.Size(75, 23);
            this.btnConnerServer.TabIndex = 10;
            this.btnConnerServer.Text = "ConnecServer";
            this.btnConnerServer.UseVisualStyleBackColor = true;
            this.btnConnerServer.Click += new System.EventHandler(this.btnConnerServer_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Salmon;
            this.btnCloseApp.Location = new System.Drawing.Point(533, 450);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(100, 22);
            this.btnCloseApp.TabIndex = 12;
            this.btnCloseApp.Text = "Close";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 475);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnConnerServer);
            this.Controls.Add(this.btnStatusServer);
            this.Controls.Add(this.grdViewClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIpCom);
            this.Controls.Add(this.txtConnecServer);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "GodChat Server - Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.TextBox txtConnecServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdViewClient;
        private System.Windows.Forms.Button btnStatusServer;
        private System.Windows.Forms.TextBox txtIpCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnerServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnCloseApp;
    }
}

