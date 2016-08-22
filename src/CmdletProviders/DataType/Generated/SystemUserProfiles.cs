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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuserprofiles")]
  public class SystemUserProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuserprofiles";
    public const int EntityTypeCode = 1202;

    [AttributeLogicalName("fieldsecurityprofileid")]
    public Guid? FieldSecurityProfileId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("fieldsecurityprofileid");
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

    [AttributeLogicalName("systemuserprofileid")]
    public Guid? SystemUserProfileId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemuserprofileid");
      }
      set
      {
        this.OnPropertyChanging("SystemUserProfileId");
        this.SetAttributeValue("systemuserprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SystemUserProfileId");
      }
    }

    [AttributeLogicalName("systemuserprofileid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SystemUserProfileId = new Guid?(value);
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

    [RelationshipSchemaName("systemuserprofiles_association")]
    public IEnumerable<SystemUser> systemuserprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("systemuserprofiles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserprofiles_association");
        this.SetRelatedEntities<SystemUser>("systemuserprofiles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserprofiles_association");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SystemUserProfiles()
      : base("systemuserprofiles")
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
