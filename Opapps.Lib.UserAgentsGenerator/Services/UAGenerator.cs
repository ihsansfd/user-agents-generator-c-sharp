using Opapps.Lib.UserAgentsGenerator.Entities;
using Opapps.Lib.UserAgentsGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opapps.Lib.UserAgentsGenerator.Services
{
    /// <summary>
    /// Generate user agent(s) from different devices and browsers!
    /// </summary>
    public class UAGenerator
    {
        private IUserAgentsRepository _repository = new UserAgentsRepository();
        private readonly RandomHelper<string> _random = new();
        protected IUserAgentsRepository Repository { get => _repository; set => _repository = value; }

        /// <summary>
        /// Randomly generate a user agent.
        /// </summary>
        /// <returns>The randomized user agent.</returns>
        public async Task<UserAgent> GenerateAsync()
        {
            List<string> userAgents = await _repository.GetAllAsync();
            return new UserAgent(_random.Generate(userAgents));
        }

        private UserAgent Generate(UserAgentsGeneratorConfig config) { throw new NotImplementedException(); }

        /// <summary>
        /// Generate many user agents at once.
        /// </summary>
        /// <param name="num">How many user agents to be generated.</param>
        /// <returns>The unique randomized user agents.</returns>
        public async Task<List<UserAgent>> GenerateManyAsync(int num)
        {
            List<string> userAgents = await _repository.GetAllAsync();
            return _random.GenerateMany(userAgents, num).Select(item => new UserAgent(item)).ToList();
        }
    }
}
