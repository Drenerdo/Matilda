using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Amentities
{
    public class AmentitiesViewModel
    {
        public AmentitiesViewModel()
        {
            Amentities = new ObservableCollection<AmentitiesModel>();
            CurrentIndex = -1;
        }

        public ObservableCollection<AmentitiesModel> Amentities;

        public int CurrentIndex;

        public AmentitiesModel CurrentAmentities
        {
            get
            {
                if(CurrentIndex != -1 && Amentities.Count != 0)
                {
                    return Amentities[CurrentIndex];
                }
                return null;
            }
        }
    }
}
