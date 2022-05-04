﻿using Authgear.Xamarin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Authgear.Xamarin
{
    [JsonConverter(typeof(JsonDescriptionEnumConverter<JwtHeaderType>))]
    internal enum JwtHeaderType
    {
        [Description("vnd.authgear.anonymous-request")]
        Anonymous,
        [Description("vnd.authgear.biometric-request")]
        Biometric
    }
}
