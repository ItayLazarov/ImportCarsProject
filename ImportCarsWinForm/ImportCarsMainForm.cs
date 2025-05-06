using ImportCarsWinForm.Models;
using ImportCarsWinForm.Services;

namespace ImportCarsWinForm
{
    public partial class ImportCarsMainForm : Form
    {
        private readonly CarsService _carsService;

        private readonly List<Car> _addedCars;

        public ImportCarsMainForm()
        {
            _addedCars = new List<Car>();
            _carsService = new CarsService();

            InitializeComponent();
        }

        private void CarSearchButton_Click(object sender, EventArgs e)
        {
            OpenSearchCarForm();
        }

        private void SaveCarDetailsButton_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                CompanyName = companyNameTextBox.Text,
                CompanyHp = companyNumberTextBox.Text,
                Date = DateTime.Now
            };

            _carsService.SaveOrderDetails(order);

            foreach (var addedCar in _addedCars)
            {
                _carsService.SaveCarDetails(car: addedCar, companyName: order.CompanyName, companyNumber: order.CompanyHp);
            }

            _carsService.CreateCarsOrderXmlFile();

            MessageBox.Show(text: "Create CarsOrder XML file.", caption: null, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            _addedCars.Add(new Car
            {
                CarNumber = carNumberTextBox.Text,
                Model = carModelTextBox.Text,
                Color = carColorTextBox.Text
            });

            MessageBox.Show(text: "Car details saved successfully.", caption: null, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

            carNumberTextBox.Clear();
            carModelTextBox.Clear();
            carColorTextBox.Clear();
        }

        private void OpenSearchCarForm()
        {
            try
            {
                using (SearchCarForm searchCarForm = new SearchCarForm())
                {
                    this.Hide();

                    var dialogResult = searchCarForm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (InvalidOperationException ioe)
            {
                ShowError(errorMessage: $"Invalid Operation Exception - {ioe.Message} \nPlease close the program and try again.");
            }
            catch (Exception ex)
            {
                ShowError(errorMessage: $"General Exception - {ex.Message} \nPlease close the program and try again.");
            }
        }

        private static void ShowError(string errorMessage)
        {
            MessageBox.Show(text: errorMessage, caption: null, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
        }

        private void ReadOrderFromFileButton_Click(object sender, EventArgs e)
        {
            _carsService.ReadCarsOrderDetails();
        }
    }
}
