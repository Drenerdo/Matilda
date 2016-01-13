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
            Clothings = new ObservableCollection<ClothingModel>();
            CurrentIndex = -1;
        }

        public ObservableCollection<ClothingModel> Clothings;

        public int CurrentIndex;

        public ClothingModel CurrentClothing
        {
            get
            {
                if(CurrentIndex != -1 && Clothings.Count != 0)
                {
                    return Clothings[CurrentIndex];
                }
                return null;
            }
        }
    }
}
