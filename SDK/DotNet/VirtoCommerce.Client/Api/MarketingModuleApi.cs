using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using VirtoCommerce.Client.Client;
using VirtoCommerce.Client.Model;


namespace VirtoCommerce.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMarketingModuleApi
    {
        
        /// <summary>
        /// Update a existing dynamic content folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="folder">dynamic content folder that needs to be updated</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentUpdateDynamicContentFolder (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder);
  
        /// <summary>
        /// Update a existing dynamic content folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="folder">dynamic content folder that needs to be updated</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentFolderAsync (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder);
        
        /// <summary>
        /// Add new dynamic content folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="folder">dynamic content folder that needs to be added</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentFolder MarketingModuleDynamicContentCreateDynamicContentFolder (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder);
  
        /// <summary>
        /// Add new dynamic content folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="folder">dynamic content folder that needs to be added</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentFolder> MarketingModuleDynamicContentCreateDynamicContentFolderAsync (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder);
        
        /// <summary>
        /// Delete a dynamic content folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">folders ids for delete</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentDeleteDynamicContentFolders (List<string> ids);
  
        /// <summary>
        /// Delete a dynamic content folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">folders ids for delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentFoldersAsync (List<string> ids);
        
        /// <summary>
        /// Find dynamic content folder by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content folder
        /// </remarks>
        /// <param name="id">folder id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentFolder MarketingModuleDynamicContentGetDynamicContentFolderById (string id);
  
        /// <summary>
        /// Find dynamic content folder by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content folder
        /// </remarks>
        /// <param name="id">folder id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentFolder> MarketingModuleDynamicContentGetDynamicContentFolderByIdAsync (string id);
        
        /// <summary>
        /// Update a existing dynamic content item object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentItem">dynamic content object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentUpdateDynamicContent (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem);
  
        /// <summary>
        /// Update a existing dynamic content item object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentItem">dynamic content object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentAsync (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem);
        
        /// <summary>
        /// Add new dynamic content item object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentItem">dynamic content object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentItem MarketingModuleDynamicContentCreateDynamicContent (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem);
  
        /// <summary>
        /// Add new dynamic content item object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentItem">dynamic content object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentCreateDynamicContentAsync (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem);
        
        /// <summary>
        /// Delete a dynamic content item objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content item object ids for delete in the dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentDeleteDynamicContents (List<string> ids);
  
        /// <summary>
        /// Delete a dynamic content item objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content item object ids for delete in the dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentsAsync (List<string> ids);
        
        /// <summary>
        /// Get dynamic content for given placeholders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="storeId"></param>
        /// <param name="placeHolder"></param>
        /// <returns></returns>
        List<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentEvaluateDynamicContent (string storeId, string placeHolder);
  
        /// <summary>
        /// Get dynamic content for given placeholders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="storeId"></param>
        /// <param name="placeHolder"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>> MarketingModuleDynamicContentEvaluateDynamicContentAsync (string storeId, string placeHolder);
        
        /// <summary>
        /// Find dynamic content item object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content item object
        /// </remarks>
        /// <param name="id">content item id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentItem MarketingModuleDynamicContentGetDynamicContentById (string id);
  
        /// <summary>
        /// Find dynamic content item object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content item object
        /// </remarks>
        /// <param name="id">content item id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentGetDynamicContentByIdAsync (string id);
        
        /// <summary>
        /// Update a existing dynamic content place object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentPlace">dynamic content place object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentUpdateDynamicContentPlace (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace);
  
        /// <summary>
        /// Update a existing dynamic content place object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentPlace">dynamic content place object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentPlaceAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace);
        
        /// <summary>
        /// Add new dynamic content place object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentPlace">dynamic content place object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentPlace MarketingModuleDynamicContentCreateDynamicContentPlace (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace);
  
        /// <summary>
        /// Add new dynamic content place object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contentPlace">dynamic content place object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPlace> MarketingModuleDynamicContentCreateDynamicContentPlaceAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace);
        
        /// <summary>
        /// Delete a dynamic content place objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content place object ids for delete from dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentDeleteDynamicContentPlaces (List<string> ids);
  
        /// <summary>
        /// Delete a dynamic content place objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content place object ids for delete from dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentPlacesAsync (List<string> ids);
        
        /// <summary>
        /// Find dynamic content place object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content place object
        /// </remarks>
        /// <param name="id">place id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentPlace MarketingModuleDynamicContentGetDynamicContentPlaceById (string id);
  
        /// <summary>
        /// Find dynamic content place object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content place object
        /// </remarks>
        /// <param name="id">place id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPlace> MarketingModuleDynamicContentGetDynamicContentPlaceByIdAsync (string id);
        
        /// <summary>
        /// Update a existing dynamic content publication object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publication">dynamic content publication object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentUpdateDynamicContentPublication (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication);
  
        /// <summary>
        /// Update a existing dynamic content publication object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publication">dynamic content publication object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentPublicationAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication);
        
        /// <summary>
        /// Add new dynamic content publication object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publication">dynamic content publication object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentCreateDynamicContentPublication (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication);
  
        /// <summary>
        /// Add new dynamic content publication object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publication">dynamic content publication object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentCreateDynamicContentPublicationAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication);
        
        /// <summary>
        /// Delete a dynamic content publication objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content publication object ids for delete from dynamic content system</param>
        /// <returns></returns>
        void MarketingModuleDynamicContentDeleteDynamicContentPublications (List<string> ids);
  
        /// <summary>
        /// Delete a dynamic content publication objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">content publication object ids for delete from dynamic content system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentPublicationsAsync (List<string> ids);
        
        /// <summary>
        /// Get new dynamic content publication object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentGetNewDynamicPublication ();
  
        /// <summary>
        /// Get new dynamic content publication object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentGetNewDynamicPublicationAsync ();
        
        /// <summary>
        /// Find dynamic content publication object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content publication object
        /// </remarks>
        /// <param name="id">publication id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentGetDynamicContentPublicationById (string id);
  
        /// <summary>
        /// Find dynamic content publication object by id
        /// </summary>
        /// <remarks>
        /// Return a single dynamic content publication object
        /// </remarks>
        /// <param name="id">publication id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentGetDynamicContentPublicationByIdAsync (string id);
        
        /// <summary>
        /// Update a existing dynamic promotion object in marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promotion">&amp;gt;dynamic promotion object that needs to be updated in the marketing system</param>
        /// <returns></returns>
        void MarketingModulePromotionUpdatePromotions (VirtoCommerceMarketingModuleWebModelPromotion promotion);
  
        /// <summary>
        /// Update a existing dynamic promotion object in marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promotion">&amp;gt;dynamic promotion object that needs to be updated in the marketing system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModulePromotionUpdatePromotionsAsync (VirtoCommerceMarketingModuleWebModelPromotion promotion);
        
        /// <summary>
        /// Add new dynamic promotion object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promotion">dynamic promotion object that needs to be added to the marketing system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionCreatePromotion (VirtoCommerceMarketingModuleWebModelPromotion promotion);
  
        /// <summary>
        /// Add new dynamic promotion object to marketing system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promotion">dynamic promotion object that needs to be added to the marketing system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionCreatePromotionAsync (VirtoCommerceMarketingModuleWebModelPromotion promotion);
        
        /// <summary>
        /// Delete promotions objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">promotions object ids for delete in the marketing system</param>
        /// <returns></returns>
        void MarketingModulePromotionDeletePromotions (List<string> ids);
  
        /// <summary>
        /// Delete promotions objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ids">promotions object ids for delete in the marketing system</param>
        /// <returns></returns>
        System.Threading.Tasks.Task MarketingModulePromotionDeletePromotionsAsync (List<string> ids);
        
        /// <summary>
        /// Evaluate promotions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="context">Promotion evaluation context</param>
        /// <returns></returns>
        List<VirtoCommerceMarketingModuleWebModelPromotionReward> MarketingModulePromotionEvaluatePromotions (VirtoCommerceDomainMarketingModelPromotionEvaluationContext context);
  
        /// <summary>
        /// Evaluate promotions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="context">Promotion evaluation context</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<VirtoCommerceMarketingModuleWebModelPromotionReward>> MarketingModulePromotionEvaluatePromotionsAsync (VirtoCommerceDomainMarketingModelPromotionEvaluationContext context);
        
        /// <summary>
        /// Get new dynamic promotion object
        /// </summary>
        /// <remarks>
        /// Return a new dynamic promotion object with populated dynamic expression tree
        /// </remarks>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionGetNewDynamicPromotion ();
  
        /// <summary>
        /// Get new dynamic promotion object
        /// </summary>
        /// <remarks>
        /// Return a new dynamic promotion object with populated dynamic expression tree
        /// </remarks>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionGetNewDynamicPromotionAsync ();
        
        /// <summary>
        /// Find promotion object by id
        /// </summary>
        /// <remarks>
        /// Return a single promotion (dynamic or custom) object
        /// </remarks>
        /// <param name="id">promotion id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionGetPromotionById (string id);
  
        /// <summary>
        /// Find promotion object by id
        /// </summary>
        /// <remarks>
        /// Return a single promotion (dynamic or custom) object
        /// </remarks>
        /// <param name="id">promotion id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionGetPromotionByIdAsync (string id);
        
        /// <summary>
        /// Search marketing objects by given criteria
        /// </summary>
        /// <remarks>
        /// Allow to find all marketing module objects (Promotions, Dynamic content objects)
        /// </remarks>
        /// <param name="criteriaFolderId"></param>
        /// <param name="criteriaResponseGroup"></param>
        /// <param name="criteriaKeyword"></param>
        /// <param name="criteriaStart"></param>
        /// <param name="criteriaCount"></param>
        /// <returns>VirtoCommerceMarketingModuleWebModelMarketingSearchResult</returns>
        VirtoCommerceMarketingModuleWebModelMarketingSearchResult MarketingModuleSearch (string criteriaFolderId = null, string criteriaResponseGroup = null, string criteriaKeyword = null, int? criteriaStart = null, int? criteriaCount = null);
  
        /// <summary>
        /// Search marketing objects by given criteria
        /// </summary>
        /// <remarks>
        /// Allow to find all marketing module objects (Promotions, Dynamic content objects)
        /// </remarks>
        /// <param name="criteriaFolderId"></param>
        /// <param name="criteriaResponseGroup"></param>
        /// <param name="criteriaKeyword"></param>
        /// <param name="criteriaStart"></param>
        /// <param name="criteriaCount"></param>
        /// <returns>VirtoCommerceMarketingModuleWebModelMarketingSearchResult</returns>
        System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelMarketingSearchResult> MarketingModuleSearchAsync (string criteriaFolderId = null, string criteriaResponseGroup = null, string criteriaKeyword = null, int? criteriaStart = null, int? criteriaCount = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketingModuleApi : IMarketingModuleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingModuleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public MarketingModuleApi(ApiClient apiClient)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Update a existing dynamic content folder 
        /// </summary>
        /// <param name="folder">dynamic content folder that needs to be updated</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentUpdateDynamicContentFolder (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder)
        {
            
            // verify the required parameter 'folder' is set
            if (folder == null) throw new ApiException(400, "Missing required parameter 'folder' when calling MarketingModuleDynamicContentUpdateDynamicContentFolder");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(folder); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a existing dynamic content folder 
        /// </summary>
        /// <param name="folder">dynamic content folder that needs to be updated</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentFolderAsync (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder)
        {
            // verify the required parameter 'folder' is set
            if (folder == null) throw new ApiException(400, "Missing required parameter 'folder' when calling MarketingModuleDynamicContentUpdateDynamicContentFolder");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(folder); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentFolder: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Add new dynamic content folder 
        /// </summary>
        /// <param name="folder">dynamic content folder that needs to be added</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentFolder MarketingModuleDynamicContentCreateDynamicContentFolder (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder)
        {
            
            // verify the required parameter 'folder' is set
            if (folder == null) throw new ApiException(400, "Missing required parameter 'folder' when calling MarketingModuleDynamicContentCreateDynamicContentFolder");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(folder); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentFolder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentFolder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentFolder) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentFolder));
        }
    
        /// <summary>
        /// Add new dynamic content folder 
        /// </summary>
        /// <param name="folder">dynamic content folder that needs to be added</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentFolder> MarketingModuleDynamicContentCreateDynamicContentFolderAsync (VirtoCommerceMarketingModuleWebModelDynamicContentFolder folder)
        {
            // verify the required parameter 'folder' is set
            if (folder == null) throw new ApiException(400, "Missing required parameter 'folder' when calling MarketingModuleDynamicContentCreateDynamicContentFolder");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(folder); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentFolder: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentFolder) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentFolder));
        }
        
        /// <summary>
        /// Delete a dynamic content folders 
        /// </summary>
        /// <param name="ids">folders ids for delete</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentDeleteDynamicContentFolders (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentFolders");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentFolders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentFolders: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a dynamic content folders 
        /// </summary>
        /// <param name="ids">folders ids for delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentFoldersAsync (List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentFolders");
            
    
            var path_ = "/api/marketing/contentfolders";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentFolders: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Find dynamic content folder by id Return a single dynamic content folder
        /// </summary>
        /// <param name="id">folder id</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentFolder MarketingModuleDynamicContentGetDynamicContentFolderById (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentFolderById");
            
    
            var path_ = "/api/marketing/contentfolders/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentFolderById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentFolderById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentFolder) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentFolder));
        }
    
        /// <summary>
        /// Find dynamic content folder by id Return a single dynamic content folder
        /// </summary>
        /// <param name="id">folder id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentFolder</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentFolder> MarketingModuleDynamicContentGetDynamicContentFolderByIdAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentFolderById");
            
    
            var path_ = "/api/marketing/contentfolders/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentFolderById: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentFolder) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentFolder));
        }
        
        /// <summary>
        /// Update a existing dynamic content item object 
        /// </summary>
        /// <param name="contentItem">dynamic content object that needs to be updated in the dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentUpdateDynamicContent (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem)
        {
            
            // verify the required parameter 'contentItem' is set
            if (contentItem == null) throw new ApiException(400, "Missing required parameter 'contentItem' when calling MarketingModuleDynamicContentUpdateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentItem); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a existing dynamic content item object 
        /// </summary>
        /// <param name="contentItem">dynamic content object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentAsync (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem)
        {
            // verify the required parameter 'contentItem' is set
            if (contentItem == null) throw new ApiException(400, "Missing required parameter 'contentItem' when calling MarketingModuleDynamicContentUpdateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentItem); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContent: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Add new dynamic content item object to marketing system 
        /// </summary>
        /// <param name="contentItem">dynamic content object that needs to be added to the dynamic content system</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentItem MarketingModuleDynamicContentCreateDynamicContent (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem)
        {
            
            // verify the required parameter 'contentItem' is set
            if (contentItem == null) throw new ApiException(400, "Missing required parameter 'contentItem' when calling MarketingModuleDynamicContentCreateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentItem); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentItem) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentItem));
        }
    
        /// <summary>
        /// Add new dynamic content item object to marketing system 
        /// </summary>
        /// <param name="contentItem">dynamic content object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentCreateDynamicContentAsync (VirtoCommerceMarketingModuleWebModelDynamicContentItem contentItem)
        {
            // verify the required parameter 'contentItem' is set
            if (contentItem == null) throw new ApiException(400, "Missing required parameter 'contentItem' when calling MarketingModuleDynamicContentCreateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentItem); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContent: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentItem) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentItem));
        }
        
        /// <summary>
        /// Delete a dynamic content item objects 
        /// </summary>
        /// <param name="ids">content item object ids for delete in the dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentDeleteDynamicContents (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContents");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a dynamic content item objects 
        /// </summary>
        /// <param name="ids">content item object ids for delete in the dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentsAsync (List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContents");
            
    
            var path_ = "/api/marketing/contentitems";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContents: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get dynamic content for given placeholders 
        /// </summary>
        /// <param name="storeId"></param> 
        /// <param name="placeHolder"></param> 
        /// <returns></returns>            
        public List<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentEvaluateDynamicContent (string storeId, string placeHolder)
        {
            
            // verify the required parameter 'storeId' is set
            if (storeId == null) throw new ApiException(400, "Missing required parameter 'storeId' when calling MarketingModuleDynamicContentEvaluateDynamicContent");
            
            // verify the required parameter 'placeHolder' is set
            if (placeHolder == null) throw new ApiException(400, "Missing required parameter 'placeHolder' when calling MarketingModuleDynamicContentEvaluateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems/evaluate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (storeId != null) queryParams.Add("storeId", ApiClient.ParameterToString(storeId)); // query parameter
            if (placeHolder != null) queryParams.Add("placeHolder", ApiClient.ParameterToString(placeHolder)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentEvaluateDynamicContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentEvaluateDynamicContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>));
        }
    
        /// <summary>
        /// Get dynamic content for given placeholders 
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="placeHolder"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>> MarketingModuleDynamicContentEvaluateDynamicContentAsync (string storeId, string placeHolder)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null) throw new ApiException(400, "Missing required parameter 'storeId' when calling MarketingModuleDynamicContentEvaluateDynamicContent");
            // verify the required parameter 'placeHolder' is set
            if (placeHolder == null) throw new ApiException(400, "Missing required parameter 'placeHolder' when calling MarketingModuleDynamicContentEvaluateDynamicContent");
            
    
            var path_ = "/api/marketing/contentitems/evaluate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (storeId != null) queryParams.Add("storeId", ApiClient.ParameterToString(storeId)); // query parameter
            if (placeHolder != null) queryParams.Add("placeHolder", ApiClient.ParameterToString(placeHolder)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentEvaluateDynamicContent: " + response.Content, response.Content);

            return (List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceMarketingModuleWebModelDynamicContentItem>));
        }
        
        /// <summary>
        /// Find dynamic content item object by id Return a single dynamic content item object
        /// </summary>
        /// <param name="id">content item id</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentItem MarketingModuleDynamicContentGetDynamicContentById (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentById");
            
    
            var path_ = "/api/marketing/contentitems/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentItem) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentItem));
        }
    
        /// <summary>
        /// Find dynamic content item object by id Return a single dynamic content item object
        /// </summary>
        /// <param name="id">content item id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentItem</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentItem> MarketingModuleDynamicContentGetDynamicContentByIdAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentById");
            
    
            var path_ = "/api/marketing/contentitems/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentById: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentItem) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentItem));
        }
        
        /// <summary>
        /// Update a existing dynamic content place object 
        /// </summary>
        /// <param name="contentPlace">dynamic content place object that needs to be updated in the dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentUpdateDynamicContentPlace (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace)
        {
            
            // verify the required parameter 'contentPlace' is set
            if (contentPlace == null) throw new ApiException(400, "Missing required parameter 'contentPlace' when calling MarketingModuleDynamicContentUpdateDynamicContentPlace");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentPlace); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPlace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPlace: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a existing dynamic content place object 
        /// </summary>
        /// <param name="contentPlace">dynamic content place object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentPlaceAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace)
        {
            // verify the required parameter 'contentPlace' is set
            if (contentPlace == null) throw new ApiException(400, "Missing required parameter 'contentPlace' when calling MarketingModuleDynamicContentUpdateDynamicContentPlace");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentPlace); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPlace: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Add new dynamic content place object to marketing system 
        /// </summary>
        /// <param name="contentPlace">dynamic content place object that needs to be added to the dynamic content system</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentPlace MarketingModuleDynamicContentCreateDynamicContentPlace (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace)
        {
            
            // verify the required parameter 'contentPlace' is set
            if (contentPlace == null) throw new ApiException(400, "Missing required parameter 'contentPlace' when calling MarketingModuleDynamicContentCreateDynamicContentPlace");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentPlace); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPlace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPlace: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentPlace) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPlace));
        }
    
        /// <summary>
        /// Add new dynamic content place object to marketing system 
        /// </summary>
        /// <param name="contentPlace">dynamic content place object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPlace> MarketingModuleDynamicContentCreateDynamicContentPlaceAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPlace contentPlace)
        {
            // verify the required parameter 'contentPlace' is set
            if (contentPlace == null) throw new ApiException(400, "Missing required parameter 'contentPlace' when calling MarketingModuleDynamicContentCreateDynamicContentPlace");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(contentPlace); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPlace: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentPlace) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPlace));
        }
        
        /// <summary>
        /// Delete a dynamic content place objects 
        /// </summary>
        /// <param name="ids">content place object ids for delete from dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentDeleteDynamicContentPlaces (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentPlaces");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPlaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPlaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a dynamic content place objects 
        /// </summary>
        /// <param name="ids">content place object ids for delete from dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentPlacesAsync (List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentPlaces");
            
    
            var path_ = "/api/marketing/contentplaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPlaces: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Find dynamic content place object by id Return a single dynamic content place object
        /// </summary>
        /// <param name="id">place id</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentPlace MarketingModuleDynamicContentGetDynamicContentPlaceById (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentPlaceById");
            
    
            var path_ = "/api/marketing/contentplaces/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPlaceById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPlaceById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentPlace) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPlace));
        }
    
        /// <summary>
        /// Find dynamic content place object by id Return a single dynamic content place object
        /// </summary>
        /// <param name="id">place id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPlace</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPlace> MarketingModuleDynamicContentGetDynamicContentPlaceByIdAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentPlaceById");
            
    
            var path_ = "/api/marketing/contentplaces/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPlaceById: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentPlace) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPlace));
        }
        
        /// <summary>
        /// Update a existing dynamic content publication object 
        /// </summary>
        /// <param name="publication">dynamic content publication object that needs to be updated in the dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentUpdateDynamicContentPublication (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication)
        {
            
            // verify the required parameter 'publication' is set
            if (publication == null) throw new ApiException(400, "Missing required parameter 'publication' when calling MarketingModuleDynamicContentUpdateDynamicContentPublication");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(publication); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPublication: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPublication: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a existing dynamic content publication object 
        /// </summary>
        /// <param name="publication">dynamic content publication object that needs to be updated in the dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentUpdateDynamicContentPublicationAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication)
        {
            // verify the required parameter 'publication' is set
            if (publication == null) throw new ApiException(400, "Missing required parameter 'publication' when calling MarketingModuleDynamicContentUpdateDynamicContentPublication");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(publication); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentUpdateDynamicContentPublication: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Add new dynamic content publication object to marketing system 
        /// </summary>
        /// <param name="publication">dynamic content publication object that needs to be added to the dynamic content system</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentCreateDynamicContentPublication (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication)
        {
            
            // verify the required parameter 'publication' is set
            if (publication == null) throw new ApiException(400, "Missing required parameter 'publication' when calling MarketingModuleDynamicContentCreateDynamicContentPublication");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(publication); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPublication: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPublication: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
    
        /// <summary>
        /// Add new dynamic content publication object to marketing system 
        /// </summary>
        /// <param name="publication">dynamic content publication object that needs to be added to the dynamic content system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentCreateDynamicContentPublicationAsync (VirtoCommerceMarketingModuleWebModelDynamicContentPublication publication)
        {
            // verify the required parameter 'publication' is set
            if (publication == null) throw new ApiException(400, "Missing required parameter 'publication' when calling MarketingModuleDynamicContentCreateDynamicContentPublication");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(publication); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentCreateDynamicContentPublication: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
        
        /// <summary>
        /// Delete a dynamic content publication objects 
        /// </summary>
        /// <param name="ids">content publication object ids for delete from dynamic content system</param> 
        /// <returns></returns>            
        public void MarketingModuleDynamicContentDeleteDynamicContentPublications (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentPublications");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPublications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPublications: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a dynamic content publication objects 
        /// </summary>
        /// <param name="ids">content publication object ids for delete from dynamic content system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModuleDynamicContentDeleteDynamicContentPublicationsAsync (List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModuleDynamicContentDeleteDynamicContentPublications");
            
    
            var path_ = "/api/marketing/contentpublications";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentDeleteDynamicContentPublications: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get new dynamic content publication object 
        /// </summary>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentGetNewDynamicPublication ()
        {
            
    
            var path_ = "/api/marketing/contentpublications/new";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetNewDynamicPublication: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetNewDynamicPublication: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
    
        /// <summary>
        /// Get new dynamic content publication object 
        /// </summary>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentGetNewDynamicPublicationAsync ()
        {
            
    
            var path_ = "/api/marketing/contentpublications/new";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetNewDynamicPublication: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
        
        /// <summary>
        /// Find dynamic content publication object by id Return a single dynamic content publication object
        /// </summary>
        /// <param name="id">publication id</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>            
        public VirtoCommerceMarketingModuleWebModelDynamicContentPublication MarketingModuleDynamicContentGetDynamicContentPublicationById (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentPublicationById");
            
    
            var path_ = "/api/marketing/contentpublications/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPublicationById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPublicationById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
    
        /// <summary>
        /// Find dynamic content publication object by id Return a single dynamic content publication object
        /// </summary>
        /// <param name="id">publication id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelDynamicContentPublication</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelDynamicContentPublication> MarketingModuleDynamicContentGetDynamicContentPublicationByIdAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModuleDynamicContentGetDynamicContentPublicationById");
            
    
            var path_ = "/api/marketing/contentpublications/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleDynamicContentGetDynamicContentPublicationById: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelDynamicContentPublication) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelDynamicContentPublication));
        }
        
        /// <summary>
        /// Update a existing dynamic promotion object in marketing system 
        /// </summary>
        /// <param name="promotion">&amp;gt;dynamic promotion object that needs to be updated in the marketing system</param> 
        /// <returns></returns>            
        public void MarketingModulePromotionUpdatePromotions (VirtoCommerceMarketingModuleWebModelPromotion promotion)
        {
            
            // verify the required parameter 'promotion' is set
            if (promotion == null) throw new ApiException(400, "Missing required parameter 'promotion' when calling MarketingModulePromotionUpdatePromotions");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(promotion); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionUpdatePromotions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionUpdatePromotions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a existing dynamic promotion object in marketing system 
        /// </summary>
        /// <param name="promotion">&amp;gt;dynamic promotion object that needs to be updated in the marketing system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModulePromotionUpdatePromotionsAsync (VirtoCommerceMarketingModuleWebModelPromotion promotion)
        {
            // verify the required parameter 'promotion' is set
            if (promotion == null) throw new ApiException(400, "Missing required parameter 'promotion' when calling MarketingModulePromotionUpdatePromotions");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(promotion); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionUpdatePromotions: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Add new dynamic promotion object to marketing system 
        /// </summary>
        /// <param name="promotion">dynamic promotion object that needs to be added to the marketing system</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>            
        public VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionCreatePromotion (VirtoCommerceMarketingModuleWebModelPromotion promotion)
        {
            
            // verify the required parameter 'promotion' is set
            if (promotion == null) throw new ApiException(400, "Missing required parameter 'promotion' when calling MarketingModulePromotionCreatePromotion");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(promotion); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionCreatePromotion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionCreatePromotion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
    
        /// <summary>
        /// Add new dynamic promotion object to marketing system 
        /// </summary>
        /// <param name="promotion">dynamic promotion object that needs to be added to the marketing system</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionCreatePromotionAsync (VirtoCommerceMarketingModuleWebModelPromotion promotion)
        {
            // verify the required parameter 'promotion' is set
            if (promotion == null) throw new ApiException(400, "Missing required parameter 'promotion' when calling MarketingModulePromotionCreatePromotion");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(promotion); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionCreatePromotion: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
        
        /// <summary>
        /// Delete promotions objects 
        /// </summary>
        /// <param name="ids">promotions object ids for delete in the marketing system</param> 
        /// <returns></returns>            
        public void MarketingModulePromotionDeletePromotions (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModulePromotionDeletePromotions");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionDeletePromotions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionDeletePromotions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete promotions objects 
        /// </summary>
        /// <param name="ids">promotions object ids for delete in the marketing system</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task MarketingModulePromotionDeletePromotionsAsync (List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MarketingModulePromotionDeletePromotions");
            
    
            var path_ = "/api/marketing/promotions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionDeletePromotions: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Evaluate promotions 
        /// </summary>
        /// <param name="context">Promotion evaluation context</param> 
        /// <returns></returns>            
        public List<VirtoCommerceMarketingModuleWebModelPromotionReward> MarketingModulePromotionEvaluatePromotions (VirtoCommerceDomainMarketingModelPromotionEvaluationContext context)
        {
            
            // verify the required parameter 'context' is set
            if (context == null) throw new ApiException(400, "Missing required parameter 'context' when calling MarketingModulePromotionEvaluatePromotions");
            
    
            var path_ = "/api/marketing/promotions/evaluate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(context); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionEvaluatePromotions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionEvaluatePromotions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VirtoCommerceMarketingModuleWebModelPromotionReward>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceMarketingModuleWebModelPromotionReward>));
        }
    
        /// <summary>
        /// Evaluate promotions 
        /// </summary>
        /// <param name="context">Promotion evaluation context</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<VirtoCommerceMarketingModuleWebModelPromotionReward>> MarketingModulePromotionEvaluatePromotionsAsync (VirtoCommerceDomainMarketingModelPromotionEvaluationContext context)
        {
            // verify the required parameter 'context' is set
            if (context == null) throw new ApiException(400, "Missing required parameter 'context' when calling MarketingModulePromotionEvaluatePromotions");
            
    
            var path_ = "/api/marketing/promotions/evaluate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(context); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionEvaluatePromotions: " + response.Content, response.Content);

            return (List<VirtoCommerceMarketingModuleWebModelPromotionReward>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceMarketingModuleWebModelPromotionReward>));
        }
        
        /// <summary>
        /// Get new dynamic promotion object Return a new dynamic promotion object with populated dynamic expression tree
        /// </summary>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>            
        public VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionGetNewDynamicPromotion ()
        {
            
    
            var path_ = "/api/marketing/promotions/new";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetNewDynamicPromotion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetNewDynamicPromotion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
    
        /// <summary>
        /// Get new dynamic promotion object Return a new dynamic promotion object with populated dynamic expression tree
        /// </summary>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionGetNewDynamicPromotionAsync ()
        {
            
    
            var path_ = "/api/marketing/promotions/new";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetNewDynamicPromotion: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
        
        /// <summary>
        /// Find promotion object by id Return a single promotion (dynamic or custom) object
        /// </summary>
        /// <param name="id">promotion id</param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>            
        public VirtoCommerceMarketingModuleWebModelPromotion MarketingModulePromotionGetPromotionById (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModulePromotionGetPromotionById");
            
    
            var path_ = "/api/marketing/promotions/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetPromotionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetPromotionById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
    
        /// <summary>
        /// Find promotion object by id Return a single promotion (dynamic or custom) object
        /// </summary>
        /// <param name="id">promotion id</param>
        /// <returns>VirtoCommerceMarketingModuleWebModelPromotion</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelPromotion> MarketingModulePromotionGetPromotionByIdAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MarketingModulePromotionGetPromotionById");
            
    
            var path_ = "/api/marketing/promotions/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModulePromotionGetPromotionById: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelPromotion) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelPromotion));
        }
        
        /// <summary>
        /// Search marketing objects by given criteria Allow to find all marketing module objects (Promotions, Dynamic content objects)
        /// </summary>
        /// <param name="criteriaFolderId"></param> 
        /// <param name="criteriaResponseGroup"></param> 
        /// <param name="criteriaKeyword"></param> 
        /// <param name="criteriaStart"></param> 
        /// <param name="criteriaCount"></param> 
        /// <returns>VirtoCommerceMarketingModuleWebModelMarketingSearchResult</returns>            
        public VirtoCommerceMarketingModuleWebModelMarketingSearchResult MarketingModuleSearch (string criteriaFolderId = null, string criteriaResponseGroup = null, string criteriaKeyword = null, int? criteriaStart = null, int? criteriaCount = null)
        {
            
    
            var path_ = "/api/marketing/search";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (criteriaFolderId != null) queryParams.Add("criteria.folderId", ApiClient.ParameterToString(criteriaFolderId)); // query parameter
            if (criteriaResponseGroup != null) queryParams.Add("criteria.responseGroup", ApiClient.ParameterToString(criteriaResponseGroup)); // query parameter
            if (criteriaKeyword != null) queryParams.Add("criteria.keyword", ApiClient.ParameterToString(criteriaKeyword)); // query parameter
            if (criteriaStart != null) queryParams.Add("criteria.start", ApiClient.ParameterToString(criteriaStart)); // query parameter
            if (criteriaCount != null) queryParams.Add("criteria.count", ApiClient.ParameterToString(criteriaCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceMarketingModuleWebModelMarketingSearchResult) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelMarketingSearchResult));
        }
    
        /// <summary>
        /// Search marketing objects by given criteria Allow to find all marketing module objects (Promotions, Dynamic content objects)
        /// </summary>
        /// <param name="criteriaFolderId"></param>
        /// <param name="criteriaResponseGroup"></param>
        /// <param name="criteriaKeyword"></param>
        /// <param name="criteriaStart"></param>
        /// <param name="criteriaCount"></param>
        /// <returns>VirtoCommerceMarketingModuleWebModelMarketingSearchResult</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceMarketingModuleWebModelMarketingSearchResult> MarketingModuleSearchAsync (string criteriaFolderId = null, string criteriaResponseGroup = null, string criteriaKeyword = null, int? criteriaStart = null, int? criteriaCount = null)
        {
            
    
            var path_ = "/api/marketing/search";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (criteriaFolderId != null) queryParams.Add("criteria.folderId", ApiClient.ParameterToString(criteriaFolderId)); // query parameter
            if (criteriaResponseGroup != null) queryParams.Add("criteria.responseGroup", ApiClient.ParameterToString(criteriaResponseGroup)); // query parameter
            if (criteriaKeyword != null) queryParams.Add("criteria.keyword", ApiClient.ParameterToString(criteriaKeyword)); // query parameter
            if (criteriaStart != null) queryParams.Add("criteria.start", ApiClient.ParameterToString(criteriaStart)); // query parameter
            if (criteriaCount != null) queryParams.Add("criteria.count", ApiClient.ParameterToString(criteriaCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarketingModuleSearch: " + response.Content, response.Content);

            return (VirtoCommerceMarketingModuleWebModelMarketingSearchResult) ApiClient.Deserialize(response, typeof(VirtoCommerceMarketingModuleWebModelMarketingSearchResult));
        }
        
    }
    
}
