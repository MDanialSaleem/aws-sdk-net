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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KeyManagementService.Model;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Interface for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/">
    /// <i>AWS Key Management Service Developer Guide</i> </a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, macOS, Android, etc.). The SDKs provide
    /// a convenient way to create programmatic access to AWS KMS and other AWS services.
    /// For example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account (root) access key ID and secret
    /// key for everyday work with AWS KMS. Instead, use the access key ID and secret access
    /// key for an IAM user, or you can use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the of credentials
    /// used for accessing AWS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the APIs discussed in this guide, the following will prove the most useful for
    /// most applications. You will likely perform actions other than these, such as creating
    /// keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonKeyManagementService : IAmazonService, IDisposable
    {

        
        #region  CancelKeyDeletion


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        CancelKeyDeletionResponse CancelKeyDeletion(string keyId);

        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request);


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CancelKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ConnectCustomKeyStore


        /// <summary>
        /// Connects or reconnects a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> to its associated AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store must be connected before you can create customer master keys
        /// (CMKs) in the key store or use the CMKs it contains. You can disconnect and reconnect
        /// a custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// To connect a custom key store, its associated AWS CloudHSM cluster must have at least
        /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters">DescribeClusters</a>
        /// operation. To add HSMs to the cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The connection process can take an extended amount of time to complete; up to 20 minutes.
        /// This operation starts the connection process, but it does not wait for it to complete.
        /// When it succeeds, this operation quickly returns an HTTP 200 response and a JSON object
        /// with no properties. However, this response does not indicate that the custom key store
        /// is connected. To get the connection state of the custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// During the connection process, AWS KMS finds the AWS CloudHSM cluster that is associated
        /// with the custom key store, creates the connection infrastructure, connects to the
        /// cluster, logs into the AWS CloudHSM client as the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user</a> (CU), and rotates its password.
        /// </para>
        ///  
        /// <para>
        /// The <code>ConnectCustomKeyStore</code> operation might fail for various reasons. To
        /// find the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <code>ConnectionErrorCode</code>
        /// in the response. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
        /// if necessary, and then use <code>ConnectCustomKeyStore</code> again.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting a custom key store, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the ConnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store. The cluster must be configured
        /// with private subnets in at least two different Availability Zones in the Region. Also,
        /// it must contain at least as many HSMs as the operation requires.
        /// 
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a private subnet for a AWS CloudHSM cluster, see <a
        /// href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. To add HSMs, use the AWS
        /// CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        ConnectCustomKeyStoreResponse ConnectCustomKeyStore(ConnectCustomKeyStoreRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ConnectCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        Task<ConnectCustomKeyStoreResponse> ConnectCustomKeyStoreAsync(ConnectCustomKeyStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Creates a display name for a customer master key (CMK). You can use an alias to identify
        /// a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. 
        /// 
        ///  
        /// <para>
        /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
        /// name must be unique in the AWS account and region. To simplify code that runs in multiple
        /// regions, use the same alias name, but point it to a different CMK in each region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An alias must start with the word <code>alias</code> followed by a forward slash (<code>alias/</code>).
        /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). Alias names cannot begin with <code>aws</code>; that alias name
        /// prefix is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the CMK it is mapped to must be in the same AWS account and the same
        /// region. You cannot perform this operation on an alias in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">Identifies the CMK for which you are creating the alias. This value cannot be an alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse CreateAlias(string aliasName, string targetKeyId);

        /// <summary>
        /// Creates a display name for a customer master key (CMK). You can use an alias to identify
        /// a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. 
        /// 
        ///  
        /// <para>
        /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
        /// name must be unique in the AWS account and region. To simplify code that runs in multiple
        /// regions, use the same alias name, but point it to a different CMK in each region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An alias must start with the word <code>alias</code> followed by a forward slash (<code>alias/</code>).
        /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). Alias names cannot begin with <code>aws</code>; that alias name
        /// prefix is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the CMK it is mapped to must be in the same AWS account and the same
        /// region. You cannot perform this operation on an alias in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);


        /// <summary>
        /// Creates a display name for a customer master key (CMK). You can use an alias to identify
        /// a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. 
        /// 
        ///  
        /// <para>
        /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
        /// name must be unique in the AWS account and region. To simplify code that runs in multiple
        /// regions, use the same alias name, but point it to a different CMK in each region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An alias must start with the word <code>alias</code> followed by a forward slash (<code>alias/</code>).
        /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). Alias names cannot begin with <code>aws</code>; that alias name
        /// prefix is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the CMK it is mapped to must be in the same AWS account and the same
        /// region. You cannot perform this operation on an alias in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">Identifies the CMK for which you are creating the alias. This value cannot be an alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCustomKeyStore


        /// <summary>
        /// Creates a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> that is associated with an <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">AWS
        /// CloudHSM cluster</a> that you own and manage.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// When the operation completes successfully, it returns the ID of the new custom key
        /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
        /// operation to connect the new key store to its AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateCustomKeyStore</code> operation requires the following elements.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify an active AWS CloudHSM cluster in the same account and AWS Region
        /// as the custom key store. You can use an existing cluster or <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/create-cluster.html">create
        /// and activate a new AWS CloudHSM cluster</a> for the key store. AWS KMS does not require
        /// exclusive use of the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must include the content of the <i>trust anchor certificate</i> for the cluster.
        /// You created this certificate, and saved it in the <code>customerCA.crt</code> file,
        /// when you <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialized
        /// the cluster</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must provide the password of the dedicated <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user</a> (CU) account in the cluster.
        /// </para>
        ///  
        /// <para>
        /// Before you create the custom key store, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/cloudhsm_mgmt_util-createUser.html">createUser</a>
        /// command in <code>cloudhsm_mgmt_util</code> to create <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">a
        /// crypto user (CU) named <code>kmsuser</code> </a>in specified AWS CloudHSM cluster.
        /// AWS KMS uses the <code>kmsuser</code> CU account to create and manage key material
        /// on your behalf. For instructions, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Create
        /// the kmsuser Crypto User</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The AWS CloudHSM cluster that you specify must meet the following requirements.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be active and be in the same AWS account and Region as the custom
        /// key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each custom key store must be associated with a different AWS CloudHSM cluster. The
        /// cluster cannot be associated with another custom key store or have the same cluster
        /// certificate as a cluster that is associated with another custom key store. To view
        /// the cluster certificate, use the AWS CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. Clusters that share a backup history have the same cluster certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must be configured with subnets in at least two different Availability
        /// Zones in the Region. Because AWS CloudHSM is not supported in all Availability Zones,
        /// we recommend that the cluster have subnets in all Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least two active HSMs, each in a different Availability
        /// Zone.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// New custom key stores are not automatically connected. After you create your custom
        /// key store, use the <a>ConnectCustomKeyStore</a> operation to connect the custom key
        /// store to its associated AWS CloudHSM cluster. Even if you are not going to use your
        /// custom key store immediately, you might want to connect it to verify that all settings
        /// are correct and then disconnect it until you are ready to use it.
        /// </para>
        ///  
        /// <para>
        /// If this operation succeeds, it returns the ID of the new custom key store. For help
        /// with failures, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshoot
        /// a Custom Key Store</a> in the <i>AWS KMS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the CreateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInUseException">
        /// The request was rejected because the specified AWS CloudHSM cluster is already associated
        /// with a custom key store or it shares a backup history with a cluster that is associated
        /// with a custom key store. Each custom key store must be associated with a different
        /// AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store. The cluster must be configured
        /// with private subnets in at least two different Availability Zones in the Region. Also,
        /// it must contain at least as many HSMs as the operation requires.
        /// 
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a private subnet for a AWS CloudHSM cluster, see <a
        /// href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. To add HSMs, use the AWS
        /// CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because AWS KMS cannot find the AWS CloudHSM cluster with
        /// the specified cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectTrustAnchorException">
        /// The request was rejected because the trust anchor certificate in the request is not
        /// the trust anchor certificate for the specified AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// When you <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create the trust anchor certificate and save it in the <code>customerCA.crt</code>
        /// file.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        CreateCustomKeyStoreResponse CreateCustomKeyStore(CreateCustomKeyStoreRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        Task<CreateCustomKeyStoreResponse> CreateCustomKeyStoreAsync(CreateCustomKeyStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Adds a grant to a customer master key (CMK). The grant specifies who can use the CMK
        /// and under what conditions. When setting permissions, grants are an alternative to
        /// key policies. 
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter. For more information about grants,
        /// see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        CreateGrantResponse CreateGrant(CreateGrantRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKey


        /// <summary>
        /// Creates a customer master key (CMK) in the caller's AWS account.
        /// 
        ///  
        /// <para>
        /// You can use a CMK to encrypt small amounts of data (4 KiB or less) directly, but CMKs
        /// are more commonly used to encrypt data keys, which are used to encrypt raw data. For
        /// more information about data keys and the difference between CMKs and data keys, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <a>GenerateDataKey</a> operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">AWS
        /// Key Management Service Concepts</a> in the <i>AWS Key Management Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you plan to <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">import
        /// key material</a>, use the <code>Origin</code> parameter with a value of <code>EXTERNAL</code>
        /// to create a CMK with no key material.
        /// </para>
        ///  
        /// <para>
        /// To create a CMK in a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, use <code>CustomKeyStoreId</code> parameter to specify the custom key
        /// store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
        /// The AWS CloudHSM cluster that is associated with the custom key store must have at
        /// least two active HSMs, each in a different Availability Zone in the Region.
        /// </para>
        ///  
        /// <para>
        /// You cannot use this operation to create a CMK in a different AWS account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store. The cluster must be configured
        /// with private subnets in at least two different Availability Zones in the Region. Also,
        /// it must contain at least as many HSMs as the operation requires.
        /// 
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a private subnet for a AWS CloudHSM cluster, see <a
        /// href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. To add HSMs, use the AWS
        /// CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        CreateKeyResponse CreateKey(CreateKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Decrypt


        /// <summary>
        /// Decrypts ciphertext. Ciphertext is plaintext that has been previously encrypted by
        /// using any of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that if a caller has been granted access permissions to all keys (through, for
        /// example, IAM user policies that grant <code>Decrypt</code> permission on all resources),
        /// then ciphertext encrypted by using keys in other accounts where the key grants access
        /// to the caller can be decrypted. To remedy this, we recommend that you do not grant
        /// <code>Decrypt</code> access in an IAM user policy. Instead grant <code>Decrypt</code>
        /// access only in key policies. If you must grant <code>Decrypt</code> access in an IAM
        /// user policy, you should scope the resource to specific keys or to specific trusted
        /// accounts.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext, or additional authenticated
        /// data incorporated into the ciphertext, such as the encryption context, is corrupted,
        /// missing, or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        DecryptResponse Decrypt(DecryptRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        Task<DecryptResponse> DecryptAsync(DecryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(string aliasName);

        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);


        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomKeyStore


        /// <summary>
        /// Deletes a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. This operation does not delete the AWS CloudHSM cluster that is associated
        /// with the custom key store, or affect any users or keys in the cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store that you delete cannot contain any AWS KMS <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">customer
        /// master keys (CMKs)</a>. Before deleting the key store, verify that you will never
        /// need to use any of the CMKs in the key store for any cryptographic operations. Then,
        /// use <a>ScheduleKeyDeletion</a> to delete the AWS KMS customer master keys (CMKs) from
        /// the key store. When the scheduled waiting period expires, the <code>ScheduleKeyDeletion</code>
        /// operation deletes the CMKs. Then it makes a best effort to delete the key material
        /// from the associated cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// After all CMKs are deleted from AWS KMS, use <a>DisconnectCustomKeyStore</a> to disconnect
        /// the key store from AWS KMS. Then, you can delete the custom key store.
        /// </para>
        ///  
        /// <para>
        /// Instead of deleting the custom key store, consider using <a>DisconnectCustomKeyStore</a>
        /// to disconnect it from AWS KMS. While the key store is disconnected, you cannot create
        /// or use the CMKs in the key store. But, you do not need to delete CMKs and you can
        /// reconnect a disconnected custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreHasCMKsException">
        /// The request was rejected because the custom key store contains AWS KMS customer master
        /// keys (CMKs). After verifying that you do not need to use the CMKs, use the <a>ScheduleKeyDeletion</a>
        /// operation to delete the CMKs. After they are deleted, you can delete the custom key
        /// store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        DeleteCustomKeyStoreResponse DeleteCustomKeyStore(DeleteCustomKeyStoreRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        Task<DeleteCustomKeyStoreResponse> DeleteCustomKeyStoreAsync(DeleteCustomKeyStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteImportedKeyMaterial


        /// <summary>
        /// Deletes key material that you previously imported. This operation makes the specified
        /// customer master key (CMK) unusable. For more information about importing key material
        /// into AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>. You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// When the specified CMK is in the <code>PendingDeletion</code> state, this operation
        /// does not change the CMK's state. Otherwise, it changes the CMK's state to <code>PendingImport</code>.
        /// </para>
        ///  
        /// <para>
        /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
        /// same key material into the CMK.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportedKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCustomKeyStores


        /// <summary>
        /// Gets information about <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key stores</a> in the account and region.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns information about all custom key stores in the
        /// account and region. To get only information about a particular custom key store, use
        /// either the <code>CustomKeyStoreName</code> or <code>CustomKeyStoreId</code> parameter
        /// (but not both).
        /// </para>
        ///  
        /// <para>
        /// To determine whether the custom key store is connected to its AWS CloudHSM cluster,
        /// use the <code>ConnectionState</code> element in the response. If an attempt to connect
        /// the custom key store failed, the <code>ConnectionState</code> value is <code>FAILED</code>
        /// and the <code>ConnectionErrorCode</code> element in the response indicates the cause
        /// of the failure. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// Custom key stores have a <code>DISCONNECTED</code> connection state if the key store
        /// has never been connected or you use the <a>DisconnectCustomKeyStore</a> operation
        /// to disconnect it. If your custom key store state is <code>CONNECTED</code> but you
        /// are having trouble using it, make sure that its associated AWS CloudHSM cluster is
        /// active and contains the minimum number of HSMs required for the operation, if any.
        /// </para>
        ///  
        /// <para>
        ///  For help repairing your custom key store, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore-html">Troubleshooting
        /// Custom Key Stores</a> topic in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomKeyStores service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        DescribeCustomKeyStoresResponse DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomKeyStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        Task<DescribeCustomKeyStoresResponse> DescribeCustomKeyStoresAsync(DescribeCustomKeyStoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeKey


        /// <summary>
        /// Provides detailed information about the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// If you use <code>DescribeKey</code> on a predefined AWS alias, that is, an AWS alias
        /// with no key ID, AWS KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified customer master key (CMK).  If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. When using an alias name, prefix it with "alias/". To specify a CMK in a different AWS account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        DescribeKeyResponse DescribeKey(string keyId);

        /// <summary>
        /// Provides detailed information about the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// If you use <code>DescribeKey</code> on a predefined AWS alias, that is, an AWS alias
        /// with no key ID, AWS KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        DescribeKeyResponse DescribeKey(DescribeKeyRequest request);


        /// <summary>
        /// Provides detailed information about the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// If you use <code>DescribeKey</code> on a predefined AWS alias, that is, an AWS alias
        /// with no key ID, AWS KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified customer master key (CMK).  If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. When using an alias name, prefix it with "alias/". To specify a CMK in a different AWS account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableKey


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        DisableKeyResponse DisableKey(string keyId);

        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        DisableKeyResponse DisableKey(DisableKeyRequest request);


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableKeyRotation


        /// <summary>
        /// Disables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        DisableKeyRotationResponse DisableKeyRotation(string keyId);

        /// <summary>
        /// Disables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request);


        /// <summary>
        /// Disables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisconnectCustomKeyStore


        /// <summary>
        /// Disconnects the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> from its associated AWS CloudHSM cluster. While a custom key store is
        /// disconnected, you can manage the custom key store and its customer master keys (CMKs),
        /// but you cannot create or use CMKs in the custom key store. You can reconnect the custom
        /// key store at any time.
        /// 
        ///  <note> 
        /// <para>
        /// While a custom key store is disconnected, all attempts to create customer master keys
        /// (CMKs) in the custom key store or to use existing CMKs in cryptographic operations
        /// will fail. This action can prevent users from storing and accessing sensitive data.
        /// </para>
        ///  </note>  
        /// <para>
        /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the DisconnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        DisconnectCustomKeyStoreResponse DisconnectCustomKeyStore(DisconnectCustomKeyStoreRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        Task<DisconnectCustomKeyStoreResponse> DisconnectCustomKeyStoreAsync(DisconnectCustomKeyStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableKey


        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        EnableKeyResponse EnableKey(string keyId);

        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        EnableKeyResponse EnableKey(EnableKeyRequest request);


        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableKeyRotation


        /// <summary>
        /// Enables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of CMKs with imported key material or CMKs in
        /// a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        EnableKeyRotationResponse EnableKeyRotation(string keyId);

        /// <summary>
        /// Enables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of CMKs with imported key material or CMKs in
        /// a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request);


        /// <summary>
        /// Enables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of CMKs with imported key material or CMKs in
        /// a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Encrypt


        /// <summary>
        /// Encrypts plaintext into ciphertext by using a customer master key (CMK). The <code>Encrypt</code>
        /// operation has two primary use cases:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can encrypt up to 4 kilobytes (4096 bytes) of arbitrary data such as an RSA key,
        /// a database password, or other sensitive information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To move encrypted data from one AWS region to another, you can use this operation
        /// to encrypt in the new region the plaintext data key that was used to encrypt the data
        /// in the original region. This provides you with an encrypted copy of the data key that
        /// can be decrypted in the new region and used there to decrypt the encrypted data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you are moving encrypted data from one region to another, you don't use this
        /// operation to encrypt a generated data key within a region. To get data keys that are
        /// already encrypted, call the <a>GenerateDataKey</a> or <a>GenerateDataKeyWithoutPlaintext</a>
        /// operation. Data keys don't need to be encrypted again by calling <code>Encrypt</code>.
        /// </para>
        ///  
        /// <para>
        /// To encrypt data locally in your application, use the <a>GenerateDataKey</a> operation
        /// to return a plaintext data encryption key and a copy of the key encrypted under the
        /// CMK of your choosing.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        EncryptResponse Encrypt(EncryptRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        Task<EncryptResponse> EncryptAsync(EncryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateDataKey


        /// <summary>
        /// Returns a data encryption key that you can use in your application to encrypt data
        /// locally. 
        /// 
        ///  
        /// <para>
        /// You must specify the customer master key (CMK) under which to generate the data key.
        /// You must also specify the length of the data key using either the <code>KeySpec</code>
        /// or <code>NumberOfBytes</code> field. You must specify one field or the other, but
        /// not both. For common key lengths (128-bit and 256-bit symmetric keys), we recommend
        /// that you use <code>KeySpec</code>. To perform this operation on a CMK in a different
        /// AWS account, specify the key ARN or alias ARN in the value of the KeyId parameter.
        /// </para>
        ///  
        /// <para>
        /// This operation returns a plaintext copy of the data key in the <code>Plaintext</code>
        /// field of the response, and an encrypted copy of the data key in the <code>CiphertextBlob</code>
        /// field. The data key is encrypted under the CMK specified in the <code>KeyId</code>
        /// field of the request. 
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use this operation (<code>GenerateDataKey</code>) to get a data encryption key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data encryption key (returned in the <code>Plaintext</code> field
        /// of the response) to encrypt data locally, then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (returned in the <code>CiphertextBlob</code> field of
        /// the response) alongside the locally encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data locally:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key into a plaintext
        /// copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data locally, then erase the plaintext data
        /// key from memory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To return only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To return a random byte string that is cryptographically secure, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use the optional <code>EncryptionContext</code> field, you must store at least
        /// enough information to be able to reconstruct the full encryption context when you
        /// later send the ciphertext to the <a>Decrypt</a> operation. It is a good practice to
        /// choose an encryption context that you can reconstruct on the fly to better secure
        /// the ciphertext. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext


        /// <summary>
        /// Returns a data encryption key encrypted under a customer master key (CMK). This operation
        /// is identical to <a>GenerateDataKey</a> but returns only the encrypted copy of the
        /// data key. 
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        ///  
        /// <para>
        /// This operation is useful in a system that has multiple components with different degrees
        /// of trust. For example, consider a system that stores encrypted data in containers.
        /// Each container stores the encrypted data and an encrypted copy of the data key. One
        /// component of the system, called the <i>control plane</i>, creates new containers.
        /// When it creates a new container, it uses this operation (<code>GenerateDataKeyWithoutPlaintext</code>)
        /// to get an encrypted data key and then stores it in the container. Later, a different
        /// component of the system, called the <i>data plane</i>, puts encrypted data into the
        /// containers. To do this, it passes the encrypted data key to the <a>Decrypt</a> operation,
        /// then uses the returned plaintext data key to encrypt data, and finally stores the
        /// encrypted data in the container. In this system, the control plane never sees the
        /// plaintext data key.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateRandom


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        GenerateRandomResponse GenerateRandom(int numberOfBytes);

        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        GenerateRandomResponse GenerateRandom(GenerateRandomRequest request);


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyPolicy


        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        GetKeyPolicyResponse GetKeyPolicy(string keyId, string policyName);

        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request);


        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyRotationStatus


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        GetKeyRotationStatusResponse GetKeyRotationStatus(string keyId);

        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request);


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParametersForImport


        /// <summary>
        /// Returns the items you need in order to import key material into AWS KMS from your
        /// existing key management infrastructure. For more information about importing key material
        /// into AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify the key ID of the customer master key (CMK) into which you will import
        /// key material. This CMK's <code>Origin</code> must be <code>EXTERNAL</code>. You must
        /// also specify the wrapping algorithm and type of wrapping key (public key) that you
        /// will use to encrypt the key material. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// This operation returns a public key and an import token. Use the public key to encrypt
        /// the key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
        /// request. The public key and import token from the same response must be used together.
        /// These items are valid for 24 hours. When they expire, they cannot be used for a subsequent
        /// <a>ImportKeyMaterial</a> request. To get new ones, send another <code>GetParametersForImport</code>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetParametersForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportKeyMaterial


        /// <summary>
        /// Imports key material into an existing AWS KMS customer master key (CMK) that was created
        /// without key material. You cannot perform this operation on a CMK in a different AWS
        /// account. For more information about creating CMKs with no key material and then importing
        /// key material, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before using this operation, call <a>GetParametersForImport</a>. Its response includes
        /// a public key and an import token. Use the public key to encrypt the key material.
        /// Then, submit the import token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  
        /// <para>
        /// When calling this operation, you must specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID or key ARN of a CMK with no key material. Its <code>Origin</code> must
        /// be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a CMK with no key material, call <a>CreateKey</a> and set the value of its
        /// <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
        /// of a CMK, call <a>DescribeKey</a>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encrypted key material. To get the public key to encrypt the key material, call
        /// <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The import token that <a>GetParametersForImport</a> returned. This token and the public
        /// key used to encrypt the key material must have come from the same response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the key material expires and if so, when. If you set an expiration date, you
        /// can change it only by reimporting the same key material and specifying a new expiration
        /// date. If the key material expires, AWS KMS deletes the key material and the CMK becomes
        /// unusable. To use the CMK again, you must reimport the same key material.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, the key state of the CMK changes from <code>PendingImport</code>
        /// to <code>Enabled</code>, and you can use the CMK. After you successfully import key
        /// material into a CMK, you can reimport the same key material into that CMK, but you
        /// cannot import different key material.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the provided import token is expired. Use <a>GetParametersForImport</a>
        /// to get a new import token and public key, use the new public key to encrypt the key
        /// material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the provided key material is invalid or is not the
        /// same key material that was previously imported into this customer master key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext, or additional authenticated
        /// data incorporated into the ciphertext, such as the encryption context, is corrupted,
        /// missing, or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different customer master key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Gets a list of all aliases in the caller's AWS account and region. You cannot list
        /// aliases in other accounts. For more information about aliases, see <a>CreateAlias</a>.
        /// 
        ///  
        /// <para>
        /// By default, the <code>ListAliases</code> command returns all aliases in the account
        /// and region. To get only the aliases that point to a particular customer master key
        /// (CMK), use the <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListAliases</code> response might include several aliases have no <code>TargetKeyId</code>
        /// field. These are predefined aliases that AWS has created but has not yet associated
        /// with a CMK. Aliases that AWS creates in your account, including predefined aliases,
        /// do not count against your <a href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">AWS
        /// KMS aliases limit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGrants


        /// <summary>
        /// Gets a list of all grants for the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        ListGrantsResponse ListGrants(ListGrantsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListKeyPolicies


        /// <summary>
        /// Gets the names of the key policies that are attached to a customer master key (CMK).
        /// This operation is designed to get policy names that you can use in a <a>GetKeyPolicy</a>
        /// operation. However, the only valid policy name is <code>default</code>. You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Gets a list of all customer master keys (CMKs) in the caller's AWS account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        ListKeysResponse ListKeys(ListKeysRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceTags


        /// <summary>
        /// Returns a list of all tags for the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRetirableGrants


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        ListRetirableGrantsResponse ListRetirableGrants(string retiringPrincipal);

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        ListRetirableGrantsResponse ListRetirableGrants();

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request);


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetirableGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutKeyPolicy


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the CMK. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>AWS Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>AWS Identity and Access Management User Guide</i>. </li> </ul> The key policy size limit is 32 kilobytes (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        PutKeyPolicyResponse PutKeyPolicy(string keyId, string policy, string policyName);

        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request);


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the CMK. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>AWS Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>AWS Identity and Access Management User Guide</i>. </li> </ul> The key policy size limit is 32 kilobytes (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReEncrypt


        /// <summary>
        /// Encrypts data on the server side with a new customer master key (CMK) without exposing
        /// the plaintext of the data on the client side. The data is first decrypted and then
        /// reencrypted. You can also use this operation to change the encryption context of a
        /// ciphertext. 
        /// 
        ///  
        /// <para>
        /// You can reencrypt data using CMKs in different AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// Unlike other operations, <code>ReEncrypt</code> is authorized twice, once as <code>ReEncryptFrom</code>
        /// on the source CMK and once as <code>ReEncryptTo</code> on the destination CMK. We
        /// recommend that you include the <code>"kms:ReEncrypt*"</code> permission in your <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policies</a> to permit reencryption from or to the CMK. This permission is automatically
        /// included in the key policy when you create a CMK through the console, but you must
        /// include it manually when you create a CMK programmatically or when you set a key policy
        /// with the <a>PutKeyPolicy</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext, or additional authenticated
        /// data incorporated into the ciphertext, such as the encryption context, is corrupted,
        /// missing, or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        ReEncryptResponse ReEncrypt(ReEncryptRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetireGrant


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        RetireGrantResponse RetireGrant(string grantToken);

        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        RetireGrantResponse RetireGrant(RetireGrantRequest request);


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeGrant


        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        RevokeGrantResponse RevokeGrant(string grantId, string keyId);

        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        RevokeGrantResponse RevokeGrant(RevokeGrantRequest request);


        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ScheduleKeyDeletion


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId);

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId, int pendingWindowInDays);

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request);


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or edits tags for a customer master key (CMK). You cannot perform this operation
        /// on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty (null) strings.
        /// </para>
        ///  
        /// <para>
        /// You can only use a tag key once for each CMK. If you use the tag key again, AWS KMS
        /// replaces the current tag value with the specified value.
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// To remove a tag, specify the tag key. To change the tag value of an existing tag key,
        /// use <a>TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Associates an existing alias with a different customer master key (CMK). Each CMK
        /// can have multiple aliases, but the aliases must be unique within the account and region.
        /// You cannot perform this operation on an alias in a different AWS account.
        /// 
        ///  
        /// <para>
        /// This operation works only on existing aliases. To change the alias of a CMK to a new
        /// value, use <a>CreateAlias</a> to create a new alias and <a>DeleteAlias</a> to delete
        /// the old alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word <code>alias</code> followed
        /// by a forward slash (<code>alias/</code>). The alias name can contain only alphanumeric
        /// characters, forward slashes (/), underscores (_), and dashes (-). Alias names cannot
        /// begin with <code>aws</code>; that alias name prefix is reserved by Amazon Web Services
        /// (AWS).
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        UpdateAliasResponse UpdateAlias(string aliasName, string targetKeyId);

        /// <summary>
        /// Associates an existing alias with a different customer master key (CMK). Each CMK
        /// can have multiple aliases, but the aliases must be unique within the account and region.
        /// You cannot perform this operation on an alias in a different AWS account.
        /// 
        ///  
        /// <para>
        /// This operation works only on existing aliases. To change the alias of a CMK to a new
        /// value, use <a>CreateAlias</a> to create a new alias and <a>DeleteAlias</a> to delete
        /// the old alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word <code>alias</code> followed
        /// by a forward slash (<code>alias/</code>). The alias name can contain only alphanumeric
        /// characters, forward slashes (/), underscores (_), and dashes (-). Alias names cannot
        /// begin with <code>aws</code>; that alias name prefix is reserved by Amazon Web Services
        /// (AWS).
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);


        /// <summary>
        /// Associates an existing alias with a different customer master key (CMK). Each CMK
        /// can have multiple aliases, but the aliases must be unique within the account and region.
        /// You cannot perform this operation on an alias in a different AWS account.
        /// 
        ///  
        /// <para>
        /// This operation works only on existing aliases. To change the alias of a CMK to a new
        /// value, use <a>CreateAlias</a> to create a new alias and <a>DeleteAlias</a> to delete
        /// the old alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word <code>alias</code> followed
        /// by a forward slash (<code>alias/</code>). The alias name can contain only alphanumeric
        /// characters, forward slashes (/), underscores (_), and dashes (-). Alias names cannot
        /// begin with <code>aws</code>; that alias name prefix is reserved by Amazon Web Services
        /// (AWS).
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCustomKeyStore


        /// <summary>
        /// Changes the properties of a custom key store. Use the <code>CustomKeyStoreId</code>
        /// parameter to identify the custom key store you want to edit. Use the remaining parameters
        /// to change the properties of the custom key store.
        /// 
        ///  
        /// <para>
        /// You can only update a custom key store that is disconnected. To disconnect the custom
        /// key store, use <a>DisconnectCustomKeyStore</a>. To reconnect the custom key store
        /// after the update completes, use <a>ConnectCustomKeyStore</a>. To find the connection
        /// state of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>NewCustomKeyStoreName</code> parameter to change the friendly name of
        /// the custom key store to the value that you specify.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>KeyStorePassword</code> parameter tell AWS KMS the current password
        /// of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user (CU)</a> in the associated AWS CloudHSM cluster.
        /// You can use this parameter to fix connection failures that occur when AWS KMS cannot
        /// log into the associated cluster because the <code>kmsuser</code> password has changed.
        /// This value does not change the password in the AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>CloudHsmClusterId</code> parameter to associate the custom key store
        /// with a related AWS CloudHSM cluster, that is, a cluster that shares a backup history
        /// with the original cluster. You can use this parameter to repair a custom key store
        /// if its AWS CloudHSM cluster becomes corrupted or is deleted, or when you need to create
        /// or restore a cluster from a backup.
        /// </para>
        ///  
        /// <para>
        /// The cluster ID must identify a AWS CloudHSM cluster with the following requirements.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be active and be in the same AWS account and Region as the custom
        /// key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must have the same cluster certificate as the original cluster. You cannot
        /// use this parameter to associate the custom key store with an unrelated cluster. To
        /// view the cluster certificate, use the AWS CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. Clusters that share a backup history have the same cluster certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must be configured with subnets in at least two different Availability
        /// Zones in the Region. Because AWS CloudHSM is not supported in all Availability Zones,
        /// we recommend that the cluster have subnets in all Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least two active HSMs, each in a different Availability
        /// Zone.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store. The cluster must be configured
        /// with private subnets in at least two different Availability Zones in the Region. Also,
        /// it must contain at least as many HSMs as the operation requires.
        /// 
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a private subnet for a AWS CloudHSM cluster, see <a
        /// href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. To add HSMs, use the AWS
        /// CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because AWS KMS cannot find the AWS CloudHSM cluster with
        /// the specified cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotRelatedException">
        /// The request was rejected because the specified AWS CloudHSM cluster has a different
        /// cluster certificate than the original cluster. You cannot use the operation to specify
        /// an unrelated cluster.
        /// 
        ///  
        /// <para>
        /// Specify a cluster that shares a backup history with the original cluster. This includes
        /// clusters that were created from a backup of the current cluster, and clusters that
        /// were created from the same backup that produced the current cluster.
        /// </para>
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        UpdateCustomKeyStoreResponse UpdateCustomKeyStore(UpdateCustomKeyStoreRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        Task<UpdateCustomKeyStoreResponse> UpdateCustomKeyStoreAsync(UpdateCustomKeyStoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateKeyDescription


        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the decription of a
        /// CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the CMK.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        UpdateKeyDescriptionResponse UpdateKeyDescription(string keyId, string description);

        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the decription of a
        /// CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request);


        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the decription of a
        /// CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the CMK.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}