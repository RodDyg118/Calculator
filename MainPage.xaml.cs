namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ArrendodarParaBaixoButton_Clicked(object? sender, EventArgs e)
        {

        }

        private void ArrendodarParaCimaButton_Clicked(object? sender, EventArgs e)
        {

        }



        private void Gorjeta15PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
            
        }

        private void Gorjeta20PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
        }

        private void TrocaDeValorDoSlider(object? sender, EventArgs e)
        {
            PorcentagemGorjetaLabel.Text = $"{PorcentagemSlider.Value} ";
            double valorDaConta = Convert.ToDouble( ContaEntry.Text);
            double porcentagemDaGorjeta = PorcentagemSlider.Value/100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = Convert.ToString(valorDaGorjeta);
            double valorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalLabel.Text = valorTotal.ToString();
        }

        private void ArrendodarParaBaixoButton_Clicked(object sender, EventArgs e)
        {

        }
    }
    }
