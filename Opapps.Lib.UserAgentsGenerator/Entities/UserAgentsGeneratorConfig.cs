namespace Opapps.Lib.UserAgentsGenerator.Entities
{
    public class UserAgentsGeneratorConfig
    {
        public int HowMany { get; set; }
        public UserAgentsFilters FilterBy { get; set; }
    }

    public class UserAgentsFilters
    {
        public string Device { get; set; }
        public string Browser { get; set; }
    }
}