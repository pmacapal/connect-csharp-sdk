# Square.Connect.Model.SearchCatalogObjectsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cursor** | **string** | The pagination cursor returned in the previous response. Leave unset for an initial request. See [Paginating results](#paginatingresults) for more information. | [optional] 
**ObjectTypes** | **List<ObjectTypesEnum>** | The desired set of object types to apper in the search results. The legal values are taken from the [CatalogObjectType](#type-catalogobjecttype) enumeration, namely &#x60;\&quot;ITEM\&quot;&#x60;, &#x60;\&quot;ITEM_VARIATION\&quot;&#x60;, &#x60;\&quot;CATEGORY\&quot;&#x60;, &#x60;\&quot;DISCOUNT\&quot;&#x60;, &#x60;\&quot;TAX\&quot;&#x60;, &#x60;\&quot;MODIFIER\&quot;&#x60;, or &#x60;\&quot;MODIFIER_LIST\&quot;&#x60;. | [optional] 
**IncludeDeletedObjects** | **bool?** | If &#x60;true&#x60;, deleted objects will be included in the results. Deleted objects will have their &#x60;is_deleted&#x60; field set to &#x60;true&#x60;. | [optional] 
**IncludeRelatedObjects** | **bool?** | If &#x60;true&#x60;, the response will include additional objects that are related to the requested object, as follows:  If a [CatalogItem](#type-catalogitem) is returned in the object field of the response, its associated [CatalogCategory](#type-catalogcategory), [CatalogTax](#type-catalogtax)es, and [CatalogModifierList](#type-catalogmodifierlist)s will be included in the &#x60;related_objects&#x60; field of the response.  If a [CatalogItemVariation](#type-catalogitemvariation) is returned in the object field of the response, its parent [CatalogItem](#type-catalogitem) will be included in the &#x60;related_objects&#x60; field of the response. | [optional] 
**BeginTime** | **string** | Return only objects that have been modified after this [timestamp](#workingwithdates) (in RFC 3339 format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;). | [optional] 
**Query** | [**CatalogQuery**](CatalogQuery.md) | A query to be used to filter or sort the results. If no query is specified, the entire catalog will be returned. | [optional] 
**Limit** | **int?** | A limit on the number of results to be returned in a single page. The limit is advisory - the implementation may return more or fewer results. If the supplied limit is negative, zero, or is higher than the maximum limit of 1,000, it will be ignored. | [optional] 


## List<ObjectTypesEnum>

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
