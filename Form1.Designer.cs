namespace HostsEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(20, 143);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(182, 91);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "安装";
            this.installButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(235, 143);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(176, 91);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "卸载";
            this.uninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(16, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello!谜子音奈旧版实验室防踢补丁V2(2023/10月/27日纪念版)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "谜子音奈旧版实验室②群:398980311\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "也许不必太过沉溺在一个人身上，因为未来总会有更出色的相遇等待着我们。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(57, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Copyright ® 2023 谜子音奈 .All Rights Reserved.\r\nPowered By DLaoX.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::_string防踢补丁.Properties.Resources.mao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.uninstallButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hello!谜子音奈旧版实验室(2023/10/27纪念版)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 自动生成的控件声明

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
