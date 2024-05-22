using System.Windows;
using System.Windows.Controls;

namespace AutoSalon
{
    public partial class AddCar : Window
    {
        private readonly CarDbContext dbContext;

        public AddCar()
        {
            InitializeComponent();
            dbContext = new CarDbContext();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var car = new Car
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                Year = int.Parse(txtYear.Text),
                Price = decimal.Parse(txtPrice.Text)
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();

            Close();
        }
    }
}