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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTextDetection operation
    /// </summary>  
    public class GetTextDetectionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetTextDetectionResponse response = new GetTextDetectionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("JobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NextToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextDetections", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TextDetectionResult, TextDetectionResultUnmarshaller>(TextDetectionResultUnmarshaller.Instance);
                    response.TextDetections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextModelVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TextModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VideoMetadata", targetDepth))
                {
                    var unmarshaller = VideoMetadataUnmarshaller.Instance;
                    response.VideoMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidPaginationTokenException"))
                {
                    return InvalidPaginationTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
                {
                    return InvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ProvisionedThroughputExceededException"))
                {
                    return ProvisionedThroughputExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRekognitionException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTextDetectionResponseUnmarshaller _instance = new GetTextDetectionResponseUnmarshaller();        

        internal static GetTextDetectionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTextDetectionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}