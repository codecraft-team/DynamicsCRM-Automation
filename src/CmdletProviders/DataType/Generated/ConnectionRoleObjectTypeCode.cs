using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionroleobjecttypecode")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class ConnectionRoleObjectTypeCode : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionroleobjecttypecode";
    public const int EntityTypeCode = 3233;

    [AttributeLogicalName("associatedobjecttypecode")]
    public string AssociatedObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("associatedobjecttypecode");
      }
      set
      {
        this.OnPropertyChanging("AssociatedObjectTypeCode");
        this.SetAttributeValue("associatedobjecttypecode", (object) value);
        this.OnPropertyChanged("AssociatedObjectTypeCode");
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public EntityReference ConnectionRoleId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("connectionroleid");
      }
      set
      {
        this.OnPropertyChanging("ConnectionRoleId");
        this.SetAttributeValue("connectionroleid", (object) value);
        this.OnPropertyChanged("ConnectionRoleId");
      }
    }

    [AttributeLogicalName("connectionroleobjecttypecodeid")]
    public Guid? ConnectionRoleObjectTypeCodeId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("connectionroleobjecttypecodeid");
      }
      set
      {
        this.OnPropertyChanging("ConnectionRoleObjectTypeCodeId");
        this.SetAttributeValue("connectionroleobjecttypecodeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ConnectionRoleObjectTypeCodeId");
      }
    }

    [AttributeLogicalName("connectionroleobjecttypecodeid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ConnectionRoleObjectTypeCodeId = new Guid?(value);
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("organizationid");
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

    [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
    [AttributeLogicalName("connectionroleid")]
    public ConnectionRole connection_role_connection_role_object_type_codes
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>("connection_role_connection_role_object_type_codes", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("connection_role_connection_role_object_type_codes");
        this.SetRelatedEntity<ConnectionRole>("connection_role_connection_role_object_type_codes", new EntityRole?(), value);
        this.OnPropertyChanged("connection_role_connection_role_object_type_codes");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public ConnectionRoleObjectTypeCode()
      : base("connectionroleobjecttypecode")
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
