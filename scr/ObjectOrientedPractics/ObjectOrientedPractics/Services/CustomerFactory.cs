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
        static private List<string> _addresses = new List<string>();

        /// <summary>
        /// Генерирует экземпляр класса <see cref="Model.Customer"/> со случайным именем и адресом из загруженных данных.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Model.Customer"/>.</returns>
        static public Model.Customer GenerateCustomer()
        {
            Random random = new Random();

            int randomCustomer = random.Next(0, maxCustomersCount);

            string newName = _fullnames[randomCustomer];

            string newInfo = _addresses[randomCustomer];

            Model.Customer newCustomer = new Model.Customer(newName, newInfo);

            return newCustomer;
        }

        /// <summary>
        /// Выполняет первичную настройку фабрики покупателей: считает списки имён и адресов из текстовых файлов и рассчитывает <see cref="maxCustomersCount">.
        /// </summary>
        static public void SetUpCustomerFactory()
        {
            StreamReader reader = new StreamReader("C:\\Users\\greft\\source\\repos\\Programming\\scr\\ObjectOrientedPractics\\ObjectOrientedPractics\\bin\\Debug\\net10.0-windows\\Customers Fullnames.txt");

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                _fullnames.Add(line);
            }

            reader.Close();

            reader = new StreamReader("C:\\Users\\greft\\source\\repos\\Programming\\scr\\ObjectOrientedPractics\\ObjectOrientedPractics\\bin\\Debug\\net10.0-windows\\Customers Addresses.txt");

            while ((line = reader.ReadLine()) != null)
            {
                _addresses.Add(line);
            }

            reader.Close();

            maxCustomersCount = int.Min(_fullnames.Count, _addresses.Count);
        }
    }
}
