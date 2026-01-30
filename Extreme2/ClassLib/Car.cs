using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Car
    {
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Модель")]
        public string Model { get; set; }
        [DisplayName("Год выпуска")]
        public int Year { get; set; }
    }
}
