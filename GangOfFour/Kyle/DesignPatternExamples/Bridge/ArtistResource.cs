using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ArtistResource : IResource
    {
        private readonly Artist _artist;

        public ArtistResource(Artist artist)
        {
            _artist = artist;
        }

        public string Image()
        {
            return _artist.Image;
        }

        public string Snippet()
        {
            return _artist.Bio;
        }

        public string Title()
        {
            return _artist.Name;
        }

        public string Url()
        {
            return _artist.Url;
        }
    }
}
