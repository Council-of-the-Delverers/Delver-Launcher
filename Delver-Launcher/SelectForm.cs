using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Delver_Launcher
{

    public partial class SelectForm : Form
    {

        enum RunChoice { DELVER, DELV_EDIT };

        RunChoice runChoice;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

            CheckJava();

            CheckGameInfo();

            if (!delverRadio.Enabled && !delvEditRadio.Enabled)
            {
                MessageBox.Show("Could not find Delver! This launcher requires Delver to be installed, it does not download the game for you. " + Environment.NewLine +
                    "Are you sure you've put the launcher in the same directory as Delver?" + Environment.NewLine + Environment.NewLine +
                   "Very common Delver game path:" + Environment.NewLine +
                   @"C:\Program Files (x86)\Steam\steamapps\common\Delver", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                rememberBox.Enabled = false;
            }

        }

        /// <summary>
        /// Check if Java is available and ready to be used.
        /// </summary>
        private void CheckJava()
        {
            int exitCode = 2;
            try {
                using (Process process = new Process()) {
                    process.StartInfo.FileName = "java";
                    process.StartInfo.Arguments = "-version";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start(); // Cannot use WaitForExit() as it doesn't provide an (int)errorcode

                    // Wait until process finished
                    while (!process.HasExited) {
                        Thread.Sleep(300);
                    }

                    exitCode = process.ExitCode;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                exitCode = 2;
            }

            if (exitCode != 0) {
                MessageBox.Show("The application has assumed that you do not have Java installed on your computer, as it was not found in PATH environment variable! It cannot function if this problem persists, you must fix this problem in order to use the launcher." + Environment.NewLine + Environment.NewLine +
                    "You can try one of the following to resolve this problem:" + Environment.NewLine +
                    "- Update to Java 8 (will 99.9% of time fix your issue)" + Environment.NewLine +
                    "- Reinstall Java (it might be a corrupt install)" + Environment.NewLine +
                    "- Manually add the Java bin folder to the PATH environment variable"
                    , "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }
        }

        /// <summary>
        /// Do simple check for if the 'save' directory exists, and create it if needed or else the game will not be able to save
        /// Checks the runnable java files 'delver.jar' and 'DelvEdit.jar'
        /// </summary>
        private void CheckGameInfo()
        {
            if (!Directory.Exists("save")) {
                try{
                    Directory.CreateDirectory("save");
                } catch (Exception ex) {
                    MessageBox.Show("Could not create the missing 'save' directory!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine(ex.ToString());
                }
            }

            if (File.Exists("delver.jar")) {
                delverRadio.Enabled = true;
                if (!File.Exists("delver_backup.jar")) {
                    try {
                        File.Copy("delver.jar", "delver_backup.jar");
                    } catch (Exception ex) {
                        Console.WriteLine(ex.ToString());
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
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show("Could not clone DelvEdit.jar!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            Process process = new Process();
            process.StartInfo.FileName = "java";
            process.StartInfo.Arguments = "-jar ";
            switch (runChoice)
            {
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

            if (rememberBox.CheckState == CheckState.Checked)
            {
                File.WriteAllText(Program.CONFIG_FILE, runChoice.ToString());
            }

            if (Program.ArgList != null)
            {
                process.StartInfo.Arguments += " " + Program.ArgList;
            }

            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Could not launch the game!", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            switch (delverRadio.Checked)
            {
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
            switch (delvEditRadio.Checked)
            {
                case true:
                    okBtn.Enabled = true;
                    runChoice = RunChoice.DELV_EDIT;
                    break;
                case false:
                    okBtn.Enabled = false;
                    break;
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void wwwLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdates = MessageBox.Show("Visit website?", "Delver-Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogUpdates == DialogResult.Yes)
            {
                Process.Start("https://github.com/Council-of-the-Delverers/Delver-Launcher");
            }

        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alternative Delver launcher developed by the CotD team" + Environment.NewLine + "- automatic backups" + Environment.NewLine + "- parses command line arguments" + Environment.NewLine + "- checks for Java" + Environment.NewLine + "- lightweight" + Environment.NewLine + "- Steam-alike clean gui" + Environment.NewLine + "v2.0.0", "Delver-Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void subredditLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdates = MessageBox.Show("Visit subreddit?", "Delver-Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogUpdates == DialogResult.Yes)
            {
                Process.Start("https://reddit.com/r/Delver");
            }
        }

        private void discordLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdates = MessageBox.Show("Join unofficial Delver Discord community?", "Delver-Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogUpdates == DialogResult.Yes)
            {
                Process.Start("https://discord.gg/R5HKtjj");
            }
        }

        private void gearLabel_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            Hide();
        }

        private void workshopLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdates = MessageBox.Show("Visit Steam Workshop?", "Delver-Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogUpdates == DialogResult.Yes)
            {
                Process.Start("https://steamcommunity.com/app/249630/workshop/");
            }
        }

    }
    
}
