using CommonLibrary.Classes;
using CommonLibrary.Models;

namespace CommonLibrary.Mocking;
public class MockedOperations
{
    public static string FileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Common1Library.dll");
    private static ApplicationSettings CreateApplicationSettings() =>
        new()
        {
            ServicePath = "X:\\Services",
            DataConfiguration = new DataConfiguration() { DatabaseConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=Master;Integrated Security=True;Encrypt=False" },
            MailSettings = new MailSettings() { FromAddress = "abc@gmail", Host = "SomeHost", Port = 21}
        };

    public static void Serialize()
    {
        List<ApplicationSettings> list = [CreateApplicationSettings()];
        CryptoSerializer<ApplicationSettings> cryptoSerializer = new(Secrets.Key);
        using FileStream fileStream = new(FileName, FileMode.OpenOrCreate);
        cryptoSerializer.Serialize(list, fileStream);
    }

    public static ApplicationSettings Deserialize()
    {
        CryptoSerializer<ApplicationSettings> cryptoSerializer = new(Secrets.Key);
        using FileStream fileStream = new(FileName, FileMode.Open);
        return cryptoSerializer.DeserializeSingle(fileStream);
    }

    /// <summary>
    /// For development only
    /// </summary>
    public static void DeleteFile()
    {
        if (File.Exists(FileName))
        {
            File.Delete(FileName);
        }
    }
}
