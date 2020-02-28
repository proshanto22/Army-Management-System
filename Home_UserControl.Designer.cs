namespace Army_Management_System
{
    partial class Home_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestID_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ASC_TextBox = new System.Windows.Forms.Label();
            this.RegNO_TextBox = new System.Windows.Forms.Label();
            this.ReqDate_TextBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemID_TextBox = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchUButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Item_TextBox = new System.Windows.Forms.ComboBox();
            this.ItemType_TextBox = new System.Windows.Forms.ComboBox();
            this.ASCUno_TextBox = new System.Windows.Forms.ComboBox();
            this.reg_textBox = new System.Windows.Forms.ComboBox();
            this.Req_TextBox = new System.Windows.Forms.TextBox();
            this.Quantity_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Request_ID";
            // 
            // RequestID_TextBox
            // 
            this.RequestID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestID_TextBox.Location = new System.Drawing.Point(187, 37);
            this.RequestID_TextBox.Name = "RequestID_TextBox";
            this.RequestID_TextBox.Size = new System.Drawing.Size(151, 19);
            this.RequestID_TextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(187, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 2);
            this.panel1.TabIndex = 7;
            // 
            // ASC_TextBox
            // 
            this.ASC_TextBox.AutoSize = true;
            this.ASC_TextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASC_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ASC_TextBox.Location = new System.Drawing.Point(360, 378);
            this.ASC_TextBox.Name = "ASC_TextBox";
            this.ASC_TextBox.Size = new System.Drawing.Size(126, 25);
            this.ASC_TextBox.TabIndex = 12;
            this.ASC_TextBox.Text = "ASC_Unit_NO";
            // 
            // RegNO_TextBox
            // 
            this.RegNO_TextBox.AutoSize = true;
            this.RegNO_TextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNO_TextBox.ForeColor = System.Drawing.Color.Black;
            this.RegNO_TextBox.Location = new System.Drawing.Point(392, 421);
            this.RegNO_TextBox.Name = "RegNO_TextBox";
            this.RegNO_TextBox.Size = new System.Drawing.Size(80, 25);
            this.RegNO_TextBox.TabIndex = 13;
            this.RegNO_TextBox.Text = "Reg_NO";
            // 
            // ReqDate_TextBox
            // 
            this.ReqDate_TextBox.AutoSize = true;
            this.ReqDate_TextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqDate_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ReqDate_TextBox.Location = new System.Drawing.Point(392, 463);
            this.ReqDate_TextBox.Name = "ReqDate_TextBox";
            this.ReqDate_TextBox.Size = new System.Drawing.Size(93, 25);
            this.ReqDate_TextBox.TabIndex = 14;
            this.ReqDate_TextBox.Text = "Req_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Item_Type";
            // 
            // ItemID_TextBox
            // 
            this.ItemID_TextBox.AutoSize = true;
            this.ItemID_TextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemID_TextBox.ForeColor = System.Drawing.Color.Black;
            this.ItemID_TextBox.Location = new System.Drawing.Point(47, 378);
            this.ItemID_TextBox.Name = "ItemID_TextBox";
            this.ItemID_TextBox.Size = new System.Drawing.Size(75, 25);
            this.ItemID_TextBox.TabIndex = 18;
            this.ItemID_TextBox.Text = "Item_ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(487, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(152, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 2);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(152, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 2);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(152, 486);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 2);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel6.Location = new System.Drawing.Point(487, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 2);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel7.Location = new System.Drawing.Point(487, 444);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 2);
            this.panel7.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Army_Management_System.Properties.Resources.icons8_synchronize_24;
            this.button1.Location = new System.Drawing.Point(587, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchUButton
            // 
            this.SearchUButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchUButton.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUButton.Image = global::Army_Management_System.Properties.Resources.searchButtom;
            this.SearchUButton.Location = new System.Drawing.Point(420, 21);
            this.SearchUButton.Name = "SearchUButton";
            this.SearchUButton.Size = new System.Drawing.Size(155, 45);
            this.SearchUButton.TabIndex = 8;
            this.SearchUButton.Text = "Search";
            this.SearchUButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchUButton.UseVisualStyleBackColor = false;
            this.SearchUButton.Click += new System.EventHandler(this.SearchUButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Image = global::Army_Management_System.Properties.Resources.clear;
            this.ClearButton.Location = new System.Drawing.Point(508, 294);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(135, 51);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Image = global::Army_Management_System.Properties.Resources.delete;
            this.DeleteButton.Location = new System.Drawing.Point(346, 294);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 51);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = global::Army_Management_System.Properties.Resources.update;
            this.UpdateButton.Location = new System.Drawing.Point(187, 294);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 51);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Image = global::Army_Management_System.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(21, 294);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 51);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add New";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Item_TextBox
            // 
            this.Item_TextBox.AllowDrop = true;
            this.Item_TextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item_TextBox.FormattingEnabled = true;
            this.Item_TextBox.Items.AddRange(new object[] {
            "Arm_01",
            "Arm_02",
            "Rice_01",
            "Rice_02",
            "Dal_01",
            "Dal_02",
            "Vec_01",
            "Vec_02"});
            this.Item_TextBox.Location = new System.Drawing.Point(152, 378);
            this.Item_TextBox.Name = "Item_TextBox";
            this.Item_TextBox.Size = new System.Drawing.Size(151, 21);
            this.Item_TextBox.TabIndex = 28;
            this.Item_TextBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ItemType_TextBox
            // 
            this.ItemType_TextBox.AllowDrop = true;
            this.ItemType_TextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemType_TextBox.FormattingEnabled = true;
            this.ItemType_TextBox.Items.AddRange(new object[] {
            "Ration",
            "Vehicle",
            "Weapon"});
            this.ItemType_TextBox.Location = new System.Drawing.Point(153, 422);
            this.ItemType_TextBox.Name = "ItemType_TextBox";
            this.ItemType_TextBox.Size = new System.Drawing.Size(151, 21);
            this.ItemType_TextBox.TabIndex = 29;
            // 
            // ASCUno_TextBox
            // 
            this.ASCUno_TextBox.AllowDrop = true;
            this.ASCUno_TextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ASCUno_TextBox.FormattingEnabled = true;
            this.ASCUno_TextBox.Items.AddRange(new object[] {
            "2215",
            "5011",
            "5032"});
            this.ASCUno_TextBox.Location = new System.Drawing.Point(487, 380);
            this.ASCUno_TextBox.Name = "ASCUno_TextBox";
            this.ASCUno_TextBox.Size = new System.Drawing.Size(151, 21);
            this.ASCUno_TextBox.TabIndex = 31;
            // 
            // reg_textBox
            // 
            this.reg_textBox.AllowDrop = true;
            this.reg_textBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_textBox.FormattingEnabled = true;
            this.reg_textBox.Items.AddRange(new object[] {
            "AMC_01",
            "EME_01",
            "PARA",
            "RR_01"});
            this.reg_textBox.Location = new System.Drawing.Point(487, 422);
            this.reg_textBox.Name = "reg_textBox";
            this.reg_textBox.Size = new System.Drawing.Size(151, 21);
            this.reg_textBox.TabIndex = 32;
            // 
            // Req_TextBox
            // 
            this.Req_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Req_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Req_TextBox.Location = new System.Drawing.Point(487, 467);
            this.Req_TextBox.Name = "Req_TextBox";
            this.Req_TextBox.Size = new System.Drawing.Size(151, 19);
            this.Req_TextBox.TabIndex = 33;
            // 
            // Quantity_TextBox
            // 
            this.Quantity_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_TextBox.Location = new System.Drawing.Point(152, 467);
            this.Quantity_TextBox.Name = "Quantity_TextBox";
            this.Quantity_TextBox.Size = new System.Drawing.Size(151, 19);
            this.Quantity_TextBox.TabIndex = 34;
            // 
            // Home_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Quantity_TextBox);
            this.Controls.Add(this.Req_TextBox);
            this.Controls.Add(this.reg_textBox);
            this.Controls.Add(this.ASCUno_TextBox);
            this.Controls.Add(this.ItemType_TextBox);
            this.Controls.Add(this.Item_TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemID_TextBox);
            this.Controls.Add(this.ReqDate_TextBox);
            this.Controls.Add(this.RegNO_TextBox);
            this.Controls.Add(this.ASC_TextBox);
            this.Controls.Add(this.SearchUButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RequestID_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Home_UserControl";
            this.Size = new System.Drawing.Size(664, 520);
            this.Load += new System.EventHandler(this.Home_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RequestID_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchUButton;
        private System.Windows.Forms.Label ASC_TextBox;
        private System.Windows.Forms.Label RegNO_TextBox;
        private System.Windows.Forms.Label ReqDate_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ItemID_TextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Item_TextBox;
        private System.Windows.Forms.ComboBox ItemType_TextBox;
        private System.Windows.Forms.ComboBox ASCUno_TextBox;
        private System.Windows.Forms.ComboBox reg_textBox;
        private System.Windows.Forms.TextBox Req_TextBox;
        private System.Windows.Forms.TextBox Quantity_TextBox;
    }
}
