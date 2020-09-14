// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.ShoppingContent.v2_1
{
    /// <summary>The ShoppingContent Service.</summary>
    public class ShoppingContentService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2.1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ShoppingContentService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ShoppingContentService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Accountstatuses = new AccountstatusesResource(this);
            Accounttax = new AccounttaxResource(this);
            Datafeeds = new DatafeedsResource(this);
            Datafeedstatuses = new DatafeedstatusesResource(this);
            Liasettings = new LiasettingsResource(this);
            Localinventory = new LocalinventoryResource(this);
            Orderinvoices = new OrderinvoicesResource(this);
            Orderreports = new OrderreportsResource(this);
            Orderreturns = new OrderreturnsResource(this);
            Orders = new OrdersResource(this);
            Pos = new PosResource(this);
            Products = new ProductsResource(this);
            Productstatuses = new ProductstatusesResource(this);
            Pubsubnotificationsettings = new PubsubnotificationsettingsResource(this);
            Regionalinventory = new RegionalinventoryResource(this);
            Returnaddress = new ReturnaddressResource(this);
            Returnpolicy = new ReturnpolicyResource(this);
            Settlementreports = new SettlementreportsResource(this);
            Settlementtransactions = new SettlementtransactionsResource(this);
            Shippingsettings = new ShippingsettingsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "content";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/content/v2.1/";
        #else
            "https://www.googleapis.com/content/v2.1/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "content/v2.1/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/content/v2.1";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/content/v2.1";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Content API for Shopping.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Content API for Shopping.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";

        }



        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Accountstatuses resource.</summary>
        public virtual AccountstatusesResource Accountstatuses { get; }

        /// <summary>Gets the Accounttax resource.</summary>
        public virtual AccounttaxResource Accounttax { get; }

        /// <summary>Gets the Datafeeds resource.</summary>
        public virtual DatafeedsResource Datafeeds { get; }

        /// <summary>Gets the Datafeedstatuses resource.</summary>
        public virtual DatafeedstatusesResource Datafeedstatuses { get; }

        /// <summary>Gets the Liasettings resource.</summary>
        public virtual LiasettingsResource Liasettings { get; }

        /// <summary>Gets the Localinventory resource.</summary>
        public virtual LocalinventoryResource Localinventory { get; }

        /// <summary>Gets the Orderinvoices resource.</summary>
        public virtual OrderinvoicesResource Orderinvoices { get; }

        /// <summary>Gets the Orderreports resource.</summary>
        public virtual OrderreportsResource Orderreports { get; }

        /// <summary>Gets the Orderreturns resource.</summary>
        public virtual OrderreturnsResource Orderreturns { get; }

        /// <summary>Gets the Orders resource.</summary>
        public virtual OrdersResource Orders { get; }

        /// <summary>Gets the Pos resource.</summary>
        public virtual PosResource Pos { get; }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>Gets the Productstatuses resource.</summary>
        public virtual ProductstatusesResource Productstatuses { get; }

        /// <summary>Gets the Pubsubnotificationsettings resource.</summary>
        public virtual PubsubnotificationsettingsResource Pubsubnotificationsettings { get; }

        /// <summary>Gets the Regionalinventory resource.</summary>
        public virtual RegionalinventoryResource Regionalinventory { get; }

        /// <summary>Gets the Returnaddress resource.</summary>
        public virtual ReturnaddressResource Returnaddress { get; }

        /// <summary>Gets the Returnpolicy resource.</summary>
        public virtual ReturnpolicyResource Returnpolicy { get; }

        /// <summary>Gets the Settlementreports resource.</summary>
        public virtual SettlementreportsResource Settlementreports { get; }

        /// <summary>Gets the Settlementtransactions resource.</summary>
        public virtual SettlementtransactionsResource Settlementtransactions { get; }

        /// <summary>Gets the Shippingsettings resource.</summary>
        public virtual ShippingsettingsResource Shippingsettings { get; }
    }

    ///<summary>A base abstract class for ShoppingContent requests.</summary>
    public abstract class ShoppingContentBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ShoppingContentBaseServiceRequest instance.</summary>
        protected ShoppingContentBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes ShoppingContent parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns information about the authenticated user.</summary>
        public virtual AuthinfoRequest Authinfo()
        {
            return new AuthinfoRequest(service);
        }

        /// <summary>Returns information about the authenticated user.</summary>
        public class AuthinfoRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsAuthInfoResponse>
        {
            /// <summary>Constructs a new Authinfo request.</summary>
            public AuthinfoRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName => "authinfo";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/authinfo";

            /// <summary>Initializes Authinfo parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Claims the website of a Merchant Center sub-account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account whose website is claimed.</param>
        public virtual ClaimwebsiteRequest Claimwebsite(ulong merchantId, ulong accountId)
        {
            return new ClaimwebsiteRequest(service, merchantId, accountId);
        }

        /// <summary>Claims the website of a Merchant Center sub-account.</summary>
        public class ClaimwebsiteRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsClaimWebsiteResponse>
        {
            /// <summary>Constructs a new Claimwebsite request.</summary>
            public ClaimwebsiteRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account whose website is claimed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>Only available to selected merchants. When set to `True`, this flag removes any existing claim
            /// on the requested website by another account and replaces it with a claim from this account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("overwrite", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Overwrite { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "claimwebsite";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}/claimwebsite";

            /// <summary>Initializes Claimwebsite parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "overwrite", new Google.Apis.Discovery.Parameter
                    {
                        Name = "overwrite",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves, inserts, updates, and deletes multiple Merchant Center (sub-)accounts in a single
        /// request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.AccountsCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves, inserts, updates, and deletes multiple Merchant Center (sub-)accounts in a single
        /// request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccountsCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccountsCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a Merchant Center sub-account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account, and accountId must be
        /// the ID of a sub-account of this account.</param>
        /// <param name="accountId">The ID of the account.</param>
        public virtual DeleteRequest Delete(ulong merchantId, ulong accountId)
        {
            return new DeleteRequest(service, merchantId, accountId);
        }

        /// <summary>Deletes a Merchant Center sub-account.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account, and accountId must be the
            /// ID of a sub-account of this account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>Flag to delete sub-accounts with products. The default value is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Force { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "force", new Google.Apis.Discovery.Parameter
                    {
                        Name = "force",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account.</param>
        public virtual GetRequest Get(ulong merchantId, ulong accountId)
        {
            return new GetRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves a Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>Controls which fields will be populated. Acceptable values are: "merchant" and "css". The
            /// default value is "merchant".</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Controls which fields will be populated. Acceptable values are: "merchant" and "css". The
            /// default value is "merchant".</summary>
            public enum ViewEnum
            {
                [Google.Apis.Util.StringValueAttribute("css")]
                Css,
                [Google.Apis.Util.StringValueAttribute("merchant")]
                Merchant,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a Merchant Center sub-account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.Account body, ulong merchantId)
        {
            return new InsertRequest(service, body, merchantId);
        }

        /// <summary>Creates a Merchant Center sub-account.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Account>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.Account body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.Account Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Performs an action on a link between two Merchant Center accounts, namely accountId and
        /// linkedAccountId.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account that should be linked.</param>
        public virtual LinkRequest Link(Google.Apis.ShoppingContent.v2_1.Data.AccountsLinkRequest body, ulong merchantId, ulong accountId)
        {
            return new LinkRequest(service, body, merchantId, accountId);
        }

        /// <summary>Performs an action on a link between two Merchant Center accounts, namely accountId and
        /// linkedAccountId.</summary>
        public class LinkRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsLinkResponse>
        {
            /// <summary>Constructs a new Link request.</summary>
            public LinkRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccountsLinkRequest body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account that should be linked.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccountsLinkRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "link";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}/link";

            /// <summary>Initializes Link parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the sub-accounts in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the sub-accounts in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>If view is set to "css", only return accounts that are assigned label with given ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("label", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> Label { get; set; }

            /// <summary>The maximum number of accounts to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Controls which fields will be populated. Acceptable values are: "merchant" and "css". The
            /// default value is "merchant".</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Controls which fields will be populated. Acceptable values are: "merchant" and "css". The
            /// default value is "merchant".</summary>
            public enum ViewEnum
            {
                [Google.Apis.Util.StringValueAttribute("css")]
                Css,
                [Google.Apis.Util.StringValueAttribute("merchant")]
                Merchant,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "label", new Google.Apis.Discovery.Parameter
                    {
                        Name = "label",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Returns the list of accounts linked to your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to list links.</param>
        public virtual ListlinksRequest Listlinks(ulong merchantId, ulong accountId)
        {
            return new ListlinksRequest(service, merchantId, accountId);
        }

        /// <summary>Returns the list of accounts linked to your Merchant Center account.</summary>
        public class ListlinksRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsListLinksResponse>
        {
            /// <summary>Constructs a new Listlinks request.</summary>
            public ListlinksRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to list links.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>The maximum number of links to return in the response, used for pagination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "listlinks";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}/listlinks";

            /// <summary>Initializes Listlinks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a Merchant Center account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.Account body, ulong merchantId, ulong accountId)
        {
            return new UpdateRequest(service, body, merchantId, accountId);
        }

        /// <summary>Updates a Merchant Center account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.Account body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.Account Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates labels that are assigned to the Merchant Center account by CSS user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="accountId">The ID of the
        /// account whose labels are updated.</param>
        public virtual UpdatelabelsRequest Updatelabels(Google.Apis.ShoppingContent.v2_1.Data.AccountsUpdateLabelsRequest body, ulong merchantId, ulong accountId)
        {
            return new UpdatelabelsRequest(service, body, merchantId, accountId);
        }

        /// <summary>Updates labels that are assigned to the Merchant Center account by CSS user.</summary>
        public class UpdatelabelsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountsUpdateLabelsResponse>
        {
            /// <summary>Constructs a new Updatelabels request.</summary>
            public UpdatelabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccountsUpdateLabelsRequest body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account whose labels are updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccountsUpdateLabelsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "updatelabels";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounts/{accountId}/updatelabels";

            /// <summary>Initializes Updatelabels parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "accountstatuses" collection of methods.</summary>
    public class AccountstatusesResource
    {
        private const string Resource = "accountstatuses";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountstatusesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves multiple Merchant Center account statuses in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.AccountstatusesCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves multiple Merchant Center account statuses in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountstatusesCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccountstatusesCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccountstatusesCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accountstatuses/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the status of a Merchant Center account. No itemLevelIssues are returned for multi-client
        /// accounts.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account.</param>
        public virtual GetRequest Get(ulong merchantId, ulong accountId)
        {
            return new GetRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves the status of a Merchant Center account. No itemLevelIssues are returned for multi-client
        /// accounts.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountStatus>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
            /// Shopping destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinations", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Destinations { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accountstatuses/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "destinations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "destinations",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the statuses of the sub-accounts in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the statuses of the sub-accounts in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountstatusesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
            /// Shopping destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinations", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Destinations { get; set; }

            /// <summary>The maximum number of account statuses to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accountstatuses";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "destinations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "destinations",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "accounttax" collection of methods.</summary>
    public class AccounttaxResource
    {
        private const string Resource = "accounttax";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccounttaxResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves and updates tax settings of multiple accounts in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.AccounttaxCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves and updates tax settings of multiple accounts in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccounttaxCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccounttaxCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccounttaxCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "accounttax/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the tax settings of the account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get/update account tax
        /// settings.</param>
        public virtual GetRequest Get(ulong merchantId, ulong accountId)
        {
            return new GetRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves the tax settings of the account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountTax>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get/update account tax settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounttax/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the tax settings of the sub-accounts in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the tax settings of the sub-accounts in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccounttaxListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of tax settings to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounttax";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the tax settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get/update account tax
        /// settings.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.AccountTax body, ulong merchantId, ulong accountId)
        {
            return new UpdateRequest(service, body, merchantId, accountId);
        }

        /// <summary>Updates the tax settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.AccountTax>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.AccountTax body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get/update account tax settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.AccountTax Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/accounttax/{accountId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "datafeeds" collection of methods.</summary>
    public class DatafeedsResource
    {
        private const string Resource = "datafeeds";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DatafeedsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes, fetches, gets, inserts and updates multiple datafeeds in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.DatafeedsCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Deletes, fetches, gets, inserts and updates multiple datafeeds in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedsCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.DatafeedsCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.DatafeedsCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "datafeeds/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a datafeed configuration from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        /// <param name="datafeedId">The ID of the datafeed.</param>
        public virtual DeleteRequest Delete(ulong merchantId, ulong datafeedId)
        {
            return new DeleteRequest(service, merchantId, datafeedId);
        }

        /// <summary>Deletes a datafeed configuration from your Merchant Center account.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong datafeedId)
                : base(service)
            {
                MerchantId = merchantId;
                DatafeedId = datafeedId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the datafeed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datafeedId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong DatafeedId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds/{datafeedId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "datafeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "datafeedId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Invokes a fetch for the datafeed in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        /// <param name="datafeedId">The ID of the datafeed to be fetched.</param>
        public virtual FetchnowRequest Fetchnow(ulong merchantId, ulong datafeedId)
        {
            return new FetchnowRequest(service, merchantId, datafeedId);
        }

        /// <summary>Invokes a fetch for the datafeed in your Merchant Center account.</summary>
        public class FetchnowRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedsFetchNowResponse>
        {
            /// <summary>Constructs a new Fetchnow request.</summary>
            public FetchnowRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong datafeedId)
                : base(service)
            {
                MerchantId = merchantId;
                DatafeedId = datafeedId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the datafeed to be fetched.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datafeedId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong DatafeedId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "fetchnow";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds/{datafeedId}/fetchNow";

            /// <summary>Initializes Fetchnow parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "datafeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "datafeedId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a datafeed configuration from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        /// <param name="datafeedId">The ID of the datafeed.</param>
        public virtual GetRequest Get(ulong merchantId, ulong datafeedId)
        {
            return new GetRequest(service, merchantId, datafeedId);
        }

        /// <summary>Retrieves a datafeed configuration from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Datafeed>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong datafeedId)
                : base(service)
            {
                MerchantId = merchantId;
                DatafeedId = datafeedId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the datafeed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datafeedId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong DatafeedId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds/{datafeedId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "datafeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "datafeedId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Registers a datafeed configuration with your Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.Datafeed body, ulong merchantId)
        {
            return new InsertRequest(service, body, merchantId);
        }

        /// <summary>Registers a datafeed configuration with your Merchant Center account.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Datafeed>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.Datafeed body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.Datafeed Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the configurations for datafeeds in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeeds. This account cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the configurations for datafeeds in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeeds. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of products to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a datafeed configuration of your Merchant Center account. Any fields that are not provided
        /// are deleted from the resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        /// <param name="datafeedId">The ID of the datafeed.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.Datafeed body, ulong merchantId, ulong datafeedId)
        {
            return new UpdateRequest(service, body, merchantId, datafeedId);
        }

        /// <summary>Updates a datafeed configuration of your Merchant Center account. Any fields that are not provided
        /// are deleted from the resource.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Datafeed>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.Datafeed body, ulong merchantId, ulong datafeedId)
                : base(service)
            {
                MerchantId = merchantId;
                DatafeedId = datafeedId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the datafeed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datafeedId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong DatafeedId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.Datafeed Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeeds/{datafeedId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "datafeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "datafeedId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "datafeedstatuses" collection of methods.</summary>
    public class DatafeedstatusesResource
    {
        private const string Resource = "datafeedstatuses";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DatafeedstatusesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets multiple Merchant Center datafeed statuses in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.DatafeedstatusesCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Gets multiple Merchant Center datafeed statuses in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedstatusesCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.DatafeedstatusesCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.DatafeedstatusesCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "datafeedstatuses/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the status of a datafeed from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeed. This account cannot be a multi-client
        /// account.</param>
        /// <param name="datafeedId">The ID of the datafeed.</param>
        public virtual GetRequest Get(ulong merchantId, ulong datafeedId)
        {
            return new GetRequest(service, merchantId, datafeedId);
        }

        /// <summary>Retrieves the status of a datafeed from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedStatus>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong datafeedId)
                : base(service)
            {
                MerchantId = merchantId;
                DatafeedId = datafeedId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeed. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the datafeed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("datafeedId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong DatafeedId { get; private set; }

            /// <summary>The country for which to get the datafeed status. If this parameter is provided then language
            /// must also be provided. Note that this parameter is required for feeds targeting multiple countries and
            /// languages, since a feed may have a different status for each target.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; set; }

            /// <summary>The language for which to get the datafeed status. If this parameter is provided then country
            /// must also be provided. Note that this parameter is required for feeds targeting multiple countries and
            /// languages, since a feed may have a different status for each target.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeedstatuses/{datafeedId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "datafeedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "datafeedId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the statuses of the datafeeds in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the datafeeds. This account cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the statuses of the datafeeds in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.DatafeedstatusesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the datafeeds. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of products to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/datafeedstatuses";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "liasettings" collection of methods.</summary>
    public class LiasettingsResource
    {
        private const string Resource = "liasettings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiasettingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves and/or updates the LIA settings of multiple accounts in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.LiasettingsCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves and/or updates the LIA settings of multiple accounts in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.LiasettingsCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.LiasettingsCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "liasettings/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the LIA settings of the account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get or update LIA
        /// settings.</param>
        public virtual GetRequest Get(ulong merchantId, ulong accountId)
        {
            return new GetRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves the LIA settings of the account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiaSettings>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get or update LIA settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves the list of accessible Google My Business accounts.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to retrieve accessible Google My
        /// Business accounts.</param>
        public virtual GetaccessiblegmbaccountsRequest Getaccessiblegmbaccounts(ulong merchantId, ulong accountId)
        {
            return new GetaccessiblegmbaccountsRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves the list of accessible Google My Business accounts.</summary>
        public class GetaccessiblegmbaccountsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsGetAccessibleGmbAccountsResponse>
        {
            /// <summary>Constructs a new Getaccessiblegmbaccounts request.</summary>
            public GetaccessiblegmbaccountsRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to retrieve accessible Google My Business accounts.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getaccessiblegmbaccounts";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}/accessiblegmbaccounts";

            /// <summary>Initializes Getaccessiblegmbaccounts parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the LIA settings of the sub-accounts in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the LIA settings of the sub-accounts in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of LIA settings to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves the list of POS data providers that have active settings for the all eiligible
        /// countries.</summary>
        public virtual ListposdataprovidersRequest Listposdataproviders()
        {
            return new ListposdataprovidersRequest(service);
        }

        /// <summary>Retrieves the list of POS data providers that have active settings for the all eiligible
        /// countries.</summary>
        public class ListposdataprovidersRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsListPosDataProvidersResponse>
        {
            /// <summary>Constructs a new Listposdataproviders request.</summary>
            public ListposdataprovidersRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName => "listposdataproviders";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "liasettings/posdataproviders";

            /// <summary>Initializes Listposdataproviders parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Requests access to a specified Google My Business account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which GMB access is
        /// requested.</param>
        /// <param name="gmbEmail">The email of the Google My Business account.</param>
        public virtual RequestgmbaccessRequest Requestgmbaccess(ulong merchantId, ulong accountId, string gmbEmail)
        {
            return new RequestgmbaccessRequest(service, merchantId, accountId, gmbEmail);
        }

        /// <summary>Requests access to a specified Google My Business account.</summary>
        public class RequestgmbaccessRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsRequestGmbAccessResponse>
        {
            /// <summary>Constructs a new Requestgmbaccess request.</summary>
            public RequestgmbaccessRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId, string gmbEmail)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                GmbEmail = gmbEmail;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which GMB access is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>The email of the Google My Business account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("gmbEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GmbEmail { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "requestgmbaccess";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}/requestgmbaccess";

            /// <summary>Initializes Requestgmbaccess parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "gmbEmail", new Google.Apis.Discovery.Parameter
                    {
                        Name = "gmbEmail",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Requests inventory validation for the specified country.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account that manages the order. This cannot be a
        /// multi-client account.</param>
        /// <param name="country">The country for which inventory validation is
        /// requested.</param>
        public virtual RequestinventoryverificationRequest Requestinventoryverification(ulong merchantId, ulong accountId, string country)
        {
            return new RequestinventoryverificationRequest(service, merchantId, accountId, country);
        }

        /// <summary>Requests inventory validation for the specified country.</summary>
        public class RequestinventoryverificationRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsRequestInventoryVerificationResponse>
        {
            /// <summary>Constructs a new Requestinventoryverification request.</summary>
            public RequestinventoryverificationRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId, string country)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Country = country;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>The country for which inventory validation is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Country { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "requestinventoryverification";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}/requestinventoryverification/{country}";

            /// <summary>Initializes Requestinventoryverification parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sets the inventory verification contract for the specified country.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account that manages the order. This cannot be a
        /// multi-client account.</param>
        /// <param name="contactEmail">The email of the inventory verification
        /// contact.</param>
        /// <param name="contactName">The name of the inventory verification contact.</param>
        ///
        /// <param name="country">The country for which inventory verification is requested.</param>
        /// <param
        /// name="language">The language for which inventory verification is requested.</param>
        public virtual SetinventoryverificationcontactRequest Setinventoryverificationcontact(ulong merchantId, ulong accountId, string contactEmail, string contactName, string country, string language)
        {
            return new SetinventoryverificationcontactRequest(service, merchantId, accountId, contactEmail, contactName, country, language);
        }

        /// <summary>Sets the inventory verification contract for the specified country.</summary>
        public class SetinventoryverificationcontactRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsSetInventoryVerificationContactResponse>
        {
            /// <summary>Constructs a new Setinventoryverificationcontact request.</summary>
            public SetinventoryverificationcontactRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId, string contactEmail, string contactName, string country, string language)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                ContactEmail = contactEmail;
                ContactName = contactName;
                Country = country;
                Language = language;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>The email of the inventory verification contact.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contactEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContactEmail { get; private set; }

            /// <summary>The name of the inventory verification contact.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contactName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContactName { get; private set; }

            /// <summary>The country for which inventory verification is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; private set; }

            /// <summary>The language for which inventory verification is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "setinventoryverificationcontact";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}/setinventoryverificationcontact";

            /// <summary>Initializes Setinventoryverificationcontact parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "contactEmail", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contactEmail",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "contactName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contactName",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sets the POS data provider for the specified country.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to retrieve accessible Google My
        /// Business accounts.</param>
        /// <param name="country">The country for which the POS data provider is
        /// selected.</param>
        public virtual SetposdataproviderRequest Setposdataprovider(ulong merchantId, ulong accountId, string country)
        {
            return new SetposdataproviderRequest(service, merchantId, accountId, country);
        }

        /// <summary>Sets the POS data provider for the specified country.</summary>
        public class SetposdataproviderRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiasettingsSetPosDataProviderResponse>
        {
            /// <summary>Constructs a new Setposdataprovider request.</summary>
            public SetposdataproviderRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId, string country)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Country = country;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to retrieve accessible Google My Business accounts.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }

            /// <summary>The country for which the POS data provider is selected.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; private set; }

            /// <summary>The ID of POS data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("posDataProviderId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> PosDataProviderId { get; set; }

            /// <summary>The account ID by which this merchant is known to the POS data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("posExternalAccountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PosExternalAccountId { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "setposdataprovider";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}/setposdataprovider";

            /// <summary>Initializes Setposdataprovider parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "posDataProviderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "posDataProviderId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "posExternalAccountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "posExternalAccountId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the LIA settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get or update LIA
        /// settings.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.LiaSettings body, ulong merchantId, ulong accountId)
        {
            return new UpdateRequest(service, body, merchantId, accountId);
        }

        /// <summary>Updates the LIA settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LiaSettings>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.LiaSettings body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get or update LIA settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.LiaSettings Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/liasettings/{accountId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "localinventory" collection of methods.</summary>
    public class LocalinventoryResource
    {
        private const string Resource = "localinventory";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LocalinventoryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Updates local inventory for multiple products or stores in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.LocalinventoryCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Updates local inventory for multiple products or stores in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LocalinventoryCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.LocalinventoryCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.LocalinventoryCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "localinventory/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Update the local inventory of a product in your Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        /// <param name="productId">The REST ID of the product for which to update local
        /// inventory.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.LocalInventory body, ulong merchantId, string productId)
        {
            return new InsertRequest(service, body, merchantId, productId);
        }

        /// <summary>Update the local inventory of a product in your Merchant Center account.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.LocalInventory>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.LocalInventory body, ulong merchantId, string productId)
                : base(service)
            {
                MerchantId = merchantId;
                ProductId = productId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The REST ID of the product for which to update local inventory.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.LocalInventory Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products/{productId}/localinventory";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "orderinvoices" collection of methods.</summary>
    public class OrderinvoicesResource
    {
        private const string Resource = "orderinvoices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrderinvoicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Creates a charge invoice for a shipment group, and triggers a charge capture for orderinvoice
        /// enabled orders.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual CreatechargeinvoiceRequest Createchargeinvoice(Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateChargeInvoiceRequest body, ulong merchantId, string orderId)
        {
            return new CreatechargeinvoiceRequest(service, body, merchantId, orderId);
        }

        /// <summary>Creates a charge invoice for a shipment group, and triggers a charge capture for orderinvoice
        /// enabled orders.</summary>
        public class CreatechargeinvoiceRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateChargeInvoiceResponse>
        {
            /// <summary>Constructs a new Createchargeinvoice request.</summary>
            public CreatechargeinvoiceRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateChargeInvoiceRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateChargeInvoiceRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "createchargeinvoice";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderinvoices/{orderId}/createChargeInvoice";

            /// <summary>Initializes Createchargeinvoice parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a refund invoice for one or more shipment groups, and triggers a refund for orderinvoice
        /// enabled orders. This can only be used for line items that have previously been charged using
        /// `createChargeInvoice`. All amounts (except for the summary) are incremental with respect to the previous
        /// invoice.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual CreaterefundinvoiceRequest Createrefundinvoice(Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateRefundInvoiceRequest body, ulong merchantId, string orderId)
        {
            return new CreaterefundinvoiceRequest(service, body, merchantId, orderId);
        }

        /// <summary>Creates a refund invoice for one or more shipment groups, and triggers a refund for orderinvoice
        /// enabled orders. This can only be used for line items that have previously been charged using
        /// `createChargeInvoice`. All amounts (except for the summary) are incremental with respect to the previous
        /// invoice.</summary>
        public class CreaterefundinvoiceRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateRefundInvoiceResponse>
        {
            /// <summary>Constructs a new Createrefundinvoice request.</summary>
            public CreaterefundinvoiceRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateRefundInvoiceRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrderinvoicesCreateRefundInvoiceRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "createrefundinvoice";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderinvoices/{orderId}/createRefundInvoice";

            /// <summary>Initializes Createrefundinvoice parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "orderreports" collection of methods.</summary>
    public class OrderreportsResource
    {
        private const string Resource = "orderreports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrderreportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a report for disbursements from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="disbursementStartDate">The first date which disbursements occurred. In ISO
        /// 8601 format.</param>
        public virtual ListdisbursementsRequest Listdisbursements(ulong merchantId, string disbursementStartDate)
        {
            return new ListdisbursementsRequest(service, merchantId, disbursementStartDate);
        }

        /// <summary>Retrieves a report for disbursements from your Merchant Center account.</summary>
        public class ListdisbursementsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderreportsListDisbursementsResponse>
        {
            /// <summary>Constructs a new Listdisbursements request.</summary>
            public ListdisbursementsRequest(Google.Apis.Services.IClientService service, ulong merchantId, string disbursementStartDate)
                : base(service)
            {
                MerchantId = merchantId;
                DisbursementStartDate = disbursementStartDate;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The first date which disbursements occurred. In ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("disbursementStartDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DisbursementStartDate { get; private set; }

            /// <summary>The last date which disbursements occurred. In ISO 8601 format. Default: current
            /// date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("disbursementEndDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DisbursementEndDate { get; set; }

            /// <summary>The maximum number of disbursements to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "listdisbursements";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreports/disbursements";

            /// <summary>Initializes Listdisbursements parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "disbursementStartDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "disbursementStartDate",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "disbursementEndDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "disbursementEndDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a list of transactions for a disbursement from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="disbursementId">The Google-provided ID of the disbursement (found in
        /// Wallet).</param>
        /// <param name="transactionStartDate">The first date in which transaction occurred. In ISO
        /// 8601 format.</param>
        public virtual ListtransactionsRequest Listtransactions(ulong merchantId, string disbursementId, string transactionStartDate)
        {
            return new ListtransactionsRequest(service, merchantId, disbursementId, transactionStartDate);
        }

        /// <summary>Retrieves a list of transactions for a disbursement from your Merchant Center account.</summary>
        public class ListtransactionsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderreportsListTransactionsResponse>
        {
            /// <summary>Constructs a new Listtransactions request.</summary>
            public ListtransactionsRequest(Google.Apis.Services.IClientService service, ulong merchantId, string disbursementId, string transactionStartDate)
                : base(service)
            {
                MerchantId = merchantId;
                DisbursementId = disbursementId;
                TransactionStartDate = transactionStartDate;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The Google-provided ID of the disbursement (found in Wallet).</summary>
            [Google.Apis.Util.RequestParameterAttribute("disbursementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DisbursementId { get; private set; }

            /// <summary>The first date in which transaction occurred. In ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("transactionStartDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TransactionStartDate { get; private set; }

            /// <summary>The maximum number of disbursements to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The last date in which transaction occurred. In ISO 8601 format. Default: current
            /// date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("transactionEndDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TransactionEndDate { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "listtransactions";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreports/disbursements/{disbursementId}/transactions";

            /// <summary>Initializes Listtransactions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "disbursementId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "disbursementId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "transactionStartDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "transactionStartDate",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "transactionEndDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "transactionEndDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "orderreturns" collection of methods.</summary>
    public class OrderreturnsResource
    {
        private const string Resource = "orderreturns";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrderreturnsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Acks an order return in your Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="returnId">The ID of the return.</param>
        public virtual AcknowledgeRequest Acknowledge(Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsAcknowledgeRequest body, ulong merchantId, string returnId)
        {
            return new AcknowledgeRequest(service, body, merchantId, returnId);
        }

        /// <summary>Acks an order return in your Merchant Center account.</summary>
        public class AcknowledgeRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsAcknowledgeResponse>
        {
            /// <summary>Constructs a new Acknowledge request.</summary>
            public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsAcknowledgeRequest body, ulong merchantId, string returnId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnId = returnId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsAcknowledgeRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "acknowledge";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreturns/{returnId}/acknowledge";

            /// <summary>Initializes Acknowledge parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves an order return from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="returnId">Merchant order return ID generated by Google.</param>
        public virtual GetRequest Get(ulong merchantId, string returnId)
        {
            return new GetRequest(service, merchantId, returnId);
        }

        /// <summary>Retrieves an order return from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.MerchantOrderReturn>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string returnId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnId = returnId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Merchant order return ID generated by Google.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreturns/{returnId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists order returns in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists order returns in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Obtains order returns that match the acknowledgement status. When set to true, obtains order
            /// returns that have been acknowledged. When false, obtains order returns that have not been acknowledged.
            /// When not provided, obtains order returns regardless of their acknowledgement status. We recommend using
            /// this filter set to `false`, in conjunction with the `acknowledge` call, such that only un-acknowledged
            /// order returns are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("acknowledged", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Acknowledged { get; set; }

            /// <summary>Obtains order returns created before this date (inclusively), in ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createdEndDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CreatedEndDate { get; set; }

            /// <summary>Obtains order returns created after this date (inclusively), in ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createdStartDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CreatedStartDate { get; set; }

            /// <summary>Obtains order returns with the specified order ids. If this parameter is provided,
            /// createdStartDate, createdEndDate, shipmentType, shipmentStatus, shipmentState and acknowledged
            /// parameters must be not set. Note: if googleOrderId and shipmentTrackingNumber parameters are provided,
            /// the obtained results will include all order returns that either match the specified order id or the
            /// specified tracking number.</summary>
            [Google.Apis.Util.RequestParameterAttribute("googleOrderIds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> GoogleOrderIds { get; set; }

            /// <summary>The maximum number of order returns to return in the response, used for paging. The default
            /// value is 25 returns per page, and the maximum allowed value is 250 returns per page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Return the results in the specified order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Return the results in the specified order.</summary>
            public enum OrderByEnum
            {
                [Google.Apis.Util.StringValueAttribute("returnCreationTimeAsc")]
                ReturnCreationTimeAsc,
                [Google.Apis.Util.StringValueAttribute("returnCreationTimeDesc")]
                ReturnCreationTimeDesc,
            }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Obtains order returns that match any shipment state provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment states.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shipmentStates", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ShipmentStatesEnum> ShipmentStates { get; set; }

            /// <summary>Obtains order returns that match any shipment state provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment states.</summary>
            public enum ShipmentStatesEnum
            {
                [Google.Apis.Util.StringValueAttribute("completed")]
                Completed,
                [Google.Apis.Util.StringValueAttribute("new")]
                New__,
                [Google.Apis.Util.StringValueAttribute("shipped")]
                Shipped,
                [Google.Apis.Util.StringValueAttribute("undeliverable")]
                Undeliverable,
            }

            /// <summary>Obtains order returns that match any shipment status provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment statuses.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shipmentStatus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ShipmentStatusEnum> ShipmentStatus { get; set; }

            /// <summary>Obtains order returns that match any shipment status provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment statuses.</summary>
            public enum ShipmentStatusEnum
            {
                [Google.Apis.Util.StringValueAttribute("inProgress")]
                InProgress,
                [Google.Apis.Util.StringValueAttribute("new")]
                New__,
                [Google.Apis.Util.StringValueAttribute("processed")]
                Processed,
            }

            /// <summary>Obtains order returns with the specified tracking numbers. If this parameter is provided,
            /// createdStartDate, createdEndDate, shipmentType, shipmentStatus, shipmentState and acknowledged
            /// parameters must be not set. Note: if googleOrderId and shipmentTrackingNumber parameters are provided,
            /// the obtained results will include all order returns that either match the specified order id or the
            /// specified tracking number.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shipmentTrackingNumbers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> ShipmentTrackingNumbers { get; set; }

            /// <summary>Obtains order returns that match any shipment type provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment types.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shipmentTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ShipmentTypesEnum> ShipmentTypes { get; set; }

            /// <summary>Obtains order returns that match any shipment type provided in this parameter. When this
            /// parameter is not provided, order returns are obtained regardless of their shipment types.</summary>
            public enum ShipmentTypesEnum
            {
                [Google.Apis.Util.StringValueAttribute("byMail")]
                ByMail,
                [Google.Apis.Util.StringValueAttribute("contactCustomerSupport")]
                ContactCustomerSupport,
                [Google.Apis.Util.StringValueAttribute("returnless")]
                Returnless,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreturns";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "acknowledged", new Google.Apis.Discovery.Parameter
                    {
                        Name = "acknowledged",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "createdEndDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "createdEndDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "createdStartDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "createdStartDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "googleOrderIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "googleOrderIds",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "shipmentStates", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shipmentStates",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "shipmentStatus", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shipmentStatus",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "shipmentTrackingNumbers", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shipmentTrackingNumbers",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "shipmentTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shipmentTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Processes return in your Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="returnId">The ID of the return.</param>
        public virtual ProcessRequest Process(Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsProcessRequest body, ulong merchantId, string returnId)
        {
            return new ProcessRequest(service, body, merchantId, returnId);
        }

        /// <summary>Processes return in your Merchant Center account.</summary>
        public class ProcessRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsProcessResponse>
        {
            /// <summary>Constructs a new Process request.</summary>
            public ProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsProcessRequest body, ulong merchantId, string returnId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnId = returnId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrderreturnsProcessRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "process";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orderreturns/{returnId}/process";

            /// <summary>Initializes Process parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "orders" collection of methods.</summary>
    public class OrdersResource
    {
        private const string Resource = "orders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrdersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Marks an order as acknowledged.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual AcknowledgeRequest Acknowledge(Google.Apis.ShoppingContent.v2_1.Data.OrdersAcknowledgeRequest body, ulong merchantId, string orderId)
        {
            return new AcknowledgeRequest(service, body, merchantId, orderId);
        }

        /// <summary>Marks an order as acknowledged.</summary>
        public class AcknowledgeRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersAcknowledgeResponse>
        {
            /// <summary>Constructs a new Acknowledge request.</summary>
            public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersAcknowledgeRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersAcknowledgeRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "acknowledge";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/acknowledge";

            /// <summary>Initializes Acknowledge parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sandbox only. Moves a test order from state "`inProgress`" to state "`pendingShipment`".</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the test order to modify.</param>
        public virtual AdvancetestorderRequest Advancetestorder(ulong merchantId, string orderId)
        {
            return new AdvancetestorderRequest(service, merchantId, orderId);
        }

        /// <summary>Sandbox only. Moves a test order from state "`inProgress`" to state "`pendingShipment`".</summary>
        public class AdvancetestorderRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersAdvanceTestOrderResponse>
        {
            /// <summary>Constructs a new Advancetestorder request.</summary>
            public AdvancetestorderRequest(Google.Apis.Services.IClientService service, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the test order to modify.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "advancetestorder";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/testorders/{orderId}/advance";

            /// <summary>Initializes Advancetestorder parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Cancels all line items in an order, making a full refund.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order to cancel.</param>
        public virtual CancelRequest Cancel(Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelRequest body, ulong merchantId, string orderId)
        {
            return new CancelRequest(service, body, merchantId, orderId);
        }

        /// <summary>Cancels all line items in an order, making a full refund.</summary>
        public class CancelRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelResponse>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order to cancel.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Cancels a line item, making a full refund.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual CancellineitemRequest Cancellineitem(Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelLineItemRequest body, ulong merchantId, string orderId)
        {
            return new CancellineitemRequest(service, body, merchantId, orderId);
        }

        /// <summary>Cancels a line item, making a full refund.</summary>
        public class CancellineitemRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelLineItemResponse>
        {
            /// <summary>Constructs a new Cancellineitem request.</summary>
            public CancellineitemRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelLineItemRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelLineItemRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "cancellineitem";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/cancelLineItem";

            /// <summary>Initializes Cancellineitem parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sandbox only. Cancels a test order for customer-initiated cancellation.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the test order to cancel.</param>
        public virtual CanceltestorderbycustomerRequest Canceltestorderbycustomer(Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelTestOrderByCustomerRequest body, ulong merchantId, string orderId)
        {
            return new CanceltestorderbycustomerRequest(service, body, merchantId, orderId);
        }

        /// <summary>Sandbox only. Cancels a test order for customer-initiated cancellation.</summary>
        public class CanceltestorderbycustomerRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelTestOrderByCustomerResponse>
        {
            /// <summary>Constructs a new Canceltestorderbycustomer request.</summary>
            public CanceltestorderbycustomerRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelTestOrderByCustomerRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the test order to cancel.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersCancelTestOrderByCustomerRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "canceltestorderbycustomer";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/testorders/{orderId}/cancelByCustomer";

            /// <summary>Initializes Canceltestorderbycustomer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sandbox only. Creates a test order.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that should manage the order. This cannot be a multi-client
        /// account.</param>
        public virtual CreatetestorderRequest Createtestorder(Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestOrderRequest body, ulong merchantId)
        {
            return new CreatetestorderRequest(service, body, merchantId);
        }

        /// <summary>Sandbox only. Creates a test order.</summary>
        public class CreatetestorderRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestOrderResponse>
        {
            /// <summary>Constructs a new Createtestorder request.</summary>
            public CreatetestorderRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestOrderRequest body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that should manage the order. This cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestOrderRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "createtestorder";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/testorders";

            /// <summary>Initializes Createtestorder parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sandbox only. Creates a test return.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual CreatetestreturnRequest Createtestreturn(Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestReturnRequest body, ulong merchantId, string orderId)
        {
            return new CreatetestreturnRequest(service, body, merchantId, orderId);
        }

        /// <summary>Sandbox only. Creates a test return.</summary>
        public class CreatetestreturnRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestReturnResponse>
        {
            /// <summary>Constructs a new Createtestreturn request.</summary>
            public CreatetestreturnRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestReturnRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersCreateTestReturnRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "createtestreturn";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/testreturn";

            /// <summary>Initializes Createtestreturn parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves an order from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual GetRequest Get(ulong merchantId, string orderId)
        {
            return new GetRequest(service, merchantId, orderId);
        }

        /// <summary>Retrieves an order from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Order>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves an order using merchant order ID.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="merchantOrderId">The merchant order ID to be looked for.</param>
        public virtual GetbymerchantorderidRequest Getbymerchantorderid(ulong merchantId, string merchantOrderId)
        {
            return new GetbymerchantorderidRequest(service, merchantId, merchantOrderId);
        }

        /// <summary>Retrieves an order using merchant order ID.</summary>
        public class GetbymerchantorderidRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersGetByMerchantOrderIdResponse>
        {
            /// <summary>Constructs a new Getbymerchantorderid request.</summary>
            public GetbymerchantorderidRequest(Google.Apis.Services.IClientService service, ulong merchantId, string merchantOrderId)
                : base(service)
            {
                MerchantId = merchantId;
                MerchantOrderId = merchantOrderId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The merchant order ID to be looked for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantOrderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MerchantOrderId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getbymerchantorderid";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/ordersbymerchantid/{merchantOrderId}";

            /// <summary>Initializes Getbymerchantorderid parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "merchantOrderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantOrderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sandbox only. Retrieves an order template that can be used to quickly create a new order in
        /// sandbox.</summary>
        /// <param name="merchantId">The ID of the account that should manage the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="templateName">The name of the template to retrieve.</param>
        public virtual GettestordertemplateRequest Gettestordertemplate(ulong merchantId, GettestordertemplateRequest.TemplateNameEnum templateName)
        {
            return new GettestordertemplateRequest(service, merchantId, templateName);
        }

        /// <summary>Sandbox only. Retrieves an order template that can be used to quickly create a new order in
        /// sandbox.</summary>
        public class GettestordertemplateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersGetTestOrderTemplateResponse>
        {
            /// <summary>Constructs a new Gettestordertemplate request.</summary>
            public GettestordertemplateRequest(Google.Apis.Services.IClientService service, ulong merchantId, GettestordertemplateRequest.TemplateNameEnum templateName)
                : base(service)
            {
                MerchantId = merchantId;
                TemplateName = templateName;
                InitParameters();
            }


            /// <summary>The ID of the account that should manage the order. This cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The name of the template to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("templateName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual TemplateNameEnum TemplateName { get; private set; }

            /// <summary>The name of the template to retrieve.</summary>
            public enum TemplateNameEnum
            {
                [Google.Apis.Util.StringValueAttribute("template1")]
                Template1,
                [Google.Apis.Util.StringValueAttribute("template1a")]
                Template1a,
                [Google.Apis.Util.StringValueAttribute("template1b")]
                Template1b,
                [Google.Apis.Util.StringValueAttribute("template2")]
                Template2,
                [Google.Apis.Util.StringValueAttribute("template3")]
                Template3,
                [Google.Apis.Util.StringValueAttribute("template4")]
                Template4,
            }

            /// <summary>The country of the template to retrieve. Defaults to `US`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "gettestordertemplate";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/testordertemplates/{templateName}";

            /// <summary>Initializes Gettestordertemplate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "templateName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "templateName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Deprecated. Notifies that item return and refund was handled directly by merchant outside of Google
        /// payments processing (e.g. cash refund done in store). Note: We recommend calling the returnrefundlineitem
        /// method to refund in-store returns. We will issue the refund directly to the customer. This helps to prevent
        /// possible differences arising between merchant and Google transaction records. We also recommend having the
        /// point of sale system communicate with Google to ensure that customers do not receive a double refund by
        /// first refunding via Google then via an in-store return.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual InstorerefundlineitemRequest Instorerefundlineitem(Google.Apis.ShoppingContent.v2_1.Data.OrdersInStoreRefundLineItemRequest body, ulong merchantId, string orderId)
        {
            return new InstorerefundlineitemRequest(service, body, merchantId, orderId);
        }

        /// <summary>Deprecated. Notifies that item return and refund was handled directly by merchant outside of Google
        /// payments processing (e.g. cash refund done in store). Note: We recommend calling the returnrefundlineitem
        /// method to refund in-store returns. We will issue the refund directly to the customer. This helps to prevent
        /// possible differences arising between merchant and Google transaction records. We also recommend having the
        /// point of sale system communicate with Google to ensure that customers do not receive a double refund by
        /// first refunding via Google then via an in-store return.</summary>
        public class InstorerefundlineitemRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersInStoreRefundLineItemResponse>
        {
            /// <summary>Constructs a new Instorerefundlineitem request.</summary>
            public InstorerefundlineitemRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersInStoreRefundLineItemRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersInStoreRefundLineItemRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "instorerefundlineitem";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/inStoreRefundLineItem";

            /// <summary>Initializes Instorerefundlineitem parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the orders in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the orders in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Obtains orders that match the acknowledgement status. When set to true, obtains orders that
            /// have been acknowledged. When false, obtains orders that have not been acknowledged. We recommend using
            /// this filter set to `false`, in conjunction with the `acknowledge` call, such that only un-acknowledged
            /// orders are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("acknowledged", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Acknowledged { get; set; }

            /// <summary>The maximum number of orders to return in the response, used for paging. The default value is
            /// 25 orders per page, and the maximum allowed value is 250 orders per page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Order results by placement date in descending or ascending order.
            ///
            /// Acceptable values are: - placedDateAsc - placedDateDesc</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Obtains orders placed before this date (exclusively), in ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("placedDateEnd", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PlacedDateEnd { get; set; }

            /// <summary>Obtains orders placed after this date (inclusively), in ISO 8601 format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("placedDateStart", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PlacedDateStart { get; set; }

            /// <summary>Obtains orders that match any of the specified statuses. Please note that `active` is a
            /// shortcut for `pendingShipment` and `partiallyShipped`, and `completed` is a shortcut for `shipped`,
            /// `partiallyDelivered`, `delivered`, `partiallyReturned`, `returned`, and `canceled`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("statuses", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusesEnum> Statuses { get; set; }

            /// <summary>Obtains orders that match any of the specified statuses. Please note that `active` is a
            /// shortcut for `pendingShipment` and `partiallyShipped`, and `completed` is a shortcut for `shipped`,
            /// `partiallyDelivered`, `delivered`, `partiallyReturned`, `returned`, and `canceled`.</summary>
            public enum StatusesEnum
            {
                [Google.Apis.Util.StringValueAttribute("active")]
                Active,
                [Google.Apis.Util.StringValueAttribute("canceled")]
                Canceled,
                [Google.Apis.Util.StringValueAttribute("completed")]
                Completed,
                [Google.Apis.Util.StringValueAttribute("delivered")]
                Delivered,
                [Google.Apis.Util.StringValueAttribute("inProgress")]
                InProgress,
                [Google.Apis.Util.StringValueAttribute("partiallyDelivered")]
                PartiallyDelivered,
                [Google.Apis.Util.StringValueAttribute("partiallyReturned")]
                PartiallyReturned,
                [Google.Apis.Util.StringValueAttribute("partiallyShipped")]
                PartiallyShipped,
                [Google.Apis.Util.StringValueAttribute("pendingShipment")]
                PendingShipment,
                [Google.Apis.Util.StringValueAttribute("returned")]
                Returned,
                [Google.Apis.Util.StringValueAttribute("shipped")]
                Shipped,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "acknowledged", new Google.Apis.Discovery.Parameter
                    {
                        Name = "acknowledged",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "placedDateEnd", new Google.Apis.Discovery.Parameter
                    {
                        Name = "placedDateEnd",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "placedDateStart", new Google.Apis.Discovery.Parameter
                    {
                        Name = "placedDateStart",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "statuses", new Google.Apis.Discovery.Parameter
                    {
                        Name = "statuses",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Issues a partial or total refund for items and shipment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order to refund.</param>
        public virtual RefunditemRequest Refunditem(Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundItemRequest body, ulong merchantId, string orderId)
        {
            return new RefunditemRequest(service, body, merchantId, orderId);
        }

        /// <summary>Issues a partial or total refund for items and shipment.</summary>
        public class RefunditemRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundItemResponse>
        {
            /// <summary>Constructs a new Refunditem request.</summary>
            public RefunditemRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundItemRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order to refund.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundItemRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "refunditem";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/refunditem";

            /// <summary>Initializes Refunditem parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Issues a partial or total refund for an order.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order to refund.</param>
        public virtual RefundorderRequest Refundorder(Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundOrderRequest body, ulong merchantId, string orderId)
        {
            return new RefundorderRequest(service, body, merchantId, orderId);
        }

        /// <summary>Issues a partial or total refund for an order.</summary>
        public class RefundorderRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundOrderResponse>
        {
            /// <summary>Constructs a new Refundorder request.</summary>
            public RefundorderRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundOrderRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order to refund.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersRefundOrderRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "refundorder";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/refundorder";

            /// <summary>Initializes Refundorder parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Rejects return on an line item.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual RejectreturnlineitemRequest Rejectreturnlineitem(Google.Apis.ShoppingContent.v2_1.Data.OrdersRejectReturnLineItemRequest body, ulong merchantId, string orderId)
        {
            return new RejectreturnlineitemRequest(service, body, merchantId, orderId);
        }

        /// <summary>Rejects return on an line item.</summary>
        public class RejectreturnlineitemRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersRejectReturnLineItemResponse>
        {
            /// <summary>Constructs a new Rejectreturnlineitem request.</summary>
            public RejectreturnlineitemRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersRejectReturnLineItemRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersRejectReturnLineItemRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "rejectreturnlineitem";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/rejectReturnLineItem";

            /// <summary>Initializes Rejectreturnlineitem parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Returns and refunds a line item. Note that this method can only be called on fully shipped orders.
        /// Please also note that the Orderreturns API is the preferred way to handle returns after you receive a return
        /// from a customer. You can use Orderreturns.list or Orderreturns.get to search for the return, and then use
        /// Orderreturns.processreturn to issue the refund. If the return cannot be found, then we recommend using this
        /// API to issue a refund.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual ReturnrefundlineitemRequest Returnrefundlineitem(Google.Apis.ShoppingContent.v2_1.Data.OrdersReturnRefundLineItemRequest body, ulong merchantId, string orderId)
        {
            return new ReturnrefundlineitemRequest(service, body, merchantId, orderId);
        }

        /// <summary>Returns and refunds a line item. Note that this method can only be called on fully shipped orders.
        /// Please also note that the Orderreturns API is the preferred way to handle returns after you receive a return
        /// from a customer. You can use Orderreturns.list or Orderreturns.get to search for the return, and then use
        /// Orderreturns.processreturn to issue the refund. If the return cannot be found, then we recommend using this
        /// API to issue a refund.</summary>
        public class ReturnrefundlineitemRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersReturnRefundLineItemResponse>
        {
            /// <summary>Constructs a new Returnrefundlineitem request.</summary>
            public ReturnrefundlineitemRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersReturnRefundLineItemRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersReturnRefundLineItemRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "returnrefundlineitem";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/returnRefundLineItem";

            /// <summary>Initializes Returnrefundlineitem parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Sets (or overrides if it already exists) merchant provided annotations in the form of key-value
        /// pairs. A common use case would be to supply us with additional structured information about a line item that
        /// cannot be provided via other methods. Submitted key-value pairs can be retrieved as part of the orders
        /// resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual SetlineitemmetadataRequest Setlineitemmetadata(Google.Apis.ShoppingContent.v2_1.Data.OrdersSetLineItemMetadataRequest body, ulong merchantId, string orderId)
        {
            return new SetlineitemmetadataRequest(service, body, merchantId, orderId);
        }

        /// <summary>Sets (or overrides if it already exists) merchant provided annotations in the form of key-value
        /// pairs. A common use case would be to supply us with additional structured information about a line item that
        /// cannot be provided via other methods. Submitted key-value pairs can be retrieved as part of the orders
        /// resource.</summary>
        public class SetlineitemmetadataRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersSetLineItemMetadataResponse>
        {
            /// <summary>Constructs a new Setlineitemmetadata request.</summary>
            public SetlineitemmetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersSetLineItemMetadataRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersSetLineItemMetadataRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "setlineitemmetadata";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/setLineItemMetadata";

            /// <summary>Initializes Setlineitemmetadata parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Marks line item(s) as shipped.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual ShiplineitemsRequest Shiplineitems(Google.Apis.ShoppingContent.v2_1.Data.OrdersShipLineItemsRequest body, ulong merchantId, string orderId)
        {
            return new ShiplineitemsRequest(service, body, merchantId, orderId);
        }

        /// <summary>Marks line item(s) as shipped.</summary>
        public class ShiplineitemsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersShipLineItemsResponse>
        {
            /// <summary>Constructs a new Shiplineitems request.</summary>
            public ShiplineitemsRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersShipLineItemsRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersShipLineItemsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "shiplineitems";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/shipLineItems";

            /// <summary>Initializes Shiplineitems parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates ship by and delivery by dates for a line item.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual UpdatelineitemshippingdetailsRequest Updatelineitemshippingdetails(Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateLineItemShippingDetailsRequest body, ulong merchantId, string orderId)
        {
            return new UpdatelineitemshippingdetailsRequest(service, body, merchantId, orderId);
        }

        /// <summary>Updates ship by and delivery by dates for a line item.</summary>
        public class UpdatelineitemshippingdetailsRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateLineItemShippingDetailsResponse>
        {
            /// <summary>Constructs a new Updatelineitemshippingdetails request.</summary>
            public UpdatelineitemshippingdetailsRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateLineItemShippingDetailsRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateLineItemShippingDetailsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "updatelineitemshippingdetails";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/updateLineItemShippingDetails";

            /// <summary>Initializes Updatelineitemshippingdetails parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the merchant order ID for a given order.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual UpdatemerchantorderidRequest Updatemerchantorderid(Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateMerchantOrderIdRequest body, ulong merchantId, string orderId)
        {
            return new UpdatemerchantorderidRequest(service, body, merchantId, orderId);
        }

        /// <summary>Updates the merchant order ID for a given order.</summary>
        public class UpdatemerchantorderidRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateMerchantOrderIdResponse>
        {
            /// <summary>Constructs a new Updatemerchantorderid request.</summary>
            public UpdatemerchantorderidRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateMerchantOrderIdRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateMerchantOrderIdRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "updatemerchantorderid";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/updateMerchantOrderId";

            /// <summary>Initializes Updatemerchantorderid parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a shipment's status, carrier, and/or tracking ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that manages the order. This cannot be a multi-client
        /// account.</param>
        /// <param name="orderId">The ID of the order.</param>
        public virtual UpdateshipmentRequest Updateshipment(Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateShipmentRequest body, ulong merchantId, string orderId)
        {
            return new UpdateshipmentRequest(service, body, merchantId, orderId);
        }

        /// <summary>Updates a shipment's status, carrier, and/or tracking ID.</summary>
        public class UpdateshipmentRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateShipmentResponse>
        {
            /// <summary>Constructs a new Updateshipment request.</summary>
            public UpdateshipmentRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateShipmentRequest body, ulong merchantId, string orderId)
                : base(service)
            {
                MerchantId = merchantId;
                OrderId = orderId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that manages the order. This cannot be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.OrdersUpdateShipmentRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "updateshipment";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/orders/{orderId}/updateShipment";

            /// <summary>Initializes Updateshipment parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "pos" collection of methods.</summary>
    public class PosResource
    {
        private const string Resource = "pos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Batches multiple POS-related calls in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.PosCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Batches multiple POS-related calls in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.PosCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.PosCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "pos/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a store for the given merchant.</summary>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        /// <param name="storeCode">A store code that is
        /// unique per merchant.</param>
        public virtual DeleteRequest Delete(ulong merchantId, ulong targetMerchantId, string storeCode)
        {
            return new DeleteRequest(service, merchantId, targetMerchantId, storeCode);
        }

        /// <summary>Deletes a store for the given merchant.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong targetMerchantId, string storeCode)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                StoreCode = storeCode;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }

            /// <summary>A store code that is unique per merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("storeCode", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string StoreCode { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/store/{storeCode}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "storeCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "storeCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves information about the given store.</summary>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        /// <param name="storeCode">A store code that is
        /// unique per merchant.</param>
        public virtual GetRequest Get(ulong merchantId, ulong targetMerchantId, string storeCode)
        {
            return new GetRequest(service, merchantId, targetMerchantId, storeCode);
        }

        /// <summary>Retrieves information about the given store.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosStore>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong targetMerchantId, string storeCode)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                StoreCode = storeCode;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }

            /// <summary>A store code that is unique per merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("storeCode", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string StoreCode { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/store/{storeCode}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "storeCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "storeCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a store for the given merchant.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.PosStore body, ulong merchantId, ulong targetMerchantId)
        {
            return new InsertRequest(service, body, merchantId, targetMerchantId);
        }

        /// <summary>Creates a store for the given merchant.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosStore>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.PosStore body, ulong merchantId, ulong targetMerchantId)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.PosStore Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/store";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Submit inventory for the given merchant.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        public virtual InventoryRequest Inventory(Google.Apis.ShoppingContent.v2_1.Data.PosInventoryRequest body, ulong merchantId, ulong targetMerchantId)
        {
            return new InventoryRequest(service, body, merchantId, targetMerchantId);
        }

        /// <summary>Submit inventory for the given merchant.</summary>
        public class InventoryRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosInventoryResponse>
        {
            /// <summary>Constructs a new Inventory request.</summary>
            public InventoryRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.PosInventoryRequest body, ulong merchantId, ulong targetMerchantId)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.PosInventoryRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "inventory";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/inventory";

            /// <summary>Initializes Inventory parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the stores of the target merchant.</summary>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        public virtual ListRequest List(ulong merchantId, ulong targetMerchantId)
        {
            return new ListRequest(service, merchantId, targetMerchantId);
        }

        /// <summary>Lists the stores of the target merchant.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong targetMerchantId)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/store";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Submit a sale event for the given merchant.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the POS or inventory data provider.</param>
        /// <param
        /// name="targetMerchantId">The ID of the target merchant.</param>
        public virtual SaleRequest Sale(Google.Apis.ShoppingContent.v2_1.Data.PosSaleRequest body, ulong merchantId, ulong targetMerchantId)
        {
            return new SaleRequest(service, body, merchantId, targetMerchantId);
        }

        /// <summary>Submit a sale event for the given merchant.</summary>
        public class SaleRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PosSaleResponse>
        {
            /// <summary>Constructs a new Sale request.</summary>
            public SaleRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.PosSaleRequest body, ulong merchantId, ulong targetMerchantId)
                : base(service)
            {
                MerchantId = merchantId;
                TargetMerchantId = targetMerchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the POS or inventory data provider.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the target merchant.</summary>
            [Google.Apis.Util.RequestParameterAttribute("targetMerchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong TargetMerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.PosSaleRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "sale";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pos/{targetMerchantId}/sale";

            /// <summary>Initializes Sale parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "targetMerchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetMerchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "products" collection of methods.</summary>
    public class ProductsResource
    {
        private const string Resource = "products";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves, inserts, and deletes multiple products in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.ProductsCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves, inserts, and deletes multiple products in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ProductsCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ProductsCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ProductsCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "products/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a product from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        /// <param name="productId">The REST ID of the product.</param>
        public virtual DeleteRequest Delete(ulong merchantId, string productId)
        {
            return new DeleteRequest(service, merchantId, productId);
        }

        /// <summary>Deletes a product from your Merchant Center account.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, string productId)
                : base(service)
            {
                MerchantId = merchantId;
                ProductId = productId;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The REST ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>The Content API Supplemental Feed ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> FeedId { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products/{productId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "feedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a product from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        /// <param name="productId">The REST ID of the product.</param>
        public virtual GetRequest Get(ulong merchantId, string productId)
        {
            return new GetRequest(service, merchantId, productId);
        }

        /// <summary>Retrieves a product from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Product>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string productId)
                : base(service)
            {
                MerchantId = merchantId;
                ProductId = productId;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The REST ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products/{productId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Uploads a product to your Merchant Center account. If an item with the same channel,
        /// contentLanguage, offerId, and targetCountry already exists, this method updates that entry.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.Product body, ulong merchantId)
        {
            return new InsertRequest(service, body, merchantId);
        }

        /// <summary>Uploads a product to your Merchant Center account. If an item with the same channel,
        /// contentLanguage, offerId, and targetCountry already exists, this method updates that entry.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.Product>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.Product body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The Content API Supplemental Feed ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ulong> FeedId { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.Product Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "feedId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the products in your Merchant Center account. The response might contain fewer items than
        /// specified by maxResults. Rely on nextPageToken to determine if there are more items to be
        /// requested.</summary>
        /// <param name="merchantId">The ID of the account that contains the products. This account cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the products in your Merchant Center account. The response might contain fewer items than
        /// specified by maxResults. Rely on nextPageToken to determine if there are more items to be
        /// requested.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ProductsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the products. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of products to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "productstatuses" collection of methods.</summary>
    public class ProductstatusesResource
    {
        private const string Resource = "productstatuses";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductstatusesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets the statuses of multiple products in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.ProductstatusesCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Gets the statuses of multiple products in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ProductstatusesCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ProductstatusesCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ProductstatusesCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "productstatuses/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Gets the status of a product from your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        /// <param name="productId">The REST ID of the product.</param>
        public virtual GetRequest Get(ulong merchantId, string productId)
        {
            return new GetRequest(service, merchantId, productId);
        }

        /// <summary>Gets the status of a product from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ProductStatus>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string productId)
                : base(service)
            {
                MerchantId = merchantId;
                ProductId = productId;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The REST ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
            /// Shopping destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinations", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Destinations { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/productstatuses/{productId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "destinations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "destinations",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the statuses of the products in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the account that contains the products. This account cannot be a multi-client
        /// account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the statuses of the products in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ProductstatusesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the products. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
            /// Shopping destination.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinations", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Destinations { get; set; }

            /// <summary>The maximum number of product statuses to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/productstatuses";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "destinations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "destinations",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "pubsubnotificationsettings" collection of methods.</summary>
    public class PubsubnotificationsettingsResource
    {
        private const string Resource = "pubsubnotificationsettings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PubsubnotificationsettingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a Merchant Center account's pubsub notification settings.</summary>
        /// <param name="merchantId">The ID of the account for which to get pubsub notification settings.</param>
        public virtual GetRequest Get(ulong merchantId)
        {
            return new GetRequest(service, merchantId);
        }

        /// <summary>Retrieves a Merchant Center account's pubsub notification settings.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PubsubNotificationSettings>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account for which to get pubsub notification settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pubsubnotificationsettings";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Register a Merchant Center account for pubsub notifications. Note that cloud topic name should not
        /// be provided as part of the request.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.PubsubNotificationSettings body, ulong merchantId)
        {
            return new UpdateRequest(service, body, merchantId);
        }

        /// <summary>Register a Merchant Center account for pubsub notifications. Note that cloud topic name should not
        /// be provided as part of the request.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.PubsubNotificationSettings>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.PubsubNotificationSettings body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.PubsubNotificationSettings Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/pubsubnotificationsettings";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "regionalinventory" collection of methods.</summary>
    public class RegionalinventoryResource
    {
        private const string Resource = "regionalinventory";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RegionalinventoryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Updates regional inventory for multiple products or regions in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.RegionalinventoryCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Updates regional inventory for multiple products or regions in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.RegionalinventoryCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.RegionalinventoryCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.RegionalinventoryCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "regionalinventory/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Update the regional inventory of a product in your Merchant Center account. If a regional inventory
        /// with the same region ID already exists, this method updates that entry.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the account that contains the product. This account cannot be a multi-client
        /// account.</param>
        /// <param name="productId">The REST ID of the product for which to update the regional
        /// inventory.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.RegionalInventory body, ulong merchantId, string productId)
        {
            return new InsertRequest(service, body, merchantId, productId);
        }

        /// <summary>Update the regional inventory of a product in your Merchant Center account. If a regional inventory
        /// with the same region ID already exists, this method updates that entry.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.RegionalInventory>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.RegionalInventory body, ulong merchantId, string productId)
                : base(service)
            {
                MerchantId = merchantId;
                ProductId = productId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the account that contains the product. This account cannot be a multi-client
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The REST ID of the product for which to update the regional inventory.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.RegionalInventory Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/products/{productId}/regionalinventory";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "returnaddress" collection of methods.</summary>
    public class ReturnaddressResource
    {
        private const string Resource = "returnaddress";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReturnaddressResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Batches multiple return address related calls in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.ReturnaddressCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Batches multiple return address related calls in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnaddressCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ReturnaddressCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ReturnaddressCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "returnaddress/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a return address for the given Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account from which to delete the given return address.</param>
        ///
        /// <param name="returnAddressId">Return address ID generated by Google.</param>
        public virtual DeleteRequest Delete(ulong merchantId, string returnAddressId)
        {
            return new DeleteRequest(service, merchantId, returnAddressId);
        }

        /// <summary>Deletes a return address for the given Merchant Center account.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, string returnAddressId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnAddressId = returnAddressId;
                InitParameters();
            }


            /// <summary>The Merchant Center account from which to delete the given return address.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Return address ID generated by Google.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnAddressId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnAddressId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnaddress/{returnAddressId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnAddressId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnAddressId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Gets a return address of the Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account to get a return address for.</param>
        /// <param
        /// name="returnAddressId">Return address ID generated by Google.</param>
        public virtual GetRequest Get(ulong merchantId, string returnAddressId)
        {
            return new GetRequest(service, merchantId, returnAddressId);
        }

        /// <summary>Gets a return address of the Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnAddress>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string returnAddressId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnAddressId = returnAddressId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to get a return address for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Return address ID generated by Google.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnAddressId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnAddressId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnaddress/{returnAddressId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnAddressId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnAddressId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts a return address for the Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The Merchant Center account to insert a return address for.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.ReturnAddress body, ulong merchantId)
        {
            return new InsertRequest(service, body, merchantId);
        }

        /// <summary>Inserts a return address for the Merchant Center account.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnAddress>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ReturnAddress body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The Merchant Center account to insert a return address for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ReturnAddress Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnaddress";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the return addresses of the Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account to list return addresses for.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the return addresses of the Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnaddressListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to list return addresses for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>List only return addresses applicable to the given country of sale. When omitted, all return
            /// addresses are listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; set; }

            /// <summary>The maximum number of addresses in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnaddress";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "returnpolicy" collection of methods.</summary>
    public class ReturnpolicyResource
    {
        private const string Resource = "returnpolicy";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReturnpolicyResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Batches multiple return policy related calls in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.ReturnpolicyCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Batches multiple return policy related calls in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnpolicyCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ReturnpolicyCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ReturnpolicyCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "returnpolicy/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a return policy for the given Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account from which to delete the given return policy.</param>
        ///
        /// <param name="returnPolicyId">Return policy ID generated by Google.</param>
        public virtual DeleteRequest Delete(ulong merchantId, string returnPolicyId)
        {
            return new DeleteRequest(service, merchantId, returnPolicyId);
        }

        /// <summary>Deletes a return policy for the given Merchant Center account.</summary>
        public class DeleteRequest : ShoppingContentBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, ulong merchantId, string returnPolicyId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnPolicyId = returnPolicyId;
                InitParameters();
            }


            /// <summary>The Merchant Center account from which to delete the given return policy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Return policy ID generated by Google.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPolicyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnPolicyId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnpolicy/{returnPolicyId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnPolicyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnPolicyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Gets a return policy of the Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account to get a return policy for.</param>
        /// <param
        /// name="returnPolicyId">Return policy ID generated by Google.</param>
        public virtual GetRequest Get(ulong merchantId, string returnPolicyId)
        {
            return new GetRequest(service, merchantId, returnPolicyId);
        }

        /// <summary>Gets a return policy of the Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnPolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string returnPolicyId)
                : base(service)
            {
                MerchantId = merchantId;
                ReturnPolicyId = returnPolicyId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to get a return policy for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>Return policy ID generated by Google.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnPolicyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReturnPolicyId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnpolicy/{returnPolicyId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "returnPolicyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "returnPolicyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts a return policy for the Merchant Center account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The Merchant Center account to insert a return policy for.</param>
        public virtual InsertRequest Insert(Google.Apis.ShoppingContent.v2_1.Data.ReturnPolicy body, ulong merchantId)
        {
            return new InsertRequest(service, body, merchantId);
        }

        /// <summary>Inserts a return policy for the Merchant Center account.</summary>
        public class InsertRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnPolicy>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ReturnPolicy body, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                Body = body;
                InitParameters();
            }


            /// <summary>The Merchant Center account to insert a return policy for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ReturnPolicy Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnpolicy";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the return policies of the Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account to list return policies for.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the return policies of the Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ReturnpolicyListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to list return policies for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/returnpolicy";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "settlementreports" collection of methods.</summary>
    public class SettlementreportsResource
    {
        private const string Resource = "settlementreports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SettlementreportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a settlement report from your Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account of the settlement report.</param>
        /// <param
        /// name="settlementId">The Google-provided ID of the settlement.</param>
        public virtual GetRequest Get(ulong merchantId, string settlementId)
        {
            return new GetRequest(service, merchantId, settlementId);
        }

        /// <summary>Retrieves a settlement report from your Merchant Center account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.SettlementReport>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, string settlementId)
                : base(service)
            {
                MerchantId = merchantId;
                SettlementId = settlementId;
                InitParameters();
            }


            /// <summary>The Merchant Center account of the settlement report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The Google-provided ID of the settlement.</summary>
            [Google.Apis.Util.RequestParameterAttribute("settlementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SettlementId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/settlementreports/{settlementId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "settlementId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "settlementId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a list of settlement reports from your Merchant Center account.</summary>
        /// <param name="merchantId">The Merchant Center account to list settlements for.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Retrieves a list of settlement reports from your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.SettlementreportsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to list settlements for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of settlements to return in the response, used for paging. The default value
            /// is 200 returns per page, and the maximum allowed value is 5000 returns per page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Obtains settlements which have transactions before this date (inclusively), in ISO 8601
            /// format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("transferEndDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TransferEndDate { get; set; }

            /// <summary>Obtains settlements which have transactions after this date (inclusively), in ISO 8601
            /// format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("transferStartDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TransferStartDate { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/settlementreports";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "transferEndDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "transferEndDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "transferStartDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "transferStartDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "settlementtransactions" collection of methods.</summary>
    public class SettlementtransactionsResource
    {
        private const string Resource = "settlementtransactions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SettlementtransactionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a list of transactions for the settlement.</summary>
        /// <param name="merchantId">The Merchant Center account to list transactions for.</param>
        /// <param
        /// name="settlementId">The Google-provided ID of the settlement.</param>
        public virtual ListRequest List(ulong merchantId, string settlementId)
        {
            return new ListRequest(service, merchantId, settlementId);
        }

        /// <summary>Retrieves a list of transactions for the settlement.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.SettlementtransactionsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId, string settlementId)
                : base(service)
            {
                MerchantId = merchantId;
                SettlementId = settlementId;
                InitParameters();
            }


            /// <summary>The Merchant Center account to list transactions for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The Google-provided ID of the settlement.</summary>
            [Google.Apis.Util.RequestParameterAttribute("settlementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SettlementId { get; private set; }

            /// <summary>The maximum number of transactions to return in the response, used for paging. The default
            /// value is 200 transactions per page, and the maximum allowed value is 5000 transactions per
            /// page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The list of transactions to return. If not set, all transactions will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("transactionIds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> TransactionIds { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/settlementreports/{settlementId}/transactions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "settlementId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "settlementId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "transactionIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "transactionIds",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "shippingsettings" collection of methods.</summary>
    public class ShippingsettingsResource
    {
        private const string Resource = "shippingsettings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ShippingsettingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves and updates the shipping settings of multiple accounts in a single request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CustombatchRequest Custombatch(Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsCustomBatchRequest body)
        {
            return new CustombatchRequest(service, body);
        }

        /// <summary>Retrieves and updates the shipping settings of multiple accounts in a single request.</summary>
        public class CustombatchRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsCustomBatchResponse>
        {
            /// <summary>Constructs a new Custombatch request.</summary>
            public CustombatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsCustomBatchRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsCustomBatchRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "custombatch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "shippingsettings/batch";

            /// <summary>Initializes Custombatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves the shipping settings of the account.</summary>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get/update shipping
        /// settings.</param>
        public virtual GetRequest Get(ulong merchantId, ulong accountId)
        {
            return new GetRequest(service, merchantId, accountId);
        }

        /// <summary>Retrieves the shipping settings of the account.</summary>
        public class GetRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingSettings>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get/update shipping settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/shippingsettings/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves supported carriers and carrier services for an account.</summary>
        /// <param name="merchantId">The ID of the account for which to retrieve the supported carriers.</param>
        public virtual GetsupportedcarriersRequest Getsupportedcarriers(ulong merchantId)
        {
            return new GetsupportedcarriersRequest(service, merchantId);
        }

        /// <summary>Retrieves supported carriers and carrier services for an account.</summary>
        public class GetsupportedcarriersRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsGetSupportedCarriersResponse>
        {
            /// <summary>Constructs a new Getsupportedcarriers request.</summary>
            public GetsupportedcarriersRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account for which to retrieve the supported carriers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getsupportedcarriers";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/supportedCarriers";

            /// <summary>Initializes Getsupportedcarriers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves supported holidays for an account.</summary>
        /// <param name="merchantId">The ID of the account for which to retrieve the supported holidays.</param>
        public virtual GetsupportedholidaysRequest Getsupportedholidays(ulong merchantId)
        {
            return new GetsupportedholidaysRequest(service, merchantId);
        }

        /// <summary>Retrieves supported holidays for an account.</summary>
        public class GetsupportedholidaysRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsGetSupportedHolidaysResponse>
        {
            /// <summary>Constructs a new Getsupportedholidays request.</summary>
            public GetsupportedholidaysRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account for which to retrieve the supported holidays.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getsupportedholidays";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/supportedHolidays";

            /// <summary>Initializes Getsupportedholidays parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves supported pickup services for an account.</summary>
        /// <param name="merchantId">The ID of the account for which to retrieve the supported pickup services.</param>
        public virtual GetsupportedpickupservicesRequest Getsupportedpickupservices(ulong merchantId)
        {
            return new GetsupportedpickupservicesRequest(service, merchantId);
        }

        /// <summary>Retrieves supported pickup services for an account.</summary>
        public class GetsupportedpickupservicesRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsGetSupportedPickupServicesResponse>
        {
            /// <summary>Constructs a new Getsupportedpickupservices request.</summary>
            public GetsupportedpickupservicesRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the account for which to retrieve the supported pickup services.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getsupportedpickupservices";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/supportedPickupServices";

            /// <summary>Initializes Getsupportedpickupservices parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the shipping settings of the sub-accounts in your Merchant Center account.</summary>
        /// <param name="merchantId">The ID of the managing account. This must be a multi-client account.</param>
        public virtual ListRequest List(ulong merchantId)
        {
            return new ListRequest(service, merchantId);
        }

        /// <summary>Lists the shipping settings of the sub-accounts in your Merchant Center account.</summary>
        public class ListRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingsettingsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ulong merchantId)
                : base(service)
            {
                MerchantId = merchantId;
                InitParameters();
            }


            /// <summary>The ID of the managing account. This must be a multi-client account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The maximum number of shipping settings to return in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/shippingsettings";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the shipping settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="merchantId">The ID of the managing account. If this parameter is not the same as accountId, then this
        /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
        /// account.</param>
        /// <param name="accountId">The ID of the account for which to get/update shipping
        /// settings.</param>
        public virtual UpdateRequest Update(Google.Apis.ShoppingContent.v2_1.Data.ShippingSettings body, ulong merchantId, ulong accountId)
        {
            return new UpdateRequest(service, body, merchantId, accountId);
        }

        /// <summary>Updates the shipping settings of the account. Any fields that are not provided are deleted from the
        /// resource.</summary>
        public class UpdateRequest : ShoppingContentBaseServiceRequest<Google.Apis.ShoppingContent.v2_1.Data.ShippingSettings>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ShoppingContent.v2_1.Data.ShippingSettings body, ulong merchantId, ulong accountId)
                : base(service)
            {
                MerchantId = merchantId;
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The ID of the managing account. If this parameter is not the same as accountId, then this
            /// account must be a multi-client account and `accountId` must be the ID of a sub-account of this
            /// account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("merchantId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong MerchantId { get; private set; }

            /// <summary>The ID of the account for which to get/update shipping settings.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ulong AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ShoppingContent.v2_1.Data.ShippingSettings Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "{merchantId}/shippingsettings/{accountId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "merchantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "merchantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.ShoppingContent.v2_1.Data
{    

    /// <summary>Account data. After the creation of a new account it may take a few minutes before it is fully
    /// operational. The methods delete, insert, and update require the admin role.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of linked Ads accounts that are active or pending approval. To create a new link request, add
        /// a new link with status `active` to the list. It will remain in a `pending` state until approved or rejected
        /// either in the Ads interface or through the AdWords API. To delete an active link, or to cancel a link
        /// request, remove it from the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsLinks")]
        public virtual System.Collections.Generic.IList<AccountAdsLink> AdsLinks { get; set; } 

        /// <summary>Indicates whether the merchant sells adult content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adultContent")]
        public virtual System.Nullable<bool> AdultContent { get; set; } 

        /// <summary>The business information of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessInformation")]
        public virtual AccountBusinessInformation BusinessInformation { get; set; } 

        /// <summary>ID of CSS the account belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cssId")]
        public virtual System.Nullable<ulong> CssId { get; set; } 

        /// <summary>The GMB account which is linked or in the process of being linked with the Merchant Center
        /// account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMyBusinessLink")]
        public virtual AccountGoogleMyBusinessLink GoogleMyBusinessLink { get; set; } 

        /// <summary>Required for update. Merchant Center account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#account`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of label IDs that are assigned to the account by CSS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<ulong>> LabelIds { get; set; } 

        /// <summary>Required. Display name for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Client-specific, locally-unique, internal ID for the child account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerId")]
        public virtual string SellerId { get; set; } 

        /// <summary>Users with access to the account. Every account (except for subaccounts) must have at least one
        /// admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<AccountUser> Users { get; set; } 

        /// <summary>The merchant's website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; } 

        /// <summary>List of linked YouTube channels that are active or pending approval. To create a new link request,
        /// add a new link with status `active` to the list. It will remain in a `pending` state until approved or
        /// rejected in the YT Creator Studio interface. To delete an active link, or to cancel a link request, remove
        /// it from the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeChannelLinks")]
        public virtual System.Collections.Generic.IList<AccountYouTubeChannelLink> YoutubeChannelLinks { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CLDR country code (e.g. "US"). This value cannot be set for a sub-account of an MCA. All MCA sub-
        /// accounts inherit the country of their parent MCA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods
        /// or suburbs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Postal code or ZIP (e.g. "94043").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Top-level administrative subdivision of the country. For example, a state like California ("CA") or
        /// a province like Quebec ("QC").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Street-level part of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountAdsLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer ID of the Ads account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsId")]
        public virtual System.Nullable<ulong> AdsId { get; set; } 

        /// <summary>Status of the link between this Merchant Center account and the Ads account. Upon retrieval, it
        /// represents the actual status of the link and can be either `active` if it was approved in Google Ads or
        /// `pending` if it's pending approval. Upon insertion, it represents the intended status of the link. Re-
        /// uploading a link with status `active` when it's still pending or with status `pending` when it's already
        /// active will have no effect: the status will remain unchanged. Re-uploading a link with deprecated status
        /// `inactive` is equivalent to not submitting the link at all and will delete the link if it was active or
        /// cancel the link request if it was pending.
        ///
        /// Acceptable values are: - "`active`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountBusinessInformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual AccountAddress Address { get; set; } 

        /// <summary>The customer service information of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerService")]
        public virtual AccountCustomerService CustomerService { get; set; } 

        /// <summary>The phone number of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountCustomerService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer service email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>Customer service phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>Customer service URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountGoogleMyBusinessLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the GMB account. If this is provided, then `gmbEmail` is ignored. The value of this field
        /// should match the `accountId` used by the GMB API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbAccountId")]
        public virtual string GmbAccountId { get; set; } 

        /// <summary>The GMB email address of which a specific account within a GMB account. A sample account within a
        /// GMB account could be a business account with set of locations, managed under the GMB account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbEmail")]
        public virtual string GmbEmail { get; set; } 

        /// <summary>Status of the link between this Merchant Center account and the GMB account.
        ///
        /// Acceptable values are: - "`active`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aggregator ID, set for aggregators and subaccounts (in that case, it represents the aggregator
        /// of the subaccount).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatorId")]
        public virtual System.Nullable<ulong> AggregatorId { get; set; } 

        /// <summary>The merchant account ID, set for individual accounts and subaccounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The status of an account, i.e., information about its products, which is computed offline and not
    /// returned immediately at insertion time.</summary>
    public class AccountStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account for which the status is reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>A list of account level issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountLevelIssues")]
        public virtual System.Collections.Generic.IList<AccountStatusAccountLevelIssue> AccountLevelIssues { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#accountStatus`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of product-related data by channel, destination, and country. Data in this field may be
        /// delayed by up to 30 minutes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<AccountStatusProducts> Products { get; set; } 

        /// <summary>Whether the account's website is claimed or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteClaimed")]
        public virtual System.Nullable<bool> WebsiteClaimed { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountStatusAccountLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Country for which this issue is reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The destination the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; } 

        /// <summary>Additional details about the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; } 

        /// <summary>The URL of a web page to help resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; } 

        /// <summary>Issue identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Severity of the issue.
        ///
        /// Acceptable values are: - "`critical`" - "`error`" - "`suggestion`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; } 

        /// <summary>Short description of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountStatusItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeName")]
        public virtual string AttributeName { get; set; } 

        /// <summary>The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; } 

        /// <summary>A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; } 

        /// <summary>The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; } 

        /// <summary>Number of items with this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numItems")]
        public virtual System.Nullable<long> NumItems { get; set; } 

        /// <summary>Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; } 

        /// <summary>How this issue affects serving of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servability")]
        public virtual string Servability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountStatusProducts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The channel the data applies to.
        ///
        /// Acceptable values are: - "`local`" - "`online`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; } 

        /// <summary>The country the data applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The destination the data applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; } 

        /// <summary>List of item-level issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<AccountStatusItemLevelIssue> ItemLevelIssues { get; set; } 

        /// <summary>Aggregated product statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual AccountStatusStatistics Statistics { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountStatusStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of active offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<long> Active { get; set; } 

        /// <summary>Number of disapproved offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapproved")]
        public virtual System.Nullable<long> Disapproved { get; set; } 

        /// <summary>Number of expiring offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiring")]
        public virtual System.Nullable<long> Expiring { get; set; } 

        /// <summary>Number of pending offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pending")]
        public virtual System.Nullable<long> Pending { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The tax settings of a merchant account. All methods require the admin role.</summary>
    public class AccountTax : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the account to which these account tax settings belong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "content#accountTax".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Tax rules. Updating the tax rules will enable US taxes (not reversible). Defining no rules is
        /// equivalent to not charging tax at all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<AccountTaxTaxRule> Rules { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Tax calculation rule to apply in a state or province (USA only).</summary>
    public class AccountTaxTaxRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Country code in which tax is applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Required. State (or province) is which the tax is applicable, described by its location ID (also
        /// called criteria ID).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual System.Nullable<ulong> LocationId { get; set; } 

        /// <summary>Explicit tax rate in percent, represented as a floating point number without the percentage
        /// character. Must not be negative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratePercent")]
        public virtual string RatePercent { get; set; } 

        /// <summary>If true, shipping charges are also taxed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingTaxed")]
        public virtual System.Nullable<bool> ShippingTaxed { get; set; } 

        /// <summary>Whether the tax rate is taken from a global tax table or specified explicitly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useGlobalRate")]
        public virtual System.Nullable<bool> UseGlobalRate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether user is an admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admin")]
        public virtual System.Nullable<bool> Admin { get; set; } 

        /// <summary>User's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; } 

        /// <summary>Whether user is an order manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderManager")]
        public virtual System.Nullable<bool> OrderManager { get; set; } 

        /// <summary>Whether user can access payment statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentsAnalyst")]
        public virtual System.Nullable<bool> PaymentsAnalyst { get; set; } 

        /// <summary>Whether user can manage payment settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentsManager")]
        public virtual System.Nullable<bool> PaymentsManager { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountYouTubeChannelLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Channel ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; } 

        /// <summary>Status of the link between this Merchant Center account and the YouTube channel. Upon retrieval, it
        /// represents the actual status of the link and can be either `active` if it was approved in YT Creator Studio
        /// or `pending` if it's pending approval. Upon insertion, it represents the intended status of the link. Re-
        /// uploading a link with status `active` when it's still pending or with status `pending` when it's already
        /// active will have no effect: the status will remain unchanged. Re-uploading a link with deprecated status
        /// `inactive` is equivalent to not submitting the link at all and will delete the link if it was active or
        /// cancel the link request if it was pending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsAuthInfoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account identifiers corresponding to the authenticated user. - For an individual account: only
        /// the merchant ID is defined - For an aggregator: only the aggregator ID is defined - For a subaccount of an
        /// MCA: both the merchant ID and the aggregator ID are defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIdentifiers")]
        public virtual System.Collections.Generic.IList<AccountIdentifier> AccountIdentifiers { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsAuthInfoResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsClaimWebsiteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsClaimWebsiteResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccountsCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accounts request.</summary>
    public class AccountsCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account to create or update. Only defined if the method is `insert` or `update`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; } 

        /// <summary>The ID of the targeted account. Only defined if the method is not `insert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>Whether the account should be deleted if the account has offers. Only applicable if the method is
        /// `delete`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; } 

        /// <summary>Label IDs for the 'updatelabels' request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<ulong>> LabelIds { get; set; } 

        /// <summary>Details about the `link` request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkRequest")]
        public virtual AccountsCustomBatchRequestEntryLinkRequest LinkRequest { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`claimWebsite`" - "`delete`" - "`get`" - "`insert`" - "`link`" -
        /// "`update`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>Only applicable if the method is `claimwebsite`. Indicates whether or not to take the claim from
        /// another account in case there is a conflict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwrite")]
        public virtual System.Nullable<bool> Overwrite { get; set; } 

        /// <summary>Controls which fields are visible. Only applicable if the method is 'get'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsCustomBatchRequestEntryLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action to perform for this link. The `"request"` action is only available to select merchants.
        ///
        /// Acceptable values are: - "`approve`" - "`remove`" - "`request`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>Type of the link between the two accounts.
        ///
        /// Acceptable values are: - "`channelPartner`" - "`eCommercePlatform`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkType")]
        public virtual string LinkType { get; set; } 

        /// <summary>The ID of the linked account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccountId")]
        public virtual string LinkedAccountId { get; set; } 

        /// <summary>List of provided services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccountsCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accounts response.</summary>
    public class AccountsCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The retrieved, created, or updated account. Not defined if the method was `delete`, `claimwebsite`
        /// or `link`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; } 

        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#accountsCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action to perform for this link. The `"request"` action is only available to select merchants.
        ///
        /// Acceptable values are: - "`approve`" - "`remove`" - "`request`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>Type of the link between the two accounts.
        ///
        /// Acceptable values are: - "`channelPartner`" - "`eCommercePlatform`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkType")]
        public virtual string LinkType { get; set; } 

        /// <summary>The ID of the linked account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccountId")]
        public virtual string LinkedAccountId { get; set; } 

        /// <summary>List of provided services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsLinkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsLinkResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsListLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsListLinksResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The list of available links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<LinkedAccount> Links { get; set; } 

        /// <summary>The token for the retrieval of the next page of links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Account> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsUpdateLabelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs of labels that should be assigned to the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<ulong>> LabelIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountsUpdateLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountsUpdateLabelsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountstatusesCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccountstatusesCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accountstatuses request.</summary>
    public class AccountstatusesCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the (sub-)account whose status to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
        /// Shopping destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<string> Destinations { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountstatusesCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccountstatusesCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountstatusesCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accountstatuses response.</summary>
    public class AccountstatusesCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested account status. Defined if and only if the request was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountStatus")]
        public virtual AccountStatus AccountStatus { get; set; } 

        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccountstatusesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accountstatusesListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of account statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<AccountStatus> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccounttaxCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccounttaxCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accounttax request.</summary>
    public class AccounttaxCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account for which to get/update account tax settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>The account tax settings to update. Only defined if the method is `update`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTax")]
        public virtual AccountTax AccountTax { get; set; } 

        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`" - "`update`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccounttaxCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<AccounttaxCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accounttaxCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch accounttax response.</summary>
    public class AccounttaxCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The retrieved or updated account tax settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTax")]
        public virtual AccountTax AccountTax { get; set; } 

        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#accounttaxCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AccounttaxListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#accounttaxListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of account tax settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<AccountTax> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Amount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] The pre-tax or post-tax price depending on the location of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>[required] Tax value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BusinessDayConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Regular business days. May not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessDays")]
        public virtual System.Collections.Generic.IList<string> BusinessDays { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CarrierRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Carrier service, such as `"UPS"` or `"Fedex"`. The list of supported carriers can be retrieved via
        /// the `getSupportedCarriers` method. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierName")]
        public virtual string CarrierName { get; set; } 

        /// <summary>Carrier service, such as `"ground"` or `"2 days"`. The list of supported services for a carrier can
        /// be retrieved via the `getSupportedCarriers` method. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierService")]
        public virtual string CarrierService { get; set; } 

        /// <summary>Additive shipping rate modifier. Can be negative. For example `{ "value": "1", "currency" : "USD"
        /// }` adds $1 to the rate, `{ "value": "-3", "currency" : "USD" }` removes $3 from the rate.
        /// Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatAdjustment")]
        public virtual Price FlatAdjustment { get; set; } 

        /// <summary>Name of the carrier rate. Must be unique per rate group. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Shipping origin for this carrier rate. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originPostalCode")]
        public virtual string OriginPostalCode { get; set; } 

        /// <summary>Multiplicative shipping rate modifier as a number in decimal notation. Can be negative. For example
        /// `"5.4"` increases the rate by 5.4%, `"-3"` decreases the rate by 3%. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentageAdjustment")]
        public virtual string PercentageAdjustment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CarriersCarrier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CLDR country code of the carrier (e.g., "US"). Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The name of the carrier (e.g., `"UPS"`). Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>A list of supported services (e.g., `"ground"`) for that carrier. Contains at least one
        /// service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subattributes within this attribute group. Exactly one of value or groupValues must be
        /// provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupValues")]
        public virtual System.Collections.Generic.IList<CustomAttribute> GroupValues { get; set; } 

        /// <summary>The name of the attribute. Underscores will be replaced by spaces upon insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The value of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CustomerReturnReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Code of the return reason.
        ///
        /// Acceptable values are: - "`betterPriceFound`" - "`changedMind`" - "`damagedOrDefectiveItem`" -
        /// "`didNotMatchDescription`" - "`doesNotFit`" - "`expiredItem`" - "`incorrectItemReceived`" -
        /// "`noLongerNeeded`" - "`notSpecified`" - "`orderedWrongItem`" - "`other`" - "`qualityNotExpected`" -
        /// "`receivedTooLate`" - "`undeliverable`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonCode")]
        public virtual string ReasonCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CutoffTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hour of the cutoff time until which an order has to be placed to be processed in the same day.
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<long> Hour { get; set; } 

        /// <summary>Minute of the cutoff time until which an order has to be placed to be processed in the same day.
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<long> Minute { get; set; } 

        /// <summary>Timezone identifier for the cutoff time. A list of identifiers can be found in  the AdWords API
        /// documentation. E.g. "Europe/Zurich". Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Datafeed configuration data.</summary>
    public class Datafeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The two-letter ISO 639-1 language in which the attributes are defined in the data feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeLanguage")]
        public virtual string AttributeLanguage { get; set; } 

        /// <summary>Required. The type of data feed. For product inventory feeds, only feeds for local stores, not
        /// online stores, are supported.
        ///
        /// Acceptable values are: - "`local products`" - "`product inventory`" - "`products`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; } 

        /// <summary>Fetch schedule for the feed file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchSchedule")]
        public virtual DatafeedFetchSchedule FetchSchedule { get; set; } 

        /// <summary>Required. The filename of the feed. All feeds must have a unique file name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; } 

        /// <summary>Format of the feed file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual DatafeedFormat Format { get; set; } 

        /// <summary>Required for update. The ID of the data feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#datafeed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required for insert. A descriptive name of the data feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The targets this feed should apply to (country, language, destinations).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<DatafeedTarget> Targets { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The required fields vary based on the frequency of fetching. For a monthly fetch schedule, day_of_month
    /// and hour are required. For a weekly fetch schedule, weekday and hour are required. For a daily fetch schedule,
    /// only hour is required.</summary>
    public class DatafeedFetchSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The day of the month the feed file should be fetched (1-31).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfMonth")]
        public virtual System.Nullable<long> DayOfMonth { get; set; } 

        /// <summary>The URL where the feed file can be fetched. Google Merchant Center will support automatic scheduled
        /// uploads using the HTTP, HTTPS, FTP, or SFTP protocols, so the value will need to be a valid link using one
        /// of those four protocols.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchUrl")]
        public virtual string FetchUrl { get; set; } 

        /// <summary>The hour of the day the feed file should be fetched (0-23).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<long> Hour { get; set; } 

        /// <summary>The minute of the hour the feed file should be fetched (0-59). Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minuteOfHour")]
        public virtual System.Nullable<long> MinuteOfHour { get; set; } 

        /// <summary>An optional password for fetch_url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; } 

        /// <summary>Whether the scheduled fetch is paused or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paused")]
        public virtual System.Nullable<bool> Paused { get; set; } 

        /// <summary>Time zone used for schedule. UTC by default. E.g., "America/Los_Angeles".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>An optional user name for fetch_url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; } 

        /// <summary>The day of the week the feed file should be fetched.
        ///
        /// Acceptable values are: - "`monday`" - "`tuesday`" - "`wednesday`" - "`thursday`" - "`friday`" - "`saturday`"
        /// - "`sunday`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekday")]
        public virtual string Weekday { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delimiter for the separation of values in a delimiter-separated values feed. If not specified, the
        /// delimiter will be auto-detected. Ignored for non-DSV data feeds.
        ///
        /// Acceptable values are: - "`pipe`" - "`tab`" - "`tilde`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnDelimiter")]
        public virtual string ColumnDelimiter { get; set; } 

        /// <summary>Character encoding scheme of the data feed. If not specified, the encoding will be auto-detected.
        ///
        /// Acceptable values are: - "`latin-1`" - "`utf-16be`" - "`utf-16le`" - "`utf-8`" - "`windows-1252`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileEncoding")]
        public virtual string FileEncoding { get; set; } 

        /// <summary>Specifies how double quotes are interpreted. If not specified, the mode will be auto-detected.
        /// Ignored for non-DSV data feeds.
        ///
        /// Acceptable values are: - "`normal character`" - "`value quoting`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotingMode")]
        public virtual string QuotingMode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The status of a datafeed, i.e., the result of the last retrieval of the datafeed computed
    /// asynchronously when the feed processing is finished.</summary>
    public class DatafeedStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country for which the status is reported, represented as a  CLDR territory code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The ID of the feed for which the status is reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeedId")]
        public virtual System.Nullable<ulong> DatafeedId { get; set; } 

        /// <summary>The list of errors occurring in the feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<DatafeedStatusError> Errors { get; set; } 

        /// <summary>The number of items in the feed that were processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsTotal")]
        public virtual System.Nullable<ulong> ItemsTotal { get; set; } 

        /// <summary>The number of items in the feed that were valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsValid")]
        public virtual System.Nullable<ulong> ItemsValid { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#datafeedStatus`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The two-letter ISO 639-1 language for which the status is reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The last date at which the feed was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUploadDate")]
        public virtual string LastUploadDate { get; set; } 

        /// <summary>The processing status of the feed.
        ///
        /// Acceptable values are: - "`"`failure`": The feed could not be processed or all items had errors.`" - "`in
        /// progress`": The feed is being processed. - "`none`": The feed has not yet been processed. For example, a
        /// feed that has never been uploaded will have this processing status. - "`success`": The feed was processed
        /// successfully, though some items might have had errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingStatus")]
        public virtual string ProcessingStatus { get; set; } 

        /// <summary>The list of errors occurring in the feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<DatafeedStatusError> Warnings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An error occurring in the feed, like "invalid price".</summary>
    public class DatafeedStatusError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The code of the error, e.g., "validation/invalid_value".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; } 

        /// <summary>The number of occurrences of the error in the feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<ulong> Count { get; set; } 

        /// <summary>A list of example occurrences of the error, grouped by product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
        public virtual System.Collections.Generic.IList<DatafeedStatusExample> Examples { get; set; } 

        /// <summary>The error message, e.g., "Invalid price".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An example occurrence for a particular error.</summary>
    public class DatafeedStatusExample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the example item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Line number in the data feed where the example is found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<ulong> LineNumber { get; set; } 

        /// <summary>The problematic value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country where the items in the feed will be included in the search index, represented as a
        /// CLDR territory code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The list of destinations to exclude for this target (corresponds to unchecked check boxes in
        /// Merchant Center).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDestinations")]
        public virtual System.Collections.Generic.IList<string> ExcludedDestinations { get; set; } 

        /// <summary>The list of destinations to include for this target (corresponds to checked check boxes in Merchant
        /// Center). Default destinations are always included unless provided in `excludedDestinations`.
        ///
        /// List of supported destinations (if available to the account): - DisplayAds - Shopping - ShoppingActions -
        /// SurfacesAcrossGoogle</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDestinations")]
        public virtual System.Collections.Generic.IList<string> IncludedDestinations { get; set; } 

        /// <summary>The two-letter ISO 639-1 language of the items in the feed. Must be a valid language for
        /// `targets[].country`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedsCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DatafeedsCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch datafeeds request.</summary>
    public class DatafeedsCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The data feed to insert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeed")]
        public virtual Datafeed Datafeed { get; set; } 

        /// <summary>The ID of the data feed to get, delete or fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeedId")]
        public virtual System.Nullable<ulong> DatafeedId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`delete`" - "`fetchNow`" - "`get`" - "`insert`" - "`update`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedsCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DatafeedsCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#datafeedsCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch datafeeds response.</summary>
    public class DatafeedsCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The requested data feed. Defined if and only if the request was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeed")]
        public virtual Datafeed Datafeed { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedsFetchNowResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#datafeedsFetchNowResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#datafeedsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of datafeeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Datafeed> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedstatusesCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DatafeedstatusesCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch datafeedstatuses request.</summary>
    public class DatafeedstatusesCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The country for which to get the datafeed status. If this parameter is provided then language must
        /// also be provided. Note that for multi-target datafeeds this parameter is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The ID of the data feed to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeedId")]
        public virtual System.Nullable<ulong> DatafeedId { get; set; } 

        /// <summary>The language for which to get the datafeed status. If this parameter is provided then country must
        /// also be provided. Note that for multi-target datafeeds this parameter is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedstatusesCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<DatafeedstatusesCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#datafeedstatusesCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch datafeedstatuses response.</summary>
    public class DatafeedstatusesCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The requested data feed status. Defined if and only if the request was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datafeedStatus")]
        public virtual DatafeedStatus DatafeedStatus { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DatafeedstatusesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#datafeedstatusesListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of datafeed statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<DatafeedStatus> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DeliveryTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Business days cutoff time definition. If not configured the cutoff time will be defaulted to 8AM
        /// PST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoffTime")]
        public virtual CutoffTime CutoffTime { get; set; } 

        /// <summary>The business days during which orders can be handled. If not provided, Monday to Friday business
        /// days will be assumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handlingBusinessDayConfig")]
        public virtual BusinessDayConfig HandlingBusinessDayConfig { get; set; } 

        /// <summary>Holiday cutoff definitions. If configured, they specify order cutoff times for holiday-specific
        /// shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidayCutoffs")]
        public virtual System.Collections.Generic.IList<HolidayCutoff> HolidayCutoffs { get; set; } 

        /// <summary>Maximum number of business days spent before an order is shipped. 0 means same day shipped, 1 means
        /// next day shipped. Must be greater than or equal to `minHandlingTimeInDays`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxHandlingTimeInDays")]
        public virtual System.Nullable<long> MaxHandlingTimeInDays { get; set; } 

        /// <summary>Maximum number of business days that is spent in transit. 0 means same day delivery, 1 means next
        /// day delivery. Must be greater than or equal to `minTransitTimeInDays`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTransitTimeInDays")]
        public virtual System.Nullable<long> MaxTransitTimeInDays { get; set; } 

        /// <summary>Minimum number of business days spent before an order is shipped. 0 means same day shipped, 1 means
        /// next day shipped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHandlingTimeInDays")]
        public virtual System.Nullable<long> MinHandlingTimeInDays { get; set; } 

        /// <summary>Minimum number of business days that is spent in transit. 0 means same day delivery, 1 means next
        /// day delivery. Either `{min,max}TransitTimeInDays` or `transitTimeTable` must be set, but not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTransitTimeInDays")]
        public virtual System.Nullable<long> MinTransitTimeInDays { get; set; } 

        /// <summary>The business days during which orders can be in-transit. If not provided, Monday to Friday business
        /// days will be assumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitBusinessDayConfig")]
        public virtual BusinessDayConfig TransitBusinessDayConfig { get; set; } 

        /// <summary>Transit time table, number of business days spent in transit based on row and column dimensions.
        /// Either `{min,max}TransitTimeInDays` or `transitTimeTable` can be set, but not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeTable")]
        public virtual TransitTable TransitTimeTable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An error returned by the API.</summary>
    public class Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; } 

        /// <summary>A description of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of errors returned by a failed batch entry.</summary>
    public class Errors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP status of the first error in `errors`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<long> Code { get; set; } 

        /// <summary>A list of errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> ErrorsValue { get; set; } 

        /// <summary>The message of the first error in `errors`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GmbAccounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Merchant Center account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>A list of GMB accounts which are available to the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbAccounts")]
        public virtual System.Collections.Generic.IList<GmbAccountsGmbAccount> GmbAccountsValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GmbAccountsGmbAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email which identifies the GMB account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>Number of listings under this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listingCount")]
        public virtual System.Nullable<ulong> ListingCount { get; set; } 

        /// <summary>The name of the GMB account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The type of the GMB account (User or Business).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A non-empty list of row or column headers for a table. Exactly one of `prices`, `weights`, `numItems`,
    /// `postalCodeGroupNames`, or `location` must be set.</summary>
    public class Headers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of location ID sets. Must be non-empty. Can only be set if all other fields are not
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LocationIdSet> Locations { get; set; } 

        /// <summary>A list of inclusive number of items upper bounds. The last value can be `"infinity"`. For example
        /// `["10", "50", "infinity"]` represents the headers "<= 10 items", " 50 items". Must be non-empty. Can only be
        /// set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfItems")]
        public virtual System.Collections.Generic.IList<string> NumberOfItems { get; set; } 

        /// <summary>A list of postal group names. The last value can be `"all other locations"`. Example: `["zone 1",
        /// "zone 2", "all other locations"]`. The referred postal code groups must match the delivery country of the
        /// service. Must be non-empty. Can only be set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeGroupNames")]
        public virtual System.Collections.Generic.IList<string> PostalCodeGroupNames { get; set; } 

        /// <summary>A list of inclusive order price upper bounds. The last price's value can be `"infinity"`. For
        /// example `[{"value": "10", "currency": "USD"}, {"value": "500", "currency": "USD"}, {"value": "infinity",
        /// "currency": "USD"}]` represents the headers "<= $10", " $500". All prices within a service must have the
        /// same currency. Must be non-empty. Can only be set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IList<Price> Prices { get; set; } 

        /// <summary>A list of inclusive order weight upper bounds. The last weight's value can be `"infinity"`. For
        /// example `[{"value": "10", "unit": "kg"}, {"value": "50", "unit": "kg"}, {"value": "infinity", "unit":
        /// "kg"}]` represents the headers "<= 10kg", " 50kg". All weights within a service must have the same unit.
        /// Must be non-empty. Can only be set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weights")]
        public virtual System.Collections.Generic.IList<Weight> Weights { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class HolidayCutoff : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date of the order deadline, in ISO 8601 format. E.g. "2016-11-29" for 29th November 2016.
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadlineDate")]
        public virtual string DeadlineDate { get; set; } 

        /// <summary>Hour of the day on the deadline date until which the order has to be placed to qualify for the
        /// delivery guarantee. Possible values are: 0 (midnight), 1, ..., 12 (noon), 13, ..., 23. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadlineHour")]
        public virtual System.Nullable<long> DeadlineHour { get; set; } 

        /// <summary>Timezone identifier for the deadline hour. A list of identifiers can be found in  the AdWords API
        /// documentation. E.g. "Europe/Zurich". Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadlineTimezone")]
        public virtual string DeadlineTimezone { get; set; } 

        /// <summary>Unique identifier for the holiday. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidayId")]
        public virtual string HolidayId { get; set; } 

        /// <summary>Date on which the deadline will become visible to consumers in ISO 8601 format. E.g. "2016-10-31"
        /// for 31st October 2016. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleFromDate")]
        public virtual string VisibleFromDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class HolidaysHoliday : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CLDR territory code of the country in which the holiday is available. E.g. "US", "DE", "GB". A
        /// holiday cutoff can only be configured in a shipping settings service with matching delivery country. Always
        /// present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; } 

        /// <summary>Date of the holiday, in ISO 8601 format. E.g. "2016-12-25" for Christmas 2016. Always
        /// present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; } 

        /// <summary>Date on which the order has to arrive at the customer's, in ISO 8601 format. E.g. "2016-12-24" for
        /// 24th December 2016. Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryGuaranteeDate")]
        public virtual string DeliveryGuaranteeDate { get; set; } 

        /// <summary>Hour of the day in the delivery location's timezone on the guaranteed delivery date by which the
        /// order has to arrive at the customer's. Possible values are: 0 (midnight), 1, ..., 12 (noon), 13, ..., 23.
        /// Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryGuaranteeHour")]
        public virtual System.Nullable<ulong> DeliveryGuaranteeHour { get; set; } 

        /// <summary>Unique identifier for the holiday to be used when configuring holiday cutoffs. Always
        /// present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The holiday type. Always present.
        ///
        /// Acceptable values are: - "`Christmas`" - "`Easter`" - "`Father's Day`" - "`Halloween`" - "`Independence Day
        /// (USA)`" - "`Mother's Day`" - "`Thanksgiving`" - "`Valentine's Day`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Installment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; } 

        /// <summary>The number of installments the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("months")]
        public virtual System.Nullable<long> Months { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class InvoiceSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary of the total amounts of the additional charges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalChargeSummaries")]
        public virtual System.Collections.Generic.IList<InvoiceSummaryAdditionalChargeSummary> AdditionalChargeSummaries { get; set; } 

        /// <summary>[required] Total price for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTotal")]
        public virtual Amount ProductTotal { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class InvoiceSummaryAdditionalChargeSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] Total additional charge for this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalAmount")]
        public virtual Amount TotalAmount { get; set; } 

        /// <summary>[required] Type of the additional charge.
        ///
        /// Acceptable values are: - "`shipping`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiaAboutPageSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the verification process for the About page.
        ///
        /// Acceptable values are: - "`active`" - "`inactive`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The URL for the About page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiaCountrySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The settings for the About page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("about")]
        public virtual LiaAboutPageSettings About { get; set; } 

        /// <summary>Required. CLDR country code (e.g. "US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The status of the "Merchant hosted local storefront" feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostedLocalStorefrontActive")]
        public virtual System.Nullable<bool> HostedLocalStorefrontActive { get; set; } 

        /// <summary>LIA inventory verification settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventory")]
        public virtual LiaInventorySettings Inventory { get; set; } 

        /// <summary>LIA "On Display To Order" settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onDisplayToOrder")]
        public virtual LiaOnDisplayToOrderSettings OnDisplayToOrder { get; set; } 

        /// <summary>The POS data provider linked with this country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProvider")]
        public virtual LiaPosDataProvider PosDataProvider { get; set; } 

        /// <summary>The status of the "Store pickup" feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storePickupActive")]
        public virtual System.Nullable<bool> StorePickupActive { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiaInventorySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email of the contact for the inventory verification process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryVerificationContactEmail")]
        public virtual string InventoryVerificationContactEmail { get; set; } 

        /// <summary>The name of the contact for the inventory verification process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryVerificationContactName")]
        public virtual string InventoryVerificationContactName { get; set; } 

        /// <summary>The status of the verification contact.
        ///
        /// Acceptable values are: - "`active`" - "`inactive`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryVerificationContactStatus")]
        public virtual string InventoryVerificationContactStatus { get; set; } 

        /// <summary>The status of the inventory verification process.
        ///
        /// Acceptable values are: - "`active`" - "`inactive`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiaOnDisplayToOrderSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Shipping cost and policy URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingCostPolicyUrl")]
        public virtual string ShippingCostPolicyUrl { get; set; } 

        /// <summary>The status of the ?On display to order? feature.
        ///
        /// Acceptable values are: - "`active`" - "`inactive`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiaPosDataProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the POS data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProviderId")]
        public virtual System.Nullable<ulong> PosDataProviderId { get; set; } 

        /// <summary>The account ID by which this merchant is known to the POS data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posExternalAccountId")]
        public virtual string PosExternalAccountId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Local Inventory ads (LIA) settings. All methods except listposdataproviders require the admin
    /// role.</summary>
    public class LiaSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account to which these LIA settings belong. Ignored upon update, always present in
        /// get request responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>The LIA settings for each country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countrySettings")]
        public virtual System.Collections.Generic.IList<LiaCountrySettings> CountrySettings { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#liaSettings`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LiasettingsCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account for which to get/update account LIA settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>Inventory validation contact email. Required only for SetInventoryValidationContact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; } 

        /// <summary>Inventory validation contact name. Required only for SetInventoryValidationContact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactName")]
        public virtual string ContactName { get; set; } 

        /// <summary>The country code. Required only for RequestInventoryVerification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The GMB account. Required only for RequestGmbAccess.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbEmail")]
        public virtual string GmbEmail { get; set; } 

        /// <summary>The account Lia settings to update. Only defined if the method is `update`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liaSettings")]
        public virtual LiaSettings LiaSettings { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`" - "`getAccessibleGmbAccounts`" - "`requestGmbAccess`" -
        /// "`requestInventoryVerification`" - "`setInventoryVerificationContact`" - "`update`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ID of POS data provider. Required only for SetPosProvider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProviderId")]
        public virtual System.Nullable<ulong> PosDataProviderId { get; set; } 

        /// <summary>The account ID by which this merchant is known to the POS provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posExternalAccountId")]
        public virtual string PosExternalAccountId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LiasettingsCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry to which this entry responds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if, and only if, the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>The the list of accessible GMB accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbAccounts")]
        public virtual GmbAccounts GmbAccounts { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#liasettingsCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The retrieved or updated Lia settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liaSettings")]
        public virtual LiaSettings LiaSettings { get; set; } 

        /// <summary>The list of POS data providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProviders")]
        public virtual System.Collections.Generic.IList<PosDataProviders> PosDataProviders { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsGetAccessibleGmbAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Merchant Center account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>A list of GMB accounts which are available to the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmbAccounts")]
        public virtual System.Collections.Generic.IList<GmbAccountsGmbAccount> GmbAccounts { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsGetAccessibleGmbAccountsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsListPosDataProvidersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsListPosDataProvidersResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The list of POS data providers for each eligible country</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProviders")]
        public virtual System.Collections.Generic.IList<PosDataProviders> PosDataProviders { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of LIA settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<LiaSettings> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsRequestGmbAccessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsRequestGmbAccessResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsRequestInventoryVerificationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsRequestInventoryVerificationResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsSetInventoryVerificationContactResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsSetInventoryVerificationContactResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LiasettingsSetPosDataProviderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#liasettingsSetPosDataProviderResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LinkService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Service provided to or by the linked account.
        ///
        /// Acceptable values are: - "`shoppingActionsOrderManagement`" - "`shoppingActionsProductManagement`" -
        /// "`shoppingAdsProductManagement`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; } 

        /// <summary>Status of the link
        ///
        /// Acceptable values are: - "`active`" - "`inactive`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LinkedAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the linked account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccountId")]
        public virtual string LinkedAccountId { get; set; } 

        /// <summary>List of provided services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<LinkService> Services { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Local inventory resource. For accepted attribute values, see the local product inventory feed
    /// specification.</summary>
    public class LocalInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Availability of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; } 

        /// <summary>In-store product location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instoreProductLocation")]
        public virtual string InstoreProductLocation { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#localInventory`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Supported pickup method for this offer. Unless the value is "not supported", this field must be
        /// submitted together with `pickupSla`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupMethod")]
        public virtual string PickupMethod { get; set; } 

        /// <summary>Expected date that an order will be ready for pickup relative to the order date. Must be submitted
        /// together with `pickupMethod`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupSla")]
        public virtual string PickupSla { get; set; } 

        /// <summary>Price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Quantity of the product. Must be nonnegative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>Sale price of the product. Mandatory if `sale_price_effective_date` is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; } 

        /// <summary>A date range represented by a pair of ISO 8601 dates separated by a space, comma, or slash. Both
        /// dates may be specified as 'null' if undecided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual string SalePriceEffectiveDate { get; set; } 

        /// <summary>Required. Store code of this local inventory resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LocalinventoryCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LocalinventoryCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Batch entry encoding a single local inventory update request.</summary>
    public class LocalinventoryCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>Local inventory of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localInventory")]
        public virtual LocalInventory LocalInventory { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Method of the batch request entry.
        ///
        /// Acceptable values are: - "`insert`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ID of the product for which to update local inventory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LocalinventoryCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<LocalinventoryCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#localinventoryCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Batch entry encoding a single local inventory update response.</summary>
    public class LocalinventoryCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#localinventoryCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LocationIdSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A non-empty list of location IDs. They must all be of the same location type (e.g.,
        /// state).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationIds")]
        public virtual System.Collections.Generic.IList<string> LocationIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LoyaltyPoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of loyalty points program. It is recommended to limit the name to 12 full-width characters or
        /// 24 Roman characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The retailer's loyalty points in absolute value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointsValue")]
        public virtual System.Nullable<long> PointsValue { get; set; } 

        /// <summary>The ratio of a point when converted to currency. Google assumes currency based on Merchant Center
        /// settings. If ratio is left out, it defaults to 1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Order return. Production access (all methods) requires the order manager role. Sandbox access does
    /// not.</summary>
    public class MerchantOrderReturn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date of creation of the return, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>Merchant defined order ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantOrderId")]
        public virtual string MerchantOrderId { get; set; } 

        /// <summary>Google order ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; } 

        /// <summary>Order return ID generated by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderReturnId")]
        public virtual string OrderReturnId { get; set; } 

        /// <summary>Items of the return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnItems")]
        public virtual System.Collections.Generic.IList<MerchantOrderReturnItem> ReturnItems { get; set; } 

        /// <summary>Information about shipping costs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPricingInfo")]
        public virtual ReturnPricingInfo ReturnPricingInfo { get; set; } 

        /// <summary>Shipments of the return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnShipments")]
        public virtual System.Collections.Generic.IList<ReturnShipment> ReturnShipments { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MerchantOrderReturnItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason that the customer chooses to return an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerReturnReason")]
        public virtual CustomerReturnReason CustomerReturnReason { get; set; } 

        /// <summary>Product level item ID. If the returned items are of the same product, they will have the same
        /// ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>The reason that the merchant chose to reject an item return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantRejectionReason")]
        public virtual MerchantRejectionReason MerchantRejectionReason { get; set; } 

        /// <summary>The reason that merchant chooses to accept a return item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantReturnReason")]
        public virtual RefundReason MerchantReturnReason { get; set; } 

        /// <summary>Product data from the time of the order placement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual OrderLineItemProduct Product { get; set; } 

        /// <summary>Maximum amount that can be refunded for this return item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundableAmount")]
        public virtual MonetaryAmount RefundableAmount { get; set; } 

        /// <summary>Unit level ID for the return item. Different units of the same product will have different
        /// IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnItemId")]
        public virtual string ReturnItemId { get; set; } 

        /// <summary>IDs of the return shipments that this return item belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnShipmentIds")]
        public virtual System.Collections.Generic.IList<string> ReturnShipmentIds { get; set; } 

        /// <summary>ID of the original shipment group. Provided for shipments with invoice support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentGroupId")]
        public virtual string ShipmentGroupId { get; set; } 

        /// <summary>ID of the shipment unit assigned by the merchant. Provided for shipments with invoice
        /// support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentUnitId")]
        public virtual string ShipmentUnitId { get; set; } 

        /// <summary>State of the item.
        ///
        /// Acceptable values are: - "`canceled`" - "`new`" - "`received`" - "`refunded`" - "`rejected`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MerchantRejectionReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Code of the rejection reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonCode")]
        public virtual string ReasonCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MinimumOrderValueTable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodeSetWithMovs")]
        public virtual System.Collections.Generic.IList<MinimumOrderValueTableStoreCodeSetWithMov> StoreCodeSetWithMovs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of store code sets sharing the same minimum order value. At least two sets are required and the
    /// last one must be empty, which signifies 'MOV for all other stores'. Each store code can only appear once across
    /// all the sets. All prices within a service must have the same currency.</summary>
    public class MinimumOrderValueTableStoreCodeSetWithMov : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of unique store codes or empty for the catch all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodes")]
        public virtual System.Collections.Generic.IList<string> StoreCodes { get; set; } 

        /// <summary>The minimum order value for the given stores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Price Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MonetaryAmount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pre-tax or post-tax price depends on the location of the order. - For countries (e.g. US) where
        /// price attribute excludes tax, this field corresponds to the pre-tax value. - For coutries (e.g. France)
        /// where price attribute includes tax, this field corresponds to the post-tax value .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>Tax value, present only for countries where price attribute excludes tax (e.g. US). No tax is
        /// referenced as 0 value with the corresponding `currency`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Order. Production access (all methods) requires the order manager role. Sandbox access does not. (==
    /// resource_for v2.orders ==) (== resource_for v2.1.orders ==)</summary>
    public class Order : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the order was acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledged")]
        public virtual System.Nullable<bool> Acknowledged { get; set; } 

        /// <summary>List of key-value pairs that are attached to a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<OrderOrderAnnotation> Annotations { get; set; } 

        /// <summary>The billing address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAddress")]
        public virtual OrderAddress BillingAddress { get; set; } 

        /// <summary>The details of the customer who placed the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual OrderCustomer Customer { get; set; } 

        /// <summary>Delivery details for shipments of type `delivery`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryDetails")]
        public virtual OrderDeliveryDetails DeliveryDetails { get; set; } 

        /// <summary>The REST ID of the order. Globally unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#order`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Line items that are ordered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<OrderLineItem> LineItems { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Merchant-provided ID of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantOrderId")]
        public virtual string MerchantOrderId { get; set; } 

        /// <summary>The net amount for the order (price part). For example, if an order was originally for $100 and a
        /// refund was issued for $20, the net amount will be $80.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netPriceAmount")]
        public virtual Price NetPriceAmount { get; set; } 

        /// <summary>The net amount for the order (tax part). Note that in certain cases due to taxable base adjustment
        /// `netTaxAmount` might not match to a sum of tax field across all lineItems and refunds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netTaxAmount")]
        public virtual Price NetTaxAmount { get; set; } 

        /// <summary>The status of the payment.
        ///
        /// Acceptable values are: - "`paymentCaptured`" - "`paymentRejected`" - "`paymentSecured`" -
        /// "`pendingAuthorization`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentStatus")]
        public virtual string PaymentStatus { get; set; } 

        /// <summary>Pickup details for shipments of type `pickup`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupDetails")]
        public virtual OrderPickupDetails PickupDetails { get; set; } 

        /// <summary>The date when the order was placed, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placedDate")]
        public virtual string PlacedDate { get; set; } 

        /// <summary>Promotions associated with the order.
        ///
        /// To determine which promotions apply to which products, check the `Promotions[].appliedItems[].lineItemId`
        /// field against the `LineItems[].id` field for each promotion. If a promotion is applied to more than 1
        /// offerId, divide the discount value by the number of affected offers to determine how much discount to apply
        /// to each offerId.
        ///
        /// Examples: - To calculate price paid by the customer for a single line item including the discount: For each
        /// promotion, subtract the `LineItems[].adjustments[].priceAdjustment.value` amount from the
        /// `LineItems[].Price.value`. - To calculate price paid by the customer for a single line item including the
        /// discount in case of multiple quantity: For each promotion, divide the
        /// `LineItems[].adjustments[].priceAdjustment.value` by the quantity of products then subtract the resulting
        /// value from the `LineItems[].Product.Price.value` for each quantity item.
        ///
        /// Only 1 promotion can be applied to an offerId in a given order. To refund an item which had a promotion
        /// applied to it, make sure to refund the amount after first subtracting the promotion discount from the item
        /// price.
        ///
        /// More details about the program are here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<OrderPromotion> Promotions { get; set; } 

        /// <summary>Refunds for the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refunds")]
        public virtual System.Collections.Generic.IList<OrderRefund> Refunds { get; set; } 

        /// <summary>Shipments of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipments")]
        public virtual System.Collections.Generic.IList<OrderShipment> Shipments { get; set; } 

        /// <summary>The total cost of shipping for all items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingCost")]
        public virtual Price ShippingCost { get; set; } 

        /// <summary>The tax for the total shipping cost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingCostTax")]
        public virtual Price ShippingCostTax { get; set; } 

        /// <summary>The status of the order.
        ///
        /// Acceptable values are: - "`canceled`" - "`delivered`" - "`inProgress`" - "`partiallyDelivered`" -
        /// "`partiallyReturned`" - "`partiallyShipped`" - "`pendingShipment`" - "`returned`" - "`shipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The party responsible for collecting and remitting taxes.
        ///
        /// Acceptable values are: - "`marketplaceFacilitator`" - "`merchant`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxCollector")]
        public virtual string TaxCollector { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CLDR country code (e.g. "US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Strings representing the lines of the printed label for mailing the order, for example: John Smith
        /// 1600 Amphitheatre Parkway Mountain View, CA, 94043 United States</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullAddress")]
        public virtual System.Collections.Generic.IList<string> FullAddress { get; set; } 

        /// <summary>Whether the address is a post office box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPostOfficeBox")]
        public virtual System.Nullable<bool> IsPostOfficeBox { get; set; } 

        /// <summary>City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods
        /// or suburbs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Postal Code or ZIP (e.g. "94043").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Name of the recipient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientName")]
        public virtual string RecipientName { get; set; } 

        /// <summary>Top-level administrative subdivision of the country. For example, a state like California ("CA") or
        /// a province like Quebec ("QC").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Street-level part of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual System.Collections.Generic.IList<string> StreetAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actor that created the cancellation.
        ///
        /// Acceptable values are: - "`customer`" - "`googleBot`" - "`googleCustomerService`" - "`googlePayments`" -
        /// "`googleSabre`" - "`merchant`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual string Actor { get; set; } 

        /// <summary>Date on which the cancellation has been created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>The quantity that was canceled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the cancellation. Orders that are canceled with a noInventory reason will lead to
        /// the removal of the product from Shopping Actions until you make an update to that product. This will not
        /// affect your Shopping ads.
        ///
        /// Acceptable values are: - "`autoPostInternal`" - "`autoPostInvalidBillingAddress`" - "`autoPostNoInventory`"
        /// - "`autoPostPriceError`" - "`autoPostUndeliverableShippingAddress`" - "`couponAbuse`" - "`customerCanceled`"
        /// - "`customerInitiatedCancel`" - "`customerSupportRequested`" - "`failToPushOrderGoogleError`" -
        /// "`failToPushOrderMerchantError`" - "`failToPushOrderMerchantFulfillmentError`" -
        /// "`failToPushOrderToMerchant`" - "`failToPushOrderToMerchantOutOfStock`" - "`invalidCoupon`" -
        /// "`malformedShippingAddress`" - "`merchantDidNotShipOnTime`" - "`noInventory`" - "`orderTimeout`" - "`other`"
        /// - "`paymentAbuse`" - "`paymentDeclined`" - "`priceError`" - "`returnRefundAbuse`" - "`shippingPriceError`" -
        /// "`taxError`" - "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderCustomer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Full name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; } 

        /// <summary>Email address for the merchant to send value-added tax or invoice documentation of the order. Only
        /// the last document sent is made available to the customer. For more information, see  About automated VAT
        /// invoicing for Shopping Actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceReceivingEmail")]
        public virtual string InvoiceReceivingEmail { get; set; } 

        /// <summary>Loyalty program information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyInfo")]
        public virtual OrderCustomerLoyaltyInfo LoyaltyInfo { get; set; } 

        /// <summary>Customer's marketing preferences. Contains the marketing opt-in information that is current at the
        /// time that the merchant call. User preference selections can change from one order to the next so preferences
        /// must be checked with every order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingRightsInfo")]
        public virtual OrderCustomerMarketingRightsInfo MarketingRightsInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderCustomerLoyaltyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The loyalty card/membership number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyNumber")]
        public virtual string LoyaltyNumber { get; set; } 

        /// <summary>Name of card/membership holder, this field will be populated when</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderCustomerMarketingRightsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Last known customer selection regarding marketing preferences. In certain cases this selection
        /// might not be known, so this field would be empty. If a customer selected `granted` in their most recent
        /// order, they can be subscribed to marketing emails. Customers who have chosen `denied` must not be
        /// subscribed, or must be unsubscribed if already opted-in.
        ///
        /// Acceptable values are: - "`denied`" - "`granted`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitMarketingPreference")]
        public virtual string ExplicitMarketingPreference { get; set; } 

        /// <summary>Timestamp when last time marketing preference was updated. Could be empty, if user wasn't offered a
        /// selection yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestamp")]
        public virtual string LastUpdatedTimestamp { get; set; } 

        /// <summary>Email address that can be used for marketing purposes. The field may be empty even if
        /// `explicitMarketingPreference` is 'granted'. This happens when retrieving an old order from the customer who
        /// deleted their account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingEmailAddress")]
        public virtual string MarketingEmailAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderDeliveryDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The delivery address</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual OrderAddress Address { get; set; } 

        /// <summary>The phone number of the person receiving the delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Price and tax adjustments applied on the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjustments")]
        public virtual System.Collections.Generic.IList<OrderLineItemAdjustment> Adjustments { get; set; } 

        /// <summary>Annotations that are attached to the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<OrderMerchantProvidedAnnotation> Annotations { get; set; } 

        /// <summary>Cancellations of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellations")]
        public virtual System.Collections.Generic.IList<OrderCancellation> Cancellations { get; set; } 

        /// <summary>The ID of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Total price for the line item. For example, if two items for $10 are purchased, the total price
        /// will be $20.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Product data as seen by customer from the time of the order placement. Note that certain attributes
        /// values (e.g. title or gtin) might be reformatted and no longer match values submitted via product
        /// feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual OrderLineItemProduct Product { get; set; } 

        /// <summary>Number of items canceled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityCanceled")]
        public virtual System.Nullable<long> QuantityCanceled { get; set; } 

        /// <summary>Number of items delivered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityDelivered")]
        public virtual System.Nullable<long> QuantityDelivered { get; set; } 

        /// <summary>Number of items ordered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityOrdered")]
        public virtual System.Nullable<long> QuantityOrdered { get; set; } 

        /// <summary>Number of items pending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityPending")]
        public virtual System.Nullable<long> QuantityPending { get; set; } 

        /// <summary>Number of items ready for pickup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityReadyForPickup")]
        public virtual System.Nullable<long> QuantityReadyForPickup { get; set; } 

        /// <summary>Number of items returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityReturned")]
        public virtual System.Nullable<long> QuantityReturned { get; set; } 

        /// <summary>Number of items shipped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityShipped")]
        public virtual System.Nullable<long> QuantityShipped { get; set; } 

        /// <summary>Number of items undeliverable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityUndeliverable")]
        public virtual System.Nullable<long> QuantityUndeliverable { get; set; } 

        /// <summary>Details of the return policy for the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnInfo")]
        public virtual OrderLineItemReturnInfo ReturnInfo { get; set; } 

        /// <summary>Returns of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returns")]
        public virtual System.Collections.Generic.IList<OrderReturn> Returns { get; set; } 

        /// <summary>Details of the requested shipping for the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingDetails")]
        public virtual OrderLineItemShippingDetails ShippingDetails { get; set; } 

        /// <summary>Total tax amount for the line item. For example, if two items are purchased, and each have a cost
        /// tax of $2, the total tax amount will be $4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tax")]
        public virtual Price Tax { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemAdjustment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adjustment for total price of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAdjustment")]
        public virtual Price PriceAdjustment { get; set; } 

        /// <summary>Adjustment for total tax of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAdjustment")]
        public virtual Price TaxAdjustment { get; set; } 

        /// <summary>Type of this adjustment.
        ///
        /// Acceptable values are: - "`promotion`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brand of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>Condition or state of the item.
        ///
        /// Acceptable values are: - "`new`" - "`refurbished`" - "`used`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Associated fees at order creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fees")]
        public virtual System.Collections.Generic.IList<OrderLineItemProductFee> Fees { get; set; } 

        /// <summary>Global Trade Item Number (GTIN) of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>The REST ID of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>URL of an image of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLink")]
        public virtual string ImageLink { get; set; } 

        /// <summary>Shared identifier for all variants of the same product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; } 

        /// <summary>Manufacturer Part Number (MPN) of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; } 

        /// <summary>An identifier of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; } 

        /// <summary>Price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>URL to the cached image shown to the user when order was placed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownImage")]
        public virtual string ShownImage { get; set; } 

        /// <summary>The CLDR territory code of the target country of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>The title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Variant attributes for the item. These are dimensions of the product, such as color, gender,
        /// material, pattern, and size. You can find a comprehensive list of variant attributes here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantAttributes")]
        public virtual System.Collections.Generic.IList<OrderLineItemProductVariantAttribute> VariantAttributes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemProductFee : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Amount of the fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; } 

        /// <summary>Name of the fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemProductVariantAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension of the variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; } 

        /// <summary>The value for the dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemReturnInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. How many days later the item can be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysToReturn")]
        public virtual System.Nullable<int> DaysToReturn { get; set; } 

        /// <summary>Required. Whether the item is returnable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReturnable")]
        public virtual System.Nullable<bool> IsReturnable { get; set; } 

        /// <summary>Required. URL of the item return policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyUrl")]
        public virtual string PolicyUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemShippingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The delivery by date, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliverByDate")]
        public virtual string DeliverByDate { get; set; } 

        /// <summary>Required. Details of the shipping method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual OrderLineItemShippingDetailsMethod Method { get; set; } 

        /// <summary>The promised time in minutes in which the order will be ready for pickup. This only applies to buy-
        /// online-pickup-in-store same-day order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupPromiseInMinutes")]
        public virtual System.Nullable<long> PickupPromiseInMinutes { get; set; } 

        /// <summary>Required. The ship by date, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipByDate")]
        public virtual string ShipByDate { get; set; } 

        /// <summary>Type of shipment. Indicates whether `deliveryDetails` or `pickupDetails` is applicable for this
        /// shipment.
        ///
        /// Acceptable values are: - "`delivery`" - "`pickup`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderLineItemShippingDetailsMethod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The carrier for the shipping. Optional. See `shipments[].carrier` for a list of acceptable
        /// values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; } 

        /// <summary>Required. Maximum transit time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDaysInTransit")]
        public virtual System.Nullable<long> MaxDaysInTransit { get; set; } 

        /// <summary>Required. The name of the shipping method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; } 

        /// <summary>Required. Minimum transit time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minDaysInTransit")]
        public virtual System.Nullable<long> MinDaysInTransit { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderMerchantProvidedAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key for additional merchant provided (as key-value pairs) annotation about the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Value for additional merchant provided (as key-value pairs) annotation about the line
        /// item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderOrderAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key for additional google provided (as key-value pairs) annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Value for additional google provided (as key-value pairs) annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderPickupDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Address of the pickup location where the shipment should be sent. Note that `recipientName` in the
        /// address is the name of the business at the pickup location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual OrderAddress Address { get; set; } 

        /// <summary>Collectors authorized to pick up shipment from the pickup location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectors")]
        public virtual System.Collections.Generic.IList<OrderPickupDetailsCollector> Collectors { get; set; } 

        /// <summary>ID of the pickup location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; } 

        /// <summary>The pickup type of this order.
        ///
        /// Acceptable values are: - "`merchantStore`" - "`merchantStoreCurbside`" - "`merchantStoreLocker`" -
        /// "`thirdPartyPickupPoint`" - "`thirdPartyLocker`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupType")]
        public virtual string PickupType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderPickupDetailsCollector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the person picking up the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Phone number of the person picking up the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderPromotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Items that this promotion may be applied to. If empty, there are no restrictions on applicable
        /// items and quantity. This field will also be empty for shipping promotions because shipping is not tied to
        /// any specific item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableItems")]
        public virtual System.Collections.Generic.IList<OrderPromotionItem> ApplicableItems { get; set; } 

        /// <summary>Items that this promotion have been applied to. Do not provide for `orders.createtestorder`. This
        /// field will be empty for shipping promotions because shipping is not tied to any specific item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedItems")]
        public virtual System.Collections.Generic.IList<OrderPromotionItem> AppliedItems { get; set; } 

        /// <summary>Promotion end time in ISO 8601 format. Date, time, and offset required, e.g.,
        /// "2020-01-02T09:00:00+01:00" or "2020-01-02T09:00:00Z".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; } 

        /// <summary>Required. The party funding the promotion. Only `merchant` is supported for
        /// `orders.createtestorder`.
        ///
        /// Acceptable values are: - "`google`" - "`merchant`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("funder")]
        public virtual string Funder { get; set; } 

        /// <summary>Required. This field is used to identify promotions within merchants' own systems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantPromotionId")]
        public virtual string MerchantPromotionId { get; set; } 

        /// <summary>Estimated discount applied to price. Amount is pre-tax or post-tax depending on location of
        /// order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceValue")]
        public virtual Price PriceValue { get; set; } 

        /// <summary>A short title of the promotion to be shown on the checkout page. Do not provide for
        /// `orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortTitle")]
        public virtual string ShortTitle { get; set; } 

        /// <summary>Promotion start time in ISO 8601 format. Date, time, and offset required, e.g.,
        /// "2020-01-02T09:00:00+01:00" or "2020-01-02T09:00:00Z".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; } 

        /// <summary>Required. The category of the promotion. Only `moneyOff` is supported for `orders.createtestorder`.
        ///
        /// Acceptable values are: - "`buyMGetMoneyOff`" - "`buyMGetNMoneyOff`" - "`buyMGetNPercentOff`" -
        /// "`buyMGetPercentOff`" - "`freeGift`" - "`freeGiftWithItemId`" - "`freeGiftWithValue`" -
        /// "`freeShippingOvernight`" - "`freeShippingStandard`" - "`freeShippingTwoDay`" - "`moneyOff`" -
        /// "`percentOff`" - "`rewardPoints`" - "`salePrice`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtype")]
        public virtual string Subtype { get; set; } 

        /// <summary>Estimated discount applied to tax (if allowed by law). Do not provide for
        /// `orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxValue")]
        public virtual Price TaxValue { get; set; } 

        /// <summary>Required. The title of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Required. The scope of the promotion. Only `product` is supported for `orders.createtestorder`.
        ///
        /// Acceptable values are: - "`product`" - "`shipping`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderPromotionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The line item ID of a product. Do not provide for `orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>Required. Offer ID of a product. Only for `orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; } 

        /// <summary>`orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity of the associated product. Do not provide for `orders.createtestorder`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actor that created the refund.
        ///
        /// Acceptable values are: - "`customer`" - "`googleBot`" - "`googleCustomerService`" - "`googlePayments`" -
        /// "`googleSabre`" - "`merchant`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual string Actor { get; set; } 

        /// <summary>The amount that is refunded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; } 

        /// <summary>Date on which the item has been created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>The reason for the refund.
        ///
        /// Acceptable values are: - "`adjustment`" - "`autoPostInternal`" - "`autoPostInvalidBillingAddress`" -
        /// "`autoPostNoInventory`" - "`autoPostPriceError`" - "`autoPostUndeliverableShippingAddress`" -
        /// "`couponAbuse`" - "`courtesyAdjustment`" - "`customerCanceled`" - "`customerDiscretionaryReturn`" -
        /// "`customerInitiatedMerchantCancel`" - "`customerSupportRequested`" - "`deliveredLateByCarrier`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`failToPushOrderGoogleError`" - "`failToPushOrderMerchantError`" -
        /// "`failToPushOrderMerchantFulfillmentError`" - "`failToPushOrderToMerchant`" -
        /// "`failToPushOrderToMerchantOutOfStock`" - "`feeAdjustment`" - "`invalidCoupon`" - "`lateShipmentCredit`" -
        /// "`malformedShippingAddress`" - "`merchantDidNotShipOnTime`" - "`noInventory`" - "`orderTimeout`" - "`other`"
        /// - "`paymentAbuse`" - "`paymentDeclined`" - "`priceAdjustment`" - "`priceError`" - "`productArrivedDamaged`"
        /// - "`productNotAsDescribed`" - "`promoReallocation`" - "`qualityNotAsExpected`" - "`returnRefundAbuse`" -
        /// "`shippingCostAdjustment`" - "`shippingPriceError`" - "`taxAdjustment`" - "`taxError`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Order disbursement. All methods require the payment analyst role. (== resource_for v2.orderreports ==)
    /// (== resource_for v2.1.orderreports ==)</summary>
    public class OrderReportDisbursement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The disbursement amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementAmount")]
        public virtual Price DisbursementAmount { get; set; } 

        /// <summary>The disbursement date, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementCreationDate")]
        public virtual string DisbursementCreationDate { get; set; } 

        /// <summary>The date the disbursement was initiated, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementDate")]
        public virtual string DisbursementDate { get; set; } 

        /// <summary>The ID of the disbursement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementId")]
        public virtual string DisbursementId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderReportTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The disbursement amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementAmount")]
        public virtual Price DisbursementAmount { get; set; } 

        /// <summary>The date the disbursement was created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementCreationDate")]
        public virtual string DisbursementCreationDate { get; set; } 

        /// <summary>The date the disbursement was initiated, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementDate")]
        public virtual string DisbursementDate { get; set; } 

        /// <summary>The ID of the disbursement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursementId")]
        public virtual string DisbursementId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Merchant-provided ID of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantOrderId")]
        public virtual string MerchantOrderId { get; set; } 

        /// <summary>The ID of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; } 

        /// <summary>Total amount for the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productAmount")]
        public virtual ProductAmount ProductAmount { get; set; } 

        /// <summary>The date of the transaction, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionDate")]
        public virtual string TransactionDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderReturn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actor that created the refund.
        ///
        /// Acceptable values are: - "`customer`" - "`googleBot`" - "`googleCustomerService`" - "`googlePayments`" -
        /// "`googleSabre`" - "`merchant`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual string Actor { get; set; } 

        /// <summary>Date on which the item has been created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>Quantity that is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the return.
        ///
        /// Acceptable values are: - "`customerDiscretionaryReturn`" - "`customerInitiatedMerchantCancel`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`invalidCoupon`" - "`malformedShippingAddress`" - "`other`" -
        /// "`productArrivedDamaged`" - "`productNotAsDescribed`" - "`qualityNotAsExpected`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderShipment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The carrier handling the shipment.
        ///
        /// For supported carriers, Google includes the carrier name and tracking URL in emails to customers. For select
        /// supported carriers, Google also automatically updates the shipment status based on the provided shipment ID.
        /// Note: You can also use unsupported carriers, but emails to customers will not include the carrier name or
        /// tracking URL, and there will be no automatic order status updates. Supported carriers for US are: - "`ups`"
        /// (United Parcel Service) automatic status updates - "`usps`" (United States Postal Service) automatic status
        /// updates - "`fedex`" (FedEx) automatic status updates - "`dhl`" (DHL eCommerce) automatic status updates (US
        /// only) - "`ontrac`" (OnTrac) automatic status updates - "`dhl express`" (DHL Express) - "`deliv`" (Deliv) -
        /// "`dynamex`" (TForce) - "`lasership`" (LaserShip) - "`mpx`" (Military Parcel Xpress) - "`uds`" (United
        /// Delivery Service) - "`efw`" (Estes Forwarding Worldwide) - "`jd logistics`" (JD Logistics) - "`yunexpress`"
        /// (YunExpress) - "`china post`" (China Post) - "`china ems`" (China Post Express Mail Service) - "`singapore
        /// post`" (Singapore Post) - "`pos malaysia`" (Pos Malaysia) - "`postnl`" (PostNL) - "`ptt`" (PTT Turkish Post)
        /// - "`eub`" (ePacket) - "`chukou1`" (Chukou1 Logistics) - "`bestex`" (Best Express) - "`canada post`" (Canada
        /// Post) - "`purolator`" (Purolator) - "`canpar`" (Canpar) - "`india post`" (India Post) - "`blue dart`" (Blue
        /// Dart) - "`delhivery`" (Delhivery) - "`dtdc`" (DTDC) - "`tpc india`" (TPC India) Supported carriers for FR
        /// are: - "`la poste`" (La Poste) automatic status updates - "`colissimo`" (Colissimo by La Poste) automatic
        /// status updates - "`ups`" (United Parcel Service) automatic status updates - "`chronopost`" (Chronopost by La
        /// Poste) - "`gls`" (General Logistics Systems France) - "`dpd`" (DPD Group by GeoPost) - "`bpost`" (Belgian
        /// Post Group) - "`colis prive`" (Colis Privé) - "`boxtal`" (Boxtal) - "`geodis`" (GEODIS) - "`tnt`" (TNT) -
        /// "`db schenker`" (DB Schenker) - "`aramex`" (Aramex)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; } 

        /// <summary>Date on which the shipment has been created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>Date on which the shipment has been delivered, in ISO 8601 format. Present only if `status` is
        /// `delivered`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryDate")]
        public virtual string DeliveryDate { get; set; } 

        /// <summary>The ID of the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The line items that are shipped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<OrderShipmentLineItemShipment> LineItems { get; set; } 

        /// <summary>Delivery details of the shipment if scheduling is needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledDeliveryDetails")]
        public virtual OrderShipmentScheduledDeliveryDetails ScheduledDeliveryDetails { get; set; } 

        /// <summary>The shipment group ID of the shipment. This is set in shiplineitems request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentGroupId")]
        public virtual string ShipmentGroupId { get; set; } 

        /// <summary>The status of the shipment.
        ///
        /// Acceptable values are: - "`delivered`" - "`readyForPickup`" - "`shipped`" - "`undeliverable`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The tracking ID for the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual string TrackingId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderShipmentLineItemShipment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item that is shipped. This value is assigned by Google when an order is created.
        /// Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the product to ship. This is the REST ID used in the products service. Either lineItemId
        /// or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity that is shipped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderShipmentScheduledDeliveryDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The phone number of the carrier fulfilling the delivery. The phone number is formatted as the
        /// international notation in ITU-T Recommendation E.123 (e.g., "+41 44 668 1800").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierPhoneNumber")]
        public virtual string CarrierPhoneNumber { get; set; } 

        /// <summary>The date a shipment is scheduled for delivery, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledDate")]
        public virtual string ScheduledDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCreateChargeInvoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] The ID of the invoice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceId")]
        public virtual string InvoiceId { get; set; } 

        /// <summary>[required] Invoice summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceSummary")]
        public virtual InvoiceSummary InvoiceSummary { get; set; } 

        /// <summary>[required] Invoice details per line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemInvoices")]
        public virtual System.Collections.Generic.IList<ShipmentInvoiceLineItemInvoice> LineItemInvoices { get; set; } 

        /// <summary>[required] The ID of the operation, unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>[required] ID of the shipment group. It is assigned by the merchant in the `shipLineItems` method
        /// and is used to group multiple line items that have the same kind of shipping charges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentGroupId")]
        public virtual string ShipmentGroupId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCreateChargeInvoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderinvoicesCreateChargeInvoiceResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCreateRefundInvoiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] The ID of the invoice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceId")]
        public virtual string InvoiceId { get; set; } 

        /// <summary>[required] The ID of the operation, unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>Option to create a refund-only invoice. Exactly one of `refundOnlyOption` or `returnOption` must be
        /// provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundOnlyOption")]
        public virtual OrderinvoicesCustomBatchRequestEntryCreateRefundInvoiceRefundOption RefundOnlyOption { get; set; } 

        /// <summary>Option to create an invoice for a refund and mark all items within the invoice as returned. Exactly
        /// one of `refundOnlyOption` or `returnOption` must be provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnOption")]
        public virtual OrderinvoicesCustomBatchRequestEntryCreateRefundInvoiceReturnOption ReturnOption { get; set; } 

        /// <summary>Invoice details for different shipment groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentInvoices")]
        public virtual System.Collections.Generic.IList<ShipmentInvoice> ShipmentInvoices { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCreateRefundInvoiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderinvoicesCreateRefundInvoiceResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCustomBatchRequestEntryCreateRefundInvoiceRefundOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional description of the refund reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>[required] Reason for the refund.
        ///
        /// Acceptable values are: - "`adjustment`" - "`autoPostInternal`" - "`autoPostInvalidBillingAddress`" -
        /// "`autoPostNoInventory`" - "`autoPostPriceError`" - "`autoPostUndeliverableShippingAddress`" -
        /// "`couponAbuse`" - "`courtesyAdjustment`" - "`customerCanceled`" - "`customerDiscretionaryReturn`" -
        /// "`customerInitiatedMerchantCancel`" - "`customerSupportRequested`" - "`deliveredLateByCarrier`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`failToPushOrderGoogleError`" - "`failToPushOrderMerchantError`" -
        /// "`failToPushOrderMerchantFulfillmentError`" - "`failToPushOrderToMerchant`" -
        /// "`failToPushOrderToMerchantOutOfStock`" - "`feeAdjustment`" - "`invalidCoupon`" - "`lateShipmentCredit`" -
        /// "`malformedShippingAddress`" - "`merchantDidNotShipOnTime`" - "`noInventory`" - "`orderTimeout`" - "`other`"
        /// - "`paymentAbuse`" - "`paymentDeclined`" - "`priceAdjustment`" - "`priceError`" - "`productArrivedDamaged`"
        /// - "`productNotAsDescribed`" - "`promoReallocation`" - "`qualityNotAsExpected`" - "`returnRefundAbuse`" -
        /// "`shippingCostAdjustment`" - "`shippingPriceError`" - "`taxAdjustment`" - "`taxError`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderinvoicesCustomBatchRequestEntryCreateRefundInvoiceReturnOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional description of the return reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>[required] Reason for the return.
        ///
        /// Acceptable values are: - "`customerDiscretionaryReturn`" - "`customerInitiatedMerchantCancel`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`invalidCoupon`" - "`malformedShippingAddress`" - "`other`" -
        /// "`productArrivedDamaged`" - "`productNotAsDescribed`" - "`qualityNotAsExpected`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreportsListDisbursementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of disbursements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disbursements")]
        public virtual System.Collections.Generic.IList<OrderReportDisbursement> Disbursements { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderreportsListDisbursementsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of disbursements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreportsListTransactionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderreportsListTransactionsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactions")]
        public virtual System.Collections.Generic.IList<OrderReportTransaction> Transactions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] The ID of the operation, unique across all operations for a given order
        /// return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsAcknowledgeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderreturnsAcknowledgeResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderreturnsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<MerchantOrderReturn> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsPartialRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pre-tax or post-tax amount to be refunded, depending on the location of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>Tax amount to be refunded. Note: This has different meaning depending on the location of the
        /// order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsProcessRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Option to charge the customer return shipping cost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullChargeReturnShippingCost")]
        public virtual System.Nullable<bool> FullChargeReturnShippingCost { get; set; } 

        /// <summary>[required] The ID of the operation, unique across all operations for a given order
        /// return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>Refunds for original shipping fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundShippingFee")]
        public virtual OrderreturnsRefundOperation RefundShippingFee { get; set; } 

        /// <summary>The list of items to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnItems")]
        public virtual System.Collections.Generic.IList<OrderreturnsReturnItem> ReturnItems { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#orderreturnsProcessResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsRefundOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, the item will be fully refunded. // Allowed only when payment_type is FOP. Merchant can
        /// choose this refund option to indicate the full remaining amount of corresponding object to be refunded to
        /// the customer via FOP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual System.Nullable<bool> FullRefund { get; set; } 

        /// <summary>If this is set, the item will be partially refunded. Merchant can choose this refund option to
        /// specify the customized amount that to be refunded to the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialRefund")]
        public virtual OrderreturnsPartialRefund PartialRefund { get; set; } 

        /// <summary>The payment way of issuing refund. Default value is ORIGINAL_FOP if not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentType")]
        public virtual string PaymentType { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>Code of the refund reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnRefundReason")]
        public virtual string ReturnRefundReason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsRejectOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason for the return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrderreturnsReturnItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Refunds the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refund")]
        public virtual OrderreturnsRefundOperation Refund { get; set; } 

        /// <summary>Rejects the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reject")]
        public virtual OrderreturnsRejectOperation Reject { get; set; } 

        /// <summary>Unit level ID for the return item. Different units of the same product will have different
        /// IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnItemId")]
        public virtual string ReturnItemId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersAcknowledgeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersAcknowledgeResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersAdvanceTestOrderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersAdvanceTestOrderResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelLineItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item to cancel. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ID of the product to cancel. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity to cancel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the cancellation.
        ///
        /// Acceptable values are: - "`customerInitiatedCancel`" - "`invalidCoupon`" - "`malformedShippingAddress`" -
        /// "`noInventory`" - "`other`" - "`priceError`" - "`shippingPriceError`" - "`taxError`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelLineItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersCancelLineItemResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The reason for the cancellation.
        ///
        /// Acceptable values are: - "`customerInitiatedCancel`" - "`invalidCoupon`" - "`malformedShippingAddress`" -
        /// "`noInventory`" - "`other`" - "`priceError`" - "`shippingPriceError`" - "`taxError`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersCancelResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelTestOrderByCustomerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason for the cancellation.
        ///
        /// Acceptable values are: - "`changedMind`" - "`orderedWrongItem`" - "`other`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCancelTestOrderByCustomerResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersCancelTestOrderByCustomerResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCreateTestOrderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The  CLDR territory code of the country of the test order to create. Affects the currency and
        /// addresses of orders created via `template_name`, or the addresses of orders created via `test_order`.
        ///
        /// Acceptable values are: - "`US`" - "`FR`"  Defaults to `US`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The test order template to use. Specify as an alternative to `testOrder` as a shortcut for
        /// retrieving a template and then creating an order using that template.
        ///
        /// Acceptable values are: - "`template1`" - "`template1a`" - "`template1b`" - "`template2`" -
        /// "`template3`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateName")]
        public virtual string TemplateName { get; set; } 

        /// <summary>The test order to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testOrder")]
        public virtual TestOrder TestOrder { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCreateTestOrderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersCreateTestOrderResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ID of the newly created test order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCreateTestReturnRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returned items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<OrdersCustomBatchRequestEntryCreateTestReturnReturnItem> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCreateTestReturnResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersCreateTestReturnResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ID of the newly created test order return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnId")]
        public virtual string ReturnId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCustomBatchRequestEntryCreateTestReturnReturnItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>Quantity that is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCustomBatchRequestEntryRefundItemItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total amount that is refunded. (e.g. refunding $5 each for 2 products should be done by setting
        /// quantity to 2 and amount to 10$) In case of multiple refunds, this should be the amount you currently want
        /// to refund to the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual MonetaryAmount Amount { get; set; } 

        /// <summary>If true, the full item will be refunded. If this is true, amount should not be provided and will be
        /// ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual System.Nullable<bool> FullRefund { get; set; } 

        /// <summary>The ID of the line item. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the product. This is the REST ID used in the products service. Either lineItemId or
        /// productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The number of products that are refunded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCustomBatchRequestEntryRefundItemShipping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount that is refunded. If this is not the first refund for the shipment, this should be the
        /// newly refunded amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; } 

        /// <summary>If set to true, all shipping costs for the order will be refunded. If this is true, amount should
        /// not be provided and will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual System.Nullable<bool> FullRefund { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersCustomBatchRequestEntryShipLineItemsShipmentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The carrier handling the shipment. See `shipments[].carrier` in the  Orders resource representation
        /// for a list of acceptable values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; } 

        /// <summary>Required. The ID of the shipment. This is assigned by the merchant and is unique to each
        /// shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentId")]
        public virtual string ShipmentId { get; set; } 

        /// <summary>The tracking ID for the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual string TrackingId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersGetByMerchantOrderIdResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersGetByMerchantOrderIdResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The requested order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual Order Order { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersGetTestOrderTemplateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersGetTestOrderTemplateResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The requested test order template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual TestOrder Template { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersInStoreRefundLineItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item to return. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The amount to be refunded. This may be pre-tax or post-tax depending on the location of the order.
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>The ID of the product to return. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity to return and refund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the return.
        ///
        /// Acceptable values are: - "`customerDiscretionaryReturn`" - "`customerInitiatedMerchantCancel`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`invalidCoupon`" - "`malformedShippingAddress`" - "`other`" -
        /// "`productArrivedDamaged`" - "`productNotAsDescribed`" - "`qualityNotAsExpected`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The amount of tax to be refunded. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersInStoreRefundLineItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersInStoreRefundLineItemResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of orders.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Order> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRefundItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The items that are refunded. Either Item or Shipping must be provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<OrdersCustomBatchRequestEntryRefundItemItem> Items { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The reason for the refund.
        ///
        /// Acceptable values are: - "`shippingCostAdjustment`" - "`priceAdjustment`" - "`taxAdjustment`" -
        /// "`feeAdjustment`" - "`courtesyAdjustment`" - "`adjustment`" - "`customerCancelled`" - "`noInventory`" -
        /// "`productNotAsDescribed`" - "`undeliverableShippingAddress`" - "`wrongProductShipped`" -
        /// "`lateShipmentCredit`" - "`deliveredLateByCarrier`" - "`productArrivedDamaged`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The refund on shipping. Optional, but either Item or Shipping must be provided in the
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipping")]
        public virtual OrdersCustomBatchRequestEntryRefundItemShipping Shipping { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRefundItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersRefundItemResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRefundOrderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount that is refunded. If this is not the first refund for the order, this should be the
        /// newly refunded amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual MonetaryAmount Amount { get; set; } 

        /// <summary>If true, the full order will be refunded, including shipping. If this is true, amount should not be
        /// provided and will be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual System.Nullable<bool> FullRefund { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The reason for the refund.
        ///
        /// Acceptable values are: - "`courtesyAdjustment`" - "`other`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRefundOrderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersRefundOrderResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRejectReturnLineItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item to return. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ID of the product to return. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity to return and refund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the return.
        ///
        /// Acceptable values are: - "`damagedOrUsed`" - "`missingComponent`" - "`notEligible`" - "`other`" -
        /// "`outOfReturnWindow`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersRejectReturnLineItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersRejectReturnLineItemResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersReturnRefundLineItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the line item to return. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The amount to be refunded. This may be pre-tax or post-tax depending on the location of the order.
        /// If omitted, refundless return is assumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>The ID of the product to return. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The quantity to return and refund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>The reason for the return.
        ///
        /// Acceptable values are: - "`customerDiscretionaryReturn`" - "`customerInitiatedMerchantCancel`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`invalidCoupon`" - "`malformedShippingAddress`" - "`other`" -
        /// "`productArrivedDamaged`" - "`productNotAsDescribed`" - "`qualityNotAsExpected`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The explanation of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonText")]
        public virtual string ReasonText { get; set; } 

        /// <summary>The amount of tax to be refunded. Optional, but if filled, then priceAmount must be set. Calculated
        /// automatically if not provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersReturnRefundLineItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersReturnRefundLineItemResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersSetLineItemMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<OrderMerchantProvidedAnnotation> Annotations { get; set; } 

        /// <summary>The ID of the line item to set metadata. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ID of the product to set metadata. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersSetLineItemMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersSetLineItemMetadataResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersShipLineItemsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Line items to ship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<OrderShipmentLineItemShipment> LineItems { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>ID of the shipment group. Required for orders that use the orderinvoices service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentGroupId")]
        public virtual string ShipmentGroupId { get; set; } 

        /// <summary>Shipment information. This field is repeated because a single line item can be shipped in several
        /// packages (and have several tracking IDs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentInfos")]
        public virtual System.Collections.Generic.IList<OrdersCustomBatchRequestEntryShipLineItemsShipmentInfo> ShipmentInfos { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersShipLineItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersShipLineItemsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateLineItemShippingDetailsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Updated delivery by date, in ISO 8601 format. If not specified only ship by date is updated.
        ///
        /// Provided date should be within 1 year timeframe and can not be a date in the past.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliverByDate")]
        public virtual string DeliverByDate { get; set; } 

        /// <summary>The ID of the line item to set metadata. Either lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ID of the product to set metadata. This is the REST ID used in the products service. Either
        /// lineItemId or productId is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>Updated ship by date, in ISO 8601 format. If not specified only deliver by date is updated.
        ///
        /// Provided date should be within 1 year timeframe and can not be a date in the past.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipByDate")]
        public virtual string ShipByDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateLineItemShippingDetailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersUpdateLineItemShippingDetailsResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateMerchantOrderIdRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The merchant order id to be assigned to the order. Must be unique per merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantOrderId")]
        public virtual string MerchantOrderId { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateMerchantOrderIdResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersUpdateMerchantOrderIdResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateShipmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The carrier handling the shipment. Not updated if missing. See `shipments[].carrier` in the  Orders
        /// resource representation for a list of acceptable values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; } 

        /// <summary>Date on which the shipment has been delivered, in ISO 8601 format. Optional and can be provided
        /// only if `status` is `delivered`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryDate")]
        public virtual string DeliveryDate { get; set; } 

        /// <summary>Date after which the pickup will expire, in ISO 8601 format. Required only when order is buy-
        /// online-pickup-in-store(BOPIS) and `status` is `ready for pickup`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPickupDate")]
        public virtual string LastPickupDate { get; set; } 

        /// <summary>The ID of the operation. Unique across all operations for a given order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; } 

        /// <summary>Date on which the shipment has been ready for pickup, in ISO 8601 format. Optional and can be
        /// provided only if `status` is `ready for pickup`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readyPickupDate")]
        public virtual string ReadyPickupDate { get; set; } 

        /// <summary>The ID of the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentId")]
        public virtual string ShipmentId { get; set; } 

        /// <summary>New status for the shipment. Not updated if missing.
        ///
        /// Acceptable values are: - "`delivered`" - "`undeliverable`" - "`readyForPickup`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The tracking ID for the shipment. Not updated if missing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual string TrackingId { get; set; } 

        /// <summary>Date on which the shipment has been undeliverable, in ISO 8601 format. Optional and can be provided
        /// only if `status` is `undeliverable`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeliveredDate")]
        public virtual string UndeliveredDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class OrdersUpdateShipmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the execution.
        ///
        /// Acceptable values are: - "`duplicate`" - "`executed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStatus")]
        public virtual string ExecutionStatus { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#ordersUpdateShipmentResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PickupCarrierService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the pickup carrier (e.g., `"UPS"`). Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierName")]
        public virtual string CarrierName { get; set; } 

        /// <summary>The name of the pickup service (e.g., `"Access point"`). Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PickupServicesPickupService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the carrier (e.g., `"UPS"`). Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierName")]
        public virtual string CarrierName { get; set; } 

        /// <summary>The CLDR country code of the carrier (e.g., "US"). Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The name of the pickup service (e.g., `"Access point"`). Always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<PosCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The inventory to submit. Set this only if the method is `inventory`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventory")]
        public virtual PosInventory Inventory { get; set; } 

        /// <summary>The ID of the POS data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`delete`" - "`get`" - "`insert`" - "`inventory`" - "`sale`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The sale information to submit. Set this only if the method is `sale`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sale")]
        public virtual PosSale Sale { get; set; } 

        /// <summary>The store information to submit. Set this only if the method is `insert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("store")]
        public virtual PosStore Store { get; set; } 

        /// <summary>The store code. Set this only if the method is `delete` or `get`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>The ID of the account for which to get/submit data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetMerchantId")]
        public virtual System.Nullable<ulong> TargetMerchantId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<PosCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#posCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry to which this entry responds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if, and only if, the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>The updated inventory information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventory")]
        public virtual PosInventory Inventory { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#posCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The updated sale information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sale")]
        public virtual PosSale Sale { get; set; } 

        /// <summary>The retrieved or updated store information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("store")]
        public virtual PosStore Store { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosDataProviders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Country code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>A list of POS data providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posDataProviders")]
        public virtual System.Collections.Generic.IList<PosDataProvidersPosDataProvider> PosDataProvidersValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosDataProvidersPosDataProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of Pos data Provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The full name of this POS data Provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; } 

        /// <summary>The ID of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerId")]
        public virtual System.Nullable<ulong> ProviderId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The absolute quantity of an item available at the given store.</summary>
    public class PosInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#posInventory`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The current price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosInventoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Required. The current price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosInventoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#posInventoryResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The current price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#posListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<PosStore> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The change of the available quantity of an item at the given store.</summary>
    public class PosSale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#posSale`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The relative change of the available quantity. Negative for items returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>A unique ID to group items from the same sale event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saleId")]
        public virtual string SaleId { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosSaleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Required. The price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The relative change of the available quantity. Negative for items returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>A unique ID to group items from the same sale event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saleId")]
        public virtual string SaleId { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PosSaleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. A unique identifier for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#posSaleResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The relative change of the available quantity. Negative for items returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; } 

        /// <summary>A unique ID to group items from the same sale event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saleId")]
        public virtual string SaleId { get; set; } 

        /// <summary>Required. The identifier of the merchant's store. Either a `storeCode` inserted via the API or the
        /// code of the store in Google My Business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The inventory timestamp, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string Timestamp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Store resource.</summary>
    public class PosStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#posStore`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The street address of the store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeAddress")]
        public virtual string StoreAddress { get; set; } 

        /// <summary>Required. A store identifier that is unique for the given merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PostalCodeGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CLDR territory code of the country the postal code group applies to. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The name of the postal code group, referred to in headers. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>A range of postal codes. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeRanges")]
        public virtual System.Collections.Generic.IList<PostalCodeRange> PostalCodeRanges { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PostalCodeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A postal code or a pattern of the form `prefix*` denoting the inclusive lower bound of the range
        /// defining the area. Examples values: `"94108"`, `"9410*"`, `"9*"`. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeRangeBegin")]
        public virtual string PostalCodeRangeBegin { get; set; } 

        /// <summary>A postal code or a pattern of the form `prefix*` denoting the inclusive upper bound of the range
        /// defining the area. It must have the same length as `postalCodeRangeBegin`: if `postalCodeRangeBegin` is a
        /// postal code then `postalCodeRangeEnd` must be a postal code too; if `postalCodeRangeBegin` is a pattern then
        /// `postalCodeRangeEnd` must be a pattern with the same prefix length. Optional: if not set, then the area is
        /// defined as being all the postal codes matching `postalCodeRangeBegin`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeRangeEnd")]
        public virtual string PostalCodeRangeEnd { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The currency of the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; } 

        /// <summary>The price represented as a number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Required product attributes are primarily defined by the products data specification. See the  Products
    /// Data Specification Help Center article for information.
    ///
    /// Some attributes are country-specific, so make sure you select the appropriate country in the drop-down selector
    /// at the top of the page.
    ///
    /// Product data. After inserting, updating, or deleting a product, it may take several minutes before changes take
    /// effect.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional URLs of images of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalImageLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalImageLinks { get; set; } 

        /// <summary>Used to group items in an arbitrary way. Only for CPA%, discouraged otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsGrouping")]
        public virtual string AdsGrouping { get; set; } 

        /// <summary>Similar to ads_grouping, but only works on CPC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsLabels")]
        public virtual System.Collections.Generic.IList<string> AdsLabels { get; set; } 

        /// <summary>Allows advertisers to override the item URL when the product is shown within the context of Product
        /// Ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsRedirect")]
        public virtual string AdsRedirect { get; set; } 

        /// <summary>Set to true if the item is targeted towards adults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual System.Nullable<bool> Adult { get; set; } 

        /// <summary>Target age group of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageGroup")]
        public virtual string AgeGroup { get; set; } 

        /// <summary>Availability status of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; } 

        /// <summary>The day a pre-ordered product becomes available for delivery, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityDate")]
        public virtual string AvailabilityDate { get; set; } 

        /// <summary>Brand of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>URL for the canonical version of your item's landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalLink")]
        public virtual string CanonicalLink { get; set; } 

        /// <summary>Required. The item's channel (online or local).
        ///
        /// Acceptable values are: - "`local`" - "`online`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; } 

        /// <summary>Color of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; } 

        /// <summary>Condition or state of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Cost of goods sold. Used for gross profit reporting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costOfGoodsSold")]
        public virtual Price CostOfGoodsSold { get; set; } 

        /// <summary>A list of custom (merchant-provided) attributes. It can also be used for submitting any attribute
        /// of the feed specification in its generic form (e.g., `{ "name": "size type", "value": "regular" }`). This is
        /// useful for submitting attributes not explicitly exposed by the API, such as additional attributes used for
        /// Shopping Actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; } 

        /// <summary>Custom label 0 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel0")]
        public virtual string CustomLabel0 { get; set; } 

        /// <summary>Custom label 1 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel1")]
        public virtual string CustomLabel1 { get; set; } 

        /// <summary>Custom label 2 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel2")]
        public virtual string CustomLabel2 { get; set; } 

        /// <summary>Custom label 3 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel3")]
        public virtual string CustomLabel3 { get; set; } 

        /// <summary>Custom label 4 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel4")]
        public virtual string CustomLabel4 { get; set; } 

        /// <summary>Description of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>An identifier for an item for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsId")]
        public virtual string DisplayAdsId { get; set; } 

        /// <summary>URL directly to your item's landing page for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsLink")]
        public virtual string DisplayAdsLink { get; set; } 

        /// <summary>Advertiser-specified recommendations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsSimilarIds")]
        public virtual System.Collections.Generic.IList<string> DisplayAdsSimilarIds { get; set; } 

        /// <summary>Title of an item for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsTitle")]
        public virtual string DisplayAdsTitle { get; set; } 

        /// <summary>Offer margin for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsValue")]
        public virtual System.Nullable<double> DisplayAdsValue { get; set; } 

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficiencyClass")]
        public virtual string EnergyEfficiencyClass { get; set; } 

        /// <summary>The list of destinations to exclude for this target (corresponds to unchecked check boxes in
        /// Merchant Center).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDestinations")]
        public virtual System.Collections.Generic.IList<string> ExcludedDestinations { get; set; } 

        /// <summary>Date on which the item should expire, as specified upon insertion, in ISO 8601 format. The actual
        /// expiration date in Google Shopping is exposed in `productstatuses` as `googleExpirationDate` and might be
        /// earlier if `expirationDate` is too far in the future.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationDate")]
        public virtual string ExpirationDate { get; set; } 

        /// <summary>Target gender of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; } 

        /// <summary>Google's category of the item (see Google product taxonomy).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleProductCategory")]
        public virtual string GoogleProductCategory { get; set; } 

        /// <summary>Global Trade Item Number (GTIN) of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>The REST ID of the product. Content API methods that operate on products take this as their
        /// `productId` parameter. The REST ID for a product is of the form channel:contentLanguage:targetCountry:
        /// offerId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>False when the item does not have unique product identifiers appropriate to its category, such as
        /// GTIN, MPN, and brand. Required according to the Unique Product Identifier Rules for all target countries
        /// except for Canada.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifierExists")]
        public virtual System.Nullable<bool> IdentifierExists { get; set; } 

        /// <summary>URL of an image of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLink")]
        public virtual string ImageLink { get; set; } 

        /// <summary>The list of destinations to include for this target (corresponds to checked check boxes in Merchant
        /// Center). Default destinations are always included unless provided in `excludedDestinations`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDestinations")]
        public virtual System.Collections.Generic.IList<string> IncludedDestinations { get; set; } 

        /// <summary>Number and amount of installments to pay for an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installment")]
        public virtual Installment Installment { get; set; } 

        /// <summary>Whether the item is a merchant-defined bundle. A bundle is a custom grouping of different products
        /// sold by a merchant for a single price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isBundle")]
        public virtual System.Nullable<bool> IsBundle { get; set; } 

        /// <summary>Shared identifier for all variants of the same product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#product`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>URL directly linking to your item's page on your website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; } 

        /// <summary>Loyalty points that users receive after purchasing the item. Japan only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPoints")]
        public virtual LoyaltyPoints LoyaltyPoints { get; set; } 

        /// <summary>The material of which the item is made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("material")]
        public virtual string Material { get; set; } 

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEnergyEfficiencyClass")]
        public virtual string MaxEnergyEfficiencyClass { get; set; } 

        /// <summary>Maximal product handling time (in business days).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxHandlingTime")]
        public virtual System.Nullable<long> MaxHandlingTime { get; set; } 

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minEnergyEfficiencyClass")]
        public virtual string MinEnergyEfficiencyClass { get; set; } 

        /// <summary>Minimal product handling time (in business days).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHandlingTime")]
        public virtual System.Nullable<long> MinHandlingTime { get; set; } 

        /// <summary>URL for the mobile-optimized version of your item's landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileLink")]
        public virtual string MobileLink { get; set; } 

        /// <summary>Manufacturer Part Number (MPN) of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; } 

        /// <summary>The number of identical products in a merchant-defined multipack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipack")]
        public virtual System.Nullable<long> Multipack { get; set; } 

        /// <summary>Required. A unique identifier for the item. Leading and trailing whitespaces are stripped and
        /// multiple whitespaces are replaced by a single whitespace upon submission. Only valid unicode characters are
        /// accepted. See the products feed specification for details. Note: Content API methods that operate on
        /// products take the REST ID of the product, not this identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; } 

        /// <summary>The item's pattern (e.g. polka dots).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; } 

        /// <summary>Price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Technical specification or additional product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<ProductProductDetail> ProductDetails { get; set; } 

        /// <summary>Bullet points describing the most relevant highlights of a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productHighlights")]
        public virtual System.Collections.Generic.IList<string> ProductHighlights { get; set; } 

        /// <summary>Categories of the item (formatted as in products data specification).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypes")]
        public virtual System.Collections.Generic.IList<string> ProductTypes { get; set; } 

        /// <summary>The unique ID of a promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionIds")]
        public virtual System.Collections.Generic.IList<string> PromotionIds { get; set; } 

        /// <summary>Advertised sale price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; } 

        /// <summary>Date range during which the item is on sale (see products data specification).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual string SalePriceEffectiveDate { get; set; } 

        /// <summary>The quantity of the product that is available for selling on Google. Supported only for online
        /// products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellOnGoogleQuantity")]
        public virtual System.Nullable<long> SellOnGoogleQuantity { get; set; } 

        /// <summary>Shipping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipping")]
        public virtual System.Collections.Generic.IList<ProductShipping> Shipping { get; set; } 

        /// <summary>Height of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingHeight")]
        public virtual ProductShippingDimension ShippingHeight { get; set; } 

        /// <summary>The shipping label of the product, used to group product in account-level shipping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLabel")]
        public virtual string ShippingLabel { get; set; } 

        /// <summary>Length of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLength")]
        public virtual ProductShippingDimension ShippingLength { get; set; } 

        /// <summary>Weight of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingWeight")]
        public virtual ProductShippingWeight ShippingWeight { get; set; } 

        /// <summary>Width of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingWidth")]
        public virtual ProductShippingDimension ShippingWidth { get; set; } 

        /// <summary>List of country codes (ISO 3166-1 alpha-2) to exclude the offer from Shopping Ads destination.
        /// Countries from this list are removed from countries configured in MC feed settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shoppingAdsExcludedCountries")]
        public virtual System.Collections.Generic.IList<string> ShoppingAdsExcludedCountries { get; set; } 

        /// <summary>System in which the size is specified. Recommended for apparel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeSystem")]
        public virtual string SizeSystem { get; set; } 

        /// <summary>The cut of the item. Recommended for apparel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeType")]
        public virtual string SizeType { get; set; } 

        /// <summary>Size of the item. Only one value is allowed. For variants with different sizes, insert a separate
        /// product for each size with the same `itemGroupId` value (see size definition).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizes")]
        public virtual System.Collections.Generic.IList<string> Sizes { get; set; } 

        /// <summary>The source of the offer, i.e., how the offer was created.
        ///
        /// Acceptable values are: - "`api`" - "`crawl`" - "`feed`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>Number of periods (months or years) and amount of payment per period for an item with an associated
        /// subscription contract.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionCost")]
        public virtual ProductSubscriptionCost SubscriptionCost { get; set; } 

        /// <summary>Required. The CLDR territory code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>The tax category of the product, used to configure detailed tax nexus in account-level tax
        /// settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxCategory")]
        public virtual string TaxCategory { get; set; } 

        /// <summary>Tax information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxes")]
        public virtual System.Collections.Generic.IList<ProductTax> Taxes { get; set; } 

        /// <summary>Title of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The transit time label of the product, used to group product in account-level transit time
        /// tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeLabel")]
        public virtual string TransitTimeLabel { get; set; } 

        /// <summary>The preference of the denominator of the unit price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPricingBaseMeasure")]
        public virtual ProductUnitPricingBaseMeasure UnitPricingBaseMeasure { get; set; } 

        /// <summary>The measure and dimension of an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPricingMeasure")]
        public virtual ProductUnitPricingMeasure UnitPricingMeasure { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductAmount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pre-tax or post-tax price depending on the location of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmount")]
        public virtual Price PriceAmount { get; set; } 

        /// <summary>Remitted tax value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remittedTaxAmount")]
        public virtual Price RemittedTaxAmount { get; set; } 

        /// <summary>Tax value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeName")]
        public virtual string AttributeName { get; set; } 

        /// <summary>The value of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeValue")]
        public virtual string AttributeValue { get; set; } 

        /// <summary>The section header used to group a set of product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionName")]
        public virtual string SectionName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductShipping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CLDR territory code of the country to which an item will ship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The location where the shipping is applicable, represented by a location group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationGroupName")]
        public virtual string LocationGroupName { get; set; } 

        /// <summary>The numeric ID of a location that the shipping rate applies to as defined in the AdWords
        /// API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual System.Nullable<long> LocationId { get; set; } 

        /// <summary>The postal code range that the shipping rate applies to, represented by a postal code, a postal
        /// code prefix followed by a * wildcard, a range between two postal codes or two postal code prefixes of equal
        /// length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Fixed shipping price, represented as a number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>The geographic region to which a shipping rate applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>A free-form description of the service class or delivery speed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductShippingDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>The dimension of the product used to calculate the shipping cost of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductShippingWeight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>The weight of the product used to calculate the shipping cost of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The status of a product, i.e., information about a product computed asynchronously.</summary>
    public class ProductStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date on which the item has been created, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>The intended destinations for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<ProductStatusDestinationStatus> DestinationStatuses { get; set; } 

        /// <summary>Date on which the item expires in Google Shopping, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleExpirationDate")]
        public virtual string GoogleExpirationDate { get; set; } 

        /// <summary>A list of all issues associated with the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ProductStatusItemLevelIssue> ItemLevelIssues { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#productStatus`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Date on which the item has been last updated, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateDate")]
        public virtual string LastUpdateDate { get; set; } 

        /// <summary>The link to the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; } 

        /// <summary>The ID of the product for which status is reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductStatusDestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvedCountries")]
        public virtual System.Collections.Generic.IList<string> ApprovedCountries { get; set; } 

        /// <summary>The name of the destination</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; } 

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is disapproved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovedCountries")]
        public virtual System.Collections.Generic.IList<string> DisapprovedCountries { get; set; } 

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is pending approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCountries")]
        public virtual System.Collections.Generic.IList<string> PendingCountries { get; set; } 

        /// <summary>Destination approval status in `targetCountry` of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductStatusItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where issue applies to the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableCountries")]
        public virtual System.Collections.Generic.IList<string> ApplicableCountries { get; set; } 

        /// <summary>The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeName")]
        public virtual string AttributeName { get; set; } 

        /// <summary>The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; } 

        /// <summary>A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The destination the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; } 

        /// <summary>A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; } 

        /// <summary>The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; } 

        /// <summary>Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; } 

        /// <summary>How this issue affects serving of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servability")]
        public virtual string Servability { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductSubscriptionCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per subscription period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; } 

        /// <summary>The type of subscription period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual string Period { get; set; } 

        /// <summary>The number of subscription periods the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodLength")]
        public virtual System.Nullable<long> PeriodLength { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductTax : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country within which the item is taxed, specified as a CLDR territory code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>The numeric ID of a location that the tax rate applies to as defined in the AdWords API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual System.Nullable<long> LocationId { get; set; } 

        /// <summary>The postal code range that the tax rate applies to, represented by a ZIP code, a ZIP code prefix
        /// using * wildcard, a range between two ZIP codes or two ZIP code prefixes of equal length. Examples: 94114,
        /// 94*, 94002-95460, 94*-95*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>The percentage of tax rate that applies to the item price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual System.Nullable<double> Rate { get; set; } 

        /// <summary>The geographic region to which the tax rate applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Set to true if tax is charged on shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxShip")]
        public virtual System.Nullable<bool> TaxShip { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductUnitPricingBaseMeasure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of the denominator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>The denominator of the unit price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductUnitPricingMeasure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of the measure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>The measure of an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductsCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ProductsCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch products request.</summary>
    public class ProductsCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The Content API feed id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedId")]
        public virtual System.Nullable<ulong> FeedId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`delete`" - "`get`" - "`insert`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The product to insert. Only required if the method is `insert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; } 

        /// <summary>The ID of the product to get or delete. Only defined if the method is `get` or `delete`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductsCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ProductsCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#productsCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch products response.</summary>
    public class ProductsCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#productsCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The inserted product. Only defined if the method is `insert` and if the request was
        /// successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#productsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Product> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductstatusesCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ProductstatusesCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch productstatuses request.</summary>
    public class ProductstatusesCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>If set, only issues for the specified destinations are returned, otherwise only issues for the
        /// Shopping destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<string> Destinations { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("includeAttributes")]
        public virtual System.Nullable<bool> IncludeAttributes { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ID of the product whose status to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductstatusesCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ProductstatusesCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#productstatusesCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch productstatuses response.</summary>
    public class ProductstatusesCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors, if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#productstatusesCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The requested product status. Only defined if the request was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productStatus")]
        public virtual ProductStatus ProductStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ProductstatusesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#productstatusesListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of products statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ProductStatus> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings for Pub/Sub notifications, all methods require that the caller is a direct user of the
    /// merchant center account. (== resource_for v2.1.pubsubnotificationsettings ==)</summary>
    public class PubsubNotificationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud pub/sub topic to which notifications are sent (read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudTopicName")]
        public virtual string CloudTopicName { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#pubsubNotificationSettings`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of event types.
        ///
        /// Acceptable values are: - "`orderPendingShipment`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registeredEvents")]
        public virtual System.Collections.Generic.IList<string> RegisteredEvents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class RateGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of shipping labels defining the products to which this rate group applies to. This is a
        /// disjunction: only one of the labels has to match for the rate group to apply. May only be empty for the last
        /// rate group of a service. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableShippingLabels")]
        public virtual System.Collections.Generic.IList<string> ApplicableShippingLabels { get; set; } 

        /// <summary>A list of carrier rates that can be referred to by `mainTable` or `singleValue`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRates")]
        public virtual System.Collections.Generic.IList<CarrierRate> CarrierRates { get; set; } 

        /// <summary>A table defining the rate group, when `singleValue` is not expressive enough. Can only be set if
        /// `singleValue` is not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainTable")]
        public virtual Table MainTable { get; set; } 

        /// <summary>Name of the rate group. Optional. If set has to be unique within shipping service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The value of the rate group (e.g. flat rate $10). Can only be set if `mainTable` and `subtables`
        /// are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleValue")]
        public virtual Value SingleValue { get; set; } 

        /// <summary>A list of subtables referred to by `mainTable`. Can only be set if `mainTable` is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtables")]
        public virtual System.Collections.Generic.IList<Table> Subtables { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class RefundReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Code of the refund reason.
        ///
        /// Acceptable values are: - "`adjustment`" - "`autoPostInternal`" - "`autoPostInvalidBillingAddress`" -
        /// "`autoPostNoInventory`" - "`autoPostPriceError`" - "`autoPostUndeliverableShippingAddress`" -
        /// "`couponAbuse`" - "`courtesyAdjustment`" - "`customerCanceled`" - "`customerDiscretionaryReturn`" -
        /// "`customerInitiatedMerchantCancel`" - "`customerSupportRequested`" - "`deliveredLateByCarrier`" -
        /// "`deliveredTooLate`" - "`expiredItem`" - "`failToPushOrderGoogleError`" - "`failToPushOrderMerchantError`" -
        /// "`failToPushOrderMerchantFulfillmentError`" - "`failToPushOrderToMerchant`" -
        /// "`failToPushOrderToMerchantOutOfStock`" - "`feeAdjustment`" - "`invalidCoupon`" - "`lateShipmentCredit`" -
        /// "`malformedShippingAddress`" - "`merchantDidNotShipOnTime`" - "`noInventory`" - "`orderTimeout`" - "`other`"
        /// - "`paymentAbuse`" - "`paymentDeclined`" - "`priceAdjustment`" - "`priceError`" - "`productArrivedDamaged`"
        /// - "`productNotAsDescribed`" - "`promoReallocation`" - "`qualityNotAsExpected`" - "`returnRefundAbuse`" -
        /// "`shippingCostAdjustment`" - "`shippingPriceError`" - "`taxAdjustment`" - "`taxError`" -
        /// "`undeliverableShippingAddress`" - "`unsupportedPoBoxAddress`" - "`wrongProductShipped`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonCode")]
        public virtual string ReasonCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Regional inventory resource. contains the regional name and all attributes which are overridden for the
    /// specified region.</summary>
    public class RegionalInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The availability of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; } 

        /// <summary>A list of custom (merchant-provided) attributes. It can also be used for submitting any attribute
        /// of the feed specification in its generic form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#regionalInventory".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>The ID uniquely identifying each region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionId")]
        public virtual string RegionId { get; set; } 

        /// <summary>The sale price of the product. Mandatory if `sale_price_effective_date` is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; } 

        /// <summary>A date range represented by a pair of ISO 8601 dates separated by a space, comma, or slash. Both
        /// dates might be specified as 'null' if undecided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual string SalePriceEffectiveDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class RegionalinventoryCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<RegionalinventoryCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch regional inventory request.</summary>
    public class RegionalinventoryCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Method of the batch request entry.
        ///
        /// Acceptable values are: - "`insert`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The ID of the product for which to update price and availability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>Price and availability of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalInventory")]
        public virtual RegionalInventory RegionalInventory { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class RegionalinventoryCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<RegionalinventoryCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#regionalinventoryCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch regional inventory response.</summary>
    public class RegionalinventoryCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry this entry responds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if and only if the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#regionalinventoryCustomBatchResponseEntry".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Price and availability of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalInventory")]
        public virtual RegionalInventory RegionalInventory { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Return address resource.</summary>
    public class ReturnAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual ReturnAddressAddress Address { get; set; } 

        /// <summary>Required. The country of sale where the return address is applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#returnAddress`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The user-defined label of the return address. For the default address, use the label
        /// "default".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; } 

        /// <summary>Required. The merchant's contact phone number regarding the return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>Return address ID generated by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnAddressId")]
        public virtual string ReturnAddressId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnAddressAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CLDR country code (e.g. "US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods
        /// or suburbs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Postal code or ZIP (e.g. "94043").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Name of the recipient to address returns to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientName")]
        public virtual string RecipientName { get; set; } 

        /// <summary>Top-level administrative subdivision of the country. For example, a state like California ("CA") or
        /// a province like Quebec ("QC").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Street-level part of the address. May be up to two lines, each line specified as an array
        /// element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual System.Collections.Generic.IList<string> StreetAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Return policy resource.</summary>
    public class ReturnPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The country of sale where the return policy is applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#returnPolicy`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. The user-defined label of the return policy. For the default policy, use the label
        /// "default".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; } 

        /// <summary>Required. The name of the policy as shown in Merchant Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Return reasons that will incur return fees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonFreeReturnReasons")]
        public virtual System.Collections.Generic.IList<string> NonFreeReturnReasons { get; set; } 

        /// <summary>Required. The policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual ReturnPolicyPolicy Policy { get; set; } 

        /// <summary>Return policy ID generated by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicyId")]
        public virtual string ReturnPolicyId { get; set; } 

        /// <summary>An optional list of seasonal overrides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalOverrides")]
        public virtual System.Collections.Generic.IList<ReturnPolicySeasonalOverride> SeasonalOverrides { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnPolicyPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Last day for returning the items. In ISO 8601 format. When specifying the return window
        /// like this, set the policy type to "lastReturnDate". Use this for seasonal overrides only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastReturnDate")]
        public virtual string LastReturnDate { get; set; } 

        /// <summary>The number of days items can be returned after delivery, where one day is defined to be 24 hours
        /// after the delivery timestamp. When specifying the return window like this, set the policy type to
        /// "numberOfDaysAfterDelivery". Acceptable values are 30, 45, 60, 90, 100, 180, 270 and 365 for the default
        /// policy. Additional policies further allow 14, 15, 21 and 28 days, but note that for most items a minimum of
        /// 30 days is required for returns. Exceptions may be made for electronics. A policy of less than 30 days can
        /// only be applied to those items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfDays")]
        public virtual System.Nullable<long> NumberOfDays { get; set; } 

        /// <summary>Policy type. Use "lastReturnDate" for seasonal overrides only. Note that for most items a minimum
        /// of 30 days is required for returns. Exceptions may be made for electronics or non-returnable items such as
        /// food, perishables, and living things. A policy of less than 30 days can only be applied to those items.
        ///
        /// Acceptable values are: - "`lastReturnDate`" - "`lifetimeReturns`" - "`noReturns`" -
        /// "`numberOfDaysAfterDelivery`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnPolicySeasonalOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Last day on which the override applies. In ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; } 

        /// <summary>Required. The name of the seasonal override as shown in Merchant Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The policy which is in effect during that time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual ReturnPolicyPolicy Policy { get; set; } 

        /// <summary>Required. First day on which the override applies. In ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnPricingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default option for whether merchant should charge the customer for return shipping costs, based on
        /// customer selected return reason and merchant's return policy for the items being returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargeReturnShippingFee")]
        public virtual System.Nullable<bool> ChargeReturnShippingFee { get; set; } 

        /// <summary>Maximum return shipping costs that may be charged to the customer depending on merchant's
        /// assessment of the return reason and the merchant's return policy for the items being returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReturnShippingFee")]
        public virtual MonetaryAmount MaxReturnShippingFee { get; set; } 

        /// <summary>Total amount that can be refunded for the items in this return. It represents the total amount
        /// received by the merchant for the items, after applying merchant coupons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundableItemsTotalAmount")]
        public virtual MonetaryAmount RefundableItemsTotalAmount { get; set; } 

        /// <summary>Maximum amount that can be refunded for the original shipping fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundableShippingAmount")]
        public virtual MonetaryAmount RefundableShippingAmount { get; set; } 

        /// <summary>Total amount already refunded by the merchant. It includes all types of refunds (items, shipping,
        /// etc.) Not provided if no refund has been applied yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRefundedAmount")]
        public virtual MonetaryAmount TotalRefundedAmount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnShipment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date of creation of the shipment, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDate { get; set; } 

        /// <summary>The date of delivery of the shipment, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryDate")]
        public virtual string DeliveryDate { get; set; } 

        /// <summary>Type of the return method.
        ///
        /// Acceptable values are: - "`byMail`" - "`contactCustomerSupport`" - "`returnless`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnMethodType")]
        public virtual string ReturnMethodType { get; set; } 

        /// <summary>Shipment ID generated by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentId")]
        public virtual string ShipmentId { get; set; } 

        /// <summary>Tracking information of the shipment. One return shipment might be handled by several shipping
        /// carriers sequentially.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentTrackingInfos")]
        public virtual System.Collections.Generic.IList<ShipmentTrackingInfo> ShipmentTrackingInfos { get; set; } 

        /// <summary>The date of shipping of the shipment, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingDate")]
        public virtual string ShippingDate { get; set; } 

        /// <summary>State of the shipment.
        ///
        /// Acceptable values are: - "`completed`" - "`new`" - "`shipped`" - "`undeliverable`" - "`pending`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnaddressCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ReturnaddressCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnaddressCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The Merchant Center account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Method of the batch request entry.
        ///
        /// Acceptable values are: - "`delete`" - "`get`" - "`insert`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The return address to submit. Set this only if the method is `insert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnAddress")]
        public virtual ReturnAddress ReturnAddress { get; set; } 

        /// <summary>The return address ID. Set this only if the method is `delete` or `get`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnAddressId")]
        public virtual string ReturnAddressId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnaddressCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ReturnaddressCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#returnaddressCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnaddressCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry to which this entry responds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if, and only if, the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#returnaddressCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The retrieved return address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnAddress")]
        public virtual ReturnAddress ReturnAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnaddressListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#returnaddressListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ReturnAddress> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnpolicyCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ReturnpolicyCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnpolicyCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The Merchant Center account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>Method of the batch request entry.
        ///
        /// Acceptable values are: - "`delete`" - "`get`" - "`insert`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The return policy to submit. Set this only if the method is `insert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicy")]
        public virtual ReturnPolicy ReturnPolicy { get; set; } 

        /// <summary>The return policy ID. Set this only if the method is `delete` or `get`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicyId")]
        public virtual string ReturnPolicyId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnpolicyCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ReturnpolicyCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#returnpolicyCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnpolicyCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry to which this entry responds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if, and only if, the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#returnpolicyCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The retrieved return policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicy")]
        public virtual ReturnPolicy ReturnPolicy { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ReturnpolicyListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#returnpolicyListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ReturnPolicy> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of cells that constitute the row. Must have the same length as `columnHeaders` for two-
        /// dimensional tables, a length of 1 for one-dimensional tables. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<Value> Cells { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean exposing the active status of the shipping service. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; } 

        /// <summary>The CLDR code of the currency to which this service applies. Must match that of the prices in rate
        /// groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; } 

        /// <summary>The CLDR territory code of the country to which the service applies. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryCountry")]
        public virtual string DeliveryCountry { get; set; } 

        /// <summary>Time spent in various aspects from order to the delivery of the product. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryTime")]
        public virtual DeliveryTime DeliveryTime { get; set; } 

        /// <summary>Eligibility for this service.
        ///
        /// Acceptable values are: - "`All scenarios`" - "`All scenarios except Shopping Actions`" - "`Shopping
        /// Actions`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibility")]
        public virtual string Eligibility { get; set; } 

        /// <summary>Minimum order value for this service. If set, indicates that customers will have to spend at least
        /// this amount. All prices within a service must have the same currency. Cannot be set together with
        /// minimum_order_value_table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumOrderValue")]
        public virtual Price MinimumOrderValue { get; set; } 

        /// <summary>Table of per store minimum order values for the pickup fulfillment type. Cannot be set together
        /// with minimum_order_value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumOrderValueTable")]
        public virtual MinimumOrderValueTable MinimumOrderValueTable { get; set; } 

        /// <summary>Free-form name of the service. Must be unique within target account. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The carrier-service pair delivering items to collection points. The list of supported pickup
        /// services can be retrieved via the `getSupportedPickupServices` method. Required if and only if the service
        /// delivery type is `pickup`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupService")]
        public virtual PickupCarrierService PickupService { get; set; } 

        /// <summary>Shipping rate group definitions. Only the last one is allowed to have an empty
        /// `applicableShippingLabels`, which means "everything else". The other `applicableShippingLabels` must not
        /// overlap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateGroups")]
        public virtual System.Collections.Generic.IList<RateGroup> RateGroups { get; set; } 

        /// <summary>Type of locations this service ships orders to.
        ///
        /// Acceptable values are: - "`delivery`" - "`pickup`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentType")]
        public virtual string ShipmentType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settlement reports detail order-level and item-level credits and debits between you and
    /// Google.</summary>
    public class SettlementReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end date on which all transactions are included in the report, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#settlementReport`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The residual amount from the previous invoice. This is set only if the previous invoices are not
        /// paid because of negative balance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousBalance")]
        public virtual Price PreviousBalance { get; set; } 

        /// <summary>The ID of the settlement report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settlementId")]
        public virtual string SettlementId { get; set; } 

        /// <summary>The start date on which all transactions are included in the report, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; } 

        /// <summary>The money due to the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferAmount")]
        public virtual Price TransferAmount { get; set; } 

        /// <summary>Date on which transfer for this payment was initiated by Google, in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferDate")]
        public virtual string TransferDate { get; set; } 

        /// <summary>The list of bank identifiers used for the transfer. e.g. Trace ID for Federal Automated Clearing
        /// House (ACH). This may also be known as the Wire ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferIds")]
        public virtual System.Collections.Generic.IList<string> TransferIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settlement transactions give a detailed breakdown of the  settlement report. (== resource_for
    /// v2.1.settlementtransactions ==)</summary>
    public class SettlementTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount for the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual SettlementTransactionAmount Amount { get; set; } 

        /// <summary>Identifiers of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifiers")]
        public virtual SettlementTransactionIdentifiers Identifiers { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#settlementTransaction`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Details of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual SettlementTransactionTransaction Transaction { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementTransactionAmount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commission")]
        public virtual SettlementTransactionAmountCommission Commission { get; set; } 

        /// <summary>The description of the event.
        ///
        /// Acceptable values are: - "`taxWithhold`" - "`principal`" - "`principalAdjustment`" - "`shippingFee`" -
        /// "`merchantRemittedSalesTax`" - "`googleRemittedSalesTax`" - "`merchantCoupon`" - "`merchantCouponTax`" -
        /// "`merchantRemittedDisposalTax`" - "`googleRemittedDisposalTax`" - "`merchantRemittedRedemptionFee`" -
        /// "`googleRemittedRedemptionFee`" - "`eeeEcoFee`" - "`furnitureEcoFee`" - "`copyPrivateFee`" -
        /// "`eeeEcoFeeCommission`" - "`furnitureEcoFeeCommission`" - "`copyPrivateFeeCommission`" - "`principalRefund`"
        /// - "`principalRefundTax`" - "`itemCommission`" - "`adjustmentCommission`" - "`shippingFeeCommission`" -
        /// "`commissionRefund`" - "`damaged`" - "`damagedOrDefectiveItem`" - "`expiredItem`" - "`faultyItem`" -
        /// "`incorrectItemReceived`" - "`itemMissing`" - "`qualityNotExpected`" - "`receivedTooLate`" -
        /// "`storePackageMissing`" - "`transitPackageMissing`" - "`unsuccessfulDeliveryUndeliverable`" -
        /// "`wrongChargeInStore`" - "`wrongItem`" - "`returns`" - "`undeliverable`" - "`refundFromMerchant`" -
        /// "`returnLabelShippingFee`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The amount that contributes to the line item price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionAmount")]
        public virtual Price TransactionAmount { get; set; } 

        /// <summary>The type of the amount.
        ///
        /// Acceptable values are: - "`itemPrice`" - "`orderPrice`" - "`refund`" - "`earlyRefund`" - "`courtesyRefund`"
        /// - "`returnRefund`" - "`returnLabelShippingFeeAmount`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementTransactionAmountCommission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the commission.
        ///
        /// Acceptable values are: - "`animalsAndPetSupplies`" - "`dogCatFoodAndCatLitter`" - "`apparelAndAccessories`"
        /// - "`shoesHandbagsAndSunglasses`" - "`costumesAndAccessories`" - "`jewelry`" - "`watches`" -
        /// "`hobbiesArtsAndCrafts`" - "`homeAndGarden`" - "`entertainmentCollectibles`" - "`collectibleCoins`" -
        /// "`sportsCollectibles`" - "`sportingGoods`" - "`toysAndGames`" - "`musicalInstruments`" - "`giftCards`" -
        /// "`babyAndToddler`" - "`babyFoodWipesAndDiapers`" - "`businessAndIndustrial`" -
        /// "`camerasOpticsAndPhotography`" - "`consumerElectronics`" - "`electronicsAccessories`" -
        /// "`personalComputers`" - "`videoGameConsoles`" - "`foodAndGrocery`" - "`beverages`" - "`tobaccoProducts`" -
        /// "`furniture`" - "`hardware`" - "`buildingMaterials`" - "`tools`" - "`healthAndPersonalCare`" - "`beauty`" -
        /// "`householdSupplies`" - "`kitchenAndDining`" - "`majorAppliances`" - "`luggageAndBags`" - "`media`" -
        /// "`officeSupplies`" - "`softwareAndVideoGames`" - "`vehiclePartsAndAccessories`" - "`vehicleTiresAndWheels`"
        /// - "`vehicles`" - "`everythingElse`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; } 

        /// <summary>Rate of the commission in percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual string Rate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementTransactionIdentifiers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the adjustments, if it is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjustmentId")]
        public virtual string AdjustmentId { get; set; } 

        /// <summary>The merchant provided order ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantOrderId")]
        public virtual string MerchantOrderId { get; set; } 

        /// <summary>The identifier of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderItemId")]
        public virtual string OrderItemId { get; set; } 

        /// <summary>The unique ID of the settlement transaction entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settlementEntryId")]
        public virtual string SettlementEntryId { get; set; } 

        /// <summary>The shipment ids for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentIds")]
        public virtual System.Collections.Generic.IList<string> ShipmentIds { get; set; } 

        /// <summary>The Google transaction ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementTransactionTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time on which the event occurred in ISO 8601 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postDate")]
        public virtual string PostDate { get; set; } 

        /// <summary>The type of the transaction that occurred.
        ///
        /// Acceptable values are: - "`order`" - "`reversal`" - "`orderRefund`" - "`reversalRefund`" -
        /// "`issueRelatedRefundAndReplacement`" - "`returnLabelShippingFeeTransaction`" -
        /// "`reversalIssueRelatedRefundAndReplacement`" - "`reversalReturnLabelShippingFeeTransaction`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementreportsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#settlementreportsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<SettlementReport> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SettlementtransactionsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#settlementtransactionsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<SettlementTransaction> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShipmentInvoice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] Invoice summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoiceSummary")]
        public virtual InvoiceSummary InvoiceSummary { get; set; } 

        /// <summary>[required] Invoice details per line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemInvoices")]
        public virtual System.Collections.Generic.IList<ShipmentInvoiceLineItemInvoice> LineItemInvoices { get; set; } 

        /// <summary>[required] ID of the shipment group. It is assigned by the merchant in the `shipLineItems` method
        /// and is used to group multiple line items that have the same kind of shipping charges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentGroupId")]
        public virtual string ShipmentGroupId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShipmentInvoiceLineItemInvoice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the line item. Either lineItemId or productId must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; } 

        /// <summary>ID of the product. This is the REST ID used in the products service. Either lineItemId or productId
        /// must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>[required] The shipment unit ID is assigned by the merchant and defines individual quantities
        /// within a line item. The same ID can be assigned to units that are the same while units that differ must be
        /// assigned a different ID (for example: free or promotional units).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentUnitIds")]
        public virtual System.Collections.Generic.IList<string> ShipmentUnitIds { get; set; } 

        /// <summary>[required] Invoice details for a single unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitInvoice")]
        public virtual UnitInvoice UnitInvoice { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShipmentTrackingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The shipping carrier that handles the package.
        ///
        /// Acceptable values are: - "`boxtal`" - "`bpost`" - "`chronopost`" - "`colisPrive`" - "`colissimo`" - "`cxt`"
        /// - "`deliv`" - "`dhl`" - "`dpd`" - "`dynamex`" - "`eCourier`" - "`easypost`" - "`efw`" - "`fedex`" -
        /// "`fedexSmartpost`" - "`geodis`" - "`gls`" - "`googleCourier`" - "`gsx`" - "`jdLogistics`" - "`laPoste`" -
        /// "`lasership`" - "`manual`" - "`mpx`" - "`onTrac`" - "`other`" - "`tnt`" - "`uds`" - "`ups`" -
        /// "`usps`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; } 

        /// <summary>The tracking number for the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingNumber")]
        public virtual string TrackingNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The merchant account's shipping settings. All methods except getsupportedcarriers and
    /// getsupportedholidays require the admin role.</summary>
    public class ShippingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account to which these account shipping settings belong. Ignored upon update, always
        /// present in get request responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>A list of postal code groups that can be referred to in `services`. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeGroups")]
        public virtual System.Collections.Generic.IList<PostalCodeGroup> PostalCodeGroups { get; set; } 

        /// <summary>The target account's list of services. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsCustomBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request entries to be processed in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ShippingsettingsCustomBatchRequestEntry> Entries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch shippingsettings request.</summary>
    public class ShippingsettingsCustomBatchRequestEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the account for which to get/update account shipping settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<ulong> AccountId { get; set; } 

        /// <summary>An entry ID, unique within the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>The ID of the managing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<ulong> MerchantId { get; set; } 

        /// <summary>The method of the batch entry.
        ///
        /// Acceptable values are: - "`get`" - "`update`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>The account shipping settings to update. Only defined if the method is `update`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingSettings")]
        public virtual ShippingSettings ShippingSettings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsCustomBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution of the batch requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ShippingsettingsCustomBatchResponseEntry> Entries { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#shippingsettingsCustomBatchResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch entry encoding a single non-batch shipping settings response.</summary>
    public class ShippingsettingsCustomBatchResponseEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the request entry to which this entry responds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchId")]
        public virtual System.Nullable<long> BatchId { get; set; } 

        /// <summary>A list of errors defined if, and only if, the request failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "`content#shippingsettingsCustomBatchResponseEntry`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The retrieved or updated account shipping settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingSettings")]
        public virtual ShippingSettings ShippingSettings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsGetSupportedCarriersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of supported carriers. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carriers")]
        public virtual System.Collections.Generic.IList<CarriersCarrier> Carriers { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#shippingsettingsGetSupportedCarriersResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsGetSupportedHolidaysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of holidays applicable for delivery guarantees. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holidays")]
        public virtual System.Collections.Generic.IList<HolidaysHoliday> Holidays { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#shippingsettingsGetSupportedHolidaysResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsGetSupportedPickupServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#shippingsettingsGetSupportedPickupServicesResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>A list of supported pickup services. May be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupServices")]
        public virtual System.Collections.Generic.IList<PickupServicesPickupService> PickupServices { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ShippingsettingsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string
        /// "content#shippingsettingsListResponse".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The token for the retrieval of the next page of shipping settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ShippingSettings> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Headers of the table's columns. Optional: if not set then the table has only one
        /// dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual Headers ColumnHeaders { get; set; } 

        /// <summary>Name of the table. Required for subtables, ignored for the main table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Headers of the table's rows. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowHeaders")]
        public virtual Headers RowHeaders { get; set; } 

        /// <summary>The list of rows that constitute the table. Must have the same length as `rowHeaders`.
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Overrides the predefined delivery details if provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryDetails")]
        public virtual TestOrderDeliveryDetails DeliveryDetails { get; set; } 

        /// <summary>Whether the orderinvoices service should support this order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableOrderinvoices")]
        public virtual System.Nullable<bool> EnableOrderinvoices { get; set; } 

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "`content#testOrder`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Required. Line items that are ordered. At least one line item must be provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<TestOrderLineItem> LineItems { get; set; } 

        /// <summary>Restricted. Do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationMode")]
        public virtual string NotificationMode { get; set; } 

        /// <summary>Overrides the predefined pickup details if provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupDetails")]
        public virtual TestOrderPickupDetails PickupDetails { get; set; } 

        /// <summary>Required. The billing address.
        ///
        /// Acceptable values are: - "`dwight`" - "`jim`" - "`pam`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedBillingAddress")]
        public virtual string PredefinedBillingAddress { get; set; } 

        /// <summary>Required. Identifier of one of the predefined delivery addresses for the delivery.
        ///
        /// Acceptable values are: - "`dwight`" - "`jim`" - "`pam`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedDeliveryAddress")]
        public virtual string PredefinedDeliveryAddress { get; set; } 

        /// <summary>Required. Email address of the customer.
        ///
        /// Acceptable values are: - "`pog.dwight.schrute@gmail.com`" - "`pog.jim.halpert@gmail.com`" -
        /// "`penpog.pam.beesly@gmail.comding`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedEmail")]
        public virtual string PredefinedEmail { get; set; } 

        /// <summary>Identifier of one of the predefined pickup details. Required for orders containing line items with
        /// shipping type `pickup`.
        ///
        /// Acceptable values are: - "`dwight`" - "`jim`" - "`pam`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedPickupDetails")]
        public virtual string PredefinedPickupDetails { get; set; } 

        /// <summary>Promotions associated with the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<OrderPromotion> Promotions { get; set; } 

        /// <summary>Required. The price of shipping for all items. Shipping tax is automatically calculated for orders
        /// where marketplace facilitator tax laws are applicable. Otherwise, tax settings from Merchant Center are
        /// applied. Note that shipping is not taxed in certain states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingCost")]
        public virtual Price ShippingCost { get; set; } 

        /// <summary>Required. The requested shipping option.
        ///
        /// Acceptable values are: - "`economy`" - "`expedited`" - "`oneDay`" - "`sameDay`" - "`standard`" -
        /// "`twoDay`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingOption")]
        public virtual string ShippingOption { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CLDR country code (e.g. "US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Strings representing the lines of the printed label for mailing the order, for example: John Smith
        /// 1600 Amphitheatre Parkway Mountain View, CA, 94043 United States</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullAddress")]
        public virtual System.Collections.Generic.IList<string> FullAddress { get; set; } 

        /// <summary>Whether the address is a post office box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPostOfficeBox")]
        public virtual System.Nullable<bool> IsPostOfficeBox { get; set; } 

        /// <summary>City, town or commune. May also include dependent localities or sublocalities (e.g. neighborhoods
        /// or suburbs).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Postal Code or ZIP (e.g. "94043").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Name of the recipient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientName")]
        public virtual string RecipientName { get; set; } 

        /// <summary>Top-level administrative subdivision of the country. For example, a state like California ("CA") or
        /// a province like Quebec ("QC").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>Street-level part of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual System.Collections.Generic.IList<string> StreetAddress { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderDeliveryDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The delivery address</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual TestOrderAddress Address { get; set; } 

        /// <summary>The phone number of the person receiving the delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderLineItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Product data from the time of the order placement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual TestOrderLineItemProduct Product { get; set; } 

        /// <summary>Required. Number of items ordered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityOrdered")]
        public virtual System.Nullable<long> QuantityOrdered { get; set; } 

        /// <summary>Required. Details of the return policy for the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnInfo")]
        public virtual OrderLineItemReturnInfo ReturnInfo { get; set; } 

        /// <summary>Required. Details of the requested shipping for the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingDetails")]
        public virtual OrderLineItemShippingDetails ShippingDetails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderLineItemProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Brand of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>Required. Condition or state of the item.
        ///
        /// Acceptable values are: - "`new`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>Required. The two-letter ISO 639-1 language code for the item.
        ///
        /// Acceptable values are: - "`en`" - "`fr`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Fees for the item. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fees")]
        public virtual System.Collections.Generic.IList<OrderLineItemProductFee> Fees { get; set; } 

        /// <summary>Global Trade Item Number (GTIN) of the item. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; } 

        /// <summary>Required. URL of an image of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLink")]
        public virtual string ImageLink { get; set; } 

        /// <summary>Shared identifier for all variants of the same product. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; } 

        /// <summary>Manufacturer Part Number (MPN) of the item. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; } 

        /// <summary>Required. An identifier of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; } 

        /// <summary>Required. The price for the product. Tax is automatically calculated for orders where marketplace
        /// facilitator tax laws are applicable. Otherwise, tax settings from Merchant Center are applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; } 

        /// <summary>Required. The CLDR territory code of the target country of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Required. The title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Variant attributes for the item. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantAttributes")]
        public virtual System.Collections.Generic.IList<OrderLineItemProductVariantAttribute> VariantAttributes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderPickupDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Code of the location defined by provider or merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationCode")]
        public virtual string LocationCode { get; set; } 

        /// <summary>Required. Pickup location address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupLocationAddress")]
        public virtual TestOrderAddress PickupLocationAddress { get; set; } 

        /// <summary>Pickup location type.
        ///
        /// Acceptable values are: - "`locker`" - "`store`" - "`curbside`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupLocationType")]
        public virtual string PickupLocationType { get; set; } 

        /// <summary>Required. all pickup persons set by users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupPersons")]
        public virtual System.Collections.Generic.IList<TestOrderPickupDetailsPickupPerson> PickupPersons { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestOrderPickupDetailsPickupPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Full name of the pickup person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The phone number of the person picking up the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TransitTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of postal group names. The last value can be `"all other locations"`. Example: `["zone 1",
        /// "zone 2", "all other locations"]`. The referred postal code groups must match the delivery country of the
        /// service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeGroupNames")]
        public virtual System.Collections.Generic.IList<string> PostalCodeGroupNames { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TransitTableTransitTimeRow> Rows { get; set; } 

        /// <summary>A list of transit time labels. The last value can be `"all other labels"`. Example: `["food",
        /// "electronics", "all other labels"]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeLabels")]
        public virtual System.Collections.Generic.IList<string> TransitTimeLabels { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TransitTableTransitTimeRow : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<TransitTableTransitTimeRowTransitTimeValue> Values { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TransitTableTransitTimeRowTransitTimeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than or equal to `minTransitTimeInDays`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTransitTimeInDays")]
        public virtual System.Nullable<long> MaxTransitTimeInDays { get; set; } 

        /// <summary>Transit time range (min-max) in business days. 0 means same day delivery, 1 means next day
        /// delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTransitTimeInDays")]
        public virtual System.Nullable<long> MinTransitTimeInDays { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UnitInvoice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional charges for a unit, e.g. shipping costs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalCharges")]
        public virtual System.Collections.Generic.IList<UnitInvoiceAdditionalCharge> AdditionalCharges { get; set; } 

        /// <summary>[required] Pre-tax or post-tax price of the unit depending on the locality of the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPrice")]
        public virtual Price UnitPrice { get; set; } 

        /// <summary>Tax amounts to apply to the unit price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPriceTaxes")]
        public virtual System.Collections.Generic.IList<UnitInvoiceTaxLine> UnitPriceTaxes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UnitInvoiceAdditionalCharge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] Amount of the additional charge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalChargeAmount")]
        public virtual Amount AdditionalChargeAmount { get; set; } 

        /// <summary>[required] Type of the additional charge.
        ///
        /// Acceptable values are: - "`shipping`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UnitInvoiceTaxLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[required] Tax amount for the tax type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Price TaxAmount { get; set; } 

        /// <summary>Optional name of the tax type. This should only be provided if `taxType` is
        /// `otherFeeTax`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxName")]
        public virtual string TaxName { get; set; } 

        /// <summary>[required] Type of the tax.
        ///
        /// Acceptable values are: - "`otherFee`" - "`otherFeeTax`" - "`sales`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxType")]
        public virtual string TaxType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The single value of a rate group or the value of a rate group table's cell. Exactly one of
    /// `noShipping`, `flatRate`, `pricePercentage`, `carrierRateName`, `subtableName` must be set.</summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of a carrier rate referring to a carrier rate defined in the same rate group. Can only be
        /// set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRateName")]
        public virtual string CarrierRateName { get; set; } 

        /// <summary>A flat rate. Can only be set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatRate")]
        public virtual Price FlatRate { get; set; } 

        /// <summary>If true, then the product can't ship. Must be true when set, can only be set if all other fields
        /// are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noShipping")]
        public virtual System.Nullable<bool> NoShipping { get; set; } 

        /// <summary>A percentage of the price represented as a number in decimal notation (e.g., `"5.4"`). Can only be
        /// set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricePercentage")]
        public virtual string PricePercentage { get; set; } 

        /// <summary>The name of a subtable. Can only be set in table cells (i.e., not for single values), and only if
        /// all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtableName")]
        public virtual string SubtableName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Weight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The weight unit.
        ///
        /// Acceptable values are: - "`kg`" - "`lb`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; } 

        /// <summary>Required. The weight represented as a number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
