
using System;
using System.Windows.Forms;

namespace tapsiriq1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numyas.Minimum = 1;
            numyas.Maximum = 100;
            numyas.Value = 18;

            cmbkurs.Items.Clear();
            cmbkurs.Items.Add("I kurs");
            cmbkurs.Items.Add("II kurs");
            cmbkurs.Items.Add("III kurs");
            cmbkurs.Items.Add("IV kurs");

            cmbkurs.DropDownStyle =
                ComboBoxStyle.DropDownList;

            btnelaveet.Click += btnelaveet_Click;
            btnsil.Click += btnsil_Click;

            lsttelebeler.SelectedIndexChanged +=
                lsttelebeler_SelectedIndexChanged;


            label5.Text = "Tələbə seçilməyib.";
        }

        private void btnelaveet_Click(
            object sender, EventArgs e)
        {
            string ad = txtad.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad))
            {
                MessageBox.Show(
                    "Tələbənin adını daxil edin!",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtad.Focus();
                return;
            }


            if (cmbkurs.SelectedIndex == -1)
            {
                MessageBox.Show("Kurs seçin!");
                return;
            }

 
            if (!rbkisi.Checked && !rbqadin.Checked)
            {
                MessageBox.Show("Cins seçin!");
                return;
            }


            int yas = (int)numyas.Value;

            string kurs =
                cmbkurs.SelectedItem.ToString();

            string cins = rbkisi.Checked
                ? "Kişi"
                : "Qadın";


            string telebe =
                $"Ad: {ad} | Yaş: {yas} | " +
                $"Kurs: {kurs} | Cins: {cins}";

            lsttelebeler.Items.Add(telebe);


            txtad.Clear();
            numyas.Value = 18;
            cmbkurs.SelectedIndex = -1;
            rbkisi.Checked = false;
            rbqadin.Checked = false;

            txtad.Focus();
        }


        private void btnsil_Click(
            object sender, EventArgs e)
        {
            if (lsttelebeler.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Silmək üçün tələbə seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Seçilmiş tələbəni silmək istəyirsiniz?",
                "Silməni təsdiqləyin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                lsttelebeler.Items.RemoveAt(
                    lsttelebeler.SelectedIndex);
            }
        }

        private void lsttelebeler_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lsttelebeler.SelectedIndex != -1)
            {
                label5.Text =
                    lsttelebeler.SelectedItem.ToString();
            }
            else
            {
                label5.Text = "Tələbə seçilməyib.";
            }
        }
    }
}
