using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuser")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SystemUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuser";
    public const int EntityTypeCode = 8;

    [AttributeLogicalName("accessmode")]
    public OptionSetValue AccessMode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("accessmode");
      }
      set
      {
        this.OnPropertyChanging("AccessMode");
        this.SetAttributeValue("accessmode", (object) value);
        this.OnPropertyChanged("AccessMode");
      }
    }

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

    [AttributeLogicalName("address1_composite")]
    public string Address1_Composite
    {
      get
      {
        return this.GetAttributeValue<string>("address1_composite");
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

    [AttributeLogicalName("address2_composite")]
    public string Address2_Composite
    {
      get
      {
        return this.GetAttributeValue<string>("address2_composite");
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
    public EntityReference BusinessUnitId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("businessunitid");
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitId");
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged("BusinessUnitId");
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

    [AttributeLogicalName("caltype")]
    public OptionSetValue CALType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("caltype");
      }
      set
      {
        this.OnPropertyChanging("CALType");
        this.SetAttributeValue("caltype", (object) value);
        this.OnPropertyChanged("CALType");
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

    [AttributeLogicalName("defaultfilterspopulated")]
    public bool? DefaultFiltersPopulated
    {
      get
      {
        return this.GetAttributeValue<bool?>("defaultfilterspopulated");
      }
    }

    [AttributeLogicalName("defaultmailbox")]
    public EntityReference DefaultMailbox
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("defaultmailbox");
      }
    }

    [AttributeLogicalName("defaultodbfoldername")]
    public string DefaultOdbFolderName
    {
      get
      {
        return this.GetAttributeValue<string>("defaultodbfoldername");
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

    [AttributeLogicalName("displayinserviceviews")]
    public bool? DisplayInServiceViews
    {
      get
      {
        return this.GetAttributeValue<bool?>("displayinserviceviews");
      }
      set
      {
        this.OnPropertyChanging("DisplayInServiceViews");
        this.SetAttributeValue("displayinserviceviews", (object) value);
        this.OnPropertyChanged("DisplayInServiceViews");
      }
    }

    [AttributeLogicalName("domainname")]
    public string DomainName
    {
      get
      {
        return this.GetAttributeValue<string>("domainname");
      }
      set
      {
        this.OnPropertyChanging("DomainName");
        this.SetAttributeValue("domainname", (object) value);
        this.OnPropertyChanged("DomainName");
      }
    }

    [AttributeLogicalName("emailrouteraccessapproval")]
    public OptionSetValue EmailRouterAccessApproval
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
      }
      set
      {
        this.OnPropertyChanging("EmailRouterAccessApproval");
        this.SetAttributeValue("emailrouteraccessapproval", (object) value);
        this.OnPropertyChanged("EmailRouterAccessApproval");
      }
    }

    [AttributeLogicalName("employeeid")]
    public string EmployeeId
    {
      get
      {
        return this.GetAttributeValue<string>("employeeid");
      }
      set
      {
        this.OnPropertyChanging("EmployeeId");
        this.SetAttributeValue("employeeid", (object) value);
        this.OnPropertyChanged("EmployeeId");
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate
    {
      get
      {
        return this.GetAttributeValue<Decimal?>("exchangerate");
      }
    }

    [AttributeLogicalName("firstname")]
    public string FirstName
    {
      get
      {
        return this.GetAttributeValue<string>("firstname");
      }
      set
      {
        this.OnPropertyChanging("FirstName");
        this.SetAttributeValue("firstname", (object) value);
        this.OnPropertyChanged("FirstName");
      }
    }

    [AttributeLogicalName("fullname")]
    public string FullName
    {
      get
      {
        return this.GetAttributeValue<string>("fullname");
      }
    }

    [AttributeLogicalName("governmentid")]
    public string GovernmentId
    {
      get
      {
        return this.GetAttributeValue<string>("governmentid");
      }
      set
      {
        this.OnPropertyChanging("GovernmentId");
        this.SetAttributeValue("governmentid", (object) value);
        this.OnPropertyChanged("GovernmentId");
      }
    }

    [AttributeLogicalName("homephone")]
    public string HomePhone
    {
      get
      {
        return this.GetAttributeValue<string>("homephone");
      }
      set
      {
        this.OnPropertyChanging("HomePhone");
        this.SetAttributeValue("homephone", (object) value);
        this.OnPropertyChanged("HomePhone");
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

    [AttributeLogicalName("incomingemaildeliverymethod")]
    public OptionSetValue IncomingEmailDeliveryMethod
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
      }
      set
      {
        this.OnPropertyChanging("IncomingEmailDeliveryMethod");
        this.SetAttributeValue("incomingemaildeliverymethod", (object) value);
        this.OnPropertyChanged("IncomingEmailDeliveryMethod");
      }
    }

    [AttributeLogicalName("internalemailaddress")]
    public string InternalEMailAddress
    {
      get
      {
        return this.GetAttributeValue<string>("internalemailaddress");
      }
      set
      {
        this.OnPropertyChanging("InternalEMailAddress");
        this.SetAttributeValue("internalemailaddress", (object) value);
        this.OnPropertyChanged("InternalEMailAddress");
      }
    }

    [AttributeLogicalName("invitestatuscode")]
    public OptionSetValue InviteStatusCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("invitestatuscode");
      }
      set
      {
        this.OnPropertyChanging("InviteStatusCode");
        this.SetAttributeValue("invitestatuscode", (object) value);
        this.OnPropertyChanged("InviteStatusCode");
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

    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    public bool? IsEmailAddressApprovedByO365Admin
    {
      get
      {
        return this.GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
      }
    }

    [AttributeLogicalName("isintegrationuser")]
    public bool? IsIntegrationUser
    {
      get
      {
        return this.GetAttributeValue<bool?>("isintegrationuser");
      }
      set
      {
        this.OnPropertyChanging("IsIntegrationUser");
        this.SetAttributeValue("isintegrationuser", (object) value);
        this.OnPropertyChanged("IsIntegrationUser");
      }
    }

    [AttributeLogicalName("islicensed")]
    public bool? IsLicensed
    {
      get
      {
        return this.GetAttributeValue<bool?>("islicensed");
      }
      set
      {
        this.OnPropertyChanging("IsLicensed");
        this.SetAttributeValue("islicensed", (object) value);
        this.OnPropertyChanged("IsLicensed");
      }
    }

    [AttributeLogicalName("issyncwithdirectory")]
    public bool? IsSyncWithDirectory
    {
      get
      {
        return this.GetAttributeValue<bool?>("issyncwithdirectory");
      }
      set
      {
        this.OnPropertyChanging("IsSyncWithDirectory");
        this.SetAttributeValue("issyncwithdirectory", (object) value);
        this.OnPropertyChanged("IsSyncWithDirectory");
      }
    }

    [AttributeLogicalName("jobtitle")]
    public string JobTitle
    {
      get
      {
        return this.GetAttributeValue<string>("jobtitle");
      }
      set
      {
        this.OnPropertyChanging("JobTitle");
        this.SetAttributeValue("jobtitle", (object) value);
        this.OnPropertyChanged("JobTitle");
      }
    }

    [AttributeLogicalName("lastname")]
    public string LastName
    {
      get
      {
        return this.GetAttributeValue<string>("lastname");
      }
      set
      {
        this.OnPropertyChanging("LastName");
        this.SetAttributeValue("lastname", (object) value);
        this.OnPropertyChanged("LastName");
      }
    }

    [AttributeLogicalName("middlename")]
    public string MiddleName
    {
      get
      {
        return this.GetAttributeValue<string>("middlename");
      }
      set
      {
        this.OnPropertyChanging("MiddleName");
        this.SetAttributeValue("middlename", (object) value);
        this.OnPropertyChanged("MiddleName");
      }
    }

    [AttributeLogicalName("mobilealertemail")]
    public string MobileAlertEMail
    {
      get
      {
        return this.GetAttributeValue<string>("mobilealertemail");
      }
      set
      {
        this.OnPropertyChanging("MobileAlertEMail");
        this.SetAttributeValue("mobilealertemail", (object) value);
        this.OnPropertyChanged("MobileAlertEMail");
      }
    }

    [AttributeLogicalName("mobileofflineprofileid")]
    public EntityReference MobileOfflineProfileId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("mobileofflineprofileid");
      }
      set
      {
        this.OnPropertyChanging("MobileOfflineProfileId");
        this.SetAttributeValue("mobileofflineprofileid", (object) value);
        this.OnPropertyChanged("MobileOfflineProfileId");
      }
    }

    [AttributeLogicalName("mobilephone")]
    public string MobilePhone
    {
      get
      {
        return this.GetAttributeValue<string>("mobilephone");
      }
      set
      {
        this.OnPropertyChanging("MobilePhone");
        this.SetAttributeValue("mobilephone", (object) value);
        this.OnPropertyChanged("MobilePhone");
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

    [AttributeLogicalName("msdyusd_usdconfigurationid")]
    public EntityReference msdyusd_USDConfigurationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("msdyusd_usdconfigurationid");
      }
      set
      {
        this.OnPropertyChanging("msdyusd_USDConfigurationId");
        this.SetAttributeValue("msdyusd_usdconfigurationid", (object) value);
        this.OnPropertyChanged("msdyusd_USDConfigurationId");
      }
    }

    [AttributeLogicalName("nickname")]
    public string NickName
    {
      get
      {
        return this.GetAttributeValue<string>("nickname");
      }
      set
      {
        this.OnPropertyChanging("NickName");
        this.SetAttributeValue("nickname", (object) value);
        this.OnPropertyChanged("NickName");
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

    [AttributeLogicalName("outgoingemaildeliverymethod")]
    public OptionSetValue OutgoingEmailDeliveryMethod
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
      }
      set
      {
        this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
        this.SetAttributeValue("outgoingemaildeliverymethod", (object) value);
        this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
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

    [AttributeLogicalName("parentsystemuserid")]
    public EntityReference ParentSystemUserId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentsystemuserid");
      }
      set
      {
        this.OnPropertyChanging("ParentSystemUserId");
        this.SetAttributeValue("parentsystemuserid", (object) value);
        this.OnPropertyChanged("ParentSystemUserId");
      }
    }

    [AttributeLogicalName("passporthi")]
    public int? PassportHi
    {
      get
      {
        return this.GetAttributeValue<int?>("passporthi");
      }
      set
      {
        this.OnPropertyChanging("PassportHi");
        this.SetAttributeValue("passporthi", (object) value);
        this.OnPropertyChanged("PassportHi");
      }
    }

    [AttributeLogicalName("passportlo")]
    public int? PassportLo
    {
      get
      {
        return this.GetAttributeValue<int?>("passportlo");
      }
      set
      {
        this.OnPropertyChanging("PassportLo");
        this.SetAttributeValue("passportlo", (object) value);
        this.OnPropertyChanged("PassportLo");
      }
    }

    [AttributeLogicalName("personalemailaddress")]
    public string PersonalEMailAddress
    {
      get
      {
        return this.GetAttributeValue<string>("personalemailaddress");
      }
      set
      {
        this.OnPropertyChanging("PersonalEMailAddress");
        this.SetAttributeValue("personalemailaddress", (object) value);
        this.OnPropertyChanged("PersonalEMailAddress");
      }
    }

    [AttributeLogicalName("photourl")]
    public string PhotoUrl
    {
      get
      {
        return this.GetAttributeValue<string>("photourl");
      }
      set
      {
        this.OnPropertyChanging("PhotoUrl");
        this.SetAttributeValue("photourl", (object) value);
        this.OnPropertyChanged("PhotoUrl");
      }
    }

    [AttributeLogicalName("positionid")]
    public EntityReference PositionId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("positionid");
      }
      set
      {
        this.OnPropertyChanging("PositionId");
        this.SetAttributeValue("positionid", (object) value);
        this.OnPropertyChanged("PositionId");
      }
    }

    [AttributeLogicalName("preferredaddresscode")]
    public OptionSetValue PreferredAddressCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("preferredaddresscode");
      }
      set
      {
        this.OnPropertyChanging("PreferredAddressCode");
        this.SetAttributeValue("preferredaddresscode", (object) value);
        this.OnPropertyChanged("PreferredAddressCode");
      }
    }

    [AttributeLogicalName("preferredemailcode")]
    public OptionSetValue PreferredEmailCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("preferredemailcode");
      }
      set
      {
        this.OnPropertyChanging("PreferredEmailCode");
        this.SetAttributeValue("preferredemailcode", (object) value);
        this.OnPropertyChanged("PreferredEmailCode");
      }
    }

    [AttributeLogicalName("preferredphonecode")]
    public OptionSetValue PreferredPhoneCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("preferredphonecode");
      }
      set
      {
        this.OnPropertyChanging("PreferredPhoneCode");
        this.SetAttributeValue("preferredphonecode", (object) value);
        this.OnPropertyChanged("PreferredPhoneCode");
      }
    }

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("processid");
      }
      set
      {
        this.OnPropertyChanging("ProcessId");
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged("ProcessId");
      }
    }

    [AttributeLogicalName("queueid")]
    public EntityReference QueueId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("queueid");
      }
      set
      {
        this.OnPropertyChanging("QueueId");
        this.SetAttributeValue("queueid", (object) value);
        this.OnPropertyChanged("QueueId");
      }
    }

    [AttributeLogicalName("salutation")]
    public string Salutation
    {
      get
      {
        return this.GetAttributeValue<string>("salutation");
      }
      set
      {
        this.OnPropertyChanging("Salutation");
        this.SetAttributeValue("salutation", (object) value);
        this.OnPropertyChanged("Salutation");
      }
    }

    [AttributeLogicalName("setupuser")]
    public bool? SetupUser
    {
      get
      {
        return this.GetAttributeValue<bool?>("setupuser");
      }
      set
      {
        this.OnPropertyChanging("SetupUser");
        this.SetAttributeValue("setupuser", (object) value);
        this.OnPropertyChanged("SetupUser");
      }
    }

    [AttributeLogicalName("sharepointemailaddress")]
    public string SharePointEmailAddress
    {
      get
      {
        return this.GetAttributeValue<string>("sharepointemailaddress");
      }
      set
      {
        this.OnPropertyChanging("SharePointEmailAddress");
        this.SetAttributeValue("sharepointemailaddress", (object) value);
        this.OnPropertyChanged("SharePointEmailAddress");
      }
    }

    [AttributeLogicalName("siteid")]
    public EntityReference SiteId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("siteid");
      }
      set
      {
        this.OnPropertyChanging("SiteId");
        this.SetAttributeValue("siteid", (object) value);
        this.OnPropertyChanged("SiteId");
      }
    }

    [AttributeLogicalName("skills")]
    public string Skills
    {
      get
      {
        return this.GetAttributeValue<string>("skills");
      }
      set
      {
        this.OnPropertyChanging("Skills");
        this.SetAttributeValue("skills", (object) value);
        this.OnPropertyChanged("Skills");
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("stageid");
      }
      set
      {
        this.OnPropertyChanging("StageId");
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged("StageId");
      }
    }

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("systemuserid");
      }
      set
      {
        this.OnPropertyChanging("SystemUserId");
        this.SetAttributeValue("systemuserid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SystemUserId");
      }
    }

    [AttributeLogicalName("systemuserid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SystemUserId = new Guid?(value);
      }
    }

    [AttributeLogicalName("territoryid")]
    public EntityReference TerritoryId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("territoryid");
      }
      set
      {
        this.OnPropertyChanging("TerritoryId");
        this.SetAttributeValue("territoryid", (object) value);
        this.OnPropertyChanged("TerritoryId");
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

    [AttributeLogicalName("title")]
    public string Title
    {
      get
      {
        return this.GetAttributeValue<string>("title");
      }
      set
      {
        this.OnPropertyChanging("Title");
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged("Title");
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

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get
      {
        return this.GetAttributeValue<string>("traversedpath");
      }
      set
      {
        this.OnPropertyChanging("TraversedPath");
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged("TraversedPath");
      }
    }

    [AttributeLogicalName("userlicensetype")]
    public int? UserLicenseType
    {
      get
      {
        return this.GetAttributeValue<int?>("userlicensetype");
      }
      set
      {
        this.OnPropertyChanging("UserLicenseType");
        this.SetAttributeValue("userlicensetype", (object) value);
        this.OnPropertyChanged("UserLicenseType");
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [AttributeLogicalName("windowsliveid")]
    public string WindowsLiveID
    {
      get
      {
        return this.GetAttributeValue<string>("windowsliveid");
      }
      set
      {
        this.OnPropertyChanging("WindowsLiveID");
        this.SetAttributeValue("windowsliveid", (object) value);
        this.OnPropertyChanged("WindowsLiveID");
      }
    }

    [AttributeLogicalName("yammeremailaddress")]
    public string YammerEmailAddress
    {
      get
      {
        return this.GetAttributeValue<string>("yammeremailaddress");
      }
      set
      {
        this.OnPropertyChanging("YammerEmailAddress");
        this.SetAttributeValue("yammeremailaddress", (object) value);
        this.OnPropertyChanged("YammerEmailAddress");
      }
    }

    [AttributeLogicalName("yammeruserid")]
    public string YammerUserId
    {
      get
      {
        return this.GetAttributeValue<string>("yammeruserid");
      }
      set
      {
        this.OnPropertyChanging("YammerUserId");
        this.SetAttributeValue("yammeruserid", (object) value);
        this.OnPropertyChanged("YammerUserId");
      }
    }

    [AttributeLogicalName("yomifirstname")]
    public string YomiFirstName
    {
      get
      {
        return this.GetAttributeValue<string>("yomifirstname");
      }
      set
      {
        this.OnPropertyChanging("YomiFirstName");
        this.SetAttributeValue("yomifirstname", (object) value);
        this.OnPropertyChanged("YomiFirstName");
      }
    }

    [AttributeLogicalName("yomifullname")]
    public string YomiFullName
    {
      get
      {
        return this.GetAttributeValue<string>("yomifullname");
      }
    }

    [AttributeLogicalName("yomilastname")]
    public string YomiLastName
    {
      get
      {
        return this.GetAttributeValue<string>("yomilastname");
      }
      set
      {
        this.OnPropertyChanging("YomiLastName");
        this.SetAttributeValue("yomilastname", (object) value);
        this.OnPropertyChanged("YomiLastName");
      }
    }

    [AttributeLogicalName("yomimiddlename")]
    public string YomiMiddleName
    {
      get
      {
        return this.GetAttributeValue<string>("yomimiddlename");
      }
      set
      {
        this.OnPropertyChanging("YomiMiddleName");
        this.SetAttributeValue("yomimiddlename", (object) value);
        this.OnPropertyChanged("YomiMiddleName");
      }
    }

    [RelationshipSchemaName("createdby_connection_role")]
    public IEnumerable<ConnectionRole> createdby_connection_role
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("createdby_connection_role", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_connection_role");
        this.SetRelatedEntities<ConnectionRole>("createdby_connection_role", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_connection_role");
      }
    }

    [RelationshipSchemaName("createdby_pluginassembly")]
    public IEnumerable<PluginAssembly> createdby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntities<PluginAssembly>("createdby_pluginassembly", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_pluginassembly");
        this.SetRelatedEntities<PluginAssembly>("createdby_pluginassembly", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_pluginassembly");
      }
    }

    [RelationshipSchemaName("createdby_plugintracelog")]
    public IEnumerable<PluginTraceLog> createdby_plugintracelog
    {
      get
      {
        return this.GetRelatedEntities<PluginTraceLog>("createdby_plugintracelog", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_plugintracelog");
        this.SetRelatedEntities<PluginTraceLog>("createdby_plugintracelog", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_plugintracelog");
      }
    }

    [RelationshipSchemaName("createdby_plugintype")]
    public IEnumerable<PluginType> createdby_plugintype
    {
      get
      {
        return this.GetRelatedEntities<PluginType>("createdby_plugintype", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_plugintype");
        this.SetRelatedEntities<PluginType>("createdby_plugintype", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_plugintype");
      }
    }

    [RelationshipSchemaName("createdby_plugintypestatistic")]
    public IEnumerable<PluginTypeStatistic> createdby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_plugintypestatistic");
        this.SetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_plugintypestatistic");
      }
    }

    [RelationshipSchemaName("createdby_relationship_role")]
    public IEnumerable<RelationshipRole> createdby_relationship_role
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRole>("createdby_relationship_role", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_relationship_role");
        this.SetRelatedEntities<RelationshipRole>("createdby_relationship_role", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_relationship_role");
      }
    }

    [RelationshipSchemaName("createdby_relationship_role_map")]
    public IEnumerable<RelationshipRoleMap> createdby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>("createdby_relationship_role_map", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_relationship_role_map");
        this.SetRelatedEntities<RelationshipRoleMap>("createdby_relationship_role_map", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_relationship_role_map");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessage")]
    public IEnumerable<SdkMessage> createdby_sdkmessage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessage>("createdby_sdkmessage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessage");
        this.SetRelatedEntities<SdkMessage>("createdby_sdkmessage", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessage");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessagefilter")]
    public IEnumerable<SdkMessageFilter> createdby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessagefilter");
        this.SetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessagefilter");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessagepair")]
    public IEnumerable<SdkMessagePair> createdby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>("createdby_sdkmessagepair", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessagepair");
        this.SetRelatedEntities<SdkMessagePair>("createdby_sdkmessagepair", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessagepair");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> createdby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageprocessingstepimage")]
    public IEnumerable<SdkMessageProcessingStepImage> createdby_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessageprocessingstepimage");
        this.SetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessageprocessingstepimage");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageprocessingstepsecureconfig")]
    public IEnumerable<SdkMessageProcessingStepSecureConfig> createdby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessageprocessingstepsecureconfig");
        this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessageprocessingstepsecureconfig");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessagerequest")]
    public IEnumerable<SdkMessageRequest> createdby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>("createdby_sdkmessagerequest", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessagerequest");
        this.SetRelatedEntities<SdkMessageRequest>("createdby_sdkmessagerequest", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessagerequest");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessagerequestfield")]
    public IEnumerable<SdkMessageRequestField> createdby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>("createdby_sdkmessagerequestfield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessagerequestfield");
        this.SetRelatedEntities<SdkMessageRequestField>("createdby_sdkmessagerequestfield", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessagerequestfield");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageresponse")]
    public IEnumerable<SdkMessageResponse> createdby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>("createdby_sdkmessageresponse", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessageresponse");
        this.SetRelatedEntities<SdkMessageResponse>("createdby_sdkmessageresponse", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessageresponse");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageresponsefield")]
    public IEnumerable<SdkMessageResponseField> createdby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>("createdby_sdkmessageresponsefield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_sdkmessageresponsefield");
        this.SetRelatedEntities<SdkMessageResponseField>("createdby_sdkmessageresponsefield", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_sdkmessageresponsefield");
      }
    }

    [RelationshipSchemaName("createdby_serviceendpoint")]
    public IEnumerable<ServiceEndpoint> createdby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("createdby_serviceendpoint");
        this.SetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", new EntityRole?(), value);
        this.OnPropertyChanged("createdby_serviceendpoint");
      }
    }

    [RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> impersonatinguserid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_createdby")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_createdby
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_createdby");
        this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_createdby");
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_createdonbehalfby");
        this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_modifiedby")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_modifiedby");
        this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_modifiedonbehalfby");
        this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
    public IEnumerable<BusinessUnit> lk_businessunit_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunit_createdonbehalfby");
        this.SetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunit_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
    public IEnumerable<BusinessUnit> lk_businessunit_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
        this.SetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_createdby")]
    public IEnumerable<BusinessUnit> lk_businessunitbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitbase_createdby");
        this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitbase_createdby");
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
    public IEnumerable<BusinessUnit> lk_businessunitbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitbase_modifiedby");
        this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitbase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
    public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitnewsarticle_createdonbehalfby");
        this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitnewsarticle_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
    public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitnewsarticle_modifiedonbehalfby");
        this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitnewsarticle_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
    public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_createdby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitnewsarticlebase_createdby");
        this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitnewsarticlebase_createdby");
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
    public IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_businessunitnewsarticlebase_modifiedby");
        this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_businessunitnewsarticlebase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
    public IEnumerable<ConnectionRole> lk_connectionrolebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_connectionrolebase_createdonbehalfby");
        this.SetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_connectionrolebase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
    public IEnumerable<ConnectionRole> lk_connectionrolebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_connectionrolebase_modifiedonbehalfby");
        this.SetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_connectionrolebase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_createdby")]
    public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdby
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_customeropportunityrole_createdby");
        this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_customeropportunityrole_createdby");
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_createdonbehalfby")]
    public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_customeropportunityrole_createdonbehalfby");
        this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_customeropportunityrole_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_modifiedby")]
    public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_customeropportunityrole_modifiedby");
        this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_customeropportunityrole_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_modifiedonbehalfby")]
    public IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_customeropportunityrole_modifiedonbehalfby");
        this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_customeropportunityrole_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
    public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdby
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_fieldsecurityprofile_createdby");
        this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_fieldsecurityprofile_createdby");
      }
    }

    [RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
    public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_fieldsecurityprofile_createdonbehalfby");
        this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_fieldsecurityprofile_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
    public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedby");
        this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
    public IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedonbehalfby");
        this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_importjobbase_createdby")]
    public IEnumerable<ImportJob> lk_importjobbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<ImportJob>("lk_importjobbase_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_importjobbase_createdby");
        this.SetRelatedEntities<ImportJob>("lk_importjobbase_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_importjobbase_createdby");
      }
    }

    [RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
    public IEnumerable<ImportJob> lk_importjobbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_importjobbase_createdonbehalfby");
        this.SetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_importjobbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_importjobbase_modifiedby")]
    public IEnumerable<ImportJob> lk_importjobbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_importjobbase_modifiedby");
        this.SetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_importjobbase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
    public IEnumerable<ImportJob> lk_importjobbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_importjobbase_modifiedonbehalfby");
        this.SetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_importjobbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_createdby")]
    public IEnumerable<IncidentResolution> lk_incidentresolution_createdby
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_incidentresolution_createdby");
        this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_incidentresolution_createdby");
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_createdonbehalfby")]
    public IEnumerable<IncidentResolution> lk_incidentresolution_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_incidentresolution_createdonbehalfby");
        this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_incidentresolution_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_modifiedby")]
    public IEnumerable<IncidentResolution> lk_incidentresolution_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_incidentresolution_modifiedby");
        this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_incidentresolution_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_modifiedonbehalfby")]
    public IEnumerable<IncidentResolution> lk_incidentresolution_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_incidentresolution_modifiedonbehalfby");
        this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_incidentresolution_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_createdby")]
    public IEnumerable<msdyusd_actioncallworkflow> lk_msdyusd_actioncallworkflow_createdby
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_msdyusd_actioncallworkflow_createdby");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_msdyusd_actioncallworkflow_createdby");
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_createdonbehalfby")]
    public IEnumerable<msdyusd_actioncallworkflow> lk_msdyusd_actioncallworkflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_msdyusd_actioncallworkflow_createdonbehalfby");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_msdyusd_actioncallworkflow_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_modifiedby")]
    public IEnumerable<msdyusd_actioncallworkflow> lk_msdyusd_actioncallworkflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_msdyusd_actioncallworkflow_modifiedby");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_msdyusd_actioncallworkflow_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_modifiedonbehalfby")]
    public IEnumerable<msdyusd_actioncallworkflow> lk_msdyusd_actioncallworkflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_msdyusd_actioncallworkflow_modifiedonbehalfby");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("lk_msdyusd_actioncallworkflow_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_msdyusd_actioncallworkflow_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_pluginassembly_createdonbehalfby")]
    public IEnumerable<PluginAssembly> lk_pluginassembly_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_pluginassembly_createdonbehalfby");
        this.SetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_pluginassembly_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_pluginassembly_modifiedonbehalfby")]
    public IEnumerable<PluginAssembly> lk_pluginassembly_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_pluginassembly_modifiedonbehalfby");
        this.SetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_pluginassembly_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_plugintracelogbase_createdonbehalfby")]
    public IEnumerable<PluginTraceLog> lk_plugintracelogbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginTraceLog>("lk_plugintracelogbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_plugintracelogbase_createdonbehalfby");
        this.SetRelatedEntities<PluginTraceLog>("lk_plugintracelogbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_plugintracelogbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
    public IEnumerable<PluginType> lk_plugintype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_plugintype_createdonbehalfby");
        this.SetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_plugintype_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
    public IEnumerable<PluginType> lk_plugintype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_plugintype_modifiedonbehalfby");
        this.SetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_plugintype_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
    public IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_plugintypestatisticbase_createdonbehalfby");
        this.SetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_plugintypestatisticbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
    public IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_plugintypestatisticbase_modifiedonbehalfby");
        this.SetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_plugintypestatisticbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_publisher_createdby")]
    public IEnumerable<Publisher> lk_publisher_createdby
    {
      get
      {
        return this.GetRelatedEntities<Publisher>("lk_publisher_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisher_createdby");
        this.SetRelatedEntities<Publisher>("lk_publisher_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisher_createdby");
      }
    }

    [RelationshipSchemaName("lk_publisher_modifiedby")]
    public IEnumerable<Publisher> lk_publisher_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Publisher>("lk_publisher_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisher_modifiedby");
        this.SetRelatedEntities<Publisher>("lk_publisher_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisher_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_publisheraddressbase_createdby")]
    public IEnumerable<PublisherAddress> lk_publisheraddressbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisheraddressbase_createdby");
        this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisheraddressbase_createdby");
      }
    }

    [RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
    public IEnumerable<PublisherAddress> lk_publisheraddressbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisheraddressbase_createdonbehalfby");
        this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisheraddressbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
    public IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisheraddressbase_modifiedby");
        this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisheraddressbase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
    public IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisheraddressbase_modifiedonbehalfby");
        this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisheraddressbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_publisherbase_createdonbehalfby")]
    public IEnumerable<Publisher> lk_publisherbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisherbase_createdonbehalfby");
        this.SetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisherbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_publisherbase_modifiedonbehalfby")]
    public IEnumerable<Publisher> lk_publisherbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_publisherbase_modifiedonbehalfby");
        this.SetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_publisherbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_relationshiprole_createdonbehalfby")]
    public IEnumerable<RelationshipRole> lk_relationshiprole_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRole>("lk_relationshiprole_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_relationshiprole_createdonbehalfby");
        this.SetRelatedEntities<RelationshipRole>("lk_relationshiprole_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_relationshiprole_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_relationshiprole_modifiedonbehalfby")]
    public IEnumerable<RelationshipRole> lk_relationshiprole_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_relationshiprole_modifiedonbehalfby");
        this.SetRelatedEntities<RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_relationshiprole_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_relationshiprolemap_createdonbehalfby")]
    public IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_relationshiprolemap_createdonbehalfby");
        this.SetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_relationshiprolemap_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_relationshiprolemap_modifiedonbehalfby")]
    public IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_relationshiprolemap_modifiedonbehalfby");
        this.SetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_relationshiprolemap_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_role_createdonbehalfby")]
    public IEnumerable<Role> lk_role_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Role>("lk_role_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_role_createdonbehalfby");
        this.SetRelatedEntities<Role>("lk_role_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_role_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_role_modifiedonbehalfby")]
    public IEnumerable<Role> lk_role_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Role>("lk_role_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_role_modifiedonbehalfby");
        this.SetRelatedEntities<Role>("lk_role_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_role_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_rolebase_createdby")]
    public IEnumerable<Role> lk_rolebase_createdby
    {
      get
      {
        return this.GetRelatedEntities<Role>("lk_rolebase_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_rolebase_createdby");
        this.SetRelatedEntities<Role>("lk_rolebase_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_rolebase_createdby");
      }
    }

    [RelationshipSchemaName("lk_rolebase_modifiedby")]
    public IEnumerable<Role> lk_rolebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Role>("lk_rolebase_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_rolebase_modifiedby");
        this.SetRelatedEntities<Role>("lk_rolebase_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_rolebase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
    public IEnumerable<SdkMessage> lk_sdkmessage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
        this.SetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
    public IEnumerable<SdkMessage> lk_sdkmessage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
    public IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagefilter_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagefilter_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
    public IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagefilter_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagefilter_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagepair_createdonbehalfby")]
    public IEnumerable<SdkMessagePair> lk_sdkmessagepair_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagepair_createdonbehalfby");
        this.SetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagepair_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagepair_modifiedonbehalfby")]
    public IEnumerable<SdkMessagePair> lk_sdkmessagepair_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagepair_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagepair_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
    public IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstep_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstep_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
    public IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstep_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstep_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
    public IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
    public IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
    public IEnumerable<SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
    public IEnumerable<SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagerequest_createdonbehalfby")]
    public IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagerequest_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagerequest_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagerequest_modifiedonbehalfby")]
    public IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagerequest_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagerequest_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagerequestfield_createdonbehalfby")]
    public IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagerequestfield_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagerequestfield_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessagerequestfield_modifiedonbehalfby")]
    public IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessagerequestfield_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessagerequestfield_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponse_createdonbehalfby")]
    public IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageresponse_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageresponse_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponse_modifiedonbehalfby")]
    public IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageresponse_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageresponse_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponsefield_createdonbehalfby")]
    public IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageresponsefield_createdonbehalfby");
        this.SetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageresponsefield_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponsefield_modifiedonbehalfby")]
    public IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_sdkmessageresponsefield_modifiedonbehalfby");
        this.SetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_sdkmessageresponsefield_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
    public IEnumerable<ServiceEndpoint> lk_serviceendpointbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_serviceendpointbase_createdonbehalfby");
        this.SetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_serviceendpointbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
    public IEnumerable<ServiceEndpoint> lk_serviceendpointbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_serviceendpointbase_modifiedonbehalfby");
        this.SetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_serviceendpointbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_solution_createdby")]
    public IEnumerable<Solution> lk_solution_createdby
    {
      get
      {
        return this.GetRelatedEntities<Solution>("lk_solution_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solution_createdby");
        this.SetRelatedEntities<Solution>("lk_solution_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solution_createdby");
      }
    }

    [RelationshipSchemaName("lk_solution_modifiedby")]
    public IEnumerable<Solution> lk_solution_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Solution>("lk_solution_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solution_modifiedby");
        this.SetRelatedEntities<Solution>("lk_solution_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solution_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
    public IEnumerable<Solution> lk_solutionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solutionbase_createdonbehalfby");
        this.SetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solutionbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
    public IEnumerable<Solution> lk_solutionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
        this.SetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
    public IEnumerable<SolutionComponent> lk_solutioncomponentbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solutioncomponentbase_createdonbehalfby");
        this.SetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solutioncomponentbase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
    public IEnumerable<SolutionComponent> lk_solutioncomponentbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_solutioncomponentbase_modifiedonbehalfby");
        this.SetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_solutioncomponentbase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_systemuser_createdonbehalfby", EntityRole.Referenced)]
    public IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
        this.SetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_systemuser_modifiedonbehalfby", EntityRole.Referenced)]
    public IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
        this.SetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_systemuserbase_createdby", EntityRole.Referenced)]
    public IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
        this.SetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
      }
    }

    [RelationshipSchemaName("lk_systemuserbase_modifiedby", EntityRole.Referenced)]
    public IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
        this.SetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_createdby")]
    public IEnumerable<UII_workflow> lk_uii_workflow_createdby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("lk_uii_workflow_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_createdby");
        this.SetRelatedEntities<UII_workflow>("lk_uii_workflow_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_createdby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_createdonbehalfby")]
    public IEnumerable<UII_workflow> lk_uii_workflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("lk_uii_workflow_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_createdonbehalfby");
        this.SetRelatedEntities<UII_workflow>("lk_uii_workflow_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_modifiedby")]
    public IEnumerable<UII_workflow> lk_uii_workflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("lk_uii_workflow_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_modifiedby");
        this.SetRelatedEntities<UII_workflow>("lk_uii_workflow_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_modifiedonbehalfby")]
    public IEnumerable<UII_workflow> lk_uii_workflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("lk_uii_workflow_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_modifiedonbehalfby");
        this.SetRelatedEntities<UII_workflow>("lk_uii_workflow_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_createdby")]
    public IEnumerable<UII_workflow_workflowstep_mapping> lk_uii_workflow_workflowstep_mapping_createdby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_workflowstep_mapping_createdby");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_workflowstep_mapping_createdby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_createdonbehalfby")]
    public IEnumerable<UII_workflow_workflowstep_mapping> lk_uii_workflow_workflowstep_mapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_workflowstep_mapping_createdonbehalfby");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_workflowstep_mapping_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_modifiedby")]
    public IEnumerable<UII_workflow_workflowstep_mapping> lk_uii_workflow_workflowstep_mapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_workflowstep_mapping_modifiedby");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_workflowstep_mapping_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby")]
    public IEnumerable<UII_workflow_workflowstep_mapping> lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_createdby")]
    public IEnumerable<UII_workflowstep> lk_uii_workflowstep_createdby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflowstep_createdby");
        this.SetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflowstep_createdby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_createdonbehalfby")]
    public IEnumerable<UII_workflowstep> lk_uii_workflowstep_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflowstep_createdonbehalfby");
        this.SetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflowstep_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_modifiedby")]
    public IEnumerable<UII_workflowstep> lk_uii_workflowstep_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflowstep_modifiedby");
        this.SetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflowstep_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_modifiedonbehalfby")]
    public IEnumerable<UII_workflowstep> lk_uii_workflowstep_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_uii_workflowstep_modifiedonbehalfby");
        this.SetRelatedEntities<UII_workflowstep>("lk_uii_workflowstep_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_uii_workflowstep_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
    public IEnumerable<WebResource> lk_webresourcebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_webresourcebase_createdonbehalfby");
        this.SetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_webresourcebase_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
    public IEnumerable<WebResource> lk_webresourcebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_webresourcebase_modifiedonbehalfby");
        this.SetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_webresourcebase_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_createdby")]
    public IEnumerable<WorkflowLog> lk_workflowlog_createdby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_createdby");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_createdby");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
    public IEnumerable<WorkflowLog> lk_workflowlog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_createdonbehalfby");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_modifiedby")]
    public IEnumerable<WorkflowLog> lk_workflowlog_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_modifiedby");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_modifiedby");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
    public IEnumerable<WorkflowLog> lk_workflowlog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_modifiedonbehalfby");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("modifiedby_connection_role")]
    public IEnumerable<ConnectionRole> modifiedby_connection_role
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("modifiedby_connection_role", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_connection_role");
        this.SetRelatedEntities<ConnectionRole>("modifiedby_connection_role", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_connection_role");
      }
    }

    [RelationshipSchemaName("modifiedby_pluginassembly")]
    public IEnumerable<PluginAssembly> modifiedby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_pluginassembly");
        this.SetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_pluginassembly");
      }
    }

    [RelationshipSchemaName("modifiedby_plugintype")]
    public IEnumerable<PluginType> modifiedby_plugintype
    {
      get
      {
        return this.GetRelatedEntities<PluginType>("modifiedby_plugintype", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_plugintype");
        this.SetRelatedEntities<PluginType>("modifiedby_plugintype", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_plugintype");
      }
    }

    [RelationshipSchemaName("modifiedby_plugintypestatistic")]
    public IEnumerable<PluginTypeStatistic> modifiedby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_plugintypestatistic");
        this.SetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_plugintypestatistic");
      }
    }

    [RelationshipSchemaName("modifiedby_relationship_role")]
    public IEnumerable<RelationshipRole> modifiedby_relationship_role
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRole>("modifiedby_relationship_role", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_relationship_role");
        this.SetRelatedEntities<RelationshipRole>("modifiedby_relationship_role", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_relationship_role");
      }
    }

    [RelationshipSchemaName("modifiedby_relationship_role_map")]
    public IEnumerable<RelationshipRoleMap> modifiedby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>("modifiedby_relationship_role_map", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_relationship_role_map");
        this.SetRelatedEntities<RelationshipRoleMap>("modifiedby_relationship_role_map", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_relationship_role_map");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessage")]
    public IEnumerable<SdkMessage> modifiedby_sdkmessage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessage");
        this.SetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessage");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagefilter")]
    public IEnumerable<SdkMessageFilter> modifiedby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessagefilter");
        this.SetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessagefilter");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagepair")]
    public IEnumerable<SdkMessagePair> modifiedby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>("modifiedby_sdkmessagepair", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessagepair");
        this.SetRelatedEntities<SdkMessagePair>("modifiedby_sdkmessagepair", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessagepair");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> modifiedby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepimage")]
    public IEnumerable<SdkMessageProcessingStepImage> modifiedby_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepimage");
        this.SetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepimage");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepsecureconfig")]
    public IEnumerable<SdkMessageProcessingStepSecureConfig> modifiedby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepsecureconfig");
        this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepsecureconfig");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagerequest")]
    public IEnumerable<SdkMessageRequest> modifiedby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>("modifiedby_sdkmessagerequest", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessagerequest");
        this.SetRelatedEntities<SdkMessageRequest>("modifiedby_sdkmessagerequest", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessagerequest");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagerequestfield")]
    public IEnumerable<SdkMessageRequestField> modifiedby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessagerequestfield");
        this.SetRelatedEntities<SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessagerequestfield");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageresponse")]
    public IEnumerable<SdkMessageResponse> modifiedby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>("modifiedby_sdkmessageresponse", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessageresponse");
        this.SetRelatedEntities<SdkMessageResponse>("modifiedby_sdkmessageresponse", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessageresponse");
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageresponsefield")]
    public IEnumerable<SdkMessageResponseField> modifiedby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_sdkmessageresponsefield");
        this.SetRelatedEntities<SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_sdkmessageresponsefield");
      }
    }

    [RelationshipSchemaName("modifiedby_serviceendpoint")]
    public IEnumerable<ServiceEndpoint> modifiedby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("modifiedby_serviceendpoint");
        this.SetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", new EntityRole?(), value);
        this.OnPropertyChanged("modifiedby_serviceendpoint");
      }
    }

    [RelationshipSchemaName("system_user_asyncoperation")]
    public IEnumerable<AsyncOperation> system_user_asyncoperation
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("system_user_asyncoperation", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("system_user_asyncoperation");
        this.SetRelatedEntities<AsyncOperation>("system_user_asyncoperation", new EntityRole?(), value);
        this.OnPropertyChanged("system_user_asyncoperation");
      }
    }

    [RelationshipSchemaName("system_user_workflow")]
    public IEnumerable<Workflow> system_user_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("system_user_workflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("system_user_workflow");
        this.SetRelatedEntities<Workflow>("system_user_workflow", new EntityRole?(), value);
        this.OnPropertyChanged("system_user_workflow");
      }
    }

    [RelationshipSchemaName("SystemUser_AsyncOperations")]
    public IEnumerable<AsyncOperation> SystemUser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("SystemUser_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("SystemUser_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("SystemUser_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("SystemUser_AsyncOperations");
      }
    }

    [RelationshipSchemaName("user_customer_opportunity_roles")]
    public IEnumerable<CustomerOpportunityRole> user_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("user_customer_opportunity_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_customer_opportunity_roles");
        this.SetRelatedEntities<CustomerOpportunityRole>("user_customer_opportunity_roles", new EntityRole?(), value);
        this.OnPropertyChanged("user_customer_opportunity_roles");
      }
    }

    [RelationshipSchemaName("user_incidentresolution")]
    public IEnumerable<IncidentResolution> user_incidentresolution
    {
      get
      {
        return this.GetRelatedEntities<IncidentResolution>("user_incidentresolution", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_incidentresolution");
        this.SetRelatedEntities<IncidentResolution>("user_incidentresolution", new EntityRole?(), value);
        this.OnPropertyChanged("user_incidentresolution");
      }
    }

    [RelationshipSchemaName("user_msdyusd_actioncallworkflow")]
    public IEnumerable<msdyusd_actioncallworkflow> user_msdyusd_actioncallworkflow
    {
      get
      {
        return this.GetRelatedEntities<msdyusd_actioncallworkflow>("user_msdyusd_actioncallworkflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_msdyusd_actioncallworkflow");
        this.SetRelatedEntities<msdyusd_actioncallworkflow>("user_msdyusd_actioncallworkflow", new EntityRole?(), value);
        this.OnPropertyChanged("user_msdyusd_actioncallworkflow");
      }
    }

    [RelationshipSchemaName("user_parent_user", EntityRole.Referenced)]
    public IEnumerable<SystemUser> Referenceduser_parent_user
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("user_parent_user", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referenceduser_parent_user");
        this.SetRelatedEntities<SystemUser>("user_parent_user", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referenceduser_parent_user");
      }
    }

    [RelationshipSchemaName("user_uii_workflow")]
    public IEnumerable<UII_workflow> user_uii_workflow
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow>("user_uii_workflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_uii_workflow");
        this.SetRelatedEntities<UII_workflow>("user_uii_workflow", new EntityRole?(), value);
        this.OnPropertyChanged("user_uii_workflow");
      }
    }

    [RelationshipSchemaName("user_uii_workflow_workflowstep_mapping")]
    public IEnumerable<UII_workflow_workflowstep_mapping> user_uii_workflow_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("user_uii_workflow_workflowstep_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_uii_workflow_workflowstep_mapping");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("user_uii_workflow_workflowstep_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("user_uii_workflow_workflowstep_mapping");
      }
    }

    [RelationshipSchemaName("user_uii_workflowstep")]
    public IEnumerable<UII_workflowstep> user_uii_workflowstep
    {
      get
      {
        return this.GetRelatedEntities<UII_workflowstep>("user_uii_workflowstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("user_uii_workflowstep");
        this.SetRelatedEntities<UII_workflowstep>("user_uii_workflowstep", new EntityRole?(), value);
        this.OnPropertyChanged("user_uii_workflowstep");
      }
    }

    [RelationshipSchemaName("webresource_createdby")]
    public IEnumerable<WebResource> webresource_createdby
    {
      get
      {
        return this.GetRelatedEntities<WebResource>("webresource_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("webresource_createdby");
        this.SetRelatedEntities<WebResource>("webresource_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("webresource_createdby");
      }
    }

    [RelationshipSchemaName("webresource_modifiedby")]
    public IEnumerable<WebResource> webresource_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<WebResource>("webresource_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("webresource_modifiedby");
        this.SetRelatedEntities<WebResource>("webresource_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("webresource_modifiedby");
      }
    }

    [RelationshipSchemaName("workflow_createdby")]
    public IEnumerable<Workflow> workflow_createdby
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_createdby");
        this.SetRelatedEntities<Workflow>("workflow_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_createdby");
      }
    }

    [RelationshipSchemaName("workflow_createdonbehalfby")]
    public IEnumerable<Workflow> workflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_createdonbehalfby");
        this.SetRelatedEntities<Workflow>("workflow_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("workflow_dependency_createdby")]
    public IEnumerable<WorkflowDependency> workflow_dependency_createdby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependency_createdby");
        this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_createdby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependency_createdby");
      }
    }

    [RelationshipSchemaName("workflow_dependency_createdonbehalfby")]
    public IEnumerable<WorkflowDependency> workflow_dependency_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependency_createdonbehalfby");
        this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_createdonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependency_createdonbehalfby");
      }
    }

    [RelationshipSchemaName("workflow_dependency_modifiedby")]
    public IEnumerable<WorkflowDependency> workflow_dependency_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependency_modifiedby");
        this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependency_modifiedby");
      }
    }

    [RelationshipSchemaName("workflow_dependency_modifiedonbehalfby")]
    public IEnumerable<WorkflowDependency> workflow_dependency_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependency_modifiedonbehalfby");
        this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependency_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("workflow_modifiedby")]
    public IEnumerable<Workflow> workflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_modifiedby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_modifiedby");
        this.SetRelatedEntities<Workflow>("workflow_modifiedby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_modifiedby");
      }
    }

    [RelationshipSchemaName("workflow_modifiedonbehalfby")]
    public IEnumerable<Workflow> workflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_modifiedonbehalfby", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_modifiedonbehalfby");
        this.SetRelatedEntities<Workflow>("workflow_modifiedonbehalfby", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_modifiedonbehalfby");
      }
    }

    [RelationshipSchemaName("systemuserprofiles_association")]
    public IEnumerable<FieldSecurityProfile> systemuserprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserprofiles_association");
        this.SetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserprofiles_association");
      }
    }

    [RelationshipSchemaName("systemuserroles_association")]
    public IEnumerable<Role> systemuserroles_association
    {
      get
      {
        return this.GetRelatedEntities<Role>("systemuserroles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserroles_association");
        this.SetRelatedEntities<Role>("systemuserroles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserroles_association");
      }
    }

    [RelationshipSchemaName("business_unit_system_users")]
    [AttributeLogicalName("businessunitid")]
    public BusinessUnit business_unit_system_users
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_system_users", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_system_users");
        this.SetRelatedEntity<BusinessUnit>("business_unit_system_users", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_system_users");
      }
    }

    [RelationshipSchemaName("lk_systemuser_createdonbehalfby", EntityRole.Referencing)]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser Referencinglk_systemuser_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?(EntityRole.Referencing));
      }
    }

    [RelationshipSchemaName("lk_systemuser_modifiedonbehalfby", EntityRole.Referencing)]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser Referencinglk_systemuser_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?(EntityRole.Referencing));
      }
    }

    [RelationshipSchemaName("lk_systemuserbase_createdby", EntityRole.Referencing)]
    [AttributeLogicalName("createdby")]
    public SystemUser Referencinglk_systemuserbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", new EntityRole?(EntityRole.Referencing));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_systemuserbase_modifiedby", EntityRole.Referencing)]
    public SystemUser Referencinglk_systemuserbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?(EntityRole.Referencing));
      }
    }

    [RelationshipSchemaName("user_parent_user", EntityRole.Referencing)]
    [AttributeLogicalName("parentsystemuserid")]
    public SystemUser Referencinguser_parent_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_parent_user", new EntityRole?(EntityRole.Referencing));
      }
      set
      {
        this.OnPropertyChanging("Referencinguser_parent_user");
        this.SetRelatedEntity<SystemUser>("user_parent_user", new EntityRole?(EntityRole.Referencing), value);
        this.OnPropertyChanged("Referencinguser_parent_user");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SystemUser()
      : base("systemuser")
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
