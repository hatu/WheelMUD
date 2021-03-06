﻿
namespace WheelMUD.Utilities
{
    using System;
    using System.Collections.Generic;

    public static class PropertyTools
    {
        public static void SetProperties(object o, IDictionary<string, object> propertyDictionary)
        {
            Type t = o.GetType();

            var properties = t.GetProperties();
            foreach (var property in properties)
            {
                string key = property.Name;
                if (propertyDictionary.ContainsKey(key))
                {
                    var v = propertyDictionary[key];
                    property.SetValue(o, v, null);
                }
            }
        }

        public static void BagProperties(object o, IDictionary<string, object> propertyDictionary)
        {
            Type t = o.GetType();

            var properties = t.GetProperties();
            foreach (var property in properties)
            {
                string key = property.Name;
                object value = property.GetValue(o, null);

                propertyDictionary.Add(key, value);
            }
        }
    }
}
