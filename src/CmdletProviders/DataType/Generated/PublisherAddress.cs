using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("publisheraddress")]
  [DataContract]
  public class PublisherAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "publisheraddress";
    public const int EntityTypeCode = 7102;

    [AttributeLogicalName("addressnumber")]
    public int? AddressNumber
    {
      get
      {
        return this.GetAttributeValue<int?>("addressnumber");
      }
      set
      {
        this.OnPropertyChanging("AddressNumber");
        this.SetAttributeValue("addressnumber", (object) value);
        this.OnPropertyChanged("AddressNumber");
      }
    }

    [AttributeLogicalName("addresstypecode")]
    public OptionSetValue AddressTypeCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("addresstypecode");
      }
      set
      {
        this.OnPropertyChanging("AddressTypeCode");
        this.SetAttributeValue("addresstypecode", (object) value);
        this.OnPropertyChanged("AddressTypeCode");
      }
    }

    [AttributeLogicalName("city")]
    public string City
    {
      get
      {
        return this.GetAttributeValue<string>("city");
      }
      set
      {
        this.OnPropertyChanging("City");
        this.SetAttributeValue("city", (object) value);
        this.OnPropertyChanged("City");
      }
    }

    [AttributeLogicalName("country")]
    public string Country
    {
      get
      {
        return this.GetAttributeValue<string>("country");
      }
      set
      {
        this.OnPropertyChanging("Country");
        this.SetAttributeValue("country", (object) value);
        this.OnPropertyChanged("Country");
      }
    }

    [AttributeLogicalName("county")]
    public string County
    {
      get
      {
        return this.GetAttributeValue<string>("county");
      }
      set
      {
        this.OnPropertyChanging("County");
        this.SetAttributeValue("county", (object) value);
        this.OnPropertyChanged("County");
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

    [AttributeLogicalName("fax")]
    public string Fax
    {
      get
      {
        return this.GetAttributeValue<string>("fax");
      }
      set
      {
        this.OnPropertyChanging("Fax");
        this.SetAttributeValue("fax", (object) value);
        this.OnPropertyChanged("Fax");
      }
    }

    [AttributeLogicalName("freighttermscode")]
    public OptionSetValue FreightTermsCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("freighttermscode");
      }
      set
      {
        this.OnPropertyChanging("FreightTermsCode");
        this.SetAttributeValue("freighttermscode", (object) value);
        this.OnPropertyChanged("FreightTermsCode");
      }
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get
      {
        return this.GetAttributeValue<int?>("importsequencenumber");
      }
      set
      {
        this.OnPropertyChanging("ImportSequenceNumber");
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged("ImportSequenceNumber");
      }
    }

    [AttributeLogicalName("latitude")]
    public double? Latitude
    {
      get
      {
        return this.GetAttributeValue<double?>("latitude");
      }
      set
      {
        this.OnPropertyChanging("Latitude");
        this.SetAttributeValue("latitude", (object) value);
        this.OnPropertyChanged("Latitude");
      }
    }

    [AttributeLogicalName("line1")]
    public string Line1
    {
      get
      {
        return this.GetAttributeValue<string>("line1");
      }
      set
      {
        this.OnPropertyChanging("Line1");
        this.SetAttributeValue("line1", (object) value);
        this.OnPropertyChanged("Line1");
      }
    }

    [AttributeLogicalName("line2")]
    public string Line2
    {
      get
      {
        return this.GetAttributeValue<string>("line2");
      }
      set
      {
        this.OnPropertyChanging("Line2");
        this.SetAttributeValue("line2", (object) value);
        this.OnPropertyChanged("Line2");
      }
    }

    [AttributeLogicalName("line3")]
    public string Line3
    {
      get
      {
        return this.GetAttributeValue<string>("line3");
      }
      set
      {
        this.OnPropertyChanging("Line3");
        this.SetAttributeValue("line3", (object) value);
        this.OnPropertyChanged("Line3");
      }
    }

    [AttributeLogicalName("longitude")]
    public double? Longitude
    {
      get
      {
        return this.GetAttributeValue<double?>("longitude");
      }
      set
      {
        this.OnPropertyChanging("Longitude");
        this.SetAttributeValue("longitude", (object) value);
        this.OnPropertyChanged("Longitude");
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get
      {
        return this.GetAttributeValue<string>("name");
      }
      set
      {
        this.OnPropertyChanging("Name");
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged("Name");
      }
    }

    [AttributeLogicalName("parentid")]
    public EntityReference ParentId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentid");
      }
      set
      {
        this.OnPropertyChanging("ParentId");
        this.SetAttributeValue("parentid", (object) value);
        this.OnPropertyChanged("ParentId");
      }
    }

    [AttributeLogicalName("postalcode")]
    public string PostalCode
    {
      get
      {
        return this.GetAttributeValue<string>("postalcode");
      }
      set
      {
        this.OnPropertyChanging("PostalCode");
        this.SetAttributeValue("postalcode", (object) value);
        this.OnPropertyChanged("PostalCode");
      }
    }

    [AttributeLogicalName("postofficebox")]
    public string PostOfficeBox
    {
      get
      {
        return this.GetAttributeValue<string>("postofficebox");
      }
      set
      {
        this.OnPropertyChanging("PostOfficeBox");
        this.SetAttributeValue("postofficebox", (object) value);
        this.OnPropertyChanged("PostOfficeBox");
      }
    }

    [AttributeLogicalName("primarycontactname")]
    public string PrimaryContactName
    {
      get
      {
        return this.GetAttributeValue<string>("primarycontactname");
      }
      set
      {
        this.OnPropertyChanging("PrimaryContactName");
        this.SetAttributeValue("primarycontactname", (object) value);
        this.OnPropertyChanged("PrimaryContactName");
      }
    }

    [AttributeLogicalName("publisheraddressid")]
    public Guid? PublisherAddressId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("publisheraddressid");
      }
      set
      {
        this.OnPropertyChanging("PublisherAddressId");
        this.SetAttributeValue("publisheraddressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("PublisherAddressId");
      }
    }

    [AttributeLogicalName("publisheraddressid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.PublisherAddressId = new Guid?(value);
      }
    }

    [AttributeLogicalName("shippingmethodcode")]
    public OptionSetValue ShippingMethodCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("shippingmethodcode");
      }
      set
      {
        this.OnPropertyChanging("ShippingMethodCode");
        this.SetAttributeValue("shippingmethodcode", (object) value);
        this.OnPropertyChanged("ShippingMethodCode");
      }
    }

    [AttributeLogicalName("stateorprovince")]
    public string StateOrProvince
    {
      get
      {
        return this.GetAttributeValue<string>("stateorprovince");
      }
      set
      {
        this.OnPropertyChanging("StateOrProvince");
        this.SetAttributeValue("stateorprovince", (object) value);
        this.OnPropertyChanged("StateOrProvince");
      }
    }

    [AttributeLogicalName("telephone1")]
    public string Telephone1
    {
      get
      {
        return this.GetAttributeValue<string>("telephone1");
      }
      set
      {
        this.OnPropertyChanging("Telephone1");
        this.SetAttributeValue("telephone1", (object) value);
        this.OnPropertyChanged("Telephone1");
      }
    }

    [AttributeLogicalName("telephone2")]
    public string Telephone2
    {
      get
      {
        return this.GetAttributeValue<string>("telephone2");
      }
      set
      {
        this.OnPropertyChanging("Telephone2");
        this.SetAttributeValue("telephone2", (object) value);
        this.OnPropertyChanged("Telephone2");
      }
    }

    [AttributeLogicalName("telephone3")]
    public string Telephone3
    {
      get
      {
        return this.GetAttributeValue<string>("telephone3");
      }
      set
      {
        this.OnPropertyChanging("Telephone3");
        this.SetAttributeValue("telephone3", (object) value);
        this.OnPropertyChanged("Telephone3");
      }
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get
      {
        return this.GetAttributeValue<int?>("timezoneruleversionnumber");
      }
      set
      {
        this.OnPropertyChanging("TimeZoneRuleVersionNumber");
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged("TimeZoneRuleVersionNumber");
      }
    }

    [AttributeLogicalName("upszone")]
    public string UPSZone
    {
      get
      {
        return this.GetAttributeValue<string>("upszone");
      }
      set
      {
        this.OnPropertyChanging("UPSZone");
        this.SetAttributeValue("upszone", (object) value);
        this.OnPropertyChanged("UPSZone");
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get
      {
        return this.GetAttributeValue<int?>("utcconversiontimezonecode");
      }
      set
      {
        this.OnPropertyChanging("UTCConversionTimeZoneCode");
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged("UTCConversionTimeZoneCode");
      }
    }

    [AttributeLogicalName("utcoffset")]
    public int? UTCOffset
    {
      get
      {
        return this.GetAttributeValue<int?>("utcoffset");
      }
      set
      {
        this.OnPropertyChanging("UTCOffset");
        this.SetAttributeValue("utcoffset", (object) value);
        this.OnPropertyChanged("UTCOffset");
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_publisheraddressbase_createdby")]
    public SystemUser lk_publisheraddressbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
    public SystemUser lk_publisheraddressbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
    public SystemUser lk_publisheraddressbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
    public SystemUser lk_publisheraddressbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("Publisher_PublisherAddress")]
    [AttributeLogicalName("parentid")]
    public Publisher Publisher_PublisherAddress
    {
      get
      {
        return this.GetRelatedEntity<Publisher>("Publisher_PublisherAddress", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Publisher_PublisherAddress");
        this.SetRelatedEntity<Publisher>("Publisher_PublisherAddress", new EntityRole?(), value);
        this.OnPropertyChanged("Publisher_PublisherAddress");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public PublisherAddress()
      : base("publisheraddress")
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
