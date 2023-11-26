namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
        object SaveImage(object imageFile);
    }
}