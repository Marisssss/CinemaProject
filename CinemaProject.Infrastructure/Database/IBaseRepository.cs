using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Infrastructure.Database
{
    internal interface IBaseRepository
    {
        CinemaEntity GetById(long id);
        List<CinemaEntity> GetList();

    }
}
