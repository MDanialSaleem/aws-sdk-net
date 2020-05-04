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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetStaticIp operation.
    /// </summary>
    public partial class GetStaticIpResponse : AmazonWebServiceResponse
    {
        private StaticIp _staticIp;

        /// <summary>
        /// Gets and sets the property StaticIp. 
        /// <para>
        /// An array of key-value pairs containing information about the requested static IP.
        /// </para>
        /// </summary>
        public StaticIp StaticIp
        {
            get { return this._staticIp; }
            set { this._staticIp = value; }
        }

        // Check to see if StaticIp property is set
        internal bool IsSetStaticIp()
        {
            return this._staticIp != null;
        }

    }
}