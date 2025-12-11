# komikaan-gtfs
Simply put, this is a library with the GTFS datacontracts in .NET without any extra fancyness. While part of an overal bigger project, these are kept up to date for general usage.

The current library by gtfs.org are a bit dissapointing, not up-to-date or are just missing data all over.

The library can be found on [Nuget](https://www.nuget.org/packages/komikaan.GTFS).

This is a part of the [komikaan.nl project](https://github.com/EnessenE/komikaan).

# Usage - realtime + ProtoBuf

Using [protobuf-net](https://github.com/protobuf-net/protobuf-net)
```xml
<ItemGroup>
    <PackageReference Include="protobuf-net" Version="<amodernversion>" />
</ItemGroup>
```
```csharp
using ProtoBuf;

// Assuming we are downloading from an alerts file from an example source
var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com/alerts.pb");

var response = await _httpClient.SendAsync(request);

if (response.IsSuccessStatusCode)
{
    // ProtoBuf doesn't require extensive configuration. It can parse the feed using the schema defined in the Models.Realtime
    FeedMessage feedMessage = Serializer.Deserialize<FeedMessage>(response.Content.ReadAsStream());
    Console.WriteLine("Alert: {countedAlerts}", feedMessage.Entities.Where(entity => entity.Alert != null).Count());
}
```
