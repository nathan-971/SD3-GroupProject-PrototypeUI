namespace CRUD_Forms_Prototype
{
    partial class form_TableInput
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label_Comment = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(202, 59);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 59);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(12, 9);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(96, 13);
            this.label_Comment.TabIndex = 3;
            this.label_Comment.Text = "Enter Table Name:";
            // 
            // cb_Tables
            // 
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Location = new System.Drawing.Point(15, 32);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(262, 21);
            this.cb_Tables.TabIndex = 4;
            // 
            // form_TableInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 94);
            this.Controls.Add(this.cb_Tables);
            this.Controls.Add(this.label_Comment);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_TableInput";
            this.Text = "Input Box";
            this.Load += new System.EventHandler(this.form_TableInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.ComboBox cb_Tables;
    }
}