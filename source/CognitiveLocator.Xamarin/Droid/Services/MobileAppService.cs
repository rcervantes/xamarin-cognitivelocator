﻿using CognitiveLocator.Droid.Services;
using CognitiveLocator.Interfaces;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(MobileAppService))]
namespace CognitiveLocator.Droid.Services
{
    public class MobileAppService:IMobileAppService
    {
        public void Initialize()
        {
            //create the client instance, using the mobile app backend URL.
            MainActivity.MobileClient = new MobileServiceClient(Settings.FunctionURL);
        }
    }
}