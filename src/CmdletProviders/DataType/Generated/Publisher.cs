using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("publisher")]
  public class Publisher : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "publisher";
    public const int EntityTypeCode = 7101;

    [AttributeLogicalName("address1_addressid")]
    public Guid? Address1_AddressId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("address1_addressid");
      }
      set
      {
        this.OnPropertyChanging("Address1_AddressId");
        this.SetAttributeValue("address1_addressid", (object) value);
        this.OnPropertyChanged("Address1_AddressId");
      }
    }

    [AttributeLogicalName("address1_addresstypecode")]
    public OptionSetValue Address1_AddressTypeCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("address1_addresstypecode");
      }
      set
      {
        this.OnPropertyChanging("Address1_AddressTypeCode");
        this.SetAttributeValue("address1_addresstypecode", (object) value);
        this.OnPropertyChanged("Address1_AddressTypeCode");
      }
    }

    [AttributeLogicalName("address1_city")]
    public string Address1_City
    {
      get
      {
        return this.GetAttributeValue<string>("address1_city");
      }
      set
      {
        this.OnPropertyChanging("Address1_City");
        this.SetAttributeValue("address1_city", (object) value);
        this.OnPropertyChanged("Address1_City");
      }
    }

    [AttributeLogicalName("address1_country")]
    public string Address1_Country
    {
      get
      {
        return this.GetAttributeValue<string>("address1_country");
      }
      set
      {
        this.OnPropertyChanging("Address1_Country");
        this.SetAttributeValue("address1_country", (object) value);
        this.OnPropertyChanged("Address1_Country");
      }
    }

    [AttributeLogicalName("address1_county")]
    public string Address1_County
    {
      get
      {
        return this.GetAttributeValue<string>("address1_county");
      }
      set
      {
        this.OnPropertyChanging("Address1_County");
        this.SetAttributeValue("address1_county", (object) value);
        this.OnPropertyChanged("Address1_County");
      }
    }

    [AttributeLogicalName("address1_fax")]
    public string Address1_Fax
    {
      get
      {
        return this.GetAttributeValue<string>("address1_fax");
      }
      set
      {
        this.OnPropertyChanging("Address1_Fax");
        this.SetAttributeValue("address1_fax", (object) value);
        this.OnPropertyChanged("Address1_Fax");
      }
    }

    [AttributeLogicalName("address1_latitude")]
    public double? Address1_Latitude
    {
      get
      {
        return this.GetAttributeValue<double?>("address1_latitude");
      }
      set
      {
        this.OnPropertyChanging("Address1_Latitude");
        this.SetAttributeValue("address1_latitude", (object) value);
        this.OnPropertyChanged("Address1_Latitude");
      }
    }

    [AttributeLogicalName("address1_line1")]
    public string Address1_Line1
    {
      get
      {
        return this.GetAttributeValue<string>("address1_line1");
      }
      set
      {
        this.OnPropertyChanging("Address1_Line1");
        this.SetAttributeValue("address1_line1", (object) value);
        this.OnPropertyChanged("Address1_Line1");
      }
    }

    [AttributeLogicalName("address1_line2")]
    public string Address1_Line2
    {
      get
      {
        return this.GetAttributeValue<string>("address1_line2");
      }
      set
      {
        this.OnPropertyChanging("Address1_Line2");
        this.SetAttributeValue("address1_line2", (object) value);
        this.OnPropertyChanged("Address1_Line2");
      }
    }

    [AttributeLogicalName("address1_line3")]
    public string Address1_Line3
    {
      get
      {
        return this.GetAttributeValue<string>("address1_line3");
      }
      set
      {
        this.OnPropertyChanging("Address1_Line3");
        this.SetAttributeValue("address1_line3", (object) value);
        this.OnPropertyChanged("Address1_Line3");
      }
    }

    [AttributeLogicalName("address1_longitude")]
    public double? Address1_Longitude
    {
      get
      {
        return this.GetAttributeValue<double?>("address1_longitude");
      }
      set
      {
        this.OnPropertyChanging("Address1_Longitude");
        this.SetAttributeValue("address1_longitude", (object) value);
        this.OnPropertyChanged("Address1_Longitude");
      }
    }

    [AttributeLogicalName("address1_name")]
    public string Address1_Name
    {
      get
      {
        return this.GetAttributeValue<string>("address1_name");
      }
      set
      {
        this.OnPropertyChanging("Address1_Name");
        this.SetAttributeValue("address1_name", (object) value);
        this.OnPropertyChanged("Address1_Name");
      }
    }

    [AttributeLogicalName("address1_postalcode")]
    public string Address1_PostalCode
    {
      get
      {
        return this.GetAttributeValue<string>("address1_postalcode");
      }
      set
      {
        this.OnPropertyChanging("Address1_PostalCode");
        this.SetAttributeValue("address1_postalcode", (object) value);
        this.OnPropertyChanged("Address1_PostalCode");
      }
    }

    [AttributeLogicalName("address1_postofficebox")]
    public string Address1_PostOfficeBox
    {
      get
      {
        return this.GetAttributeValue<string>("address1_postofficebox");
      }
      set
      {
        this.OnPropertyChanging("Address1_PostOfficeBox");
        this.SetAttributeValue("address1_postofficebox", (object) value);
        this.OnPropertyChanged("Address1_PostOfficeBox");
      }
    }

    [AttributeLogicalName("address1_shippingmethodcode")]
    public OptionSetValue Address1_ShippingMethodCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("address1_shippingmethodcode");
      }
      set
      {
        this.OnPropertyChanging("Address1_ShippingMethodCode");
        this.SetAttributeValue("address1_shippingmethodcode", (object) value);
        this.OnPropertyChanged("Address1_ShippingMethodCode");
      }
    }

    [AttributeLogicalName("address1_stateorprovince")]
    public string Address1_StateOrProvince
    {
      get
      {
        return this.GetAttributeValue<string>("address1_stateorprovince");
      }
      set
      {
        this.OnPropertyChanging("Address1_StateOrProvince");
        this.SetAttributeValue("address1_stateorprovince", (object) value);
        this.OnPropertyChanged("Address1_StateOrProvince");
      }
    }

    [AttributeLogicalName("address1_telephone1")]
    public string Address1_Telephone1
    {
      get
      {
        return this.GetAttributeValue<string>("address1_telephone1");
      }
      set
      {
        this.OnPropertyChanging("Address1_Telephone1");
        this.SetAttributeValue("address1_telephone1", (object) value);
        this.OnPropertyChanged("Address1_Telephone1");
      }
    }

    [AttributeLogicalName("address1_telephone2")]
    public string Address1_Telephone2
    {
      get
      {
        return this.GetAttributeValue<string>("address1_telephone2");
      }
      set
      {
        this.OnPropertyChanging("Address1_Telephone2");
        this.SetAttributeValue("address1_telephone2", (object) value);
        this.OnPropertyChanged("Address1_Telephone2");
      }
    }

    [AttributeLogicalName("address1_telephone3")]
    public string Address1_Telephone3
    {
      get
      {
        return this.GetAttributeValue<string>("address1_telephone3");
      }
      set
      {
        this.OnPropertyChanging("Address1_Telephone3");
        this.SetAttributeValue("address1_telephone3", (object) value);
        this.OnPropertyChanged("Address1_Telephone3");
      }
    }

    [AttributeLogicalName("address1_upszone")]
    public string Address1_UPSZone
    {
      get
      {
        return this.GetAttributeValue<string>("address1_upszone");
      }
      set
      {
        this.OnPropertyChanging("Address1_UPSZone");
        this.SetAttributeValue("address1_upszone", (object) value);
        this.OnPropertyChanged("Address1_UPSZone");
      }
    }

    [AttributeLogicalName("address1_utcoffset")]
    public int? Address1_UTCOffset
    {
      get
      {
        return this.GetAttributeValue<int?>("address1_utcoffset");
      }
      set
      {
        this.OnPropertyChanging("Address1_UTCOffset");
        this.SetAttributeValue("address1_utcoffset", (object) value);
        this.OnPropertyChanged("Address1_UTCOffset");
      }
    }

    [AttributeLogicalName("address2_addressid")]
    public Guid? Address2_AddressId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("address2_addressid");
      }
      set
      {
        this.OnPropertyChanging("Address2_AddressId");
        this.SetAttributeValue("address2_addressid", (object) value);
        this.OnPropertyChanged("Address2_AddressId");
      }
    }

    [AttributeLogicalName("address2_addresstypecode")]
    public OptionSetValue Address2_AddressTypeCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("address2_addresstypecode");
      }
      set
      {
        this.OnPropertyChanging("Address2_AddressTypeCode");
        this.SetAttributeValue("address2_addresstypecode", (object) value);
        this.OnPropertyChanged("Address2_AddressTypeCode");
      }
    }

    [AttributeLogicalName("address2_city")]
    public string Address2_City
    {
      get
      {
        return this.GetAttributeValue<string>("address2_city");
      }
      set
      {
        this.OnPropertyChanging("Address2_City");
        this.SetAttributeValue("address2_city", (object) value);
        this.OnPropertyChanged("Address2_City");
      }
    }

    [AttributeLogicalName("address2_country")]
    public string Address2_Country
    {
      get
      {
        return this.GetAttributeValue<string>("address2_country");
      }
      set
      {
        this.OnPropertyChanging("Address2_Country");
        this.SetAttributeValue("address2_country", (object) value);
        this.OnPropertyChanged("Address2_Country");
      }
    }

    [AttributeLogicalName("address2_county")]
    public string Address2_County
    {
      get
      {
        return this.GetAttributeValue<string>("address2_county");
      }
      set
      {
        this.OnPropertyChanging("Address2_County");
        this.SetAttributeValue("address2_county", (object) value);
        this.OnPropertyChanged("Address2_County");
      }
    }

    [AttributeLogicalName("address2_fax")]
    public string Address2_Fax
    {
      get
      {
        return this.GetAttributeValue<string>("address2_fax");
      }
      set
      {
        this.OnPropertyChanging("Address2_Fax");
        this.SetAttributeValue("address2_fax", (object) value);
        this.OnPropertyChanged("Address2_Fax");
      }
    }

    [AttributeLogicalName("address2_latitude")]
    public double? Address2_Latitude
    {
      get
      {
        return this.GetAttributeValue<double?>("address2_latitude");
      }
      set
      {
        this.OnPropertyChanging("Address2_Latitude");
        this.SetAttributeValue("address2_latitude", (object) value);
        this.OnPropertyChanged("Address2_Latitude");
      }
    }

    [AttributeLogicalName("address2_line1")]
    public string Address2_Line1
    {
      get
      {
        return this.GetAttributeValue<string>("address2_line1");
      }
      set
      {
        this.OnPropertyChanging("Address2_Line1");
        this.SetAttributeValue("address2_line1", (object) value);
        this.OnPropertyChanged("Address2_Line1");
      }
    }

    [AttributeLogicalName("address2_line2")]
    public string Address2_Line2
    {
      get
      {
        return this.GetAttributeValue<string>("address2_line2");
      }
      set
      {
        this.OnPropertyChanging("Address2_Line2");
        this.SetAttributeValue("address2_line2", (object) value);
        this.OnPropertyChanged("Address2_Line2");
      }
    }

    [AttributeLogicalName("address2_line3")]
    public string Address2_Line3
    {
      get
      {
        return this.GetAttributeValue<string>("address2_line3");
      }
      set
      {
        this.OnPropertyChanging("Address2_Line3");
        this.SetAttributeValue("address2_line3", (object) value);
        this.OnPropertyChanged("Address2_Line3");
      }
    }

    [AttributeLogicalName("address2_longitude")]
    public double? Address2_Longitude
    {
      get
      {
        return this.GetAttributeValue<double?>("address2_longitude");
      }
      set
      {
        this.OnPropertyChanging("Address2_Longitude");
        this.SetAttributeValue("address2_longitude", (object) value);
        this.OnPropertyChanged("Address2_Longitude");
      }
    }

    [AttributeLogicalName("address2_name")]
    public string Address2_Name
    {
      get
      {
        return this.GetAttributeValue<string>("address2_name");
      }
      set
      {
        this.OnPropertyChanging("Address2_Name");
        this.SetAttributeValue("address2_name", (object) value);
        this.OnPropertyChanged("Address2_Name");
      }
    }

    [AttributeLogicalName("address2_postalcode")]
    public string Address2_PostalCode
    {
      get
      {
        return this.GetAttributeValue<string>("address2_postalcode");
      }
      set
      {
        this.OnPropertyChanging("Address2_PostalCode");
        this.SetAttributeValue("address2_postalcode", (object) value);
        this.OnPropertyChanged("Address2_PostalCode");
      }
    }

    [AttributeLogicalName("address2_postofficebox")]
    public string Address2_PostOfficeBox
    {
      get
      {
        return this.GetAttributeValue<string>("address2_postofficebox");
      }
      set
      {
        this.OnPropertyChanging("Address2_PostOfficeBox");
        this.SetAttributeValue("address2_postofficebox", (object) value);
        this.OnPropertyChanged("Address2_PostOfficeBox");
      }
    }

    [AttributeLogicalName("address2_shippingmethodcode")]
    public OptionSetValue Address2_ShippingMethodCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("address2_shippingmethodcode");
      }
      set
      {
        this.OnPropertyChanging("Address2_ShippingMethodCode");
        this.SetAttributeValue("address2_shippingmethodcode", (object) value);
        this.OnPropertyChanged("Address2_ShippingMethodCode");
      }
    }

    [AttributeLogicalName("address2_stateorprovince")]
    public string Address2_StateOrProvince
    {
      get
      {
        return this.GetAttributeValue<string>("address2_stateorprovince");
      }
      set
      {
        this.OnPropertyChanging("Address2_StateOrProvince");
        this.SetAttributeValue("address2_stateorprovince", (object) value);
        this.OnPropertyChanged("Address2_StateOrProvince");
      }
    }

    [AttributeLogicalName("address2_telephone1")]
    public string Address2_Telephone1
    {
      get
      {
        return this.GetAttributeValue<string>("address2_telephone1");
      }
      set
      {
        this.OnPropertyChanging("Address2_Telephone1");
        this.SetAttributeValue("address2_telephone1", (object) value);
        this.OnPropertyChanged("Address2_Telephone1");
      }
    }

    [AttributeLogicalName("address2_telephone2")]
    public string Address2_Telephone2
    {
      get
      {
        return this.GetAttributeValue<string>("address2_telephone2");
      }
      set
      {
        this.OnPropertyChanging("Address2_Telephone2");
        this.SetAttributeValue("address2_telephone2", (object) value);
        this.OnPropertyChanged("Address2_Telephone2");
      }
    }

    [AttributeLogicalName("address2_telephone3")]
    public string Address2_Telephone3
    {
      get
      {
        return this.GetAttributeValue<string>("address2_telephone3");
      }
      set
      {
        this.OnPropertyChanging("Address2_Telephone3");
        this.SetAttributeValue("address2_telephone3", (object) value);
        this.OnPropertyChanged("Address2_Telephone3");
      }
    }

    [AttributeLogicalName("address2_upszone")]
    public string Address2_UPSZone
    {
      get
      {
        return this.GetAttributeValue<string>("address2_upszone");
      }
      set
      {
        this.OnPropertyChanging("Address2_UPSZone");
        this.SetAttributeValue("address2_upszone", (object) value);
        this.OnPropertyChanged("Address2_UPSZone");
      }
    }

    [AttributeLogicalName("address2_utcoffset")]
    public int? Address2_UTCOffset
    {
      get
      {
        return this.GetAttributeValue<int?>("address2_utcoffset");
      }
      set
      {
        this.OnPropertyChanging("Address2_UTCOffset");
        this.SetAttributeValue("address2_utcoffset", (object) value);
        this.OnPropertyChanged("Address2_UTCOffset");
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("createdby");
      }
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("createdon");
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("createdonbehalfby");
      }
    }

    [AttributeLogicalName("customizationoptionvalueprefix")]
    public int? CustomizationOptionValuePrefix
    {
      get
      {
        return this.GetAttributeValue<int?>("customizationoptionvalueprefix");
      }
      set
      {
        this.OnPropertyChanging("CustomizationOptionValuePrefix");
        this.SetAttributeValue("customizationoptionvalueprefix", (object) value);
        this.OnPropertyChanged("CustomizationOptionValuePrefix");
      }
    }

    [AttributeLogicalName("customizationprefix")]
    public string CustomizationPrefix
    {
      get
      {
        return this.GetAttributeValue<string>("customizationprefix");
      }
      set
      {
        this.OnPropertyChanging("CustomizationPrefix");
        this.SetAttributeValue("customizationprefix", (object) value);
        this.OnPropertyChanged("CustomizationPrefix");
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get
      {
        return this.GetAttributeValue<string>("description");
      }
      set
      {
        this.OnPropertyChanging("Description");
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged("Description");
      }
    }

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get
      {
        return this.GetAttributeValue<string>("emailaddress");
      }
      set
      {
        this.OnPropertyChanging("EMailAddress");
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged("EMailAddress");
      }
    }

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get
      {
        return this.GetAttributeValue<byte[]>("entityimage");
      }
      set
      {
        this.OnPropertyChanging("EntityImage");
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged("EntityImage");
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp
    {
      get
      {
        return this.GetAttributeValue<long?>("entityimage_timestamp");
      }
    }

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL
    {
      get
      {
        return this.GetAttributeValue<string>("entityimage_url");
      }
    }

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("entityimageid");
      }
    }

    [AttributeLogicalName("friendlyname")]
    public string FriendlyName
    {
      get
      {
        return this.GetAttributeValue<string>("friendlyname");
      }
      set
      {
        this.OnPropertyChanging("FriendlyName");
        this.SetAttributeValue("friendlyname", (object) value);
        this.OnPropertyChanged("FriendlyName");
      }
    }

    [AttributeLogicalName("isreadonly")]
    public bool? IsReadonly
    {
      get
      {
        return this.GetAttributeValue<bool?>("isreadonly");
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("modifiedby");
      }
    }

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("modifiedon");
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("pinpointpublisherdefaultlocale")]
    public string PinpointPublisherDefaultLocale
    {
      get
      {
        return this.GetAttributeValue<string>("pinpointpublisherdefaultlocale");
      }
    }

    [AttributeLogicalName("pinpointpublisherid")]
    public long? PinpointPublisherId
    {
      get
      {
        return this.GetAttributeValue<long?>("pinpointpublisherid");
      }
    }

    [AttributeLogicalName("publisherid")]
    public Guid? PublisherId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("publisherid");
      }
      set
      {
        this.OnPropertyChanging("PublisherId");
        this.SetAttributeValue("publisherid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("PublisherId");
      }
    }

    [AttributeLogicalName("publisherid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.PublisherId = new Guid?(value);
      }
    }

    [AttributeLogicalName("supportingwebsiteurl")]
    public string SupportingWebsiteUrl
    {
      get
      {
        return this.GetAttributeValue<string>("supportingwebsiteurl");
      }
      set
      {
        this.OnPropertyChanging("SupportingWebsiteUrl");
        this.SetAttributeValue("supportingwebsiteurl", (object) value);
        this.OnPropertyChanged("SupportingWebsiteUrl");
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get
      {
        return this.GetAttributeValue<string>("uniquename");
      }
      set
      {
        this.OnPropertyChanging("UniqueName");
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged("UniqueName");
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

    [RelationshipSchemaName("Publisher_PublisherAddress")]
    public IEnumerable<PublisherAddress> Publisher_PublisherAddress
    {
      get
      {
        return this.GetRelatedEntities<PublisherAddress>("Publisher_PublisherAddress", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Publisher_PublisherAddress");
        this.SetRelatedEntities<PublisherAddress>("Publisher_PublisherAddress", new EntityRole?(), value);
        this.OnPropertyChanged("Publisher_PublisherAddress");
      }
    }

    [RelationshipSchemaName("publisher_solution")]
    public IEnumerable<Solution> publisher_solution
    {
      get
      {
        return this.GetRelatedEntities<Solution>("publisher_solution", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("publisher_solution");
        this.SetRelatedEntities<Solution>("publisher_solution", new EntityRole?(), value);
        this.OnPropertyChanged("publisher_solution");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_publisher_createdby")]
    public SystemUser lk_publisher_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisher_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_publisher_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser lk_publisher_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisher_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_publisherbase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_publisherbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisherbase_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_publisherbase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_publisherbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisherbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public Publisher()
      : base("publisher")
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
