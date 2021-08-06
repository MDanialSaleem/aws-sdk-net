/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchChannelMemberships Object
    /// </summary>  
    public class BatchChannelMembershipsUnmarshaller : IUnmarshaller<BatchChannelMemberships, XmlUnmarshallerContext>, IUnmarshaller<BatchChannelMemberships, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchChannelMemberships IUnmarshaller<BatchChannelMemberships, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchChannelMemberships Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchChannelMemberships unmarshalledObject = new BatchChannelMemberships();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChannelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvitedBy", targetDepth))
                {
                    var unmarshaller = IdentityUnmarshaller.Instance;
                    unmarshalledObject.InvitedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Members", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Identity, IdentityUnmarshaller>(IdentityUnmarshaller.Instance);
                    unmarshalledObject.Members = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchChannelMembershipsUnmarshaller _instance = new BatchChannelMembershipsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchChannelMembershipsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}