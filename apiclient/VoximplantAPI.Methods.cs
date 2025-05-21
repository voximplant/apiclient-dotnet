using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Voximplant.API.Response;

namespace Voximplant.API {

    public partial class VoximplantAPI
    {
        /// <summary>
        /// Gets the account's info such as account_id, account_name, account_email etc.
        /// </summary>
        /// <param name="returnLiveBalance">Whether to get the account's live balance</param>
        public async Task<GetAccountInfoResponse> GetAccountInfo(bool? returnLiveBalance = null)
        {
            var args = new Dictionary<string, object>();

            if (returnLiveBalance.HasValue)
                args["return_live_balance"] = returnLiveBalance.Value ? "1" : "0";
            return await PerformRequest<GetAccountInfoResponse>("GetAccountInfo", args);
}
        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        /// <param name="newAccountEmail">The new account email</param>
        /// <param name="newAccountPassword">The new account password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="languageCode">The notification language code (2 symbols, ISO639-1). The following values are available: aa (Afar), ab (Abkhazian), af (Afrikaans), am (Amharic), ar (Arabic), as (Assamese), ay (Aymara), az (Azerbaijani), ba (Bashkir), be (Belarusian), bg (Bulgarian), bh (Bihari), bi (Bislama), bn (Bengali), bo (Tibetan), br (Breton), ca (Catalan), co (Corsican), cs (Czech), cy (Welch), da (Danish), de (German), dz (Bhutani), el (Greek), en (English), eo (Esperanto), es (Spanish), et (Estonian), eu (Basque), fa (Persian), fi (Finnish), fj (Fiji), fo (Faeroese), fr (French), fy (Frisian), ga (Irish), gd (Scots Gaelic), gl (Galician), gn (Guarani), gu (Gujarati), ha (Hausa), hi (Hindi), he (Hebrew), hr (Croatian), hu (Hungarian), hy (Armenian), ia (Interlingua), id (Indonesian), ie (Interlingue), ik (Inupiak), in (Indonesian), is (Icelandic), it (Italian), iu (Inuktitut), iw (Hebrew), ja (Japanese), ji (Yiddish), jw (Javanese), ka (Georgian), kk (Kazakh), kl (Greenlandic), km (Cambodian), kn (Kannada), ko (Korean), ks (Kashmiri), ku (Kurdish), ky (Kirghiz), la (Latin), ln (Lingala), lo (Laothian), lt (Lithuanian), lv (Latvian), mg (Malagasy), mi (Maori), mk (Macedonian), ml (Malayalam), mn (Mongolian), mo (Moldavian), mr (Marathi), ms (Malay), mt (Maltese), my (Burmese), na (Nauru), ne (Nepali), nl (Dutch), no (Norwegian), oc (Occitan), om (Oromo), or (Oriya), pa (Punjabi), pl (Polish), ps (Pashto), pt (Portuguese), qu (Quechua), rm (Rhaeto-Romance), rn (Kirundi), ro (Romanian), ru (Russian), rw (Kinyarwanda), sa (Sanskrit), sd (Sindhi), sg (Sangro), sh (Serbo-Croatian), si (Singhalese), sk (Slovak), sl (Slovenian), sm (Samoan), sn (Shona), so (Somali), sq (Albanian), sr (Serbian), ss (Siswati), st (Sesotho), su (Sudanese), sv (Swedish), sw (Swahili), ta (Tamil), te (Tegulu), tg (Tajik), th (Thai), ti (Tigrinya), tk (Turkmen), tl (Tagalog), tn (Setswana), to (Tonga), tr (Turkish), ts (Tsonga), tt (Tatar), tw (Twi), ug (Uigur), uk (Ukrainian), ur (Urdu), uz (Uzbek), vi (Vietnamese), vo (Volapuk), wo (Wolof), xh (Xhosa), yi (Yiddish), yo (Yoruba), za (Zhuang), zh (Chinese), zu (Zulu)</param>
        /// <param name="location">The account location (timezone). Examples: America/Los_Angeles, Etc/GMT-8, Etc/GMT+10</param>
        /// <param name="accountFirstName">The first name</param>
        /// <param name="accountLastName">The last name</param>
        /// <param name="minBalanceToNotify">The min balance value to notify by email or SMS</param>
        /// <param name="accountNotifications">Whether Voximplant notifications are required</param>
        /// <param name="tariffChangingNotifications">Whether to receive the emails about the Voximplant plan changing</param>
        /// <param name="newsNotifications">Whether to receive the emails about the Voximplant news</param>
        /// <param name="sendJsError">Whether to receive the emails about a JS scenario error</param>
        /// <param name="billingAddressName">The company or businessman name</param>
        /// <param name="billingAddressCountryCode">The billing address country code (2 symbols, ISO 3166-1 alpha-2). The following values are available: AF (Afghanistan), AL (Albania), DZ (Algeria), AS (American Samoa), AD (Andorra), AO (Angola), AI (Anguilla), AQ (Antarctica), AG (Antigua and Barbuda), AR (Argentina), AM (Armenia), AW (Aruba), AU (Australia), AT (Austria), AZ (Azerbaijan), BH (Bahrain), BD (Bangladesh), BB (Barbados), BY (Belarus), BE (Belgium), BZ (Belize), BJ (Benin), BM (Bermuda), BT (Bhutan), BO (Bolivia), BA (Bosnia and Herzegovina), BW (Botswana), BV (Bouvet Island), BR (Brazil), IO (British Indian Ocean Territory), BN (Brunei), BG (Bulgaria), BF (Burkina Faso), BI (Burundi), KH (Cambodia), CM (Cameroon), CA (Canada), CV (Cape Verde), KY (Cayman Islands), CF (Central African Republic), TD (Chad), CL (Chile), CN (China), CX (Christmas Island), CO (Colombia), KM (Comoros), CG (Congo), CK (Cook Islands), CR (Costa Rica), HR (Croatia), CU (Cuba), CY (Cyprus), CZ (Czech Republic), DK (Denmark), DJ (Djibouti), DM (Dominica), DO (Dominican Republic), EC (Ecuador), EG (Egypt), SV (El Salvador), GQ (Equatorial Guinea), ER (Eritrea), EE (Estonia), ET (Ethiopia), FO (Faroe Islands), FJ (Fiji Islands), FI (Finland), FR (France), GF (French Guiana), PF (French Polynesia), TF (French Southern and Antarctic Lands), GA (Gabon), GE (Georgia), DE (Germany), GH (Ghana), GI (Gibraltar), GR (Greece), GL (Greenland), GD (Grenada), GP (Guadeloupe), GU (Guam), GT (Guatemala), GG (Guernsey), GN (Guinea), GY (Guyana), HT (Haiti), HM (Heard Island and McDonald Islands), HN (Honduras), HU (Hungary), IS (Iceland), IN (India), ID (Indonesia), IR (Iran), IQ (Iraq), IE (Ireland), IL (Israel), IT (Italy), JM (Jamaica), JP (Japan), JE (Jersey), JO (Jordan), KZ (Kazakhstan), KE (Kenya), KI (Kiribati), KR (Korea), KW (Kuwait), KG (Kyrgyzstan), LA (Laos), LV (Latvia), LB (Lebanon), LS (Lesotho), LR (Liberia), LY (Libya), LI (Liechtenstein), LT (Lithuania), LU (Luxembourg), MG (Madagascar), MW (Malawi), MY (Malaysia), MV (Maldives), ML (Mali), MT (Malta), MH (Marshall Islands), MQ (Martinique), MR (Mauritania), MU (Mauritius), YT (Mayotte), MX (Mexico), FM (Micronesia), MD (Moldova), MC (Monaco), MN (Mongolia), ME (Montenegro), MS (Montserrat), MA (Morocco), MZ (Mozambique), MM (Myanmar), NA (Namibia), NR (Nauru), NP (Nepal), NL (Netherlands), AN (Netherlands Antilles), NC (New Caledonia), NZ (New Zealand), NI (Nicaragua), NE (Niger), NG (Nigeria), NU (Niue), NF (Norfolk Island), KP (North Korea), MP (Northern Mariana Islands), NO (Norway), OM (Oman), PK (Pakistan), PW (Palau), PS (Palestinian Authority), PA (Panama), PG (Papua New Guinea), PY (Paraguay), PE (Peru), PH (Philippines), PN (Pitcairn Islands), PL (Poland), PT (Portugal), PR (Puerto Rico), QA (Qatar), RE (Reunion), RO (Romania), RU (Russia), RW (Rwanda), WS (Samoa), SM (San Marino), SA (Saudi Arabia), SN (Senegal), RS (Serbia), SC (Seychelles), SL (Sierra Leone), SG (Singapore), SK (Slovakia), SI (Slovenia), SB (Solomon Islands), SO (Somalia), ZA (South Africa), GS (South Georgia and the South Sandwich Islands), ES (Spain), LK (Sri Lanka), SD (Sudan), SR (Suriname), SZ (Swaziland), SE (Sweden), CH (Switzerland), SY (Syria), ST (Sao Tome and Principe), TW (Taiwan), TJ (Tajikistan), TZ (Tanzania), TH (Thailand), TG (Togo), TK (Tokelau), TO (Tonga), TT (Trinidad and Tobago), TN (Tunisia), TR (Turkey), TM (Turkmenistan), TC (Turks and Caicos Islands), TV (Tuvalu), UG (Uganda), UA (Ukraine), AE (United Arab Emirates), GB (United Kingdom), US (United States), UY (Uruguay), UZ (Uzbekistan), VU (Vanuatu), VA (Vatican City), VE (Venezuela), VN (Vietnam), VI (Virgin Islands), WF (Wallis and Futuna), EH (Western Sahara), YE (Yemen), ZM (Zambia), ZW (Zimbabwe), AX (Aland Islands)</param>
        /// <param name="billingAddressAddress">The valid address that needs to be specified to pay for any services. You cannot delete it later, only change</param>
        /// <param name="billingAddressZip">The office ZIP</param>
        /// <param name="billingAddressPhone">The office phone number</param>
        /// <param name="accountCustomData">The custom data</param>
        /// <param name="callbackUrl">If URL is specified, Voximplant cloud makes HTTP POST requests to it when something happens. For a full list of reasons see the <b>type</b> field of the [AccountCallback] structure. The HTTP request has a JSON-encoded body that conforms to the [AccountCallbacks] structure</param>
        /// <param name="callbackSalt">If salt string is specified, each HTTP request made by the Voximplant cloud toward the <b>callback_url</b> has a <b>salt</b> field set to MD5 hash of account information and salt. That hash can be used be a developer to ensure that HTTP request is made by the Voximplant cloud</param>
        /// <param name="storeOutboundSms">Whether to store outgoing message texts. Default value is false</param>
        /// <param name="storeInboundSms">Whether to store incoming message texts. Default value is false</param>
        public async Task<SetAccountInfoResponse> SetAccountInfo(string newAccountEmail = null, string newAccountPassword = null, string languageCode = null, string location = null, string accountFirstName = null, string accountLastName = null, decimal? minBalanceToNotify = null, bool? accountNotifications = null, bool? tariffChangingNotifications = null, bool? newsNotifications = null, bool? sendJsError = null, string billingAddressName = null, string billingAddressCountryCode = null, string billingAddressAddress = null, string billingAddressZip = null, string billingAddressPhone = null, string accountCustomData = null, string callbackUrl = null, string callbackSalt = null, bool? storeOutboundSms = null, bool? storeInboundSms = null)
        {
            var args = new Dictionary<string, object>();

            if (newAccountEmail != null)
                args["new_account_email"] = newAccountEmail;
            if (newAccountPassword != null)
                args["new_account_password"] = newAccountPassword;
            if (languageCode != null)
                args["language_code"] = languageCode;
            if (location != null)
                args["location"] = location;
            if (accountFirstName != null)
                args["account_first_name"] = accountFirstName;
            if (accountLastName != null)
                args["account_last_name"] = accountLastName;
            if (minBalanceToNotify.HasValue)
                args["min_balance_to_notify"] = minBalanceToNotify.Value.ToString(CultureInfo.InvariantCulture);
            if (accountNotifications.HasValue)
                args["account_notifications"] = accountNotifications.Value ? "1" : "0";
            if (tariffChangingNotifications.HasValue)
                args["tariff_changing_notifications"] = tariffChangingNotifications.Value ? "1" : "0";
            if (newsNotifications.HasValue)
                args["news_notifications"] = newsNotifications.Value ? "1" : "0";
            if (sendJsError.HasValue)
                args["send_js_error"] = sendJsError.Value ? "1" : "0";
            if (billingAddressName != null)
                args["billing_address_name"] = billingAddressName;
            if (billingAddressCountryCode != null)
                args["billing_address_country_code"] = billingAddressCountryCode;
            if (billingAddressAddress != null)
                args["billing_address_address"] = billingAddressAddress;
            if (billingAddressZip != null)
                args["billing_address_zip"] = billingAddressZip;
            if (billingAddressPhone != null)
                args["billing_address_phone"] = billingAddressPhone;
            if (accountCustomData != null)
                args["account_custom_data"] = accountCustomData;
            if (callbackUrl != null)
                args["callback_url"] = callbackUrl;
            if (callbackSalt != null)
                args["callback_salt"] = callbackSalt;
            if (storeOutboundSms.HasValue)
                args["store_outbound_sms"] = storeOutboundSms.Value ? "1" : "0";
            if (storeInboundSms.HasValue)
                args["store_inbound_sms"] = storeInboundSms.Value ? "1" : "0";
            return await PerformRequest<SetAccountInfoResponse>("SetAccountInfo", args);
}
        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;). Use the 'all' value to select all child accounts</param>
        /// <param name="childAccountName">The child account name list separated by semicolons (;). Can be used instead of <b>child_account_id</b></param>
        /// <param name="childAccountEmail">The child account email list separated by semicolons (;). Can be used instead of <b>child_account_id</b></param>
        /// <param name="newChildAccountEmail">The new child account email</param>
        /// <param name="newChildAccountPassword">The new child account password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="accountNotifications">Whether Voximplant notifications are required</param>
        /// <param name="tariffChangingNotifications">Whether to receive the emails about the Voximplant plan changing</param>
        /// <param name="newsNotifications">Whether to receive the emails about the Voximplant news</param>
        /// <param name="active">Whether to enable the child account</param>
        /// <param name="languageCode">The notification language code (2 symbols, ISO639-1). The following values are available: aa (Afar), ab (Abkhazian), af (Afrikaans), am (Amharic), ar (Arabic), as (Assamese), ay (Aymara), az (Azerbaijani), ba (Bashkir), be (Belarusian), bg (Bulgarian), bh (Bihari), bi (Bislama), bn (Bengali), bo (Tibetan), br (Breton), ca (Catalan), co (Corsican), cs (Czech), cy (Welch), da (Danish), de (German), dz (Bhutani), el (Greek), en (English), eo (Esperanto), es (Spanish), et (Estonian), eu (Basque), fa (Persian), fi (Finnish), fj (Fiji), fo (Faeroese), fr (French), fy (Frisian), ga (Irish), gd (Scots Gaelic), gl (Galician), gn (Guarani), gu (Gujarati), ha (Hausa), hi (Hindi), he (Hebrew), hr (Croatian), hu (Hungarian), hy (Armenian), ia (Interlingua), id (Indonesian), ie (Interlingue), ik (Inupiak), in (Indonesian), is (Icelandic), it (Italian), iu (Inuktitut), iw (Hebrew), ja (Japanese), ji (Yiddish), jw (Javanese), ka (Georgian), kk (Kazakh), kl (Greenlandic), km (Cambodian), kn (Kannada), ko (Korean), ks (Kashmiri), ku (Kurdish), ky (Kirghiz), la (Latin), ln (Lingala), lo (Laothian), lt (Lithuanian), lv (Latvian), mg (Malagasy), mi (Maori), mk (Macedonian), ml (Malayalam), mn (Mongolian), mo (Moldavian), mr (Marathi), ms (Malay), mt (Maltese), my (Burmese), na (Nauru), ne (Nepali), nl (Dutch), no (Norwegian), oc (Occitan), om (Oromo), or (Oriya), pa (Punjabi), pl (Polish), ps (Pashto), pt (Portuguese), qu (Quechua), rm (Rhaeto-Romance), rn (Kirundi), ro (Romanian), ru (Russian), rw (Kinyarwanda), sa (Sanskrit), sd (Sindhi), sg (Sangro), sh (Serbo-Croatian), si (Singhalese), sk (Slovak), sl (Slovenian), sm (Samoan), sn (Shona), so (Somali), sq (Albanian), sr (Serbian), ss (Siswati), st (Sesotho), su (Sudanese), sv (Swedish), sw (Swahili), ta (Tamil), te (Tegulu), tg (Tajik), th (Thai), ti (Tigrinya), tk (Turkmen), tl (Tagalog), tn (Setswana), to (Tonga), tr (Turkish), ts (Tsonga), tt (Tatar), tw (Twi), ug (Uigur), uk (Ukrainian), ur (Urdu), uz (Uzbek), vi (Vietnamese), vo (Volapuk), wo (Wolof), xh (Xhosa), yi (Yiddish), yo (Yoruba), za (Zhuang), zh (Chinese), zu (Zulu)</param>
        /// <param name="location">The child account location (timezone). Examples: America/Los_Angeles, Etc/GMT-8, Etc/GMT+10</param>
        /// <param name="minBalanceToNotify">The min balance value to notify by email or SMS</param>
        /// <param name="supportRobokassa">Whether to allow the robokassa payments</param>
        /// <param name="supportBankCard">Whether to allow the bank card payments</param>
        /// <param name="supportInvoice">Whether to allow the bank invoices</param>
        /// <param name="canUseRestricted">Whether to allow use restricted directions</param>
        public async Task<SetChildAccountInfoResponse> SetChildAccountInfo(string childAccountId = null, string childAccountName = null, string childAccountEmail = null, string newChildAccountEmail = null, string newChildAccountPassword = null, bool? accountNotifications = null, bool? tariffChangingNotifications = null, bool? newsNotifications = null, bool? active = null, string languageCode = null, string location = null, decimal? minBalanceToNotify = null, bool? supportRobokassa = null, bool? supportBankCard = null, bool? supportInvoice = null, bool? canUseRestricted = null)
        {
            var passedArgs = new List<string>();
        
            if (childAccountId != null)
                passedArgs.Add("childAccountId");
            if (childAccountName != null)
                passedArgs.Add("childAccountName");
            if (childAccountEmail != null)
                passedArgs.Add("childAccountEmail");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetChildAccountInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of childAccountId, childAccountName, childAccountEmail passed into SetChildAccountInfo");
    
            var args = new Dictionary<string, object>();

            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childAccountName != null)
                args["child_account_name"] = childAccountName;
            if (childAccountEmail != null)
                args["child_account_email"] = childAccountEmail;
            if (newChildAccountEmail != null)
                args["new_child_account_email"] = newChildAccountEmail;
            if (newChildAccountPassword != null)
                args["new_child_account_password"] = newChildAccountPassword;
            if (accountNotifications.HasValue)
                args["account_notifications"] = accountNotifications.Value ? "1" : "0";
            if (tariffChangingNotifications.HasValue)
                args["tariff_changing_notifications"] = tariffChangingNotifications.Value ? "1" : "0";
            if (newsNotifications.HasValue)
                args["news_notifications"] = newsNotifications.Value ? "1" : "0";
            if (active.HasValue)
                args["active"] = active.Value ? "1" : "0";
            if (languageCode != null)
                args["language_code"] = languageCode;
            if (location != null)
                args["location"] = location;
            if (minBalanceToNotify.HasValue)
                args["min_balance_to_notify"] = minBalanceToNotify.Value.ToString(CultureInfo.InvariantCulture);
            if (supportRobokassa.HasValue)
                args["support_robokassa"] = supportRobokassa.Value ? "1" : "0";
            if (supportBankCard.HasValue)
                args["support_bank_card"] = supportBankCard.Value ? "1" : "0";
            if (supportInvoice.HasValue)
                args["support_invoice"] = supportInvoice.Value ? "1" : "0";
            if (canUseRestricted.HasValue)
                args["can_use_restricted"] = canUseRestricted.Value ? "1" : "0";
            return await PerformRequest<SetChildAccountInfoResponse>("SetChildAccountInfo", args);
}
        /// <summary>
        /// Gets the exchange rate on selected date (per USD).
        /// </summary>
        /// <param name="currency">The currency code list separated by semicolons (;). Examples: RUR, KZT, EUR, USD</param>
        /// <param name="date">The date, format: YYYY-MM-DD</param>
        public async Task<GetCurrencyRateResponse> GetCurrencyRate(string currency, DateTime? date = null)
        {
            var args = new Dictionary<string, object>();

            args["currency"] = currency;
            if (date.HasValue)
                args["date"] = date.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            return await PerformRequest<GetCurrencyRateResponse>("GetCurrencyRate", args);
}
        /// <summary>
        /// Gets the resource price.
        /// </summary>
        /// <param name="resourceType">The resource type list separated by semicolons (;). The possible values are AUDIOHDCONFERENCE, AUDIOHDRECORD, AUDIORECORD, CALLLIST, CALLSESSION, DIALOGFLOW, IM, PSTN_IN_ALASKA, PSTN_IN_GB, PSTN_IN_GEOGRAPHIC, PSTN_IN_GEO_PH, PSTN_IN_RU, PSTN_IN_RU_TOLLFREE, PSTN_INTERNATIONAL, PSTNINTEST, PSTN_IN_TF_AR, PSTN_IN_TF_AT, PSTN_IN_TF_AU, PSTN_IN_TF_BE, PSTN_IN_TF_BR, PSTN_IN_TF_CA, PSTN_IN_TF_CO, PSTN_IN_TF_CY, PSTN_IN_TF_DE, PSTN_IN_TF_DK, PSTN_IN_TF_DO, PSTN_IN_TF_FI, PSTN_IN_TF_FR, PSTN_IN_TF_GB, PSTN_IN_TF_HR, PSTN_IN_TF_HU, PSTN_IN_TF_IL, PSTN_IN_TF_LT, PSTN_IN_TF_PE, PSTN_IN_TF_US, PSTN_IN_US, PSTNOUT, PSTNOUT_EEA, PSTNOUTEMERG, PSTNOUT_KZ, PSTNOUT_LOCAL, PSTN_OUT_LOCAL_RU, RELAYED_TRAFFIC, SIPOUT, SIPOUTVIDEO, SMSINPUT, SMSOUT, SMSOUT_INTERNATIONAL, TRANSCRIPTION, TTS_TEXT_GOOGLE, TTS_YANDEX, USER_LOGON, VIDEOCALL, VIDEORECORD, VOICEMAILDETECTION, VOIPIN, VOIPOUT, VOIPOUTVIDEO, YANDEXASR, ASR, ASR_GOOGLE_ENHANCED</param>
        /// <param name="priceGroupId">The price group ID list separated by semicolons (;)</param>
        /// <param name="priceGroupName">The price group name template to filter</param>
        /// <param name="resourceParam">The resource parameter list separated by semicolons (;). Example: a phone number list</param>
        public async Task<GetResourcePriceResponse> GetResourcePrice(string resourceType = null, string priceGroupId = null, string priceGroupName = null, string resourceParam = null)
        {
            var args = new Dictionary<string, object>();

            if (resourceType != null)
                args["resource_type"] = resourceType;
            if (priceGroupId != null)
                args["price_group_id"] = priceGroupId;
            if (priceGroupName != null)
                args["price_group_name"] = priceGroupName;
            if (resourceParam != null)
                args["resource_param"] = resourceParam;
            return await PerformRequest<GetResourcePriceResponse>("GetResourcePrice", args);
}
        /// <summary>
        /// Gets the subscription template price.
        /// </summary>
        /// <param name="subscriptionTemplateId">The subscription template ID list separated by semicolons (;)</param>
        /// <param name="subscriptionTemplateType">The subscription template type. The following values are possible: PHONE_NUM, SIP_REGISTRATION</param>
        /// <param name="subscriptionTemplateName">The subscription template name  (example: SIP registration, Phone GB, Phone RU 495, ...)</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPrice(string subscriptionTemplateId = null, string subscriptionTemplateType = null, string subscriptionTemplateName = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (subscriptionTemplateId != null)
                args["subscription_template_id"] = subscriptionTemplateId;
            if (subscriptionTemplateType != null)
                args["subscription_template_type"] = subscriptionTemplateType;
            if (subscriptionTemplateName != null)
                args["subscription_template_name"] = subscriptionTemplateName;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetSubscriptionPriceResponse>("GetSubscriptionPrice", args);
}
        /// <summary>
        /// Gets the info about all children accounts.
        /// </summary>
        /// <param name="childAccountId">The account ID list separated by semicolons (;). You need to specify at least one of the following parameters: `child_account_id`, `child_account_name`, `child_account_email`</param>
        /// <param name="childAccountName">The child account name to filter. You need to specify at least one of the following parameters: `child_account_id`, `child_account_name`, `child_account_email`</param>
        /// <param name="childAccountEmail">The child account email to filter. You need to specify at least one of the following parameters: `child_account_id`, `child_account_name`, `child_account_email`</param>
        /// <param name="active">Whether the filter is active</param>
        /// <param name="frozen">Whether the filter is frozen</param>
        /// <param name="ignoreInvalidAccounts">Whether to ignore the invalid 'child_account_id' items</param>
        /// <param name="briefOutput">Whether to output the account_id only</param>
        /// <param name="mediumOutput">Whether to output the account_id, account_name, account_email only</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="orderBy">The following values are available: 'child_account_id', 'child_account_name' and 'child_account_email'</param>
        /// <param name="returnLiveBalance">Whether to get the user live balance</param>
        public async Task<GetChildrenAccountsResponse> GetChildrenAccounts(string childAccountId = null, string childAccountName = null, string childAccountEmail = null, bool? active = null, bool? frozen = null, bool? ignoreInvalidAccounts = null, bool? briefOutput = null, bool? mediumOutput = null, long? count = null, long? offset = null, string orderBy = null, bool? returnLiveBalance = null)
        {
            var args = new Dictionary<string, object>();

            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childAccountName != null)
                args["child_account_name"] = childAccountName;
            if (childAccountEmail != null)
                args["child_account_email"] = childAccountEmail;
            if (active.HasValue)
                args["active"] = active.Value ? "1" : "0";
            if (frozen.HasValue)
                args["frozen"] = frozen.Value ? "1" : "0";
            if (ignoreInvalidAccounts.HasValue)
                args["ignore_invalid_accounts"] = ignoreInvalidAccounts.Value ? "1" : "0";
            if (briefOutput.HasValue)
                args["brief_output"] = briefOutput.Value ? "1" : "0";
            if (mediumOutput.HasValue)
                args["medium_output"] = mediumOutput.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (orderBy != null)
                args["order_by"] = orderBy;
            if (returnLiveBalance.HasValue)
                args["return_live_balance"] = returnLiveBalance.Value ? "1" : "0";
            return await PerformRequest<GetChildrenAccountsResponse>("GetChildrenAccounts", args);
}
        /// <summary>
        /// Get the recommended money amount to charge.
        /// </summary>
        /// <param name="currency">The currency name. Examples: USD, RUR, EUR</param>
        /// <param name="chargeDate">The next charge date, format: YYYY-MM-DD</param>
        public async Task<GetMoneyAmountToChargeResponse> GetMoneyAmountToCharge(string currency = null, DateTime? chargeDate = null)
        {
            var args = new Dictionary<string, object>();

            if (currency != null)
                args["currency"] = currency;
            if (chargeDate.HasValue)
                args["charge_date"] = chargeDate.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            return await PerformRequest<GetMoneyAmountToChargeResponse>("GetMoneyAmountToCharge", args);
}
        /// <summary>
        /// Charges the account in the manual mode. You should call the ChargeAccount function to charge the subscriptions having the auto_charge=false.
        /// </summary>
        /// <param name="phoneId">The phone ID list separated by semicolons (;). Use the 'all' value to select all phone ids. You should specify the phones having the auto_charge=false</param>
        /// <param name="phoneNumber">The phone number list separated by semicolons (;). Use the 'all' value to select all phone numbers. Can be used instead of <b>phone_id</b>. You should specify the phones having the auto_charge=false</param>
        public async Task<ChargeAccountResponse> ChargeAccount(string phoneId = null, string phoneNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneId != null)
                passedArgs.Add("phoneId");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into ChargeAccount");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneId, phoneNumber passed into ChargeAccount");
    
            var args = new Dictionary<string, object>();

            if (phoneId != null)
                args["phone_id"] = phoneId;
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            return await PerformRequest<ChargeAccountResponse>("ChargeAccount", args);
}
        /// <summary>
        /// Configures the account's plan.<br><br>Please note that when you change the billing plan, we reserve the subscription fee and taxes for the upcoming month. Read more in the <a href='/docs/gettingstarted/billing'>Billing</a> page.
        /// </summary>
        /// <param name="planType">The plan type to config. The possible values are IM, MAU</param>
        /// <param name="planSubscriptionTemplateId">The new plan ID with a price larger than the current plan's (see [GetAvailablePlans])</param>
        public async Task<ChangeAccountPlanResponse> ChangeAccountPlan(string planType, long? planSubscriptionTemplateId = null)
        {
            var args = new Dictionary<string, object>();

            args["plan_type"] = planType;
            if (planSubscriptionTemplateId.HasValue)
                args["plan_subscription_template_id"] = planSubscriptionTemplateId.Value.ToString();
            return await PerformRequest<ChangeAccountPlanResponse>("ChangeAccountPlan", args);
}
        /// <summary>
        /// Gets the account plans with packages.
        /// </summary>
        /// <param name="planType">The plan type list separated by semicolons (;). The possible values are IM, MAU</param>
        /// <param name="planSubscriptionTemplateId">The plan ID list separated by semicolons (;)</param>
        public async Task<GetAccountPlansResponse> GetAccountPlans(string planType = null, string planSubscriptionTemplateId = null)
        {
            var args = new Dictionary<string, object>();

            if (planType != null)
                args["plan_type"] = planType;
            if (planSubscriptionTemplateId != null)
                args["plan_subscription_template_id"] = planSubscriptionTemplateId;
            return await PerformRequest<GetAccountPlansResponse>("GetAccountPlans", args);
}
        /// <summary>
        /// Gets the allowed plans to change.
        /// </summary>
        /// <param name="planType">The plan type list separated by semicolons (;). The possible values are IM, MAU</param>
        /// <param name="planSubscriptionTemplateId">The plan ID list separated by semicolons (;)</param>
        public async Task<GetAvailablePlansResponse> GetAvailablePlans(string planType = null, string planSubscriptionTemplateId = null)
        {
            var args = new Dictionary<string, object>();

            if (planType != null)
                args["plan_type"] = planType;
            if (planSubscriptionTemplateId != null)
                args["plan_subscription_template_id"] = planSubscriptionTemplateId;
            return await PerformRequest<GetAvailablePlansResponse>("GetAvailablePlans", args);
}
        /// <summary>
        /// Adds a new account's application.
        /// </summary>
        /// <param name="applicationName">The short application name in format \[a-z\]\[a-z0-9-\]{1,64}</param>
        /// <param name="secureRecordStorage">Whether to enable secure storage for all logs and records of the application</param>
        public async Task<AddApplicationResponse> AddApplication(string applicationName, bool? secureRecordStorage = null)
        {
            var args = new Dictionary<string, object>();

            args["application_name"] = applicationName;
            if (secureRecordStorage.HasValue)
                args["secure_record_storage"] = secureRecordStorage.Value ? "1" : "0";
            return await PerformRequest<AddApplicationResponse>("AddApplication", args);
}
        /// <summary>
        /// Deletes the account's application.
        /// </summary>
        /// <param name="applicationId">The application ID list separated by semicolons (;). Use the 'all' value to select all applications</param>
        /// <param name="applicationName">The application name list separated by semicolons (;). Can be used instead of <b>application_id</b></param>
        public async Task<DelApplicationResponse> DelApplication(string applicationId = null, string applicationName = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelApplication");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into DelApplication");
    
            var args = new Dictionary<string, object>();

            if (applicationId != null)
                args["application_id"] = applicationId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<DelApplicationResponse>("DelApplication", args);
}
        /// <summary>
        /// Edits the account's application.
        /// </summary>
        /// <param name="applicationId">The application ID</param>
        /// <param name="requiredApplicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="applicationName">The new short application name in format [a-z][a-z0-9-]{1,79}</param>
        /// <param name="secureRecordStorage">Whether to enable secure storage for all logs and records of the application</param>
        public async Task<SetApplicationInfoResponse> SetApplicationInfo(long? applicationId = null, string requiredApplicationName = null, string applicationName = null, bool? secureRecordStorage = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (requiredApplicationName != null)
                passedArgs.Add("requiredApplicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetApplicationInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, requiredApplicationName passed into SetApplicationInfo");
    
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (requiredApplicationName != null)
                args["required_application_name"] = requiredApplicationName;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (secureRecordStorage.HasValue)
                args["secure_record_storage"] = secureRecordStorage.Value ? "1" : "0";
            return await PerformRequest<SetApplicationInfoResponse>("SetApplicationInfo", args);
}
        /// <summary>
        /// Gets the account's applications.
        /// </summary>
        /// <param name="applicationId">The application ID to filter</param>
        /// <param name="applicationName">The application name part to filter</param>
        /// <param name="withRules">Whether to get bound rules info</param>
        /// <param name="withScenarios">Whether to get bound rules and scenarios info</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetApplicationsResponse> GetApplications(long? applicationId = null, string applicationName = null, bool? withRules = null, bool? withScenarios = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (withRules.HasValue)
                args["with_rules"] = withRules.Value ? "1" : "0";
            if (withScenarios.HasValue)
                args["with_scenarios"] = withScenarios.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetApplicationsResponse>("GetApplications", args);
}
        /// <summary>
        /// Adds a new user.
        /// </summary>
        /// <param name="userName">The user name in format [a-z0-9][a-z0-9_-]{2,49}</param>
        /// <param name="userDisplayName">The user display name. The length must be less than 256</param>
        /// <param name="userPassword">The user password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="applicationId">The application ID which a new user is to be bound to. Can be used instead of the <b>application_name</b> parameter</param>
        /// <param name="applicationName">The application name which a new user is to be bound to. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="parentAccounting">Whether the user uses the parent account's money, 'false' if the user has a separate balance</param>
        /// <param name="userActive">Whether the user is active. Inactive users cannot log in to applications</param>
        /// <param name="userCustomData">Any string</param>
        public async Task<AddUserResponse> AddUser(string userName, string userDisplayName, string userPassword, long? applicationId = null, string applicationName = null, bool? parentAccounting = null, bool? userActive = null, string userCustomData = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddUser");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into AddUser");
    
            var args = new Dictionary<string, object>();

            args["user_name"] = userName;
            args["user_display_name"] = userDisplayName;
            args["user_password"] = userPassword;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (parentAccounting.HasValue)
                args["parent_accounting"] = parentAccounting.Value ? "1" : "0";
            if (userActive.HasValue)
                args["user_active"] = userActive.Value ? "1" : "0";
            if (userCustomData != null)
                args["user_custom_data"] = userCustomData;
            return await PerformRequest<AddUserResponse>("AddUser", args);
}
        /// <summary>
        /// Deletes the specified user(s).
        /// </summary>
        /// <param name="userId">The user ID list separated by semicolons (;). Use the 'all' value to select all users</param>
        /// <param name="userName">The user name list separated by semicolons (;) that can be used instead of <b>user_id</b></param>
        /// <param name="applicationId">Delete the specified users bound to the application ID. It is required if the <b>user_name</b> is specified</param>
        /// <param name="applicationName">Delete the specified users bound to the application name. Can be used instead of the <b>application_id</b> parameter</param>
        public async Task<DelUserResponse> DelUser(string userId = null, string userName = null, long? applicationId = null, string applicationName = null)
        {
            var passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelUser");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of userId, userName passed into DelUser");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelUser");
    
            var args = new Dictionary<string, object>();

            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<DelUserResponse>("DelUser", args);
}
        /// <summary>
        /// Edits the user.
        /// </summary>
        /// <param name="userId">The user to edit</param>
        /// <param name="userName">The user name that can be used instead of <b>user_id</b></param>
        /// <param name="applicationId">The application ID. It is required if the <b>user_name</b> is specified</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="newUserName">The new user name in format [a-z0-9][a-z0-9_-]{2,49}</param>
        /// <param name="userDisplayName">The new user display name. The length must be less than 256</param>
        /// <param name="userPassword">The new user password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="parentAccounting">Whether to use the parent account's money, 'false' to use a separate user balance</param>
        /// <param name="userActive">Whether the user is active. Inactive users cannot log in to applications</param>
        /// <param name="userCustomData">Any string</param>
        public async Task<SetUserInfoResponse> SetUserInfo(long? userId = null, string userName = null, long? applicationId = null, string applicationName = null, string newUserName = null, string userDisplayName = null, string userPassword = null, bool? parentAccounting = null, bool? userActive = null, string userCustomData = null)
        {
            var passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetUserInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of userId, userName passed into SetUserInfo");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetUserInfo");
    
            var args = new Dictionary<string, object>();

            if (userId.HasValue)
                args["user_id"] = userId.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (newUserName != null)
                args["new_user_name"] = newUserName;
            if (userDisplayName != null)
                args["user_display_name"] = userDisplayName;
            if (userPassword != null)
                args["user_password"] = userPassword;
            if (parentAccounting.HasValue)
                args["parent_accounting"] = parentAccounting.Value ? "1" : "0";
            if (userActive.HasValue)
                args["user_active"] = userActive.Value ? "1" : "0";
            if (userCustomData != null)
                args["user_custom_data"] = userCustomData;
            return await PerformRequest<SetUserInfoResponse>("SetUserInfo", args);
}
        /// <summary>
        /// Shows the users of the specified account.
        /// </summary>
        /// <param name="applicationId">The application ID to filter</param>
        /// <param name="applicationName">The application name part to filter</param>
        /// <param name="skillId">The skill ID to filter</param>
        /// <param name="excludedSkillId">The excluded skill ID to filter</param>
        /// <param name="acdQueueId">The ACD queue ID to filter</param>
        /// <param name="excludedAcdQueueId">The excluded ACD queue ID to filter</param>
        /// <param name="userId">The user ID to filter</param>
        /// <param name="userName">The user name part to filter</param>
        /// <param name="userActive">Whether the user is active to filter. Inactive users cannot log in to applications</param>
        /// <param name="userDisplayName">The user display name part to filter</param>
        /// <param name="withSkills">Whether to get the bound skills</param>
        /// <param name="withQueues">Whether to get the bound queues</param>
        /// <param name="acdStatus">The ACD status list separated by semicolons (;) to filter. The following values are possible: OFFLINE, ONLINE, READY, BANNED, IN_SERVICE, AFTER_SERVICE, TIMEOUT, DND</param>
        /// <param name="showingSkillId">The skill to show in the 'skills' field output</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="orderBy">The following values are available: 'user_id', 'user_name' and 'user_display_name'</param>
        /// <param name="returnLiveBalance">Whether to get the user live balance</param>
        public async Task<GetUsersResponse> GetUsers(long? applicationId = null, string applicationName = null, long? skillId = null, long? excludedSkillId = null, long? acdQueueId = null, long? excludedAcdQueueId = null, long? userId = null, string userName = null, bool? userActive = null, string userDisplayName = null, bool? withSkills = null, bool? withQueues = null, string acdStatus = null, long? showingSkillId = null, long? count = null, long? offset = null, string orderBy = null, bool? returnLiveBalance = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetUsers");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into GetUsers");
    
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (skillId.HasValue)
                args["skill_id"] = skillId.Value.ToString();
            if (excludedSkillId.HasValue)
                args["excluded_skill_id"] = excludedSkillId.Value.ToString();
            if (acdQueueId.HasValue)
                args["acd_queue_id"] = acdQueueId.Value.ToString();
            if (excludedAcdQueueId.HasValue)
                args["excluded_acd_queue_id"] = excludedAcdQueueId.Value.ToString();
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (userActive.HasValue)
                args["user_active"] = userActive.Value ? "1" : "0";
            if (userDisplayName != null)
                args["user_display_name"] = userDisplayName;
            if (withSkills.HasValue)
                args["with_skills"] = withSkills.Value ? "1" : "0";
            if (withQueues.HasValue)
                args["with_queues"] = withQueues.Value ? "1" : "0";
            if (acdStatus != null)
                args["acd_status"] = acdStatus;
            if (showingSkillId.HasValue)
                args["showing_skill_id"] = showingSkillId.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (orderBy != null)
                args["order_by"] = orderBy;
            if (returnLiveBalance.HasValue)
                args["return_live_balance"] = returnLiveBalance.Value ? "1" : "0";
            return await PerformRequest<GetUsersResponse>("GetUsers", args);
}
        /// <summary>
        /// Adds a new CSV file for call list processing and starts the specified rule immediately. To send a file, use the request body. To set the call time constraints, use the following options in a CSV file: <ul><li>**__start_execution_time** – when the call list processing starts every day, UTC+0 24-h format: HH:mm:ss</li><li>**__end_execution_time** – when the call list processing stops every day,  UTC+0 24-h format: HH:mm:ss</li><li>**__start_at** – when the call list processing starts, UNIX timestamp. If not specified, the processing starts immediately after a method call</li><li>**__task_uuid** – call list UUID. A string up to 40 characters, can contain latin letters, digits, hyphens (-) and colons (:). Unique within the call list</li></ul><br>This method accepts CSV files with custom delimiters, such a commas (,), semicolons (;) and other. To specify a delimiter, pass it to the <b>delimiter</b> parameter.<br/><b>IMPORTANT:</b> the account's balance should be equal or greater than 1 USD. If the balance is lower than 1 USD, the call list processing does not start, or it stops immediately if it is active.
        /// </summary>
        /// <param name="ruleId">The rule ID. It is specified in the <a href='//manage.voximplant.com/applications'>Applications</a> section of the Control Panel</param>
        /// <param name="priority">Call list priority. The value is in the range of [0 ... 2^31] where zero is the highest priority</param>
        /// <param name="maxSimultaneous">Number of simultaneously processed tasks</param>
        /// <param name="numAttempts">Number of attempts. Minimum is <b>1</b>, maximum is <b>5</b></param>
        /// <param name="name">File name, up to 255 characters and cannot contain the '/' and '\' symbols</param>
        /// <param name="fileContent">Send as "body" part of the HTTP request or as multiform. The sending "file_content" via URL is at its own risk because the network devices tend to drop HTTP requests with large headers</param>
        /// <param name="intervalSeconds">Interval between call attempts in seconds. The default value is 0</param>
        /// <param name="encoding">Encoding file. The default value is UTF-8</param>
        /// <param name="delimiter">Separator values. The default value is ';'</param>
        /// <param name="escape">Escape character for parsing csv</param>
        /// <param name="referenceIp">Specifies the IP from the geolocation of the call list subscribers. It allows selecting the nearest server for serving subscribers</param>
        /// <param name="serverLocation">Specifies the location of the server where the scenario needs to be executed. Has higher priority than `reference_ip`. Request [getServerLocations](https://api.voximplant.com/getServerLocations) for possible values</param>
        public async Task<CreateCallListResponse> CreateCallList(long ruleId, long priority, long maxSimultaneous, long numAttempts, string name, Stream fileContent, long? intervalSeconds = null, string encoding = null, string delimiter = null, string escape = null, string referenceIp = null, string serverLocation = null)
        {
            var args = new Dictionary<string, object>();

            args["rule_id"] = ruleId.ToString();
            args["priority"] = priority.ToString();
            args["max_simultaneous"] = maxSimultaneous.ToString();
            args["num_attempts"] = numAttempts.ToString();
            args["name"] = name;
            args["file_content"] = fileContent;
            if (intervalSeconds.HasValue)
                args["interval_seconds"] = intervalSeconds.Value.ToString();
            if (encoding != null)
                args["encoding"] = encoding;
            if (delimiter != null)
                args["delimiter"] = delimiter;
            if (escape != null)
                args["escape"] = escape;
            if (referenceIp != null)
                args["reference_ip"] = referenceIp;
            if (serverLocation != null)
                args["server_location"] = serverLocation;
            return await PerformRequest<CreateCallListResponse>("CreateCallList", args);
}
        /// <summary>
        /// Appends a new task to the existing call list.<br>This method accepts CSV files with custom delimiters, such a commas (,), semicolons (;) and other. To specify a delimiter, pass it to the <b>delimiter</b> parameter.
        /// </summary>
        /// <param name="fileContent">Send as request body or multiform</param>
        /// <param name="listId">The call list ID</param>
        /// <param name="encoding">Encoding file. The default value is UTF-8</param>
        /// <param name="escape">Escape character for parsing csv</param>
        /// <param name="delimiter">Separator values. The default value is ';'</param>
        public async Task<AppendToCallListResponse> AppendToCallList(Stream fileContent, long? listId = null, string encoding = null, string escape = null, string delimiter = null)
        {
            var passedArgs = new List<string>();
        
            if (listId != null)
                passedArgs.Add("listId");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AppendToCallList");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of listId passed into AppendToCallList");
    
            var args = new Dictionary<string, object>();

            args["file_content"] = fileContent;
            if (listId.HasValue)
                args["list_id"] = listId.ToString();
            if (encoding != null)
                args["encoding"] = encoding;
            if (escape != null)
                args["escape"] = escape;
            if (delimiter != null)
                args["delimiter"] = delimiter;
            return await PerformRequest<AppendToCallListResponse>("AppendToCallList", args);
}
        /// <summary>
        /// Edits the specified call list by its ID.
        /// </summary>
        /// <param name="listId">Call list ID. If the ID is non existing, the 251 error returns</param>
        /// <param name="intervalSeconds">Minimum interval between call attempts. Cannot be a negative value</param>
        /// <param name="numAttempts">Maximum call attempt number. Cannot be less than 1</param>
        /// <param name="maxSimultaneous">Maximum simultaneous call attempts for this call list. Cannot be less than 1</param>
        /// <param name="ipAddress">IP address in the `Inet4Address` format</param>
        /// <param name="name">Call list name. Cannot be bigger than 255 characters, cannot contain slash symbol</param>
        /// <param name="priority">Call list's priority among other call list. The lower the value, the higher is the call list's priority</param>
        /// <param name="startAt">Time when the call list should start in the `yyyy-MM-dd HH:mm:ss` format</param>
        /// <param name="serverLocation">Location of the server processing the call list. If the ID is non existing, the 496 error returns: The 'server_location' parameter is invalid.</param>
        public async Task<EditCallListResponse> EditCallList(long listId, long? intervalSeconds = null, long? numAttempts = null, long? maxSimultaneous = null, string ipAddress = null, string name = null, long? priority = null, string startAt = null, string serverLocation = null)
        {
            var args = new Dictionary<string, object>();

            args["list_id"] = listId.ToString();
            if (intervalSeconds.HasValue)
                args["interval_seconds"] = intervalSeconds.Value.ToString();
            if (numAttempts.HasValue)
                args["num_attempts"] = numAttempts.Value.ToString();
            if (maxSimultaneous.HasValue)
                args["max_simultaneous"] = maxSimultaneous.Value.ToString();
            if (ipAddress != null)
                args["ip_address"] = ipAddress;
            if (name != null)
                args["name"] = name;
            if (priority.HasValue)
                args["priority"] = priority.Value.ToString();
            if (startAt != null)
                args["start_at"] = startAt;
            if (serverLocation != null)
                args["server_location"] = serverLocation;
            return await PerformRequest<EditCallListResponse>("EditCallList", args);
}
        /// <summary>
        /// Deletes an existing call list by its ID.
        /// </summary>
        /// <param name="accountId">Account's ID</param>
        public async Task<DeleteCallListResponse> DeleteCallList(long? accountId = null)
        {
            var passedArgs = new List<string>();
        
            if (accountId != null)
                passedArgs.Add("accountId");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DeleteCallList");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of accountId passed into DeleteCallList");
    
            var args = new Dictionary<string, object>();

            if (accountId.HasValue)
                args["account_id"] = accountId.ToString();
            return await PerformRequest<DeleteCallListResponse>("DeleteCallList", args);
}
        /// <summary>
        /// Get all call lists for the specified user.
        /// </summary>
        /// <param name="listId">The list ID to filter. Can be a list separated by semicolons (;). Use the 'all' value to select all lists</param>
        /// <param name="name">Find call lists by name</param>
        /// <param name="isActive">Whether to find only active call lists</param>
        /// <param name="fromDate">The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="typeList">The type of the call list. The possible values are AUTOMATIC and MANUAL</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="applicationId">The application ID to filter. Can be a list separated by semicolons (;). Use the 'all' value to select all applications</param>
        public async Task<GetCallListsResponse> GetCallLists(string listId = null, string name = null, bool? isActive = null, DateTime? fromDate = null, DateTime? toDate = null, string typeList = null, long? count = null, long? offset = null, string applicationId = null)
        {
            var args = new Dictionary<string, object>();

            if (listId != null)
                args["list_id"] = listId;
            if (name != null)
                args["name"] = name;
            if (isActive.HasValue)
                args["is_active"] = isActive.Value ? "1" : "0";
            if (fromDate.HasValue)
                args["from_date"] = fromDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (typeList != null)
                args["type_list"] = typeList;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (applicationId != null)
                args["application_id"] = applicationId;
            return await PerformRequest<GetCallListsResponse>("GetCallLists", args);
}
        /// <summary>
        /// Gets details of the specified call list. Returns a CSV file by default.
        /// </summary>
        /// <param name="listId">The list ID</param>
        /// <param name="count">Maximum number of entries in the result</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="output">The output format. The following values available: **json**, **csv**, **xls**. The default value is **csv**</param>
        /// <param name="encoding">Encoding of the output file. Default UTF-8</param>
        /// <param name="delimiter">Separator values. The default value is ';'</param>
        public async Task<GetCallListDetailsResponse> GetCallListDetails(long listId, long? count = null, long? offset = null, string output = null, string encoding = null, string delimiter = null)
        {
            var args = new Dictionary<string, object>();

            args["list_id"] = listId.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (output != null)
                args["output"] = output;
            if (encoding != null)
                args["encoding"] = encoding;
            if (delimiter != null)
                args["delimiter"] = delimiter;
            return await PerformRequest<GetCallListDetailsResponse>("GetCallListDetails", args);
}
        /// <summary>
        /// Edits the specified call list's task.
        /// </summary>
        /// <param name="listId">Call list's ID</param>
        /// <param name="taskId">Call list's task ID. Please specify either the task's ID or the task's UUID to edit the task</param>
        /// <param name="taskUuid">Call list's task ID. Please specify either the task's ID or the task's UUID to edit the task</param>
        /// <param name="startAt">Next calling attempts timestamp in the yyyy-MM-dd HH:mm:ss format</param>
        /// <param name="attemptsLeft">Number of remaining calling attempts</param>
        /// <param name="customData">Custom data string</param>
        /// <param name="minExecutionTime">Start time for the daily calling attempts in the UTC+0 24-h format: HH:mm:ss format</param>
        public async Task<EditCallListTaskResponse> EditCallListTask(long listId, long? taskId = null, string taskUuid = null, DateTime? startAt = null, long? attemptsLeft = null, string customData = null, DateTime? minExecutionTime = null)
        {
            var args = new Dictionary<string, object>();

            args["list_id"] = listId.ToString();
            if (taskId.HasValue)
                args["task_id"] = taskId.Value.ToString();
            if (taskUuid != null)
                args["task_uuid"] = taskUuid;
            if (startAt.HasValue)
                args["start_at"] = startAt.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (attemptsLeft.HasValue)
                args["attempts_left"] = attemptsLeft.Value.ToString();
            if (customData != null)
                args["custom_data"] = customData;
            if (minExecutionTime.HasValue)
                args["min_execution_time"] = minExecutionTime.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            return await PerformRequest<EditCallListTaskResponse>("EditCallListTask", args);
}
        /// <summary>
        /// Cancels the specified tasks in the call list by their IDs or UUIDs.
        /// </summary>
        /// <param name="accountId">Account's ID</param>
        /// <param name="listId">Call list's ID</param>
        /// <param name="tasksIds">Task IDs separated by a semicolon. Specify either `tasks_ids` or `tasks_uuids`. The method returns an error if none of the parameters is specified</param>
        /// <param name="tasksUuids">Task UUIDs separated by a semicolon. Specify either `tasks_ids` or `tasks_uuids`. The method returns an error if none of the parameters is specified</param>
        public async Task<CancelCallListTaskResponse> CancelCallListTask(string accountId, string listId, string tasksIds = null, string tasksUuids = null)
        {
            var args = new Dictionary<string, object>();

            args["account_id"] = accountId;
            args["list_id"] = listId;
            if (tasksIds != null)
                args["tasks_ids"] = tasksIds;
            if (tasksUuids != null)
                args["tasks_uuids"] = tasksUuids;
            return await PerformRequest<CancelCallListTaskResponse>("CancelCallListTask", args);
}
        /// <summary>
        /// Stops processing the specified call list.
        /// </summary>
        /// <param name="listId">The list Id</param>
        public async Task<StopCallListProcessingResponse> StopCallListProcessing(long listId)
        {
            var args = new Dictionary<string, object>();

            args["list_id"] = listId.ToString();
            return await PerformRequest<StopCallListProcessingResponse>("StopCallListProcessing", args);
}
        /// <summary>
        /// Resume processing the specified call list.
        /// </summary>
        /// <param name="listId">The list Id</param>
        public async Task<RecoverCallListResponse> RecoverCallList(long listId)
        {
            var args = new Dictionary<string, object>();

            args["list_id"] = listId.ToString();
            return await PerformRequest<RecoverCallListResponse>("RecoverCallList", args);
}
        /// <summary>
        /// Adds a new scenario to the <a href="https://voximplant.com/docs/gettingstarted/basicconcepts/scenarios#shared-scenarios">Shared</a> folder, so the scenario is available in all the existing applications. Please use the POST method.<br><br>When adding a scenario to the Shared folder, the `application_id` and `application_name` parameters should not be provided.
        /// </summary>
        /// <param name="scenarioName">The scenario name. The length must be less than 30</param>
        /// <param name="scenarioScript">The scenario text. Use the application/x-www-form-urlencoded content type with UTF-8 encoding. The length must be less than 128 KB</param>
        /// <param name="ruleId">The rule ID. The new scenario binds to the specified rule. Please note, if you do not bind the scenario to any rule, you cannot execute the scenario</param>
        /// <param name="ruleName">The rule name that can be used instead of <b>rule_id</b></param>
        /// <param name="rewrite">Whether to rewrite the existing scenario</param>
        /// <param name="applicationId">ID of the application to bind the scenario to</param>
        /// <param name="applicationName">Name of the application to bind the scenario to</param>
        public async Task<AddScenarioResponse> AddScenario(string scenarioName, string scenarioScript = null, long? ruleId = null, string ruleName = null, bool? rewrite = null, long? applicationId = null, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            args["scenario_name"] = scenarioName;
            if (scenarioScript != null)
                args["scenario_script"] = scenarioScript;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (rewrite.HasValue)
                args["rewrite"] = rewrite.Value ? "1" : "0";
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<AddScenarioResponse>("AddScenario", args);
}
        /// <summary>
        /// Deletes the scenario.
        /// </summary>
        /// <param name="scenarioId">The scenario ID list separated by semicolons (;). Use the 'all' value to delete all scenarios in all applications</param>
        /// <param name="scenarioName">The scenario name list separated by semicolons (;). Can be used instead of <b>scenario_id</b></param>
        public async Task<DelScenarioResponse> DelScenario(string scenarioId = null, string scenarioName = null)
        {
            var passedArgs = new List<string>();
        
            if (scenarioId != null)
                passedArgs.Add("scenarioId");
            if (scenarioName != null)
                passedArgs.Add("scenarioName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelScenario");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of scenarioId, scenarioName passed into DelScenario");
    
            var args = new Dictionary<string, object>();

            if (scenarioId != null)
                args["scenario_id"] = scenarioId;
            if (scenarioName != null)
                args["scenario_name"] = scenarioName;
            return await PerformRequest<DelScenarioResponse>("DelScenario", args);
}
        /// <summary>
        /// Bind the scenario list to the rule. You should specify the application_id or application_name if you specify the rule_name. Please note, the scenario and the routing rule need to be within the same application.
        /// </summary>
        /// <param name="scenarioId">The scenario ID list separated by semicolons (;)</param>
        /// <param name="scenarioName">The scenario name list separated by semicolons (;). Can be used instead of <b>scenario_id</b></param>
        /// <param name="ruleId">The rule ID to bind the scenario. The rule and the scenario need to be in the same application</param>
        /// <param name="ruleName">The rule name that can be used instead of <b>rule_id</b></param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindScenarioResponse> BindScenario(string scenarioId = null, string scenarioName = null, long? ruleId = null, string ruleName = null, long? applicationId = null, string applicationName = null, bool? bind = null)
        {
            var passedArgs = new List<string>();
        
            if (scenarioId != null)
                passedArgs.Add("scenarioId");
            if (scenarioName != null)
                passedArgs.Add("scenarioName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindScenario");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of scenarioId, scenarioName passed into BindScenario");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindScenario");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of ruleId, ruleName passed into BindScenario");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindScenario");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into BindScenario");
    
            var args = new Dictionary<string, object>();

            if (scenarioId != null)
                args["scenario_id"] = scenarioId;
            if (scenarioName != null)
                args["scenario_name"] = scenarioName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindScenarioResponse>("BindScenario", args);
}
        /// <summary>
        /// Gets the account's scenarios.
        /// </summary>
        /// <param name="scenarioId">The scenario ID to filter</param>
        /// <param name="scenarioName">The scenario name to filter. Can be used instead of <b>scenario_id</b>. All scenarios containing this param in their names are returned. The parameter is case insensitive</param>
        /// <param name="withScript">Whether to get the scenario text. You must specify the 'scenario_id' too!</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="applicationId">ID of the scenario's application</param>
        /// <param name="applicationName">Name of the scenario's application</param>
        public async Task<GetScenariosResponse> GetScenarios(long? scenarioId = null, string scenarioName = null, bool? withScript = null, long? count = null, long? offset = null, long? applicationId = null, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            if (scenarioId.HasValue)
                args["scenario_id"] = scenarioId.Value.ToString();
            if (scenarioName != null)
                args["scenario_name"] = scenarioName;
            if (withScript.HasValue)
                args["with_script"] = withScript.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<GetScenariosResponse>("GetScenarios", args);
}
        /// <summary>
        /// Edits the scenario. You can edit the scenario's name and body. Please use the POST method.
        /// </summary>
        /// <param name="scenarioId">Scenario ID</param>
        /// <param name="requiredScenarioName">Name of the scenario to edit, can be used instead of <b>scenario_id</b></param>
        /// <param name="scenarioName">New scenario name. The length must be less than 30</param>
        /// <param name="scenarioScript">New scenario text. Use the application/x-www-form-urlencoded content type with UTF-8 encoding. The length must be less than 128 KB</param>
        public async Task<SetScenarioInfoResponse> SetScenarioInfo(long? scenarioId = null, string requiredScenarioName = null, string scenarioName = null, string scenarioScript = null)
        {
            var passedArgs = new List<string>();
        
            if (scenarioId != null)
                passedArgs.Add("scenarioId");
            if (requiredScenarioName != null)
                passedArgs.Add("requiredScenarioName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetScenarioInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of scenarioId, requiredScenarioName passed into SetScenarioInfo");
    
            var args = new Dictionary<string, object>();

            if (scenarioId.HasValue)
                args["scenario_id"] = scenarioId.ToString();
            if (requiredScenarioName != null)
                args["required_scenario_name"] = requiredScenarioName;
            if (scenarioName != null)
                args["scenario_name"] = scenarioName;
            if (scenarioScript != null)
                args["scenario_script"] = scenarioScript;
            return await PerformRequest<SetScenarioInfoResponse>("SetScenarioInfo", args);
}
        /// <summary>
        /// Configures the order of scenarios that are assigned to the specified rule.
        /// </summary>
        /// <param name="ruleId">The rule ID</param>
        /// <param name="ruleName">The rule name that can be used instead of <b>rule_id</b></param>
        /// <param name="scenarioId">The scenario ID list separated by semicolons (;)</param>
        public async Task<ReorderScenariosResponse> ReorderScenarios(long? ruleId = null, string ruleName = null, string scenarioId = null)
        {
            var passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into ReorderScenarios");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of ruleId, ruleName passed into ReorderScenarios");
    
            var args = new Dictionary<string, object>();

            if (ruleId.HasValue)
                args["rule_id"] = ruleId.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (scenarioId != null)
                args["scenario_id"] = scenarioId;
            return await PerformRequest<ReorderScenariosResponse>("ReorderScenarios", args);
}
        /// <summary>
        /// Runs JavaScript scenarios on a Voximplant server. The scenarios run in a new media session. To start a scenario, pass the routing rule ID associated with the necessary scenario. You can use both GET and POST requests, but we recommend using the POST mode if you pass some data in the custom_data field. The maximum number of simultaneous requests is 200. If you exceed this number, you get the 429 error code.
        /// </summary>
        /// <param name="ruleId">The rule ID that needs to be launched. Please note, the necessary scenario needs to be attached to the rule</param>
        /// <param name="userId">The user ID. Run the scripts from the user if set</param>
        /// <param name="userName">The user name that can be used instead of <b>user_id</b>. Run the scripts from the user if set</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="scriptCustomData">The script custom data, that can be accessed in the scenario via the <a href='/docs/references/voxengine/voxengine/customdata'>VoxEngine.customData()</a> method. Use the application/x-www-form-urlencoded content type with UTF-8 encoding</param>
        /// <param name="referenceIp">Specifies the IP from the geolocation of predicted subscribers. It allows selecting the nearest server for serving subscribers</param>
        /// <param name="serverLocation">Specifies the location of the server where the scenario needs to be executed. Has higher priority than `reference_ip`. Request [getServerLocations](https://api.voximplant.com/getServerLocations) for possible values</param>
        public async Task<StartScenariosResponse> StartScenarios(long ruleId, long? userId = null, string userName = null, long? applicationId = null, string applicationName = null, string scriptCustomData = null, string referenceIp = null, string serverLocation = null)
        {
            var passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into StartScenarios");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into StartScenarios");
    
            var args = new Dictionary<string, object>();

            args["rule_id"] = ruleId.ToString();
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (scriptCustomData != null)
                args["script_custom_data"] = scriptCustomData;
            if (referenceIp != null)
                args["reference_ip"] = referenceIp;
            if (serverLocation != null)
                args["server_location"] = serverLocation;
            return await PerformRequest<StartScenariosResponse>("StartScenarios", args);
}
        /// <summary>
        /// Runs a session for video conferencing or joins the existing video conference session.<br/><br/>When you create a session by calling this method, a scenario runs on one of the servers dedicated to video conferencing. All further method calls with the same **conference_name** do not create a new video conference session but join the existing one.<br/><br/>Use the [StartScenarios] method for creating audio conferences.
        /// </summary>
        /// <param name="conferenceName">The conference name. The name length must be less than 50 symbols</param>
        /// <param name="ruleId">The rule ID that needs to be launched. Please note, the necessary scenario needs to be attached to the rule</param>
        /// <param name="userId">The user ID. Run the scripts from the user if set</param>
        /// <param name="userName">The user name that can be used instead of <b>user_id</b>. Run the scripts from the user if set</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="scriptCustomData">The script custom data, that can be accessed in the scenario via the <a href='/docs/references/voxengine/voxengine/customdata'>VoxEngine.customData()</a> method. Use the application/x-www-form-urlencoded content type with UTF-8 encoding.</param>
        /// <param name="referenceIp">Specifies the IP from the geolocation of predicted subscribers. It allows selecting the nearest server for serving subscribers</param>
        /// <param name="serverLocation">Specifies the location of the server where the scenario needs to be executed. Has higher priority than `reference_ip`. Request [getServerLocations](https://api.voximplant.com/getServerLocations) for possible values</param>
        public async Task<StartConferenceResponse> StartConference(string conferenceName, long ruleId, long? userId = null, string userName = null, long? applicationId = null, string applicationName = null, string scriptCustomData = null, string referenceIp = null, string serverLocation = null)
        {
            var passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into StartConference");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into StartConference");
    
            var args = new Dictionary<string, object>();

            args["conference_name"] = conferenceName;
            args["rule_id"] = ruleId.ToString();
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (scriptCustomData != null)
                args["script_custom_data"] = scriptCustomData;
            if (referenceIp != null)
                args["reference_ip"] = referenceIp;
            if (serverLocation != null)
                args["server_location"] = serverLocation;
            return await PerformRequest<StartConferenceResponse>("StartConference", args);
}
        /// <summary>
        /// Adds a new rule for the application.
        /// </summary>
        /// <param name="ruleName">The rule name. The length must be less than 100</param>
        /// <param name="rulePattern">The rule pattern regex. The length must be less than 64 KB</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name, can be used instead of <b>application_id</b></param>
        /// <param name="rulePatternExclude">The exclude pattern regex. The length must be less than 64 KB</param>
        /// <param name="videoConference">Whether video conference is required</param>
        /// <param name="bindKeyId">The service account ID to bind to the rule. Read more in the [guide](/docs/guides/voxengine/management-api)</param>
        /// <param name="scenarioId">The scenario ID list separated by semicolons (;)</param>
        /// <param name="scenarioName">The scenario name list separated by semicolons (;). Can be used instead of <b>scenario_id</b></param>
        public async Task<AddRuleResponse> AddRule(string ruleName, string rulePattern, long? applicationId = null, string applicationName = null, string rulePatternExclude = null, bool? videoConference = null, string bindKeyId = null, string scenarioId = null, string scenarioName = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddRule");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into AddRule");
    
            passedArgs = new List<string>();
        
            if (scenarioId != null)
                passedArgs.Add("scenarioId");
            if (scenarioName != null)
                passedArgs.Add("scenarioName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddRule");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of scenarioId, scenarioName passed into AddRule");
    
            var args = new Dictionary<string, object>();

            args["rule_name"] = ruleName;
            args["rule_pattern"] = rulePattern;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (rulePatternExclude != null)
                args["rule_pattern_exclude"] = rulePatternExclude;
            if (videoConference.HasValue)
                args["video_conference"] = videoConference.Value ? "1" : "0";
            if (bindKeyId != null)
                args["bind_key_id"] = bindKeyId;
            if (scenarioId != null)
                args["scenario_id"] = scenarioId;
            if (scenarioName != null)
                args["scenario_name"] = scenarioName;
            return await PerformRequest<AddRuleResponse>("AddRule", args);
}
        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="ruleId">The rule ID list separated by semicolons (;). Use the 'all' value to select all rules</param>
        /// <param name="ruleName">The rule name list separated by semicolons (;). Can be used instead of <b>rule_id</b></param>
        /// <param name="applicationId">The application ID list separated by semicolons (;). Use the 'all' value to select all applications</param>
        /// <param name="applicationName">The application name list separated by semicolons (;). Can be used instead of <b>application_id</b></param>
        public async Task<DelRuleResponse> DelRule(string ruleId = null, string ruleName = null, string applicationId = null, string applicationName = null)
        {
            var passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelRule");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of ruleId, ruleName passed into DelRule");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelRule");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into DelRule");
    
            var args = new Dictionary<string, object>();

            if (ruleId != null)
                args["rule_id"] = ruleId;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (applicationId != null)
                args["application_id"] = applicationId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<DelRuleResponse>("DelRule", args);
}
        /// <summary>
        /// Edits the rule.
        /// </summary>
        /// <param name="ruleId">The rule ID</param>
        /// <param name="ruleName">The new rule name. The length must be less than 100</param>
        /// <param name="rulePattern">The new rule pattern regex. The length must be less than 64 KB</param>
        /// <param name="rulePatternExclude">The new exclude pattern regex. The length must be less than 64 KB</param>
        /// <param name="videoConference">Whether video conference is required</param>
        /// <param name="bindKeyId">The service account ID to bind to the rule. Read more in the [guide](/docs/guides/voxengine/management-api)</param>
        public async Task<SetRuleInfoResponse> SetRuleInfo(long ruleId, string ruleName = null, string rulePattern = null, string rulePatternExclude = null, bool? videoConference = null, string bindKeyId = null)
        {
            var args = new Dictionary<string, object>();

            args["rule_id"] = ruleId.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (rulePattern != null)
                args["rule_pattern"] = rulePattern;
            if (rulePatternExclude != null)
                args["rule_pattern_exclude"] = rulePatternExclude;
            if (videoConference.HasValue)
                args["video_conference"] = videoConference.Value ? "1" : "0";
            if (bindKeyId != null)
                args["bind_key_id"] = bindKeyId;
            return await PerformRequest<SetRuleInfoResponse>("SetRuleInfo", args);
}
        /// <summary>
        /// Gets the rules.
        /// </summary>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="ruleId">The rule ID to filter</param>
        /// <param name="ruleName">The rule name part to filter</param>
        /// <param name="videoConference">Whether it is a video conference to filter</param>
        /// <param name="attachedKeyId">The service account ID bound to the rule. Read more in the [guide](/docs/guides/voxengine/management-api)</param>
        /// <param name="template">Search for template matching</param>
        /// <param name="withScenarios">Whether to get bound scenarios info</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetRulesResponse> GetRules(long? applicationId = null, string applicationName = null, long? ruleId = null, string ruleName = null, bool? videoConference = null, string attachedKeyId = null, string template = null, bool? withScenarios = null, long? count = null, long? offset = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetRules");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into GetRules");
    
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (videoConference.HasValue)
                args["video_conference"] = videoConference.Value ? "1" : "0";
            if (attachedKeyId != null)
                args["attached_key_id"] = attachedKeyId;
            if (template != null)
                args["template"] = template;
            if (withScenarios.HasValue)
                args["with_scenarios"] = withScenarios.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetRulesResponse>("GetRules", args);
}
        /// <summary>
        /// Configures the rules' order in the <a href='//manage.voximplant.com/applications'>Applications</a> section of Control panel. Note: the rules must belong to the same application!
        /// </summary>
        /// <param name="ruleId">The rule ID list separated by semicolons (;)</param>
        public async Task<ReorderRulesResponse> ReorderRules(string ruleId)
        {
            var args = new Dictionary<string, object>();

            args["rule_id"] = ruleId;
            return await PerformRequest<ReorderRulesResponse>("ReorderRules", args);
}
        /// <summary>
        /// Gets the account's call history (including call duration, cost, logs and other call information). You can filter the call history by a certain date.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="callSessionHistoryId">To get the call history for the specific sessions, pass the session IDs to this parameter separated by a semicolon (;). You can find the session ID in the <a href='/docs/references/voxengine/appevents#started'>AppEvents.Started</a> event's <b>sessionID</b> property in a scenario, or retrieve it from the <b>call_session_history_id</b> value returned from the <a href='https://voximplant.com/docs/references/httpapi/scenarios#reorderscenarios'>StartScenarios</a> or <a href='https://voximplant.com/docs/references/httpapi/scenarios#startconference'>StartConference</a> methods</param>
        /// <param name="applicationId">To receive the call history for a specific application, pass the application ID to this parameter</param>
        /// <param name="applicationName">The application name, can be used instead of <b>application_id</b></param>
        /// <param name="userId">To receive the call history for a specific users, pass the user ID list separated by semicolons (;). If it is specified, the output contains the calls from the listed users only</param>
        /// <param name="ruleName">To receive the call history for a specific routing rule, pass the rule name to this parameter. Applies only if you set application_id or application_name</param>
        /// <param name="remoteNumber">To receive a call history for a specific remote numbers, pass the number list separated by semicolons (;). A remote number is a number on the client side. Ignored if the `remote_number_list` parameter is not empty</param>
        /// <param name="remoteNumberList">A JS array of strings of specific remote phone numbers to sort the call history. Has higher priority than the `remote_number` parameter. If the array is empty, the `remote_number` parameter is used instead</param>
        /// <param name="localNumber">To receive a call history for a specific local numbers, pass the number list separated by semicolons (;). A local number is a number on the platform side</param>
        /// <param name="callSessionHistoryCustomData">To filter the call history by the custom_data passed to the call sessions, pass the custom data to this parameter</param>
        /// <param name="withCalls">Whether to receive a list of sessions with all calls within the sessions, including phone numbers, call cost and other information</param>
        /// <param name="withRecords">Whether to get the calls' records</param>
        /// <param name="withOtherResources">Whether to get other resources usage (see [ResourceUsageType])</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;)</param>
        /// <param name="childrenCallsOnly">Whether to get the children account calls only</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withTotalCount">Whether to include the 'total_count' and increase performance</param>
        /// <param name="count">The number of returning records. The maximum value is 1000</param>
        /// <param name="offset">The number of records to skip in the output. The maximum value of 10000</param>
        public async Task<GetCallHistoryResponse> GetCallHistory(DateTime fromDate, DateTime toDate, string callSessionHistoryId = null, long? applicationId = null, string applicationName = null, string userId = null, string ruleName = null, string remoteNumber = null, object remoteNumberList = null, string localNumber = null, string callSessionHistoryCustomData = null, bool? withCalls = null, bool? withRecords = null, bool? withOtherResources = null, string childAccountId = null, bool? childrenCallsOnly = null, bool? descOrder = null, bool? withTotalCount = null, long? count = null, long? offset = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetCallHistory");
    
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (callSessionHistoryId != null)
                args["call_session_history_id"] = callSessionHistoryId;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (remoteNumber != null)
                args["remote_number"] = remoteNumber;
            if (remoteNumberList != null)
                args["remote_number_list"] = remoteNumberList.ToString();
            if (localNumber != null)
                args["local_number"] = localNumber;
            if (callSessionHistoryCustomData != null)
                args["call_session_history_custom_data"] = callSessionHistoryCustomData;
            if (withCalls.HasValue)
                args["with_calls"] = withCalls.Value ? "1" : "0";
            if (withRecords.HasValue)
                args["with_records"] = withRecords.Value ? "1" : "0";
            if (withOtherResources.HasValue)
                args["with_other_resources"] = withOtherResources.Value ? "1" : "0";
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenCallsOnly.HasValue)
                args["children_calls_only"] = childrenCallsOnly.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withTotalCount.HasValue)
                args["with_total_count"] = withTotalCount.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetCallHistoryResponse>("GetCallHistory", args);
}
        /// <summary>
        /// The [GetCallHistory] asynchronous implementation. Use this function to download a large amounts of data. Take a look at the [GetHistoryReports] and [DownloadHistoryReport] functions for downloading details.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="callSessionHistoryId">To get the call history for the specific sessions, pass the session IDs to this parameter separated by a semicolon (;). You can find the session ID in the <a href='/docs/references/voxengine/appevents#started'>AppEvents.Started</a> event's <b>sessionID</b> property in a scenario, or retrieve it from the <b>call_session_history_id</b> value returned from the <a href='https://voximplant.com/docs/references/httpapi/scenarios#reorderscenarios'>StartScenarios</a> or <a href='https://voximplant.com/docs/references/httpapi/scenarios#startconference'>StartConference</a> methods</param>
        /// <param name="applicationId">To receive the call history for a specific application, pass the application ID to this parameter</param>
        /// <param name="applicationName">The application name, can be used instead of <b>application_id</b></param>
        /// <param name="userId">To receive the call history for a specific users, pass the user ID list separated by semicolons (;). If it is specified, the output contains the calls from the listed users only</param>
        /// <param name="ruleName">To receive the call history for a specific routing rule, pass the rule name to this parameter. Applies only if you set application_id or application_name</param>
        /// <param name="remoteNumber">To receive a call history for a specific remote numbers, pass the number list separated by semicolons (;). A remote number is a number on the client side</param>
        /// <param name="localNumber">To receive a call history for a specific local numbers, pass the number list separated by semicolons (;). A local number is a number on the platform side</param>
        /// <param name="callSessionHistoryCustomData">To filter the call history by the custom_data passed to the call sessions, pass the custom data to this parameter</param>
        /// <param name="withCalls">Whether to receive a list of sessions with all calls within the sessions, including phone numbers, call cost and other information</param>
        /// <param name="withRecords">Whether to get the calls' records</param>
        /// <param name="withOtherResources">Whether to get other resources usage (see [ResourceUsageType])</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;)</param>
        /// <param name="childrenCallsOnly">Whether to get the children account calls only</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withHeader">Whether to get a CSV file with the column names if the output=csv</param>
        /// <param name="output">The output format. The following values available: **csv**. The default value is **csv**</param>
        public async Task<GetCallHistoryAsyncResponse> GetCallHistoryAsync(DateTime fromDate, DateTime toDate, string callSessionHistoryId = null, long? applicationId = null, string applicationName = null, string userId = null, string ruleName = null, string remoteNumber = null, string localNumber = null, string callSessionHistoryCustomData = null, bool? withCalls = null, bool? withRecords = null, bool? withOtherResources = null, string childAccountId = null, bool? childrenCallsOnly = null, bool? descOrder = null, bool? withHeader = null, string output = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetCallHistoryAsync");
    
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (callSessionHistoryId != null)
                args["call_session_history_id"] = callSessionHistoryId;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (remoteNumber != null)
                args["remote_number"] = remoteNumber;
            if (localNumber != null)
                args["local_number"] = localNumber;
            if (callSessionHistoryCustomData != null)
                args["call_session_history_custom_data"] = callSessionHistoryCustomData;
            if (withCalls.HasValue)
                args["with_calls"] = withCalls.Value ? "1" : "0";
            if (withRecords.HasValue)
                args["with_records"] = withRecords.Value ? "1" : "0";
            if (withOtherResources.HasValue)
                args["with_other_resources"] = withOtherResources.Value ? "1" : "0";
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenCallsOnly.HasValue)
                args["children_calls_only"] = childrenCallsOnly.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            if (output != null)
                args["output"] = output;
            return await PerformRequest<GetCallHistoryAsyncResponse>("GetCallHistoryAsync", args);
}
        /// <summary>
        /// Gets the account's brief call history in the asynchronous mode. Take a look at the [GetHistoryReports] and [DownloadHistoryReport] functions for downloading details.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="output">The output format. The following values available: **csv**.</param>
        /// <param name="callSessionHistoryId">To get the call history for the specific sessions, pass the session IDs to this parameter separated by a semicolon (;). You can find the session ID in the <a href='/docs/references/voxengine/appevents#started'>AppEvents.Started</a> event's <b>sessionID</b> property in a scenario, or retrieve it from the <b>call_session_history_id</b> value returned from the <a href='https://voximplant.com/docs/references/httpapi/scenarios#reorderscenarios'>StartScenarios</a> or <a href='https://voximplant.com/docs/references/httpapi/scenarios#startconference'>StartConference</a> methods</param>
        /// <param name="applicationId">To receive the call history for a specific application, pass the application ID to this parameter</param>
        /// <param name="applicationName">The application name, can be used instead of <b>application_id</b></param>
        /// <param name="ruleName">To receive the call history for a specific routing rule, pass the rule name to this parameter. Applies only if you set application_id or application_name</param>
        /// <param name="remoteNumber">To receive a call history for a specific remote numbers, pass the number list separated by semicolons (;). A remote number is a number on the client side</param>
        /// <param name="localNumber">To receive a call history for a specific local numbers, pass the number list separated by semicolons (;). A local number is a number on the platform side</param>
        /// <param name="callSessionHistoryCustomData">To filter the call history by the custom_data passed to the call sessions, pass the custom data to this parameter</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withHeader">Whether to get a CSV file with the column names if the output=csv</param>
        public async Task<GetBriefCallHistoryResponse> GetBriefCallHistory(DateTime fromDate, DateTime toDate, string output, string callSessionHistoryId = null, long? applicationId = null, string applicationName = null, string ruleName = null, string remoteNumber = null, string localNumber = null, string callSessionHistoryCustomData = null, bool? descOrder = null, bool? withHeader = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetBriefCallHistory");
    
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["output"] = output;
            if (callSessionHistoryId != null)
                args["call_session_history_id"] = callSessionHistoryId;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (remoteNumber != null)
                args["remote_number"] = remoteNumber;
            if (localNumber != null)
                args["local_number"] = localNumber;
            if (callSessionHistoryCustomData != null)
                args["call_session_history_custom_data"] = callSessionHistoryCustomData;
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            return await PerformRequest<GetBriefCallHistoryResponse>("GetBriefCallHistory", args);
}
        /// <summary>
        /// Gets the list of history reports and their statuses. The method returns info about the reports made via [GetCallHistoryAsync], [GetTransactionHistoryAsync], [GetAuditLogAsync] and [GetBriefCallHistory] asynchronous methods. Note that the **file_size** field in response is valid only for the video calls.
        /// </summary>
        /// <param name="historyReportId">The history report ID to filter</param>
        /// <param name="historyType">The history report type list separated by semicolons (;). Use the 'all' value to select all history report types. The following values are possible: calls, calls_brief, transactions, audit, call_list, transactions_on_hold</param>
        /// <param name="createdFrom">The UTC creation from date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="createdTo">The UTC creation to date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="isCompleted">Whether the report is completed</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="applicationId">The application ID to filter. Can be a list separated by semicolons (;). Use the 'all' value to select all applications</param>
        public async Task<GetHistoryReportsResponse> GetHistoryReports(long? historyReportId = null, string historyType = null, DateTime? createdFrom = null, DateTime? createdTo = null, bool? isCompleted = null, bool? descOrder = null, long? count = null, long? offset = null, string applicationId = null)
        {
            var args = new Dictionary<string, object>();

            if (historyReportId.HasValue)
                args["history_report_id"] = historyReportId.Value.ToString();
            if (historyType != null)
                args["history_type"] = historyType;
            if (createdFrom.HasValue)
                args["created_from"] = createdFrom.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (createdTo.HasValue)
                args["created_to"] = createdTo.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (isCompleted.HasValue)
                args["is_completed"] = isCompleted.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (applicationId != null)
                args["application_id"] = applicationId;
            return await PerformRequest<GetHistoryReportsResponse>("GetHistoryReports", args);
}
        /// <summary>
        /// Receives information about the created phone numbers report or list of reports.
        /// </summary>
        /// <param name="reportId">The phone number report ID to filter</param>
        /// <param name="reportType">The phone number report type list separated by semicolons (;). Use the 'all' value to select all history report types. The following values are possible: calls, calls_brief, transactions, audit, call_list, transactions_on_hold</param>
        /// <param name="createdFrom">The UTC creation from date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="createdTo">The UTC creation to date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="isCompleted">Whether the report is completed</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetPhoneNumberReportsResponse> GetPhoneNumberReports(long? reportId = null, string reportType = null, DateTime? createdFrom = null, DateTime? createdTo = null, bool? isCompleted = null, bool? descOrder = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (reportId.HasValue)
                args["report_id"] = reportId.Value.ToString();
            if (reportType != null)
                args["report_type"] = reportType;
            if (createdFrom.HasValue)
                args["created_from"] = createdFrom.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (createdTo.HasValue)
                args["created_to"] = createdTo.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (isCompleted.HasValue)
                args["is_completed"] = isCompleted.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetPhoneNumberReportsResponse>("GetPhoneNumberReports", args);
}
        /// <summary>
        /// Downloads the required history report.<br><br>Please note, that the history report can return in a compressed state (*.gzip). In order for CURL to process a compressed file correctly, add the **--compressed** key.
        /// </summary>
        /// <param name="historyReportId">The history report ID</param>
        public async Task<DownloadHistoryReportResponse> DownloadHistoryReport(long historyReportId)
        {
            var args = new Dictionary<string, object>();

            args["history_report_id"] = historyReportId.ToString();
            return await PerformRequest<DownloadHistoryReportResponse>("DownloadHistoryReport", args);
}
        /// <summary>
        /// Gets the transaction history.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="transactionId">The transaction ID list separated by semicolons (;)</param>
        /// <param name="transactionType">The transaction type list separated by semicolons (;). The following values are possible: gift_revoke, resource_charge, money_distribution, subscription_charge, subscription_installation_charge, card_periodic_payment, card_overrun_payment, card_payment, rub_card_periodic_payment, rub_card_overrun_payment, rub_card_payment, robokassa_payment, gift, promo, adjustment, wire_transfer, us_wire_transfer, refund, discount, mgp_charge, mgp_startup, mgp_business, mgp_big_business, mgp_enterprise, mgp_large_enterprise, techsupport_charge, tax_charge, monthly_fee_charge, grace_credit_payment, grace_credit_provision, mau_charge, mau_overrun, im_charge, im_overrun, fmc_charge, sip_registration_charge, development_fee, money_transfer_to_child, money_transfer_to_parent, money_acceptance_from_child, money_acceptance_from_parent, phone_number_installation, phone_number_charge, toll_free_phone_number_installation, toll_free_phone_number_charge, services, user_money_transfer, paypal_payment, paypal_overrun_payment, paypal_periodic_payment</param>
        /// <param name="userId">The user ID list separated by semicolons (;)</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;). Use the 'all' value to select all child accounts</param>
        /// <param name="childrenTransactionsOnly">Whether to get the children account transactions only</param>
        /// <param name="usersTransactionsOnly">Whether to get the users' transactions only</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withTotalCount">Whether to include the 'total_count' and increase performance</param>
        /// <param name="count">The number of returning records. The maximum value is 1000</param>
        /// <param name="offset">The number of records to skip in the output with a maximum value of 10000</param>
        /// <param name="isUncommitted">Whether to get transactions on hold (transactions for which money is reserved but not yet withdrawn from the account)</param>
        public async Task<GetTransactionHistoryResponse> GetTransactionHistory(DateTime fromDate, DateTime toDate, string transactionId = null, string transactionType = null, string userId = null, string childAccountId = null, bool? childrenTransactionsOnly = null, bool? usersTransactionsOnly = null, bool? descOrder = null, bool? withTotalCount = null, long? count = null, long? offset = null, bool? isUncommitted = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (transactionId != null)
                args["transaction_id"] = transactionId;
            if (transactionType != null)
                args["transaction_type"] = transactionType;
            if (userId != null)
                args["user_id"] = userId;
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenTransactionsOnly.HasValue)
                args["children_transactions_only"] = childrenTransactionsOnly.Value ? "1" : "0";
            if (usersTransactionsOnly.HasValue)
                args["users_transactions_only"] = usersTransactionsOnly.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withTotalCount.HasValue)
                args["with_total_count"] = withTotalCount.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (isUncommitted.HasValue)
                args["is_uncommitted"] = isUncommitted.Value ? "1" : "0";
            return await PerformRequest<GetTransactionHistoryResponse>("GetTransactionHistory", args);
}
        /// <summary>
        /// The [GetTransactionHistory] asynchronous implementation. Use this function to download a large amounts of data. Take a look at the [GetHistoryReports] and [DownloadHistoryReport] functions for downloading details.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="transactionId">The transaction ID list separated by semicolons (;)</param>
        /// <param name="transactionType">The transaction type list separated by semicolons (;). The following values are possible: gift_revoke, resource_charge, money_distribution, subscription_charge, subscription_installation_charge, card_periodic_payment, card_overrun_payment, card_payment, rub_card_periodic_payment, rub_card_overrun_payment, rub_card_payment, robokassa_payment, gift, promo, adjustment, wire_transfer, us_wire_transfer, refund, discount, mgp_charge, mgp_startup, mgp_business, mgp_big_business, mgp_enterprise, mgp_large_enterprise, techsupport_charge, tax_charge, monthly_fee_charge, grace_credit_payment, grace_credit_provision, mau_charge, mau_overrun, im_charge, im_overrun, fmc_charge, sip_registration_charge, development_fee, money_transfer_to_child, money_transfer_to_parent, money_acceptance_from_child, money_acceptance_from_parent, phone_number_installation, phone_number_charge, toll_free_phone_number_installation, toll_free_phone_number_charge, services, user_money_transfer, paypal_payment, paypal_overrun_payment, paypal_periodic_payment</param>
        /// <param name="userId">The user ID list separated by semicolons (;)</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;). Use the 'all' value to select all child accounts</param>
        /// <param name="childrenTransactionsOnly">Whether to get the children account transactions only</param>
        /// <param name="usersTransactionsOnly">Whether to get the users' transactions only</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="isUncommitted">Whether to get transactions on hold (transactions for which money is reserved but not yet withdrawn from the account)</param>
        /// <param name="withHeader">Whether to get a CSV file with the column names if the output=csv</param>
        /// <param name="output">The output format. The following values available: **csv**. The default value is **csv**</param>
        public async Task<GetTransactionHistoryAsyncResponse> GetTransactionHistoryAsync(DateTime fromDate, DateTime toDate, string transactionId = null, string transactionType = null, string userId = null, string childAccountId = null, bool? childrenTransactionsOnly = null, bool? usersTransactionsOnly = null, bool? descOrder = null, bool? isUncommitted = null, bool? withHeader = null, string output = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (transactionId != null)
                args["transaction_id"] = transactionId;
            if (transactionType != null)
                args["transaction_type"] = transactionType;
            if (userId != null)
                args["user_id"] = userId;
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenTransactionsOnly.HasValue)
                args["children_transactions_only"] = childrenTransactionsOnly.Value ? "1" : "0";
            if (usersTransactionsOnly.HasValue)
                args["users_transactions_only"] = usersTransactionsOnly.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (isUncommitted.HasValue)
                args["is_uncommitted"] = isUncommitted.Value ? "1" : "0";
            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            if (output != null)
                args["output"] = output;
            return await PerformRequest<GetTransactionHistoryAsyncResponse>("GetTransactionHistoryAsync", args);
}
        /// <summary>
        /// Try to remove a record and transcription files.
        /// </summary>
        /// <param name="recordUrl">The record URL to remove. You can retrieve the record URL via the <a href="https://voximplant.com/docs/references/httpapi/structure/callsessioninfotype#records">CallSessionInfoType.records</a> method</param>
        /// <param name="recordId">The record ID to remove. You can retrieve the record ID via the <a href="https://voximplant.com/docs/references/httpapi/structure/callsessioninfotype#records">CallSessionInfoType.records</a> method</param>
        public async Task<DeleteRecordResponse> DeleteRecord(string recordUrl = null, long? recordId = null)
        {
            var args = new Dictionary<string, object>();

            if (recordUrl != null)
                args["record_url"] = recordUrl;
            if (recordId.HasValue)
                args["record_id"] = recordId.Value.ToString();
            return await PerformRequest<DeleteRecordResponse>("DeleteRecord", args);
}
        /// <summary>
        /// Gets the ACD history.
        /// </summary>
        /// <param name="fromDate">The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="acdSessionHistoryId">The ACD session history ID list separated by semicolons (;)</param>
        /// <param name="acdRequestId">The ACD request ID list separated by semicolons (;)</param>
        /// <param name="acdQueueId">The ACD queue ID list to filter separated by semicolons (;)</param>
        /// <param name="userId">The user ID list to filter separated by semicolons (;)</param>
        /// <param name="operatorHangup">Whether to get the calls terminated by the operator</param>
        /// <param name="unserviced">Whether the call is unserviced by the operator</param>
        /// <param name="minWaitingTime">The min waiting time filter</param>
        /// <param name="rejected">Whether the call is rejected calls by the 'max_queue_size', 'max_waiting_time' threshold</param>
        /// <param name="withEvents">Whether to get the bound events</param>
        /// <param name="withHeader">Whether to get a CSV file with the column names if the output=csv</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="output">The output format. The following values available: **json**, **csv**, **xls**. The default value is **json**</param>
        public async Task<GetACDHistoryResponse> GetACDHistory(DateTime fromDate, DateTime toDate, string acdSessionHistoryId = null, string acdRequestId = null, string acdQueueId = null, string userId = null, bool? operatorHangup = null, bool? unserviced = null, long? minWaitingTime = null, bool? rejected = null, bool? withEvents = null, bool? withHeader = null, bool? descOrder = null, long? count = null, long? offset = null, string output = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (acdSessionHistoryId != null)
                args["acd_session_history_id"] = acdSessionHistoryId;
            if (acdRequestId != null)
                args["acd_request_id"] = acdRequestId;
            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (userId != null)
                args["user_id"] = userId;
            if (operatorHangup.HasValue)
                args["operator_hangup"] = operatorHangup.Value ? "1" : "0";
            if (unserviced.HasValue)
                args["unserviced"] = unserviced.Value ? "1" : "0";
            if (minWaitingTime.HasValue)
                args["min_waiting_time"] = minWaitingTime.Value.ToString();
            if (rejected.HasValue)
                args["rejected"] = rejected.Value ? "1" : "0";
            if (withEvents.HasValue)
                args["with_events"] = withEvents.Value ? "1" : "0";
            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (output != null)
                args["output"] = output;
            return await PerformRequest<GetACDHistoryResponse>("GetACDHistory", args);
}
        /// <summary>
        /// Gets the history of account changes.
        /// </summary>
        /// <param name="fromDate">The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="auditLogId">The audit history ID list separated by semicolons (;)</param>
        /// <param name="filteredAdminUserId">The admin user ID to filter</param>
        /// <param name="filteredIp">The IP list separated by semicolons (;) to filter</param>
        /// <param name="filteredCmd">The function list separated by semicolons (;) to filter</param>
        /// <param name="advancedFilters">A relation ID to filter (for example: a phone_number value, a user_id value, an application_id value)</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withTotalCount">Whether to include the 'total_count' and increase performance</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetAuditLogResponse> GetAuditLog(DateTime fromDate, DateTime toDate, string auditLogId = null, string filteredAdminUserId = null, string filteredIp = null, string filteredCmd = null, string advancedFilters = null, bool? descOrder = null, bool? withTotalCount = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (auditLogId != null)
                args["audit_log_id"] = auditLogId;
            if (filteredAdminUserId != null)
                args["filtered_admin_user_id"] = filteredAdminUserId;
            if (filteredIp != null)
                args["filtered_ip"] = filteredIp;
            if (filteredCmd != null)
                args["filtered_cmd"] = filteredCmd;
            if (advancedFilters != null)
                args["advanced_filters"] = advancedFilters;
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withTotalCount.HasValue)
                args["with_total_count"] = withTotalCount.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetAuditLogResponse>("GetAuditLog", args);
}
        /// <summary>
        /// The [GetAuditLog] asynchronous implementation. Use this function to download a large amounts of data. Take a look at the [GetHistoryReports] and [DownloadHistoryReport] functions for downloading details.
        /// </summary>
        /// <param name="fromDate">The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toDate">The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="auditLogId">The audit history ID list separated by semicolons (;)</param>
        /// <param name="filteredAdminUserId">The admin user ID to filter</param>
        /// <param name="filteredIp">The IP list separated by semicolons (;) to filter</param>
        /// <param name="filteredCmd">The function list separated by semicolons (;) to filter</param>
        /// <param name="advancedFilters">A relation ID to filter (for example: a phone_number value, a user_id value, an application_id value)</param>
        /// <param name="descOrder">Whether to get records in the descent order</param>
        /// <param name="withHeader">Whether to get a CSV file with the column names if the output=csv</param>
        /// <param name="output">The output format. The following values available: **csv**. The default value is **csv**</param>
        public async Task<GetAuditLogAsyncResponse> GetAuditLogAsync(DateTime fromDate, DateTime toDate, string auditLogId = null, string filteredAdminUserId = null, string filteredIp = null, string filteredCmd = null, string advancedFilters = null, bool? descOrder = null, bool? withHeader = null, string output = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (auditLogId != null)
                args["audit_log_id"] = auditLogId;
            if (filteredAdminUserId != null)
                args["filtered_admin_user_id"] = filteredAdminUserId;
            if (filteredIp != null)
                args["filtered_ip"] = filteredIp;
            if (filteredCmd != null)
                args["filtered_cmd"] = filteredCmd;
            if (advancedFilters != null)
                args["advanced_filters"] = advancedFilters;
            if (descOrder.HasValue)
                args["desc_order"] = descOrder.Value ? "1" : "0";
            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            if (output != null)
                args["output"] = output;
            return await PerformRequest<GetAuditLogAsyncResponse>("GetAuditLogAsync", args);
}
        /// <summary>
        /// Add a new phone number to the PSTN blacklist. Use blacklist to block incoming calls from specified phone numbers to numbers purchased from Voximplant. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        /// <param name="pstnBlacklistPhone">The phone number in format e164 or regex pattern</param>
        public async Task<AddPstnBlackListItemResponse> AddPstnBlackListItem(string pstnBlacklistPhone)
        {
            var args = new Dictionary<string, object>();

            args["pstn_blacklist_phone"] = pstnBlacklistPhone;
            return await PerformRequest<AddPstnBlackListItemResponse>("AddPstnBlackListItem", args);
}
        /// <summary>
        /// Update the PSTN blacklist item. BlackList works for numbers that are purchased from Voximplant only. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        /// <param name="pstnBlacklistId">The PSTN black list item ID</param>
        /// <param name="pstnBlacklistPhone">The new phone number in format e164</param>
        public async Task<SetPstnBlackListItemResponse> SetPstnBlackListItem(long pstnBlacklistId, string pstnBlacklistPhone)
        {
            var args = new Dictionary<string, object>();

            args["pstn_blacklist_id"] = pstnBlacklistId.ToString();
            args["pstn_blacklist_phone"] = pstnBlacklistPhone;
            return await PerformRequest<SetPstnBlackListItemResponse>("SetPstnBlackListItem", args);
}
        /// <summary>
        /// Remove phone number from the PSTN blacklist.
        /// </summary>
        /// <param name="pstnBlacklistId">The PSTN black list item ID</param>
        public async Task<DelPstnBlackListItemResponse> DelPstnBlackListItem(long pstnBlacklistId)
        {
            var args = new Dictionary<string, object>();

            args["pstn_blacklist_id"] = pstnBlacklistId.ToString();
            return await PerformRequest<DelPstnBlackListItemResponse>("DelPstnBlackListItem", args);
}
        /// <summary>
        /// Get the whole PSTN blacklist.
        /// </summary>
        /// <param name="pstnBlacklistId">The PSTN black list item ID for filter</param>
        /// <param name="pstnBlacklistPhone">The phone number in format e164 for filter</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetPstnBlackListResponse> GetPstnBlackList(long? pstnBlacklistId = null, string pstnBlacklistPhone = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (pstnBlacklistId.HasValue)
                args["pstn_blacklist_id"] = pstnBlacklistId.Value.ToString();
            if (pstnBlacklistPhone != null)
                args["pstn_blacklist_phone"] = pstnBlacklistPhone;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetPstnBlackListResponse>("GetPstnBlackList", args);
}
        /// <summary>
        /// Adds a new network address to the SIP white list.
        /// </summary>
        /// <param name="sipWhitelistNetwork">The network address in format A.B.C.D/L or A.B.C.D/a.b.c.d (example 192.168.1.5/16)</param>
        /// <param name="description">The network address description</param>
        public async Task<AddSipWhiteListItemResponse> AddSipWhiteListItem(string sipWhitelistNetwork, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["sip_whitelist_network"] = sipWhitelistNetwork;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<AddSipWhiteListItemResponse>("AddSipWhiteListItem", args);
}
        /// <summary>
        /// Deletes the network address from the SIP white list.
        /// </summary>
        /// <param name="sipWhitelistId">The SIP white list item ID to delete</param>
        public async Task<DelSipWhiteListItemResponse> DelSipWhiteListItem(long sipWhitelistId)
        {
            var args = new Dictionary<string, object>();

            args["sip_whitelist_id"] = sipWhitelistId.ToString();
            return await PerformRequest<DelSipWhiteListItemResponse>("DelSipWhiteListItem", args);
}
        /// <summary>
        /// Edits the SIP white list.
        /// </summary>
        /// <param name="sipWhitelistId">The SIP white list item ID</param>
        /// <param name="sipWhitelistNetwork">The new network address in format A.B.C.D/L or A.B.C.D/a.b.c.d (example 192.168.1.5/16)</param>
        /// <param name="description">The network address description</param>
        public async Task<SetSipWhiteListItemResponse> SetSipWhiteListItem(long sipWhitelistId, string sipWhitelistNetwork, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["sip_whitelist_id"] = sipWhitelistId.ToString();
            args["sip_whitelist_network"] = sipWhitelistNetwork;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<SetSipWhiteListItemResponse>("SetSipWhiteListItem", args);
}
        /// <summary>
        /// Gets the SIP white list.
        /// </summary>
        /// <param name="sipWhitelistId">The SIP white list item ID to filter</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetSipWhiteListResponse> GetSipWhiteList(long? sipWhitelistId = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (sipWhitelistId.HasValue)
                args["sip_whitelist_id"] = sipWhitelistId.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetSipWhiteListResponse>("GetSipWhiteList", args);
}
        /// <summary>
        /// Create a new SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should set is_persistent=true if you specify the user_id or user_name. You can bind only one SIP registration to the user (the previous SIP registration are automatically unbound).<br><br>Please note that when you create a SIP registration, we reserve the subscription fee and taxes for the upcoming month. Read more in the <a href='/docs/gettingstarted/billing'>Billing</a> page.
        /// </summary>
        /// <param name="sipUsername">The user name</param>
        /// <param name="proxy">The SIP proxy</param>
        /// <param name="authUser">The SIP authentications user</param>
        /// <param name="outboundProxy">The outgoing SIP proxy</param>
        /// <param name="password">The SIP password</param>
        /// <param name="isPersistent">Whether SIP registration is persistent. Set false to activate it only on the user login</param>
        /// <param name="applicationId">The application ID which a new SIP registration is to be bound to. Can be used instead of the <b>application_name</b> parameter</param>
        /// <param name="applicationName">The application name which a new SIP registration is to be bound to. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="ruleId">The rule ID which a new SIP registration is to be bound to. Can be used instead of the <b>rule_name</b> parameter</param>
        /// <param name="ruleName">The rule name which a new SIP registration is to be bound to. Can be used instead of the <b>rule_id</b> parameter</param>
        /// <param name="userId">The user ID which a new SIP registration is to be bound to. Can be used instead of the <b>user_name</b> parameter</param>
        /// <param name="userName">The user name which a new SIP registration is to be bound to. Can be used instead of the <b>user_id</b> parameter</param>
        public async Task<CreateSipRegistrationResponse> CreateSipRegistration(string sipUsername, string proxy, string authUser = null, string outboundProxy = null, string password = null, bool? isPersistent = null, long? applicationId = null, string applicationName = null, long? ruleId = null, string ruleName = null, long? userId = null, string userName = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into CreateSipRegistration");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into CreateSipRegistration");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into CreateSipRegistration");
    
            var args = new Dictionary<string, object>();

            args["sip_username"] = sipUsername;
            args["proxy"] = proxy;
            if (authUser != null)
                args["auth_user"] = authUser;
            if (outboundProxy != null)
                args["outbound_proxy"] = outboundProxy;
            if (password != null)
                args["password"] = password;
            if (isPersistent.HasValue)
                args["is_persistent"] = isPersistent.Value ? "1" : "0";
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            return await PerformRequest<CreateSipRegistrationResponse>("CreateSipRegistration", args);
}
        /// <summary>
        /// Update SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You can bind only one SIP registration to the user (the previous SIP registration is automatically unbound).
        /// </summary>
        /// <param name="sipRegistrationId">The registration ID</param>
        /// <param name="sipUsername">The user name</param>
        /// <param name="proxy">The SIP proxy</param>
        /// <param name="authUser">The SIP authentications user</param>
        /// <param name="outboundProxy">The outgoing SIP proxy</param>
        /// <param name="password">The SIP password</param>
        /// <param name="applicationId">The application ID which the SIP registration is to be bound to. Can be used instead of the <b>application_name</b> parameter</param>
        /// <param name="applicationName">The application name which the SIP registration is to be bound to. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="ruleId">The rule ID which the SIP registration is to be bound to. Can be used instead of the <b>rule_name</b> parameter</param>
        /// <param name="ruleName">The rule name which the SIP registration is to be bound to. Can be used instead of the <b>rule_id</b> parameter</param>
        /// <param name="userId">The user ID which the SIP registration is to be bound to. Can be used instead of the <b>user_name</b> parameter</param>
        /// <param name="userName">The user name which the SIP registration is to be bound to. Can be used instead of the <b>user_id</b> parameter</param>
        public async Task<UpdateSipRegistrationResponse> UpdateSipRegistration(long sipRegistrationId, string sipUsername = null, string proxy = null, string authUser = null, string outboundProxy = null, string password = null, long? applicationId = null, string applicationName = null, long? ruleId = null, string ruleName = null, long? userId = null, string userName = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into UpdateSipRegistration");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into UpdateSipRegistration");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into UpdateSipRegistration");
    
            var args = new Dictionary<string, object>();

            args["sip_registration_id"] = sipRegistrationId.ToString();
            if (sipUsername != null)
                args["sip_username"] = sipUsername;
            if (proxy != null)
                args["proxy"] = proxy;
            if (authUser != null)
                args["auth_user"] = authUser;
            if (outboundProxy != null)
                args["outbound_proxy"] = outboundProxy;
            if (password != null)
                args["password"] = password;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            return await PerformRequest<UpdateSipRegistrationResponse>("UpdateSipRegistration", args);
}
        /// <summary>
        /// Bind the SIP registration to the application/user or unbind the SIP registration from the application/user. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should specify the sip_registration_id if you set bind=true. You can bind only one SIP registration to the user (the previous SIP registration is automatically unbound).
        /// </summary>
        /// <param name="sipRegistrationId">The registration ID</param>
        /// <param name="applicationId">The application ID which the SIP registration is to be bound to. Can be used instead of the <b>application_name</b> parameter</param>
        /// <param name="applicationName">The application name which the SIP registration is to be bound to. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="ruleId">The rule ID which the SIP registration is to be bound to. Can be used instead of the <b>rule_name</b> parameter</param>
        /// <param name="ruleName">The rule name which the SIP registration is to be bound to. Can be used instead of the <b>rule_id</b> parameter</param>
        /// <param name="userId">The user ID which the SIP registration is to be bound to. Can be used instead of the <b>user_name</b> parameter</param>
        /// <param name="userName">The user name which the SIP registration is to be bound to. Can be used instead of the <b>user_id</b> parameter</param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindSipRegistrationResponse> BindSipRegistration(long? sipRegistrationId = null, long? applicationId = null, string applicationName = null, long? ruleId = null, string ruleName = null, long? userId = null, string userName = null, bool? bind = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSipRegistration");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSipRegistration");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSipRegistration");
    
            var args = new Dictionary<string, object>();

            if (sipRegistrationId.HasValue)
                args["sip_registration_id"] = sipRegistrationId.Value.ToString();
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindSipRegistrationResponse>("BindSipRegistration", args);
}
        /// <summary>
        /// Delete SIP registration.
        /// </summary>
        /// <param name="sipRegistrationId">The registration ID</param>
        public async Task<DeleteSipRegistrationResponse> DeleteSipRegistration(long sipRegistrationId)
        {
            var args = new Dictionary<string, object>();

            args["sip_registration_id"] = sipRegistrationId.ToString();
            return await PerformRequest<DeleteSipRegistrationResponse>("DeleteSipRegistration", args);
}
        /// <summary>
        /// Get active SIP registrations.
        /// </summary>
        /// <param name="sipRegistrationId">The SIP registration ID</param>
        /// <param name="sipUsername">The SIP user name to filter</param>
        /// <param name="deactivated">Whether to show the frozen SIP registrations only</param>
        /// <param name="successful">Whether to show the successful SIP registrations only</param>
        /// <param name="isPersistent">Whether the SIP registration is persistent to filter</param>
        /// <param name="applicationId">The application ID list separated by semicolons (;) to filter. Can be used instead of <b>application_name</b></param>
        /// <param name="applicationName">The application name list separated by semicolons (;) to filter. Can be used instead of <b>application_id</b></param>
        /// <param name="isBoundToApplication">Whether SIP registration bound to an application</param>
        /// <param name="ruleId">The rule ID list separated by semicolons (;) to filter. Can be used instead of <b>rule_name</b></param>
        /// <param name="ruleName">The rule name list separated by semicolons (;) to filter. Can be used instead of <b>rule_id</b></param>
        /// <param name="userId">The user ID list separated by semicolons (;) to filter. Can be used instead of <b>user_name</b></param>
        /// <param name="userName">The user name list separated by semicolons (;) to filter. Can be used instead of <b>user_id</b></param>
        /// <param name="proxy">The list of proxy servers to use, divided by semicolon (;)</param>
        /// <param name="inProgress">Whether SIP registration is still in progress</param>
        /// <param name="statusCode">The list of SIP response codes. The __code1:code2__ means a range from __code1__ to __code2__ including; the __code1;code2__ meanse either __code1__ or __code2__. You can combine ranges, e.g., __code1;code2:code3__</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetSipRegistrationsResponse> GetSipRegistrations(long? sipRegistrationId = null, string sipUsername = null, bool? deactivated = null, bool? successful = null, bool? isPersistent = null, string applicationId = null, string applicationName = null, bool? isBoundToApplication = null, string ruleId = null, string ruleName = null, string userId = null, string userName = null, string proxy = null, bool? inProgress = null, string statusCode = null, long? count = null, long? offset = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSipRegistrations");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSipRegistrations");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of ruleId, ruleName passed into GetSipRegistrations");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSipRegistrations");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of userId, userName passed into GetSipRegistrations");
    
            var args = new Dictionary<string, object>();

            if (sipRegistrationId.HasValue)
                args["sip_registration_id"] = sipRegistrationId.Value.ToString();
            if (sipUsername != null)
                args["sip_username"] = sipUsername;
            if (deactivated.HasValue)
                args["deactivated"] = deactivated.Value ? "1" : "0";
            if (successful.HasValue)
                args["successful"] = successful.Value ? "1" : "0";
            if (isPersistent.HasValue)
                args["is_persistent"] = isPersistent.Value ? "1" : "0";
            if (applicationId != null)
                args["application_id"] = applicationId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (isBoundToApplication.HasValue)
                args["is_bound_to_application"] = isBoundToApplication.Value ? "1" : "0";
            if (ruleId != null)
                args["rule_id"] = ruleId;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (proxy != null)
                args["proxy"] = proxy;
            if (inProgress.HasValue)
                args["in_progress"] = inProgress.Value ? "1" : "0";
            if (statusCode != null)
                args["status_code"] = statusCode;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetSipRegistrationsResponse>("GetSipRegistrations", args);
}
        /// <summary>
        /// Attach the phone number to the account. Note that phone numbers of some countries may require additional verification steps.<br><br>Please note that when you purchase a phone number, we reserve the subscription fee and taxes for the upcoming month. Read more in the <a href='/docs/gettingstarted/billing'>Billing</a> page.
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="phoneRegionId">The phone region ID. See the [GetPhoneNumberRegions] method</param>
        /// <param name="phoneCount">The phone count to attach</param>
        /// <param name="phoneNumber">The phone number that can be used instead of <b>phone_count</b>. See the [GetNewPhoneNumbers] method</param>
        /// <param name="countryState">The country state. See the [GetPhoneNumberCategories] and [GetPhoneNumberCountryStates] methods</param>
        /// <param name="regulationAddressId">The phone regulation address ID</param>
        public async Task<AttachPhoneNumberResponse> AttachPhoneNumber(string countryCode, string phoneCategoryName, long phoneRegionId, long? phoneCount = null, string phoneNumber = null, string countryState = null, long? regulationAddressId = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneCount != null)
                passedArgs.Add("phoneCount");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AttachPhoneNumber");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneCount, phoneNumber passed into AttachPhoneNumber");
    
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            args["phone_region_id"] = phoneRegionId.ToString();
            if (phoneCount.HasValue)
                args["phone_count"] = phoneCount.ToString();
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            if (countryState != null)
                args["country_state"] = countryState;
            if (regulationAddressId.HasValue)
                args["regulation_address_id"] = regulationAddressId.Value.ToString();
            return await PerformRequest<AttachPhoneNumberResponse>("AttachPhoneNumber", args);
}
        /// <summary>
        /// Bind the phone number to the application or unbind the phone number from the application. You should specify the application_id or application_name if you specify the rule_name.
        /// </summary>
        /// <param name="phoneId">The phone ID list separated by semicolons (;). Use the 'all' value to select all phone ids</param>
        /// <param name="phoneNumber">The phone number list separated by semicolons (;) that can be used instead of <b>phone_id</b></param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="ruleId">The rule ID</param>
        /// <param name="ruleName">The rule name that can be used instead of <b>rule_id</b></param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindPhoneNumberToApplicationResponse> BindPhoneNumberToApplication(string phoneId = null, string phoneNumber = null, long? applicationId = null, string applicationName = null, long? ruleId = null, string ruleName = null, bool? bind = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneId != null)
                passedArgs.Add("phoneId");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindPhoneNumberToApplication");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneId, phoneNumber passed into BindPhoneNumberToApplication");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindPhoneNumberToApplication");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into BindPhoneNumberToApplication");
    
            passedArgs = new List<string>();
        
            if (ruleId != null)
                passedArgs.Add("ruleId");
            if (ruleName != null)
                passedArgs.Add("ruleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindPhoneNumberToApplication");
    
            var args = new Dictionary<string, object>();

            if (phoneId != null)
                args["phone_id"] = phoneId;
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ruleId.HasValue)
                args["rule_id"] = ruleId.Value.ToString();
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindPhoneNumberToApplicationResponse>("BindPhoneNumberToApplication", args);
}
        /// <summary>
        /// Deactivates the phone number.
        /// </summary>
        /// <param name="phoneId">The phone ID list separated by semicolons (;). Use the 'all' value to select all phone ids</param>
        /// <param name="phoneNumber">The phone number list separated by semicolons (;) that can be used instead of <b>phone_id</b></param>
        public async Task<DeactivatePhoneNumberResponse> DeactivatePhoneNumber(string phoneId = null, string phoneNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneId != null)
                passedArgs.Add("phoneId");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DeactivatePhoneNumber");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneId, phoneNumber passed into DeactivatePhoneNumber");
    
            var args = new Dictionary<string, object>();

            if (phoneId != null)
                args["phone_id"] = phoneId;
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            return await PerformRequest<DeactivatePhoneNumberResponse>("DeactivatePhoneNumber", args);
}
        /// <summary>
        /// Set the phone number information.
        /// </summary>
        /// <param name="phoneId">The phone ID list separated by semicolons (;). Use the 'all' value to select all phone ids</param>
        /// <param name="phoneNumber">The phone number list separated by semicolons (;) that can be used instead of <b>phone_id</b></param>
        /// <param name="incomingSmsCallbackUrl">If set, the callback of an incoming SMS is sent to this url, otherwise, it is sent to the general account URL</param>
        public async Task<SetPhoneNumberInfoResponse> SetPhoneNumberInfo(string phoneId = null, string phoneNumber = null, string incomingSmsCallbackUrl = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneId != null)
                passedArgs.Add("phoneId");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetPhoneNumberInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneId, phoneNumber passed into SetPhoneNumberInfo");
    
            var args = new Dictionary<string, object>();

            if (phoneId != null)
                args["phone_id"] = phoneId;
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            if (incomingSmsCallbackUrl != null)
                args["incoming_sms_callback_url"] = incomingSmsCallbackUrl;
            return await PerformRequest<SetPhoneNumberInfoResponse>("SetPhoneNumberInfo", args);
}
        /// <summary>
        /// Gets the account phone numbers.
        /// </summary>
        /// <param name="phoneId">The particular phone ID to filter</param>
        /// <param name="phoneNumber">The phone number list separated by semicolons (;) that can be used instead of <b>phone_id</b></param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="isBoundToApplication">Whether the phone number bound to an application</param>
        /// <param name="phoneTemplate">The phone number start to filter</param>
        /// <param name="countryCode">The country code list separated by semicolons (;)</param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="canceled">Whether the subscription is cancelled to filter</param>
        /// <param name="deactivated">Whether the subscription is frozen to filter</param>
        /// <param name="autoCharge">Whether the auto_charge flag is enabled</param>
        /// <param name="fromPhoneNextRenewal">The UTC 'from' date filter in format: YYYY-MM-DD</param>
        /// <param name="toPhoneNextRenewal">The UTC 'to' date filter in format: YYYY-MM-DD</param>
        /// <param name="fromPhonePurchaseDate">The UTC 'from' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="toPhonePurchaseDate">The UTC 'to' date filter in 24-h format: YYYY-MM-DD HH:mm:ss</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;). Use the 'all' value to select all child accounts</param>
        /// <param name="childrenPhonesOnly">Whether to get the children phones only</param>
        /// <param name="verificationName">The required account verification name to filter</param>
        /// <param name="verificationStatus">The account verification status list separated by semicolons (;). The following values are possible: REQUIRED, IN_PROGRESS, VERIFIED</param>
        /// <param name="fromUnverifiedHoldUntil">Unverified phone hold until the date (from ...) in format: YYYY-MM-DD</param>
        /// <param name="toUnverifiedHoldUntil">Unverified phone hold until the date (... to) in format: YYYY-MM-DD</param>
        /// <param name="canBeUsed">Whether a not verified account can use the phone</param>
        /// <param name="orderBy">The following values are available: 'phone_number' (ascent order), 'phone_price' (ascent order), 'phone_country_code' (ascent order), 'deactivated' (deactivated first, active last), 'purchase_date' (descent order), 'phone_next_renewal' (ascent order), 'verification_status', 'unverified_hold_until' (ascent order), 'verification_name'</param>
        /// <param name="sandbox">Flag allows you to display only the numbers of the sandbox, real numbers, or all numbers. The following values are possible: 'all', 'true', 'false'</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="phoneRegionName">The region names list separated by semicolons (;)</param>
        /// <param name="ruleId">The rule ID list separated by semicolons (;)</param>
        /// <param name="ruleName">The rule names list separated by semicolons (;). Can be used only if __application_id__ or __application_name__ is specified</param>
        /// <param name="isBoundToRule">Whether the phone number is bound to some rule</param>
        public async Task<GetPhoneNumbersResponse> GetPhoneNumbers(string phoneId = null, string phoneNumber = null, long? applicationId = null, string applicationName = null, bool? isBoundToApplication = null, string phoneTemplate = null, string countryCode = null, string phoneCategoryName = null, bool? canceled = null, bool? deactivated = null, bool? autoCharge = null, DateTime? fromPhoneNextRenewal = null, DateTime? toPhoneNextRenewal = null, DateTime? fromPhonePurchaseDate = null, DateTime? toPhonePurchaseDate = null, string childAccountId = null, bool? childrenPhonesOnly = null, string verificationName = null, string verificationStatus = null, DateTime? fromUnverifiedHoldUntil = null, DateTime? toUnverifiedHoldUntil = null, bool? canBeUsed = null, string orderBy = null, string sandbox = null, long? count = null, long? offset = null, string phoneRegionName = null, string ruleId = null, string ruleName = null, bool? isBoundToRule = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetPhoneNumbers");
    
            var args = new Dictionary<string, object>();

            if (phoneId != null)
                args["phone_id"] = phoneId;
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (isBoundToApplication.HasValue)
                args["is_bound_to_application"] = isBoundToApplication.Value ? "1" : "0";
            if (phoneTemplate != null)
                args["phone_template"] = phoneTemplate;
            if (countryCode != null)
                args["country_code"] = countryCode;
            if (phoneCategoryName != null)
                args["phone_category_name"] = phoneCategoryName;
            if (canceled.HasValue)
                args["canceled"] = canceled.Value ? "1" : "0";
            if (deactivated.HasValue)
                args["deactivated"] = deactivated.Value ? "1" : "0";
            if (autoCharge.HasValue)
                args["auto_charge"] = autoCharge.Value ? "1" : "0";
            if (fromPhoneNextRenewal.HasValue)
                args["from_phone_next_renewal"] = fromPhoneNextRenewal.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (toPhoneNextRenewal.HasValue)
                args["to_phone_next_renewal"] = toPhoneNextRenewal.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (fromPhonePurchaseDate.HasValue)
                args["from_phone_purchase_date"] = fromPhonePurchaseDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toPhonePurchaseDate.HasValue)
                args["to_phone_purchase_date"] = toPhonePurchaseDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenPhonesOnly.HasValue)
                args["children_phones_only"] = childrenPhonesOnly.Value ? "1" : "0";
            if (verificationName != null)
                args["verification_name"] = verificationName;
            if (verificationStatus != null)
                args["verification_status"] = verificationStatus;
            if (fromUnverifiedHoldUntil.HasValue)
                args["from_unverified_hold_until"] = fromUnverifiedHoldUntil.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (toUnverifiedHoldUntil.HasValue)
                args["to_unverified_hold_until"] = toUnverifiedHoldUntil.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (canBeUsed.HasValue)
                args["can_be_used"] = canBeUsed.Value ? "1" : "0";
            if (orderBy != null)
                args["order_by"] = orderBy;
            if (sandbox != null)
                args["sandbox"] = sandbox;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (phoneRegionName != null)
                args["phone_region_name"] = phoneRegionName;
            if (ruleId != null)
                args["rule_id"] = ruleId;
            if (ruleName != null)
                args["rule_name"] = ruleName;
            if (isBoundToRule.HasValue)
                args["is_bound_to_rule"] = isBoundToRule.Value ? "1" : "0";
            return await PerformRequest<GetPhoneNumbersResponse>("GetPhoneNumbers", args);
}
        /// <summary>
        /// Checks if the phone number belongs to the authorized account.
        /// </summary>
        /// <param name="phoneNumber">Phone number to check in the international format without `+`</param>
        public async Task<IsAccountPhoneNumberResponse> IsAccountPhoneNumber(string phoneNumber)
        {
            var args = new Dictionary<string, object>();

            args["phone_number"] = phoneNumber;
            return await PerformRequest<IsAccountPhoneNumberResponse>("IsAccountPhoneNumber", args);
}
        /// <summary>
        /// Gets the asynchronous report regarding purchased phone numbers.
        /// </summary>
        /// <param name="withHeader">Whether to get a CSV file with the column names</param>
        public async Task<GetPhoneNumbersAsyncResponse> GetPhoneNumbersAsync(bool? withHeader = null)
        {
            var args = new Dictionary<string, object>();

            if (withHeader.HasValue)
                args["with_header"] = withHeader.Value ? "1" : "0";
            return await PerformRequest<GetPhoneNumbersAsyncResponse>("GetPhoneNumbersAsync", args);
}
        /// <summary>
        /// Gets the new phone numbers.
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] function</param>
        /// <param name="phoneRegionId">The phone region ID. See the [GetPhoneNumberRegions] method</param>
        /// <param name="countryState">The country state. See the GetPhoneNumberCategories and GetPhoneNumberCountryStates functions</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="phoneNumberMask">The phone number searching mask. Asterisk represents zero or more occurrences of any character</param>
        public async Task<GetNewPhoneNumbersResponse> GetNewPhoneNumbers(string countryCode, string phoneCategoryName, long phoneRegionId, string countryState = null, long? count = null, long? offset = null, string phoneNumberMask = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            args["phone_region_id"] = phoneRegionId.ToString();
            if (countryState != null)
                args["country_state"] = countryState;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (phoneNumberMask != null)
                args["phone_number_mask"] = phoneNumberMask;
            return await PerformRequest<GetNewPhoneNumbersResponse>("GetNewPhoneNumbers", args);
}
        /// <summary>
        /// Gets the phone number categories.
        /// </summary>
        /// <param name="countryCode">Country code list separated by semicolons (;)</param>
        /// <param name="sandbox">Flag allows you to display phone number categories only of the sandbox, real or all .The following values are possible: 'all', 'true', 'false'</param>
        /// <param name="locale">The 2-letter locale code. Supported values are EN, RU</param>
        public async Task<GetPhoneNumberCategoriesResponse> GetPhoneNumberCategories(string countryCode = null, string sandbox = null, string locale = null)
        {
            var args = new Dictionary<string, object>();

            if (countryCode != null)
                args["country_code"] = countryCode;
            if (sandbox != null)
                args["sandbox"] = sandbox;
            if (locale != null)
                args["locale"] = locale;
            return await PerformRequest<GetPhoneNumberCategoriesResponse>("GetPhoneNumberCategories", args);
}
        /// <summary>
        /// Gets the phone number country states.
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <param name="phoneCategoryName">The phone category name. See the GetPhoneNumberCategories function</param>
        /// <param name="countryState">The country state code (example: AL, CA, ... )</param>
        public async Task<GetPhoneNumberCountryStatesResponse> GetPhoneNumberCountryStates(string countryCode, string phoneCategoryName, string countryState = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            if (countryState != null)
                args["country_state"] = countryState;
            return await PerformRequest<GetPhoneNumberCountryStatesResponse>("GetPhoneNumberCountryStates", args);
}
        /// <summary>
        /// Get the country regions of the phone numbers. The response also contains the info about multiple numbers subscription for the child accounts.
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="countryState">The country state code (example: AL, CA, ... )</param>
        /// <param name="omitEmpty">Whether not to show all the regions (with and without phone numbers in stock)</param>
        /// <param name="phoneRegionId">The phone region ID to filter</param>
        /// <param name="phoneRegionName">The phone region name to filter</param>
        /// <param name="phoneRegionCode">The region phone prefix to filter</param>
        /// <param name="locale">The 2-letter locale code. Supported values are EN, RU</param>
        public async Task<GetPhoneNumberRegionsResponse> GetPhoneNumberRegions(string countryCode, string phoneCategoryName, string countryState = null, bool? omitEmpty = null, long? phoneRegionId = null, string phoneRegionName = null, string phoneRegionCode = null, string locale = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            if (countryState != null)
                args["country_state"] = countryState;
            if (omitEmpty.HasValue)
                args["omit_empty"] = omitEmpty.Value ? "1" : "0";
            if (phoneRegionId.HasValue)
                args["phone_region_id"] = phoneRegionId.Value.ToString();
            if (phoneRegionName != null)
                args["phone_region_name"] = phoneRegionName;
            if (phoneRegionCode != null)
                args["phone_region_code"] = phoneRegionCode;
            if (locale != null)
                args["locale"] = locale;
            return await PerformRequest<GetPhoneNumberRegionsResponse>("GetPhoneNumberRegions", args);
}
        /// <summary>
        /// Get actual info on the country region of the phone numbers. The response also contains the info about multiple numbers subscription for the child accounts.
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="phoneRegionId">The phone region ID to filter</param>
        /// <param name="countryState">The country state code (example: AL, CA, ... )</param>
        /// <param name="locale">The 2-letter locale code. Supported values are EN, RU</param>
        public async Task<GetActualPhoneNumberRegionResponse> GetActualPhoneNumberRegion(string countryCode, string phoneCategoryName, long phoneRegionId, string countryState = null, string locale = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            args["phone_region_id"] = phoneRegionId.ToString();
            if (countryState != null)
                args["country_state"] = countryState;
            if (locale != null)
                args["locale"] = locale;
            return await PerformRequest<GetActualPhoneNumberRegionResponse>("GetActualPhoneNumberRegion", args);
}
        /// <summary>
        /// Adds a new caller ID. Caller ID is the phone that is displayed to the called user. This number can be used for call back.
        /// </summary>
        /// <param name="calleridNumber">The callerID number in E.164 format</param>
        public async Task<AddCallerIDResponse> AddCallerID(string calleridNumber)
        {
            var args = new Dictionary<string, object>();

            args["callerid_number"] = calleridNumber;
            return await PerformRequest<AddCallerIDResponse>("AddCallerID", args);
}
        /// <summary>
        /// Activates the CallerID by the verification code.
        /// </summary>
        /// <param name="verificationCode">The verification code, see the VerifyCallerID function</param>
        /// <param name="calleridId">ID of the callerID object</param>
        /// <param name="calleridNumber">The callerID number that can be used instead of <b>callerid_id</b></param>
        public async Task<ActivateCallerIDResponse> ActivateCallerID(string verificationCode, long? calleridId = null, string calleridNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (calleridId != null)
                passedArgs.Add("calleridId");
            if (calleridNumber != null)
                passedArgs.Add("calleridNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into ActivateCallerID");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of calleridId, calleridNumber passed into ActivateCallerID");
    
            var args = new Dictionary<string, object>();

            args["verification_code"] = verificationCode;
            if (calleridId.HasValue)
                args["callerid_id"] = calleridId.ToString();
            if (calleridNumber != null)
                args["callerid_number"] = calleridNumber;
            return await PerformRequest<ActivateCallerIDResponse>("ActivateCallerID", args);
}
        /// <summary>
        /// Deletes the CallerID. Note: you cannot delete a CID permanently (the antispam defence).
        /// </summary>
        /// <param name="calleridId">ID of the callerID object</param>
        /// <param name="calleridNumber">The callerID number that can be used instead of <b>callerid_id</b></param>
        public async Task<DelCallerIDResponse> DelCallerID(long? calleridId = null, string calleridNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (calleridId != null)
                passedArgs.Add("calleridId");
            if (calleridNumber != null)
                passedArgs.Add("calleridNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelCallerID");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of calleridId, calleridNumber passed into DelCallerID");
    
            var args = new Dictionary<string, object>();

            if (calleridId.HasValue)
                args["callerid_id"] = calleridId.ToString();
            if (calleridNumber != null)
                args["callerid_number"] = calleridNumber;
            return await PerformRequest<DelCallerIDResponse>("DelCallerID", args);
}
        /// <summary>
        /// Gets the account callerIDs.
        /// </summary>
        /// <param name="calleridId">ID of the callerID object to filter</param>
        /// <param name="calleridNumber">The phone number to filter</param>
        /// <param name="active">Whether the account is active to filter</param>
        /// <param name="orderBy">The following values are available: 'caller_number' (ascent order), 'verified_until' (ascent order)</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetCallerIDsResponse> GetCallerIDs(long? calleridId = null, string calleridNumber = null, bool? active = null, string orderBy = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (calleridId.HasValue)
                args["callerid_id"] = calleridId.Value.ToString();
            if (calleridNumber != null)
                args["callerid_number"] = calleridNumber;
            if (active.HasValue)
                args["active"] = active.Value ? "1" : "0";
            if (orderBy != null)
                args["order_by"] = orderBy;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetCallerIDsResponse>("GetCallerIDs", args);
}
        /// <summary>
        /// Gets a verification code via phone call to the **callerid_number**.
        /// </summary>
        /// <param name="calleridId">ID of the callerID object</param>
        /// <param name="calleridNumber">The callerID number that can be used instead of <b>callerid_id</b></param>
        public async Task<VerifyCallerIDResponse> VerifyCallerID(long? calleridId = null, string calleridNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (calleridId != null)
                passedArgs.Add("calleridId");
            if (calleridNumber != null)
                passedArgs.Add("calleridNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into VerifyCallerID");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of calleridId, calleridNumber passed into VerifyCallerID");
    
            var args = new Dictionary<string, object>();

            if (calleridId.HasValue)
                args["callerid_id"] = calleridId.ToString();
            if (calleridNumber != null)
                args["callerid_number"] = calleridNumber;
            return await PerformRequest<VerifyCallerIDResponse>("VerifyCallerID", args);
}
        /// <summary>
        /// Adds a personal phone number to test outgoing calls. Only one personal phone number can be used. To replace it with another, delete the existing one first.
        /// </summary>
        /// <param name="phoneNumber">The personal phone number in the E.164 format</param>
        public async Task<AddOutboundTestPhoneNumberResponse> AddOutboundTestPhoneNumber(string phoneNumber)
        {
            var args = new Dictionary<string, object>();

            args["phone_number"] = phoneNumber;
            return await PerformRequest<AddOutboundTestPhoneNumberResponse>("AddOutboundTestPhoneNumber", args);
}
        /// <summary>
        /// Starts a call to the added phone number and pronounces a verification code. You have only 5 verification attempts per day and 100 in total. 1 minute should pass between 2 attempts.
        /// </summary>
        public async Task<VerifyOutboundTestPhoneNumberResponse> VerifyOutboundTestPhoneNumber()
        {
            var args = new Dictionary<string, object>();

            return await PerformRequest<VerifyOutboundTestPhoneNumberResponse>("VerifyOutboundTestPhoneNumber", args);
}
        /// <summary>
        /// Activates the phone number by the verification code.
        /// </summary>
        /// <param name="verificationCode">The verification code, see the [VerifyOutboundTestPhoneNumber] function</param>
        public async Task<ActivateOutboundTestPhoneNumberResponse> ActivateOutboundTestPhoneNumber(string verificationCode)
        {
            var args = new Dictionary<string, object>();

            args["verification_code"] = verificationCode;
            return await PerformRequest<ActivateOutboundTestPhoneNumberResponse>("ActivateOutboundTestPhoneNumber", args);
}
        /// <summary>
        /// Deletes the existing phone number.
        /// </summary>
        public async Task<DelOutboundTestPhoneNumberResponse> DelOutboundTestPhoneNumber()
        {
            var args = new Dictionary<string, object>();

            return await PerformRequest<DelOutboundTestPhoneNumberResponse>("DelOutboundTestPhoneNumber", args);
}
        /// <summary>
        /// Shows the phone number info.
        /// </summary>
        public async Task<GetOutboundTestPhoneNumbersResponse> GetOutboundTestPhoneNumbers()
        {
            var args = new Dictionary<string, object>();

            return await PerformRequest<GetOutboundTestPhoneNumbersResponse>("GetOutboundTestPhoneNumbers", args);
}
        /// <summary>
        /// Adds a new ACD queue.
        /// </summary>
        /// <param name="acdQueueName">The queue name. The length must be less than 100</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="acdQueuePriority">The integer queue priority. The highest priority is 0</param>
        /// <param name="autoBinding">Whether to enable the auto binding of operators to a queue by skills comparing</param>
        /// <param name="serviceProbability">The value in the range of [0.5 ... 1.0]. The value 1.0 means the service probability 100% in challenge with a lower priority queue</param>
        /// <param name="maxQueueSize">The max queue size</param>
        /// <param name="maxWaitingTime">The max predicted waiting time in minutes. The client is rejected if the predicted waiting time is greater than the max predicted waiting time</param>
        /// <param name="averageServiceTime">The average service time in seconds. Specify the parameter to correct or initialize the waiting time prediction</param>
        public async Task<AddQueueResponse> AddQueue(string acdQueueName, long? applicationId = null, string applicationName = null, long? acdQueuePriority = null, bool? autoBinding = null, long? serviceProbability = null, long? maxQueueSize = null, long? maxWaitingTime = null, long? averageServiceTime = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddQueue");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into AddQueue");
    
            var args = new Dictionary<string, object>();

            args["acd_queue_name"] = acdQueueName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (acdQueuePriority.HasValue)
                args["acd_queue_priority"] = acdQueuePriority.Value.ToString();
            if (autoBinding.HasValue)
                args["auto_binding"] = autoBinding.Value ? "1" : "0";
            if (serviceProbability.HasValue)
                args["service_probability"] = serviceProbability.Value.ToString();
            if (maxQueueSize.HasValue)
                args["max_queue_size"] = maxQueueSize.Value.ToString();
            if (maxWaitingTime.HasValue)
                args["max_waiting_time"] = maxWaitingTime.Value.ToString();
            if (averageServiceTime.HasValue)
                args["average_service_time"] = averageServiceTime.Value.ToString();
            return await PerformRequest<AddQueueResponse>("AddQueue", args);
}
        /// <summary>
        /// Bind/unbind users to/from the specified ACD queues. Note that users and queues should be already bound to the same application.
        /// </summary>
        /// <param name="bind">Whether to bind or unbind users</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="userId">The user ID list separated by semicolons (;). Use the 'all' value to specify all users bound to the application</param>
        /// <param name="userName">The user name list separated by semicolons (;). <b>user_name</b> can be used instead of <b>user_id</b></param>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;). Use the 'all' value to specify all queues bound to the application</param>
        /// <param name="acdQueueName">The queue name that can be used instead of <b>acd_queue_id</b>. The queue name list separated by semicolons (;)</param>
        public async Task<BindUserToQueueResponse> BindUserToQueue(bool bind, long? applicationId = null, string applicationName = null, string userId = null, string userName = null, string acdQueueId = null, string acdQueueName = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindUserToQueue");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into BindUserToQueue");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindUserToQueue");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of userId, userName passed into BindUserToQueue");
    
            passedArgs = new List<string>();
        
            if (acdQueueId != null)
                passedArgs.Add("acdQueueId");
            if (acdQueueName != null)
                passedArgs.Add("acdQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindUserToQueue");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of acdQueueId, acdQueueName passed into BindUserToQueue");
    
            var args = new Dictionary<string, object>();

            args["bind"] = bind.ToString();
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (acdQueueName != null)
                args["acd_queue_name"] = acdQueueName;
            return await PerformRequest<BindUserToQueueResponse>("BindUserToQueue", args);
}
        /// <summary>
        /// Deletes the ACD queue.
        /// </summary>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;)</param>
        /// <param name="acdQueueName">The ACD queue name that can be used instead of <b>acd_queue_id</b>. The ACD queue name list separated by semicolons (;)</param>
        public async Task<DelQueueResponse> DelQueue(string acdQueueId = null, string acdQueueName = null)
        {
            var passedArgs = new List<string>();
        
            if (acdQueueId != null)
                passedArgs.Add("acdQueueId");
            if (acdQueueName != null)
                passedArgs.Add("acdQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelQueue");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of acdQueueId, acdQueueName passed into DelQueue");
    
            var args = new Dictionary<string, object>();

            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (acdQueueName != null)
                args["acd_queue_name"] = acdQueueName;
            return await PerformRequest<DelQueueResponse>("DelQueue", args);
}
        /// <summary>
        /// Edits the ACD queue.
        /// </summary>
        /// <param name="acdQueueId">The ACD queue ID</param>
        /// <param name="acdQueueName">The ACD queue name that can be used instead of <b>acd_queue_id</b></param>
        /// <param name="newAcdQueueName">The new queue name. The length must be less than 100</param>
        /// <param name="acdQueuePriority">The integer queue priority. The highest priority is 0</param>
        /// <param name="autoBinding">Whether to enable the auto binding of operators to a queue by skills comparing</param>
        /// <param name="serviceProbability">The value in the range of [0.5 ... 1.0]. The value 1.0 means the service probability 100% in challenge with a lower priority queue</param>
        /// <param name="maxQueueSize">The max queue size</param>
        /// <param name="maxWaitingTime">The max predicted waiting time in minutes. The client is rejected if the predicted waiting time is greater than the max predicted waiting time</param>
        /// <param name="averageServiceTime">The average service time in seconds. Specify the parameter to correct or initialize the waiting time prediction</param>
        /// <param name="applicationId">The new application ID</param>
        public async Task<SetQueueInfoResponse> SetQueueInfo(long? acdQueueId = null, string acdQueueName = null, string newAcdQueueName = null, long? acdQueuePriority = null, bool? autoBinding = null, long? serviceProbability = null, long? maxQueueSize = null, long? maxWaitingTime = null, long? averageServiceTime = null, long? applicationId = null)
        {
            var passedArgs = new List<string>();
        
            if (acdQueueId != null)
                passedArgs.Add("acdQueueId");
            if (acdQueueName != null)
                passedArgs.Add("acdQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetQueueInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of acdQueueId, acdQueueName passed into SetQueueInfo");
    
            var args = new Dictionary<string, object>();

            if (acdQueueId.HasValue)
                args["acd_queue_id"] = acdQueueId.ToString();
            if (acdQueueName != null)
                args["acd_queue_name"] = acdQueueName;
            if (newAcdQueueName != null)
                args["new_acd_queue_name"] = newAcdQueueName;
            if (acdQueuePriority.HasValue)
                args["acd_queue_priority"] = acdQueuePriority.Value.ToString();
            if (autoBinding.HasValue)
                args["auto_binding"] = autoBinding.Value ? "1" : "0";
            if (serviceProbability.HasValue)
                args["service_probability"] = serviceProbability.Value.ToString();
            if (maxQueueSize.HasValue)
                args["max_queue_size"] = maxQueueSize.Value.ToString();
            if (maxWaitingTime.HasValue)
                args["max_waiting_time"] = maxWaitingTime.Value.ToString();
            if (averageServiceTime.HasValue)
                args["average_service_time"] = averageServiceTime.Value.ToString();
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            return await PerformRequest<SetQueueInfoResponse>("SetQueueInfo", args);
}
        /// <summary>
        /// Gets the ACD queues.
        /// </summary>
        /// <param name="acdQueueId">The ACD queue ID to filter</param>
        /// <param name="acdQueueName">The ACD queue name part to filter</param>
        /// <param name="applicationId">The application ID to filter</param>
        /// <param name="skillId">The skill ID to filter</param>
        /// <param name="excludedSkillId">The excluded skill ID to filter</param>
        /// <param name="withSkills">Whether to get the bound skills</param>
        /// <param name="showingSkillId">The skill to show in the 'skills' field output</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="withOperatorcount">Whether to include the number of agents bound to the queue</param>
        public async Task<GetQueuesResponse> GetQueues(long? acdQueueId = null, string acdQueueName = null, long? applicationId = null, long? skillId = null, long? excludedSkillId = null, bool? withSkills = null, long? showingSkillId = null, long? count = null, long? offset = null, bool? withOperatorcount = null)
        {
            var args = new Dictionary<string, object>();

            if (acdQueueId.HasValue)
                args["acd_queue_id"] = acdQueueId.Value.ToString();
            if (acdQueueName != null)
                args["acd_queue_name"] = acdQueueName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (skillId.HasValue)
                args["skill_id"] = skillId.Value.ToString();
            if (excludedSkillId.HasValue)
                args["excluded_skill_id"] = excludedSkillId.Value.ToString();
            if (withSkills.HasValue)
                args["with_skills"] = withSkills.Value ? "1" : "0";
            if (showingSkillId.HasValue)
                args["showing_skill_id"] = showingSkillId.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (withOperatorcount.HasValue)
                args["with_operatorcount"] = withOperatorcount.Value ? "1" : "0";
            return await PerformRequest<GetQueuesResponse>("GetQueues", args);
}
        /// <summary>
        /// Gets the current ACD queue state.
        /// </summary>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;). Use the 'all' value to select all ACD queues</param>
        public async Task<GetACDStateResponse> GetACDState(string acdQueueId = null)
        {
            var args = new Dictionary<string, object>();

            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            return await PerformRequest<GetACDStateResponse>("GetACDState", args);
}
        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'ACD' module. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        /// <param name="fromDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="userId">The user ID list separated by semicolons (;). Use the 'all' value to select all users</param>
        /// <param name="toDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;). Use the 'all' value to select all ACD queues</param>
        /// <param name="abbreviation">Whether key names in returned JSON are abbreviated to reduce response byte size. The abbreviations are: 'SA' for 'SpeedOfAnswer', 'HT' for 'HandlingTime', 'TT' for 'TalkTime', 'ACW' for 'AfterCallWork', 'TDT' for 'TotalDialingTime', 'THT' for 'TotalHandlingTime', 'TTT' for 'TotalTalkTime', 'TACW' for 'TotalAfterCallWork', 'AC' for 'AnsweredCalls', 'UAC' for 'UnansweredCalls'</param>
        /// <param name="report">List of item names abbreviations separated by semicolons (;). Returned JSON includes keys only for the selected items. Special 'all' value defines all possible items, see [ACDOperatorStatisticsType] for a complete list. See 'abbreviation' description for complete abbreviation list</param>
        /// <param name="aggregation">Specifies how records are grouped by date and time. If set to 'day', the criteria is a day number. If set to 'hour_of_day', the criteria is a 60-minute interval within a day. If set to 'hour', the criteria is both day number and 60-minute interval within that day. If set to 'none', records are not grouped by date and time</param>
        /// <param name="group">If set to 'user', first-level array in the resulting JSON groups records by the user ID, and second-level array groups them by date according to the 'aggregation' parameter. If set to 'aggregation', first-level array in the resulting JSON groups records according to the 'aggregation' parameter, and second-level array groups them by the user ID</param>
        public async Task<GetACDOperatorStatisticsResponse> GetACDOperatorStatistics(DateTime fromDate, string userId, DateTime? toDate = null, string acdQueueId = null, bool? abbreviation = null, string report = null, string aggregation = null, string group = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["user_id"] = userId;
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (abbreviation.HasValue)
                args["abbreviation"] = abbreviation.Value ? "1" : "0";
            if (report != null)
                args["report"] = report;
            if (aggregation != null)
                args["aggregation"] = aggregation;
            if (group != null)
                args["group"] = group;
            return await PerformRequest<GetACDOperatorStatisticsResponse>("GetACDOperatorStatistics", args);
}
        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'queue' distribution system. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        /// <param name="fromDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="toDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="abbreviation">Whether key names in returned JSON are abbreviated to reduce response byte size. The abbreviations are: 'WT' for 'WaitingTime', 'SA' for 'SpeedOfAnswer', 'AT' is for 'AbandonmentTime', 'HT' is for 'HandlingTime', 'TT' is for 'TalkTime', 'ACW' is for 'AfterCallWork', 'QL' is for 'QueueLength', 'TC' is for 'TotalCalls', 'AC' is for 'AnsweredCalls', 'UAC' is for 'UnansweredCalls', 'RC' is for 'RejectedCalls', 'SL' is for 'ServiceLevel', 'TWT' is for 'TotalWaitingTime', 'TST' is for 'TotalSubmissionTime', 'TAT' is for 'TotalAbandonmentTime', 'THT' is for 'TotalHandlingTime', 'TTT' is for 'TotalTalkTime', 'TACW' is for 'TotalAfterCallWork'</param>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;). Use the 'all' value to select all ACD queues</param>
        /// <param name="report">List of item names abbreviations separated by semicolons (;). Returned JSON includes keys only for the selected items. Special 'all' value defines all possible items, see [ACDQueueStatisticsType] for a complete list. See 'abbreviation' description for complete abbreviation list</param>
        /// <param name="aggregation">Specifies how records are grouped by date and time. If set to 'day', the criteria is a day number. If set to 'hour_of_day', the criteria is a 60-minute interval within a day. If set to 'hour', the criteria is both day number and 60-minute interval within that day. If set to 'none', records are not grouped by date and time</param>
        public async Task<GetACDQueueStatisticsResponse> GetACDQueueStatistics(DateTime fromDate, DateTime? toDate = null, bool? abbreviation = null, string acdQueueId = null, string report = null, string aggregation = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (abbreviation.HasValue)
                args["abbreviation"] = abbreviation.Value ? "1" : "0";
            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (report != null)
                args["report"] = report;
            if (aggregation != null)
                args["aggregation"] = aggregation;
            return await PerformRequest<GetACDQueueStatisticsResponse>("GetACDQueueStatistics", args);
}
        /// <summary>
        /// Get statistics for the specified operators and ACD statuses. This method can filter statistics by operator ids and statuses. It can also group results by day/hour or users.
        /// </summary>
        /// <param name="fromDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="userId">The user ID list separated by semicolons (;). Use the 'all' value to select all users</param>
        /// <param name="toDate">Date and time of statistics interval begin. Time zone is UTC, format is 24-h 'YYYY-MM-DD HH:mm:ss'</param>
        /// <param name="acdStatus">The ACD status list separated by semicolons (;). The following values are possible: OFFLINE, ONLINE, READY, BANNED, IN_SERVICE, AFTER_SERVICE, TIMEOUT, DND</param>
        /// <param name="aggregation">Specifies how records are grouped by date and time. If set to 'day', the criteria is a day number. If set to 'hour_of_day', the criteria is a 60-minute interval within a day. If set to 'hour', the criteria is both day number and 60-minute interval within that day. If set to 'none', records are not grouped by date and time</param>
        /// <param name="group">If set to 'user', first-level array in the resulting JSON groups records by the user ID, and second-level array groups them by date according to the 'aggregation' parameter. If set to 'aggregation', first-level array in the resulting JSON groups records according to the 'aggregation' parameter, and second-level array groups them by the user ID</param>
        public async Task<GetACDOperatorStatusStatisticsResponse> GetACDOperatorStatusStatistics(DateTime fromDate, string userId, DateTime? toDate = null, string acdStatus = null, string aggregation = null, string group = null)
        {
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["user_id"] = userId;
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (acdStatus != null)
                args["acd_status"] = acdStatus;
            if (aggregation != null)
                args["aggregation"] = aggregation;
            if (group != null)
                args["group"] = group;
            return await PerformRequest<GetACDOperatorStatusStatisticsResponse>("GetACDOperatorStatusStatistics", args);
}
        /// <summary>
        /// Gets the metrics for the specified SmartQueue for the last 30 minutes. Refer to the <a href="/docs/guides/contact-center/reporting">SmartQueue reporting guide</a> to learn more.
        /// </summary>
        /// <param name="reportType">The report type. Possible values are: calls_blocked_percentage, count_blocked_calls, im_blocked_chats_percentage, im_count_blocked_chats, im_answered_chats_rate, average_abandonment_rate, count_abandonment_calls, service_level, im_service_level, occupancy_rate, im_agent_occupancy_rate, agent_utilization_rate, im_agent_utilization_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_in_service_incoming_time, sum_agents_in_service_outcoming_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_custom_1_time, sum_agents_custom_2_time, sum_agents_custom_3_time, sum_agents_custom_4_time, sum_agents_custom_5_time, sum_agents_custom_6_time, sum_agents_custom_7_time, sum_agents_custom_8_time, sum_agents_custom_9_time, sum_agents_custom_10_time, sum_agents_banned_time, im_sum_agents_online_time, im_sum_agents_ready_time, im_sum_agents_in_service_time, im_sum_agents_dnd_time, im_sum_agents_custom_1_time, im_sum_agents_custom_2_time, im_sum_agents_custom_3_time, im_sum_agents_custom_4_time, im_sum_agents_custom_5_time, im_sum_agents_custom_6_time, im_sum_agents_custom_7_time, im_sum_agents_custom_8_time, im_sum_agents_custom_9_time, im_sum_agents_custom_10_time, im_sum_agents_banned_time, average_agents_idle_time, max_agents_idle_time, min_agents_idle_time, percentile_0_25_agents_idle_time, percentile_0_50_agents_idle_time, percentile_0_75_agents_idle_time, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, im_min_answer_speed, im_max_answer_speed, im_average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime, count_agent_unanswered_calls, im_count_agent_unanswered_chats, min_reaction_time, max_reaction_time, average_reaction_time, im_min_reaction_time, im_max_reaction_time, im_average_reaction_time, im_count_abandonment_chats, im_count_lost_chats, im_lost_chats_rate, call_count_assigned_to_queue, im_count_assigned_to_queue</param>
        /// <param name="applicationId">The application ID to search by</param>
        /// <param name="applicationName">The application name to search by. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="userId">The user ID list with a maximum of 5 values separated by semicolons (;). Use the 'all' value to select all users. Can operate as a filter for the **occupancy_rate**, **sum_agents_online_time**, **sum_agents_ready_time**, **sum_agents_dialing_time**, **sum_agents_in_service_time**, **sum_agents_afterservice_time**, **sum_agents_dnd_time**, **sum_agents_banned_time**, **min_handle_time**, **max_handle_time**, **average_handle_time**, **count_handled_calls**, **min_after_call_worktime**, **max_after_call_worktime**, **average_after_call_worktime** report types</param>
        /// <param name="userName">The user name list separated by semicolons (;). <b>user_name</b> can be used instead of <b>user_id</b></param>
        /// <param name="sqQueueName">The SmartQueue name list separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time minus 30 minutes</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time</param>
        /// <param name="timezone">The selected timezone or the 'auto' value (the account location)</param>
        /// <param name="interval">Interval format: YYYY-MM-DD HH:mm:ss. Default is 30 minutes</param>
        /// <param name="groupBy">Group the result by **agent** or *queue*. The **agent** grouping is allowed for 1 queue and for the occupancy_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_banned_time, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types. The **queue** grouping allowed for the calls_blocked_percentage, count_blocked_calls, average_abandonment_rate, count_abandonment_calls, service_level, occupancy_rate, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types</param>
        /// <param name="maxWaitingSec">Maximum waiting time. Required for the **service_level** report type</param>
        public async Task<GetSmartQueueRealtimeMetricsResponse> GetSmartQueueRealtimeMetrics(string reportType, long? applicationId = null, string applicationName = null, string userId = null, string userName = null, string sqQueueName = null, DateTime? fromDate = null, DateTime? toDate = null, string timezone = null, string interval = null, string groupBy = null, long? maxWaitingSec = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueRealtimeMetrics");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into GetSmartQueueRealtimeMetrics");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueRealtimeMetrics");
    
            passedArgs = new List<string>();
        
            if (sqQueueName != null)
                passedArgs.Add("sqQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueRealtimeMetrics");
    
            var args = new Dictionary<string, object>();

            args["report_type"] = reportType;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (fromDate.HasValue)
                args["from_date"] = fromDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (timezone != null)
                args["timezone"] = timezone;
            if (interval != null)
                args["interval"] = interval;
            if (groupBy != null)
                args["group_by"] = groupBy;
            if (maxWaitingSec.HasValue)
                args["max_waiting_sec"] = maxWaitingSec.Value.ToString();
            return await PerformRequest<GetSmartQueueRealtimeMetricsResponse>("GetSmartQueueRealtimeMetrics", args);
}
        /// <summary>
        /// Gets the metrics for the specified SmartQueue for the last 2 days. Refer to the <a href="/docs/guides/contact-center/reporting">SmartQueue reporting guide</a> to learn more.
        /// </summary>
        /// <param name="reportType">The report type. Possible values are: calls_blocked_percentage, count_blocked_calls, im_blocked_chats_percentage, im_count_blocked_chats, im_answered_chats_rate, average_abandonment_rate, count_abandonment_calls, service_level, im_service_level, occupancy_rate, im_agent_occupancy_rate, agent_utilization_rate, im_agent_utilization_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_in_service_incoming_time, sum_agents_in_service_outcoming_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_custom_1_time, sum_agents_custom_2_time, sum_agents_custom_3_time, sum_agents_custom_4_time, sum_agents_custom_5_time, sum_agents_custom_6_time, sum_agents_custom_7_time, sum_agents_custom_8_time, sum_agents_custom_9_time, sum_agents_custom_10_time, sum_agents_banned_time, im_sum_agents_online_time, im_sum_agents_ready_time, im_sum_agents_in_service_time, im_sum_agents_dnd_time, im_sum_agents_custom_1_time, im_sum_agents_custom_2_time, im_sum_agents_custom_3_time, im_sum_agents_custom_4_time, im_sum_agents_custom_5_time, im_sum_agents_custom_6_time, im_sum_agents_custom_7_time, im_sum_agents_custom_8_time, im_sum_agents_custom_9_time, im_sum_agents_custom_10_time, im_sum_agents_banned_time, average_agents_idle_time, max_agents_idle_time, min_agents_idle_time, percentile_0_25_agents_idle_time, percentile_0_50_agents_idle_time, percentile_0_75_agents_idle_time, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, im_min_answer_speed, im_max_answer_speed, im_average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime, count_agent_unanswered_calls, im_count_agent_unanswered_chats, min_reaction_time, max_reaction_time, average_reaction_time, im_min_reaction_time, im_max_reaction_time, im_average_reaction_time, im_count_abandonment_chats, im_count_lost_chats, im_lost_chats_rate, call_count_assigned_to_queue, im_count_assigned_to_queue</param>
        /// <param name="applicationId">The application ID to search by</param>
        /// <param name="applicationName">The application name to search by. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="userId">The user ID list with a maximum of 5 values separated by semicolons (;). Use the 'all' value to select all users. Can operate as a filter for the **occupancy_rate**, **sum_agents_online_time**, **sum_agents_ready_time**, **sum_agents_dialing_time**, **sum_agents_in_service_time**, **sum_agents_afterservice_time**, **sum_agents_dnd_time**, **sum_agents_banned_time**, **min_handle_time**, **max_handle_time**, **average_handle_time**, **count_handled_calls**, **min_after_call_worktime**, **max_after_call_worktime**, **average_after_call_worktime** report types</param>
        /// <param name="userName">The user name list separated by semicolons (;). <b>user_name</b> can be used instead of <b>user_id</b></param>
        /// <param name="sqQueueId">The SmartQueue ID list with a maximum of 5 values separated by semicolons (;). Can operate as filter for the **calls_blocked_percentage**, **count_blocked_calls**, **average_abandonment_rate**, **count_abandonment_calls**, **service_level**, **occupancy_rate**, **min_time_in_queue**, **max_time_in_queue**, **average_time_in_queue**, **min_answer_speed**, **max_answer_speed**, **average_answer_speed**, **min_handle_time**, **max_handle_time**, **average_handle_time**, **count_handled_calls**, **min_after_call_worktime**, **max_after_call_worktime**, **average_after_call_worktime** report types</param>
        /// <param name="sqQueueName">The SmartQueue name list separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time minus 1 day</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time</param>
        /// <param name="timezone">The selected timezone or the 'auto' value (the account location)</param>
        /// <param name="interval">Interval format: YYYY-MM-DD HH:mm:ss. Default is 1 day</param>
        /// <param name="groupBy">Group the result by **agent** or *queue*. The **agent** grouping is allowed only for 1 queue and for the occupancy_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_banned_time, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types. The **queue** grouping allowed for the calls_blocked_percentage, count_blocked_calls, average_abandonment_rate, count_abandonment_calls, service_level, occupancy_rate, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types</param>
        /// <param name="maxWaitingSec">Maximum waiting time. Required for the **service_level** report type</param>
        public async Task<GetSmartQueueDayHistoryResponse> GetSmartQueueDayHistory(string reportType, long? applicationId = null, string applicationName = null, string userId = null, string userName = null, string sqQueueId = null, string sqQueueName = null, DateTime? fromDate = null, DateTime? toDate = null, string timezone = null, string interval = null, string groupBy = null, long? maxWaitingSec = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueDayHistory");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into GetSmartQueueDayHistory");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueDayHistory");
    
            passedArgs = new List<string>();
        
            if (sqQueueId != null)
                passedArgs.Add("sqQueueId");
            if (sqQueueName != null)
                passedArgs.Add("sqQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSmartQueueDayHistory");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of sqQueueId, sqQueueName passed into GetSmartQueueDayHistory");
    
            var args = new Dictionary<string, object>();

            args["report_type"] = reportType;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (sqQueueId != null)
                args["sq_queue_id"] = sqQueueId;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (fromDate.HasValue)
                args["from_date"] = fromDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (timezone != null)
                args["timezone"] = timezone;
            if (interval != null)
                args["interval"] = interval;
            if (groupBy != null)
                args["group_by"] = groupBy;
            if (maxWaitingSec.HasValue)
                args["max_waiting_sec"] = maxWaitingSec.Value.ToString();
            return await PerformRequest<GetSmartQueueDayHistoryResponse>("GetSmartQueueDayHistory", args);
}
        /// <summary>
        /// Gets history for the specified SmartQueue. Refer to the <a href="/docs/guides/contact-center/reporting">SmartQueue reporting guide</a> to learn more.
        /// </summary>
        /// <param name="fromDate">The from date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time minus 1 day</param>
        /// <param name="toDate">The to date in the selected timezone in 24-h format: YYYY-MM-DD HH:mm:ss. Default is the current time</param>
        /// <param name="reportType">The report type. Possible values are: calls_blocked_percentage, count_blocked_calls, im_blocked_chats_percentage, im_count_blocked_chats, im_answered_chats_rate, average_abandonment_rate, count_abandonment_calls, service_level, im_service_level, occupancy_rate, im_agent_occupancy_rate, agent_utilization_rate, im_agent_utilization_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_in_service_incoming_time, sum_agents_in_service_outcoming_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_custom_1_time, sum_agents_custom_2_time, sum_agents_custom_3_time, sum_agents_custom_4_time, sum_agents_custom_5_time, sum_agents_custom_6_time, sum_agents_custom_7_time, sum_agents_custom_8_time, sum_agents_custom_9_time, sum_agents_custom_10_time, sum_agents_banned_time, im_sum_agents_online_time, im_sum_agents_ready_time, im_sum_agents_in_service_time, im_sum_agents_dnd_time, im_sum_agents_custom_1_time, im_sum_agents_custom_2_time, im_sum_agents_custom_3_time, im_sum_agents_custom_4_time, im_sum_agents_custom_5_time, im_sum_agents_custom_6_time, im_sum_agents_custom_7_time, im_sum_agents_custom_8_time, im_sum_agents_custom_9_time, im_sum_agents_custom_10_time, im_sum_agents_banned_time, average_agents_idle_time, max_agents_idle_time, min_agents_idle_time, percentile_0_25_agents_idle_time, percentile_0_50_agents_idle_time, percentile_0_75_agents_idle_time, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, im_min_answer_speed, im_max_answer_speed, im_average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime, count_agent_unanswered_calls, im_count_agent_unanswered_chats, min_reaction_time, max_reaction_time, average_reaction_time, im_min_reaction_time, im_max_reaction_time, im_average_reaction_time, im_count_abandonment_chats, im_count_lost_chats, im_lost_chats_rate, call_count_assigned_to_queue, im_count_assigned_to_queue</param>
        /// <param name="applicationId">The application ID to search by</param>
        /// <param name="applicationName">The application name to search by. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="userId">The user ID list with a maximum of 5 values separated by semicolons (;). Use the 'all' value to select all users. Can operate as a filter for the **occupancy_rate**, **sum_agents_online_time**, **sum_agents_ready_time**, **sum_agents_dialing_time**, **sum_agents_in_service_time**, **sum_agents_afterservice_time**, **sum_agents_dnd_time**, **sum_agents_banned_time**, **min_handle_time**, **max_handle_time**, **average_handle_time**, **count_handled_calls**, **min_after_call_worktime**, **max_after_call_worktime**, **average_after_call_worktime** report types</param>
        /// <param name="userName">The user name list separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="sqQueueId">The SmartQueue ID list with a maximum of 5 values separated by semicolons (;). Can operate as filter for the **calls_blocked_percentage**, **count_blocked_calls**, **average_abandonment_rate**, **count_abandonment_calls**, **service_level**, **occupancy_rate**, **min_time_in_queue**, **max_time_in_queue**, **average_time_in_queue**, **min_answer_speed**, **max_answer_speed**, **average_answer_speed**, **min_handle_time**, **max_handle_time**, **average_handle_time**, **count_handled_calls**, **min_after_call_worktime**, **max_after_call_worktime**, **average_after_call_worktime** report types</param>
        /// <param name="sqQueueName">The SmartQueue name list separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="timezone">The selected timezone or the 'auto' value (the account location)</param>
        /// <param name="interval">Interval format: YYYY-MM-DD HH:mm:ss. Default is 1 day</param>
        /// <param name="groupBy">Group the result by **agent** or *queue*. The **agent** grouping is allowed only for 1 queue and for the occupancy_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_banned_time, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types. The **queue** grouping allowed for the calls_blocked_percentage, count_blocked_calls, average_abandonment_rate, count_abandonment_calls, service_level, occupancy_rate, min_time_in_queue, max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime report types</param>
        /// <param name="maxWaitingSec">Maximum waiting time. Required for the **service_level** report type</param>
        public async Task<RequestSmartQueueHistoryResponse> RequestSmartQueueHistory(DateTime fromDate, DateTime toDate, string reportType, long? applicationId = null, string applicationName = null, string userId = null, string userName = null, string sqQueueId = null, string sqQueueName = null, string timezone = null, string interval = null, string groupBy = null, long? maxWaitingSec = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into RequestSmartQueueHistory");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into RequestSmartQueueHistory");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into RequestSmartQueueHistory");
    
            passedArgs = new List<string>();
        
            if (sqQueueId != null)
                passedArgs.Add("sqQueueId");
            if (sqQueueName != null)
                passedArgs.Add("sqQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into RequestSmartQueueHistory");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of sqQueueId, sqQueueName passed into RequestSmartQueueHistory");
    
            var args = new Dictionary<string, object>();

            args["from_date"] = fromDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["to_date"] = toDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            args["report_type"] = reportType;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (sqQueueId != null)
                args["sq_queue_id"] = sqQueueId;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (timezone != null)
                args["timezone"] = timezone;
            if (interval != null)
                args["interval"] = interval;
            if (groupBy != null)
                args["group_by"] = groupBy;
            if (maxWaitingSec.HasValue)
                args["max_waiting_sec"] = maxWaitingSec.Value.ToString();
            return await PerformRequest<RequestSmartQueueHistoryResponse>("RequestSmartQueueHistory", args);
}
        /// <summary>
        /// Gets the current state of the specified SmartQueue.
        /// </summary>
        /// <param name="applicationId">The application ID to search by</param>
        /// <param name="applicationName">The application name to search by. Can be used instead of the <b>application_id</b> parameter</param>
        /// <param name="sqQueueId">The SmartQueue ID list separated by semicolons (;). Use the 'all' value to select all SmartQueues</param>
        /// <param name="sqQueueName">The SmartQueue name list separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="timezone">The selected timezone or the 'auto' value (the account location)</param>
        public async Task<GetSQStateResponse> GetSQState(long? applicationId = null, string applicationName = null, string sqQueueId = null, string sqQueueName = null, string timezone = null)
        {
            var passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSQState");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of applicationId, applicationName passed into GetSQState");
    
            passedArgs = new List<string>();
        
            if (sqQueueId != null)
                passedArgs.Add("sqQueueId");
            if (sqQueueName != null)
                passedArgs.Add("sqQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into GetSQState");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of sqQueueId, sqQueueName passed into GetSQState");
    
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueId != null)
                args["sq_queue_id"] = sqQueueId;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (timezone != null)
                args["timezone"] = timezone;
            return await PerformRequest<GetSQStateResponse>("GetSQState", args);
}
        /// <summary>
        /// Adds a status if there is no match for the given internal status and renames it if there is a match. It means that if the passed **sq_status_name** parameter is not in the mapping table, a new entry is created in there; if it is, the **name** field in its mapping is replaced with **custom_status_name**.
        /// </summary>
        /// <param name="sqStatusName">Status name</param>
        /// <param name="customStatusName">Custom status name</param>
        /// <param name="applicationId">Application ID</param>
        public async Task<SQ_SetAgentCustomStatusMappingResponse> SQ_SetAgentCustomStatusMapping(string sqStatusName, string customStatusName, long applicationId)
        {
            var args = new Dictionary<string, object>();

            args["sq_status_name"] = sqStatusName;
            args["custom_status_name"] = customStatusName;
            args["application_id"] = applicationId.ToString();
            return await PerformRequest<SQ_SetAgentCustomStatusMappingResponse>("SQ_SetAgentCustomStatusMapping", args);
}
        /// <summary>
        /// Returns the mapping list of SQ statuses and custom statuses. SQ statuses are returned whether they have mappings to custom statuses.
        /// </summary>
        /// <param name="applicationId">Application ID</param>
        public async Task<SQ_GetAgentCustomStatusMappingResponse> SQ_GetAgentCustomStatusMapping(long? applicationId = null)
        {
            var args = new Dictionary<string, object>();

            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            return await PerformRequest<SQ_GetAgentCustomStatusMappingResponse>("SQ_GetAgentCustomStatusMapping", args);
}
        /// <summary>
        /// Removes a mapping from the mapping table. If there is no such mapping, does nothing.
        /// </summary>
        /// <param name="applicationId">Application ID</param>
        /// <param name="sqStatusName">Status name</param>
        public async Task<SQ_DeleteAgentCustomStatusMappingResponse> SQ_DeleteAgentCustomStatusMapping(long applicationId, string sqStatusName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            if (sqStatusName != null)
                args["sq_status_name"] = sqStatusName;
            return await PerformRequest<SQ_DeleteAgentCustomStatusMappingResponse>("SQ_DeleteAgentCustomStatusMapping", args);
}
        /// <summary>
        /// Adds a new operator's skill. Works only for ACDv1. For SmartQueue/ACDv2, use <a href="#how-auth-works">this reference</a>.
        /// </summary>
        /// <param name="skillName">The ACD operator skill name. The length must be less than 512</param>
        public async Task<AddSkillResponse> AddSkill(string skillName)
        {
            var args = new Dictionary<string, object>();

            args["skill_name"] = skillName;
            return await PerformRequest<AddSkillResponse>("AddSkill", args);
}
        /// <summary>
        /// Deletes an operator's skill. Works only for ACDv1. For SmartQueue/ACDv2, use <a href="#how-auth-works">this reference</a>.
        /// </summary>
        /// <param name="skillId">The skill ID</param>
        /// <param name="skillName">The skill name that can be used instead of <b>skill_id</b></param>
        public async Task<DelSkillResponse> DelSkill(long? skillId = null, string skillName = null)
        {
            var passedArgs = new List<string>();
        
            if (skillId != null)
                passedArgs.Add("skillId");
            if (skillName != null)
                passedArgs.Add("skillName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelSkill");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of skillId, skillName passed into DelSkill");
    
            var args = new Dictionary<string, object>();

            if (skillId.HasValue)
                args["skill_id"] = skillId.ToString();
            if (skillName != null)
                args["skill_name"] = skillName;
            return await PerformRequest<DelSkillResponse>("DelSkill", args);
}
        /// <summary>
        /// Edits an operator's skill. Works only for ACDv1. For SmartQueue/ACDv2, use <a href="#how-auth-works">this reference</a>.
        /// </summary>
        /// <param name="newSkillName">The new skill name. The length must be less than 512</param>
        /// <param name="skillId">The skill ID</param>
        /// <param name="skillName">The skill name that can be used instead of <b>skill_id</b></param>
        public async Task<SetSkillInfoResponse> SetSkillInfo(string newSkillName, long? skillId = null, string skillName = null)
        {
            var passedArgs = new List<string>();
        
            if (skillId != null)
                passedArgs.Add("skillId");
            if (skillName != null)
                passedArgs.Add("skillName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetSkillInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of skillId, skillName passed into SetSkillInfo");
    
            var args = new Dictionary<string, object>();

            args["new_skill_name"] = newSkillName;
            if (skillId.HasValue)
                args["skill_id"] = skillId.ToString();
            if (skillName != null)
                args["skill_name"] = skillName;
            return await PerformRequest<SetSkillInfoResponse>("SetSkillInfo", args);
}
        /// <summary>
        /// Gets the skills of an operator. Works only for ACDv1. For SmartQueue/ACDv2, use <a href="#how-auth-works">this reference</a>.
        /// </summary>
        /// <param name="skillId">The skill ID to filter</param>
        /// <param name="skillName">The skill name part to filter</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetSkillsResponse> GetSkills(long? skillId = null, string skillName = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (skillId.HasValue)
                args["skill_id"] = skillId.Value.ToString();
            if (skillName != null)
                args["skill_name"] = skillName;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetSkillsResponse>("GetSkills", args);
}
        /// <summary>
        /// Binds the specified skills to the users (ACD operators) and/or the ACD queues. Works only for ACDv1. For SmartQueue/ACDv2, use <a href="#how-auth-works">this reference</a>.
        /// </summary>
        /// <param name="skillId">The skill ID list separated by semicolons (;). Use the 'all' value to select all skills</param>
        /// <param name="skillName">The skill name list separated by semicolons (;). Can be used instead of <b>skill_id</b></param>
        /// <param name="userId">The user ID list separated by semicolons (;). Use the 'all' value to select all users</param>
        /// <param name="userName">The user name list separated by semicolons (;). <b>user_name</b> can be used instead of <b>user_id</b></param>
        /// <param name="acdQueueId">The ACD queue ID list separated by semicolons (;). Use the 'all' value to select all ACD queues</param>
        /// <param name="acdQueueName">The ACD queue name that can be used instead of <b>acd_queue_id</b>. The ACD queue name list separated by semicolons (;)</param>
        /// <param name="applicationId">The application ID. It is required if the <b>user_name</b> is specified</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindSkillResponse> BindSkill(string skillId = null, string skillName = null, string userId = null, string userName = null, string acdQueueId = null, string acdQueueName = null, long? applicationId = null, string applicationName = null, bool? bind = null)
        {
            var passedArgs = new List<string>();
        
            if (skillId != null)
                passedArgs.Add("skillId");
            if (skillName != null)
                passedArgs.Add("skillName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSkill");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of skillId, skillName passed into BindSkill");
    
            passedArgs = new List<string>();
        
            if (userId != null)
                passedArgs.Add("userId");
            if (userName != null)
                passedArgs.Add("userName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSkill");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of userId, userName passed into BindSkill");
    
            passedArgs = new List<string>();
        
            if (acdQueueId != null)
                passedArgs.Add("acdQueueId");
            if (acdQueueName != null)
                passedArgs.Add("acdQueueName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSkill");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of acdQueueId, acdQueueName passed into BindSkill");
    
            passedArgs = new List<string>();
        
            if (applicationId != null)
                passedArgs.Add("applicationId");
            if (applicationName != null)
                passedArgs.Add("applicationName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into BindSkill");
    
            var args = new Dictionary<string, object>();

            if (skillId != null)
                args["skill_id"] = skillId;
            if (skillName != null)
                args["skill_name"] = skillName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (acdQueueId != null)
                args["acd_queue_id"] = acdQueueId;
            if (acdQueueName != null)
                args["acd_queue_name"] = acdQueueName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindSkillResponse>("BindSkill", args);
}
        /// <summary>
        /// Gets the account documents and the verification states.
        /// </summary>
        /// <param name="withDetails">Whether to view the uploaded document statuses. (The flag is ignored with the child_account_id=all)</param>
        /// <param name="verificationName">The required account verification name to filter</param>
        /// <param name="verificationStatus">The account verification status list separated by semicolons (;). The following values are possible: REQUIRED, IN_PROGRESS, VERIFIED</param>
        /// <param name="fromUnverifiedHoldUntil">Unverified subscriptions hold until the date (from ...) in format: YYYY-MM-DD</param>
        /// <param name="toUnverifiedHoldUntil">Unverified subscriptions hold until the date (... to) in format: YYYY-MM-DD</param>
        /// <param name="childAccountId">The child account ID list separated by semicolons (;). Use the 'all' value to select all child accounts</param>
        /// <param name="childrenVerificationsOnly">Whether to get the children account verifications only</param>
        public async Task<GetAccountDocumentsResponse> GetAccountDocuments(bool? withDetails = null, string verificationName = null, string verificationStatus = null, DateTime? fromUnverifiedHoldUntil = null, DateTime? toUnverifiedHoldUntil = null, string childAccountId = null, bool? childrenVerificationsOnly = null)
        {
            var args = new Dictionary<string, object>();

            if (withDetails.HasValue)
                args["with_details"] = withDetails.Value ? "1" : "0";
            if (verificationName != null)
                args["verification_name"] = verificationName;
            if (verificationStatus != null)
                args["verification_status"] = verificationStatus;
            if (fromUnverifiedHoldUntil.HasValue)
                args["from_unverified_hold_until"] = fromUnverifiedHoldUntil.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (toUnverifiedHoldUntil.HasValue)
                args["to_unverified_hold_until"] = toUnverifiedHoldUntil.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            if (childAccountId != null)
                args["child_account_id"] = childAccountId;
            if (childrenVerificationsOnly.HasValue)
                args["children_verifications_only"] = childrenVerificationsOnly.Value ? "1" : "0";
            return await PerformRequest<GetAccountDocumentsResponse>("GetAccountDocuments", args);
}
        /// <summary>
        /// Adds a new admin user into the specified parent or child account.
        /// </summary>
        /// <param name="newAdminUserName">The admin user name. The length must be less than 50</param>
        /// <param name="adminUserDisplayName">The admin user display name. The length must be less than 256</param>
        /// <param name="newAdminUserPassword">The admin user password. The length must be at least 6 symbols</param>
        /// <param name="adminUserActive">Whether the admin user is active</param>
        /// <param name="adminRoleId">The role(s) ID created via <a href='/docs/references/httpapi/adminroles'>Managing Admin Roles</a> methods. The attaching admin role ID list separated by semicolons (;). Use the 'all' value to select all admin roles</param>
        /// <param name="adminRoleName">The role(s) name(s) created via <a href='/docs/references/httpapi/adminroles'>Managing Admin Roles</a> methods. The attaching admin role name that can be used instead of <b>admin_role_id</b></param>
        public async Task<AddAdminUserResponse> AddAdminUser(string newAdminUserName, string adminUserDisplayName, string newAdminUserPassword, bool? adminUserActive = null, string adminRoleId = null, string adminRoleName = null)
        {
            var passedArgs = new List<string>();
        
            if (adminRoleId != null)
                passedArgs.Add("adminRoleId");
            if (adminRoleName != null)
                passedArgs.Add("adminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddAdminUser");
    
            var args = new Dictionary<string, object>();

            args["new_admin_user_name"] = newAdminUserName;
            args["admin_user_display_name"] = adminUserDisplayName;
            args["new_admin_user_password"] = newAdminUserPassword;
            if (adminUserActive.HasValue)
                args["admin_user_active"] = adminUserActive.Value ? "1" : "0";
            if (adminRoleId != null)
                args["admin_role_id"] = adminRoleId;
            if (adminRoleName != null)
                args["admin_role_name"] = adminRoleName;
            return await PerformRequest<AddAdminUserResponse>("AddAdminUser", args);
}
        /// <summary>
        /// Deletes the specified admin user.
        /// </summary>
        /// <param name="requiredAdminUserId">The admin user ID list separated by semicolons (;). Use the 'all' value to select all admin users</param>
        /// <param name="requiredAdminUserName">The admin user name to delete, can be used instead of <b>required_admin_user_id</b></param>
        public async Task<DelAdminUserResponse> DelAdminUser(string requiredAdminUserId = null, string requiredAdminUserName = null)
        {
            var passedArgs = new List<string>();
        
            if (requiredAdminUserId != null)
                passedArgs.Add("requiredAdminUserId");
            if (requiredAdminUserName != null)
                passedArgs.Add("requiredAdminUserName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelAdminUser");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of requiredAdminUserId, requiredAdminUserName passed into DelAdminUser");
    
            var args = new Dictionary<string, object>();

            if (requiredAdminUserId != null)
                args["required_admin_user_id"] = requiredAdminUserId;
            if (requiredAdminUserName != null)
                args["required_admin_user_name"] = requiredAdminUserName;
            return await PerformRequest<DelAdminUserResponse>("DelAdminUser", args);
}
        /// <summary>
        /// Edits the specified admin user.
        /// </summary>
        /// <param name="requiredAdminUserId">The admin user to edit</param>
        /// <param name="requiredAdminUserName">The admin user to edit, can be used instead of <b>required_admin_user_id</b></param>
        /// <param name="newAdminUserName">The new admin user name. The length must be less than 50</param>
        /// <param name="adminUserDisplayName">The new admin user display name. The length must be less than 256</param>
        /// <param name="newAdminUserPassword">The new admin user password. The length must be at least 6 symbols</param>
        /// <param name="adminUserActive">Whether the admin user is active</param>
        public async Task<SetAdminUserInfoResponse> SetAdminUserInfo(long? requiredAdminUserId = null, string requiredAdminUserName = null, string newAdminUserName = null, string adminUserDisplayName = null, string newAdminUserPassword = null, bool? adminUserActive = null)
        {
            var passedArgs = new List<string>();
        
            if (requiredAdminUserId != null)
                passedArgs.Add("requiredAdminUserId");
            if (requiredAdminUserName != null)
                passedArgs.Add("requiredAdminUserName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetAdminUserInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of requiredAdminUserId, requiredAdminUserName passed into SetAdminUserInfo");
    
            var args = new Dictionary<string, object>();

            if (requiredAdminUserId.HasValue)
                args["required_admin_user_id"] = requiredAdminUserId.ToString();
            if (requiredAdminUserName != null)
                args["required_admin_user_name"] = requiredAdminUserName;
            if (newAdminUserName != null)
                args["new_admin_user_name"] = newAdminUserName;
            if (adminUserDisplayName != null)
                args["admin_user_display_name"] = adminUserDisplayName;
            if (newAdminUserPassword != null)
                args["new_admin_user_password"] = newAdminUserPassword;
            if (adminUserActive.HasValue)
                args["admin_user_active"] = adminUserActive.Value ? "1" : "0";
            return await PerformRequest<SetAdminUserInfoResponse>("SetAdminUserInfo", args);
}
        /// <summary>
        /// Gets the admin users of the specified account. Note that both account types - parent and child - can have its own admins.
        /// </summary>
        /// <param name="requiredAdminUserId">The admin user ID to filter</param>
        /// <param name="requiredAdminUserName">The admin user name part to filter</param>
        /// <param name="adminUserDisplayName">The admin user display name part to filter</param>
        /// <param name="adminUserActive">Whether the admin user is active to filter</param>
        /// <param name="withRoles">Whether to get the attached admin roles</param>
        /// <param name="withAccessEntries">Whether to get the admin user permissions</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetAdminUsersResponse> GetAdminUsers(long? requiredAdminUserId = null, string requiredAdminUserName = null, string adminUserDisplayName = null, bool? adminUserActive = null, bool? withRoles = null, bool? withAccessEntries = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (requiredAdminUserId.HasValue)
                args["required_admin_user_id"] = requiredAdminUserId.Value.ToString();
            if (requiredAdminUserName != null)
                args["required_admin_user_name"] = requiredAdminUserName;
            if (adminUserDisplayName != null)
                args["admin_user_display_name"] = adminUserDisplayName;
            if (adminUserActive.HasValue)
                args["admin_user_active"] = adminUserActive.Value ? "1" : "0";
            if (withRoles.HasValue)
                args["with_roles"] = withRoles.Value ? "1" : "0";
            if (withAccessEntries.HasValue)
                args["with_access_entries"] = withAccessEntries.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetAdminUsersResponse>("GetAdminUsers", args);
}
        /// <summary>
        /// Adds a new admin role.
        /// </summary>
        /// <param name="adminRoleName">The admin role name. The length must be less than 50</param>
        /// <param name="adminRoleActive">Whether the admin role is enabled. If false the allowed and denied entries have no affect</param>
        /// <param name="likeAdminRoleId">The admin role ID list separated by semicolons (;). Use the 'all' value to select all admin roles. The list specifies the roles from which the new role automatically copies all permissions (allowed_entries and denied_entries)</param>
        /// <param name="likeAdminRoleName">The admin role name that can be used instead of <b>like_admin_role_id</b>. The name specifies a role from which the new role automatically copies all permissions (allowed_entries and denied_entries)</param>
        /// <param name="allowedEntries">The list of allowed access entries separated by semicolons (;) (the API function names)</param>
        /// <param name="deniedEntries">The list of denied access entries separated by semicolons (;) (the API function names)</param>
        public async Task<AddAdminRoleResponse> AddAdminRole(string adminRoleName, bool? adminRoleActive = null, string likeAdminRoleId = null, string likeAdminRoleName = null, string allowedEntries = null, string deniedEntries = null)
        {
            var passedArgs = new List<string>();
        
            if (likeAdminRoleId != null)
                passedArgs.Add("likeAdminRoleId");
            if (likeAdminRoleName != null)
                passedArgs.Add("likeAdminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddAdminRole");
    
            var args = new Dictionary<string, object>();

            args["admin_role_name"] = adminRoleName;
            if (adminRoleActive.HasValue)
                args["admin_role_active"] = adminRoleActive.Value ? "1" : "0";
            if (likeAdminRoleId != null)
                args["like_admin_role_id"] = likeAdminRoleId;
            if (likeAdminRoleName != null)
                args["like_admin_role_name"] = likeAdminRoleName;
            if (allowedEntries != null)
                args["allowed_entries"] = allowedEntries;
            if (deniedEntries != null)
                args["denied_entries"] = deniedEntries;
            return await PerformRequest<AddAdminRoleResponse>("AddAdminRole", args);
}
        /// <summary>
        /// Deletes the specified admin role.
        /// </summary>
        /// <param name="adminRoleId">The admin role ID list separated by semicolons (;). Use the 'all' value to select all admin roles</param>
        /// <param name="adminRoleName">The admin role name to delete, can be used instead of <b>admin_role_id</b></param>
        public async Task<DelAdminRoleResponse> DelAdminRole(string adminRoleId = null, string adminRoleName = null)
        {
            var passedArgs = new List<string>();
        
            if (adminRoleId != null)
                passedArgs.Add("adminRoleId");
            if (adminRoleName != null)
                passedArgs.Add("adminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelAdminRole");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of adminRoleId, adminRoleName passed into DelAdminRole");
    
            var args = new Dictionary<string, object>();

            if (adminRoleId != null)
                args["admin_role_id"] = adminRoleId;
            if (adminRoleName != null)
                args["admin_role_name"] = adminRoleName;
            return await PerformRequest<DelAdminRoleResponse>("DelAdminRole", args);
}
        /// <summary>
        /// Edits the specified admin role.
        /// </summary>
        /// <param name="adminRoleId">The admin role to edit</param>
        /// <param name="adminRoleName">The admin role to edit, can be used instead of <b>admin_role_id</b></param>
        /// <param name="newAdminRoleName">The new admin role name. The length must be less than 50</param>
        /// <param name="adminRoleActive">Whether the admin role is enabled. If false the allowed and denied entries have no affect</param>
        /// <param name="entryModificationMode">The modification mode of the permission lists (allowed_entries and denied_entries). The following values are possible: add, del, set</param>
        /// <param name="allowedEntries">The list of allowed access entry changes separated by semicolons (;) (the API function names)</param>
        /// <param name="deniedEntries">The list of denied access entry changes separated by semicolons (;) (the API function names)</param>
        /// <param name="likeAdminRoleId">The admin role ID list separated by semicolons (;). Use the 'all' value to select all admin roles. The list specifies the roles from which the allowed_entries and denied_entries are merged</param>
        /// <param name="likeAdminRoleName">The admin role name, can be used instead of <b>like_admin_role_id</b>. The name specifies a role from which the allowed_entries and denied_entries are merged</param>
        public async Task<SetAdminRoleInfoResponse> SetAdminRoleInfo(long? adminRoleId = null, string adminRoleName = null, string newAdminRoleName = null, bool? adminRoleActive = null, string entryModificationMode = null, string allowedEntries = null, string deniedEntries = null, string likeAdminRoleId = null, string likeAdminRoleName = null)
        {
            var passedArgs = new List<string>();
        
            if (adminRoleId != null)
                passedArgs.Add("adminRoleId");
            if (adminRoleName != null)
                passedArgs.Add("adminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetAdminRoleInfo");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of adminRoleId, adminRoleName passed into SetAdminRoleInfo");
    
            passedArgs = new List<string>();
        
            if (likeAdminRoleId != null)
                passedArgs.Add("likeAdminRoleId");
            if (likeAdminRoleName != null)
                passedArgs.Add("likeAdminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetAdminRoleInfo");
    
            var args = new Dictionary<string, object>();

            if (adminRoleId.HasValue)
                args["admin_role_id"] = adminRoleId.ToString();
            if (adminRoleName != null)
                args["admin_role_name"] = adminRoleName;
            if (newAdminRoleName != null)
                args["new_admin_role_name"] = newAdminRoleName;
            if (adminRoleActive.HasValue)
                args["admin_role_active"] = adminRoleActive.Value ? "1" : "0";
            if (entryModificationMode != null)
                args["entry_modification_mode"] = entryModificationMode;
            if (allowedEntries != null)
                args["allowed_entries"] = allowedEntries;
            if (deniedEntries != null)
                args["denied_entries"] = deniedEntries;
            if (likeAdminRoleId != null)
                args["like_admin_role_id"] = likeAdminRoleId;
            if (likeAdminRoleName != null)
                args["like_admin_role_name"] = likeAdminRoleName;
            return await PerformRequest<SetAdminRoleInfoResponse>("SetAdminRoleInfo", args);
}
        /// <summary>
        /// Gets the admin roles.
        /// </summary>
        /// <param name="adminRoleId">The admin role ID to filter</param>
        /// <param name="adminRoleName">The admin role name part to filter</param>
        /// <param name="adminRoleActive">Whether the admin role is enabled to filter</param>
        /// <param name="withEntries">Whether to get the permissions</param>
        /// <param name="withAccountRoles">Whether to include the account roles</param>
        /// <param name="withParentRoles">Whether to include the parent roles</param>
        /// <param name="includedAdminUserId">The attached admin user ID list separated by semicolons (;). Use the 'all' value to select all admin users</param>
        /// <param name="excludedAdminUserId">Not attached admin user ID list separated by semicolons (;). Use the 'all' value to select all admin users</param>
        /// <param name="fullAdminUsersMatching">Set false to get roles with partial admin user list matching</param>
        /// <param name="showingAdminUserId">The admin user to show in the 'admin_users' field output</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetAdminRolesResponse> GetAdminRoles(long? adminRoleId = null, string adminRoleName = null, bool? adminRoleActive = null, bool? withEntries = null, bool? withAccountRoles = null, bool? withParentRoles = null, string includedAdminUserId = null, string excludedAdminUserId = null, string fullAdminUsersMatching = null, long? showingAdminUserId = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (adminRoleId.HasValue)
                args["admin_role_id"] = adminRoleId.Value.ToString();
            if (adminRoleName != null)
                args["admin_role_name"] = adminRoleName;
            if (adminRoleActive.HasValue)
                args["admin_role_active"] = adminRoleActive.Value ? "1" : "0";
            if (withEntries.HasValue)
                args["with_entries"] = withEntries.Value ? "1" : "0";
            if (withAccountRoles.HasValue)
                args["with_account_roles"] = withAccountRoles.Value ? "1" : "0";
            if (withParentRoles.HasValue)
                args["with_parent_roles"] = withParentRoles.Value ? "1" : "0";
            if (includedAdminUserId != null)
                args["included_admin_user_id"] = includedAdminUserId;
            if (excludedAdminUserId != null)
                args["excluded_admin_user_id"] = excludedAdminUserId;
            if (fullAdminUsersMatching != null)
                args["full_admin_users_matching"] = fullAdminUsersMatching;
            if (showingAdminUserId.HasValue)
                args["showing_admin_user_id"] = showingAdminUserId.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetAdminRolesResponse>("GetAdminRoles", args);
}
        /// <summary>
        /// Attaches the admin role(s) to the already existing admin(s).
        /// </summary>
        /// <param name="requiredAdminUserId">The admin user ID list separated by semicolons (;). Use the 'all' value to select all admin users</param>
        /// <param name="requiredAdminUserName">The admin user name to bind, can be used instead of <b>required_admin_user_id</b></param>
        /// <param name="adminRoleId">The role(s) ID created via <a href='/docs/references/httpapi/adminroles'>Managing Admin Roles</a> methods. The attached admin role ID list separated by semicolons (;). Use the 'all' value to select alladmin roles</param>
        /// <param name="adminRoleName">The role(s) name(s) created via <a href='/docs/references/httpapi/adminroles'>Managing Admin Roles</a> methods. The admin role name to attach, can be used instead of <b>admin_role_id</b></param>
        /// <param name="mode">The merge mode. The following values are possible: add, del, set</param>
        public async Task<AttachAdminRoleResponse> AttachAdminRole(string requiredAdminUserId = null, string requiredAdminUserName = null, string adminRoleId = null, string adminRoleName = null, string mode = null)
        {
            var passedArgs = new List<string>();
        
            if (requiredAdminUserId != null)
                passedArgs.Add("requiredAdminUserId");
            if (requiredAdminUserName != null)
                passedArgs.Add("requiredAdminUserName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AttachAdminRole");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of requiredAdminUserId, requiredAdminUserName passed into AttachAdminRole");
    
            passedArgs = new List<string>();
        
            if (adminRoleId != null)
                passedArgs.Add("adminRoleId");
            if (adminRoleName != null)
                passedArgs.Add("adminRoleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AttachAdminRole");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of adminRoleId, adminRoleName passed into AttachAdminRole");
    
            var args = new Dictionary<string, object>();

            if (requiredAdminUserId != null)
                args["required_admin_user_id"] = requiredAdminUserId;
            if (requiredAdminUserName != null)
                args["required_admin_user_name"] = requiredAdminUserName;
            if (adminRoleId != null)
                args["admin_role_id"] = adminRoleId;
            if (adminRoleName != null)
                args["admin_role_name"] = adminRoleName;
            if (mode != null)
                args["mode"] = mode;
            return await PerformRequest<AttachAdminRoleResponse>("AttachAdminRole", args);
}
        /// <summary>
        /// Gets the all available admin role entries.
        /// </summary>
        public async Task<GetAvailableAdminRoleEntriesResponse> GetAvailableAdminRoleEntries()
        {
            var args = new Dictionary<string, object>();

            return await PerformRequest<GetAvailableAdminRoleEntriesResponse>("GetAvailableAdminRoleEntries", args);
}
        /// <summary>
        /// Adds a new authorized IP4 or network to the white/black list.
        /// </summary>
        /// <param name="authorizedIp">The authorized IP4 or network</param>
        /// <param name="allowed">Whether to remove the IP from the blacklist</param>
        /// <param name="description">The IP address description</param>
        public async Task<AddAuthorizedAccountIPResponse> AddAuthorizedAccountIP(string authorizedIp, bool? allowed = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["authorized_ip"] = authorizedIp;
            if (allowed.HasValue)
                args["allowed"] = allowed.Value ? "1" : "0";
            if (description != null)
                args["description"] = description;
            return await PerformRequest<AddAuthorizedAccountIPResponse>("AddAuthorizedAccountIP", args);
}
        /// <summary>
        /// Removes the authorized IP4 or network from the white/black list.
        /// </summary>
        /// <param name="authorizedIp">The authorized IP4 or network to remove. Set to 'all' to remove all items</param>
        /// <param name="containsIp">Specify the parameter to remove the networks that contains the particular IP4. Can be used instead of <b>authorized_ip</b></param>
        /// <param name="allowed">Whether to remove the network from the white list. Set false to remove the network from the black list. Omit the parameter to remove the network from all lists</param>
        public async Task<DelAuthorizedAccountIPResponse> DelAuthorizedAccountIP(string authorizedIp = null, string containsIp = null, bool? allowed = null)
        {
            var passedArgs = new List<string>();
        
            if (authorizedIp != null)
                passedArgs.Add("authorizedIp");
            if (containsIp != null)
                passedArgs.Add("containsIp");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into DelAuthorizedAccountIP");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of authorizedIp, containsIp passed into DelAuthorizedAccountIP");
    
            var args = new Dictionary<string, object>();

            if (authorizedIp != null)
                args["authorized_ip"] = authorizedIp;
            if (containsIp != null)
                args["contains_ip"] = containsIp;
            if (allowed.HasValue)
                args["allowed"] = allowed.Value ? "1" : "0";
            return await PerformRequest<DelAuthorizedAccountIPResponse>("DelAuthorizedAccountIP", args);
}
        /// <summary>
        /// Gets the authorized IP4 or network.
        /// </summary>
        /// <param name="authorizedIp">The authorized IP4 or network to filter</param>
        /// <param name="allowed">Whether the IP is allowed</param>
        /// <param name="containsIp">Specify the parameter to filter the networks that contains the particular IP4</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="description">The IP address description</param>
        public async Task<GetAuthorizedAccountIPsResponse> GetAuthorizedAccountIPs(string authorizedIp = null, bool? allowed = null, string containsIp = null, long? count = null, long? offset = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            if (authorizedIp != null)
                args["authorized_ip"] = authorizedIp;
            if (allowed.HasValue)
                args["allowed"] = allowed.Value ? "1" : "0";
            if (containsIp != null)
                args["contains_ip"] = containsIp;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (description != null)
                args["description"] = description;
            return await PerformRequest<GetAuthorizedAccountIPsResponse>("GetAuthorizedAccountIPs", args);
}
        /// <summary>
        /// Tests whether the IP4 is banned or allowed.
        /// </summary>
        /// <param name="authorizedIp">The IP4 to test</param>
        public async Task<CheckAuthorizedAccountIPResponse> CheckAuthorizedAccountIP(string authorizedIp)
        {
            var args = new Dictionary<string, object>();

            args["authorized_ip"] = authorizedIp;
            return await PerformRequest<CheckAuthorizedAccountIPResponse>("CheckAuthorizedAccountIP", args);
}
        /// <summary>
        /// Links the regulation address to a phone.
        /// </summary>
        /// <param name="regulationAddressId">The regulation address ID</param>
        /// <param name="phoneId">The phone ID for link</param>
        /// <param name="phoneNumber">The phone number for link</param>
        public async Task<LinkRegulationAddressResponse> LinkRegulationAddress(long regulationAddressId, long? phoneId = null, string phoneNumber = null)
        {
            var passedArgs = new List<string>();
        
            if (phoneId != null)
                passedArgs.Add("phoneId");
            if (phoneNumber != null)
                passedArgs.Add("phoneNumber");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into LinkRegulationAddress");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of phoneId, phoneNumber passed into LinkRegulationAddress");
    
            var args = new Dictionary<string, object>();

            args["regulation_address_id"] = regulationAddressId.ToString();
            if (phoneId.HasValue)
                args["phone_id"] = phoneId.ToString();
            if (phoneNumber != null)
                args["phone_number"] = phoneNumber;
            return await PerformRequest<LinkRegulationAddressResponse>("LinkRegulationAddress", args);
}
        /// <summary>
        /// Searches for available zip codes.
        /// </summary>
        /// <param name="countryCode">The country code according to the <b>ISO 3166-1 alpha-2</b></param>
        /// <param name="phoneRegionCode">The phone region code</param>
        /// <param name="count">The max returning record count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetZIPCodesResponse> GetZIPCodes(string countryCode, string phoneRegionCode = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            if (phoneRegionCode != null)
                args["phone_region_code"] = phoneRegionCode;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetZIPCodesResponse>("GetZIPCodes", args);
}
        /// <summary>
        /// Searches for the user's regulation address.
        /// </summary>
        /// <param name="countryCode">The country code according to the <b>ISO 3166-1 alpha-2</b></param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="phoneRegionCode">The phone region code. See the [GetRegions] method</param>
        /// <param name="regulationAddressId">The regulation address ID</param>
        /// <param name="verified">Whether to show only verified regulation address</param>
        /// <param name="inProgress">Whether to show only in progress regulation address</param>
        public async Task<GetRegulationsAddressResponse> GetRegulationsAddress(string countryCode = null, string phoneCategoryName = null, string phoneRegionCode = null, long? regulationAddressId = null, bool? verified = null, bool? inProgress = null)
        {
            var args = new Dictionary<string, object>();

            if (countryCode != null)
                args["country_code"] = countryCode;
            if (phoneCategoryName != null)
                args["phone_category_name"] = phoneCategoryName;
            if (phoneRegionCode != null)
                args["phone_region_code"] = phoneRegionCode;
            if (regulationAddressId.HasValue)
                args["regulation_address_id"] = regulationAddressId.Value.ToString();
            if (verified.HasValue)
                args["verified"] = verified.Value ? "1" : "0";
            if (inProgress.HasValue)
                args["in_progress"] = inProgress.Value ? "1" : "0";
            return await PerformRequest<GetRegulationsAddressResponse>("GetRegulationsAddress", args);
}
        /// <summary>
        /// Searches for the available regulation for a link.
        /// </summary>
        /// <param name="countryCode">The country code according to the <b>ISO 3166-1 alpha-2</b></param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="phoneRegionCode">The phone region code. See the [GetRegions] method</param>
        public async Task<GetAvailableRegulationsResponse> GetAvailableRegulations(string countryCode, string phoneCategoryName, string phoneRegionCode = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            if (phoneRegionCode != null)
                args["phone_region_code"] = phoneRegionCode;
            return await PerformRequest<GetAvailableRegulationsResponse>("GetAvailableRegulations", args);
}
        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <param name="countryCode">The country code according to the <b>ISO 3166-1 alpha-2</b></param>
        public async Task<GetCountriesResponse> GetCountries(string countryCode = null)
        {
            var args = new Dictionary<string, object>();

            if (countryCode != null)
                args["country_code"] = countryCode;
            return await PerformRequest<GetCountriesResponse>("GetCountries", args);
}
        /// <summary>
        /// Gets all countries where the specific account has phone numbers.
        /// </summary>
        /// <param name="applicationId">The application ID list separated by semicolons (;) to filter</param>
        public async Task<GetAccountPhoneNumberCountriesResponse> GetAccountPhoneNumberCountries(string applicationId = null)
        {
            var args = new Dictionary<string, object>();

            if (applicationId != null)
                args["application_id"] = applicationId;
            return await PerformRequest<GetAccountPhoneNumberCountriesResponse>("GetAccountPhoneNumberCountries", args);
}
        /// <summary>
        /// Gets available regions in a country.
        /// </summary>
        /// <param name="countryCode">The country code according to the <b>ISO 3166-1 alpha-2</b></param>
        /// <param name="phoneCategoryName">The phone category name. See the [GetPhoneNumberCategories] method</param>
        /// <param name="cityName">The pattern of city's name</param>
        /// <param name="count">The returned regions count</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        public async Task<GetRegionsResponse> GetRegions(string countryCode, string phoneCategoryName, string cityName = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            args["country_code"] = countryCode;
            args["phone_category_name"] = phoneCategoryName;
            if (cityName != null)
                args["city_name"] = cityName;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetRegionsResponse>("GetRegions", args);
}
        /// <summary>
        /// Adds push credentials.
        /// </summary>
        /// <param name="pushProviderName">The push provider name. The possible values are APPLE, APPLE_VOIP, GOOGLE, HUAWEI</param>
        /// <param name="pushProviderId">The push provider id. Can be used instead of <b>push_provider_name</b>. The possible values are: 1 — APPLE, 2 — GOOGLE, 3 — APPLE_VOIP, 5 — HUAWEI.</param>
        /// <param name="applicationId">The application id</param>
        /// <param name="applicationName">The application name that can be used instead of <b>application_id</b></param>
        /// <param name="credentialBundle">The bundle of Android/iOS/Huawei application</param>
        /// <param name="certContent">Public and private keys in PKCS12 format. Credentials for APPLE push</param>
        /// <param name="certFileName">The parameter is required, when set 'cert_content' as POST body. Credentials for APPLE push</param>
        /// <param name="certPassword">The secret password for private key. Credentials for APPLE push</param>
        /// <param name="isDevMode">Whether to use this certificate in apple's sandbox environment. Credentials for APPLE push</param>
        /// <param name="senderId">The sender id, provided by Google. Credentials for GOOGLE push</param>
        /// <param name="serverKey">The server key, provided by Google. Credentials for GOOGLE push</param>
        /// <param name="serviceAccountFile">The service account key file, provided by Google. Can be used instead of <b>server_key</b>. Credentials for GOOGLE push</param>
        /// <param name="huaweiClientId">The client id, provided by Huawei. Credentials for HUAWEI push</param>
        /// <param name="huaweiClientSecret">The client secret, provided by Huawei. Credentials for HUAWEI push</param>
        /// <param name="huaweiApplicationId">The application id, provided by Huawei. Credentials for HUAWEI push</param>
        public async Task<AddPushCredentialResponse> AddPushCredential(string pushProviderName = null, long? pushProviderId = null, long? applicationId = null, string applicationName = null, string credentialBundle = null, Stream certContent = null, string certFileName = null, string certPassword = null, bool? isDevMode = null, string senderId = null, string serverKey = null, Stream serviceAccountFile = null, string huaweiClientId = null, string huaweiClientSecret = null, string huaweiApplicationId = null)
        {
            var passedArgs = new List<string>();
        
            if (pushProviderName != null)
                passedArgs.Add("pushProviderName");
            if (pushProviderId != null)
                passedArgs.Add("pushProviderId");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddPushCredential");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of pushProviderName, pushProviderId passed into AddPushCredential");
    
            passedArgs = new List<string>();
        
            if (certContent != null)
                passedArgs.Add("certContent");
            if (certFileName != null)
                passedArgs.Add("certFileName");
            if (certPassword != null)
                passedArgs.Add("certPassword");
            if (isDevMode != null)
                passedArgs.Add("isDevMode");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddPushCredential");
    
            passedArgs = new List<string>();
        
            if (senderId != null)
                passedArgs.Add("senderId");
            if (serverKey != null)
                passedArgs.Add("serverKey");
            if (serviceAccountFile != null)
                passedArgs.Add("serviceAccountFile");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddPushCredential");
    
            passedArgs = new List<string>();
        
            if (huaweiClientId != null)
                passedArgs.Add("huaweiClientId");
            if (huaweiClientSecret != null)
                passedArgs.Add("huaweiClientSecret");
            if (huaweiApplicationId != null)
                passedArgs.Add("huaweiApplicationId");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddPushCredential");
    
            var args = new Dictionary<string, object>();

            if (pushProviderName != null)
                args["push_provider_name"] = pushProviderName;
            if (pushProviderId.HasValue)
                args["push_provider_id"] = pushProviderId.ToString();
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (credentialBundle != null)
                args["credential_bundle"] = credentialBundle;
            if (certContent != null)
                args["cert_content"] = certContent;
            if (certFileName != null)
                args["cert_file_name"] = certFileName;
            if (certPassword != null)
                args["cert_password"] = certPassword;
            if (isDevMode.HasValue)
                args["is_dev_mode"] = isDevMode.Value ? "1" : "0";
            if (senderId != null)
                args["sender_id"] = senderId;
            if (serverKey != null)
                args["server_key"] = serverKey;
            if (serviceAccountFile != null)
                args["service_account_file"] = serviceAccountFile;
            if (huaweiClientId != null)
                args["huawei_client_id"] = huaweiClientId;
            if (huaweiClientSecret != null)
                args["huawei_client_secret"] = huaweiClientSecret;
            if (huaweiApplicationId != null)
                args["huawei_application_id"] = huaweiApplicationId;
            return await PerformRequest<AddPushCredentialResponse>("AddPushCredential", args);
}
        /// <summary>
        /// Modifies push credentials.
        /// </summary>
        /// <param name="pushCredentialId">The push credentials id</param>
        /// <param name="certContent">Public and private keys in PKCS12 format. Credentials for APPLE push</param>
        /// <param name="certPassword">The secret password for private key. Credentials for APPLE push</param>
        /// <param name="isDevMode">Whether to use this certificate in apple's sandbox environment. Credentials for APPLE push</param>
        /// <param name="senderId">The sender id, provided by Google. Credentials for GOOGLE push</param>
        /// <param name="serverKey">The server key, provided by Google. Credentials for GOOGLE push</param>
        /// <param name="serviceAccountFile">The service account key file, provided by Google. Can be used instead of <b>server_key</b>. Credentials for GOOGLE push</param>
        /// <param name="huaweiClientId">The client id, provided by Huawei. Credentials for HUAWEI push</param>
        /// <param name="huaweiClientSecret">The client secret, provided by Huawei. Credentials for HUAWEI push</param>
        /// <param name="huaweiApplicationId">The application id, provided by Huawei. Credentials for HUAWEI push</param>
        public async Task<SetPushCredentialResponse> SetPushCredential(long pushCredentialId, Stream certContent = null, string certPassword = null, bool? isDevMode = null, string senderId = null, string serverKey = null, Stream serviceAccountFile = null, string huaweiClientId = null, string huaweiClientSecret = null, string huaweiApplicationId = null)
        {
            var passedArgs = new List<string>();
        
            if (certContent != null)
                passedArgs.Add("certContent");
            if (certPassword != null)
                passedArgs.Add("certPassword");
            if (isDevMode != null)
                passedArgs.Add("isDevMode");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetPushCredential");
    
            passedArgs = new List<string>();
        
            if (senderId != null)
                passedArgs.Add("senderId");
            if (serverKey != null)
                passedArgs.Add("serverKey");
            if (serviceAccountFile != null)
                passedArgs.Add("serviceAccountFile");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetPushCredential");
    
            passedArgs = new List<string>();
        
            if (huaweiClientId != null)
                passedArgs.Add("huaweiClientId");
            if (huaweiClientSecret != null)
                passedArgs.Add("huaweiClientSecret");
            if (huaweiApplicationId != null)
                passedArgs.Add("huaweiApplicationId");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetPushCredential");
    
            var args = new Dictionary<string, object>();

            args["push_credential_id"] = pushCredentialId.ToString();
            if (certContent != null)
                args["cert_content"] = certContent;
            if (certPassword != null)
                args["cert_password"] = certPassword;
            if (isDevMode.HasValue)
                args["is_dev_mode"] = isDevMode.Value ? "1" : "0";
            if (senderId != null)
                args["sender_id"] = senderId;
            if (serverKey != null)
                args["server_key"] = serverKey;
            if (serviceAccountFile != null)
                args["service_account_file"] = serviceAccountFile;
            if (huaweiClientId != null)
                args["huawei_client_id"] = huaweiClientId;
            if (huaweiClientSecret != null)
                args["huawei_client_secret"] = huaweiClientSecret;
            if (huaweiApplicationId != null)
                args["huawei_application_id"] = huaweiApplicationId;
            return await PerformRequest<SetPushCredentialResponse>("SetPushCredential", args);
}
        /// <summary>
        /// Removes push credentials.
        /// </summary>
        /// <param name="pushCredentialId">The push credentials id</param>
        public async Task<DelPushCredentialResponse> DelPushCredential(long pushCredentialId)
        {
            var args = new Dictionary<string, object>();

            args["push_credential_id"] = pushCredentialId.ToString();
            return await PerformRequest<DelPushCredentialResponse>("DelPushCredential", args);
}
        /// <summary>
        /// Gets push credentials.
        /// </summary>
        /// <param name="pushCredentialId">The push credentials id</param>
        /// <param name="pushProviderName">The push provider name. The possible values are APPLE, APPLE_VOIP, GOOGLE, HUAWEI</param>
        /// <param name="pushProviderId">The push provider id. Can be used instead of <b>push_provider_name</b>. The possible values are: 1 — APPLE, 2 — GOOGLE, 3 — APPLE_VOIP, 5 — HUAWEI.</param>
        /// <param name="applicationName">Name of the bound application</param>
        /// <param name="applicationId">ID of the bound application</param>
        /// <param name="withCert">Whether to get the user's certificate</param>
        public async Task<GetPushCredentialResponse> GetPushCredential(long? pushCredentialId = null, string pushProviderName = null, long? pushProviderId = null, string applicationName = null, long? applicationId = null, bool? withCert = null)
        {
            var args = new Dictionary<string, object>();

            if (pushCredentialId.HasValue)
                args["push_credential_id"] = pushCredentialId.Value.ToString();
            if (pushProviderName != null)
                args["push_provider_name"] = pushProviderName;
            if (pushProviderId.HasValue)
                args["push_provider_id"] = pushProviderId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            if (withCert.HasValue)
                args["with_cert"] = withCert.Value ? "1" : "0";
            return await PerformRequest<GetPushCredentialResponse>("GetPushCredential", args);
}
        /// <summary>
        /// Binds push credentials to applications.
        /// </summary>
        /// <param name="pushCredentialId">The push credentials ID list separated by semicolons (;)</param>
        /// <param name="applicationId">The application ID list separated by semicolons (;). Use the 'all' value to select all applications</param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindPushCredentialResponse> BindPushCredential(string pushCredentialId, string applicationId, bool? bind = null)
        {
            var args = new Dictionary<string, object>();

            args["push_credential_id"] = pushCredentialId;
            args["application_id"] = applicationId;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindPushCredentialResponse>("BindPushCredential", args);
}
        /// <summary>
        /// Adds a Dialogflow key.
        /// </summary>
        /// <param name="applicationId">The application ID</param>
        /// <param name="jsonCredentials">Dialogflow credentials, provided by JWK (Json web key)</param>
        /// <param name="applicationName">The application name. Can be used instead of <b>application_id</b></param>
        /// <param name="description">The Dialogflow key's description</param>
        public async Task<AddDialogflowKeyResponse> AddDialogflowKey(string applicationId, string jsonCredentials, string applicationName = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId;
            args["json_credentials"] = jsonCredentials;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<AddDialogflowKeyResponse>("AddDialogflowKey", args);
}
        /// <summary>
        /// Edits a Dialogflow key.
        /// </summary>
        /// <param name="dialogflowKeyId">The Dialogflow key's ID</param>
        /// <param name="description">The Dialogflow key's description. To clear previously set description leave the parameter blank or put whitespaces only</param>
        public async Task<SetDialogflowKeyResponse> SetDialogflowKey(long dialogflowKeyId, string description)
        {
            var args = new Dictionary<string, object>();

            args["dialogflow_key_id"] = dialogflowKeyId.ToString();
            args["description"] = description;
            return await PerformRequest<SetDialogflowKeyResponse>("SetDialogflowKey", args);
}
        /// <summary>
        /// Removes a Dialogflow key.
        /// </summary>
        /// <param name="dialogflowKeyId">The Dialogflow key's ID</param>
        public async Task<DelDialogflowKeyResponse> DelDialogflowKey(long dialogflowKeyId)
        {
            var args = new Dictionary<string, object>();

            args["dialogflow_key_id"] = dialogflowKeyId.ToString();
            return await PerformRequest<DelDialogflowKeyResponse>("DelDialogflowKey", args);
}
        /// <summary>
        /// Gets Dialogflow keys.
        /// </summary>
        /// <param name="dialogflowKeyId">Dialogflow key's ID</param>
        /// <param name="applicationName">Name of the bound application</param>
        /// <param name="applicationId">ID of the bound application</param>
        public async Task<GetDialogflowKeysResponse> GetDialogflowKeys(long? dialogflowKeyId = null, string applicationName = null, long? applicationId = null)
        {
            var args = new Dictionary<string, object>();

            if (dialogflowKeyId.HasValue)
                args["dialogflow_key_id"] = dialogflowKeyId.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (applicationId.HasValue)
                args["application_id"] = applicationId.Value.ToString();
            return await PerformRequest<GetDialogflowKeysResponse>("GetDialogflowKeys", args);
}
        /// <summary>
        /// Binds a Dialogflow key to the specified applications.
        /// </summary>
        /// <param name="dialogflowKeyId">The Dialogflow key's ID </param>
        /// <param name="applicationId">The application ID list separated by semicolons (;). Use the 'all' value to select all applications</param>
        /// <param name="bind">Whether to bind or unbind (set true or false respectively)</param>
        public async Task<BindDialogflowKeysResponse> BindDialogflowKeys(long dialogflowKeyId, string applicationId, bool? bind = null)
        {
            var args = new Dictionary<string, object>();

            args["dialogflow_key_id"] = dialogflowKeyId.ToString();
            args["application_id"] = applicationId;
            if (bind.HasValue)
                args["bind"] = bind.Value ? "1" : "0";
            return await PerformRequest<BindDialogflowKeysResponse>("BindDialogflowKeys", args);
}
        /// <summary>
        /// Sends an SMS message between two phone numbers. The source phone number should be purchased from Voximplant and support SMS (which is indicated by the <b>is_sms_supported</b> property in the objects returned by the [GetPhoneNumbers] Management API) and SMS should be enabled for it via the [ControlSms] Management API. SMS messages can be received via HTTP callbacks, see <a href='/docs/guides/managementapi/callbacks'>this article</a> for details.
        /// </summary>
        /// <param name="source">The source phone number</param>
        /// <param name="destination">The destination phone number</param>
        /// <param name="smsBody">The message text, up to 765 characters. We split long messages greater than 160 GSM-7 characters or 70 UTF-16 characters into multiple segments. Each segment is charged as one message</param>
        /// <param name="storeBody">Whether to store outgoing message texts. Default value is false</param>
        public async Task<SendSmsMessageResponse> SendSmsMessage(string source, string destination, string smsBody, bool? storeBody = null)
        {
            var args = new Dictionary<string, object>();

            args["source"] = source;
            args["destination"] = destination;
            args["sms_body"] = smsBody;
            if (storeBody.HasValue)
                args["store_body"] = storeBody.Value ? "1" : "0";
            return await PerformRequest<SendSmsMessageResponse>("SendSmsMessage", args);
}
        /// <summary>
        /// Sends an SMS message from the application to customers. The source phone number should be purchased from Voximplant and support SMS (which is indicated by the <b>is_sms_supported</b> property in the objects returned by the <a href='/docs/references/httpapi/managing_phone_numbers#getphonenumbers'>/GetPhoneNumbers</a> Management API) and SMS should be enabled for it via the <a href='/docs/references/httpapi/managing_sms#controlsms'>/ControlSms</a> Management API.
        /// </summary>
        /// <param name="srcNumber">The SenderID for outgoing SMS. Please contact support for installing a SenderID</param>
        /// <param name="dstNumbers">The destination phone numbers separated by semicolons (;). The maximum number of these phone numbers is 100</param>
        /// <param name="text">The message text, up to 1600 characters. We split long messages greater than 160 GSM-7 characters or 70 UTF-16 characters into multiple segments. Each segment is charged as one message</param>
        /// <param name="storeBody">Whether to store outgoing message texts. Default value is false</param>
        public async Task<A2PSendSmsResponse> A2PSendSms(string srcNumber, string dstNumbers, string text, bool? storeBody = null)
        {
            var args = new Dictionary<string, object>();

            args["src_number"] = srcNumber;
            args["dst_numbers"] = dstNumbers;
            args["text"] = text;
            if (storeBody.HasValue)
                args["store_body"] = storeBody.Value ? "1" : "0";
            return await PerformRequest<A2PSendSmsResponse>("A2PSendSms", args);
}
        /// <summary>
        /// Enables or disables sending and receiving SMS for the phone number. Can be used only for phone numbers with SMS support, which is indicated by the <b>is_sms_supported</b> property in the objects returned by the [GetPhoneNumbers] Management API. Each incoming SMS message is charged according to the <a href='//voximplant.com/pricing'>pricing</a>. If enabled, SMS can be sent from this phone number via the [SendSmsMessage] Management API and received via the [InboundSmsCallback] property of the HTTP callback. See <a href='/docs/guides/managementapi/callbacks'>this article</a> for HTTP callback details.
        /// </summary>
        /// <param name="phoneNumber">The phone number</param>
        /// <param name="command">The SMS control command. The following values are possible: enable, disable</param>
        public async Task<ControlSmsResponse> ControlSms(string phoneNumber, string command)
        {
            var args = new Dictionary<string, object>();

            args["phone_number"] = phoneNumber;
            args["command"] = command;
            return await PerformRequest<ControlSmsResponse>("ControlSms", args);
}
        /// <summary>
        /// Gets the record storages.
        /// </summary>
        /// <param name="recordStorageId">The record storage ID list separated by semicolons (;)</param>
        /// <param name="recordStorageName">The record storage name list separated by semicolons (;)</param>
        public async Task<GetRecordStoragesResponse> GetRecordStorages(string recordStorageId = null, string recordStorageName = null)
        {
            var args = new Dictionary<string, object>();

            if (recordStorageId != null)
                args["record_storage_id"] = recordStorageId;
            if (recordStorageName != null)
                args["record_storage_name"] = recordStorageName;
            return await PerformRequest<GetRecordStoragesResponse>("GetRecordStorages", args);
}
        /// <summary>
        /// Creates a public/private key pair. You can optionally specify one or more roles for the key.
        /// </summary>
        /// <param name="description">The key's description</param>
        /// <param name="keyName">The key's name, up to 50 characters. Cannot be empty</param>
        /// <param name="roleId">The role ID list separated by semicolons (;). Use it instead of **role_name**, but not combine with</param>
        /// <param name="roleName">The role name list separated by semicolons (;). Use it instead of **role_id**, but not combine with</param>
        public async Task<CreateKeyResponse> CreateKey(string description = null, string keyName = null, string roleId = null, string roleName = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into CreateKey");
    
            var args = new Dictionary<string, object>();

            if (description != null)
                args["description"] = description;
            if (keyName != null)
                args["key_name"] = keyName;
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            return await PerformRequest<CreateKeyResponse>("CreateKey", args);
}
        /// <summary>
        /// Gets key info of the specified account.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        /// <param name="withRoles">Whether to show roles for the key</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="count">The max returning record count</param>
        public async Task<GetKeysResponse> GetKeys(string keyId = null, bool? withRoles = null, long? offset = null, long? count = null)
        {
            var args = new Dictionary<string, object>();

            if (keyId != null)
                args["key_id"] = keyId;
            if (withRoles.HasValue)
                args["with_roles"] = withRoles.Value ? "1" : "0";
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            return await PerformRequest<GetKeysResponse>("GetKeys", args);
}
        /// <summary>
        /// Updates info of the specified key.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        /// <param name="description">The key's description</param>
        /// <param name="keyName">The key's name, up to 50 characters. Cannot be empty</param>
        public async Task<UpdateKeyResponse> UpdateKey(string keyId, string description, string keyName = null)
        {
            var args = new Dictionary<string, object>();

            args["key_id"] = keyId;
            args["description"] = description;
            if (keyName != null)
                args["key_name"] = keyName;
            return await PerformRequest<UpdateKeyResponse>("UpdateKey", args);
}
        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        public async Task<DeleteKeyResponse> DeleteKey(string keyId)
        {
            var args = new Dictionary<string, object>();

            args["key_id"] = keyId;
            return await PerformRequest<DeleteKeyResponse>("DeleteKey", args);
}
        /// <summary>
        /// Set roles for the specified key.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        /// <param name="roleId">The role id list separated by semicolons (;)</param>
        /// <param name="roleName">The role name list separated by semicolons (;)</param>
        public async Task<SetKeyRolesResponse> SetKeyRoles(string keyId, string roleId = null, string roleName = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetKeyRoles");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of roleId, roleName passed into SetKeyRoles");
    
            var args = new Dictionary<string, object>();

            args["key_id"] = keyId;
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            return await PerformRequest<SetKeyRolesResponse>("SetKeyRoles", args);
}
        /// <summary>
        /// Gets roles of the specified key.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        /// <param name="withExpandedRoles">Whether to show the roles' additional properties</param>
        public async Task<GetKeyRolesResponse> GetKeyRoles(string keyId, bool? withExpandedRoles = null)
        {
            var args = new Dictionary<string, object>();

            args["key_id"] = keyId;
            if (withExpandedRoles.HasValue)
                args["with_expanded_roles"] = withExpandedRoles.Value ? "1" : "0";
            return await PerformRequest<GetKeyRolesResponse>("GetKeyRoles", args);
}
        /// <summary>
        /// Removes the specified roles of a key.
        /// </summary>
        /// <param name="keyId">The key's ID</param>
        /// <param name="roleId">The role id list separated by semicolons (;)</param>
        /// <param name="roleName">The role name list separated by semicolons (;)</param>
        public async Task<RemoveKeyRolesResponse> RemoveKeyRoles(string keyId, string roleId = null, string roleName = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into RemoveKeyRoles");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of roleId, roleName passed into RemoveKeyRoles");
    
            var args = new Dictionary<string, object>();

            args["key_id"] = keyId;
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            return await PerformRequest<RemoveKeyRolesResponse>("RemoveKeyRoles", args);
}
        /// <summary>
        /// Creates a subuser.
        /// </summary>
        /// <param name="newSubuserName">The new subuser login for management api authentication, should be unique within the Voximplant account. The login specified is always converted to lowercase</param>
        /// <param name="newSubuserPassword">The new subuser password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="roleId">The role id list separated by semicolons (;)</param>
        /// <param name="roleName">The role name list separated by semicolons (;)</param>
        /// <param name="description">Description of a new subuser</param>
        public async Task<AddSubUserResponse> AddSubUser(string newSubuserName, string newSubuserPassword, string roleId = null, string roleName = null, string description = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into AddSubUser");
    
            var args = new Dictionary<string, object>();

            args["new_subuser_name"] = newSubuserName;
            args["new_subuser_password"] = newSubuserPassword;
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<AddSubUserResponse>("AddSubUser", args);
}
        /// <summary>
        /// Gets subusers.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        /// <param name="withRoles">Whether to show subuser's roles</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="count">The max returning record count</param>
        public async Task<GetSubUsersResponse> GetSubUsers(long? subuserId = null, bool? withRoles = null, long? offset = null, long? count = null)
        {
            var args = new Dictionary<string, object>();

            if (subuserId.HasValue)
                args["subuser_id"] = subuserId.Value.ToString();
            if (withRoles.HasValue)
                args["with_roles"] = withRoles.Value ? "1" : "0";
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            return await PerformRequest<GetSubUsersResponse>("GetSubUsers", args);
}
        /// <summary>
        /// Edits a subuser.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        /// <param name="oldSubuserPassword">The subuser old password. It is required if __new_subuser_password__ is specified</param>
        /// <param name="newSubuserPassword">The new user password. Must be at least 8 characters long and contain at least one uppercase and lowercase letter, one number, and one special character</param>
        /// <param name="description">The new subuser description</param>
        public async Task<SetSubUserInfoResponse> SetSubUserInfo(long subuserId, string oldSubuserPassword = null, string newSubuserPassword = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["subuser_id"] = subuserId.ToString();
            if (oldSubuserPassword != null)
                args["old_subuser_password"] = oldSubuserPassword;
            if (newSubuserPassword != null)
                args["new_subuser_password"] = newSubuserPassword;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<SetSubUserInfoResponse>("SetSubUserInfo", args);
}
        /// <summary>
        /// Deletes a subuser.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        public async Task<DelSubUserResponse> DelSubUser(long subuserId)
        {
            var args = new Dictionary<string, object>();

            args["subuser_id"] = subuserId.ToString();
            return await PerformRequest<DelSubUserResponse>("DelSubUser", args);
}
        /// <summary>
        /// Adds the specified roles for a subuser.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        /// <param name="roleId">The role id list separated by semicolons (;)</param>
        /// <param name="roleName">The role name list separated by semicolons (;)</param>
        public async Task<SetSubUserRolesResponse> SetSubUserRoles(long subuserId, string roleId = null, string roleName = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into SetSubUserRoles");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of roleId, roleName passed into SetSubUserRoles");
    
            var args = new Dictionary<string, object>();

            args["subuser_id"] = subuserId.ToString();
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            return await PerformRequest<SetSubUserRolesResponse>("SetSubUserRoles", args);
}
        /// <summary>
        /// Gets the subuser's roles.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        /// <param name="withExpandedRoles">Whether to show the roles' additional properties</param>
        public async Task<GetSubUserRolesResponse> GetSubUserRoles(long subuserId, bool? withExpandedRoles = null)
        {
            var args = new Dictionary<string, object>();

            args["subuser_id"] = subuserId.ToString();
            if (withExpandedRoles.HasValue)
                args["with_expanded_roles"] = withExpandedRoles.Value ? "1" : "0";
            return await PerformRequest<GetSubUserRolesResponse>("GetSubUserRoles", args);
}
        /// <summary>
        /// Removes the specified roles of a subuser.
        /// </summary>
        /// <param name="subuserId">The subuser's ID</param>
        /// <param name="roleId">The role id list separated by semicolons (;)</param>
        /// <param name="roleName">The role name list separated by semicolons (;)</param>
        /// <param name="force">Whether to remove roles from all subuser keys</param>
        public async Task<RemoveSubUserRolesResponse> RemoveSubUserRoles(long subuserId, string roleId = null, string roleName = null, bool? force = null)
        {
            var passedArgs = new List<string>();
        
            if (roleId != null)
                passedArgs.Add("roleId");
            if (roleName != null)
                passedArgs.Add("roleName");
            if (passedArgs.Count > 1)
                throw new VoximplantException(string.Join(", ", passedArgs) + " passed simultaneously into RemoveSubUserRoles");
            if (passedArgs.Count == 0)
                throw new VoximplantException("None of roleId, roleName passed into RemoveSubUserRoles");
    
            var args = new Dictionary<string, object>();

            args["subuser_id"] = subuserId.ToString();
            if (roleId != null)
                args["role_id"] = roleId;
            if (roleName != null)
                args["role_name"] = roleName;
            if (force.HasValue)
                args["force"] = force.Value ? "1" : "0";
            return await PerformRequest<RemoveSubUserRolesResponse>("RemoveSubUserRoles", args);
}
        /// <summary>
        /// Gets all roles.
        /// </summary>
        /// <param name="groupName">The role group</param>
        public async Task<GetRolesResponse> GetRoles(string groupName = null)
        {
            var args = new Dictionary<string, object>();

            if (groupName != null)
                args["group_name"] = groupName;
            return await PerformRequest<GetRolesResponse>("GetRoles", args);
}
        /// <summary>
        /// Gets role groups.
        /// </summary>
        public async Task<GetRoleGroupsResponse> GetRoleGroups()
        {
            var args = new Dictionary<string, object>();

            return await PerformRequest<GetRoleGroupsResponse>("GetRoleGroups", args);
}
        /// <summary>
        /// Creates or updates a key-value pair. If an existing key is passed, the method returns the existing item and changes the value if needed. The keys should be unique within a Voximplant application.
        /// </summary>
        /// <param name="key">Key, up to 200 characters. A key can contain a namespace that is written before the ':' symbol, for example, test:1234. Thus, namespace 'test' can be used as a pattern in the [GetKeyValueItems](/docs/references/httpapi/keyvaluestorage#getkeyvalueitems) and [GetKeyValueKeys](/docs/references/httpapi/keyvaluestorage#getkeyvaluekeys) methods to find the keys with the same namespace</param>
        /// <param name="value">Value for the specified key, up to 2000 characters</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name</param>
        /// <param name="ttl">Key expiry time in seconds. The value is in range of 0..7,776,000 (90 days), the default value is 30 days (2,592,000 seconds). The TTL is converted to an **expires_at** Unix timestamp field as part of the storage object. Note that one of the two parameters (ttl or expires_at) must be set</param>
        /// <param name="expiresAt">Expiration date based on **ttl** (timestamp without milliseconds). Note that one of the two parameters (ttl or expires_at) must be set</param>
        public async Task<SetKeyValueItemResponse> SetKeyValueItem(string key, string value, long applicationId, string applicationName = null, long? ttl = null, long? expiresAt = null)
        {
            var args = new Dictionary<string, object>();

            args["key"] = key;
            args["value"] = value;
            args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (ttl.HasValue)
                args["ttl"] = ttl.Value.ToString();
            if (expiresAt.HasValue)
                args["expires_at"] = expiresAt.Value.ToString();
            return await PerformRequest<SetKeyValueItemResponse>("SetKeyValueItem", args);
}
        /// <summary>
        /// Deletes the specified key-value pair from the storage.
        /// </summary>
        /// <param name="key">Key, up to 200 characters</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name</param>
        public async Task<DelKeyValueItemResponse> DelKeyValueItem(string key, long applicationId, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            args["key"] = key;
            args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<DelKeyValueItemResponse>("DelKeyValueItem", args);
}
        /// <summary>
        /// Gets the specified key-value pair from the storage.
        /// </summary>
        /// <param name="key">Key, up to 200 characters</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="applicationName">The application name</param>
        public async Task<GetKeyValueItemResponse> GetKeyValueItem(string key, long applicationId, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            args["key"] = key;
            args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<GetKeyValueItemResponse>("GetKeyValueItem", args);
}
        /// <summary>
        /// Gets all the key-value pairs in which the keys begin with a pattern.
        /// </summary>
        /// <param name="key">Namespace that keys should contain, up to 200 characters</param>
        /// <param name="applicationId">The application ID</param>
        /// <param name="count">Number of items to show per page with a maximum value of 50. Default value is 10</param>
        /// <param name="offset">Number of items to skip (e.g. if you set count = 20 and offset = 0 the first time, the next time, offset has to be equal to 20 to skip the items shown earlier). Default value is 0</param>
        /// <param name="applicationName">The application name</param>
        public async Task<GetKeyValueItemsResponse> GetKeyValueItems(string key, long applicationId, long? count = null, long? offset = null, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            args["key"] = key;
            args["application_id"] = applicationId.ToString();
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<GetKeyValueItemsResponse>("GetKeyValueItems", args);
}
        /// <summary>
        /// Gets all the keys of key-value pairs.
        /// </summary>
        /// <param name="applicationId">The application ID</param>
        /// <param name="key">Namespace that keys should contain, up to 200 characters</param>
        /// <param name="count">Number of items to show per page with a maximum value of 50. Default value is 10</param>
        /// <param name="offset">Number of items to skip (e.g. if you set count = 20 and offset = 0 the first time, the next time, offset has to be equal to 20 to skip the items shown earlier). Default value is 0</param>
        /// <param name="applicationName">The application name</param>
        public async Task<GetKeyValueKeysResponse> GetKeyValueKeys(long applicationId, string key = null, long? count = null, long? offset = null, string applicationName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            if (key != null)
                args["key"] = key;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            return await PerformRequest<GetKeyValueKeysResponse>("GetKeyValueKeys", args);
}
        /// <summary>
        /// Gets all invoices for the specified USD or EUR account.
        /// </summary>
        /// <param name="count">Number of invoices to show per page. Default value is 20</param>
        /// <param name="offset">Number of invoices to skip (e.g. if you set count = 20 and offset = 0 the first time, the next time, offset has to be equal to 20 to skip the items shown earlier). Default value is 0</param>
        public async Task<GetAccountInvoicesResponse> GetAccountInvoices(long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<GetAccountInvoicesResponse>("GetAccountInvoices", args);
}
        /// <summary>
        /// Downloads the specified invoice.
        /// </summary>
        /// <param name="invoiceId">Invoice ID</param>
        public async Task<DownloadInvoiceResponse> DownloadInvoice(long invoiceId)
        {
            var args = new Dictionary<string, object>();

            args["invoice_id"] = invoiceId.ToString();
            return await PerformRequest<DownloadInvoiceResponse>("DownloadInvoice", args);
}
        /// <summary>
        /// Gets the history of sent and/or received SMS.
        /// </summary>
        /// <param name="sourceNumber">The source phone number</param>
        /// <param name="destinationNumber">The destination phone number</param>
        /// <param name="direction">Sent or received SMS. Possible values: 'IN', 'OUT', 'in, 'out'. Leave blank to get both incoming and outgoing messages</param>
        /// <param name="count">Maximum number of resulting rows fetched. Must be not bigger than 1000. If left blank, then the default value of 1000 is used</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="fromDate">Date from which to perform search. Format is 'yyyy-MM-dd HH:mm:ss', time zone is UTC</param>
        /// <param name="toDate">Date until which to perform search. Format is 'yyyy-MM-dd HH:mm:ss', time zone is UTC</param>
        /// <param name="output">The output format. The following values available: **json**, **csv**, **xls**. The default value is **json**</param>
        public async Task<GetSmsHistoryResponse> GetSmsHistory(string sourceNumber = null, string destinationNumber = null, string direction = null, long? count = null, long? offset = null, DateTime? fromDate = null, DateTime? toDate = null, string output = null)
        {
            var args = new Dictionary<string, object>();

            if (sourceNumber != null)
                args["source_number"] = sourceNumber;
            if (destinationNumber != null)
                args["destination_number"] = destinationNumber;
            if (direction != null)
                args["direction"] = direction;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (fromDate.HasValue)
                args["from_date"] = fromDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (output != null)
                args["output"] = output;
            return await PerformRequest<GetSmsHistoryResponse>("GetSmsHistory", args);
}
        /// <summary>
        /// Gets the history of sent/or received A2P SMS.
        /// </summary>
        /// <param name="sourceNumber">The source phone number</param>
        /// <param name="destinationNumber">The destination phone number</param>
        /// <param name="count">Maximum number of resulting rows fetched. Must be not bigger than 1000. If left blank, then the default value of 1000 is used</param>
        /// <param name="offset">The first <b>N</b> records are skipped in the output</param>
        /// <param name="fromDate">Date from which the search is to start. Format is 'yyyy-MM-dd HH:mm:ss', time zone is UTC</param>
        /// <param name="toDate">Date from which the search is to end. Format is 'yyyy-MM-dd HH:mm:ss', time zone is UTC</param>
        /// <param name="output">The output format. The following values available: **json**, **csv**, **xls**. The default value is **json**</param>
        /// <param name="deliveryStatus">The delivery status ID: QUEUED - 1, DISPATCHED - 2, ABORTED - 3, REJECTED - 4, DELIVERED - 5, FAILED - 6, EXPIRED - 7, UNKNOWN - 8</param>
        public async Task<A2PGetSmsHistoryResponse> A2PGetSmsHistory(string sourceNumber = null, string destinationNumber = null, long? count = null, long? offset = null, DateTime? fromDate = null, DateTime? toDate = null, string output = null, long? deliveryStatus = null)
        {
            var args = new Dictionary<string, object>();

            if (sourceNumber != null)
                args["source_number"] = sourceNumber;
            if (destinationNumber != null)
                args["destination_number"] = destinationNumber;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (fromDate.HasValue)
                args["from_date"] = fromDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (toDate.HasValue)
                args["to_date"] = toDate.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            if (output != null)
                args["output"] = output;
            if (deliveryStatus.HasValue)
                args["delivery_status"] = deliveryStatus.Value.ToString();
            return await PerformRequest<A2PGetSmsHistoryResponse>("A2PGetSmsHistory", args);
}
        /// <summary>
        /// Adds a new queue.
        /// </summary>
        /// <param name="applicationId">ID of the application to bind to</param>
        /// <param name="sqQueueName">Unique SmartQueue name within the application, up to 100 characters</param>
        /// <param name="callAgentSelection">Agent selection strategy for calls. Accepts one of the following values: "MOST_QUALIFIED", "LEAST_QUALIFIED", "MAX_WAITING_TIME"</param>
        /// <param name="callTaskSelection">Call type requests prioritizing strategy. Accepts one of the [SQTaskSelectionStrategies] enum values</param>
        /// <param name="applicationName">Name of the application to bind to. Can be used instead of <b>application_id</b></param>
        /// <param name="imAgentSelection">Agent selection strategy for messages. Accepts one of the following values: "MOST_QUALIFIED", "LEAST_QUALIFIED", "MAX_WAITING_TIME". The default value is **call_agent_selection**</param>
        /// <param name="imTaskSelection">IM type requests prioritizing strategy. Accepts one of the [SQTaskSelectionStrategies] enum values. The default value is **call_task_selection**</param>
        /// <param name="description">Comment, up to 200 characters</param>
        /// <param name="callMaxWaitingTime">Maximum time in minutes that a CALL-type request can remain in the queue without being assigned to an agent. Specify either this parameter or `call_max_waiting_time_in_seconds`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="imMaxWaitingTime">Maximum time in minutes that an IM-type request can remain in the queue without being assigned to an agent. Specify either this parameter or `im_max_waiting_time_in_seconds`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="callMaxQueueSize">Maximum size of the queue with CALL-type requests</param>
        /// <param name="imMaxQueueSize">Maximum size of the queue with IM-type requests</param>
        /// <param name="priority">The queue's priority from 1 to 100</param>
        /// <param name="callMaxWaitingTimeInSeconds">Maximum call waiting time in seconds. Specify either this parameter or `call_max_waiting_time`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="imMaxWaitingTimeInSeconds">Maximum chat message waiting time in seconds. Specify either this parameter or `im_max_waiting_time`. Specifying both parameters simultaniously leads to an error</param>
        public async Task<SQ_AddQueueResponse> SQ_AddQueue(long applicationId, string sqQueueName, string callAgentSelection, string callTaskSelection, string applicationName = null, string imAgentSelection = null, string imTaskSelection = null, string description = null, long? callMaxWaitingTime = null, long? imMaxWaitingTime = null, long? callMaxQueueSize = null, long? imMaxQueueSize = null, long? priority = null, long? callMaxWaitingTimeInSeconds = null, long? imMaxWaitingTimeInSeconds = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_queue_name"] = sqQueueName;
            args["call_agent_selection"] = callAgentSelection;
            args["call_task_selection"] = callTaskSelection;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (imAgentSelection != null)
                args["im_agent_selection"] = imAgentSelection;
            if (imTaskSelection != null)
                args["im_task_selection"] = imTaskSelection;
            if (description != null)
                args["description"] = description;
            if (callMaxWaitingTime.HasValue)
                args["call_max_waiting_time"] = callMaxWaitingTime.Value.ToString();
            if (imMaxWaitingTime.HasValue)
                args["im_max_waiting_time"] = imMaxWaitingTime.Value.ToString();
            if (callMaxQueueSize.HasValue)
                args["call_max_queue_size"] = callMaxQueueSize.Value.ToString();
            if (imMaxQueueSize.HasValue)
                args["im_max_queue_size"] = imMaxQueueSize.Value.ToString();
            if (priority.HasValue)
                args["priority"] = priority.Value.ToString();
            if (callMaxWaitingTimeInSeconds.HasValue)
                args["call_max_waiting_time_in_seconds"] = callMaxWaitingTimeInSeconds.Value.ToString();
            if (imMaxWaitingTimeInSeconds.HasValue)
                args["im_max_waiting_time_in_seconds"] = imMaxWaitingTimeInSeconds.Value.ToString();
            return await PerformRequest<SQ_AddQueueResponse>("SQ_AddQueue", args);
}
        /// <summary>
        /// Edits an existing queue.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqQueueId">ID of the SmartQueue to search for</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueName">Name of the SmartQueue to search for. Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="newSqQueueName">New SmartQueue name within the application, up to 100 characters</param>
        /// <param name="callAgentSelection">Agent selection strategy for calls. Accepts one of the following values: "MOST_QUALIFIED", "LEAST_QUALIFIED", "MAX_WAITING_TIME"</param>
        /// <param name="imAgentSelection">Agent selection strategy for messages. Accepts one of the following values: "MOST_QUALIFIED", "LEAST_QUALIFIED", "MAX_WAITING_TIME". The default value is **call_agent_selection**</param>
        /// <param name="callTaskSelection">Strategy of prioritizing CALL-type requests for service. Accepts one of the following values: "MAX_PRIORITY", "MAX_WAITING_TIME"</param>
        /// <param name="imTaskSelection">Strategy of prioritizing IM-type requests for service. Accepts one of the following values: "MAX_PRIORITY", "MAX_WAITING_TIME". The default value is **call_task_selection**</param>
        /// <param name="description">Comment, up to 200 characters</param>
        /// <param name="callMaxWaitingTime">Maximum time in minutes that a CALL-type request can remain in the queue without being assigned to an agent. Specify either this parameter or `call_max_waiting_time_in_seconds`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="imMaxWaitingTime">Maximum time in minutes that an IM-type request can remain in the queue without being assigned to an agent. Specify either this parameter or `im_max_waiting_time_in_seconds`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="callMaxQueueSize">Maximum size of the queue with CALL-type requests</param>
        /// <param name="imMaxQueueSize">Maximum size of the queue with IM-type requests</param>
        /// <param name="priority">The queue's priority from 1 to 100</param>
        /// <param name="callMaxWaitingTimeInSeconds">Maximum call waiting time in seconds. Specify either this parameter or `call_max_waiting_time`. Specifying both parameters simultaniously leads to an error</param>
        /// <param name="imMaxWaitingTimeInSeconds">Maximum chat message waiting time in seconds. Specify either this parameter or `im_max_waiting_time`. Specifying both parameters simultaniously leads to an error</param>
        public async Task<SQ_SetQueueInfoResponse> SQ_SetQueueInfo(long applicationId, long sqQueueId, string applicationName = null, string sqQueueName = null, string newSqQueueName = null, string callAgentSelection = null, string imAgentSelection = null, string callTaskSelection = null, string imTaskSelection = null, string description = null, long? callMaxWaitingTime = null, long? imMaxWaitingTime = null, long? callMaxQueueSize = null, long? imMaxQueueSize = null, long? priority = null, long? callMaxWaitingTimeInSeconds = null, long? imMaxWaitingTimeInSeconds = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_queue_id"] = sqQueueId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (newSqQueueName != null)
                args["new_sq_queue_name"] = newSqQueueName;
            if (callAgentSelection != null)
                args["call_agent_selection"] = callAgentSelection;
            if (imAgentSelection != null)
                args["im_agent_selection"] = imAgentSelection;
            if (callTaskSelection != null)
                args["call_task_selection"] = callTaskSelection;
            if (imTaskSelection != null)
                args["im_task_selection"] = imTaskSelection;
            if (description != null)
                args["description"] = description;
            if (callMaxWaitingTime.HasValue)
                args["call_max_waiting_time"] = callMaxWaitingTime.Value.ToString();
            if (imMaxWaitingTime.HasValue)
                args["im_max_waiting_time"] = imMaxWaitingTime.Value.ToString();
            if (callMaxQueueSize.HasValue)
                args["call_max_queue_size"] = callMaxQueueSize.Value.ToString();
            if (imMaxQueueSize.HasValue)
                args["im_max_queue_size"] = imMaxQueueSize.Value.ToString();
            if (priority.HasValue)
                args["priority"] = priority.Value.ToString();
            if (callMaxWaitingTimeInSeconds.HasValue)
                args["call_max_waiting_time_in_seconds"] = callMaxWaitingTimeInSeconds.Value.ToString();
            if (imMaxWaitingTimeInSeconds.HasValue)
                args["im_max_waiting_time_in_seconds"] = imMaxWaitingTimeInSeconds.Value.ToString();
            return await PerformRequest<SQ_SetQueueInfoResponse>("SQ_SetQueueInfo", args);
}
        /// <summary>
        /// Deletes a queue.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqQueueId">List of SmartQueue IDs separated by semicolons (;). Use 'all' to delete all the queues</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueName">List of SmartQueue names separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        public async Task<SQ_DelQueueResponse> SQ_DelQueue(long applicationId, string sqQueueId, string applicationName = null, string sqQueueName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_queue_id"] = sqQueueId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            return await PerformRequest<SQ_DelQueueResponse>("SQ_DelQueue", args);
}
        /// <summary>
        /// Gets the queue(s).
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueId">List of SmartQueue IDs separated by semicolons (;)</param>
        /// <param name="sqQueueName">List of SmartQueue names separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="sqQueueNameTemplate">Substring of the SmartQueue name to filter</param>
        /// <param name="userId">ID of the user that is bound to the queue</param>
        /// <param name="userName">Name of the user that is bound to the queue. Can be used instead of <b>user_id</b></param>
        /// <param name="excludedUserId">ID of the user that is not bound to the queue</param>
        /// <param name="excludedUserName">Name of the user that is not bound to the queue. Can be used instead of <b>excluded_user_id</b></param>
        /// <param name="count">Number of items to show in the output</param>
        /// <param name="offset">Number of items to skip in the output</param>
        /// <param name="withAgentcount">Whether to include the number of agents bound to the queue</param>
        public async Task<SQ_GetQueuesResponse> SQ_GetQueues(long applicationId, string applicationName = null, string sqQueueId = null, string sqQueueName = null, string sqQueueNameTemplate = null, long? userId = null, string userName = null, long? excludedUserId = null, string excludedUserName = null, long? count = null, long? offset = null, bool? withAgentcount = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueId != null)
                args["sq_queue_id"] = sqQueueId;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (sqQueueNameTemplate != null)
                args["sq_queue_name_template"] = sqQueueNameTemplate;
            if (userId.HasValue)
                args["user_id"] = userId.Value.ToString();
            if (userName != null)
                args["user_name"] = userName;
            if (excludedUserId.HasValue)
                args["excluded_user_id"] = excludedUserId.Value.ToString();
            if (excludedUserName != null)
                args["excluded_user_name"] = excludedUserName;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            if (withAgentcount.HasValue)
                args["with_agentcount"] = withAgentcount.Value ? "1" : "0";
            return await PerformRequest<SQ_GetQueuesResponse>("SQ_GetQueues", args);
}
        /// <summary>
        /// Adds a new skill to the app.
        /// </summary>
        /// <param name="applicationId">ID of the application to bind to</param>
        /// <param name="sqSkillName">Unique skill name within the application</param>
        /// <param name="applicationName">Name of the application to bind to. Can be used instead of <b>application_id</b></param>
        /// <param name="description">Comment, up to 200 characters</param>
        public async Task<SQ_AddSkillResponse> SQ_AddSkill(long applicationId, string sqSkillName, string applicationName = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_skill_name"] = sqSkillName;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<SQ_AddSkillResponse>("SQ_AddSkill", args);
}
        /// <summary>
        /// Deletes a skill and detaches it from agents.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqSkillId">List of skill IDs separated by semicolons (;). Use 'all' to delete all the skills</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqSkillName">List of skill names separated by semicolons (;). Can be used instead of <b>sq_skill_id</b></param>
        public async Task<SQ_DelSkillResponse> SQ_DelSkill(long applicationId, string sqSkillId, string applicationName = null, string sqSkillName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_skill_id"] = sqSkillId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqSkillName != null)
                args["sq_skill_name"] = sqSkillName;
            return await PerformRequest<SQ_DelSkillResponse>("SQ_DelSkill", args);
}
        /// <summary>
        /// Edits an existing skill.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqSkillId">ID of the skill</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqSkillName">Name of the skill. Can be used instead of <b>sq_skill_id</b></param>
        /// <param name="newSqSkillName">New unique skill name within the application</param>
        /// <param name="description">Comment, up to 200 characters</param>
        public async Task<SQ_SetSkillInfoResponse> SQ_SetSkillInfo(long applicationId, long sqSkillId, string applicationName = null, string sqSkillName = null, string newSqSkillName = null, string description = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_skill_id"] = sqSkillId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqSkillName != null)
                args["sq_skill_name"] = sqSkillName;
            if (newSqSkillName != null)
                args["new_sq_skill_name"] = newSqSkillName;
            if (description != null)
                args["description"] = description;
            return await PerformRequest<SQ_SetSkillInfoResponse>("SQ_SetSkillInfo", args);
}
        /// <summary>
        /// Binds skills to agents.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="userId">List of user IDs separated by semicolons (;). Use 'all' to select all the users</param>
        /// <param name="sqSkills">Skills to be bound to agents in the json array format. The array should contain objects with the <b>sq_skill_id</b>/<b>sq_skill_name</b> and <b>sq_skill_level</b> keys where skill levels range from 1 to 5</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="bindMode">Binding mode. Accepts one of the [SQSkillBindingModes] enum values</param>
        public async Task<SQ_BindSkillResponse> SQ_BindSkill(long applicationId, string userId, Object sqSkills, string applicationName = null, string userName = null, string bindMode = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["user_id"] = userId;
            args["sq_skills"] = sqSkills.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userName != null)
                args["user_name"] = userName;
            if (bindMode != null)
                args["bind_mode"] = bindMode;
            return await PerformRequest<SQ_BindSkillResponse>("SQ_BindSkill", args);
}
        /// <summary>
        /// Unbinds skills from agents.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="userId">List of user IDs separated by semicolons (;). Use 'all' to select all the users</param>
        /// <param name="sqSkillId">List of skill IDs separated by semicolons (;). Use 'all' to unbind all the skills</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="sqSkillName">List of skill names separated by semicolons (;). Can be used instead of <b>sq_skill_id</b></param>
        public async Task<SQ_UnbindSkillResponse> SQ_UnbindSkill(long applicationId, string userId, string sqSkillId, string applicationName = null, string userName = null, string sqSkillName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["user_id"] = userId;
            args["sq_skill_id"] = sqSkillId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userName != null)
                args["user_name"] = userName;
            if (sqSkillName != null)
                args["sq_skill_name"] = sqSkillName;
            return await PerformRequest<SQ_UnbindSkillResponse>("SQ_UnbindSkill", args);
}
        /// <summary>
        /// Gets the skill(s).
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="userId">List of user IDs separated by semicolons (;)</param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="sqSkillId">List of skill IDs separated by semicolons (;)</param>
        /// <param name="sqSkillName">List of skill names separated by semicolons (;). Can be used instead of <b>sq_skill_id</b></param>
        /// <param name="sqSkillNameTemplate">Substring of the skill name to filter, case-insensitive</param>
        /// <param name="excludedUserId">ID of the user that is not bound to the skill</param>
        /// <param name="excludedUserName">Name of the user that is not bound to the skill. Can be used instead of <b>excluded_user_id</b></param>
        /// <param name="count">Number of items to show in the output</param>
        /// <param name="offset">Number of items to skip in the output</param>
        public async Task<SQ_GetSkillsResponse> SQ_GetSkills(long applicationId, string applicationName = null, string userId = null, string userName = null, string sqSkillId = null, string sqSkillName = null, string sqSkillNameTemplate = null, long? excludedUserId = null, string excludedUserName = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (sqSkillId != null)
                args["sq_skill_id"] = sqSkillId;
            if (sqSkillName != null)
                args["sq_skill_name"] = sqSkillName;
            if (sqSkillNameTemplate != null)
                args["sq_skill_name_template"] = sqSkillNameTemplate;
            if (excludedUserId.HasValue)
                args["excluded_user_id"] = excludedUserId.Value.ToString();
            if (excludedUserName != null)
                args["excluded_user_name"] = excludedUserName;
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<SQ_GetSkillsResponse>("SQ_GetSkills", args);
}
        /// <summary>
        /// Binds agents to a queue.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqQueueId">ID of the SmartQueue. Pass a list of values divided by ; or the "all" keyword</param>
        /// <param name="userId">List of user IDs separated by semicolons (;). Use 'all' to select all the users</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueName">Name of the SmartQueue. Pass a list of names divided by ; or the "all" keyword</param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="bindMode">Binding mode. Accepts one of the [SQAgentBindingModes] enum values</param>
        public async Task<SQ_BindAgentResponse> SQ_BindAgent(long applicationId, string sqQueueId, string userId, string applicationName = null, string sqQueueName = null, string userName = null, string bindMode = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_queue_id"] = sqQueueId;
            args["user_id"] = userId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (userName != null)
                args["user_name"] = userName;
            if (bindMode != null)
                args["bind_mode"] = bindMode;
            return await PerformRequest<SQ_BindAgentResponse>("SQ_BindAgent", args);
}
        /// <summary>
        /// Unbinds agents from queues.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="sqQueueId">List of SmartQueue IDs separated by semicolons (;). Use 'all' to select all the queues</param>
        /// <param name="userId">List of user IDs separated by semicolons (;). Use 'all' to select all the users</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueName">List of SmartQueue names separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        public async Task<SQ_UnbindAgentResponse> SQ_UnbindAgent(long applicationId, string sqQueueId, string userId, string applicationName = null, string sqQueueName = null, string userName = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["sq_queue_id"] = sqQueueId;
            args["user_id"] = userId;
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (userName != null)
                args["user_name"] = userName;
            return await PerformRequest<SQ_UnbindAgentResponse>("SQ_UnbindAgent", args);
}
        /// <summary>
        /// Gets agents.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="handleCalls">Whether the agent can handle calls. When set to false, the agent is excluded from the CALL-request distribution</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="sqQueueId">List of SmartQueue IDs separated by semicolons (;). Use 'all' to select all the queues</param>
        /// <param name="sqQueueName">List of SmartQueue names separated by semicolons (;). Can be used instead of <b>sq_queue_id</b></param>
        /// <param name="excludedSqQueueId">ID of the SmartQueue to exclude</param>
        /// <param name="excludedSqQueueName">Name of the SmartQueue to exclude. Can be used instead of <b>excluded_sq_queue_id</b></param>
        /// <param name="sqSkills">Skills to filter in the json array format. The array should contain objects with the <b>sq_skill_id</b>/<b>sq_skill_name</b>, <b>min_sq_skill_level</b>, and <b>max_sq_skill_level</b> keys where skill levels range from 1 to 5</param>
        /// <param name="userId">List of user IDs separated by semicolons (;)</param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="userNameTemplate">Substring of the user name to filter</param>
        /// <param name="sqStatuses">Filter statuses in the json array format. The array should contain objects with the <b>sq_status_type</b> and <b>sq_status_name</b> keys. Possible values for <b>sq_status_type</b> are 'CALL' and 'IM'. Possible values for <b>sq_status_name</b> are 'OFFLINE', 'ONLINE', 'READY', 'IN_SERVICE', 'AFTER_SERVICE', 'DND'</param>
        /// <param name="withSqSkills">Whether to display agent skills</param>
        /// <param name="withSqQueues">Whether to display agent queues</param>
        /// <param name="withSqStatuses">Whether to display agent current statuses</param>
        /// <param name="count">Number of items to show in the output</param>
        /// <param name="offset">Number of items to skip in the output</param>
        public async Task<SQ_GetAgentsResponse> SQ_GetAgents(long applicationId, bool handleCalls, string applicationName = null, string sqQueueId = null, string sqQueueName = null, long? excludedSqQueueId = null, string excludedSqQueueName = null, Object sqSkills = null, string userId = null, string userName = null, string userNameTemplate = null, Object sqStatuses = null, bool? withSqSkills = null, bool? withSqQueues = null, bool? withSqStatuses = null, long? count = null, long? offset = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["handle_calls"] = handleCalls.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (sqQueueId != null)
                args["sq_queue_id"] = sqQueueId;
            if (sqQueueName != null)
                args["sq_queue_name"] = sqQueueName;
            if (excludedSqQueueId.HasValue)
                args["excluded_sq_queue_id"] = excludedSqQueueId.Value.ToString();
            if (excludedSqQueueName != null)
                args["excluded_sq_queue_name"] = excludedSqQueueName;
            if (sqSkills != null)
                args["sq_skills"] = sqSkills.ToString();
            if (userId != null)
                args["user_id"] = userId;
            if (userName != null)
                args["user_name"] = userName;
            if (userNameTemplate != null)
                args["user_name_template"] = userNameTemplate;
            if (sqStatuses != null)
                args["sq_statuses"] = sqStatuses.ToString();
            if (withSqSkills.HasValue)
                args["with_sq_skills"] = withSqSkills.Value ? "1" : "0";
            if (withSqQueues.HasValue)
                args["with_sq_queues"] = withSqQueues.Value ? "1" : "0";
            if (withSqStatuses.HasValue)
                args["with_sq_statuses"] = withSqStatuses.Value ? "1" : "0";
            if (count.HasValue)
                args["count"] = count.Value.ToString();
            if (offset.HasValue)
                args["offset"] = offset.Value.ToString();
            return await PerformRequest<SQ_GetAgentsResponse>("SQ_GetAgents", args);
}
        /// <summary>
        /// Edits the agent settings.
        /// </summary>
        /// <param name="applicationId">ID of the application to search by</param>
        /// <param name="userId">List of user IDs separated by semicolons (;). Use 'all' to select all the users</param>
        /// <param name="handleCalls">Whether the agent can handle calls. When set to false, the agent is excluded from the CALL-request distribution</param>
        /// <param name="applicationName">Name of the application to search by. Can be used instead of <b>application_id</b></param>
        /// <param name="userName">List of user names separated by semicolons (;). Can be used instead of <b>user_id</b></param>
        /// <param name="maxSimultaneousConversations">Maximum number of chats that the user processes simultaneously</param>
        public async Task<SQ_SetAgentInfoResponse> SQ_SetAgentInfo(long applicationId, string userId, bool handleCalls, string applicationName = null, string userName = null, long? maxSimultaneousConversations = null)
        {
            var args = new Dictionary<string, object>();

            args["application_id"] = applicationId.ToString();
            args["user_id"] = userId;
            args["handle_calls"] = handleCalls.ToString();
            if (applicationName != null)
                args["application_name"] = applicationName;
            if (userName != null)
                args["user_name"] = userName;
            if (maxSimultaneousConversations.HasValue)
                args["max_simultaneous_conversations"] = maxSimultaneousConversations.Value.ToString();
            return await PerformRequest<SQ_SetAgentInfoResponse>("SQ_SetAgentInfo", args);
}
    }
}