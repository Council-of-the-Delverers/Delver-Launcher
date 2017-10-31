using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Delver_Launcher
{

    public partial class SelectForm : Form {

        enum RunChoice { DELVER, DELV_EDIT };

        RunChoice runChoice;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e) {

            int exitCode = 2;

            try {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "java";
                    process.StartInfo.Arguments = "-version";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();

                    // Wait until process finished
                    while (!process.HasExited) {
                        Thread.Sleep(100);
                    }

                    exitCode = process.ExitCode;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                exitCode = 2;
            }

            if (exitCode != 0) {
                MessageBox.Show("The application has assumed that you do not have Java installed on your computer, as it was not found in %PATH%!" + Environment.NewLine + Environment.NewLine +
                    "If you belive this is in error, then make sure you've updated to Java 8, which will fix the issue. You should also try re-installing Java as it 99% is an corrupt install.", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }

            if (!Directory.Exists("save")) {
                try {
                    Directory.CreateDirectory("save");
                } catch (Exception ex) {
                    MessageBox.Show("Could not create the missing 'save' directory!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(ex.Message);
                }
            }

            if (File.Exists("delver.jar")) {
                delverRadio.Enabled = true;
                if(!File.Exists("delver_backup.jar")) {
                    try
                    {
                        File.Copy("delver.jar", "delver_backup.jar");
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Could not clone delver.jar!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }

            if (File.Exists("DelvEdit.jar")) {
                delvEditRadio.Enabled = true;
                if (!File.Exists("DelvEdit_backup.jar")) {
                    try {
                        File.Copy("DelvEdit.jar", "DelvEdit_backup.jar");
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Could not clone DelvEdit.jar!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (!delverRadio.Enabled && !delvEditRadio.Enabled) {
                MessageBox.Show("Could not find Delver! This launcher requires Delver to be installed, it does not download the game for you. "+ Environment.NewLine +
                    "Are you sure you've put the launcher in the same directory as Delver?" + Environment.NewLine + Environment.NewLine +
                   "Very common Delver game path:" + Environment.NewLine +
                   @"C:\Program Files (x86)\Steam\steamapps\common\Delver", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                rememberBox.Enabled = false;
            }

        }

        private void okBtn_Click(object sender, EventArgs e) {

            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.Arguments = "-jar ";
            switch (runChoice) {
                case RunChoice.DELVER:
                    process.StartInfo.Arguments += "delver.jar";
                    break;

                case RunChoice.DELV_EDIT:
                    process.StartInfo.Arguments += "DelvEdit.jar";
                    break;

                default:
                    MessageBox.Show("You haven't selected anything!");
                    break;
            }

            if (rememberBox.CheckState == CheckState.Checked) {
                File.WriteAllText(Program.CONFIG_FILE, runChoice.ToString());
            }

            if (Program.ArgList != null) {
                process.StartInfo.Arguments += " " + Program.ArgList;
            }
            
            try
            {
                process.Start();
            } catch (Exception) {
                MessageBox.Show("Could not launch!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }
            

            Environment.Exit(0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void delverRadio_CheckedChanged(object sender, EventArgs e)
        {
            switch (delverRadio.Checked) {
                case true:
                    okBtn.Enabled = true;
                    runChoice = RunChoice.DELVER;
                    break;
                case false:
                    okBtn.Enabled = false;
                    break;
            }
        }

        private void delvEditRadio_CheckedChanged(object sender, EventArgs e)
        {
            switch (delvEditRadio.Checked) {
                case true:
                    okBtn.Enabled = true;
                    runChoice = RunChoice.DELV_EDIT;
                    break;
                case false:
                    okBtn.Enabled = false;
                    break;
            }
        }

        private void exitLabel_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void wwwLabel_Click(object sender, EventArgs e) {
            DialogResult dialogUpdates = MessageBox.Show("Visit webiste?", "Delver-Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogUpdates == DialogResult.Yes) {
                Process.Start("https://github.com/Council-of-the-Delverers/Delver-Launcher");
            }

        }

        private void aboutLabel_Click(object sender, EventArgs e) {
            MessageBox.Show("Alternative Delver launcher developed by the CotD team" + Environment.NewLine + "- automatic backups" + Environment.NewLine + "- parses command line arguments" + Environment.NewLine + "- checks for Java" + Environment.NewLine + "- lightweight" + Environment.NewLine + "- Steam-alike clean gui" + Environment.NewLine + "v2.0.0", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
