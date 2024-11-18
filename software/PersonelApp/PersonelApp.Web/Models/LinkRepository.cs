namespace PersonelApp.Web.Models
{
    public class LinkRepository
    {
        private static List<LinkModel> _linkModel = new List<LinkModel>();

        //Tüm dersleri çekme
        public List<LinkModel> GetAll() => _linkModel;
    }
}
