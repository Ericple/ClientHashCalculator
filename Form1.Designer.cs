namespace ClientHashCalculator
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
            groupBox1 = new GroupBox();
            Select_File_Button = new Button();
            File_Path_Box = new TextBox();
            Calculate_Button = new Button();
            Result_Text_Box = new TextBox();
            openFileDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Select_File_Button);
            groupBox1.Controls.Add(File_Path_Box);
            groupBox1.Controls.Add(Calculate_Button);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "选项";
            // 
            // Select_File_Button
            // 
            Select_File_Button.Location = new Point(459, 22);
            Select_File_Button.Name = "Select_File_Button";
            Select_File_Button.Size = new Size(63, 23);
            Select_File_Button.TabIndex = 2;
            Select_File_Button.Text = "浏览";
            Select_File_Button.UseVisualStyleBackColor = true;
            Select_File_Button.Click += Select_File_Button_Click;
            // 
            // File_Path_Box
            // 
            File_Path_Box.Location = new Point(6, 22);
            File_Path_Box.Name = "File_Path_Box";
            File_Path_Box.Size = new Size(447, 23);
            File_Path_Box.TabIndex = 1;
            File_Path_Box.Text = "选择文件";
            // 
            // Calculate_Button
            // 
            Calculate_Button.Location = new Point(528, 22);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(63, 23);
            Calculate_Button.TabIndex = 0;
            Calculate_Button.Text = "计算";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // Result_Text_Box
            // 
            Result_Text_Box.Location = new Point(12, 77);
            Result_Text_Box.Name = "Result_Text_Box";
            Result_Text_Box.Size = new Size(597, 23);
            Result_Text_Box.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 110);
            Controls.Add(Result_Text_Box);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Hash Calculator For VatsimAuth";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox File_Path_Box;
        private Button Calculate_Button;
        private TextBox Result_Text_Box;
        private Button Select_File_Button;
        private OpenFileDialog openFileDialog;
    }
}