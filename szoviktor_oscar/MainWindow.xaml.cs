using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szoviktor_oscar
{

    public partial class MainWindow : Window
    {
        List<Oscar> lista = new List<Oscar>();
        public MainWindow()
        {
            InitializeComponent();
            var sr = new StreamReader("../../../src/oscar.csv", System.Text.Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Oscar(sr.ReadLine()));
            }

            foreach (var item in lista.OrderByDescending(item => item.Ev))
            {
                lbxFilmek.Items.Add($"{item.Ev}, {item.FilmCime}");
            }

        }

        private void BtnUjFilm_Click(object sender, RoutedEventArgs e)
        {
            var sw = new StreamWriter("../../../src/oscar.csv", true);
            if (UjCim.Text != null && UjDij.Text != null && UjEv.Text != null && UjJeloles.Text != null)
            {
                sw.WriteLine($"{UjCim.Text} \t {UjEv.Text} \t {UjJeloles} \t {UjDij}");
                MessageBox.Show("Sikeres felvitel!");
            }
            else
            {
                MessageBox.Show("Hibás adatfelvitel!");
            }
        }
    }
}