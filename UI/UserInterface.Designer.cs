namespace UI
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            pictureBox1 = new PictureBox();
            IDLabel = new Label();
            Name = new Label();
            AgeLabel = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            AgeBox = new TextBox();
            GetBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-7, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 471);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(10, 131);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(24, 20);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(10, 165);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 2;
            Name.Text = "Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(10, 202);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(71, 124);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(46, 27);
            IDBox.TabIndex = 4;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(71, 162);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(101, 27);
            NameBox.TabIndex = 5;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(72, 199);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(45, 27);
            AgeBox.TabIndex = 6;
            // 
            // GetBtn
            // 
            GetBtn.Location = new Point(209, 117);
            GetBtn.Name = "GetBtn";
            GetBtn.Size = new Size(126, 49);
            GetBtn.TabIndex = 7;
            GetBtn.Text = "Get";
            GetBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(209, 168);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(122, 50);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(214, 224);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 51);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(209, 281);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(120, 46);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(GetBtn);
            Controls.Add(AgeBox);
            Controls.Add(NameBox);
            Controls.Add(IDBox);
            Controls.Add(AgeLabel);
            Controls.Add(Name);
            Controls.Add(IDLabel);
            Controls.Add(pictureBox1);
            Name = "UserInterface";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label IDLabel;
        private Label Name;
        private Label AgeLabel;
        private TextBox IDBox;
        private TextBox NameBox;
        private TextBox AgeBox;
        private Button GetBtn;
        private Button UpdateBtn;
        private Button AddBtn;
        private Button DeleteBtn;
    }
}