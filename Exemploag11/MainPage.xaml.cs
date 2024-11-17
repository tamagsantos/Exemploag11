namespace Exemploag11
{
    public partial class MainPage : ContentPage
    {
        String vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando o resultado */
            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
                (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") ||
                (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") ||
                (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") ||
                (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") ||
                (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") ||
                (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") ||
                (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")) 
            { 
                    DisplayAlert("PArabéns", "O Jogador 'X'  ganhou!", "OK");
                    Zerar();
            }
            if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
                     (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") ||
                     (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") ||
                     (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") ||
                     (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") ||
                     (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") ||
                     (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") ||
                     (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"))
            {
                DisplayAlert("Parabéns", "O Jogador 'O'  ganhou!", "OK");
                Zerar();
            }
            else if (!btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled &&
                       !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled &&
                       !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled)
            {
                DisplayAlert("Ops, Empatou.","O jogo finalizou e Ninguém ganhou!", "Tente outra vez!");
                Zerar();
            }

        } // Fechamento método 

        void Zerar ()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
           
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

        }
    } // Fecha Classe
} // Fecha Namespace
