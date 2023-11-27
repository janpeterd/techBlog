using Contentful.Core.Models;

namespace techBlog.Models;

public class Post
{
    public string Title { get; set; } = "Temporary title";
    public Document? Body { get; set; }
    public Asset? Image { get; set; }
    // https://www.contentful.com/developers/docs/net/tutorials/rich-text/
    public SystemProperties Sys { get; set; } // Fix the typo here
}
