using CinemaProject.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Infrastructure.Mappers
{
    public static class CinemaMapper
    {
        public static CinemaViewModel Map(CinemaEntity entity)
        {
            var viewModel = new CinemaViewModel
            {
                IdCinema = entity.IdCinema,
                Address = entity.Address,
                NameCinema = entity.NameCinema,
            };
            return viewModel;
        }

        public static List<CinemaViewModel> Map(List<CinemaEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }

}
