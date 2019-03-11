using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinama_Odev1
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X , false = Y 
        bool against_computer = false;
        int turn_count = 0;
        int zamanPlayer1 = 0,zamanPlayer2=0;
                                        
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" By Geren ", " X O X About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txt_p1.Text == "Player 1") || (txt_p2.Text == "Player 2")) //bilgisayara karşı mı yoksa 2 kişilik oyun mu seçimi textboxlara girilecek isimlerle belirlenir.
                MessageBox.Show("You must specify the players names before you can start!\nType computer(for player 2) to play against the computer.");
            else
            {
                Button button = (Button)sender;

                if (turn) { 
                    button.Text = "X";
                    timer1.Start();
                    timer2.Stop();
                }
                else {
                    timer1.Stop();
                    timer2.Start();
                    button.Text = "O";
                }

                turn = !turn; //turn değerini sıradaki oyuncunun diğer harfi oynayabilmesi için değiştiriyoruz.
                button.Enabled = false; //oynanan hamlenin değiştirilmesini engellemek için.
                turn_count++; //hamle sayısını arttır

                checkForWinner(); //kazanma koşullarını içeren fonksiyonu çağır
            }

            if ((!turn) && (against_computer)) //sıra O ' da ise ve 2. player da computer yazıyorsa
                computer_make_move();          //bilgisayarla oynama fonksiyonuna ilerle
        }

        private void computer_make_move() //Bilgisayarın hamlesi
        {
            Button move = null; //butonlarda hamle yok

            move = look_for_win_or_block("O"); // bilgisayarın oynayacağı hamle kazanma hamlesi mı yoksa rakibi bloklama hamlesi mi kontrol için foksiyona git
            if (move == null) 
            {
                move = look_for_win_or_block("X"); //bilgisayarın oynayacağı hamle kazanma hamlesi mı yoksa rakibi bloklama hamlesi mi kontrol için foksiyona git
                if (move == null)
                {
                    move = look_for_corner(); //hamle için uygun köşelere bakmaya giden fonksiyon
                    if (move == null)
                        move = look_for_open_space();// sonunda oynanılcak buton açık mı diye kontrole giden fonksiyon
                }
            }
            try
            {
                move.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("OYUN BİTTİ");
            }   
        }

        private Button look_for_open_space() //kazanma yada blok hamlesi seçilip uygun olan köşe(buton) belirlendikten sonra seçilen alan açık mı diye kontrol edilir
        {
            Console.WriteLine("Looking for open space");
            Button button = null;

            foreach(Control c in Controls)
            {
                button = c as Button;
                if (button != null)
                {
                    if (button.Text == "")
                        return button;
                }
            }
            return null;
        }

        private Button look_for_corner() //köşe kontrolü
        {
            Console.WriteLine("Looking for corner");
                                     //ne tür hamle(kazanma or blok) belirlendikten sonra ugun köşülere(butonlara) bakılır
            if (btn_A1.Text == "O") //3lü yapıp kazanmak için satır ve sütunundaki köşeler boş mu diye kontrol edip boş olan köşeyi geri dödürür
            {
                if (btn_A3.Text == "")
                    return btn_A3;
                if (btn_C3.Text == "")
                    return btn_C3;
                if (btn_C1.Text == "")
                    return btn_C1;
            }

            if (btn_A3.Text == "O")
            {
                if (btn_A1.Text == "")
                    return btn_A1;
                if (btn_C3.Text == "")
                    return btn_C3;
                if (btn_C1.Text == "")
                    return btn_C1;
            }

            if (btn_C3.Text == "O")
            {
                if (btn_A1.Text == "")
                    return btn_A1;
                if (btn_A3.Text == "")
                    return btn_A3;
                if (btn_C1.Text == "")
                    return btn_C1;
            }

            if (btn_C1.Text == "O")
            {
                if (btn_A1.Text == "")
                    return btn_A1;
                if (btn_A3.Text == "")
                    return btn_A3;
                if (btn_C3.Text == "")
                    return btn_C3;
            }

            if (btn_A1.Text == "")
                return btn_A1;
            if (btn_A3.Text == "")
                return btn_A3;
            if (btn_C1.Text == "")
                return btn_C1;
            if (btn_C3.Text == "")
                return btn_C3;

            return null;
        }

        private Button look_for_win_or_block(string symbol) //butonlardaki sembol ile bilgisayarın oynayacağı sembolu karşılaştırıp kazanma mı blok hamlesi mi belirlenir ve hangi butona oynaması gerektiği geri döner 
        {
            Console.WriteLine("Looking for win or block : " + symbol);

            //yatay testler
            if ((btn_A1.Text == symbol) && (btn_A2.Text == symbol) && (btn_A3.Text == ""))
                return btn_A3;
            if ((btn_A2.Text == symbol) && (btn_A3.Text == symbol) && (btn_A1.Text == ""))
                return btn_A1;
            if ((btn_A1.Text == symbol) && (btn_A3.Text == symbol) && (btn_A2.Text == ""))
                return btn_A2;

            if ((btn_B1.Text == symbol) && (btn_B2.Text == symbol) && (btn_B3.Text == ""))
                return btn_B3;
            if ((btn_B2.Text == symbol) && (btn_B3.Text == symbol) && (btn_B1.Text == ""))
                return btn_B1;
            if ((btn_B1.Text == symbol) && (btn_B3.Text == symbol) && (btn_B2.Text == ""))
                return btn_B2;

            if ((btn_C1.Text == symbol) && (btn_C2.Text == symbol) && (btn_C3.Text == ""))
                return btn_C3;
            if ((btn_C2.Text == symbol) && (btn_C3.Text == symbol) && (btn_C1.Text == ""))
                return btn_C1;
            if ((btn_C1.Text == symbol) && (btn_C3.Text == symbol) && (btn_C2.Text == ""))
                return btn_C2;

            //dikey testler
            if ((btn_A1.Text == symbol) && (btn_B1.Text == symbol) && (btn_C1.Text == ""))
                return btn_C1;
            if ((btn_B1.Text == symbol) && (btn_C1.Text == symbol) && (btn_A1.Text == ""))
                return btn_A1;
            if ((btn_A1.Text == symbol) && (btn_C1.Text == symbol) && (btn_B1.Text == ""))
                return btn_B1;

            if ((btn_A2.Text == symbol) && (btn_B2.Text == symbol) && (btn_C2.Text == ""))
                return btn_C2;
            if ((btn_B2.Text == symbol) && (btn_C2.Text == symbol) && (btn_A2.Text == ""))
                return btn_A2;
            if ((btn_A2.Text == symbol) && (btn_C2.Text == symbol) && (btn_B2.Text == ""))
                return btn_B2;

            if ((btn_A3.Text == symbol) && (btn_B3.Text == symbol) && (btn_C3.Text == ""))
                return btn_C3;
            if ((btn_B3.Text == symbol) && (btn_C3.Text == symbol) && (btn_A3.Text == ""))
                return btn_A3;
            if ((btn_A3.Text == symbol) && (btn_C3.Text == symbol) && (btn_B3.Text == ""))
                return btn_B3;

            //çapraz testler
            if ((btn_A1.Text == symbol) && (btn_B2.Text == symbol) && (btn_C3.Text == ""))
                return btn_C3;
            if ((btn_B2.Text == symbol) && (btn_C3.Text == symbol) && (btn_A1.Text == ""))
                return btn_A1;
            if ((btn_A1.Text == symbol) && (btn_C3.Text == symbol) && (btn_B2.Text == ""))
                return btn_B2;

            if ((btn_A3.Text == symbol) && (btn_B2.Text == symbol) && (btn_C1.Text == ""))
                return btn_C1;
            if ((btn_B2.Text == symbol) && (btn_C1.Text == symbol) && (btn_A3.Text == ""))
                return btn_A3;
            if ((btn_A3.Text == symbol) && (btn_C1.Text == symbol) && (btn_B2.Text == ""))
                return btn_B2;

            return null;
        }

        private void checkForWinner() //kazananın belirlenmesi
        {
            bool there_is_a_winner = false;

            //yatay olarak kazanan belirlemek için.
            if ((btn_A1.Text == btn_A2.Text) && (btn_A2.Text == btn_A3.Text) && (!btn_A1.Enabled) && (!btn_A2.Enabled) && (!btn_A3.Enabled))
                there_is_a_winner = true;
            else if ((btn_B1.Text == btn_B2.Text) && (btn_B2.Text == btn_B3.Text) && (!btn_B1.Enabled) && (!btn_B2.Enabled) && (!btn_B3.Enabled))
                there_is_a_winner = true;
            else if ((btn_C1.Text == btn_C2.Text) && (btn_C2.Text == btn_C3.Text) && (!btn_C1.Enabled) && (!btn_C2.Enabled) && (!btn_C3.Enabled))
                there_is_a_winner = true;

            //dikey olarak kazanan belirlemek için.
            else if ((btn_A1.Text == btn_B1.Text) && (btn_B1.Text == btn_C1.Text) && (!btn_A1.Enabled) && (!btn_B1.Enabled) && (!btn_C1.Enabled))
                there_is_a_winner = true;
            else if ((btn_A2.Text == btn_B2.Text) && (btn_B2.Text == btn_C2.Text) && (!btn_A2.Enabled) && (!btn_B2.Enabled) && (!btn_C2.Enabled))
                there_is_a_winner = true;
            else if ((btn_A3.Text == btn_B3.Text) && (btn_B3.Text == btn_C3.Text) && (!btn_A3.Enabled) && (!btn_B3.Enabled) && (!btn_C3.Enabled))
                there_is_a_winner = true;

            //çapraz olarak kazanan belirlemek için.
            else if ((btn_A1.Text == btn_B2.Text) && (btn_B2.Text == btn_C3.Text) && (!btn_A1.Enabled) && (!btn_B2.Enabled) && (!btn_C3.Enabled))
                there_is_a_winner = true;
            else if ((btn_A3.Text == btn_B2.Text) && (btn_B2.Text == btn_C1.Text) && (!btn_A3.Enabled) && (!btn_B2.Enabled) && (!btn_C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";

                if (turn)           //son hamle yapıldığında kazanma mesajından once harf değişeceği için O dedik
                {
                    winner = txt_p2.Text;   //yoksa burda X olmalıydı.
                    lbl_owincount.Text = (Int32.Parse(lbl_owincount.Text) + 1).ToString(); //o kazandığında kazanma sayısını 1 arttırmak için
                }
                else
                {
                    winner = txt_p1.Text;
                    lbl_xwincount.Text = (Int32.Parse(lbl_xwincount.Text) + 1).ToString(); //x kazandığında kazanma sayısını 1 arttırmak için
                }
                timer1.Stop();
                timer2.Stop();

                MessageBox.Show(winner + " Wins!", "Congratulations");
            }
            else
            {
                if (turn_count == 9) //tüm kutular dolduğunda kazanan yoksa berabere bitti
                {
                    timer1.Stop();
                    timer2.Stop();
                    if (txt_p2.Text == "Computer")
                    {
                        MessageBox.Show(txt_p2.Text + " Wins!", "Congratulations");
                        lbl_owincount.Text = (Int32.Parse(lbl_owincount.Text) + 1).ToString();
                    }
                    if (zamanPlayer2 < zamanPlayer1)
                    {
                        MessageBox.Show(txt_p1.Text + " Wins!", "Congratulations");
                        lbl_xwincount.Text = (Int32.Parse(lbl_xwincount.Text) + 1).ToString();
                    }
                    else if (zamanPlayer1 < zamanPlayer2)
                    {
                        MessageBox.Show(txt_p2.Text + " Wins!", "Congratulations");
                        lbl_owincount.Text = (Int32.Parse(lbl_owincount.Text) + 1).ToString();
                    }
                }
                    
            }
        }

        private void disableButtons() //oyunu bittiği zaman başka hamle şansı bırakma hepsını false yapmak için
        {
            try
            {
                foreach(Control c in Controls) //tüm butonları kontrol edebilmek için döngü
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
            catch { } //try catch kullanma sebebi menustripten dolayı hata almayı engellemek
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            zamanPlayer1 = 0;
            zamanPlayer2 = 0;
            labelPlayer2.Text = "00";
            labelPlayer1.Text = "00";


            foreach (Control c in Controls) //tüm butonları kontrol edebilmek için döngü
                {
                        try//try catch kullanma sebebi menustripten dolayı hata almayı engellemek
                        {
                        Button button = (Button)c;
                        button.Enabled = true;
                        button.Text = "";
                        }
                        catch { } //try catch içeri fareachın içine yazmamızın sebebi new game dediğimizde hata olmaması için
                }
            }

        private void button_enter(object sender, EventArgs e) //butonların üstüne gelindiğinde aktif oyuncunun hangi harfi oynayabileceği gösterilmesi için
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                if (turn)
                    button.Text = "X";
                else
                    button.Text = "O";
            }
        }

        private void buton_leave(object sender, EventArgs e) //butonların üstünden gidince harf kaybolur ve yeni gittiği kutunun üstünde belirtilir
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                button.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e) //kazanma sayılarını sıfırlamak için
        {
            lbl_xwincount.Text = "0";
            lbl_owincount.Text = "0";
            zamanPlayer1 = 0;
            zamanPlayer2 = 0;
            labelPlayer2.Text = "00";
            labelPlayer1.Text = "00";
        }

        private void txt_p2_TextChanged(object sender, EventArgs e) //2. oyuncu bilgisayar olduğunda
        {
            if (txt_p2.Text.ToUpper() == "COMPUTER") {
                timer1.Stop();
                timer2.Stop();
                against_computer = true;  
            }
            else
                against_computer = false;
        }

        private void setPlayerDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_p1.Text = "Mert";
            txt_p2.Text = "Computer";
            zamanPlayer1 = 0;
            zamanPlayer2 = 0;
            labelPlayer2.Text = "00";
            labelPlayer1.Text = "00";
            lbl_xwincount.Text = "0";
            lbl_owincount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun default olarak bilgisayara karşı moduyla açılır.\nİki kişi oynamak için 'Computer' yerine isminizi yazınız.");
            setPlayerDefaultsToolStripMenuItem.PerformClick(); //form1 yüklenirken bilgisayara karşı şeklini açar otomatik olarak
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_p2.Text != "Computer")
            {
                zamanPlayer1++;
                labelPlayer1.Text = zamanPlayer1.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txt_p2.Text != "Computer")
            {
                zamanPlayer2++;
                labelPlayer2.Text = zamanPlayer2.ToString();
            }
        }
    }
}
