using CoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Cache
{
    public class AppCacheHandler
    {
        public CacheService cacheService;
        public AppCacheHandler appCacheHandler;
        public CoreDBContext _coreDBContext;
        public string TranslationsKey { get; set; }

        public AppCacheHandler(CoreDBContext coreDBContext)
        {
             cacheService = new CacheService();
            TranslationsKey = "trans";
            //  appCacheHandler = new AppCacheHandler();
            _coreDBContext = coreDBContext;
        }
        public  void LoadTranslations()
        {
           
            List<string> countryCodes="en|us".Split('|').ToList();
            List<TranslationViewModel> result = new List<TranslationViewModel>();
            foreach (var c in countryCodes)
            {
              
                result.AddRange(GetAllWebTranslations());
            }

            cacheService.Set(TranslationsKey, result.Distinct().ToList(), 1440);
        }
        public List<TranslationViewModel> GetAllWebTranslations()
        {
            return _coreDBContext.TranslationViewModel.ToList();
        }
         public  string GetTranslation(string key, int langId)
        {
            if (!cacheService.IsSet(TranslationsKey))
            {
                LoadTranslations();
            }

            List<TranslationViewModel> result = (List<TranslationViewModel>)cacheService.Get(TranslationsKey);
            var data = result.Where(a => a.Key.ToLower().Trim().Equals(key.ToLower().Trim()) && a.LanguageId == langId).FirstOrDefault();
            return data != null ? data.Value.Replace("'","\\'").Replace("\"", "\\\"") : key;
        }
    }
}
