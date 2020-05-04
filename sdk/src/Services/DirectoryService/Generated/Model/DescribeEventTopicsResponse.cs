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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// The result of a DescribeEventTopic request.
    /// </summary>
    public partial class DescribeEventTopicsResponse : AmazonWebServiceResponse
    {
        private List<EventTopic> _eventTopics = new List<EventTopic>();

        /// <summary>
        /// Gets and sets the property EventTopics. 
        /// <para>
        /// A list of SNS topic names that receive status messages from the specified Directory
        /// ID.
        /// </para>
        /// </summary>
        public List<EventTopic> EventTopics
        {
            get { return this._eventTopics; }
            set { this._eventTopics = value; }
        }

        // Check to see if EventTopics property is set
        internal bool IsSetEventTopics()
        {
            return this._eventTopics != null && this._eventTopics.Count > 0; 
        }

    }
}