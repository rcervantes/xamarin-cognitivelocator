﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CognitiveLocator.Interfaces;
using CognitiveLocator.Pages;
using Xamarin.Forms;

namespace CognitiveLocator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LoadAppConfiguration();
            MainPage = new LoginPage();
        }

        private void LoadAppConfiguration()
        {
            List<Task> tasks = new List<Task>();
            Task startup = Task.Run(async() => { 

                //set startup akavache
                Akavache.BlobCache.ApplicationName = nameof(SettingsType.CognitiveLocator);

                //set startup settings
                await Settings.Initialize();

                //set startup app configuration
                await Settings.Set<string>(SettingsType.CognitiveLocator, "CognitiveLocator");
                await Settings.Set<string>(SettingsType.FunctionURL, "https://YOUR_AZURE_FUNCTION.azurewebsites.net");
                await Settings.Set<string>(SettingsType.CryptographyKey, "YOUR_CRYPT_KEY");

                //set startup language configuration
                string language = Settings.Language;

                if (string.IsNullOrEmpty(language))
                {
                    language = "en-US";
                    await Settings.Set<string>(SettingsType.Language, language);
                }

                //initialize multi-culture
                DependencyService.Get<ILocalizeService>().Set(language);

                //initialize Azure Mobile App
                DependencyService.Get<IMobileAppService>().Initialize();

            });
            tasks.Add(startup);
            Task.WaitAll(tasks.ToArray());
        }

        public static void ProceedToHome()
        {
            Application.Current.MainPage = new NavigationPage(new HomePage());
        }
    }
}