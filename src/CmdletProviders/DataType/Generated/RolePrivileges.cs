using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("roleprivileges")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class RolePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "roleprivileges";
    public const int EntityTypeCode = 12;

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componentstate");
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get
      {
        return this.GetAttributeValue<bool?>("ismanaged");
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overwritetime");
      }
    }

    [AttributeLogicalName("privilegedepthmask")]
    public int? PrivilegeDepthMask
    {
      get
      {
        return this.GetAttributeValue<int?>("privilegedepthmask");
      }
      set
      {
        this.OnPropertyChanging("PrivilegeDepthMask");
        this.SetAttributeValue("privilegedepthmask", (object) value);
        this.OnPropertyChanged("PrivilegeDepthMask");
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

    [AttributeLogicalName("roleid")]
    public Guid? RoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleid");
      }
    }

    [AttributeLogicalName("roleprivilegeid")]
    public Guid? RolePrivilegeId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleprivilegeid");
      }
      set
      {
        this.OnPropertyChanging("RolePrivilegeId");
        this.SetAttributeValue("roleprivilegeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("RolePrivilegeId");
      }
    }

    [AttributeLogicalName("roleprivilegeid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.RolePrivilegeId = new Guid?(value);
      }
    }

    [AttributeLogicalName("roleprivilegeidunique")]
    public Guid? RolePrivilegeIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleprivilegeidunique");
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("solutionid");
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public RolePrivileges()
      : base("roleprivileges")
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
