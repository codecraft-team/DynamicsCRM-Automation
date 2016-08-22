using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuserlicenses")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SystemUserLicenses : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuserlicenses";
    public const int EntityTypeCode = 13;

    [AttributeLogicalName("licenseid")]
    public Guid? LicenseId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("licenseid");
      }
    }

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemuserid");
      }
    }

    [AttributeLogicalName("systemuserlicenseid")]
    public Guid? SystemUserLicenseId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemuserlicenseid");
      }
      set
      {
        this.OnPropertyChanging("SystemUserLicenseId");
        this.SetAttributeValue("systemuserlicenseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SystemUserLicenseId");
      }
    }

    [AttributeLogicalName("systemuserlicenseid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SystemUserLicenseId = new Guid?(value);
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SystemUserLicenses()
      : base("systemuserlicenses")
    {
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }
  }
}
