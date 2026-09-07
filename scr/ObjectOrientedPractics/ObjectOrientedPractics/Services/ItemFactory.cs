using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        static private int maxItemsCount;

        static private List<string> _names = new List<string>();

        static private List<string> _info = new List<string>();

        static public Model.Item GenerateItem()
        {
            Random random = new Random();

            int randomItem = random.Next(0, maxItemsCount);

            string newName = _names[randomItem];

            string newInfo = _info[randomItem];

            int newCost = random.Next(0, 100000);

            Model.Item newItem = new Model.Item(newName, newInfo, newCost);

            return newItem;
        }

        static public void SetUpItemFactory()
        {
            StreamReader reader = new StreamReader("C:\\Users\\greft\\source\\repos\\Programming\\scr\\ObjectOrientedPractics\\ObjectOrientedPractics\\bin\\Debug\\net10.0-windows\\Items Names.txt");

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                _names.Add(line);
            }

            reader.Close();

            reader = new StreamReader("C:\\Users\\greft\\source\\repos\\Programming\\scr\\ObjectOrientedPractics\\ObjectOrientedPractics\\bin\\Debug\\net10.0-windows\\Items Info.txt");

            while ((line = reader.ReadLine()) != null)
            {
                _info.Add(line);
            }

            reader.Close();

            maxItemsCount = int.Min(_names.Count, _info.Count);
        }
    }
}