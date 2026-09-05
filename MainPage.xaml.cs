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
            //Muda String para double
            double ValorGorjeta = Convert.ToDouble(GorjetaLabel.Text);
            

            GorjetaLabel.Text = Math.Floor(ValorGorjeta).ToString();
            

        }

        private void ArrendodarParaCimaButton_Clicked(object? sender, EventArgs e)
        {
            double ValorGorjeta = Convert.ToDouble(GorjetaLabel.Text);
            GorjetaLabel.Text = Math.Ceiling(ValorGorjeta).ToString();
            
            double ValorTotal = Convert.ToDouble(ValorTotalLabel.Text);
            
            


        }



        private void Gorjeta15PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
            
        }

        private void Gorjeta20PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
        }

        private void TrocaDeValorDoSlider(object? sender, EventArgs e)
        {
            PorcentagemGorjetaLabel.Text = $"{Math.Round( PorcentagemSlider.Value)} %";
            double valorDaConta = Convert.ToDouble( ContaEntry.Text);
            double porcentagemDaGorjeta = PorcentagemSlider.Value/100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = Convert.ToString(valorDaGorjeta);
            double valorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalLabel.Text = valorTotal.ToString();
        }

        
    }
    }
