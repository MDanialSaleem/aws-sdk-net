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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the GetQueryResults operation.
    /// Streams the results of a single query execution specified by <code>QueryExecutionId</code>
    /// from the Athena query results location in Amazon S3. For more information, see <a
    /// href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Query Results</a>
    /// in the <i>Amazon Athena User Guide</i>. This request does not execute the query but
    /// returns results. Use <a>StartQueryExecution</a> to run a query.
    /// 
    ///  
    /// <para>
    /// To stream query results successfully, the IAM principal with permission to call <code>GetQueryResults</code>
    /// also must have permissions to the Amazon S3 <code>GetObject</code> action for the
    /// Athena query results location.
    /// </para>
    ///  <important> 
    /// <para>
    /// IAM principals with permission to the Amazon S3 <code>GetObject</code> action for
    /// the query results location are able to retrieve query results from Amazon S3 even
    /// if permission to the <code>GetQueryResults</code> action is denied. To restrict user
    /// or role access, ensure that Amazon S3 permissions to the Athena query location are
    /// denied.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetQueryResultsRequest : AmazonAthenaRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _queryExecutionId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results (rows) to return in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that specifies where to start pagination if a previous request was truncated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique ID of the query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryExecutionId
        {
            get { return this._queryExecutionId; }
            set { this._queryExecutionId = value; }
        }

        // Check to see if QueryExecutionId property is set
        internal bool IsSetQueryExecutionId()
        {
            return this._queryExecutionId != null;
        }

    }
}