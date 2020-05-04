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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Identifies the user, the file transfer protocol-enabled server they belong to, and
    /// the identifier of the SSH public key associated with that user. A user can have more
    /// than one key on each server that they are associated with.
    /// </summary>
    public partial class ImportSshPublicKeyResponse : AmazonWebServiceResponse
    {
        private string _serverId;
        private string _sshPublicKeyId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a file transfer protocol-enabled server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeyId. 
        /// <para>
        /// The name given to a public key by the system that was imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string SshPublicKeyId
        {
            get { return this._sshPublicKeyId; }
            set { this._sshPublicKeyId = value; }
        }

        // Check to see if SshPublicKeyId property is set
        internal bool IsSetSshPublicKeyId()
        {
            return this._sshPublicKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A user name assigned to the <code>ServerID</code> value that you specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=32)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}