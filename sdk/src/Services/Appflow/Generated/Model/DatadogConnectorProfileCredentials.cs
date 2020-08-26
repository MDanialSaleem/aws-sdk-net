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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific credentials required by Datadog.
    /// </summary>
    public partial class DatadogConnectorProfileCredentials
    {
        private string _apiKey;
        private string _applicationKey;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        ///  A unique alphanumeric identifier used to authenticate a user, developer, or calling
        /// program to your API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationKey. 
        /// <para>
        ///  Application keys, in conjunction with your API key, give you full access to Datadog’s
        /// programmatic API. Application keys are associated with the user account that created
        /// them. The application key is used to log all requests made to the API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string ApplicationKey
        {
            get { return this._applicationKey; }
            set { this._applicationKey = value; }
        }

        // Check to see if ApplicationKey property is set
        internal bool IsSetApplicationKey()
        {
            return this._applicationKey != null;
        }

    }
}