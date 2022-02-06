using System;
using System.Windows.Forms;
 
namespace Lab1
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            Hide();
            mm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ID.TextLength == 0 || NameTextBox.TextLength == 0 || Surname.TextLength == 0 || Sex.Text == "" || Specialization.Text == "")
                MessageBox.Show("You have not added all the items. \nUnable to add student.", "Can not add!");
            else if (ID.Text.Length > 6) MessageBox.Show("Maximal ID length is 5", "Can not add!");
            else if (Sex.Text != "Male" || Sex.Text != "Female") MessageBox.Show("Choose a sex from the suggested", "Can not add!");
            else {
                IDdel.Items.Add(ID.Text);
        } }
    }
}
