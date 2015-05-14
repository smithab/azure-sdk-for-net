// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Authorization;
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization
{
    /// <summary>
    /// TBD  (see http://TBD for more information)
    /// </summary>
    public partial interface IRoleAssignmentOperations
    {
        /// <summary>
        /// Create role assignment.
        /// </summary>
        /// <param name='scope'>
        /// Scope.
        /// </param>
        /// <param name='roleAssignmentName'>
        /// Role assignment name.
        /// </param>
        /// <param name='parameters'>
        /// Role assignment.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignments creation results
        /// </returns>
        Task<RoleAssignmentCreateResult> CreateAsync(string scope, Guid roleAssignmentName, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create role assignment by Id.
        /// </summary>
        /// <param name='roleAssignmentId'>
        /// Role assignment Id
        /// </param>
        /// <param name='parameters'>
        /// Role assignment.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignments creation results
        /// </returns>
        Task<RoleAssignmentCreateResult> CreateByIdAsync(string roleAssignmentId, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete role assignment.
        /// </summary>
        /// <param name='scope'>
        /// Scope.
        /// </param>
        /// <param name='roleAssignmentName'>
        /// Role assignment name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignments delete result
        /// </returns>
        Task<RoleAssignmentDeleteResult> DeleteAsync(string scope, Guid roleAssignmentName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete role assignment.
        /// </summary>
        /// <param name='roleAssignmentId'>
        /// Role assignment Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignments delete result
        /// </returns>
        Task<RoleAssignmentDeleteResult> DeleteByIdAsync(string roleAssignmentId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get single role assignment.
        /// </summary>
        /// <param name='scope'>
        /// Scope.
        /// </param>
        /// <param name='roleAssignmentName'>
        /// Role assignment name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment get operation result.
        /// </returns>
        Task<RoleAssignmentGetResult> GetAsync(string scope, Guid roleAssignmentName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get single role assignment.
        /// </summary>
        /// <param name='roleAssignmentId'>
        /// Role assignment Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment get operation result.
        /// </returns>
        Task<RoleAssignmentGetResult> GetByIdAsync(string roleAssignmentId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets role assignments of the subscription.
        /// </summary>
        /// <param name='parameters'>
        /// List operation filters. If null will return all role assignments
        /// at, above or below the subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment list operation result.
        /// </returns>
        Task<RoleAssignmentListResult> ListAsync(ListAssignmentsFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets role assignments of the resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='identity'>
        /// Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// List operation filters. If null will return all role assignments
        /// at, above or below the resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment list operation result.
        /// </returns>
        Task<RoleAssignmentListResult> ListForResourceAsync(string resourceGroupName, ResourceIdentity identity, ListAssignmentsFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets role assignments of the resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name.
        /// </param>
        /// <param name='parameters'>
        /// List operation filters. If null will return all role assignments
        /// at, above or below the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment list operation result.
        /// </returns>
        Task<RoleAssignmentListResult> ListForResourceGroupAsync(string resourceGroupName, ListAssignmentsFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets role assignments of the scope.
        /// </summary>
        /// <param name='scope'>
        /// Scope.
        /// </param>
        /// <param name='parameters'>
        /// List operation filters. If null will return all role assignments
        /// at, above or below the subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role assignment list operation result.
        /// </returns>
        Task<RoleAssignmentListResult> ListForScopeAsync(string scope, ListAssignmentsFilterParameters parameters, CancellationToken cancellationToken);
    }
}