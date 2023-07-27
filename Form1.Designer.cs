namespace ContactMe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            addBtn = new Button();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameField = new TextBox();
            emailField = new TextBox();
            phoneField = new TextBox();
            dataGridView1 = new DataGridView();
            editBtn = new Button();
            deleteBtn = new Button();
            searchField = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(91, 204);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(47, 31);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.White;
            Label1.Location = new Point(14, 63);
            Label1.Name = "Label1";
            Label1.Size = new Size(49, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(14, 107);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(14, 156);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // nameField
            // 
            nameField.Location = new Point(91, 52);
            nameField.Margin = new Padding(3, 4, 3, 4);
            nameField.Name = "nameField";
            nameField.Size = new Size(265, 27);
            nameField.TabIndex = 5;
            // 
            // emailField
            // 
            emailField.Location = new Point(91, 103);
            emailField.Margin = new Padding(3, 4, 3, 4);
            emailField.Name = "emailField";
            emailField.Size = new Size(265, 27);
            emailField.TabIndex = 6;
            // 
            // phoneField
            // 
            phoneField.Location = new Point(91, 152);
            phoneField.Margin = new Padding(3, 4, 3, 4);
            phoneField.Name = "phoneField";
            phoneField.Size = new Size(265, 27);
            phoneField.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 53);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(493, 416);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(195, 204);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(47, 31);
            editBtn.TabIndex = 9;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(291, 204);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(65, 31);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // searchField
            // 
            searchField.Location = new Point(443, 508);
            searchField.Margin = new Padding(3, 4, 3, 4);
            searchField.Name = "searchField";
            searchField.Size = new Size(430, 27);
            searchField.TabIndex = 11;
            searchField.KeyPress += searchField_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(382, 512);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 12;
            label4.Text = "Search :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(664, 568);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 14;
            label5.Text = "By Kolman Industries";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(824, 547);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 56);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(searchField);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(dataGridView1);
            Controls.Add(phoneField);
            Controls.Add(emailField);
            Controls.Add(nameField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(addBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label Label1;
        private Label label2;
        private Label label3;
        private TextBox nameField;
        private TextBox emailField;
        private TextBox phoneField;
        private DataGridView dataGridView1;
        private Button editBtn;
        private Button deleteBtn;
        private TextBox searchField;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}