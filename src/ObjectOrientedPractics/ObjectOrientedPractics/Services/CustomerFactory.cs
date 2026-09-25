using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        /// <summary>
        /// Максимальное количество покупателей, доступных для генерации (определяется наименьшим размером из списка имён и адресов).
        /// </summary>
        static private int maxCustomersCount;

        /// <summary>
        /// Список полных имён покупателей, загруженных из файла.
        /// </summary>
        static private List<string> _fullnames = new List<string>();

        /// <summary>
        /// Список адрессов покупателей, загруженных из файла.
        /// </summary>
        static private List<Model.Address> _addresses = new List<Model.Address>();

        /// <summary>
        /// Генерирует экземпляр класса <see cref="Model.Customer"/> со случайным именем и адресом из загруженных данных.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Model.Customer"/>.</returns>
        static public Model.Customer GenerateCustomer()
        {
            Random random = new Random();

            int randomCustomer = random.Next(0, maxCustomersCount);

            string newFullname;

            if (_fullnames.Count != 0)
            {
                newFullname = _fullnames[randomCustomer];
            }
            else
            {
                newFullname = "Default fullname";
            }

            int newIndex;
            string newCountry, newCity, newStreet, newBuilding, newApartment;

            if (_addresses.Count != 0)
            {
                newIndex = _addresses[randomCustomer].Index;
                newCountry = _addresses[randomCustomer].Country;
                newCity = _addresses[randomCustomer].City;
                newStreet = _addresses[randomCustomer].Street;
                newBuilding = _addresses[randomCustomer].Building;
                newApartment = _addresses[randomCustomer].Apartment;
            }
            else
            {
                newIndex = 100000;
                newCountry = "Default country";
                newCity = "Default";
                newStreet = "Default street";
                newBuilding = "Default";
                newApartment = "Default";
            }

            Model.Customer newCustomer = new Model.Customer(newFullname, newIndex, newCountry,
            newCity, newStreet, newBuilding, newApartment);

            return newCustomer;
        }

        /// <summary>
        /// Выполняет первичную настройку фабрики покупателей: считает списки имён и адресов из текстовых файлов и рассчитывает <see cref="maxCustomersCount">.
        /// </summary>
        static public void SetUpCustomerFactory()
        {
            StreamReader reader = new StreamReader(PathService.GetProjectRootDir() + "\\Customers Fullnames.json");

            if (reader != null)
            {
                _fullnames = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }
            
            reader.Close();

            reader = new StreamReader(PathService.GetProjectRootDir() + "\\Customers Addresses.json");

            if (reader != null)
            {
                _addresses = JsonConvert.DeserializeObject<List<Model.Address>>(reader.ReadToEnd());
            }
            
            reader.Close();

            if (_fullnames != null && _addresses != null)
            {
                maxCustomersCount = int.Min(_fullnames.Count, _addresses.Count);
            }
            else
            {
                maxCustomersCount = -1;
            }
        }
    }
}
