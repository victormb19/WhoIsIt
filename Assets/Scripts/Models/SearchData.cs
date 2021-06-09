
namespace WhoIsIt.Models
{
    struct SearchData
    {
        CategoryName categoryName;
        int number;

        public SearchData(CategoryName categoryName, int number)
        {
            this.categoryName = categoryName;
            this.number = number;
        }

        public CategoryName GetCategory()
        {
            return categoryName;
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
