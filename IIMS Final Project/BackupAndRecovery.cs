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
        private const string Password = "peybi29INC";
        private const string Database = "iims_finalproject";
        private const int Port = 3306;

        public BackupAndRecovery()
        {
            InitializeComponent(); // Initialize the form components
        }

        private void btn_BrowseBackup_Click(object sender, EventArgs e)
        {
            // Open a dialog for the user to select the backup file location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql", // Restrict file format to .sql
                Title = "Select Backup File Location",
                DefaultExt = "sql" // Default file extension
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_BackupPath.Text = saveFileDialog.FileName; // Save file path
                }
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            // Validate that the user has specified a backup path
            if (string.IsNullOrWhiteSpace(txtbox_BackupPath.Text))
            {
                MessageBox.Show("Please specify a file path for the backup.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create the MySQL dump command
                string backupCommand = $"mysqldump --user={User} --password={Password} --host={Server} --port={Port} {Database} > \"{txtbox_BackupPath.Text}\"";

                // Execute the command in a shell environment
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
            // Open a dialog for the user to select a restore file
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql", // Restrict file format to .sql
                Title = "Select Restore File"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_RestorePath.Text = openFileDialog.FileName; // Save file path
                }
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            // Validate that the user has specified a restore file path
            if (string.IsNullOrWhiteSpace(txtbox_RestorePath.Text))
            {
                MessageBox.Show("Please specify a file path for the restore.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create the MySQL restore command
                string restoreCommand = $"mysql --user={User} --password={Password} --host={Server} --port={Port} {Database} < \"{txtbox_RestorePath.Text}\"";

                // Execute the command in a shell environment
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
                // Prepare the command for execution in a new shell
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
                            sw.WriteLine(command); // Pass the command to the shell
                        }
                        process.WaitForExit();

                        // Check for command execution success
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            Menu Menu = new Menu();
            Menu.Show();  // Show the Menu form
            this.Hide();  // Hide the current form
        }
    }
}
