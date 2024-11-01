namespace PersonelApp.Web.Models
{
    public class BlogRepository
    {
        private static List<BlogModel> _blogModel = new List<BlogModel>();

        //Tüm dersleri çekme
        public List<BlogModel> GetAll() => _blogModel;

        public void Select(string id)
        {
            var hasBlog = _blogModel.FirstOrDefault(x => "x.Id" == id);
        }
    }
}
