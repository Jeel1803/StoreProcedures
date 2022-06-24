using PartB_StoreProcedures.Models;
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

namespace PartB_StoreProcedures
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

        private void top5Button_Click(object sender, RoutedEventArgs e)
        {
            outputGrid.ItemsSource = DAO.GetTop5RentedTrucks();
        }

        private void least5Button_Click(object sender, RoutedEventArgs e)
        {
            
            outputGrid.ItemsSource = DAO.GetLeast5RentedTrucks();

        }



        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (monthSelection.SelectedIndex == -1 || string.IsNullOrEmpty(yearTextBox.Text))
            {
                MessageBox.Show("Please Enter Month and Year");
            }
            else 
            { 
                int month = int.Parse(monthSelection.Text);
                int year = int.Parse(yearTextBox.Text);
                outputGrid.ItemsSource = DAO.GetRentalSaleByMonth(month, year);
        }
          
        }

        private void searchButton1_Click(object sender, RoutedEventArgs e)
        {

            if(startDate.SelectedDate == null || endDate.SelectedDate == null || string.IsNullOrEmpty(modelTextBox.Text))
            {
                MessageBox.Show("Please provide all required inputs");
            }
            else { 
            DateTime start = startDate.SelectedDate.Value;
            DateTime end = endDate.SelectedDate.Value;
            string model = modelTextBox.Text;
            outputGrid.ItemsSource = DAO.GetTrucksBetweenDates(model, start, end);
            }
        }
    }
    }

