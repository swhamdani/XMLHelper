namespace XMLHelper
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
            this.stringsTxtBox = new System.Windows.Forms.TextBox();
            this.valuesTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringsTxtBox
            // 
            this.stringsTxtBox.Location = new System.Drawing.Point(33, 104);
            this.stringsTxtBox.Multiline = true;
            this.stringsTxtBox.Name = "stringsTxtBox";
            this.stringsTxtBox.Size = new System.Drawing.Size(576, 578);
            this.stringsTxtBox.TabIndex = 0;
            // 
            // valuesTxtBox
            // 
            this.valuesTxtBox.Location = new System.Drawing.Point(626, 104);
            this.valuesTxtBox.Multiline = true;
            this.valuesTxtBox.Name = "valuesTxtBox";
            this.valuesTxtBox.Size = new System.Drawing.Size(588, 578);
            this.valuesTxtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Extract Text from XML String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(862, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Create XML String from Text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Extract Text / Create XML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valuesTxtBox);
            this.Controls.Add(this.stringsTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XML Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringsTxtBox;
        private System.Windows.Forms.TextBox valuesTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

