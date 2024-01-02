using System.Text.Json.Serialization;
using System.Text.Json;

namespace CommonLibrary.JsonConverters;
/*
 * See JsonHelpers class for the right way
 */
public class QuotedDecimalConverter : JsonConverter<decimal>
{
    public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return Convert.ToDecimal(reader.GetString(), System.Globalization.CultureInfo.GetCultureInfo("en"));
        }
        else
        {
            return reader.GetInt32();
        }
    }

    public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

}