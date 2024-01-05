#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using ProtoBuf;

namespace CommonLibrary.Models;

[ProtoContract]
public class ApplicationSettings
{
    [ProtoMember(1)]
    public string ServicePath { get; set; }
    [ProtoMember(2)]
    public MailSettings MailSettings { get; set; }
    [ProtoMember(3)]
    public DataConfiguration DataConfiguration { get; set; }
}
[ProtoContract]
public class MailSettings
{
    [ProtoMember(1)]
    public string FromAddress { get; set; }
    [ProtoMember(2)]
    public string Host { get; set; }
    [ProtoMember(3)]
    public int? Port { get; set; }
}
[ProtoContract]
public class DataConfiguration
{
    [ProtoMember(1)]
    public string DatabaseConnection { get; set; }
}
