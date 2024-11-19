using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutSystems.ExternalLibraries.SDK;

namespace MarkdownToHTML
{
    /// <summary>
    /// Version 1.0
    /// Helper extension for JSON. Allows you to manipulate and parse JSON using JSONPath.
    /// Uses the Newtonsoft.Json library (https://www.newtonsoft.com/json)
    /// </summary>
    [OSInterface(Description = "Version 0.1.0\r\n\r\nWrapper code for the Markdig .Net Library. Markdig is a fast, powerful, CommonMark compliant, extensible Markdown processor for .NET. (https://github.com/xoofx/markdig)", IconResourceName = "MarkdownToHtml.resources.markdig.png", Name = "MarkdownToHTML")]
    internal interface IMarkdownToHTML
    {
        /// <summary>
        /// Converts Markdown content into HTML
        /// </summary>
        [OSAction(Description = "Converts Markdown content into HTML", IconResourceName = "MarkdownToHtml.resources.markdig.png", ReturnName = "HTML_Content")]
        public string MarkdownToHTML(
            [OSParameter(Description = "The Markdown content to be converted")]
            string MarkdownContent);

    }

}