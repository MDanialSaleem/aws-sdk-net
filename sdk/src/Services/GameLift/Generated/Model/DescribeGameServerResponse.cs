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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the DescribeGameServer operation.
    /// </summary>
    public partial class DescribeGameServerResponse : AmazonWebServiceResponse
    {
        private GameServer _gameServer;

        /// <summary>
        /// Gets and sets the property GameServer. 
        /// <para>
        /// Object that describes the requested game server resource.
        /// </para>
        /// </summary>
        public GameServer GameServer
        {
            get { return this._gameServer; }
            set { this._gameServer = value; }
        }

        // Check to see if GameServer property is set
        internal bool IsSetGameServer()
        {
            return this._gameServer != null;
        }

    }
}