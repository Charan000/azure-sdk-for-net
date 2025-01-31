// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class RefundBillingInformation
    {
        internal static RefundBillingInformation DeserializeRefundBillingInformation(JsonElement element)
        {
            Optional<ReservationBillingPlan> billingPlan = default;
            Optional<int> completedTransactions = default;
            Optional<int> totalTransactions = default;
            Optional<PurchasePrice> billingCurrencyTotalPaidAmount = default;
            Optional<PurchasePrice> billingCurrencyProratedAmount = default;
            Optional<PurchasePrice> billingCurrencyRemainingCommitmentAmount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingPlan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingPlan = new ReservationBillingPlan(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedTransactions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completedTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalTransactions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotalPaidAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
            }
            return new RefundBillingInformation(Optional.ToNullable(billingPlan), Optional.ToNullable(completedTransactions), Optional.ToNullable(totalTransactions), billingCurrencyTotalPaidAmount.Value, billingCurrencyProratedAmount.Value, billingCurrencyRemainingCommitmentAmount.Value);
        }
    }
}
