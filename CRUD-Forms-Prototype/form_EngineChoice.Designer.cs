namespace CRUD_Forms_Prototype
{
    partial class form_EngineChoice
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
            this.label_Option = new System.Windows.Forms.Label();
            this.btn_MYSQL = new System.Windows.Forms.Button();
            this.btn_SQLSERVER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Option
            // 
            this.label_Option.AutoSize = true;
            this.label_Option.Location = new System.Drawing.Point(73, 40);
            this.label_Option.Name = "label_Option";
            this.label_Option.Size = new System.Drawing.Size(128, 13);
            this.label_Option.TabIndex = 0;
            this.label_Option.Text = "Choose Database Engine";
            this.label_Option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MYSQL
            // 
            this.btn_MYSQL.Location = new System.Drawing.Point(12, 94);
            this.btn_MYSQL.Name = "btn_MYSQL";
            this.btn_MYSQL.Size = new System.Drawing.Size(121, 62);
            this.btn_MYSQL.TabIndex = 1;
            this.btn_MYSQL.Text = "MySQL";
            this.btn_MYSQL.UseVisualStyleBackColor = true;
            this.btn_MYSQL.Click += new System.EventHandler(this.btn_MYSQL_Click);
            // 
            // btn_SQLSERVER
            // 
            this.btn_SQLSERVER.Location = new System.Drawing.Point(139, 94);
            this.btn_SQLSERVER.Name = "btn_SQLSERVER";
            this.btn_SQLSERVER.Size = new System.Drawing.Size(121, 62);
            this.btn_SQLSERVER.TabIndex = 2;
            this.btn_SQLSERVER.Text = "SQL Server";
            this.btn_SQLSERVER.UseVisualStyleBackColor = true;
            this.btn_SQLSERVER.Click += new System.EventHandler(this.btn_SQLSERVER_Click);
            // 
            // form_EngineChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 168);
            this.Controls.Add(this.btn_SQLSERVER);
            this.Controls.Add(this.btn_MYSQL);
            this.Controls.Add(this.label_Option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_EngineChoice";
            this.Text = "Choose Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Option;
        private System.Windows.Forms.Button btn_MYSQL;
        private System.Windows.Forms.Button btn_SQLSERVER;
    }
}