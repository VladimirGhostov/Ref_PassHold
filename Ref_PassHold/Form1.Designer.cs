namespace Ref_PassHold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            generateButton = new Button();
            saveButton = new Button();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            passwordListBox = new ListBox();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(generateButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(loginTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 119);
            panel1.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(180, 86);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(105, 25);
            generateButton.TabIndex = 5;
            generateButton.Text = "Сгенерировать";
            generateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(50, 86);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(105, 25);
            saveButton.TabIndex = 4;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(50, 57);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(235, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(50, 21);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(235, 23);
            loginTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(54, 22);
            toolStripButton2.Text = "Пароли";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 22);
            toolStripButton1.Text = "Выход";
            // 
            // passwordListBox
            // 
            passwordListBox.FormattingEnabled = true;
            passwordListBox.ItemHeight = 15;
            passwordListBox.Location = new Point(314, 19);
            passwordListBox.Name = "passwordListBox";
            passwordListBox.Size = new Size(458, 424);
            passwordListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(passwordListBox);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "PassHold";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button generateButton;
        private Button saveButton;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ListBox passwordListBox;
    }
}
