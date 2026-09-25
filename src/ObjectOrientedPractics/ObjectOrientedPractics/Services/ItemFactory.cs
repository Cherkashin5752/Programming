using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        /// <summary>
        /// Максимальное количество товаров, доступных для генерации (определяется наименьшим размером из списка названий и описаний).
        /// </summary>
        static private int maxItemsCount;

        /// <summary>
        /// Список названий покупателей, загруженных из файла.
        /// </summary>
        static private List<string> _names = new List<string>();

        /// <summary>
        /// Список описаний покупателей, загруженных из файла.
        /// </summary>
        static private List<string> _info = new List<string>();

        /// <summary>
        /// Генерирует экземпляр класса <see cref="Model.Item"/> со случайным название и описанием из загруженных данных.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Model.Item"/>.</returns>
        static public Model.Item GenerateItem()
        {
            Random random = new Random();

            int randomItem = random.Next(0, maxItemsCount);

            string newName = _names[randomItem];

            string newInfo = _info[randomItem];

            int newCost = random.Next(0, 100000);

            ProductCategory newCategory = (ProductCategory)random.Next(1, 8);

            Model.Item newItem = new Model.Item(newName, newInfo, newCost, newCategory);

            return newItem;
        }

        /// <summary>
        /// Выполняет первичную настройку фабрики товаров: считает списки названий и описаний из текстовых файлов и рассчитывает <see cref="maxItemsCount">.
        /// </summary>
        static public void SetUpItemFactory()
        {
            StreamReader reader = new StreamReader(PathService.GetProjectRootDir() + "\\Items Names.json");

            if (reader != null)
            {
                _names = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }

            reader.Close();

            reader = new StreamReader(PathService.GetProjectRootDir() + "\\Items Info.json");

            if (reader != null)
            {
                _info = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }

            reader.Close();

            maxItemsCount = int.Min(_names.Count, _info.Count);
        }
    }
}