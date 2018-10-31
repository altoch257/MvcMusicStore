using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{

    public class MusicStoreDBInitializer : DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Donnie McClurkin" });
            context.Genres.Add(new Genre { Name = "Gospel" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Ray Charles" },
                Genre = new Genre { Name = "Soul" },
                Price = 9.99m,
                Title = "Genius Loves Company"
            });

            base.Seed(context);
        }
    }
}