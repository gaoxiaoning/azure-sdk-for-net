// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a cloud endpoint.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CloudEndpointCreateParameters : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the CloudEndpointCreateParameters
        /// class.
        /// </summary>
        public CloudEndpointCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudEndpointCreateParameters
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="storageAccountResourceId">Storage Account Resource
        /// Id</param>
        /// <param name="azureFileShareName">Azure file share name</param>
        /// <param name="storageAccountTenantId">Storage Account Tenant
        /// Id</param>
        public CloudEndpointCreateParameters(string id = default(string), string name = default(string), string type = default(string), string storageAccountResourceId = default(string), string azureFileShareName = default(string), string storageAccountTenantId = default(string))
            : base(id, name, type)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AzureFileShareName = azureFileShareName;
            StorageAccountTenantId = storageAccountTenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage Account Resource Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountResourceId")]
        public string StorageAccountResourceId { get; set; }

        /// <summary>
        /// Gets or sets azure file share name
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFileShareName")]
        public string AzureFileShareName { get; set; }

        /// <summary>
        /// Gets or sets storage Account Tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountTenantId")]
        public string StorageAccountTenantId { get; set; }

    }
}