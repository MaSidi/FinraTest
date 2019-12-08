using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Data
{
   public class GenreRepository : Repository<Genre>,IGenreRepository    
    {

        public GenreRepository(MoveShopDbContext dbContext) :base(dbContext)
        {
            
        }



    }

  
}
