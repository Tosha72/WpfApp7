using System.Windows;
using System.Windows.Controls;

namespace AutoSalon
{
    public partial class DeleteCar : Window
    {
        private readonly CarDbContext dbContext;
        private readonly Car car;

        public DeleteCar(Car car)
        {
            InitializeComponent();
            dbContext = new CarDbContext();
            this.car = car;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Cars.Remove(car);
            dbContext.SaveChanges();

            Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}