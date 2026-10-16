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

            cmbkurs.Items.AddRange(new object[]
            {
                "I kurs",
                "II kurs",
                "III kurs",
                "IV kurs"
            });

            cmbkurs.DropDownStyle = ComboBoxStyle.DropDownList;

            btnelaveet.Click += btnelaveet_Click;
            btnsil.Click += btnsil_Click;

            lsttelebeler.SelectedIndexChanged +=
                lsttelebeler_SelectedIndexChanged;
        }

        private void btnelaveet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtad.Text))
            {
                MessageBox.Show("Ad daxil edin!");
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

            string cins = rbkisi.Checked ? "Kişi" : "Qadın";

            string telebe = $"Ad: {txtad.Text.Trim()} | " +
                            $"Yaş: {numyas.Value} | " +
                            $"Kurs: {cmbkurs.Text} | " +
                            $"Cins: {cins}";

            lsttelebeler.Items.Add(telebe);

            txtad.Clear();
            numyas.Value = 18;
            cmbkurs.SelectedIndex = -1;
            rbkisi.Checked = false;
            rbqadin.Checked = false;

            txtad.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lsttelebeler.SelectedIndex == -1)
            {
                MessageBox.Show("Silmək üçün tələbə seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Seçilmiş tələbəni silmək istəyirsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                lsttelebeler.Items.RemoveAt(
                    lsttelebeler.SelectedIndex);

                label5.Text = "Tələbə seçilməyib.";
            }
        }

        private void lsttelebeler_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lsttelebeler.SelectedItem != null)
            {
                label5.Text = lsttelebeler.SelectedItem.ToString();
            }
            else
            {
                label5.Text = "Tələbə seçilməyib.";
            }
        }

        private void numyas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}