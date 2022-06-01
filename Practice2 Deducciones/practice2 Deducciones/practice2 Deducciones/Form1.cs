namespace practice2_Deducciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sueldo = Convert.ToDouble(textBox1.Text);

            

            label3.Text = $"AFP = {sueldo * 0.0287}$";
            label4.Text = $"ISR = {sueldo * 0.07}$";
            label5.Text = $"SFS = {sueldo * 0.0304}$";
            label6.Text = $"Deducciones totales = {sueldo * 0.09 + sueldo * 0.07 + sueldo * 0.10}$";
            label7.Text = $"Sueldo Neto = {sueldo - (sueldo * 0.09 + sueldo * 0.07 + sueldo * 0.10)}";

        }
    }
}