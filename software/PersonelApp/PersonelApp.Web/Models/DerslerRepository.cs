namespace PersonelApp.Web.Models
{
    public class DerslerRepository
    {
        private static List<DerslerModel> _derslerModel=new List<DerslerModel>();

        //Tüm dersleri çekme
        public List<DerslerModel> GetAll() => _derslerModel;
    }
}
