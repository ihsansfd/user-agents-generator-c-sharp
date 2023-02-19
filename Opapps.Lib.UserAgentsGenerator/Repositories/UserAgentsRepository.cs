using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opapps.Lib.UserAgentsGenerator.Helpers
{

    internal static class UploadPaths
    {
        public static readonly string UPLOAD_DIR_PATH = "Uploads";
        public static readonly string USER_AGENTS_LISTS = UPLOAD_DIR_PATH + "/" + "user_agents_list.txt";
    }
    internal class UserAgentsRepository : IUserAgentsRepository
    {
        public async Task<List<string>> GetAllAsync()
        {
            string[] res = await File.ReadAllLinesAsync(UploadPaths.USER_AGENTS_LISTS);

            return new List<string>(res);
        }
    }
}
