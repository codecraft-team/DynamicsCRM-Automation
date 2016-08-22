using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuserroles")]
  public class SystemUserRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuserroles";
    public const int EntityTypeCode = 15;

    [AttributeLogicalName("roleid")]
    public Guid? RoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleid");
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

    [AttributeLogicalName("systemuserroleid")]
    public Guid? SystemUserRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemuserroleid");
      }
      set
      {
        this.OnPropertyChanging("SystemUserRoleId");
        this.SetAttributeValue("systemuserroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SystemUserRoleId");
      }
    }

    [AttributeLogicalName("systemuserroleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SystemUserRoleId = new Guid?(value);
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

    [RelationshipSchemaName("systemuserroles_association")]
    public IEnumerable<SystemUser> systemuserroles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("systemuserroles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserroles_association");
        this.SetRelatedEntities<SystemUser>("systemuserroles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserroles_association");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SystemUserRoles()
      : base("systemuserroles")
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
