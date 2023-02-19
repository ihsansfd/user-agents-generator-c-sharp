
# A Simple Random User Agents API for C#

With this library, you can generate random user agents that have been curated from different devices and browsers.




## Quick Start

Below is a simple example on how to generate a single random user agent.

```csharp
using Opapps.Lib.UserAgentsGenerator.Services;

...

var userAgentsGenerator = new UAGenerator();

string res = await userAgentsGenerator.GenerateAsync();
Console.WriteLine(res) // Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)

```

To generate many, unique, randomized user agents:

```csharp
using Opapps.Lib.UserAgentsGenerator.Services;

...

int howMany = 5;
List<string> res = await _userAgentsGenerator.GenerateManyAsync(howMany);
Console.WriteLine(res.Count) // 5

```

## Attributions

The list of user agents was taken from this repository: https://gist.github.com/CryptoCloud9/9eec69c26e2999773c6f55cff8a4631d
