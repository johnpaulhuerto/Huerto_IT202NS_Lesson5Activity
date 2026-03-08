using System;
using System.Windows.Forms;

namespace Huerto_Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double getVal(TextBox t) => double.TryParse(t.Text, out double v) ? v : 0;

            // 1. Calculate Income per category
            double basic = getVal(txtBasicRate) * getVal(txtBasicHours);
            double hon = getVal(txtHonRate) * getVal(txtHonHours);
            double other = getVal(txtOtherRate) * getVal(txtOtherHours);

            // 2. Display Incomes
            txtBasicIncome.Text = basic.ToString("0.00");
            txtHonIncome.Text = hon.ToString("0.00");
            txtOtherIncome.Text = other.ToString("0.00");

            double gross = basic + hon + other;
            txtGrossIncome.Text = gross.ToString("0.00");

            // 3. Display Regular Deductions
            // Based on your activity's sample data:
            txtSSSCont.Text = "1178.70";     // SSS Contribution
            txtPhilHealth.Text = "325.00";   // PhilHealth Contribution
            txtPagibig.Text = "100.00";      // Pag-IBIG is fixed at 100.00
            txtTax.Text = "3083.25";         // Income Tax Contribution
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double getVal(TextBox t) => double.TryParse(t.Text, out double v) ? v : 0;

            // Total Deductions = Regular Deductions + Other Deductions
            double regDed = getVal(txtSSSCont) + getVal(txtPhilHealth) + getVal(txtPagibig) + getVal(txtTax);
            double otherDed = getVal(txtSSSLoan) + getVal(txtPagibigLoan) + getVal(txtFacultySavings) +
                              getVal(txtFacultyLoan) + getVal(txtSalaryLoan) + getVal(txtOtherLoan);

            double totalDeduction = regDed + otherDed;
            txtTotalDeduction.Text = totalDeduction.ToString("0.00");

            // Net Income = Gross Income - Total Deductions
            double gross = getVal(txtGrossIncome);
            txtNetIncome.Text = (gross - totalDeduction).ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Getting data from your TextBoxes
            string fullName = $"{txtFirstname.Text} {txtSurname.Text}";
            string employeeNo = txtEmployeeNum.Text; // or txtEmployeeNo if renamed
            string payDate = txtPayDate.Text;

            // Formatting the Payslip Message
            string payslip = "LYCEUM OF THE PHILIPPINES UNIVERSITY - CAVITE\n";
            payslip += "--------------------------------------------------------\n";
            payslip += $"Employee Name: {fullName}\n";
            payslip += $"Employee Code: {employeeNo}\n";
            payslip += $"Pay Period: {payDate}\n";
            payslip += "--------------------------------------------------------\n";
            payslip += "EARNINGS\n";
            payslip += $"Basic Pay: {txtBasicIncome.Text}\n";
            payslip += $"Honorarium: {txtHonIncome.Text}\n";
            payslip += $"Other Income: {txtOtherIncome.Text}\n";
            payslip += $"GROSS EARNINGS: {txtGrossIncome.Text}\n";
            payslip += "--------------------------------------------------------\n";
            payslip += "DEDUCTIONS\n";
            payslip += $"Total Deductions: {txtTotalDeduction.Text}\n";
            payslip += "--------------------------------------------------------\n";
            payslip += $"NET PAY: {txtNetIncome.Text}\n";

            // Displaying the Payslip in a Message Box
            MessageBox.Show(payslip, "Employee Payslip Report");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Loops through all controls and clears TextBoxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox t) t.Clear();
                // If your controls are inside a GroupBox, we check those too
                if (c is GroupBox g)
                    foreach (Control gc in g.Controls)
                        if (gc is TextBox gt) gt.Clear();
            }
            picEmployee.Image = null; // Clears the photo
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
