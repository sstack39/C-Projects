namespace timeZoneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city;

            if (listBox1.SelectedIndex != -1)
            {
                city = listBox1.SelectedItem.ToString();
                switch (city)
                {
                    case "Honolulu":
                        timezoneLabel.Text = "Hawaii-Aleutian";
                            break;
                    case "San Francisco":
                        timezoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timezoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timezoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timezoneLabel.Text = "Eastern";
                        break;

                }
            }else
            {
                MessageBox.Show("Select a City.");
            }
        }
    }
}
