using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calemre
{
    public partial class Form2 : Form
    {
        private string FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login_info.txt");
        private string TaskFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        private string username;
        private List<Task> tasks = new List<Task>();

        public Form2()
        {
            InitializeComponent();

            buttonUpdatePsswd.Click += buttonUpdatePsswd_Click;
            buttonCancelUpdate.Click += buttonCancelUpdate_Click;


            buttonSaveTask.Click += btnSaveTask_Click;
            iconAddTasks.Click += iconAddTasks_Click;

            panelPasswrodChange.Visible = false;
            panelNewTask.Visible = false;
            panelTask1.Visible = false;
            panelTask2.Visible = false;
            panelTask3.Visible = false;
            panelTask4.Visible = false;

            this.Controls.Add(taskPanelContainer); //Read User Name
            string[] credentials = File.ReadAllLines(FileName);
            foreach (string line in credentials)
            {
                string[] parts = line.Split('-');
                username = parts[0].Trim();
                break;
            }
            labelUsername.Text = username;      //Print UserName
            DisplayTasks();

        }

        private FlowLayoutPanel taskPanelContainer = new FlowLayoutPanel
        {
            AutoScroll = false,
            Dock = DockStyle.Fill,
        };

        //The Task Class
        public class Task
        {
            public string Taskname { get; set; }
            public DateTime DueDate { get; set; }
            public string Description { get; set; }
            public int Priority { get; set; }

            public Task(string taskName, DateTime dueDate, string description = "", int priority = 3)
            {
                Taskname = taskName;
                DueDate = dueDate;
                Description = description;
                Priority = priority;
            }
        }


        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            panelPasswrodChange.Visible = true;
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void buttonCancelUpdate_Click(object sender, EventArgs e)
        {
            panelPasswrodChange.Visible = false;
        }

        private void buttonUpdatePsswd_Click(object sender, EventArgs e)
        {
            string currentPassword = textBoxCurrentPsswd.Text;
            string newPassword = textBoxNewPsswd.Text;
            string confirmPassword = textBoxRetypePsswd.Text;

            string[] credentials = File.ReadAllLines(FileName);

            foreach (string line in credentials)
            {
                string[] parts = line.Split('-');
                string username = parts[0].Trim();
                string savedPassword = parts[1].Trim();

                if (currentPassword == savedPassword)
                {
                    if (newPassword == confirmPassword)
                    {
                        savedPassword = newPassword;

                        string tempFileName = Path.GetTempFileName();

                        using (StreamWriter writer = new StreamWriter(tempFileName))
                        {
                            writer.WriteLine($"{username} - {savedPassword}");
                            foreach (string credential in credentials)
                            {
                                if (credential != line)
                                {
                                    writer.WriteLine(credential);
                                }
                            }
                        }

                        File.Delete(FileName);
                        File.Move(tempFileName, FileName);

                        MessageBox.Show("Password changed successfully.");
                        panelPasswrodChange.Visible = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("New passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            MessageBox.Show("Current password is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconAddTasks_Click(object sender, EventArgs e)
        {
            textTaskName.Clear();
            textDesc.Clear();
            GetSelectedPriority();

            panelNewTask.Visible = true;
        }
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = textTaskName.Text;
            DateTime dueDate = dateTimePicker.Value;
            string description = textDesc.Text;
            int priority = GetSelectedPriority();

            Task newTask = new Task(taskName, dueDate, description, priority);
            tasks.Add(newTask);
            SaveTasks();
            DisplayTasks();
            panelNewTask.Visible = false;
            MessageBox.Show("Task has been created Successfully");
        }

        private int GetSelectedPriority()
        {
            if (priority1.Checked)
            {
                return 1;
            }
            if (priority2.Checked)
            {
                return 2;
            }
            if (priority3.Checked)
            {
                return 3;
            }
            if (priority4.Checked)
            {
                return 4;
            }
            if (priority5.Checked)
            {
                return 5;
            }

            // Return a default value if none of the radio buttons are checked.
            return 3;
        }
        private void SaveTasks()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(TaskFile, true)) // Use 'true' to append to the file
                {
                    foreach (Task task in tasks)
                    {
                        writer.WriteLine($"{task.Taskname} - {task.DueDate.ToString("yyyy/MM/dd")} - {task.Description} - {task.Priority}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayTasks()
        {
            if (File.Exists(TaskFile))
            {
                string[] lines = File.ReadAllLines(TaskFile);
                int lineNum = lines.Length;

                for (int i = 0; i < lineNum; i++)
                {
                    string[] parts = lines[i].Split('-');
                    string taskName = parts[0].Trim();
                    string dateString = parts[1].Trim();
                    string description = parts[2].Trim();

                    // Print the date string to diagnose the issue
                    Console.WriteLine($"Date String: {dateString}");

                    DateTime dueDate;
                    if (DateTime.TryParseExact(dateString, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dueDate))
                    {
                        int priority = int.Parse(parts[3].Trim());
                        // Assuming the names of the panels are panelTask1, panelTask2, etc.
                        Panel taskPanel = this.Controls.Find("panelTask" + (i + 1), true).FirstOrDefault() as Panel;

                        // Assuming the names of the controls in the panel
                        // Replace these with the actual names of your controls
                        TextBox taskNameTextBox = taskPanel.Controls.Find("textPanel" + (i + 1), true).FirstOrDefault() as TextBox;
                        DateTimePicker dueDatePicker = taskPanel.Controls.Find("datePanel" + (i + 1), true).FirstOrDefault() as DateTimePicker;
                        RichTextBox descriptionTextBox = taskPanel.Controls.Find("descPanel" + (i + 1), true).FirstOrDefault() as RichTextBox;

                        taskPanel.Visible = true;


                        if (taskNameTextBox != null)
                            taskNameTextBox.Text = taskName;

                        if (dueDatePicker != null)
                            dueDatePicker.Value = dueDate;

                        if (descriptionTextBox != null)
                            descriptionTextBox.Text = description;

                    }
                    else
                    {
                        // Print an error message if parsing fails
                        Console.WriteLine($"Error parsing date string: {dateString}");
                    }
                }
            }
        }

    }

}