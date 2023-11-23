using CinemaProject.Infrastructure.Mappers;
using CinemaProject.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Infrastructure.Database
{
    public class CinemaRepository
    {
        public List<CinemaViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Cinemas.ToList();
                return CinemaMapper.Map(items);
            }
        }
        public CinemaViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Cinemas.FirstOrDefault(x => x.IdCinema == id);
                return CinemaMapper.Map(item);
            }
        }

    }
}
