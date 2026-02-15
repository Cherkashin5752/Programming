using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Rectangle
    {
        private double length;
        private double width;
        private string color { get; set; }

        private double Length
        {
            get { return length; }
            set
            { 
                if (length < 0)
                    throw new ArgumentException();
                length = value;
            }
        }

        private double Width
        {
            get { return width; }
            set
            {
                if (width < 0)
                    throw new ArgumentException();
                width = value;
            }
        }
    }
}
