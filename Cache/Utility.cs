using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Cache
{
    public class Utility
    {
        public static AppCacheHandler appCacheHandler;
        public static string GetLocalisedString(string key, int langId)
        {
            return appCacheHandler.GetTranslation(key, langId);
        }
    }
}
