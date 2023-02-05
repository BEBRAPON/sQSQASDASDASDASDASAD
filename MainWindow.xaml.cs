using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace sQSQASDASDASDASDASAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Button> buts = new List<Button>();
        private int step = 1;
        private string let = "X";
        private string let2 = "0";
        private string let3 = "0";
        public MainWindow()
        {
            InitializeComponent();
            ZapolnenLista();
        }
        private void ZapolnenLista()
        {
            buts.Add(b1);
            buts.Add(b2);
            buts.Add(b3);
            buts.Add(b4);
            buts.Add(b5);
            buts.Add(b6);
            buts.Add(b7);
            buts.Add(b8);
            buts.Add(b9);
        }
        private void bstart_Click(object sender, RoutedEventArgs e)
        {

            bstart.IsEnabled = false;
            foreach (Button b in buts)
            {
                b.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (step != 0)
            {
                if (step == 1)
                {
                    sender.GetType().GetProperty("Content").SetValue(sender, let);
                    sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
                    buts.Remove(sender as Button);
                    step = 2; ;
                    winCheck();
                }
                if (step == 2 && bstart.IsEnabled == false)
                {
                    RandomClick();
                    step = 1;
                    winCheck();
                }
            }

        }

        private void RandomClick()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, buts.Count);
            buts[x].IsEnabled = false;
            buts[x].Content = let2;
            buts.RemoveAt(x);
        }

        private void winCheck()
        {

            if (b1.Content == "X" && b1.Content == b2.Content && b2.Content == b3.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b4.Content == "X" && b4.Content == b5.Content && b5.Content == b6.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b7.Content == "X" && b7.Content == b8.Content && b8.Content == b9.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b1.Content == "X" && b1.Content == b4.Content && b4.Content == b7.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b2.Content == "X" && b2.Content == b5.Content && b5.Content == b8.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b3.Content == "X" && b3.Content == b6.Content && b6.Content == b9.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b1.Content == "X" && b1.Content == b5.Content && b5.Content == b9.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }
            if (b3.Content == "X" && b3.Content == b5.Content && b5.Content == b7.Content)
            {
                t1.Text = "Победили крестики";
                Restart();
            }


            if (b1.Content == "0" && b1.Content == b2.Content && b2.Content == b3.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b4.Content == "0" && b4.Content == b5.Content && b5.Content == b6.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b7.Content == "0" && b7.Content == b8.Content && b8.Content == b9.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b1.Content == "0" && b1.Content == b4.Content && b4.Content == b7.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b2.Content == "0" && b2.Content == b5.Content && b5.Content == b8.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b3.Content == "0" && b3.Content == b6.Content && b6.Content == b9.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b1.Content == "0" && b1.Content == b5.Content && b5.Content == b9.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }
            if (b3.Content == "0" && b3.Content == b5.Content && b5.Content == b7.Content)
            {
                t1.Text = "Победили нолики";
                Restart();
            }


            if (buts.Count == 0)
            {
                t1.Text = "Ничья";
                Restart();
            }
        }

        private void Restart()
        {
            bstart.IsEnabled = true;
            ZapolnenLista();
            foreach (Button b in buts)
            {
                b.Content = "";
                b.IsEnabled = false;
            }
            let3 = let;
            let = let2;
            let2 = let3;
        }
    }
}
