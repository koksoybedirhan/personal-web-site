namespace PersonelApp.Web.Models
{
    public class HomeRepository
    {
        private static List<HomeModel> _homeModel = new List<HomeModel>();

        //Tüm dersleri çekme
        public List<HomeModel> GetAll() => _homeModel;
    }
}
