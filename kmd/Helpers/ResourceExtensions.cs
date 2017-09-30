﻿using Windows.ApplicationModel.Resources;

namespace kmd.Helpers
{
    internal static class ResourceExtensions
    {
        private static readonly ResourceLoader _resLoader = new ResourceLoader();

        public static string GetLocalized(this string resourceKey)
        {
            var localizedString = _resLoader.GetString(resourceKey);
            if (string.IsNullOrEmpty(localizedString))
            {
                return resourceKey;
            }
            else
            {
                return localizedString;
            }
        }
    }
}