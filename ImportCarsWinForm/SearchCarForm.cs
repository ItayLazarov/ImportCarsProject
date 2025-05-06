using ImportCarsWinForm.Services;

namespace ImportCarsWinForm
{
    public partial class SearchCarForm : Form
    {
        private readonly CarsService _carsService;

        public SearchCarForm()
        {
            _carsService = new CarsService();

            InitializeComponent();
        }

        private void SearchCarButton_Click(object sender, EventArgs e)
        {
            var searchedCar = _carsService.GetCarDetails(carNumber: searchCarNumberTextBox.Text);

            if(searchedCar is null)
            {
                MessageBox.Show($"Car with the car number: {searchCarNumberTextBox.Text} was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(text: $"Car Number: {searchedCar.CarNumber} \nModel: {searchedCar.Model} \nColor: {searchedCar.Color}", caption: null, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
}
