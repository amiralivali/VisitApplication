using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class ExeptionService
    {
        public async Task InsertAsync(Exception ex)
        {
            await ex.AddLogAsync();
        }
    }
}
