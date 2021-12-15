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

namespace chel_pr5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Liquid liquid = new Liquid();
        Liquid liquid2 = new Liquid();
        Beer beer = new Beer();
        private void Create(object sender, RoutedEventArgs e)
        {
            liquid.SetParams(Name.Text, Convert.ToInt32(OBbem.Text), Convert.ToInt32(Plotnost.Text));
            Name1.Text = liquid.Title;
            OBbem1.Text = liquid.Volume.ToString();
            Plotnost1.Text = liquid.Density.ToString();
        }
        private void Creates(object sender, RoutedEventArgs e)
        {
            liquid2.SetParams(Name.Text, Convert.ToInt32(OBbem2.Text), Convert.ToInt32(Plotnost2.Text));
            Name3.Text = liquid2.Title;
            OBbem3.Text = liquid2.Volume.ToString();
            Plotnost3.Text = liquid2.Density.ToString();
        }
        private void Compare(object sender, RoutedEventArgs e)
        {
            if (liquid == liquid2)
            {
                MessageBox.Show("Объемы равны", "Результат", MessageBoxButton.OK);
            }
            else MessageBox.Show("Объемы неравны", "Результат", MessageBoxButton.OK);
        }
        private void Minus(object sender, RoutedEventArgs e)
        {
            liquid--;
            Raznost1.Text = liquid.Volume.ToString();
        }
        private void Minuss(object sender, RoutedEventArgs e)
        {
            liquid2--;
            Raznost2.Text = liquid2.Volume.ToString();
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            liquid++;
            Summa1.Text = liquid.Volume.ToString();
        }
        private void Pluss(object sender, RoutedEventArgs e)
        {
            liquid2++;
            Summa2.Text = liquid2.Volume.ToString();
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Челяев Никита Вариант 14\nПрактическая работа №5\nСоздать класс Liquid (жидкость), имеющий поля названия, плотности и объема. Создать необходимые методы и свойства.Создать перегруженные методы SetParams, для установки параметров жидкости. Сравнение объема. +1 -1 объема.", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void PreviewTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int addvalue))
            {
                e.Handled = true;
            }
        }

        private void Jigul(object sender, RoutedEventArgs e)
        {
            beer.Strength = 5;
            beer.Hops = 7.1;
            beer.Volume = 150;
            beer.Density = 980;
            Strengths.Text = "Крепость = " + beer.Strength.ToString();
            Hop.Text = "% хмеля = " + beer.Hops.ToString();
            Volume.Text = "Объем = " + beer.Volume.ToString();
            Density.Text = "Плотность = " + beer.Density.ToString();
        }

        private void Gold(object sender, RoutedEventArgs e)
        {
            beer.Strength = 4;
            beer.Hops = 5.3;
            beer.Volume = 200;
            beer.Density = 1000;
            Strengths.Text = "Крепость = " + beer.Strength.ToString();
            Hop.Text = "% хмеля = " + beer.Hops.ToString();
            Volume.Text = "Объем = " + beer.Volume.ToString();
            Density.Text = "Плотность = " + beer.Density.ToString();
        }
    }
}
