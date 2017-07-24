﻿using System;

namespace SalesForceAPI.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ObjectNameAttribute : System.Attribute
    {
        public ObjectNameAttribute(string salesForceObjectName)
        {
            SalesForceObjectName = salesForceObjectName;
        }

        public string SalesForceObjectName { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class FieldType : System.Attribute
    {
        public FieldType(string fieldLengthAttribute)
        {
            FieldLengthAttribute = fieldLengthAttribute;
        }

        public string FieldLengthAttribute { get; set; }
    }
}