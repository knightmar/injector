using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Injector
{
    public partial class Form1 : Form
    {
        private static String dll_path = "";
        private static int pid = 0;

        void LoadPrograms()
        {
            program_to_inject.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.ProcessName))
                {
                    string[] processNames = processes.Select(p => p.ProcessName).Distinct().ToArray().OrderBy(x => x).ToArray();
                    program_to_inject.Items.AddRange(processNames.Cast<object>().ToArray());
                }
            }


            Debug.WriteLine("Loaded programs");

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a dll file",
                Filter = "Text files (*.dll)|*.dll",
                Title = "Open dll file"
            };
        }


        public Form1()
        {
            InitializeComponent();
            LoadPrograms();


            if (program_to_inject.Items.Count > 0)
            {
                program_to_inject.SelectedIndex = 0;
            }
        }


        private void program_to_inject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName(program_to_inject.SelectedItem.ToString());
            pid = proc[0].Id;
            Console.WriteLine(@"Selected program: " + program_to_inject.SelectedItem + @" with pid: " + pid);
        }

        private void select_dll_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dll_path = openFileDialog1.FileName;
                Console.WriteLine(@"Selected dll: " + dll_path);
            }
            else
            {
                Console.WriteLine(@"No dll selected");
            }
        }


        private void inject_button_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // private void openDllDialog_FileOk(object sender, CancelEventArgs e)
        // {
        //     if (openDllDialog.FileName != null)
        //     {
        //         dll_path = openDllDialog.FileName;
        //         Debug.WriteLine("Selected dll: " + dll_path);
        //     }
        // }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadPrograms();
        }
    }
}