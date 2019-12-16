using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Request {

    public class SetChildAccountInfoRequest : BaseRequest
    {
        /// <summary>
        /// The child account ID list separated by the ';' symbol or the 'all'
        /// value.
        /// </summary>
        [JsonProperty("child_account_id")]
        public Argument<long> ChildAccountId { get; set; }

        /// <summary>
        /// The child account name list separated by the ';' symbol. Can be used
        /// instead of <b>child_account_id</b>.
        /// </summary>
        [JsonProperty("child_account_name")]
        public Argument<string> ChildAccountName { get; set; }

        /// <summary>
        /// The child account email list separated by the ';' symbol. Can be used
        /// instead of <b>child_account_id</b>.
        /// </summary>
        [JsonProperty("child_account_email")]
        public Argument<string> ChildAccountEmail { get; set; }

        /// <summary>
        /// The new child account email.
        /// </summary>
        [JsonProperty("new_child_account_email")]
        public string NewChildAccountEmail { get; set; }

        /// <summary>
        /// The new child account password.
        /// </summary>
        [JsonProperty("new_child_account_password")]
        public string NewChildAccountPassword { get; set; }

        /// <summary>
        /// Are the VoxImplant notifications required?
        /// </summary>
        [JsonProperty("account_notifications")]
        public bool? AccountNotifications { get; set; }

        /// <summary>
        /// Set to true to receive the emails about the VoxImplant plan changing.
        /// </summary>
        [JsonProperty("tariff_changing_notifications")]
        public bool? TariffChangingNotifications { get; set; }

        /// <summary>
        /// Set to true to receive the emails about the VoxImplant news.
        /// </summary>
        [JsonProperty("news_notifications")]
        public bool? NewsNotifications { get; set; }

        /// <summary>
        /// Set false to disable the child account.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The notification language code (2 symbols, ISO639-1). The following
        /// values are available: aa (Afar), ab (Abkhazian), af (Afrikaans), am
        /// (Amharic), ar (Arabic), as (Assamese), ay (Aymara), az (Azerbaijani),
        /// ba (Bashkir), be (Belarusian), bg (Bulgarian), bh (Bihari), bi
        /// (Bislama), bn (Bengali), bo (Tibetan), br (Breton), ca (Catalan), co
        /// (Corsican), cs (Czech), cy (Welch), da (Danish), de (German), dz
        /// (Bhutani), el (Greek), en (English), eo (Esperanto), es (Spanish), et
        /// (Estonian), eu (Basque), fa (Persian), fi (Finnish), fj (Fiji), fo
        /// (Faeroese), fr (French), fy (Frisian), ga (Irish), gd (Scots Gaelic),
        /// gl (Galician), gn (Guarani), gu (Gujarati), ha (Hausa), hi (Hindi),
        /// he (Hebrew), hr (Croatian), hu (Hungarian), hy (Armenian), ia
        /// (Interlingua), id (Indonesian), ie (Interlingue), ik (Inupiak), in
        /// (Indonesian), is (Icelandic), it (Italian), iu (Inuktitut), iw
        /// (Hebrew), ja (Japanese), ji (Yiddish), jw (Javanese), ka (Georgian),
        /// kk (Kazakh), kl (Greenlandic), km (Cambodian), kn (Kannada), ko
        /// (Korean), ks (Kashmiri), ku (Kurdish), ky (Kirghiz), la (Latin), ln
        /// (Lingala), lo (Laothian), lt (Lithuanian), lv (Latvian), mg
        /// (Malagasy), mi (Maori), mk (Macedonian), ml (Malayalam), mn
        /// (Mongolian), mo (Moldavian), mr (Marathi), ms (Malay), mt (Maltese),
        /// my (Burmese), na (Nauru), ne (Nepali), nl (Dutch), no (Norwegian), oc
        /// (Occitan), om (Oromo), or (Oriya), pa (Punjabi), pl (Polish), ps
        /// (Pashto), pt (Portuguese), qu (Quechua), rm (Rhaeto-Romance), rn
        /// (Kirundi), ro (Romanian), ru (Russian), rw (Kinyarwanda), sa
        /// (Sanskrit), sd (Sindhi), sg (Sangro), sh (Serbo-Croatian), si
        /// (Singhalese), sk (Slovak), sl (Slovenian), sm (Samoan), sn (Shona),
        /// so (Somali), sq (Albanian), sr (Serbian), ss (Siswati), st (Sesotho),
        /// su (Sudanese), sv (Swedish), sw (Swahili), ta (Tamil), te (Tegulu),
        /// tg (Tajik), th (Thai), ti (Tigrinya), tk (Turkmen), tl (Tagalog), tn
        /// (Setswana), to (Tonga), tr (Turkish), ts (Tsonga), tt (Tatar), tw
        /// (Twi), ug (Uigur), uk (Ukrainian), ur (Urdu), uz (Uzbek), vi
        /// (Vietnamese), vo (Volapuk), wo (Wolof), xh (Xhosa), yi (Yiddish), yo
        /// (Yoruba), za (Zhuang), zh (Chinese), zu (Zulu)
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// The child account location (timezone). Examples: America/Los_Angeles,
        /// GMT-8, GMT-08:00, GMT+10
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// The min balance value to notify by email or SMS.
        /// </summary>
        [JsonProperty("min_balance_to_notify")]
        public decimal? MinBalanceToNotify { get; set; }

        /// <summary>
        /// Set to true to allow the robokassa payments.
        /// </summary>
        [JsonProperty("support_robokassa")]
        public bool? SupportRobokassa { get; set; }

        /// <summary>
        /// Set to true to allow the bank card payments.
        /// </summary>
        [JsonProperty("support_bank_card")]
        public bool? SupportBankCard { get; set; }

        /// <summary>
        /// Set to true to allow the bank invoices.
        /// </summary>
        [JsonProperty("support_invoice")]
        public bool? SupportInvoice { get; set; }

        /// <summary>
        /// Set to true to allow use restricted directions.
        /// </summary>
        [JsonProperty("can_use_restricted")]
        public bool? CanUseRestricted { get; set; }

        /// <summary>
        /// The minimum payment amount.
        /// </summary>
        [JsonProperty("min_payment_amount")]
        public long? MinPaymentAmount { get; set; }

    }
}