using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The newAlfaBankPayment function result.
    /// </summary>
    public class AllocateAlfaBankPaymentResultType
    {
        /// <summary>
        /// The URL to redirect
        /// </summary>
        [JsonProperty("formUrl")]
        public string FormUrl { get; private set; }

        /// <summary>
        /// The payment ID
        /// </summary>
        [JsonProperty("payment_id ")]
        public string PaymentId  { get; private set; }

    }
}