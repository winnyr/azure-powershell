// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ManagedLedgerDigestUploadsOperations
    /// </summary>
    public static partial class ManagedLedgerDigestUploadsOperationsExtensions
    {
        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ManagedLedgerDigestUploads> ListByDatabase(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).ListByDatabaseAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ManagedLedgerDigestUploads>> ListByDatabaseAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the current ledger digest upload configuration for a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedLedgerDigestUploads Get(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).GetAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the current ledger digest upload configuration for a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedLedgerDigestUploads> GetAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedLedgerDigestUploads CreateOrUpdate(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedLedgerDigestUploads parameters)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).CreateOrUpdateAsync(resourceGroupName, managedInstanceName, databaseName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedLedgerDigestUploads> CreateOrUpdateAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedLedgerDigestUploads parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedLedgerDigestUploads Disable(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).DisableAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedLedgerDigestUploads> DisableAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DisableWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedLedgerDigestUploads BeginCreateOrUpdate(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedLedgerDigestUploads parameters)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, managedInstanceName, databaseName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedLedgerDigestUploads> BeginCreateOrUpdateAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedLedgerDigestUploads parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedLedgerDigestUploads BeginDisable(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).BeginDisableAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedLedgerDigestUploads> BeginDisableAsync(this IManagedLedgerDigestUploadsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDisableWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ManagedLedgerDigestUploads> ListByDatabaseNext(this IManagedLedgerDigestUploadsOperations operations, string nextPageLink)
        {
                return ((IManagedLedgerDigestUploadsOperations)operations).ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ManagedLedgerDigestUploads>> ListByDatabaseNextAsync(this IManagedLedgerDigestUploadsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
