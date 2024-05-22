using System.Windows;
using System.Windows.Controls;

namespace AutoSalon
{
    public partial class EditCar : Window
    {
        private readonly CarDbContext dbContext;
        private readonly Car car;

        public EditCar(Car car)
        {
            InitializeComponent();
            dbContext = new CarDbContext();
            this.car = car;

            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtYear.Text = car.Year.ToString();
            txtPrice.Text = car.Price.ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            car.Make = txtMake.Text;
            car.Model = txtModel.Text;
            car.Year = int.Parse(txtYear.Text);
            car.Price = decimal.Parse(txtPrice.Text);

            dbContext.Cars.Update(car);
            dbContext.SaveChanges();

            Close();
        }
    }
}