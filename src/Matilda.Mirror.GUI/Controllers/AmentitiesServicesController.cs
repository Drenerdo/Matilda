using Matilda.Mirror.GUI.Amentities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Controllers
{
    public class AmentitiesServicesController
    {
    	public ObservableCollection<AmentitiesModel> GetAmentities()
    	{
    		ObservableCollection<AmentitiesModel> Amentities = new ObservableCollection<AmentitiesModel>();
    		Amentities.Add(new AmentitiesModel() 
    		{
    			Name = "Book",
    			Brand = "",
    			Type = AmentitiesType.SHAMPOO,
    			MainPhoto = @"ms-appx:///Resources/Amentities/book.jpg"
    		});

    		Amentities.Add(new AmentitiesModel() 
    		{
    			Name = "",
    			Brand = "",
    			Type = AmentitiesType.SLIPPERS,
    			MainPhoto = @"ms-appx:///Resources/Amentities/book.jpg"
    		});

    		Amentities.Add(new AmentitiesModel() 
    		{
    			Name = "",
    			Brand = "",
    			Type = AmentitiesType.NOTEBOOK,
    			MainPhoto = @"ms-appx:///Resources/Amentities/book.jpg"
    		});

    		Amentities.Add(new AmentitiesModel() 
    		{
    			Name = "",
    			Brand = "",
    			Type = AmentitiesType.HANGERS,
    			MainPhoto = @"ms-appx:///Resources/Amentities/book.jpg"
    		});
    		return Amentities;
    	}
    }
}
