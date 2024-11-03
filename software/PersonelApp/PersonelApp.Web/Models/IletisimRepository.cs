namespace PersonelApp.Web.Models
{
    public class IletisimRepository
    {
        private static List<IletisimModel> _iletisimModel = new List<IletisimModel>();

        //Tüm dersleri çekme
        public List<IletisimModel> GetAll() => _iletisimModel;
    }
}
