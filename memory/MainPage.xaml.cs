namespace memory
{
    public partial class MainPage : ContentPage
    {
        private const int liczbaPar = 3;
        int[] elementy = new int[liczbaPar*2];
        string[] karty = { "kw.png", "ko.png", "tr.png"};
        private bool czyPierwsza = true;
        private int nrPierwszej;
        private ImageButton btnPierwszy;
        Random rnd = new Random();
        public MainPage()
        {
            InitializeComponent();
            losujElementy();
        }
        private void losujElementy()
        {
            for (int i = 0; i < liczbaPar*2; i++)
                elementy[i] = -1;
            for (int i = 0;i < liczbaPar; i++)
            {
                int x;
                do
                {
                    x = rnd.Next(0, liczbaPar * 2);
                } while (elementy[x]>=0);
                elementy[x] = i;
                do
                {
                    x = rnd.Next(0, liczbaPar * 2);
                } while (elementy[x]>=0);
                elementy[x] = i;
            }
        }
        private void resetBtnClicked(object sender, EventArgs e)
        {
            czyPierwsza = true;
            P00.Source = "bg.png";
            P01.Source = "bg.png";
            P02.Source = "bg.png";
            P10.Source = "bg.png";
            P11.Source = "bg.png";
            P12.Source = "bg.png";
            P00.IsEnabled = true;
            P01.IsEnabled = true;
            P02.IsEnabled = true;
            P10.IsEnabled = true;
            P11.IsEnabled = true;
            P12.IsEnabled = true;
            losujElementy();
        }
        private async void btnP00Clicked(object sender, EventArgs e)
        {
            P00.Source = karty[elementy[0]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 0;
                btnPierwszy = P00;
            }
            else
            {
                int x = elementy[0];
                if(nrPierwszej !=0)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P00.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P00.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
        private async void btnP01Clicked(object sender, EventArgs e)
        {
            P01.Source = karty[elementy[1]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 1;
                btnPierwszy = P01;
            }
            else
            {
                int x = elementy[1];
                if (nrPierwszej != 1)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P01.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P01.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
        private async void btnP02Clicked(object sender, EventArgs e)
        {
            P02.Source = karty[elementy[2]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 2;
                btnPierwszy = P02;
            }
            else
            {
                int x = elementy[2];
                if (nrPierwszej != 2)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P02.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P02.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
        private async void btnP10Clicked(object sender, EventArgs e)
        {
            P10.Source = karty[elementy[3]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 3;
                btnPierwszy = P10;
            }
            else
            {
                int x = elementy[3];
                if (nrPierwszej != 3)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P10.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P10.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
        private async void btnP11Clicked(object sender, EventArgs e)
        {
            P11.Source = karty[elementy[4]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 4;
                btnPierwszy = P11;
            }
            else
            {
                int x = elementy[4];
                if (nrPierwszej != 4)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P11.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P11.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
        private async void btnP12Clicked(object sender, EventArgs e)
        {
            P12.Source = karty[elementy[5]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 5;
                btnPierwszy = P12;
            }
            else
            {
                int x = elementy[5];
                if (nrPierwszej != 5)
                {
                    int y = elementy[nrPierwszej];
                    if (x == y)
                    {
                        P12.IsEnabled = false;
                        btnPierwszy.IsEnabled = false;
                        czyPierwsza = true;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        P12.Source = "bg.png";
                        btnPierwszy.Source = "bg.png";
                        czyPierwsza = true;
                    }
                }
                
            }
        }
    }
}