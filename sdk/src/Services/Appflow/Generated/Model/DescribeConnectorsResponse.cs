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
    /// This is the response object from the DescribeConnectors operation.
    /// </summary>
    public partial class DescribeConnectorsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, ConnectorConfiguration> _connectorConfigurations = new Dictionary<string, ConnectorConfiguration>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectorConfigurations. 
        /// <para>
        ///  The configuration that is applied to the connectors used in the flow. 
        /// </para>
        /// </summary>
        public Dictionary<string, ConnectorConfiguration> ConnectorConfigurations
        {
            get { return this._connectorConfigurations; }
            set { this._connectorConfigurations = value; }
        }

        // Check to see if ConnectorConfigurations property is set
        internal bool IsSetConnectorConfigurations()
        {
            return this._connectorConfigurations != null && this._connectorConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token for the next page of data. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}