namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        

        private void Gorjeta15PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
            
        }

        private void Gorjeta20PorcentagemButton_Clicked(object? sender, EventArgs e)
        {
            
        }

        private void TrocaDeValorDoSlider(object? sender, EventArgs e)
        {
            PorcentagemGorjetaLabel.Text = $"{TipPercentSlider.Value}";
        }
    }
    }
