namespace WhoIsIt.Models
{
    class Championship
    {
        Category[] categories;

        public Championship(Category[] categories)
        {
            this.categories = categories;
        }

        public Rider SearchRider(SearchData search)
        {
            return categories[(int)search.GetCategory()].FindRider(search.GetNumber());
        }
    }
}
