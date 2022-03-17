namespace Juego_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int dado1, dado2;
            Random alea = new Random();
            dado1 = alea.Next(1, 6);
            dado2 = alea.Next(1, 6);
    
            try
            {
                if (dado1 == 1)
                {
                    PicDado1.Image = Image.FromFile("Cara1.png");
                    lblDado1.Text = dado1.ToString();
                }
                if (dado1 == 2)
                {
                    PicDado1.Image = Image.FromFile("Cara2.png");
                    lblDado1.Text = dado1.ToString();
                }
                if (dado1 == 3)
                {
                    PicDado1.Image = Image.FromFile("Cara3.png");
                    lblDado1.Text = dado1.ToString();
                }
                if (dado1 == 4)
                {
                    PicDado1.Image = Image.FromFile("Cara4.png");
                    lblDado1.Text = dado1.ToString();
                }
                if (dado1 == 5)
                {
                    PicDado1.Image = Image.FromFile("Cara5.png");
                    lblDado1.Text = dado1.ToString();
                }
                if (dado1 == 6)
                {
                    PicDado1.Image = Image.FromFile("Cara6.png");
                    lblDado1.Text = dado1.ToString();
                }

                if (dado2 == 1)
                {
                    PicDado2.Image = Image.FromFile("Cara1.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado2 == 2)
                {
                    PicDado2.Image = Image.FromFile("Cara2.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado2 == 3)
                {
                    PicDado2.Image = Image.FromFile("Cara3.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado2 == 4)
                {
                    PicDado2.Image = Image.FromFile("Cara4.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado2 == 5)
                {
                    PicDado2.Image = Image.FromFile("Cara5.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado2 == 6)
                {
                    PicDado2.Image = Image.FromFile("Cara6.png");
                    lblDado2.Text = dado2.ToString();
                }
                if (dado1 == dado2)
                {
                    lblResultado.Text = ("LOS DADOS CAYERON IGUALES");
                }
                else
                {
                    lblResultado.Text = "";
                }

            }catch (Exception ex)
            {
                //Console.WriteLine(ex.Message); 
                MessageBox.Show("Hubo un error!");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
       
    }
}