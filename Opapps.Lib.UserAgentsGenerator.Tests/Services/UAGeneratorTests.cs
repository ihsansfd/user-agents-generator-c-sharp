using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opapps.Lib.UserAgentsGenerator.Entities;
using Opapps.Lib.UserAgentsGenerator.Services;

namespace Opapps.Lib.UserAgentsGenerator.Tests.Services
{
    public class UAGeneratorTests
    {
        private readonly UAGenerator _userAgentsGenerator;

        public UAGeneratorTests()
        {
            _userAgentsGenerator = new UAGenerator();
        }
        [Fact]
        public async Task GenerateAsync_WhenCalled_ReturnRandomizedUserAgent()
        {

            UserAgent res = await _userAgentsGenerator.GenerateAsync();
            Assert.NotNull(res.Content);
        }
        
        [Fact]
        public async Task GenerateManyAsync_WhenCalled_ReturnUniqueRandomizedUserAgents()
        {
            int howMany = 5;
            List<UserAgent> res = await _userAgentsGenerator.GenerateManyAsync(howMany);
            Assert.NotNull(res);
            Assert.True(res.Distinct().Count() == res.Count);
            Assert.True(howMany == res.Count);
        }

    }
}
