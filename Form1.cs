namespace NuevaCalculadora
{
    public partial class btnlimpiar : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public btnlimpiar()
        {
            InitializeComponent();
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
            Pantalla.Text = Math.Sqrt(primero).ToString();
        }
    }
}