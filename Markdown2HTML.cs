using Markdig;
namespace MarkdownToHTML
{
    public class Markdown2HTML : IMarkdownToHTML
    {
        public string MarkdownToHTML(string MarkdownContent)
        {
          return Markdown.ToHtml(MarkdownContent);
        }
    }
}