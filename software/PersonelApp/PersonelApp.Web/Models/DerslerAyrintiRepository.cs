namespace PersonelApp.Web.Models
{
    public class DerslerAyrintiRepository
    {
        private static List<DerslerAyrintiModel> _derslerAyrintiModel = new List<DerslerAyrintiModel>();

        //Tüm dersleri çekme
        public List<DerslerAyrintiModel> GetAll() => _derslerAyrintiModel;
    }
}
