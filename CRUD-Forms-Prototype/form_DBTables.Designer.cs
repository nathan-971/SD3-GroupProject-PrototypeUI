namespace CRUD_Forms_Prototype
{
    partial class form_DBTables
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.DGV_TableData = new System.Windows.Forms.DataGridView();
            this.btn_ChangeTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TableData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(211, 429);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(292, 429);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(373, 429);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // DGV_TableData
            // 
            this.DGV_TableData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TableData.Location = new System.Drawing.Point(12, 16);
            this.DGV_TableData.Name = "DGV_TableData";
            this.DGV_TableData.Size = new System.Drawing.Size(635, 407);
            this.DGV_TableData.TabIndex = 5;
            // 
            // btn_ChangeTable
            // 
            this.btn_ChangeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ChangeTable.FlatAppearance.BorderSize = 0;
            this.btn_ChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeTable.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeTable.Location = new System.Drawing.Point(538, 429);
            this.btn_ChangeTable.Name = "btn_ChangeTable";
            this.btn_ChangeTable.Size = new System.Drawing.Size(109, 23);
            this.btn_ChangeTable.TabIndex = 6;
            this.btn_ChangeTable.Text = "Change Table";
            this.btn_ChangeTable.UseVisualStyleBackColor = false;
            this.btn_ChangeTable.Click += new System.EventHandler(this.btn_ChangeTable_Click);
            // 
            // form_DBTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 459);
            this.Controls.Add(this.btn_ChangeTable);
            this.Controls.Add(this.DGV_TableData);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Create);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_DBTables";
            this.Text = "CRUD Program";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TableData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView DGV_TableData;
        private System.Windows.Forms.Button btn_ChangeTable;
    }
}

