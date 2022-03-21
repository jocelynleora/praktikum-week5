namespace praktikum_week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDara_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxData.Items.Contains(textBoxData.Text))
            {
                MessageBox.Show("Input Kembar");
            }
            else
            listBoxData.Items.Add(textBoxData.Text);
            textBoxData.Text = "";
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasil.Text = listBoxData.SelectedItem.ToString();
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked)
            {
                if (radioButtonMerah.Checked == true)
                {
                    labelHasil.ForeColor = Color.Red;
                }
                else if (radioButtonBiru.Checked == true)
                {
                    labelHasil.ForeColor = Color.Blue;
                }
            }
            
        }
    }
}