using TextSearchWebAPI.Models;

namespace TextSearchWebAPI.Services;
public interface ITextSearchService
{
    public int CountMatch(TextSearch textSearch);
}

