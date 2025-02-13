using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_dodaj_tekst_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.Text = b.Text + "!";
            }

            string tekst = textBox_tekst.Text;
            if (!string.IsNullOrWhiteSpace(tekst))
            {
                DialogResult dialogResult = MessageBox.Show($"Doda³eœ tekst: {tekst}", "DODANO NOWY TEKST", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    listBox_tekst.Items.Add(tekst);
                    textBox_tekst.Clear();
                    textBox_tekst.Focus();
                    button_wyczysc.Visible = true;
                    button_wyczysc.BackColor = Color.Orange;
                }
            }
        }

        private void button_wyczysc_Click(object sender, EventArgs e)
        {
            listBox_tekst.Items.Clear();
            button_wyczysc.Visible = false;
        }

        private void textBox_tekst_KeyPress(object sender, KeyPressEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Poda³eœ tekst: {textBox_tekst.Text}", "Wpisano NOWY TEKST", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK) {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                label1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
    }
}
