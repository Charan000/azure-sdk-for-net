// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This does not change the overall billing, only how it will be distributed. Default value is &apos;Cluster&apos;. </summary>
    public readonly partial struct BillingType : IEquatable<BillingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClusterValue = "Cluster";
        private const string WorkspacesValue = "Workspaces";

        /// <summary> Cluster. </summary>
        public static BillingType Cluster { get; } = new BillingType(ClusterValue);
        /// <summary> Workspaces. </summary>
        public static BillingType Workspaces { get; } = new BillingType(WorkspacesValue);
        /// <summary> Determines if two <see cref="BillingType"/> values are the same. </summary>
        public static bool operator ==(BillingType left, BillingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingType"/> values are not the same. </summary>
        public static bool operator !=(BillingType left, BillingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BillingType"/>. </summary>
        public static implicit operator BillingType(string value) => new BillingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
