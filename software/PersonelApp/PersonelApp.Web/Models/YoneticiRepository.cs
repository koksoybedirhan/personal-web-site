namespace PersonelApp.Web.Models
{
    public class YoneticiRepository
    {
        private static List<YoneticiModel> _yoneticiModel = new List<YoneticiModel>();

        //Tüm dersleri çekme
        public List<YoneticiModel> GetAll() => _yoneticiModel;
    }
}
