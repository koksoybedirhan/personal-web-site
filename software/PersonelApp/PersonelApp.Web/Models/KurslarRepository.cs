namespace PersonelApp.Web.Models
{
    public class KurslarRepository
    {
        private static List<KurslarModel> _kurslarModel = new List<KurslarModel>();

        //Tüm dersleri çekme
        public List<KurslarModel> GetAll() => _kurslarModel;
    }
}
