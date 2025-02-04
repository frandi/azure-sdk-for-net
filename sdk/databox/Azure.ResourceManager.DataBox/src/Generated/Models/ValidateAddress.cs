// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The requirements to validate customer address where the device needs to be shipped. </summary>
    public partial class ValidateAddress : ValidationInputRequest
    {
        /// <summary> Initializes a new instance of ValidateAddress. </summary>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shippingAddress"/> is null. </exception>
        public ValidateAddress(ShippingAddress shippingAddress, DataBoxSkuName deviceType)
        {
            if (shippingAddress == null)
            {
                throw new ArgumentNullException(nameof(shippingAddress));
            }

            ShippingAddress = shippingAddress;
            DeviceType = deviceType;
            ValidationType = ValidationInputDiscriminator.ValidateAddress;
        }

        /// <summary> Shipping address of the customer. </summary>
        public ShippingAddress ShippingAddress { get; }
        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
        /// <summary> Preferences related to the shipment logistics of the sku. </summary>
        internal TransportPreferences TransportPreferences { get; set; }
        /// <summary> Indicates Shipment Logistics type that the customer preferred. </summary>
        public TransportShipmentType? TransportPreferencesPreferredShipmentType
        {
            get => TransportPreferences is null ? default(TransportShipmentType?) : TransportPreferences.PreferredShipmentType;
            set
            {
                TransportPreferences = value.HasValue ? new TransportPreferences(value.Value) : null;
            }
        }
    }
}
