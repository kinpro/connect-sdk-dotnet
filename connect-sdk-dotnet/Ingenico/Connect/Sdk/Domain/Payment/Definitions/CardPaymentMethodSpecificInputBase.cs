/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CardPaymentMethodSpecificInputBase">CardPaymentMethodSpecificInputBase</a>
    /// </summary>
    public class CardPaymentMethodSpecificInputBase : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public bool? SkipAuthentication { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
