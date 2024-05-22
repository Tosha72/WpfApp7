using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoSalon
{
    public partial class MainWindow : Window
    {
        private readonly CarDbContext dbContext;

        public MainWindow()
        {
            InitializeComponent();
            dbContext = new CarDbContext();

            dgCars.ItemsSource = dbContext.Cars.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addCarWindow = new AddCar();
            addCarWindow.ShowDialog();

            dgCars.ItemsSource = dbContext.Cars.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgCars.SelectedItem is Car car)
            {
                var editCarWindow = new EditCar(car);
                editCarWindow.ShowDialog();

                dgCars.ItemsSource = dbContext.Cars.ToList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgCars.SelectedItem is Car car)
            {
                var deleteCarWindow = new DeleteCar(car);
                deleteCarWindow.ShowDialog();

                dgCars.ItemsSource = dbContext.Cars.ToList();
            }
        }
    }
}