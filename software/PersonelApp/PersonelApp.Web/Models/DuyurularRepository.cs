namespace PersonelApp.Web.Models
{
    public class DuyurularRepository
    {
        private static List<DuyurularModel> _duyurularModel = new List<DuyurularModel>();

        //Tüm dersleri çekme
        public List<DuyurularModel> GetAll() => _duyurularModel;
    }
}
