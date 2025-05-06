using ImportCarsWinForm.Data;
using ImportCarsWinForm.Models;
using System.Xml;
using System.Xml.Linq;

namespace ImportCarsWinForm.Services
{
    public class CarsService
    {
        public void SaveCarDetails(Car car, string companyName, string companyNumber)
        {
            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                var createdOrder = carsTestDbContext.Orders.First(x => x.CompanyName == companyName &&
                                                                       x.CompanyHp == companyNumber);

                car.OrderId = createdOrder.Id;

                //Save Car Details
                carsTestDbContext.Cars.Add(car);

                carsTestDbContext.SaveChanges();
            }
        }

        public void SaveOrderDetails(Order order)
        {
            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                //Save Order Details
                carsTestDbContext.Orders.Add(order);

                carsTestDbContext.SaveChanges();
            }
        }

        public Car? GetCarDetails(string carNumber)
        {
            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                return carsTestDbContext.Cars.FirstOrDefault(x => x.CarNumber == carNumber);
            }
        }

        public Order? GetOrderDetails(string orderId)
        {
            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                return carsTestDbContext.Orders.FirstOrDefault(x => x.Id.ToString() == orderId);
            }
        }

        public void ReadCarsOrderDetails()
        {
            string carsXmlFilePath = Path.Combine(Environment.CurrentDirectory, "XML Files", "CarsRequestFeedback.xml");

            XmlDocument xmlDocument = new XmlDocument();

            Feedback feedback = new Feedback();

            Order order = new Order();

            List<Car> cars = new List<Car>();

            int orderId = 0;

            xmlDocument.Load(carsXmlFilePath);

            XmlNodeList orderResponseXmlNodeList = xmlDocument.GetElementsByTagName("OrderResponse");

            foreach (XmlNode xmlNode in orderResponseXmlNodeList)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    switch (childNode.Name)
                    {
                        case "Order":
                            orderId = int.Parse(childNode.InnerText);
                            feedback.OrderId = orderId;
                            break;

                        case "CompanyHp":
                            order.CompanyHp = childNode.InnerText;
                            break;

                        case "FeedbackDate":
                            feedback.FeedbackDate = DateTime.ParseExact(childNode.InnerText, format: "dd-MM-yyyyTHH:mm", provider: null);
                            break;

                        case "FeedbackType":
                            feedback.FeedbackType = childNode.InnerText;
                            break;

                        case "Comment":
                            feedback.Comment = childNode.InnerText;
                            order.Comment = childNode.InnerText;
                            break;

                        case "Cars":
                            foreach (XmlNode carNode in childNode.ChildNodes)
                            {
                                switch (carNode.Name)
                                {
                                    case "Car":
                                        foreach (XmlNode carChildNode in carNode.ChildNodes)
                                        {
                                            switch (carChildNode.Name)
                                            {
                                                case "CarNumber":
                                                    cars.Add(new Car { CarNumber = carChildNode.InnerText, OrderId = orderId });
                                                    break;
                                            }
                                        }

                                    break;
                                }
                            }

                            break;
                    }
                }
            }

            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                //Save Feedback Details
                carsTestDbContext.Feedbacks.Add(feedback);


                //Save Car Details
                carsTestDbContext.Cars.AddRange(cars);


                //Save Order Details
                carsTestDbContext.Orders.Add(order);

                carsTestDbContext.SaveChanges();
            }
        }

        public void CreateCarsOrderXmlFile()
        {
            using (CarsTestContext carsTestDbContext = new CarsTestContext())
            {
                Car createdCar1 = carsTestDbContext.Cars.First(x => x.Id == 1);

                Car createdCar2 = carsTestDbContext.Cars.First(x => x.Id == 2);

                Order createdOrder = carsTestDbContext.Orders.First(x => x.Id == createdCar1.OrderId);

                XDocument xDocument = new XDocument(
                new XElement("transmission",
                    new XElement("OrderRequest",
                        new XElement("OrderID", createdOrder.Id),
                        new XElement("OrderDate", createdOrder.Date!.Value.Date.ToString("dd/MM/yyyy"),
                        new XElement("OrderDescription",
                            new XElement("CompanyHp", createdOrder.CompanyHp),
                            new XElement("Cars",
                                new XElement("Car",
                                    new XElement("CarNumber", createdCar1.CarNumber),
                                    new XElement("CarModel", createdCar1.Model),
                                    new XElement("CarColor", createdCar1.Color)),
                                new XElement("Car",
                                    new XElement("CarNumber", createdCar2.CarNumber),
                                    new XElement("CarModel", createdCar2.Model),
                                    new XElement("CarColor", createdCar2.Color))))))));

                if (Directory.Exists(Path.Combine(Environment.CurrentDirectory, "Xml Files")) == false)
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "Xml Files"));
                }

                string carsXmlFilePath = Path.Combine(Environment.CurrentDirectory, "XML Files", "OrderedCars.xml");

                File.WriteAllText(path: carsXmlFilePath, contents: xDocument.ToString());
            }
        }
    }
}
