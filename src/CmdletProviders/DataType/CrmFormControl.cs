using System.Xml.Linq;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class CrmFormControl {
    private readonly CrmForm _form;
    public XElement Xml { get; }

    public string UniqueId => Xml.GetUniqueId();
    public string Id => Xml.GetId();
    public string DataFieldName => Xml.GetDataFieldName();

    public CrmFormControl(CrmForm form, XElement xml) {
      _form = form;
      Xml = xml;
    }

    public void Remove() {
      _form.Remove(this);
    }
  }
}