/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Returns an error that explains why the action did not succeed.
    /// </summary>
    public partial class ErrorReason
    {
        private ErrorCode _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Service Quotas returns the following error values. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DEPENDENCY_ACCESS_DENIED_ERROR</code> is returned when the caller does not
        /// have permission to call the service or service quota. To resolve the error, you need
        /// permission to access the service or service quota.
        /// </para>
        ///  
        /// <para>
        ///  <code>DEPENDENCY_THROTTLING_ERROR</code> is returned when the service being called
        /// is throttling Service Quotas.
        /// </para>
        ///  
        /// <para>
        ///  <code>DEPENDENCY_SERVICE_ERROR</code> is returned when the service being called has
        /// availability issues.
        /// </para>
        ///  
        /// <para>
        ///  <code>SERVICE_QUOTA_NOT_AVAILABLE_ERROR</code> is returned when there was an error
        /// in Service Quotas.
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message that provides more detail.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

    }
}