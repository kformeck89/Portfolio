using System.Collections.Generic;

namespace Portfolio.Models
{
    public class PortfolioModalModel
    {
        public PortfolioModalModel(string id, string galleryId, string title, List<string> imagePathList)
        {
            Id = id;
            GalleryId = galleryId;
            Title = title;
            ImagePathList = imagePathList;
        }
        public string Id { get; private set; }
        public string GalleryId { get; private set;}
        public string Title { get; private set; }
        public List<string> ImagePathList { get; private set; }
    }
}