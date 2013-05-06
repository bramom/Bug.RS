namespace AsyncWinForms
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
            this.btnAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAsyncTask = new System.Windows.Forms.Button();
            this.chkRaiseException = new System.Windows.Forms.CheckBox();
            this.btnAsyncTaskEx = new System.Windows.Forms.Button();
            this.btnAsyncAwait = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(90, 41);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(75, 23);
            this.btnAsync.TabIndex = 0;
            this.btnAsync.Text = "Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnASync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(9, 12);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Label";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAsyncTask
            // 
            this.btnAsyncTask.Location = new System.Drawing.Point(90, 12);
            this.btnAsyncTask.Name = "btnAsyncTask";
            this.btnAsyncTask.Size = new System.Drawing.Size(75, 23);
            this.btnAsyncTask.TabIndex = 4;
            this.btnAsyncTask.Text = "Task";
            this.btnAsyncTask.UseVisualStyleBackColor = true;
            this.btnAsyncTask.Click += new System.EventHandler(this.btnAsyncTask_Click);
            // 
            // chkRaiseException
            // 
            this.chkRaiseException.AutoSize = true;
            this.chkRaiseException.Location = new System.Drawing.Point(9, 70);
            this.chkRaiseException.Name = "chkRaiseException";
            this.chkRaiseException.Size = new System.Drawing.Size(103, 17);
            this.chkRaiseException.TabIndex = 5;
            this.chkRaiseException.Text = "Raise Exception";
            this.chkRaiseException.UseVisualStyleBackColor = true;
            // 
            // btnAsyncTaskEx
            // 
            this.btnAsyncTaskEx.Location = new System.Drawing.Point(171, 12);
            this.btnAsyncTaskEx.Name = "btnAsyncTaskEx";
            this.btnAsyncTaskEx.Size = new System.Drawing.Size(77, 23);
            this.btnAsyncTaskEx.TabIndex = 6;
            this.btnAsyncTaskEx.Text = "Task Ex";
            this.btnAsyncTaskEx.UseVisualStyleBackColor = true;
            this.btnAsyncTaskEx.Click += new System.EventHandler(this.btnAsyncTaskEx_Click);
            // 
            // btnAsyncAwait
            // 
            this.btnAsyncAwait.Location = new System.Drawing.Point(171, 41);
            this.btnAsyncAwait.Name = "btnAsyncAwait";
            this.btnAsyncAwait.Size = new System.Drawing.Size(75, 23);
            this.btnAsyncAwait.TabIndex = 7;
            this.btnAsyncAwait.Text = "Async Await";
            this.btnAsyncAwait.UseVisualStyleBackColor = true;
            this.btnAsyncAwait.Click += new System.EventHandler(this.btnAsyncAwait_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(299, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bug.Rs";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 351);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAsyncAwait);
            this.Controls.Add(this.btnAsyncTaskEx);
            this.Controls.Add(this.chkRaiseException);
            this.Controls.Add(this.btnAsyncTask);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsync);
            this.Name = "Form1";
            this.Text = "AsyncDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAsyncTask;
        private System.Windows.Forms.CheckBox chkRaiseException;
        private System.Windows.Forms.Button btnAsyncTaskEx;
        private System.Windows.Forms.Button btnAsyncAwait;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

