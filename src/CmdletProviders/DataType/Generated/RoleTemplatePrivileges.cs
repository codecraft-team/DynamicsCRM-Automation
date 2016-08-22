using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("roletemplateprivileges")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class RoleTemplatePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "roletemplateprivileges";
    public const int EntityTypeCode = 28;

    [AttributeLogicalName("isbasic")]
    public bool? IsBasic
    {
      get
      {
        return this.GetAttributeValue<bool?>("isbasic");
      }
      set
      {
        this.OnPropertyChanging("IsBasic");
        this.SetAttributeValue("isbasic", (object) value);
        this.OnPropertyChanged("IsBasic");
      }
    }

    [AttributeLogicalName("isdeep")]
    public bool? IsDeep
    {
      get
      {
        return this.GetAttributeValue<bool?>("isdeep");
      }
      set
      {
        this.OnPropertyChanging("IsDeep");
        this.SetAttributeValue("isdeep", (object) value);
        this.OnPropertyChanged("IsDeep");
      }
    }

    [AttributeLogicalName("isglobal")]
    public bool? IsGlobal
    {
      get
      {
        return this.GetAttributeValue<bool?>("isglobal");
      }
      set
      {
        this.OnPropertyChanging("IsGlobal");
        this.SetAttributeValue("isglobal", (object) value);
        this.OnPropertyChanged("IsGlobal");
      }
    }

    [AttributeLogicalName("islocal")]
    public bool? IsLocal
    {
      get
      {
        return this.GetAttributeValue<bool?>("islocal");
      }
      set
      {
        this.OnPropertyChanging("IsLocal");
        this.SetAttributeValue("islocal", (object) value);
        this.OnPropertyChanged("IsLocal");
      }
    }

    [AttributeLogicalName("privilegeid")]
    public Guid? PrivilegeId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("privilegeid");
      }
    }

    [AttributeLogicalName("roletemplateid")]
    public Guid? RoleTemplateId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roletemplateid");
      }
    }

    [AttributeLogicalName("roletemplateprivilegeid")]
    public Guid? RoleTemplatePrivilegeId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roletemplateprivilegeid");
      }
      set
      {
        this.OnPropertyChanging("RoleTemplatePrivilegeId");
        this.SetAttributeValue("roletemplateprivilegeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("RoleTemplatePrivilegeId");
      }
    }

    [AttributeLogicalName("roletemplateprivilegeid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.RoleTemplatePrivilegeId = new Guid?(value);
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public RoleTemplatePrivileges()
      : base("roletemplateprivileges")
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
