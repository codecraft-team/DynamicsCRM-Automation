using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessunitnewsarticle")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class BusinessUnitNewsArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessunitnewsarticle";
    public const int EntityTypeCode = 132;

    [AttributeLogicalName("activeon")]
    public DateTime? ActiveOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("activeon");
      }
      set
      {
        this.OnPropertyChanging("ActiveOn");
        this.SetAttributeValue("activeon", (object) value);
        this.OnPropertyChanged("ActiveOn");
      }
    }

    [AttributeLogicalName("activeuntil")]
    public DateTime? ActiveUntil
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("activeuntil");
      }
      set
      {
        this.OnPropertyChanging("ActiveUntil");
        this.SetAttributeValue("activeuntil", (object) value);
        this.OnPropertyChanged("ActiveUntil");
      }
    }

    [AttributeLogicalName("articletitle")]
    public string ArticleTitle
    {
      get
      {
        return this.GetAttributeValue<string>("articletitle");
      }
      set
      {
        this.OnPropertyChanging("ArticleTitle");
        this.SetAttributeValue("articletitle", (object) value);
        this.OnPropertyChanged("ArticleTitle");
      }
    }

    [AttributeLogicalName("articletypecode")]
    public OptionSetValue ArticleTypeCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("articletypecode");
      }
      set
      {
        this.OnPropertyChanging("ArticleTypeCode");
        this.SetAttributeValue("articletypecode", (object) value);
        this.OnPropertyChanged("ArticleTypeCode");
      }
    }

    [AttributeLogicalName("articleurl")]
    public string ArticleUrl
    {
      get
      {
        return this.GetAttributeValue<string>("articleurl");
      }
      set
      {
        this.OnPropertyChanging("ArticleUrl");
        this.SetAttributeValue("articleurl", (object) value);
        this.OnPropertyChanged("ArticleUrl");
      }
    }

    [AttributeLogicalName("businessunitnewsarticleid")]
    public Guid? BusinessUnitNewsArticleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("businessunitnewsarticleid");
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitNewsArticleId");
        this.SetAttributeValue("businessunitnewsarticleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("BusinessUnitNewsArticleId");
      }
    }

    [AttributeLogicalName("businessunitnewsarticleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.BusinessUnitNewsArticleId = new Guid?(value);
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

    [AttributeLogicalName("newsarticle")]
    public string NewsArticle
    {
      get
      {
        return this.GetAttributeValue<string>("newsarticle");
      }
      set
      {
        this.OnPropertyChanging("NewsArticle");
        this.SetAttributeValue("newsarticle", (object) value);
        this.OnPropertyChanged("NewsArticle");
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

    [AttributeLogicalName("showonhomepage")]
    public bool? ShowOnHomepage
    {
      get
      {
        return this.GetAttributeValue<bool?>("showonhomepage");
      }
      set
      {
        this.OnPropertyChanging("ShowOnHomepage");
        this.SetAttributeValue("showonhomepage", (object) value);
        this.OnPropertyChanged("ShowOnHomepage");
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

    [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
    public IEnumerable<AsyncOperation> BusinessUnitNewsArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("BusinessUnitNewsArticle_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("BusinessUnitNewsArticle_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_businessunitnewsarticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_businessunitnewsarticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_businessunitnewsarticlebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser lk_businessunitnewsarticlebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_modifiedby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public BusinessUnitNewsArticle()
      : base("businessunitnewsarticle")
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
