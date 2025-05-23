﻿using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace IsYonetimSistemi
{
    
    public class SettingsHelper
    {
        private IConfigurationRoot _configuration;
        public SettingsHelper()
        {
            try
            {
                var builder = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory);

                
                if (File.Exists("appsettings.json"))
                {
                    builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                }
                else if (File.Exists("appsettings.example.json"))
                {
                    builder.AddJsonFile("appsettings.example.json", optional: false, reloadOnChange: true);
                }
                else
                {
                    throw new FileNotFoundException("appsettings.json veya appsettings.example.json dosyası bulunamadı.");
                }

                _configuration = builder.Build();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ayar dosyası yüklenemedi: {ex.Message}");
            }
        }

        public string apiAl() => _configuration?["WeatherAPI:api"] ?? "";
        public string urlAl() => _configuration?["WeatherAPI:url"] ?? "";
        public string sehirAl() => _configuration?["WeatherAPI:sehir"] ?? "";
    }
}
