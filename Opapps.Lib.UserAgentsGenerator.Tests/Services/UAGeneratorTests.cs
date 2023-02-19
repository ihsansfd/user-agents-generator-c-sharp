using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string res = await _userAgentsGenerator.GenerateAsync();
            Assert.NotNull(res);
        }
        
        [Fact]
        public async Task GenerateManyAsync_WhenCalled_ReturnUniqueRandomizedUserAgents()
        {
            List<string> res = await _userAgentsGenerator.GenerateManyAsync(5);
            Assert.NotNull(res);
            Assert.True(res.Distinct().Count() == res.Count());
        }

    }
}
