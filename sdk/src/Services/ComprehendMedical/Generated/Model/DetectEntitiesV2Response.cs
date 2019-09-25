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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// This is the response object from the DetectEntitiesV2 operation.
    /// </summary>
    public partial class DetectEntitiesV2Response : AmazonWebServiceResponse
    {
        private List<Entity> _entities = new List<Entity>();
        private string _modelVersion;
        private string _paginationToken;
        private List<UnmappedAttribute> _unmappedAttributes = new List<UnmappedAttribute>();

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// The collection of medical entities extracted from the input text and their associated
        /// information. For each entity, the response provides the entity text, the entity category,
        /// where the entity text begins and ends, and the level of confidence in the detection
        /// and analysis. Attributes and traits of the entity are also returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Entity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && this._entities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model used to analyze the documents. The version number looks like
        /// X.X.X. You can use this information to track the model used for a particular batch
        /// of documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// If the result to the <code>DetectEntitiesV2</code> operation was truncated, include
        /// the <code>PaginationToken</code> to fetch the next page of entities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property UnmappedAttributes. 
        /// <para>
        /// Attributes extracted from the input text that couldn't be related to an entity.
        /// </para>
        /// </summary>
        public List<UnmappedAttribute> UnmappedAttributes
        {
            get { return this._unmappedAttributes; }
            set { this._unmappedAttributes = value; }
        }

        // Check to see if UnmappedAttributes property is set
        internal bool IsSetUnmappedAttributes()
        {
            return this._unmappedAttributes != null && this._unmappedAttributes.Count > 0; 
        }

    }
}