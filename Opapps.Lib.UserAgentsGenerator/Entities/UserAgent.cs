using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opapps.Lib.UserAgentsGenerator.Entities
{
    public record UserAgent
    {

        public string Content { get; }

        public UserAgent(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
