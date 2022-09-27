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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.TBzn.PreviewTextInput += new TextCompositionEventHandler(TBzn_PreviewTextInput);
            this.TBvost.PreviewTextInput += new TextCompositionEventHandler(TBzn_PreviewTextInput);
        }

        private void CBGoroscop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBGoroscop.SelectedIndex)
            {
                case 0:
                    TBOtvet.Text = "";
                    TBzn.Text = "";
                    CBMes.Text = "";
                    TBzn.Visibility = Visibility.Visible;
                    CBMes.Visibility = Visibility.Visible;
                    TBvost.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    TBOtvet.Text = "";
                    TBvost.Text = "";
                    TBzn.Visibility = Visibility.Collapsed;
                    CBMes.Visibility = Visibility.Collapsed;
                    TBvost.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void CBMes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            switch (CBMes.SelectedIndex)
            {
                case 0:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В январе только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 1:
                    if (int.Parse(TBzn.Text) > 28 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В феврале только 28 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 2:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В марте только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 3:
                    if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В апреле только 30 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 4:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В мае только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 5:
                    if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В июне только 30 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 6:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В июле только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 7:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В августе только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 8:
                    if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В сентябре только 30 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 9:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В октябре только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 10:
                    if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В ноябре только 30 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
                case 11:
                    if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                    {
                        MessageBox.Show("В декабре только 31 день.\nПовторите ввод");
                        TBzn.Text = "";
                    }
                    else
                        MessageBox.Show("Вы успешно ввели данные");
                    break;
              

            }
        }

      
        private void TBzn_PreviewTextInput(object sender, TextCompositionEventArgs e) //Ограничение на ввод только чисел 
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    
        private void TBvost_PreviewTextInput(object sender, TextCompositionEventArgs e)//Ограничение на ввод только чисел 
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
