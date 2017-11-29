﻿using Apex.System;

namespace Apex.ApexSharp
{
    using SalesForceAPI;
    using SalesForceAPI.ApexApi;

    public class Soql
    {
        public static SoqlQuery<T> Query<T>(string soql, params object[] parameters)
        {
            return SoqlApi.Query<T>(soql, parameters);
        }

        public static SoqlQuery<T> Query<T>(string soql)
        {
            return SoqlApi.Query<T>(soql);
        }

        public static void Insert<T>(T sObject) where T : SObject
        {
            SoqlApi.Insert(sObject);
        }

        public static void Update<T>(T sObject) where T : SObject
        {
            SoqlApi.Update(sObject);
        }

        public static void Update<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Update(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static void Delete<T>(T sObject) where T : SObject
        {
            SoqlApi.Delete(sObject);
        }

        public static void Delete<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Delete(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }
    }
}