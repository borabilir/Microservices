using UI.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Helpers
{
    public class PhotoHelper
    {
        private readonly ServiceApiSettings _serviceApiSettings;

        public PhotoHelper(IOptions<ServiceApiSettings> serviceApiSettings)
        {
            _serviceApiSettings = serviceApiSettings.Value;
        }

        public string GetPhotoStockUrl(string photoUrl)
        {
            return $"{_serviceApiSettings.PhotoStockUri}/photos/{photoUrl}";
        }
    }
}