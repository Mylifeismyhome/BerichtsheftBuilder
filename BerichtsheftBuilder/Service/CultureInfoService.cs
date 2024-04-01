using System;
using System.Globalization;

namespace BerichtsheftBuilder.Service
{
    public class CultureInfoService
    {
        private CultureInfo cultureInfo;
        public CultureInfo CultureInfo
        {
            get => cultureInfo;
        }

        public CultureInfoService()
        {
            cultureInfo = new CultureInfo("de-DE");
        }

        public string dateFormat(DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy", cultureInfo);
        }

        public string dateTimeFormat(DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy HH:mm:ss", cultureInfo);
        }
    }
}
