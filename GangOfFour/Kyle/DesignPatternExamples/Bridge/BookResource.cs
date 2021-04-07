using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class BookResource : IResource
    {
        private readonly Book _book;

        public BookResource(Book book)
        {
            _book = book;
        }

        public string Image()
        {
            return _book.Image;
        }

        public string Snippet()
        {
            return _book.Excerpt;
        }

        public string Title()
        {
            return _book.Title;
        }

        public string Url()
        {
            return _book.Url;
        }
    }
}
