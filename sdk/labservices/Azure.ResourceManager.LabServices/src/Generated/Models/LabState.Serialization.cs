// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class LabStateExtensions
    {
        public static string ToSerialString(this LabState value) => value switch
        {
            LabState.Draft => "Draft",
            LabState.Publishing => "Publishing",
            LabState.Scaling => "Scaling",
            LabState.Syncing => "Syncing",
            LabState.Published => "Published",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabState value.")
        };

        public static LabState ToLabState(this string value)
        {
            if (string.Equals(value, "Draft", StringComparison.InvariantCultureIgnoreCase)) return LabState.Draft;
            if (string.Equals(value, "Publishing", StringComparison.InvariantCultureIgnoreCase)) return LabState.Publishing;
            if (string.Equals(value, "Scaling", StringComparison.InvariantCultureIgnoreCase)) return LabState.Scaling;
            if (string.Equals(value, "Syncing", StringComparison.InvariantCultureIgnoreCase)) return LabState.Syncing;
            if (string.Equals(value, "Published", StringComparison.InvariantCultureIgnoreCase)) return LabState.Published;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabState value.");
        }
    }
}
