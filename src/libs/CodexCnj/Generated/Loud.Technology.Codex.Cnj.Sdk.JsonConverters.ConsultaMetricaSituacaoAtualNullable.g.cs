#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConsultaMetricaSituacaoAtualNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual?>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtualExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtualExtensions.ToValueString(value.Value));
            }
        }
    }
}
