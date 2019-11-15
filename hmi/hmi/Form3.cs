using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmi
{
    public partial class Form3 : Form
    {
        public delegate void ValueCallback(string data);
        public ValueCallback valueCallback;
        List<User> users = new List<User>();
        int trial = 0;
        public Form3()
        {
            InitializeComponent();
            readFromFile();
            foreach (User u in users)
            {
                listBox_users.Items.Add(u.Login);
            }
            listBox_users.SetSelected(0, true);
        }
        private void readFromFile()
        {
            string pathName = @"users.txt";
            List<string> user = new List<string>();
            foreach (string line in File.ReadLines(pathName))
            {
                user = line.Split(',').ToList<string>();
                users.Add(new User(user[0], user[1], user[2]));
            }
        }
        public void saveToFile()
        {
            string pathName = @"users.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathName, true))
            {
                file.WriteLine(users[users.Count - 1].Login + "," + users[users.Count - 1].EncryptDecrypt() + "," + users[users.Count - 1].Group);
                /*foreach (User u in users)
                {
                    file.WriteLine(u.Login + "," + u.EncryptDecrypt() + "," + u.Group);
                }*/
            }
        }
        private void Button_log_Click(object sender, EventArgs e)
        {
            button_newuser.Enabled = false;
            foreach (User u in users)
            {
                if (u.Login == listBox_users.SelectedItem.ToString())
                {
                    if (textBox_pass.Text == u.EncryptDecrypt())
                    {
                        textBox_group.Text = u.Group;
                        trial = 0;
                        if (u.Group == "admin") button_newuser.Enabled = true;
                        if (valueCallback != null) valueCallback(u.Group);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        trial++;
                        if (trial == 3)
                            this.Close();
                    }
                }
            }
        }
        private void Button_newuser_Click(object sender, EventArgs e)
        {
            listBox_users.Visible = false;
            textBox_user.Visible = true;
            textBox_group.Enabled = true;
            textBox_group.Text = "";
            textBox_pass.Text = "";
            button_create.Visible = true;
        }
        private void Button_create_Click(object sender, EventArgs e)
        {
            users.Add(new User(textBox_user.Text, textBox_pass.Text, textBox_group.Text));
            listBox_users.Items.Add(users[users.Count - 1].Login);
            textBox_user.Visible = false;
            listBox_users.Visible = true;
            textBox_group.Enabled = false;
            button_create.Visible = false;
            textBox_user.Text = "";
            textBox_group.Text = "";
            textBox_pass.Text = "";
            button_newuser.Enabled = false;
            saveToFile();
        }
    }
}