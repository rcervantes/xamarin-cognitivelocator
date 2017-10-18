﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveLocator.Functions
{
    public class Settings
    {
        public static string AzureWebJobsStorage = Environment.GetEnvironmentVariable("AzureWebJobsStorage");

        public static string FaceAPIKey = Environment.GetEnvironmentVariable("Vision_API_Subscription_Key");
        public static string PersonGroupId = Environment.GetEnvironmentVariable("Vision_API_PersonGroupId");
        public static string Zone = Environment.GetEnvironmentVariable("Vision_API_Zone");
        public static string FaceListId = Environment.GetEnvironmentVariable("Vision_API_FaceList");

        public static string DocumentDB = Environment.GetEnvironmentVariable("CosmosDB_URI");
        public static string DocumentDBAuthKey = Environment.GetEnvironmentVariable("CosmosDB_AuthKey");
        public static string DatabaseId = Environment.GetEnvironmentVariable("CosmosDB_DatabaseId");
        public static string CollectionId = Environment.GetEnvironmentVariable("CosmosDB_Collection");

        public static string NotificationAccessSignature = Environment.GetEnvironmentVariable("NotificationHub_Access_Signature");
        public static string NotificationHubName = Environment.GetEnvironmentVariable("NotificationHub_Name");
        
         public static string CryptographyKey = Environment.GetEnvironmentVariable("Cryptography_Key");
    }
}
