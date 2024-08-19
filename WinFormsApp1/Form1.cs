namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(txtNum1.Text);
            valor2 = Convert.ToInt32(txtNum2.Text);

            if (rBtnSuma.Checked){
                resultado = valor1 + valor2;
                txtRes.Text = Convert.ToString(resultado);
            } else if (rBtnResta.Checked) {
                resultado = valor1 - valor2;
                txtRes.Text = Convert.ToString(resultado);
            } else if (rBtnMultiplicación.Checked)
            {
                resultado = valor1 * valor2;
                txtRes.Text = Convert.ToString(resultado);
            } else if (rBtnDivision.Checked) {
                resultado = valor1 / valor2;
                txtRes.Text = Convert.ToString(resultado);
                } 
        } 

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
