using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionroleassociation")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class ConnectionRoleAssociation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionroleassociation";
    public const int EntityTypeCode = 3232;

    [AttributeLogicalName("associatedconnectionroleid")]
    public Guid? AssociatedConnectionRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("associatedconnectionroleid");
      }
      set
      {
        this.OnPropertyChanging("AssociatedConnectionRoleId");
        this.SetAttributeValue("associatedconnectionroleid", (object) value);
        this.OnPropertyChanged("AssociatedConnectionRoleId");
      }
    }

    [AttributeLogicalName("connectionroleassociationid")]
    public Guid? ConnectionRoleAssociationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("connectionroleassociationid");
      }
      set
      {
        this.OnPropertyChanging("ConnectionRoleAssociationId");
        this.SetAttributeValue("connectionroleassociationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ConnectionRoleAssociationId");
      }
    }

    [AttributeLogicalName("connectionroleassociationid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ConnectionRoleAssociationId = new Guid?(value);
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public Guid? ConnectionRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("connectionroleid");
      }
      set
      {
        this.OnPropertyChanging("ConnectionRoleId");
        this.SetAttributeValue("connectionroleid", (object) value);
        this.OnPropertyChanged("ConnectionRoleId");
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

    [RelationshipSchemaName("connectionroleassociation_association")]
    public IEnumerable<ConnectionRole> connectionroleassociation_association
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("connectionroleassociation_association");
        this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?(), value);
        this.OnPropertyChanged("connectionroleassociation_association");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public ConnectionRoleAssociation()
      : base("connectionroleassociation")
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
