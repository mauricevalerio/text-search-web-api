namespace TextSearchWebAPI.Models;
public class TextSearch
{
    public string Sentence { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public bool IsFullWordSearch { get; set; }
    public bool IsCaseSensitive { get; set; }
}
