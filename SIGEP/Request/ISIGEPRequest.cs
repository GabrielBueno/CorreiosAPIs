using System.Xml.Linq;

namespace CorreiosAPI.SIGEP.Request {
    public interface ISIGEPRequest {
        XElement XML(string usuario, string senha, XNamespace cli);
    }
}