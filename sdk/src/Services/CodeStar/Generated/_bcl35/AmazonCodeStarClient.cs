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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CodeStar.Model;
using Amazon.CodeStar.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeStar
{
    /// <summary>
    /// Implementation for accessing CodeStar
    ///
    /// AWS CodeStar 
    /// <para>
    /// This is the API reference for AWS CodeStar. This reference provides descriptions of
    /// the operations and data types for the AWS CodeStar API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeStar API to work with:
    /// </para>
    ///  
    /// <para>
    /// Projects and their resources, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateProject</a>, which creates an empty project in AWS CodeStar with no resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteProject</a>, which deletes a project in AWS CodeStar.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeProject</a>, which lists the attributes of a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which lists all AWS CodeStar projects associated with your AWS
    /// account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListResources</a>, which lists the resources associated with an AWS CodeStar project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateProject</a>, which updates the attributes of an AWS CodeStar project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Teams and team members, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AssociateTeamMember</a>, which adds an IAM user to the team for an AWS CodeStar
    /// project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisassociateTeamMember</a>, which removes an IAM user from the team for an AWS
    /// CodeStar project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTeamMembers</a>, which lists all the IAM users in the team for an AWS CodeStar
    /// project, including their roles and attributes.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateUserProfile</a>, which creates a user profile that contains data associated
    /// with the user across all AWS CodeStar projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteUserProfile</a>, which deletes all user profile information across all AWS
    /// CodeStar projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeUserProfile</a>, which describes the profile of a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListUserProfiles</a>, which lists all AWS CodeStar user profiles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateUserProfile</a>, which updates the profile for an AWS CodeStar user. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeStarClient : AmazonServiceClient, IAmazonCodeStar
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeStarClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeStarConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeStarClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(AmazonCodeStarConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeStarClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeStarConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Credentials and an
        /// AmazonCodeStarClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(AWSCredentials credentials, AmazonCodeStarConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeStarConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeStarClient Configuration Object</param>
        public AmazonCodeStarClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeStarConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AssociateTeamMember

        /// <summary>
        /// Adds an IAM user to the team for an AWS CodeStar project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember service method.</param>
        /// 
        /// <returns>The response from the AssociateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.TeamMemberAlreadyAssociatedException">
        /// The team member is already associated with a role in this project.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        public AssociateTeamMemberResponse AssociateTeamMember(AssociateTeamMemberRequest request)
        {
            var marshaller = new AssociateTeamMemberRequestMarshaller();
            var unmarshaller = AssociateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<AssociateTeamMemberRequest,AssociateTeamMemberResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        public IAsyncResult BeginAssociateTeamMember(AssociateTeamMemberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateTeamMemberRequestMarshaller();
            var unmarshaller = AssociateTeamMemberResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateTeamMemberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTeamMember.</param>
        /// 
        /// <returns>Returns a  AssociateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        public  AssociateTeamMemberResponse EndAssociateTeamMember(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTeamMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a project in AWS CodeStar with minimal structure and no resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectAlreadyExistsException">
        /// An AWS CodeStar project with the same ID already exists in this region for the AWS
        /// account. AWS CodeStar project IDs must be unique within a region for the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectCreationFailedException">
        /// The project creation request was valid, but a nonspecific exception or error occurred
        /// during project creation. The project could not be created in AWS CodeStar.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public  CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserProfile

        /// <summary>
        /// Creates a profile for a user that includes user preferences, such as the display name
        /// and email address assocciated with the user, in AWS CodeStar. The user profile is
        /// not project-specific. Information in the user profile is displayed wherever the user's
        /// information appears to other users in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileAlreadyExistsException">
        /// A user profile with that name already exists in this region for the AWS account. AWS
        /// CodeStar user profile names must be unique within a region for the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public  CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes a project, including project resources. Does not delete users associated with
        /// the project, but does delete the IAM roles that allowed access to the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public  DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserProfile

        /// <summary>
        /// Deletes a user profile in AWS CodeStar, including all personal preference data associated
        /// with that profile, such as display name and email address. It does not delete the
        /// history of that user, for example the history of commits made by that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public  DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProject

        /// <summary>
        /// Describes a project and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var marshaller = new DescribeProjectRequestMarshaller();
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectRequest,DescribeProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeProjectRequestMarshaller();
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public  DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUserProfile

        /// <summary>
        /// Describes a user in AWS CodeStar and the user attributes across all projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileNotFoundException">
        /// The user profile was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request)
        {
            var marshaller = new DescribeUserProfileRequestMarshaller();
            var unmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfileRequest,DescribeUserProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public IAsyncResult BeginDescribeUserProfile(DescribeUserProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeUserProfileRequestMarshaller();
            var unmarshaller = DescribeUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeUserProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        public  DescribeUserProfileResponse EndDescribeUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTeamMember

        /// <summary>
        /// Removes a user from a project. Removing a user from a project also removes the IAM
        /// policies from that user that allowed access to the project and its resources. Disassociating
        /// a team member does not remove that user's profile from AWS CodeStar. It does not remove
        /// the user from IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        public DisassociateTeamMemberResponse DisassociateTeamMember(DisassociateTeamMemberRequest request)
        {
            var marshaller = new DisassociateTeamMemberRequestMarshaller();
            var unmarshaller = DisassociateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<DisassociateTeamMemberRequest,DisassociateTeamMemberResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        public IAsyncResult BeginDisassociateTeamMember(DisassociateTeamMemberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateTeamMemberRequestMarshaller();
            var unmarshaller = DisassociateTeamMemberResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateTeamMemberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTeamMember.</param>
        /// 
        /// <returns>Returns a  DisassociateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        public  DisassociateTeamMemberResponse EndDisassociateTeamMember(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTeamMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Lists all projects in AWS CodeStar associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return BeginInvoke<ListProjectsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public  ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResources

        /// <summary>
        /// Lists resources associated with a project in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var marshaller = new ListResourcesRequestMarshaller();
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesRequest,ListResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        public IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListResourcesRequestMarshaller();
            var unmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        public  ListResourcesResponse EndListResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTeamMembers

        /// <summary>
        /// Lists all team members associated with a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers service method.</param>
        /// 
        /// <returns>The response from the ListTeamMembers service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        public ListTeamMembersResponse ListTeamMembers(ListTeamMembersRequest request)
        {
            var marshaller = new ListTeamMembersRequestMarshaller();
            var unmarshaller = ListTeamMembersResponseUnmarshaller.Instance;

            return Invoke<ListTeamMembersRequest,ListTeamMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTeamMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        public IAsyncResult BeginListTeamMembers(ListTeamMembersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTeamMembersRequestMarshaller();
            var unmarshaller = ListTeamMembersResponseUnmarshaller.Instance;

            return BeginInvoke<ListTeamMembersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTeamMembers.</param>
        /// 
        /// <returns>Returns a  ListTeamMembersResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        public  ListTeamMembersResponse EndListTeamMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTeamMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserProfiles

        /// <summary>
        /// Lists all the user profiles configured for your AWS account in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request)
        {
            var marshaller = new ListUserProfilesRequestMarshaller();
            var unmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return Invoke<ListUserProfilesRequest,ListUserProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public IAsyncResult BeginListUserProfiles(ListUserProfilesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListUserProfilesRequestMarshaller();
            var unmarshaller = ListUserProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<ListUserProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserProfiles.</param>
        /// 
        /// <returns>Returns a  ListUserProfilesResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        public  ListUserProfilesResponse EndListUserProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProject

        /// <summary>
        /// Updates a project in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public  UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTeamMember

        /// <summary>
        /// Updates a team member's attributes in an AWS CodeStar project. For example, you can
        /// change a team member's role in the project, or change whether they have remote access
        /// to project resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember service method.</param>
        /// 
        /// <returns>The response from the UpdateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.TeamMemberNotFoundException">
        /// The specified team member was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        public UpdateTeamMemberResponse UpdateTeamMember(UpdateTeamMemberRequest request)
        {
            var marshaller = new UpdateTeamMemberRequestMarshaller();
            var unmarshaller = UpdateTeamMemberResponseUnmarshaller.Instance;

            return Invoke<UpdateTeamMemberRequest,UpdateTeamMemberResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        public IAsyncResult BeginUpdateTeamMember(UpdateTeamMemberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateTeamMemberRequestMarshaller();
            var unmarshaller = UpdateTeamMemberResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTeamMemberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTeamMember.</param>
        /// 
        /// <returns>Returns a  UpdateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        public  UpdateTeamMemberResponse EndUpdateTeamMember(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTeamMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserProfile

        /// <summary>
        /// Updates a user's profile in AWS CodeStar. The user profile is not project-specific.
        /// Information in the user profile is displayed wherever the user's information appears
        /// to other users in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileNotFoundException">
        /// The user profile was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public  UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserProfileResponse>(asyncResult);
        }

        #endregion
        
    }
}