using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    internal class ProjectSerializer
    {
        /// <summary>
        /// Выполняет десериализацию списка магазина из файла формат JSON.
        /// </summary>
        /// <param name="path">Путь к файлу, содержащему данные о магазине.</param>
        /// <returns>экземпляр магазина в виде объекта <see cref="Store"/></returns>
        static public Store DeserializeJsonStoreFile(string path)
        {
            string StoreJsonText = File.ReadAllText(PathService.GetProjectRootDir() + path);

            Model.Store store = JsonConvert.DeserializeObject<Model.Store>(StoreJsonText);

            return store;
        }

        /// <summary>
        /// Сериализует экземпляр магазина в формат JSON и сохраняет его в указанный файл.
        /// </summary>
        /// <param name="customers">Экземпляр покупателя <see cref="Store"/> для сохранения.</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные.</param>
        static public void SerializeJsonStoreFile(Model.Store store, string path)
        {
            string jsonStore = JsonConvert.SerializeObject(store);

            File.WriteAllText(PathService.GetProjectRootDir() + path, jsonStore);
        }
    }
}
