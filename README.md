
# A Simple Random User Agents API for C#

With this library, you can generate random user agents that have been curated from different devices and browsers.




## Quick Start

Add the library to your project:
```
dotnet add package UserAgentsGenerator
```


Below is a simple example on how to generate a single random user agent.

```csharp
using Opapps.Lib.UserAgentsGenerator.Services;
using Opapps.Lib.UserAgentsGenerator.Entities;

...

var userAgentsGenerator = new UAGenerator();

UserAgent userAgent = await userAgentsGenerator.GenerateAsync();
Console.WriteLine(userAgent.Content); // Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)
Console.WriteLine(userAgent); // Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)

```

To generate many, unique, randomized user agents:

```csharp
using Opapps.Lib.UserAgentsGenerator.Services;

...
var userAgentsGenerator = new UAGenerator();
int howMany = 5;
List<UserAgent> userAgents = await userAgentsGenerator.GenerateManyAsync(howMany);
Console.WriteLine(userAgents.Count); // 5

```

## Attributions

The list of user agents was taken from this repository: https://gist.github.com/CryptoCloud9/9eec69c26e2999773c6f55cff8a4631d

## License
MIT
