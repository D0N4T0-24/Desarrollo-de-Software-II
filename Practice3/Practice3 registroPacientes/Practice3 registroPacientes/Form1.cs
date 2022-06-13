namespace Practice3_registroPacientes
{

    public partial class Form1 : Form
    {
        List<Paciente> Pacients = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            groupBox1.Enabled = true;
            label10.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        private void Save()
        {
            var patient = new Paciente
            {
                Id = Guid.NewGuid(),
                NombreCompleto = textBox1.Text,
                Sexo = radioButton1.Checked ? "Masculino" : "Femenino",
                Nacimiento = dateTimePicker1.Value,
                Email = textBox2.Text,
                Contacto = textBox3.Text,
                Nacionalidad = textBox4.Text,
                TipoDocumento = comboBox1.Text,
                NumeroDocumento = textBox5.Text,
                Seguro = checkBox1.Checked ? true : false,
                NumeroSeguro = textBox6.Text,
                Fecha = DateTime.Now
            };

            Pacients.Add(patient);
            
            MessageBox.Show($"{textBox1.Text} registrado.");

            EmptyControls();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            groupBox1.Enabled = false;

            GetPatients();
        }


        private void GetPatients()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Pacients;
        }

        private void EmptyControls()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
                if (c is ComboBox)
                {
                    c.Text = String.Empty;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                if (c is DateTimePicker)
                {
                    c.ResetText();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyControls();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label10.Enabled = true;
                textBox6.Enabled = true;
            }
            else
            {
                label10.Enabled = false;    
                textBox6.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(dialog.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox1.Text;
        }
    }
}