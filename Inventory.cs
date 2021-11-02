using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace GameInventory
{
    class Inventory : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public Dictionary<(int row, int column), (int count, Item item)> ItemPosition { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
