using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class VisitService
    {
        VisitRepository visitRepository;
        public VisitService()
        {
            visitRepository = new VisitRepository();
        }
        public async Task<OprationResult<List<VisitDto>>> SelectAsync(int id,string search)
        {
            var visits = await visitRepository.SelectAsync(id, search);
            if (visits != null)
            {
                return OprationResult<List<VisitDto>>.Success(visits);
            }
            else
            {
                return OprationResult<List<VisitDto>>.RunTimeError();
            }
        }
        public async Task<OprationResult> InsertAsync(VisitInfo info)
        { 
            var visit = info.MapToVisit();
            var result = await visitRepository.InsertAsync(visit);
            if (result)
            {
                return OprationResult.Success(Messages.Visit);
            }
            else
            { 
                return OprationResult.RunTimeError();
            }
        }
    }
}
