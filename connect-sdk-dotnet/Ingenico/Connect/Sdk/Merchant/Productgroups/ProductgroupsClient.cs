/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Productgroups
{
    /// <summary>
    /// Productgroups client. Thread-safe.
    /// </summary>
    public class ProductgroupsClient : ApiResource
    {
        public ProductgroupsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__productgroups_get">Get payment product groups</a>
        /// </summary>
        /// <param name="query">FindProductgroupsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroups</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PaymentProductGroups> Find(FindProductgroupsParams query, CallContext context = null)
        {
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/productgroups", null);
            try
            {
                return await _communicator.Get<PaymentProductGroups>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups/{paymentProductGroupId}
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__productgroups__paymentProductGroupId__get">Get payment product group</a>
        /// </summary>
        /// <param name="paymentProductGroupId">string</param>
        /// <param name="query">GetProductgroupParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroupResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PaymentProductGroupResponse> Get(string paymentProductGroupId, GetProductgroupParams query, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductGroupId", paymentProductGroupId);
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/productgroups/{paymentProductGroupId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductGroupResponse>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
