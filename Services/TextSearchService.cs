using System.Text.RegularExpressions;
using TextSearchWebAPI.Models;

namespace TextSearchWebAPI.Services;
public class TextSearchService : ITextSearchService
{
    public int CountMatch(TextSearch textSearch)
    {

        MatchCollection matches;

        textSearch.Text = Regex.Escape(textSearch.Text);

        if (textSearch.IsFullWordSearch && textSearch.IsCaseSensitive)
        {
            matches = Regex.Matches(textSearch.Sentence, $@"(?<=^|\s){textSearch.Text}(?=\s|$)");
        }
        else if (textSearch.IsFullWordSearch)
        {
            matches = Regex.Matches(textSearch.Sentence, $@"(?<=^|\s){textSearch.Text}(?=\s|$)", RegexOptions.IgnoreCase);
        }
        else if (textSearch.IsCaseSensitive)
        {
            matches = Regex.Matches(textSearch.Sentence, textSearch.Text);
        }
        else
        {
            matches = Regex.Matches(textSearch.Sentence, textSearch.Text, RegexOptions.IgnoreCase);
        }

        return matches.Count;
    }
}
