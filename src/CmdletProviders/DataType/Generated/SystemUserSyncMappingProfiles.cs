using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemusersyncmappingprofiles")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SystemUserSyncMappingProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemusersyncmappingprofiles";
    public const int EntityTypeCode = 1402;

    [AttributeLogicalName("syncattributemappingprofileid")]
    public Guid? SyncAttributeMappingProfileId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("syncattributemappingprofileid");
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

    [AttributeLogicalName("systemusersyncmappingprofileid")]
    public Guid? SystemUserSyncMappingProfileId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemusersyncmappingprofileid");
      }
      set
      {
        this.OnPropertyChanging("SystemUserSyncMappingProfileId");
        this.SetAttributeValue("systemusersyncmappingprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SystemUserSyncMappingProfileId");
      }
    }

    [AttributeLogicalName("systemusersyncmappingprofileid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SystemUserSyncMappingProfileId = new Guid?(value);
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

    [RelationshipSchemaName("systemusersyncmappingprofiles_association")]
    public IEnumerable<SystemUser> systemusersyncmappingprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("systemusersyncmappingprofiles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemusersyncmappingprofiles_association");
        this.SetRelatedEntities<SystemUser>("systemusersyncmappingprofiles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemusersyncmappingprofiles_association");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SystemUserSyncMappingProfiles()
      : base("systemusersyncmappingprofiles")
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
