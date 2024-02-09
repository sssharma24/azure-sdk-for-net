// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ExchangeResultProperties : IUtf8JsonSerializable, IJsonModel<ExchangeResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExchangeResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExchangeResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(NetPayable))
            {
                writer.WritePropertyName("netPayable"u8);
                writer.WriteObjectValue(NetPayable);
            }
            if (Optional.IsDefined(RefundsTotal))
            {
                writer.WritePropertyName("refundsTotal"u8);
                writer.WriteObjectValue(RefundsTotal);
            }
            if (Optional.IsDefined(PurchasesTotal))
            {
                writer.WritePropertyName("purchasesTotal"u8);
                writer.WriteObjectValue(PurchasesTotal);
            }
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyResult))
            {
                writer.WritePropertyName("policyResult"u8);
                writer.WriteObjectValue(PolicyResult);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ExchangeResultProperties IJsonModel<ExchangeResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExchangeResultProperties(document.RootElement, options);
        }

        internal static ExchangeResultProperties DeserializeExchangeResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> sessionId = default;
            Optional<PurchasePrice> netPayable = default;
            Optional<PurchasePrice> refundsTotal = default;
            Optional<PurchasePrice> purchasesTotal = default;
            Optional<IReadOnlyList<ReservationToPurchaseExchange>> reservationsToPurchase = default;
            Optional<IReadOnlyList<SavingsPlanToPurchaseExchange>> savingsPlansToPurchase = default;
            Optional<IReadOnlyList<ReservationToReturnForExchange>> reservationsToExchange = default;
            Optional<ExchangePolicyErrors> policyResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("netPayable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    netPayable = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("refundsTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refundsTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("purchasesTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchasesTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToPurchaseExchange> array = new List<ReservationToPurchaseExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToPurchaseExchange.DeserializeReservationToPurchaseExchange(item));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanToPurchaseExchange> array = new List<SavingsPlanToPurchaseExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanToPurchaseExchange.DeserializeSavingsPlanToPurchaseExchange(item));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToReturnForExchange> array = new List<ReservationToReturnForExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToReturnForExchange.DeserializeReservationToReturnForExchange(item));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (property.NameEquals("policyResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyResult = ExchangePolicyErrors.DeserializeExchangePolicyErrors(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExchangeResultProperties(Optional.ToNullable(sessionId), netPayable.Value, refundsTotal.Value, purchasesTotal.Value, Optional.ToList(reservationsToPurchase), Optional.ToList(savingsPlansToPurchase), Optional.ToList(reservationsToExchange), policyResult.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExchangeResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support '{options.Format}' format.");
            }
        }

        ExchangeResultProperties IPersistableModel<ExchangeResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExchangeResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExchangeResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
