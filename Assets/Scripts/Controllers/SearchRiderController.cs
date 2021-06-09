using WhoIsIt.Models;

namespace WhoIsIt.Controllers
{
    class SearchRiderController
    {
        Championship championship;

        public SearchRiderController()
        {
            championship = new ChampionshipBuilder().Build();
        }

        public Rider Execute(SearchData searchData)
        {
          return championship.SearchRider(searchData);
        }

    }
}
