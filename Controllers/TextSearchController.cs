using Microsoft.AspNetCore.Mvc;
using TextSearchWebAPI.Models;
using TextSearchWebAPI.Services;

namespace TextSearchWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TextSearchController : ControllerBase
{
    private readonly ITextSearchService _textSearchService;
    public TextSearchController(ITextSearchService textSearchService)
    {
        _textSearchService = textSearchService;
    }

    [HttpPost]
    public ActionResult<int> Post(TextSearch textSearch)
    {
        if (String.IsNullOrEmpty(textSearch.Sentence) || String.IsNullOrEmpty(textSearch.Text))
        {
            return BadRequest();
        }
        return Ok(_textSearchService.CountMatch(textSearch));
    }
}