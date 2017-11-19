using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiRunRater
{
    public class SkiRunBusiness : IDisposable, ISkiRunRepository
    {
        ISkiRunRepository _skiRunRepository;

        public SkiRunBusiness(ISkiRunRepository repository){
            _skiRunRepository = repository;
        }

        public void Insert(SkiRun skiRun)
        {
            _skiRunRepository.Insert(skiRun);
        }

        public void Delete(int ID)
        {
            _skiRunRepository.Delete(ID);
        }

        public void Update(SkiRun skiRun)
        {
            _skiRunRepository.Update(skiRun);
        }

        public SkiRun SelectById(int id)
        {
            return _skiRunRepository.SelectById(id);
        }

        public void Save()
        {
            _skiRunRepository.Save();
        }

        public List<SkiRun> QueryByVertical(int minVal, int maxVal)
        {
            List<SkiRun> skiRuns = _skiRunRepository.SelectAll();

            return skiRuns.Where(s => s.Vertical >= minVal && s.Vertical <= maxVal).ToList();
        }

        public void Dispose()
        {
            _skiRunRepository = null;
        }
    }
}
