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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The values that are available for a tag.
    /// </summary>
    public partial class TagValues
    {
        private string _key;
        private List<string> _matchOptions = new List<string>();
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MatchOptions. 
        /// <para>
        /// The match options that you can use to filter your results. <code>MatchOptions</code>
        /// is only applicable for only applicable for actions related to Cost Category. The default
        /// values for <code>MatchOptions</code> is <code>EQUALS</code> and <code>CASE_SENSITIVE</code>.
        /// </para>
        /// </summary>
        public List<string> MatchOptions
        {
            get { return this._matchOptions; }
            set { this._matchOptions = value; }
        }

        // Check to see if MatchOptions property is set
        internal bool IsSetMatchOptions()
        {
            return this._matchOptions != null && this._matchOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The specific value of the tag.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}