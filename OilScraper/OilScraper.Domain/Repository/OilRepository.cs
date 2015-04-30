using System.Data.SqlClient;
using Dapper;

namespace OilScraper.Domain.Repository
{
    public interface IOilRepository {
        void InsertRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth);
    }

    public class OilRepository : IOilRepository {
        public void InsertRig(string rigName, string manager, string rigType, string ratedWaterDepth, string drillingDepth) {
            using (var sqlConnection = new SqlConnection(DapperContext.Constant.DatabaseConnection)) {

                sqlConnection.Open();
                var addNewData = "INSERT INTO rig_info " +
                    "VALUES (getdate(), " + "'" + rigName + "', " + "'" + manager + "', " + "'" + rigType + "'" + "'" + drillingDepth + ")";
                sqlConnection.Execute(addNewData);
            }

        }
    }
}
