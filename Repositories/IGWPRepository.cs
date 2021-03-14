using System.Collections.Generic;
using System.Threading.Tasks;
using Galytix.WebApi.Models;

namespace Galytix.WebApi.Repositories
{
    public interface IGWPRepository
    {
        Task<List<GWPData>> GetGWPData(Input input);
    }
}