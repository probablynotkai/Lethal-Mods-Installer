using LethalMods.api;
using LethalMods.managers;
using LethalMods.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LethalMods
{
    public partial class Form1 : Form
    {
        public static ConfigManager configManager = new ConfigManager();
        private static LethalInstaller installer = new LethalInstaller();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            installer.UninstallLethalMods();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kai-h.dev/");
        }

        private void installModsButton_Click(object sender, EventArgs e)
        {
            installer.InstallLethalMods();
        }

        private void uiHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
