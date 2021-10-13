
namespace SqlViewer
{
    partial class SplitForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TbQuery = new System.Windows.Forms.RichTextBox();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TcOutput = new System.Windows.Forms.TabControl();
            this.TpResult = new System.Windows.Forms.TabPage();
            this.FlpResult = new System.Windows.Forms.FlowLayoutPanel();
            this.TpMessage = new System.Windows.Forms.TabPage();
            this.LbMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TcOutput.SuspendLayout();
            this.TpResult.SuspendLayout();
            this.TpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.BtnExecute);
            this.splitContainer1.Panel1.Controls.Add(this.TbQuery);
            this.splitContainer1.Panel1.Controls.Add(this.CbDatabases);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TcOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1470, 762);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRefresh.Image = global::SqlViewer.Properties.Resources.refresh_22;
            this.BtnRefresh.Location = new System.Drawing.Point(283, 11);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(25, 25);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExecute.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExecute.Location = new System.Drawing.Point(1338, 365);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(120, 37);
            this.BtnExecute.TabIndex = 10;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TbQuery
            // 
            this.TbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbQuery.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbQuery.Location = new System.Drawing.Point(12, 42);
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(1446, 360);
            this.TbQuery.TabIndex = 9;
            this.TbQuery.Text = "";
            // 
            // CbDatabases
            // 
            this.CbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDatabases.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(100, 11);
            this.CbDatabases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(177, 25);
            this.CbDatabases.TabIndex = 8;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Database:";
            // 
            // TcOutput
            // 
            this.TcOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TcOutput.Controls.Add(this.TpResult);
            this.TcOutput.Controls.Add(this.TpMessage);
            this.TcOutput.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcOutput.Location = new System.Drawing.Point(12, 3);
            this.TcOutput.Name = "TcOutput";
            this.TcOutput.SelectedIndex = 0;
            this.TcOutput.Size = new System.Drawing.Size(1446, 327);
            this.TcOutput.TabIndex = 5;
            // 
            // TpResult
            // 
            this.TpResult.Controls.Add(this.FlpResult);
            this.TpResult.Location = new System.Drawing.Point(4, 26);
            this.TpResult.Name = "TpResult";
            this.TpResult.Padding = new System.Windows.Forms.Padding(3);
            this.TpResult.Size = new System.Drawing.Size(1438, 297);
            this.TpResult.TabIndex = 0;
            this.TpResult.Text = "Results";
            this.TpResult.UseVisualStyleBackColor = true;
            // 
            // FlpResult
            // 
            this.FlpResult.AutoScroll = true;
            this.FlpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpResult.Location = new System.Drawing.Point(3, 3);
            this.FlpResult.Name = "FlpResult";
            this.FlpResult.Size = new System.Drawing.Size(1432, 291);
            this.FlpResult.TabIndex = 0;
            // 
            // TpMessage
            // 
            this.TpMessage.Controls.Add(this.LbMessage);
            this.TpMessage.Location = new System.Drawing.Point(4, 26);
            this.TpMessage.Name = "TpMessage";
            this.TpMessage.Padding = new System.Windows.Forms.Padding(3);
            this.TpMessage.Size = new System.Drawing.Size(1438, 297);
            this.TpMessage.TabIndex = 1;
            this.TpMessage.Text = "Messages";
            this.TpMessage.UseVisualStyleBackColor = true;
            // 
            // LbMessage
            // 
            this.LbMessage.AutoSize = true;
            this.LbMessage.Location = new System.Drawing.Point(7, 7);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(101, 19);
            this.LbMessage.TabIndex = 0;
            this.LbMessage.Text = "No messages.";
            // 
            // SplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 762);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SplitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplitForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplitForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TcOutput.ResumeLayout(false);
            this.TpResult.ResumeLayout(false);
            this.TpMessage.ResumeLayout(false);
            this.TpMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.RichTextBox TbQuery;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TcOutput;
        private System.Windows.Forms.TabPage TpResult;
        private System.Windows.Forms.FlowLayoutPanel FlpResult;
        private System.Windows.Forms.TabPage TpMessage;
        private System.Windows.Forms.Label LbMessage;
    }
}