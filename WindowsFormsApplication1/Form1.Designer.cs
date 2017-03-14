namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveLabel = new System.Windows.Forms.Label();
            this.SendLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BeginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(49, 25);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(134, 21);
            this.IPTextBox.TabIndex = 1;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(58, 68);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(125, 21);
            this.PortTextBox.TabIndex = 2;
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.AcceptsReturn = true;
            this.ReceiveTextBox.AcceptsTab = true;
            this.ReceiveTextBox.AllowDrop = true;
            this.ReceiveTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReceiveTextBox.Location = new System.Drawing.Point(231, 22);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(446, 213);
            this.ReceiveTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文行楷", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(-1, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口号:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("华文行楷", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(22, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "显示时间";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SendTextBox
            // 
            this.SendTextBox.AcceptsReturn = true;
            this.SendTextBox.AcceptsTab = true;
            this.SendTextBox.AllowDrop = true;
            this.SendTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SendTextBox.Location = new System.Drawing.Point(231, 293);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(446, 79);
            this.SendTextBox.TabIndex = 7;
            // 
            // ReceiveLabel
            // 
            this.ReceiveLabel.AutoSize = true;
            this.ReceiveLabel.Font = new System.Drawing.Font("华文行楷", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReceiveLabel.Location = new System.Drawing.Point(228, 4);
            this.ReceiveLabel.Name = "ReceiveLabel";
            this.ReceiveLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReceiveLabel.Size = new System.Drawing.Size(54, 15);
            this.ReceiveLabel.TabIndex = 8;
            this.ReceiveLabel.Text = "接收区:";
            // 
            // SendLabel
            // 
            this.SendLabel.AutoSize = true;
            this.SendLabel.Font = new System.Drawing.Font("华文行楷", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendLabel.Location = new System.Drawing.Point(228, 275);
            this.SendLabel.Name = "SendLabel";
            this.SendLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SendLabel.Size = new System.Drawing.Size(54, 15);
            this.SendLabel.TabIndex = 9;
            this.SendLabel.Text = "发送区:";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("华文行楷", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendButton.Location = new System.Drawing.Point(586, 381);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(91, 32);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("华文行楷", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(22, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 19);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "停止显示";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // BeginButton
            // 
            this.BeginButton.Font = new System.Drawing.Font("华文行楷", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginButton.Location = new System.Drawing.Point(49, 121);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(91, 32);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "开始";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 425);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendLabel);
            this.Controls.Add(this.ReceiveLabel);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiveTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.BeginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Label ReceiveLabel;
        private System.Windows.Forms.Label SendLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BeginButton;
    }
}

