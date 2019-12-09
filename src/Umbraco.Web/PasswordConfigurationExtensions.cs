﻿using System.Collections.Generic;
using Umbraco.Core.Configuration;
using Umbraco.Core.Security;
using Umbraco.Core.Services;

namespace Umbraco.Web
{
    internal static class PasswordConfigurationExtensions
    {
        /// <summary>
        /// Returns the configuration of the membership provider used to configure change password editors
        /// </summary>
        /// <param name="passwordConfiguration"></param>
        /// <param name="userService"></param>
        /// <returns></returns>
        public static IDictionary<string, object> GetConfiguration(
            this IPasswordConfiguration passwordConfiguration,
            bool allowManuallyChangingPassword = false)
        {
            return new Dictionary<string, object>
                {
                    {"minPasswordLength", passwordConfiguration.RequiredLength},

                    // TODO: This doesn't make a ton of sense with asp.net identity and also there's a bunch of other settings
                    // that we can consider with IPasswordConfiguration, but these are currently still based on how membership providers worked.
                    {"minNonAlphaNumericChars", passwordConfiguration.RequireNonLetterOrDigit ? 2 : 0},

                    // A flag to indicate if the current password box should be shown or not, only a user that has access to change other user/member passwords
                    // doesn't have to specify the current password for the user/member. A user changing their own password must specify their current password.
                    {"allowManuallyChangingPassword", allowManuallyChangingPassword},
                };
        }

    }
}