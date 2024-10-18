namespace Prototype_1
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.panel_Nav = new System.Windows.Forms.Panel();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_AddInjury = new System.Windows.Forms.Button();
            this.btn_DisqualifyPlayer = new System.Windows.Forms.Button();
            this.btn_Halftime = new System.Windows.Forms.Button();
            this.btn_Subsitution = new System.Windows.Forms.Button();
            this.btn_ExpandMenu = new System.Windows.Forms.Button();
            this.tableLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Actions = new System.Windows.Forms.Panel();
            this.DGV_Actions = new System.Windows.Forms.DataGridView();
            this.label_Actions = new System.Windows.Forms.Label();
            this.panel_Players = new System.Windows.Forms.Panel();
            this.panel_PlayerButtons = new System.Windows.Forms.Panel();
            this.tableLayout_Players = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Player_1 = new System.Windows.Forms.Button();
            this.btn_Player_2 = new System.Windows.Forms.Button();
            this.btn_Player_3 = new System.Windows.Forms.Button();
            this.btn_Player_4 = new System.Windows.Forms.Button();
            this.btn_Player_5 = new System.Windows.Forms.Button();
            this.btn_Player_6 = new System.Windows.Forms.Button();
            this.btn_Player_7 = new System.Windows.Forms.Button();
            this.btn_Player_9 = new System.Windows.Forms.Button();
            this.btn_Player_10 = new System.Windows.Forms.Button();
            this.btn_Player_13 = new System.Windows.Forms.Button();
            this.btn_Player_11 = new System.Windows.Forms.Button();
            this.btn_Player_14 = new System.Windows.Forms.Button();
            this.btn_Player_12 = new System.Windows.Forms.Button();
            this.btn_Player_15 = new System.Windows.Forms.Button();
            this.btn_Player_8 = new System.Windows.Forms.Button();
            this.label_Players = new System.Windows.Forms.Label();
            this.panel_Pitch = new System.Windows.Forms.Panel();
            this.panel_Grid_Buttons = new System.Windows.Forms.Panel();
            this.tableLayout_Pitch = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Pitch_BOTTOMRIGHT = new System.Windows.Forms.Button();
            this.btn_Pitch_BOTTOMCENTRE = new System.Windows.Forms.Button();
            this.btn_Pitch_BOTTOMLEFT = new System.Windows.Forms.Button();
            this.btn_Pitch_CENTRERIGHT = new System.Windows.Forms.Button();
            this.btn_Pitch_CENTRE = new System.Windows.Forms.Button();
            this.btn_Pitch_CENTRELEFT = new System.Windows.Forms.Button();
            this.btn_Pitch_TOPRIGHT = new System.Windows.Forms.Button();
            this.btn_Pitch_TOPCENTRE = new System.Windows.Forms.Button();
            this.btn_Pitch_TOPLEFT = new System.Windows.Forms.Button();
            this.label_Pitch = new System.Windows.Forms.Label();
            this.panel_Nav.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.tableLayout_Main.SuspendLayout();
            this.panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actions)).BeginInit();
            this.panel_Players.SuspendLayout();
            this.panel_PlayerButtons.SuspendLayout();
            this.tableLayout_Players.SuspendLayout();
            this.panel_Pitch.SuspendLayout();
            this.panel_Grid_Buttons.SuspendLayout();
            this.tableLayout_Pitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Nav
            // 
            this.panel_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.panel_Nav.Controls.Add(this.btn_Maximize);
            this.panel_Nav.Controls.Add(this.btn_Minimize);
            this.panel_Nav.Controls.Add(this.label_Title);
            this.panel_Nav.Controls.Add(this.btn_Exit);
            this.panel_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Nav.Location = new System.Drawing.Point(0, 0);
            this.panel_Nav.Name = "panel_Nav";
            this.panel_Nav.Size = new System.Drawing.Size(1414, 28);
            this.panel_Nav.TabIndex = 0;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.Location = new System.Drawing.Point(1338, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(35, 28);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.Text = "-";
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(1297, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(35, 28);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(3, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(122, 13);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "PLACEHOLDER_TITLE";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(1379, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 28);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.panel_Menu.Controls.Add(this.btn_AddInjury);
            this.panel_Menu.Controls.Add(this.btn_DisqualifyPlayer);
            this.panel_Menu.Controls.Add(this.btn_Halftime);
            this.panel_Menu.Controls.Add(this.btn_Subsitution);
            this.panel_Menu.Location = new System.Drawing.Point(257, 675);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(900, 25);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_AddInjury
            // 
            this.btn_AddInjury.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddInjury.Enabled = false;
            this.btn_AddInjury.Location = new System.Drawing.Point(785, 17);
            this.btn_AddInjury.Name = "btn_AddInjury";
            this.btn_AddInjury.Size = new System.Drawing.Size(75, 71);
            this.btn_AddInjury.TabIndex = 3;
            this.btn_AddInjury.Text = "Add Injury Time";
            this.btn_AddInjury.UseVisualStyleBackColor = true;
            this.btn_AddInjury.Visible = false;
            // 
            // btn_DisqualifyPlayer
            // 
            this.btn_DisqualifyPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisqualifyPlayer.Enabled = false;
            this.btn_DisqualifyPlayer.Location = new System.Drawing.Point(694, 17);
            this.btn_DisqualifyPlayer.Name = "btn_DisqualifyPlayer";
            this.btn_DisqualifyPlayer.Size = new System.Drawing.Size(75, 71);
            this.btn_DisqualifyPlayer.TabIndex = 2;
            this.btn_DisqualifyPlayer.Text = "Disqualify Player";
            this.btn_DisqualifyPlayer.UseVisualStyleBackColor = true;
            this.btn_DisqualifyPlayer.Visible = false;
            // 
            // btn_Halftime
            // 
            this.btn_Halftime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Halftime.Enabled = false;
            this.btn_Halftime.Location = new System.Drawing.Point(121, 17);
            this.btn_Halftime.Name = "btn_Halftime";
            this.btn_Halftime.Size = new System.Drawing.Size(75, 71);
            this.btn_Halftime.TabIndex = 1;
            this.btn_Halftime.Text = "Call Halftime";
            this.btn_Halftime.UseVisualStyleBackColor = true;
            this.btn_Halftime.Visible = false;
            // 
            // btn_Subsitution
            // 
            this.btn_Subsitution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Subsitution.Enabled = false;
            this.btn_Subsitution.Location = new System.Drawing.Point(24, 17);
            this.btn_Subsitution.Name = "btn_Subsitution";
            this.btn_Subsitution.Size = new System.Drawing.Size(75, 71);
            this.btn_Subsitution.TabIndex = 0;
            this.btn_Subsitution.Text = "Substitute Player";
            this.btn_Subsitution.UseVisualStyleBackColor = true;
            this.btn_Subsitution.Visible = false;
            // 
            // btn_ExpandMenu
            // 
            this.btn_ExpandMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ExpandMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btn_ExpandMenu.FlatAppearance.BorderSize = 0;
            this.btn_ExpandMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpandMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExpandMenu.ForeColor = System.Drawing.Color.White;
            this.btn_ExpandMenu.Location = new System.Drawing.Point(687, 635);
            this.btn_ExpandMenu.Name = "btn_ExpandMenu";
            this.btn_ExpandMenu.Size = new System.Drawing.Size(40, 40);
            this.btn_ExpandMenu.TabIndex = 3;
            this.btn_ExpandMenu.Text = "^";
            this.btn_ExpandMenu.UseVisualStyleBackColor = false;
            this.btn_ExpandMenu.Click += new System.EventHandler(this.btn_ExpandMenu_Click);
            // 
            // tableLayout_Main
            // 
            this.tableLayout_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Main.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout_Main.ColumnCount = 3;
            this.tableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Main.Controls.Add(this.panel_Actions, 0, 0);
            this.tableLayout_Main.Controls.Add(this.panel_Players, 1, 0);
            this.tableLayout_Main.Controls.Add(this.panel_Pitch, 2, 0);
            this.tableLayout_Main.Location = new System.Drawing.Point(6, 34);
            this.tableLayout_Main.Name = "tableLayout_Main";
            this.tableLayout_Main.RowCount = 1;
            this.tableLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Main.Size = new System.Drawing.Size(1402, 663);
            this.tableLayout_Main.TabIndex = 6;
            // 
            // panel_Actions
            // 
            this.panel_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(235)))), ((int)(((byte)(188)))));
            this.panel_Actions.Controls.Add(this.DGV_Actions);
            this.panel_Actions.Controls.Add(this.label_Actions);
            this.panel_Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Actions.Location = new System.Drawing.Point(25, 50);
            this.panel_Actions.Margin = new System.Windows.Forms.Padding(25, 50, 25, 50);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(417, 563);
            this.panel_Actions.TabIndex = 1;
            // 
            // DGV_Actions
            // 
            this.DGV_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Actions.BackgroundColor = System.Drawing.Color.Silver;
            this.DGV_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Actions.Location = new System.Drawing.Point(33, 71);
            this.DGV_Actions.Name = "DGV_Actions";
            this.DGV_Actions.Size = new System.Drawing.Size(350, 464);
            this.DGV_Actions.TabIndex = 1;
            // 
            // label_Actions
            // 
            this.label_Actions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Actions.AutoSize = true;
            this.label_Actions.BackColor = System.Drawing.Color.Transparent;
            this.label_Actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Actions.Location = new System.Drawing.Point(169, 29);
            this.label_Actions.Name = "label_Actions";
            this.label_Actions.Size = new System.Drawing.Size(79, 24);
            this.label_Actions.TabIndex = 0;
            this.label_Actions.Text = "Actions";
            // 
            // panel_Players
            // 
            this.panel_Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(235)))), ((int)(((byte)(188)))));
            this.panel_Players.Controls.Add(this.panel_PlayerButtons);
            this.panel_Players.Controls.Add(this.label_Players);
            this.panel_Players.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Players.Location = new System.Drawing.Point(492, 50);
            this.panel_Players.Margin = new System.Windows.Forms.Padding(25, 50, 25, 50);
            this.panel_Players.Name = "panel_Players";
            this.panel_Players.Size = new System.Drawing.Size(417, 563);
            this.panel_Players.TabIndex = 0;
            // 
            // panel_PlayerButtons
            // 
            this.panel_PlayerButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PlayerButtons.BackColor = System.Drawing.Color.Transparent;
            this.panel_PlayerButtons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_PlayerButtons.BackgroundImage")));
            this.panel_PlayerButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_PlayerButtons.Controls.Add(this.tableLayout_Players);
            this.panel_PlayerButtons.Location = new System.Drawing.Point(31, 71);
            this.panel_PlayerButtons.Name = "panel_PlayerButtons";
            this.panel_PlayerButtons.Size = new System.Drawing.Size(350, 464);
            this.panel_PlayerButtons.TabIndex = 2;
            // 
            // tableLayout_Players
            // 
            this.tableLayout_Players.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Players.ColumnCount = 7;
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.Controls.Add(this.btn_Player_1, 3, 0);
            this.tableLayout_Players.Controls.Add(this.btn_Player_2, 1, 1);
            this.tableLayout_Players.Controls.Add(this.btn_Player_3, 3, 1);
            this.tableLayout_Players.Controls.Add(this.btn_Player_4, 5, 1);
            this.tableLayout_Players.Controls.Add(this.btn_Player_5, 1, 2);
            this.tableLayout_Players.Controls.Add(this.btn_Player_6, 3, 2);
            this.tableLayout_Players.Controls.Add(this.btn_Player_7, 5, 2);
            this.tableLayout_Players.Controls.Add(this.btn_Player_9, 4, 3);
            this.tableLayout_Players.Controls.Add(this.btn_Player_10, 1, 4);
            this.tableLayout_Players.Controls.Add(this.btn_Player_13, 1, 5);
            this.tableLayout_Players.Controls.Add(this.btn_Player_11, 3, 4);
            this.tableLayout_Players.Controls.Add(this.btn_Player_14, 3, 5);
            this.tableLayout_Players.Controls.Add(this.btn_Player_12, 5, 4);
            this.tableLayout_Players.Controls.Add(this.btn_Player_15, 5, 5);
            this.tableLayout_Players.Controls.Add(this.btn_Player_8, 2, 3);
            this.tableLayout_Players.Location = new System.Drawing.Point(3, 3);
            this.tableLayout_Players.Name = "tableLayout_Players";
            this.tableLayout_Players.RowCount = 8;
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayout_Players.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Players.Size = new System.Drawing.Size(344, 458);
            this.tableLayout_Players.TabIndex = 0;
            // 
            // btn_Player_1
            // 
            this.btn_Player_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_1.ForeColor = System.Drawing.Color.White;
            this.btn_Player_1.Location = new System.Drawing.Point(150, 3);
            this.btn_Player_1.Name = "btn_Player_1";
            this.btn_Player_1.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_1.TabIndex = 0;
            this.btn_Player_1.Text = "1";
            this.btn_Player_1.UseVisualStyleBackColor = false;
            // 
            // btn_Player_2
            // 
            this.btn_Player_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_2.ForeColor = System.Drawing.Color.White;
            this.btn_Player_2.Location = new System.Drawing.Point(52, 65);
            this.btn_Player_2.Name = "btn_Player_2";
            this.btn_Player_2.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_2.TabIndex = 1;
            this.btn_Player_2.Text = "2";
            this.btn_Player_2.UseVisualStyleBackColor = false;
            // 
            // btn_Player_3
            // 
            this.btn_Player_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_3.ForeColor = System.Drawing.Color.White;
            this.btn_Player_3.Location = new System.Drawing.Point(150, 65);
            this.btn_Player_3.Name = "btn_Player_3";
            this.btn_Player_3.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_3.TabIndex = 2;
            this.btn_Player_3.Text = "3";
            this.btn_Player_3.UseVisualStyleBackColor = false;
            // 
            // btn_Player_4
            // 
            this.btn_Player_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_4.ForeColor = System.Drawing.Color.White;
            this.btn_Player_4.Location = new System.Drawing.Point(248, 65);
            this.btn_Player_4.Name = "btn_Player_4";
            this.btn_Player_4.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_4.TabIndex = 3;
            this.btn_Player_4.Text = "4";
            this.btn_Player_4.UseVisualStyleBackColor = false;
            // 
            // btn_Player_5
            // 
            this.btn_Player_5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_5.ForeColor = System.Drawing.Color.White;
            this.btn_Player_5.Location = new System.Drawing.Point(52, 127);
            this.btn_Player_5.Name = "btn_Player_5";
            this.btn_Player_5.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_5.TabIndex = 4;
            this.btn_Player_5.Text = "5";
            this.btn_Player_5.UseVisualStyleBackColor = false;
            // 
            // btn_Player_6
            // 
            this.btn_Player_6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_6.ForeColor = System.Drawing.Color.White;
            this.btn_Player_6.Location = new System.Drawing.Point(150, 127);
            this.btn_Player_6.Name = "btn_Player_6";
            this.btn_Player_6.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_6.TabIndex = 5;
            this.btn_Player_6.Text = "6";
            this.btn_Player_6.UseVisualStyleBackColor = false;
            // 
            // btn_Player_7
            // 
            this.btn_Player_7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_7.ForeColor = System.Drawing.Color.White;
            this.btn_Player_7.Location = new System.Drawing.Point(248, 127);
            this.btn_Player_7.Name = "btn_Player_7";
            this.btn_Player_7.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_7.TabIndex = 6;
            this.btn_Player_7.Text = "7";
            this.btn_Player_7.UseVisualStyleBackColor = false;
            // 
            // btn_Player_9
            // 
            this.btn_Player_9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_9.ForeColor = System.Drawing.Color.White;
            this.btn_Player_9.Location = new System.Drawing.Point(199, 189);
            this.btn_Player_9.Name = "btn_Player_9";
            this.btn_Player_9.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_9.TabIndex = 8;
            this.btn_Player_9.Text = "9";
            this.btn_Player_9.UseVisualStyleBackColor = false;
            // 
            // btn_Player_10
            // 
            this.btn_Player_10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_10.ForeColor = System.Drawing.Color.White;
            this.btn_Player_10.Location = new System.Drawing.Point(52, 251);
            this.btn_Player_10.Name = "btn_Player_10";
            this.btn_Player_10.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_10.TabIndex = 9;
            this.btn_Player_10.Text = "10";
            this.btn_Player_10.UseVisualStyleBackColor = false;
            // 
            // btn_Player_13
            // 
            this.btn_Player_13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_13.ForeColor = System.Drawing.Color.White;
            this.btn_Player_13.Location = new System.Drawing.Point(52, 313);
            this.btn_Player_13.Name = "btn_Player_13";
            this.btn_Player_13.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_13.TabIndex = 10;
            this.btn_Player_13.Text = "13";
            this.btn_Player_13.UseVisualStyleBackColor = false;
            // 
            // btn_Player_11
            // 
            this.btn_Player_11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_11.ForeColor = System.Drawing.Color.White;
            this.btn_Player_11.Location = new System.Drawing.Point(150, 251);
            this.btn_Player_11.Name = "btn_Player_11";
            this.btn_Player_11.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_11.TabIndex = 11;
            this.btn_Player_11.Text = "11";
            this.btn_Player_11.UseVisualStyleBackColor = false;
            // 
            // btn_Player_14
            // 
            this.btn_Player_14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_14.ForeColor = System.Drawing.Color.White;
            this.btn_Player_14.Location = new System.Drawing.Point(150, 313);
            this.btn_Player_14.Name = "btn_Player_14";
            this.btn_Player_14.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_14.TabIndex = 12;
            this.btn_Player_14.Text = "14";
            this.btn_Player_14.UseVisualStyleBackColor = false;
            // 
            // btn_Player_12
            // 
            this.btn_Player_12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_12.ForeColor = System.Drawing.Color.White;
            this.btn_Player_12.Location = new System.Drawing.Point(248, 251);
            this.btn_Player_12.Name = "btn_Player_12";
            this.btn_Player_12.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_12.TabIndex = 13;
            this.btn_Player_12.Text = "12";
            this.btn_Player_12.UseVisualStyleBackColor = false;
            // 
            // btn_Player_15
            // 
            this.btn_Player_15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_15.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_15.ForeColor = System.Drawing.Color.White;
            this.btn_Player_15.Location = new System.Drawing.Point(248, 313);
            this.btn_Player_15.Name = "btn_Player_15";
            this.btn_Player_15.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_15.TabIndex = 14;
            this.btn_Player_15.Text = "15";
            this.btn_Player_15.UseVisualStyleBackColor = false;
            // 
            // btn_Player_8
            // 
            this.btn_Player_8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player_8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Player_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Player_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Player_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player_8.ForeColor = System.Drawing.Color.White;
            this.btn_Player_8.Location = new System.Drawing.Point(101, 189);
            this.btn_Player_8.Name = "btn_Player_8";
            this.btn_Player_8.Size = new System.Drawing.Size(43, 56);
            this.btn_Player_8.TabIndex = 7;
            this.btn_Player_8.Text = "8";
            this.btn_Player_8.UseVisualStyleBackColor = false;
            // 
            // label_Players
            // 
            this.label_Players.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Players.AutoSize = true;
            this.label_Players.BackColor = System.Drawing.Color.Transparent;
            this.label_Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Players.Location = new System.Drawing.Point(169, 29);
            this.label_Players.Name = "label_Players";
            this.label_Players.Size = new System.Drawing.Size(78, 24);
            this.label_Players.TabIndex = 1;
            this.label_Players.Text = "Players";
            // 
            // panel_Pitch
            // 
            this.panel_Pitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(235)))), ((int)(((byte)(188)))));
            this.panel_Pitch.Controls.Add(this.panel_Grid_Buttons);
            this.panel_Pitch.Controls.Add(this.label_Pitch);
            this.panel_Pitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Pitch.Location = new System.Drawing.Point(959, 50);
            this.panel_Pitch.Margin = new System.Windows.Forms.Padding(25, 50, 25, 50);
            this.panel_Pitch.Name = "panel_Pitch";
            this.panel_Pitch.Size = new System.Drawing.Size(418, 563);
            this.panel_Pitch.TabIndex = 1;
            // 
            // panel_Grid_Buttons
            // 
            this.panel_Grid_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Grid_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.panel_Grid_Buttons.Controls.Add(this.tableLayout_Pitch);
            this.panel_Grid_Buttons.Location = new System.Drawing.Point(31, 71);
            this.panel_Grid_Buttons.Name = "panel_Grid_Buttons";
            this.panel_Grid_Buttons.Size = new System.Drawing.Size(350, 464);
            this.panel_Grid_Buttons.TabIndex = 3;
            // 
            // tableLayout_Pitch
            // 
            this.tableLayout_Pitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Pitch.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout_Pitch.ColumnCount = 3;
            this.tableLayout_Pitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Pitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayout_Pitch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_BOTTOMRIGHT, 2, 2);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_BOTTOMCENTRE, 1, 2);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_BOTTOMLEFT, 0, 2);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_CENTRERIGHT, 2, 1);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_CENTRE, 1, 1);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_CENTRELEFT, 0, 1);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_TOPRIGHT, 2, 0);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_TOPCENTRE, 1, 0);
            this.tableLayout_Pitch.Controls.Add(this.btn_Pitch_TOPLEFT, 0, 0);
            this.tableLayout_Pitch.Location = new System.Drawing.Point(3, 3);
            this.tableLayout_Pitch.Name = "tableLayout_Pitch";
            this.tableLayout_Pitch.RowCount = 3;
            this.tableLayout_Pitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Pitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Pitch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout_Pitch.Size = new System.Drawing.Size(344, 458);
            this.tableLayout_Pitch.TabIndex = 0;
            // 
            // btn_Pitch_BOTTOMRIGHT
            // 
            this.btn_Pitch_BOTTOMRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_BOTTOMRIGHT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_BOTTOMRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_BOTTOMRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_BOTTOMRIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_BOTTOMRIGHT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_BOTTOMRIGHT.Location = new System.Drawing.Point(238, 334);
            this.btn_Pitch_BOTTOMRIGHT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_BOTTOMRIGHT.Name = "btn_Pitch_BOTTOMRIGHT";
            this.btn_Pitch_BOTTOMRIGHT.Size = new System.Drawing.Size(96, 94);
            this.btn_Pitch_BOTTOMRIGHT.TabIndex = 8;
            this.btn_Pitch_BOTTOMRIGHT.Text = "BOTTOM RIGHT";
            this.btn_Pitch_BOTTOMRIGHT.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_BOTTOMCENTRE
            // 
            this.btn_Pitch_BOTTOMCENTRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_BOTTOMCENTRE.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_BOTTOMCENTRE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_BOTTOMCENTRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_BOTTOMCENTRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_BOTTOMCENTRE.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_BOTTOMCENTRE.Location = new System.Drawing.Point(124, 334);
            this.btn_Pitch_BOTTOMCENTRE.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_BOTTOMCENTRE.Name = "btn_Pitch_BOTTOMCENTRE";
            this.btn_Pitch_BOTTOMCENTRE.Size = new System.Drawing.Size(94, 94);
            this.btn_Pitch_BOTTOMCENTRE.TabIndex = 7;
            this.btn_Pitch_BOTTOMCENTRE.Text = "BOTTOM CENTRE";
            this.btn_Pitch_BOTTOMCENTRE.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_BOTTOMLEFT
            // 
            this.btn_Pitch_BOTTOMLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_BOTTOMLEFT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_BOTTOMLEFT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_BOTTOMLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_BOTTOMLEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_BOTTOMLEFT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_BOTTOMLEFT.Location = new System.Drawing.Point(10, 334);
            this.btn_Pitch_BOTTOMLEFT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_BOTTOMLEFT.Name = "btn_Pitch_BOTTOMLEFT";
            this.btn_Pitch_BOTTOMLEFT.Size = new System.Drawing.Size(94, 94);
            this.btn_Pitch_BOTTOMLEFT.TabIndex = 6;
            this.btn_Pitch_BOTTOMLEFT.Text = "BOTTOM LEFT";
            this.btn_Pitch_BOTTOMLEFT.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_CENTRERIGHT
            // 
            this.btn_Pitch_CENTRERIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_CENTRERIGHT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_CENTRERIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_CENTRERIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_CENTRERIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_CENTRERIGHT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_CENTRERIGHT.Location = new System.Drawing.Point(238, 182);
            this.btn_Pitch_CENTRERIGHT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_CENTRERIGHT.Name = "btn_Pitch_CENTRERIGHT";
            this.btn_Pitch_CENTRERIGHT.Size = new System.Drawing.Size(96, 92);
            this.btn_Pitch_CENTRERIGHT.TabIndex = 5;
            this.btn_Pitch_CENTRERIGHT.Text = "CENTRE RIGHT";
            this.btn_Pitch_CENTRERIGHT.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_CENTRE
            // 
            this.btn_Pitch_CENTRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_CENTRE.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_CENTRE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_CENTRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_CENTRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_CENTRE.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_CENTRE.Location = new System.Drawing.Point(124, 182);
            this.btn_Pitch_CENTRE.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_CENTRE.Name = "btn_Pitch_CENTRE";
            this.btn_Pitch_CENTRE.Size = new System.Drawing.Size(94, 92);
            this.btn_Pitch_CENTRE.TabIndex = 4;
            this.btn_Pitch_CENTRE.Text = "CENTRE";
            this.btn_Pitch_CENTRE.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_CENTRELEFT
            // 
            this.btn_Pitch_CENTRELEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_CENTRELEFT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_CENTRELEFT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_CENTRELEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_CENTRELEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_CENTRELEFT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_CENTRELEFT.Location = new System.Drawing.Point(10, 182);
            this.btn_Pitch_CENTRELEFT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_CENTRELEFT.Name = "btn_Pitch_CENTRELEFT";
            this.btn_Pitch_CENTRELEFT.Size = new System.Drawing.Size(94, 92);
            this.btn_Pitch_CENTRELEFT.TabIndex = 3;
            this.btn_Pitch_CENTRELEFT.Text = "CENTRE LEFT";
            this.btn_Pitch_CENTRELEFT.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_TOPRIGHT
            // 
            this.btn_Pitch_TOPRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_TOPRIGHT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_TOPRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_TOPRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_TOPRIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_TOPRIGHT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_TOPRIGHT.Location = new System.Drawing.Point(238, 30);
            this.btn_Pitch_TOPRIGHT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_TOPRIGHT.Name = "btn_Pitch_TOPRIGHT";
            this.btn_Pitch_TOPRIGHT.Size = new System.Drawing.Size(96, 92);
            this.btn_Pitch_TOPRIGHT.TabIndex = 2;
            this.btn_Pitch_TOPRIGHT.Text = "TOP RIGHT";
            this.btn_Pitch_TOPRIGHT.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_TOPCENTRE
            // 
            this.btn_Pitch_TOPCENTRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_TOPCENTRE.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_TOPCENTRE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_TOPCENTRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_TOPCENTRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_TOPCENTRE.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_TOPCENTRE.Location = new System.Drawing.Point(124, 30);
            this.btn_Pitch_TOPCENTRE.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_TOPCENTRE.Name = "btn_Pitch_TOPCENTRE";
            this.btn_Pitch_TOPCENTRE.Size = new System.Drawing.Size(94, 92);
            this.btn_Pitch_TOPCENTRE.TabIndex = 1;
            this.btn_Pitch_TOPCENTRE.Text = "TOP CENTRE";
            this.btn_Pitch_TOPCENTRE.UseVisualStyleBackColor = false;
            // 
            // btn_Pitch_TOPLEFT
            // 
            this.btn_Pitch_TOPLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pitch_TOPLEFT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Pitch_TOPLEFT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pitch_TOPLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pitch_TOPLEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pitch_TOPLEFT.ForeColor = System.Drawing.Color.White;
            this.btn_Pitch_TOPLEFT.Location = new System.Drawing.Point(10, 30);
            this.btn_Pitch_TOPLEFT.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.btn_Pitch_TOPLEFT.Name = "btn_Pitch_TOPLEFT";
            this.btn_Pitch_TOPLEFT.Size = new System.Drawing.Size(94, 92);
            this.btn_Pitch_TOPLEFT.TabIndex = 0;
            this.btn_Pitch_TOPLEFT.Text = "TOP LEFT";
            this.btn_Pitch_TOPLEFT.UseVisualStyleBackColor = false;
            // 
            // label_Pitch
            // 
            this.label_Pitch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Pitch.AutoSize = true;
            this.label_Pitch.BackColor = System.Drawing.Color.Transparent;
            this.label_Pitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pitch.Location = new System.Drawing.Point(158, 29);
            this.label_Pitch.Name = "label_Pitch";
            this.label_Pitch.Size = new System.Drawing.Size(101, 24);
            this.label_Pitch.TabIndex = 2;
            this.label_Pitch.Text = "Pitch Grid";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 700);
            this.Controls.Add(this.btn_ExpandMenu);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Nav);
            this.Controls.Add(this.tableLayout_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Main";
            this.Text = "PLACEHOLDER_TITLE";
            this.panel_Nav.ResumeLayout(false);
            this.panel_Nav.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.tableLayout_Main.ResumeLayout(false);
            this.panel_Actions.ResumeLayout(false);
            this.panel_Actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Actions)).EndInit();
            this.panel_Players.ResumeLayout(false);
            this.panel_Players.PerformLayout();
            this.panel_PlayerButtons.ResumeLayout(false);
            this.tableLayout_Players.ResumeLayout(false);
            this.panel_Pitch.ResumeLayout(false);
            this.panel_Pitch.PerformLayout();
            this.panel_Grid_Buttons.ResumeLayout(false);
            this.tableLayout_Pitch.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel_Nav;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_ExpandMenu;
        private System.Windows.Forms.Button btn_AddInjury;
        private System.Windows.Forms.Button btn_DisqualifyPlayer;
        private System.Windows.Forms.Button btn_Halftime;
        private System.Windows.Forms.Button btn_Subsitution;
        private System.Windows.Forms.Panel panel_Actions;
        private System.Windows.Forms.Panel panel_Players;
        private System.Windows.Forms.Panel panel_Pitch;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Main;
        private System.Windows.Forms.Label label_Actions;
        private System.Windows.Forms.Label label_Players;
        private System.Windows.Forms.Label label_Pitch;
        private System.Windows.Forms.DataGridView DGV_Actions;
        private System.Windows.Forms.Panel panel_PlayerButtons;
        private System.Windows.Forms.Panel panel_Grid_Buttons;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Pitch;
        private System.Windows.Forms.Button btn_Pitch_TOPLEFT;
        private System.Windows.Forms.Button btn_Pitch_TOPCENTRE;
        private System.Windows.Forms.Button btn_Pitch_BOTTOMRIGHT;
        private System.Windows.Forms.Button btn_Pitch_BOTTOMCENTRE;
        private System.Windows.Forms.Button btn_Pitch_BOTTOMLEFT;
        private System.Windows.Forms.Button btn_Pitch_CENTRERIGHT;
        private System.Windows.Forms.Button btn_Pitch_CENTRE;
        private System.Windows.Forms.Button btn_Pitch_CENTRELEFT;
        private System.Windows.Forms.Button btn_Pitch_TOPRIGHT;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Players;
        private System.Windows.Forms.Button btn_Player_1;
        private System.Windows.Forms.Button btn_Player_2;
        private System.Windows.Forms.Button btn_Player_3;
        private System.Windows.Forms.Button btn_Player_4;
        private System.Windows.Forms.Button btn_Player_5;
        private System.Windows.Forms.Button btn_Player_6;
        private System.Windows.Forms.Button btn_Player_7;
        private System.Windows.Forms.Button btn_Player_8;
        private System.Windows.Forms.Button btn_Player_9;
        private System.Windows.Forms.Button btn_Player_10;
        private System.Windows.Forms.Button btn_Player_13;
        private System.Windows.Forms.Button btn_Player_11;
        private System.Windows.Forms.Button btn_Player_14;
        private System.Windows.Forms.Button btn_Player_12;
        private System.Windows.Forms.Button btn_Player_15;
        private System.Windows.Forms.Button btn_Maximize;
    }
} 