namespace GodChat
{
    partial class GetNickName
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
            this.btnSuchNickName = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuchNickName
            // 
            this.btnSuchNickName.Location = new System.Drawing.Point(252, 33);
            this.btnSuchNickName.Name = "btnSuchNickName";
            this.btnSuchNickName.Size = new System.Drawing.Size(62, 26);
            this.btnSuchNickName.TabIndex = 0;
            this.btnSuchNickName.Text = "OK!";
            this.btnSuchNickName.UseVisualStyleBackColor = true;
            this.btnSuchNickName.Click += new System.EventHandler(this.btnSuchNickName_Click);
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(27, 37);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(205, 20);
            this.txtNickName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NickName Show Chat";
            // 
            // GetNickName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 77);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.btnSuchNickName);
            this.Name = "GetNickName";
            this.Text = "GetNickName";
            this.Load += new System.EventHandler(this.GetNickName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuchNickName;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label1;
    }
}