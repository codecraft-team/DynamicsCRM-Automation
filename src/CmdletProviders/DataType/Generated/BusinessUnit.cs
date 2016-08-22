using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessunit")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class BusinessUnit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessunit";
    public const int EntityTypeCode = 10;

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

    [AttributeLogicalName("businessunitid")]
    public Guid? BusinessUnitId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("businessunitid");
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitId");
        this.SetAttributeValue("businessunitid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("BusinessUnitId");
      }
    }

    [AttributeLogicalName("businessunitid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.BusinessUnitId = new Guid?(value);
      }
    }

    [AttributeLogicalName("calendarid")]
    public EntityReference CalendarId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("calendarid");
      }
      set
      {
        this.OnPropertyChanging("CalendarId");
        this.SetAttributeValue("calendarid", (object) value);
        this.OnPropertyChanged("CalendarId");
      }
    }

    [AttributeLogicalName("costcenter")]
    public string CostCenter
    {
      get
      {
        return this.GetAttributeValue<string>("costcenter");
      }
      set
      {
        this.OnPropertyChanging("CostCenter");
        this.SetAttributeValue("costcenter", (object) value);
        this.OnPropertyChanged("CostCenter");
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

    [AttributeLogicalName("creditlimit")]
    public double? CreditLimit
    {
      get
      {
        return this.GetAttributeValue<double?>("creditlimit");
      }
      set
      {
        this.OnPropertyChanging("CreditLimit");
        this.SetAttributeValue("creditlimit", (object) value);
        this.OnPropertyChanged("CreditLimit");
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

    [AttributeLogicalName("disabledreason")]
    public string DisabledReason
    {
      get
      {
        return this.GetAttributeValue<string>("disabledreason");
      }
    }

    [AttributeLogicalName("divisionname")]
    public string DivisionName
    {
      get
      {
        return this.GetAttributeValue<string>("divisionname");
      }
      set
      {
        this.OnPropertyChanging("DivisionName");
        this.SetAttributeValue("divisionname", (object) value);
        this.OnPropertyChanged("DivisionName");
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate
    {
      get
      {
        return this.GetAttributeValue<Decimal?>("exchangerate");
      }
    }

    [AttributeLogicalName("fileasname")]
    public string FileAsName
    {
      get
      {
        return this.GetAttributeValue<string>("fileasname");
      }
      set
      {
        this.OnPropertyChanging("FileAsName");
        this.SetAttributeValue("fileasname", (object) value);
        this.OnPropertyChanged("FileAsName");
      }
    }

    [AttributeLogicalName("ftpsiteurl")]
    public string FtpSiteUrl
    {
      get
      {
        return this.GetAttributeValue<string>("ftpsiteurl");
      }
      set
      {
        this.OnPropertyChanging("FtpSiteUrl");
        this.SetAttributeValue("ftpsiteurl", (object) value);
        this.OnPropertyChanged("FtpSiteUrl");
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

    [AttributeLogicalName("inheritancemask")]
    public int? InheritanceMask
    {
      get
      {
        return this.GetAttributeValue<int?>("inheritancemask");
      }
      set
      {
        this.OnPropertyChanging("InheritanceMask");
        this.SetAttributeValue("inheritancemask", (object) value);
        this.OnPropertyChanged("InheritanceMask");
      }
    }

    [AttributeLogicalName("isdisabled")]
    public bool? IsDisabled
    {
      get
      {
        return this.GetAttributeValue<bool?>("isdisabled");
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overriddencreatedon");
      }
      set
      {
        this.OnPropertyChanging("OverriddenCreatedOn");
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged("OverriddenCreatedOn");
      }
    }

    [AttributeLogicalName("parentbusinessunitid")]
    public EntityReference ParentBusinessUnitId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentbusinessunitid");
      }
      set
      {
        this.OnPropertyChanging("ParentBusinessUnitId");
        this.SetAttributeValue("parentbusinessunitid", (object) value);
        this.OnPropertyChanged("ParentBusinessUnitId");
      }
    }

    [AttributeLogicalName("picture")]
    public string Picture
    {
      get
      {
        return this.GetAttributeValue<string>("picture");
      }
      set
      {
        this.OnPropertyChanging("Picture");
        this.SetAttributeValue("picture", (object) value);
        this.OnPropertyChanged("Picture");
      }
    }

    [AttributeLogicalName("stockexchange")]
    public string StockExchange
    {
      get
      {
        return this.GetAttributeValue<string>("stockexchange");
      }
      set
      {
        this.OnPropertyChanging("StockExchange");
        this.SetAttributeValue("stockexchange", (object) value);
        this.OnPropertyChanged("StockExchange");
      }
    }

    [AttributeLogicalName("tickersymbol")]
    public string TickerSymbol
    {
      get
      {
        return this.GetAttributeValue<string>("tickersymbol");
      }
      set
      {
        this.OnPropertyChanging("TickerSymbol");
        this.SetAttributeValue("tickersymbol", (object) value);
        this.OnPropertyChanged("TickerSymbol");
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      }
      set
      {
        this.OnPropertyChanging("TransactionCurrencyId");
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged("TransactionCurrencyId");
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

    [AttributeLogicalName("websiteurl")]
    public string WebSiteUrl
    {
      get
      {
        return this.GetAttributeValue<string>("websiteurl");
      }
      set
      {
        this.OnPropertyChanging("WebSiteUrl");
        this.SetAttributeValue("websiteurl", (object) value);
        this.OnPropertyChanged("WebSiteUrl");
      }
    }

    [AttributeLogicalName("workflowsuspended")]
    public bool? WorkflowSuspended
    {
      get
      {
        return this.GetAttributeValue<bool?>("workflowsuspended");
      }
      set
      {
        this.OnPropertyChanging("WorkflowSuspended");
        this.SetAttributeValue("workflowsuspended", (object) value);
        this.OnPropertyChanged("WorkflowSuspended");
      }
    }

    [RelationshipSchemaName("business_customer_opportunity_roles")]
    public IEnumerable<CustomerOpportunityRole> business_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("business_customer_opportunity_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_customer_opportunity_roles");
        this.SetRelatedEntities<CustomerOpportunityRole>("business_customer_opportunity_roles", new EntityRole?(), value);
        this.OnPropertyChanged("business_customer_opportunity_roles");
      }
    }

    [RelationshipSchemaName("business_unit_asyncoperation")]
    public IEnumerable<AsyncOperation> business_unit_asyncoperation
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("business_unit_asyncoperation", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_asyncoperation");
        this.SetRelatedEntities<AsyncOperation>("business_unit_asyncoperation", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_asyncoperation");
      }
    }

    [RelationshipSchemaName("business_unit_incident_resolution_activities")]
    public IEnumerable<IncidentResolution> business_unit_incident_resolution_activities
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("business_unit_incident_resolution_activities", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_incident_resolution_activities");
        this.SetRelatedEntities<IncidentResolution>("business_unit_incident_resolution_activities", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_incident_resolution_activities");
      }
    }

    [RelationshipSchemaName("business_unit_msdyusd_actioncallworkflow")]
    public IEnumerable<msdyusd_actioncallworkflow> business_unit_msdyusd_actioncallworkflow
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("business_unit_msdyusd_actioncallworkflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_msdyusd_actioncallworkflow");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("business_unit_msdyusd_actioncallworkflow", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_msdyusd_actioncallworkflow");
      }
    }

    [RelationshipSchemaName("business_unit_parent_business_unit", EntityRole.Referenced)]
    public IEnumerable<BusinessUnit> Referencedbusiness_unit_parent_business_unit
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedbusiness_unit_parent_business_unit");
        this.SetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedbusiness_unit_parent_business_unit");
      }
    }

    [RelationshipSchemaName("business_unit_roles")]
    public IEnumerable<Role> business_unit_roles
    {
      get
      {
        return this.GetRelatedEntities<Role>("business_unit_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_roles");
        this.SetRelatedEntities<Role>("business_unit_roles", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_roles");
      }
    }

    [RelationshipSchemaName("business_unit_system_users")]
    public IEnumerable<SystemUser> business_unit_system_users
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("business_unit_system_users", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_system_users");
        this.SetRelatedEntities<SystemUser>("business_unit_system_users", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_system_users");
      }
    }

    [RelationshipSchemaName("business_unit_uii_workflow")]
    public IEnumerable<UII_workflow> business_unit_uii_workflow
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("business_unit_uii_workflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_uii_workflow");
        this.SetRelatedEntities<UII_workflow>("business_unit_uii_workflow", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_uii_workflow");
      }
    }

    [RelationshipSchemaName("business_unit_uii_workflow_workflowstep_mapping")]
    public IEnumerable<UII_workflow_workflowstep_mapping> business_unit_uii_workflow_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("business_unit_uii_workflow_workflowstep_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_uii_workflow_workflowstep_mapping");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("business_unit_uii_workflow_workflowstep_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_uii_workflow_workflowstep_mapping");
      }
    }

    [RelationshipSchemaName("business_unit_uii_workflowstep")]
    public IEnumerable<UII_workflowstep> business_unit_uii_workflowstep
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("business_unit_uii_workflowstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_uii_workflowstep");
        this.SetRelatedEntities<UII_workflowstep>("business_unit_uii_workflowstep", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_uii_workflowstep");
      }
    }

    [RelationshipSchemaName("business_unit_workflow")]
    public IEnumerable<Workflow> business_unit_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("business_unit_workflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_workflow");
        this.SetRelatedEntities<Workflow>("business_unit_workflow", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_workflow");
      }
    }

    [RelationshipSchemaName("business_unit_workflowlogs")]
    public IEnumerable<WorkflowLog> business_unit_workflowlogs
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("business_unit_workflowlogs", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_workflowlogs");
        this.SetRelatedEntities<WorkflowLog>("business_unit_workflowlogs", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_workflowlogs");
      }
    }

    [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
    public IEnumerable<AsyncOperation> BusinessUnit_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("BusinessUnit_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("BusinessUnit_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("BusinessUnit_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("BusinessUnit_AsyncOperations");
      }
    }

    [RelationshipSchemaName("business_unit_parent_business_unit", EntityRole.Referencing)]
    [AttributeLogicalName("parentbusinessunitid")]
    public BusinessUnit Referencingbusiness_unit_parent_business_unit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?(EntityRole.Referencing));
      }
      set
      {
        this.OnPropertyChanging("Referencingbusiness_unit_parent_business_unit");
        this.SetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?(EntityRole.Referencing), value);
        this.OnPropertyChanged("Referencingbusiness_unit_parent_business_unit");
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
    public SystemUser lk_businessunit_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunit_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_businessunit_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunit_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_businessunitbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser lk_businessunitbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_modifiedby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public BusinessUnit()
      : base("businessunit")
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
