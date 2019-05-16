namespace VisioNeo4jVsto
{
    partial class FrmMain
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
            this._lblTitle = new System.Windows.Forms.Label();
            this._txtCypher = new System.Windows.Forms.TextBox();
            this._btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(12, 9);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(113, 17);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Export to Cypher";
            // 
            // _txtCypher
            // 
            this._txtCypher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtCypher.Location = new System.Drawing.Point(15, 29);
            this._txtCypher.Multiline = true;
            this._txtCypher.Name = "_txtCypher";
            this._txtCypher.Size = new System.Drawing.Size(835, 315);
            this._txtCypher.TabIndex = 1;
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(752, 350);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(98, 36);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "&OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 398);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._txtCypher);
            this.Controls.Add(this._lblTitle);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.TextBox _txtCypher;
        private System.Windows.Forms.Button _btnOK;
    }
}