using System.Xml.Linq;

namespace CorreiosAPI.SIGEP.Interfaces {
    public interface ISIGEPRequest {
        XElement XML(string usuario, string senha, XNamespace cli);
    }
}