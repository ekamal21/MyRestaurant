using System.Collections.Generic;

namespace MyRestaurant.Models.ViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }
        //we chosed string list b/c we need only the name of subcategory
        public List<string> SubCategoryList { get; set; }
        //the string alart if anything went wrong 
        public string StatusMessage { get; set; }
    }
}
