using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class TakhasosService
    {
        TakhasosRepository takhasosRepository;
        public TakhasosService()
        {
            takhasosRepository = new TakhasosRepository();
        }
        public async Task<OprationResult<List<TakhasosInfo>>> SelectAsync()
        {
            var takhasoses = await takhasosRepository.SelectAsync();
            if (takhasoses != null)
            {
                return OprationResult<List<TakhasosInfo>>.Success(takhasoses);
            }
            else
            {
                return OprationResult<List<TakhasosInfo>>.RunTimeError();
            }
        }
        public async Task<OprationResult> InsertAsync(Doctor_TakhasosInfo takhasos)
        {
            var doctorTakhasos = takhasos.MapToDoctorTakhasos();
            var check = await takhasosRepository.InsertAsync(doctorTakhasos);
            if (check)
            {
                return OprationResult.Success(Messages.Takhasos);
            }
            else
            { 
                return OprationResult.RunTimeError();
            }
        }
    }
}
