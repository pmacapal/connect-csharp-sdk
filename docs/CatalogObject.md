# Square.Connect.Model.CatalogObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | The type of this object. Each object type has expected properties expressed in a structured format within its corresponding &#x60;*_data&#x60; field below.  See [CatalogObjectType](#type-catalogobjecttype) for all possible values. | 
**Id** | **string** | An identifier to reference this object in the catalog. When a new CatalogObject is inserted, the client should set the id to a temporary identifier starting with a &#x60;&#39;#&#39;&#x60; character. Other objects being inserted or updated within the same request may use this identifier to refer to the new object.  When the server receives the new object, it will supply a unique identifier that replaces the temporary identifier for all future references. | 
**UpdatedAt** | **string** | Last modification [timestamp](#workingwithdates) in RFC 3339 format, e.g., &#x60;\&quot;2016-08-15T23:59:33.123Z\&quot;&#x60; would indicate the UTC time (denoted by &#x60;Z&#x60;) of August 15, 2016 at 23:59:33 and 123 milliseconds. | [optional] 
**Version** | **long?** | The version of the object. When updating an object, the version supplied must match the version in the database, otherwise the write will be rejected as conflicting. | [optional] 
**IsDeleted** | **bool?** | If &#x60;true&#x60;, the object has been deleted from the database. Must be &#x60;false&#x60; for new objects being inserted. When deleted, the &#x60;updated_at&#x60; field will equal the deletion time. | [optional] 
**CatalogV1Ids** | [**List&lt;CatalogV1Id&gt;**](CatalogV1Id.md) | The Connect V1 IDs for this object at each [location](#type-location) where it is present, where they differ from the object&#39;s Connect V2 ID. The field will only be present for objects that have been created or modified by legacy APIs. | [optional] 
**PresentAtAllLocations** | **bool?** | If &#x60;true&#x60;, this object is present at all locations (including future locations), except where specified in the &#x60;absent_at_location_ids&#x60; field. If &#x60;false&#x60;, this object is not present at any locations (including future locations), except where specified in the &#x60;present_at_location_ids&#x60; field. If not specified, defaults to &#x60;true&#x60;. | [optional] 
**PresentAtLocationIds** | **List<string>** | A list of locations where the object is present, even if &#x60;present_at_all_locations&#x60; is &#x60;false&#x60;. | [optional] 
**AbsentAtLocationIds** | **List<string>** | A list of locations where the object is not present, even if &#x60;present_at_all_locations&#x60; is &#x60;true&#x60;. | [optional] 
**ItemData** | [**CatalogItem**](CatalogItem.md) | Structured data for a [CatalogItem](#type-catalogitem), set for CatalogObjects of type &#x60;ITEM&#x60;. | [optional] 
**CategoryData** | [**CatalogCategory**](CatalogCategory.md) | Structured data for a [CatalogCategory](#type-catalogcategory), set for CatalogObjects of type &#x60;CATEGORY&#x60;. | [optional] 
**ItemVariationData** | [**CatalogItemVariation**](CatalogItemVariation.md) | Structured data for a [CatalogItemVariation](#type-catalogitemvariation), set for CatalogObjects of type &#x60;ITEM_VARIATION&#x60;. | [optional] 
**TaxData** | [**CatalogTax**](CatalogTax.md) | Structured data for a [CatalogTax](#type-catalogtax), set for CatalogObjects of type &#x60;TAX&#x60;. | [optional] 
**DiscountData** | [**CatalogDiscount**](CatalogDiscount.md) | Structured data for a [CatalogDiscount](#type-catalogdiscount), set for CatalogObjects of type &#x60;DISCOUNT&#x60;. | [optional] 
**ModifierListData** | [**CatalogModifierList**](CatalogModifierList.md) | Structured data for a [CatalogModifierList](#type-catalogmodifierlist), set for CatalogObjects of type &#x60;MODIFIER_LIST&#x60;. | [optional] 
**ModifierData** | [**CatalogModifier**](CatalogModifier.md) | Structured data for a [CatalogModifier](#type-catalogmodifier), set for CatalogObjects of type &#x60;MODIFIER&#x60;. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**ITEM** | "ITEM"
**CATEGORY** | "CATEGORY"
**ITEMVARIATION** | "ITEM_VARIATION"
**TAX** | "TAX"
**DISCOUNT** | "DISCOUNT"
**MODIFIERLIST** | "MODIFIER_LIST"
**MODIFIER** | "MODIFIER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

