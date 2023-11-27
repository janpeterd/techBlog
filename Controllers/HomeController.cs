using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using techBlog.Models;
using Contentful.Core;
using Contentful.Core.Models;
using System.Web;

namespace techBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IContentfulClient _client;

    public HomeController(ILogger<HomeController> logger, IContentfulClient client)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var posts = await _client.GetEntries<Post>();
        return View(posts);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PostNotFound()
    {
        return View();
    }
    public async Task<Post> GetPostByTitle(string title)
    {
        var decodedTitle = HttpUtility.UrlDecode(title);
        var entries = await _client.GetEntries<Post>();
        return entries.FirstOrDefault(post => post.Title == title);
    }



    [Route("posts/{title}")]
    public async Task<IActionResult> Post(string title)
    {
        var decodedTitle = HttpUtility.UrlDecode(title);
        var allPosts = await _client.GetEntries<Post>();
        var post = await GetPostByTitle(decodedTitle);
        if (post == null)
        {
            return Redirect("~/Home/PostNotFound");
        }
        ViewBag.allPosts = allPosts;
        return View(post);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}