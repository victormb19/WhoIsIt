namespace WhoIsIt.Views
{
    interface IViewVisitor
    {
       void Visit(MainView mainView);
       void Visit(RiderView riderView);
    }
}
