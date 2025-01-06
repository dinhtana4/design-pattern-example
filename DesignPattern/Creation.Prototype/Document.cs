using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.Prototype
{
    public class Document : IPrototype<Document>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Document(string title, string content, string author )
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public Document Clone()
        {
            return new Document( Title, Content, Author );
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
