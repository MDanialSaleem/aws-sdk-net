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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeLaunchTemplates operation.
    /// </summary>
    public partial class DescribeLaunchTemplatesResponse : AmazonWebServiceResponse
    {
        private List<LaunchTemplate> _launchTemplates = new List<LaunchTemplate>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LaunchTemplates. 
        /// <para>
        /// Information about the launch templates.
        /// </para>
        /// </summary>
        public List<LaunchTemplate> LaunchTemplates
        {
            get { return this._launchTemplates; }
            set { this._launchTemplates = value; }
        }

        // Check to see if LaunchTemplates property is set
        internal bool IsSetLaunchTemplates()
        {
            return this._launchTemplates != null && this._launchTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
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