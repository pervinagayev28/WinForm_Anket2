using System.Text.Json;
using System.Text.RegularExpressions;

namespace Anket2_
{
    public partial class Form1 : Form
    {
        static List<User> users = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            if (tbox_file_name.Text == "file name...")
                tbox_file_name.Text = "";
        }

        private void tbox_file_name_MouseLeave(object sender, EventArgs e)
        {
            if (tbox_file_name.Text == "")
                tbox_file_name.Text = "file name...";
        }
        private void filldata(string filename)
        {
            if (File.Exists(filename))
            {
                var file = File.ReadAllText(filename);
                users = JsonSerializer.Deserialize<List<User>>(file);
                dataGridView1.Rows.Clear();
                foreach (var item in users)
                    dataGridView1.Rows.Add(item.Gmail);
            }

        }
        private void saveData(string filename)
        {
            if (filename == "file name...")
            {
                MessageBox.Show("enter any name");
                return;
            }
            if (!File.Exists(filename))
            {
                using (File.Create(filename))
                {

                }
            }
            var file = JsonSerializer.Serialize(users, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(filename, file);
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            if (!Regex.IsMatch(tbox_name.Text, "^[a-zA-Z]{3,10}$"))
                lbl_error.Text = "error username";
            else if (!Regex.IsMatch(tbox_surname.Text, "^[a-zA-Z]{3,10}$"))
                lbl_error.Text = "error surname";
            else if (!Regex.IsMatch(tbox_gmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                lbl_error.Text = "error gmail";
            else if (dateTimePicker1.Value.Year > 2005)
            {

                lbl_error.Text = "your age under of 18";
            }
            else
            {
                if (button2.Text == "ADD")
                {
                    int VerifyCode = Random.Shared.Next(111111, 999999);
                    try
                    {
                        SmtpServerConnection.GmailVerify(tbox_gmail.Text, VerifyCode);
                    }
                    catch (Exception)
                    {
                        lbl_error.Text = "error gmail";
                        return;
                    }
                    try
                    {
                        var input = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("WE HAVE SENT  CODE,ENTER PLEASE:"));
                        if (input != VerifyCode)
                        {
                            lbl_error.Text = "incorrect verify code";
                            return;
                        }

                    }
                    catch (Exception)
                    {

                        lbl_error.Text = "incorrect verify code";
                        return;
                    }
                    dataGridView1.ClearSelection();
                    users.Add(new User()
                    {
                        Name = tbox_name.Text,
                        Surname = tbox_surname.Text,
                        Gmail = tbox_gmail.Text,
                        BirthDay = dateTimePicker1.Value
                    });
                    dataGridView1.Rows.Add(tbox_gmail.Text);
                }
                else
                {
                    var user = users.FirstOrDefault(u => u.Gmail == tbox_gmail.Text);
                    user.Name = tbox_name.Text;
                    user.Surname = tbox_surname.Text;
                    user.BirthDay = dateTimePicker1.Value;
                }


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    string gmail = dataGridView1.Rows[rowIndex].Cells["Gmails"].Value.ToString();


                    if (user.Gmail == gmail)
                    {
                        button2.Text = "UPDATE";
                        tbox_name.Text = user.Name;
                        tbox_surname.Text = user.Surname;
                        tbox_gmail.Text = user.Gmail;
                        dateTimePicker1.Value = user.BirthDay;
                    }
                }
            }


        }


        private void button4_Click(object sender, EventArgs e)
        {
            saveData(tbox_file_name.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filldata(tbox_file_name.Text);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width + 3, ((Button)sender).Height + 3);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width - 3, ((Button)sender).Height - 3);

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width + 3, ((Button)sender).Height + 3);

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width - 3, ((Button)sender).Height - 3);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width + 3, ((Button)sender).Height + 3);

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width - 3, ((Button)sender).Height - 3);

        }

        private void tbox_gmail_MouseLeave(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells["Gmails"].Value) == tbox_gmail.Text)
                    {
                        button2.Text = "UPDATE";
                        return;
                    }
                }
            }
            button2.Text = "ADD";
        }
    }
}
