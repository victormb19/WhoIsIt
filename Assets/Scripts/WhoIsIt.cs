using UnityEngine;
using WhoIsIt.Views;

namespace WhoIsIt
{
    class WhoIsIt: MonoBehaviour, IViewVisitor
    {
        [SerializeField]
        private MainView mainView;

        [SerializeField]
        private RiderView riderView;

        private void Awake()
        {
            mainView.Initialize(this);
            riderView.Initialize(this);

            mainView.EnableView();
            riderView.DisableView();
        }

        public void Visit(MainView mainView) 
        { 
            mainView.DisableView();
            riderView.EnableView();
            riderView.Draw(mainView.GetSearchData());
        }

        public void Visit(RiderView riderView)
        {
            riderView.DisableView();
            mainView.EnableView();
        }
    }
}
