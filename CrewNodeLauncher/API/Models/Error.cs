// https://www.jsonutils.com/
namespace CrewNodeLauncher.API.Models
{
    class Error : Base
    {
        public string error { get; set; }
        public int _code { get; set; }
    }
}
