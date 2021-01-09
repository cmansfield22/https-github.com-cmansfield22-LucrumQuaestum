using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class AlpacaKeyProcessor
    {
        public static int UpdateAlpacaKeys(string userID, string liveApiKey, string liveApiSecretKey, string paperApiKey, string paperApiSecretKey)
        {
            AlpacaKeyModel data = new AlpacaKeyModel
            {
                UserID = userID,
                LiveApiKey = liveApiKey,
                LiveApiSecretKey = liveApiSecretKey,
                PaperApiKey = paperApiKey,
                PaperApiSecretKey = paperApiSecretKey
            };

            string sql = @"update users set LiveApiKey = @LiveApiKey,
                                            LiveApiSecretKey = @LiveApiSecretKey,
                                            PaperApiKey = @PaperApiKey,
                                            PaperApiSecretKey = @PaperApiSecretKey
                                            where Id=@UserID;";


            return MySqlDataAccess.SaveData(sql, data);
        }

        public static List<AlpacaKeyModel> LoadAlpacaKeys(string userID)
        {
            string sql = $"select LiveApiKey, LiveApiSecretKey, PaperApiKey, PaperApiSecretKey from users where Id='{userID}';";


            return MySqlDataAccess.LoadData<AlpacaKeyModel>(sql);
        }
    }
}
