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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorkflow operation.
    /// Retrieves resource metadata for a workflow.
    /// </summary>
    public partial class GetWorkflowRequest : AmazonGlueRequest
    {
        private bool? _includeGraph;
        private string _name;

        /// <summary>
        /// Gets and sets the property IncludeGraph. 
        /// <para>
        /// Specifies whether to include a graph when returning the workflow resource metadata.
        /// </para>
        /// </summary>
        public bool IncludeGraph
        {
            get { return this._includeGraph.GetValueOrDefault(); }
            set { this._includeGraph = value; }
        }

        // Check to see if IncludeGraph property is set
        internal bool IsSetIncludeGraph()
        {
            return this._includeGraph.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}