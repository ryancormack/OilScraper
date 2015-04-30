using OilScraper.Domain.Repository;

namespace OilScraper.Domain.Service
{
    public interface IOilService {
        void InsertOilRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth);
    }

    public class OilService : IOilService {

        private readonly IOilRepository _oilRepository;

        public OilService(IOilRepository oilRepository) {
            _oilRepository = oilRepository;
        }

        public void InsertOilRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth) {
            _oilRepository.InsertRig(rigName, manager, rigType, ratedWaterDepth, drillingDepth);
        }
    }
}
