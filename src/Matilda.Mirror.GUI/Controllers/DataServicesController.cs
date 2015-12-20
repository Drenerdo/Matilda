﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Matilda.Mirror.GUI.Closet;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Controllers
{
    public class DataServicesController
    {
        public ObservableCollection<ClothingModel> GetClothings()
        {
            ObservableCollection<ClothingModel> Clothings = new ObservableCollection<ClothingModel>();
            Clothings.Add(new ClothingModel()
            {
                Refid = "",
                Brand = "",
                Price = 229,
                Unit = PriceUnit.USD,
                Type = ClothingType.DRESS,
                Sizes = new List<Size> { Size.small, Size.large, Size.xlarge },
                MainPhoto = @"..\Resources\Images\p1.jpg"
            });

            Clothings.Add(new ClothingModel()
            {
                Refid = "",
                Brand = "",
                Price = 229,
                Unit = PriceUnit.USD,
                Type = ClothingType.DRESS,
                Sizes = new List<Size> { Size.small, Size.large, Size.xlarge },
                MainPhoto = @"..\Resources\Images\p1.jpg"
            });

            Clothings.Add(new ClothingModel()
            {
                Refid = "",
                Brand = "",
                Price = 229,
                Unit = PriceUnit.USD,
                Type = ClothingType.DRESS,
                Sizes = new List<Size> { Size.small, Size.large, Size.xlarge },
                MainPhoto = @"..\Resources\Images\p1.jpg"
            });

            Clothings.Add(new ClothingModel()
            {
                Refid = "",
                Brand = "",
                Price = 229,
                Unit = PriceUnit.USD,
                Type = ClothingType.LADYWEAR,
                Sizes = new List<Size> { Size.small, Size.large, Size.xlarge },
                MainPhoto = @"..\Resources\Images\p1.jpg"
            });
            return Clothings;
        }
    }
}