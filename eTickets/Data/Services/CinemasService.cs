using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {


        public CinemasService(AppDBContext context) : base(context)
        {
            
        }
    }
}
