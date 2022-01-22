using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork24
{
    //класс-хранилище общих данных, доступных везде

    class Data
    {
        public static ObservableCollection<Worker> Workers = new ObservableCollection<Worker>();
        public static ObservableCollection<Worker> TimeWork = new ObservableCollection<Worker>();
        

    }
}
