// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownCodec))]
    public partial class MediaCodecBase : IUtf8JsonSerializable, IJsonModel<MediaCodecBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaCodecBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaCodecBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaCodecBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        MediaCodecBase IJsonModel<MediaCodecBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaCodecBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaCodecBase(document.RootElement, options);
        }

        internal static MediaCodecBase DeserializeMediaCodecBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AacAudio": return AacAudio.DeserializeAacAudio(element, options);
                    case "#Microsoft.Media.Audio": return MediaAudioBase.DeserializeMediaAudioBase(element, options);
                    case "#Microsoft.Media.CopyAudio": return CodecCopyAudio.DeserializeCodecCopyAudio(element, options);
                    case "#Microsoft.Media.CopyVideo": return CodecCopyVideo.DeserializeCodecCopyVideo(element, options);
                    case "#Microsoft.Media.DDAudio": return DDAudio.DeserializeDDAudio(element, options);
                    case "#Microsoft.Media.H264Video": return H264Video.DeserializeH264Video(element, options);
                    case "#Microsoft.Media.H265Video": return H265Video.DeserializeH265Video(element, options);
                    case "#Microsoft.Media.Image": return MediaImageBase.DeserializeMediaImageBase(element, options);
                    case "#Microsoft.Media.JpgImage": return JpgImage.DeserializeJpgImage(element, options);
                    case "#Microsoft.Media.PngImage": return PngImage.DeserializePngImage(element, options);
                    case "#Microsoft.Media.Video": return MediaVideoBase.DeserializeMediaVideoBase(element, options);
                }
            }
            return UnknownCodec.DeserializeUnknownCodec(element, options);
        }

        BinaryData IPersistableModel<MediaCodecBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaCodecBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{options.Format}' format.");
            }
        }

        MediaCodecBase IPersistableModel<MediaCodecBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaCodecBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaCodecBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaCodecBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
