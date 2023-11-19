using System;
using System.IO;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            try
            {
                string hostsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
                File.AppendAllText(hostsPath, "127.0.0.1 api.scpslgame.com\r\n");
                File.AppendAllText(hostsPath, "127.0.0.1 gra2.scpslgame.com\r\n");

                MessageBox.Show("安装成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("安装失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            try
            {
                string hostsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts");
                string hostsContent = File.ReadAllText(hostsPath);
                hostsContent = hostsContent.Replace("127.0.0.1 api.scpslgame.com", string.Empty);
                hostsContent = hostsContent.Replace("127.0.0.1 gra2.scpslgame.com", string.Empty);
                File.WriteAllText(hostsPath, hostsContent);

                MessageBox.Show("卸载成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("卸载失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}