// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Name of the stage. </summary>
    public readonly partial struct NotificationStageName : IEquatable<NotificationStageName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NotificationStageName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationStageName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DevicePreparedValue = "DevicePrepared";
        private const string DispatchedValue = "Dispatched";
        private const string DeliveredValue = "Delivered";
        private const string PickedUpValue = "PickedUp";
        private const string AtAzureDCValue = "AtAzureDC";
        private const string DataCopyValue = "DataCopy";
        private const string CreatedValue = "Created";
        private const string ShippedToCustomerValue = "ShippedToCustomer";

        /// <summary> Notification at device prepared stage. </summary>
        public static NotificationStageName DevicePrepared { get; } = new NotificationStageName(DevicePreparedValue);
        /// <summary> Notification at device dispatched stage. </summary>
        public static NotificationStageName Dispatched { get; } = new NotificationStageName(DispatchedValue);
        /// <summary> Notification at device delivered stage. </summary>
        public static NotificationStageName Delivered { get; } = new NotificationStageName(DeliveredValue);
        /// <summary> Notification at device picked up from user stage. </summary>
        public static NotificationStageName PickedUp { get; } = new NotificationStageName(PickedUpValue);
        /// <summary> Notification at device received at Azure datacenter stage. </summary>
        public static NotificationStageName AtAzureDC { get; } = new NotificationStageName(AtAzureDCValue);
        /// <summary> Notification at data copy started stage. </summary>
        public static NotificationStageName DataCopy { get; } = new NotificationStageName(DataCopyValue);
        /// <summary> Notification at job created stage. </summary>
        public static NotificationStageName Created { get; } = new NotificationStageName(CreatedValue);
        /// <summary> Notification at shipped devices to customer stage. </summary>
        public static NotificationStageName ShippedToCustomer { get; } = new NotificationStageName(ShippedToCustomerValue);
        /// <summary> Determines if two <see cref="NotificationStageName"/> values are the same. </summary>
        public static bool operator ==(NotificationStageName left, NotificationStageName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationStageName"/> values are not the same. </summary>
        public static bool operator !=(NotificationStageName left, NotificationStageName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationStageName"/>. </summary>
        public static implicit operator NotificationStageName(string value) => new NotificationStageName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationStageName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationStageName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
