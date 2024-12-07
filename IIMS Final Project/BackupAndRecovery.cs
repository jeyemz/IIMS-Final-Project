using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IIMS_Final_Project
{
    public partial class BackupAndRecovery : Form
    {
        // Database Configuration
        private const string Server = "localhost";
        private const string User = "root";
        private const string Password = "";
        private const string Database = "iims_finalproject";
        private const int Port = 3307;

        public BackupAndRecovery()
        {
            InitializeComponent();
        }

        private void BackupAndRecovery_Load(object sender, EventArgs e)
        {

        }

        private void btn_BrowseBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql",
                Title = "Select Backup File Location",
                DefaultExt = "sql"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_BackupPath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_BackupPath.Text))
            {
                MessageBox.Show("Please specify a file path for the backup.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string backupCommand = $"mysqldump --user={User} --password={Password} --host={Server} --port={Port} {Database} > \"{txtbox_BackupPath.Text}\"";

                ExecuteCommand(backupCommand);
                MessageBox.Show("Database backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BrowseRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql",
                Title = "Select Restore File"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_RestorePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_RestorePath.Text))
            {
                MessageBox.Show("Please specify a file path for the restore.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string restoreCommand = $"mysql --user={User} --password={Password} --host={Server} --port={Port} {Database} < \"{txtbox_RestorePath.Text}\"";

                ExecuteCommand(restoreCommand);
                MessageBox.Show("Database restore completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during restore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    if (process != null)
                    {
                        using (StreamWriter sw = process.StandardInput)
                        {
                            sw.WriteLine(command);
                        }
                        process.WaitForExit();

                        if (process.ExitCode != 0)
                        {
                            throw new Exception($"Command failed with exit code {process.ExitCode}");
                        }
                    }
                    else
                    {
                        throw new Exception("Process failed to start.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Command execution failed: {ex.Message}");
            }
        }

        private void btn_BackToMenu_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
