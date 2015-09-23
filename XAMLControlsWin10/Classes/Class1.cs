using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLControlsWin10.Classes
{
    public class Class1
    {

        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }

        public Class1()
        {
            List<Class1> persons = new List<Class1>();
            Image = "ms-appx:///Assets/IMG_0802.JPG";
            Name = "Mohamed Emam";
            Occupation = "Developer";
            Age = 21;
            
        }
    }
}
