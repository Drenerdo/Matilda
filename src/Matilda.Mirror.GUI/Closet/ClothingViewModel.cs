using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Closet
{
    public class ClothingViewModel
    {
        public ClothingViewModel()
        {
            Clothings = new ObservableCollection<Clothing>();
            CurrentIndex = -1;
        }

        public ObservableCollection<Clothing> Clothings;

        public int CurrentIndex;

        public Clothing CurrentClothing
        {
            get
            {
                if (CurrentIndex != -1 && Clothings.Count != 0)
                {
                    return Clothings[CurrentIndex];
                }
                return null;
            }
        }
    }
}
