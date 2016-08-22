using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teamroles")]
  public class TeamRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teamroles";
    public const int EntityTypeCode = 40;

    [AttributeLogicalName("roleid")]
    public Guid? RoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleid");
      }
    }

    [AttributeLogicalName("teamid")]
    public Guid? TeamId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("teamid");
      }
    }

    [AttributeLogicalName("teamroleid")]
    public Guid? TeamRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("teamroleid");
      }
      set
      {
        this.OnPropertyChanging("TeamRoleId");
        this.SetAttributeValue("teamroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("TeamRoleId");
      }
    }

    [AttributeLogicalName("teamroleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.TeamRoleId = new Guid?(value);
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

    public TeamRoles()
      : base("teamroles")
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
