/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Refund;

namespace Ingenico.Connect.Sdk.Merchant.Refunds
{
    public class ApproveRefundExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                ApproveRefundRequest body = new ApproveRefundRequest();
                body.Amount = 199L;

                await client.Merchant("merchantId").Refunds().Approve("refundId", body);
            }
#pragma warning restore 0168
        }

        private Client GetClient()
        {
            string apiKeyId = "someKey";
            string secretApiKey = "someSecret";

            CommunicatorConfiguration configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
