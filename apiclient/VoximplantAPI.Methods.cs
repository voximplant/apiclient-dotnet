using Voximplant.API.Request;
using Voximplant.API.Response;

namespace Voximplant.API {

    public partial class VoximplantAPI
    { 
        /// <summary>
        /// Gets the account's info such as account_id, account_name, account_email etc.
        /// </summary>
        public GetAccountInfoResponse GetAccountInfo(GetAccountInfoRequest request)
        {
            return PerformRequest<GetAccountInfoResponse, GetAccountInfoRequest>("GetAccountInfo", request);
        }

        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        public SetAccountInfoResponse SetAccountInfo(SetAccountInfoRequest request)
        {
            return PerformRequest<SetAccountInfoResponse, SetAccountInfoRequest>("SetAccountInfo", request);
        }

        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        public SetChildAccountInfoResponse SetChildAccountInfo(SetChildAccountInfoRequest request)
        {
            return PerformRequest<SetChildAccountInfoResponse, SetChildAccountInfoRequest>("SetChildAccountInfo", request);
        }

        /// <summary>
        /// Gets the exchange rate on selected date (per USD).
        /// </summary>
        public GetCurrencyRateResponse GetCurrencyRate(GetCurrencyRateRequest request)
        {
            return PerformRequest<GetCurrencyRateResponse, GetCurrencyRateRequest>("GetCurrencyRate", request);
        }

        /// <summary>
        /// Gets the resource price.
        /// </summary>
        public GetResourcePriceResponse GetResourcePrice(GetResourcePriceRequest request)
        {
            return PerformRequest<GetResourcePriceResponse, GetResourcePriceRequest>("GetResourcePrice", request);
        }

        /// <summary>
        /// Gets the subscription template price.
        /// </summary>
        public GetSubscriptionPriceResponse GetSubscriptionPrice(GetSubscriptionPriceRequest request)
        {
            return PerformRequest<GetSubscriptionPriceResponse, GetSubscriptionPriceRequest>("GetSubscriptionPrice", request);
        }

        /// <summary>
        /// Gets the info about all children accounts.
        /// </summary>
        public GetChildrenAccountsResponse GetChildrenAccounts(GetChildrenAccountsRequest request)
        {
            return PerformRequest<GetChildrenAccountsResponse, GetChildrenAccountsRequest>("GetChildrenAccounts", request);
        }

        /// <summary>
        /// Transfer the parent account's money to the child account or transfer the child's money to the parent account if the money amount is negative.
        /// </summary>
        public TransferMoneyToChildAccountResponse TransferMoneyToChildAccount(TransferMoneyToChildAccountRequest request)
        {
            return PerformRequest<TransferMoneyToChildAccountResponse, TransferMoneyToChildAccountRequest>("TransferMoneyToChildAccount", request);
        }

        /// <summary>
        /// Get the recommended money amount to charge.
        /// </summary>
        public GetMoneyAmountToChargeResponse GetMoneyAmountToCharge(GetMoneyAmountToChargeRequest request)
        {
            return PerformRequest<GetMoneyAmountToChargeResponse, GetMoneyAmountToChargeRequest>("GetMoneyAmountToCharge", request);
        }

        /// <summary>
        /// Charges the account in the manual mode. You should call the ChargeAccount function to charge the subscriptions having the auto_charge=false.
        /// </summary>
        public ChargeAccountResponse ChargeAccount(ChargeAccountRequest request)
        {
            return PerformRequest<ChargeAccountResponse, ChargeAccountRequest>("ChargeAccount", request);
        }

        /// <summary>
        /// Adds a new account's application.
        /// </summary>
        public AddApplicationResponse AddApplication(AddApplicationRequest request)
        {
            return PerformRequest<AddApplicationResponse, AddApplicationRequest>("AddApplication", request);
        }

        /// <summary>
        /// Deletes the account's application.
        /// </summary>
        public DelApplicationResponse DelApplication(DelApplicationRequest request)
        {
            return PerformRequest<DelApplicationResponse, DelApplicationRequest>("DelApplication", request);
        }

        /// <summary>
        /// Edits the account's application.
        /// </summary>
        public SetApplicationInfoResponse SetApplicationInfo(SetApplicationInfoRequest request)
        {
            return PerformRequest<SetApplicationInfoResponse, SetApplicationInfoRequest>("SetApplicationInfo", request);
        }

        /// <summary>
        /// Gets the account's applications.
        /// </summary>
        public GetApplicationsResponse GetApplications(GetApplicationsRequest request)
        {
            return PerformRequest<GetApplicationsResponse, GetApplicationsRequest>("GetApplications", request);
        }

        /// <summary>
        /// Adds a new user.
        /// </summary>
        public AddUserResponse AddUser(AddUserRequest request)
        {
            return PerformRequest<AddUserResponse, AddUserRequest>("AddUser", request);
        }

        /// <summary>
        /// Deletes the specified user(s).
        /// </summary>
        public DelUserResponse DelUser(DelUserRequest request)
        {
            return PerformRequest<DelUserResponse, DelUserRequest>("DelUser", request);
        }

        /// <summary>
        /// Edits the user.
        /// </summary>
        public SetUserInfoResponse SetUserInfo(SetUserInfoRequest request)
        {
            return PerformRequest<SetUserInfoResponse, SetUserInfoRequest>("SetUserInfo", request);
        }

        /// <summary>
        /// Shows the users of the specified account.
        /// </summary>
        public GetUsersResponse GetUsers(GetUsersRequest request)
        {
            return PerformRequest<GetUsersResponse, GetUsersRequest>("GetUsers", request);
        }

        /// <summary>
        /// Transfer the account's money to the user or transfer the user's money to the account if the money amount is negative.
        /// </summary>
        public TransferMoneyToUserResponse TransferMoneyToUser(TransferMoneyToUserRequest request)
        {
            return PerformRequest<TransferMoneyToUserResponse, TransferMoneyToUserRequest>("TransferMoneyToUser", request);
        }

        /// <summary>
        /// Adds a new CSV file for call list processing and starts the specified rule immediately. To send a file, use the request body. To set the call time constraints, use the following options in a CSV file: <ul><li>**__start_execution_time** – when the call list processing will start every day, UTC+0 24-h format: HH:mm:ss</li><li>**__end_execution_time** – when the call list processing will stop every day,  UTC+0 24-h format: HH:mm:ss</li><li>**__start_at** – when the call list processing will start, UNIX timestamp. If not specified, the processing will start immediately after a method call</li></ul><br/><b>IMPORTANT:</b> the account's balance should be equal or greater than 1 USD. If the balance is lower than 1 USD, the call list processing won't start, or it stops immediately if it was active.
        /// </summary>
        public CreateCallListResponse CreateCallList(CreateCallListRequest request)
        {
            return PerformRequest<CreateCallListResponse, CreateCallListRequest>("CreateCallList", request);
        }

        /// <summary>
        /// Adds a new CSV file for manual call list processing and bind it with the specified rule. To send a file, use the request body. To start processing calls, use the function <a href='//voximplant.com/docs/references/httpapi/managing_call_lists#startnextcalltask'>StartNextCallTask</a>. <b>IMPORTANT:</b> the account's balance should be equal or greater than 1 USD. If the balance is lower than 1 USD, the call list processing won't start, or it stops immediately if it was active.
        /// </summary>
        public CreateManualCallListResponse CreateManualCallList(CreateManualCallListRequest request)
        {
            return PerformRequest<CreateManualCallListResponse, CreateManualCallListRequest>("CreateManualCallList", request);
        }

        /// <summary>
        /// Start processing the next task.
        /// </summary>
        public StartNextCallTaskResponse StartNextCallTask(StartNextCallTaskRequest request)
        {
            return PerformRequest<StartNextCallTaskResponse, StartNextCallTaskRequest>("StartNextCallTask", request);
        }

        /// <summary>
        /// Appending a new task to the existing call list.
        /// </summary>
        public AppendToCallListResponse AppendToCallList(AppendToCallListRequest request)
        {
            return PerformRequest<AppendToCallListResponse, AppendToCallListRequest>("AppendToCallList", request);
        }

        /// <summary>
        /// Get all call lists for the specified user.
        /// </summary>
        public GetCallListsResponse GetCallLists(GetCallListsRequest request)
        {
            return PerformRequest<GetCallListsResponse, GetCallListsRequest>("GetCallLists", request);
        }

        /// <summary>
        /// Get details of the specified call list. Returns a CSV file by default.
        /// </summary>
        public GetCallListDetailsResponse GetCallListDetails(GetCallListDetailsRequest request)
        {
            return PerformRequest<GetCallListDetailsResponse, GetCallListDetailsRequest>("GetCallListDetails", request);
        }

        /// <summary>
        /// Stop processing the specified call list.
        /// </summary>
        public StopCallListProcessingResponse StopCallListProcessing(StopCallListProcessingRequest request)
        {
            return PerformRequest<StopCallListProcessingResponse, StopCallListProcessingRequest>("StopCallListProcessing", request);
        }

        /// <summary>
        /// Resume processing the specified call list.
        /// </summary>
        public RecoverCallListResponse RecoverCallList(RecoverCallListRequest request)
        {
            return PerformRequest<RecoverCallListResponse, RecoverCallListRequest>("RecoverCallList", request);
        }

        /// <summary>
        /// Adds a new scenario. Please use the POST method.
        /// </summary>
        public AddScenarioResponse AddScenario(AddScenarioRequest request)
        {
            return PerformRequest<AddScenarioResponse, AddScenarioRequest>("AddScenario", request);
        }

        /// <summary>
        /// Deletes the scenario.
        /// </summary>
        public DelScenarioResponse DelScenario(DelScenarioRequest request)
        {
            return PerformRequest<DelScenarioResponse, DelScenarioRequest>("DelScenario", request);
        }

        /// <summary>
        /// Bind the scenario list to the rule. You should specify the application_id or application_name if you specify the rule_name.
        /// </summary>
        public BindScenarioResponse BindScenario(BindScenarioRequest request)
        {
            return PerformRequest<BindScenarioResponse, BindScenarioRequest>("BindScenario", request);
        }

        /// <summary>
        /// Gets the account's scenarios.
        /// </summary>
        public GetScenariosResponse GetScenarios(GetScenariosRequest request)
        {
            return PerformRequest<GetScenariosResponse, GetScenariosRequest>("GetScenarios", request);
        }

        /// <summary>
        /// Edits the scenario. Please use the POST method.
        /// </summary>
        public SetScenarioInfoResponse SetScenarioInfo(SetScenarioInfoRequest request)
        {
            return PerformRequest<SetScenarioInfoResponse, SetScenarioInfoRequest>("SetScenarioInfo", request);
        }

        /// <summary>
        /// Configures the order of scenarios that are assigned to the specified rule.
        /// </summary>
        public ReorderScenariosResponse ReorderScenarios(ReorderScenariosRequest request)
        {
            return PerformRequest<ReorderScenariosResponse, ReorderScenariosRequest>("ReorderScenarios", request);
        }

        /// <summary>
        /// Runs JavaScript scenarios on a VoxImplant server. The scenarios run in a new media session.
        /// </summary>
        public StartScenariosResponse StartScenarios(StartScenariosRequest request)
        {
            return PerformRequest<StartScenariosResponse, StartScenariosRequest>("StartScenarios", request);
        }

        /// <summary>
        /// Runs a session for video conferencing or joins the existing video conference session.<br/><br/>When a session is created by calling this method, a scenario assigned to the specified **rule_id** will run on one of the servers dedicated to video conferencing. All further method calls with the same **rule_id** won't create a new video conference session, but join the already existing one.<br/><br/>Use the [StartScenarios] method for creating audio conferences.
        /// </summary>
        public StartConferenceResponse StartConference(StartConferenceRequest request)
        {
            return PerformRequest<StartConferenceResponse, StartConferenceRequest>("StartConference", request);
        }

        /// <summary>
        /// Adds a new rule for the application.
        /// </summary>
        public AddRuleResponse AddRule(AddRuleRequest request)
        {
            return PerformRequest<AddRuleResponse, AddRuleRequest>("AddRule", request);
        }

        /// <summary>
        /// Deletes the rule.
        /// </summary>
        public DelRuleResponse DelRule(DelRuleRequest request)
        {
            return PerformRequest<DelRuleResponse, DelRuleRequest>("DelRule", request);
        }

        /// <summary>
        /// Edits the rule.
        /// </summary>
        public SetRuleInfoResponse SetRuleInfo(SetRuleInfoRequest request)
        {
            return PerformRequest<SetRuleInfoResponse, SetRuleInfoRequest>("SetRuleInfo", request);
        }

        /// <summary>
        /// Gets the rules.
        /// </summary>
        public GetRulesResponse GetRules(GetRulesRequest request)
        {
            return PerformRequest<GetRulesResponse, GetRulesRequest>("GetRules", request);
        }

        /// <summary>
        /// Configures the rules' order in the <a href='//manage.voximplant.com/#editApplication'>Applications</a> section of Control panel. Note: the rules must belong to the same application!
        /// </summary>
        public ReorderRulesResponse ReorderRules(ReorderRulesRequest request)
        {
            return PerformRequest<ReorderRulesResponse, ReorderRulesRequest>("ReorderRules", request);
        }

        /// <summary>
        /// Gets the call history.
        /// </summary>
        public GetCallHistoryResponse GetCallHistory(GetCallHistoryRequest request)
        {
            return PerformRequest<GetCallHistoryResponse, GetCallHistoryRequest>("GetCallHistory", request);
        }

        /// <summary>
        /// Gets the list of history reports and their statuses. The method returns info about reports made via [GetCallHistory] with the specified __output=csv__ and **is_async=true** parameters.
        /// </summary>
        public GetHistoryReportsResponse GetHistoryReports(GetHistoryReportsRequest request)
        {
            return PerformRequest<GetHistoryReportsResponse, GetHistoryReportsRequest>("GetHistoryReports", request);
        }

        /// <summary>
        /// Gets the transaction history.
        /// </summary>
        public GetTransactionHistoryResponse GetTransactionHistory(GetTransactionHistoryRequest request)
        {
            return PerformRequest<GetTransactionHistoryResponse, GetTransactionHistoryRequest>("GetTransactionHistory", request);
        }

        /// <summary>
        /// Try to remove record and transcription files.
        /// </summary>
        public DeleteRecordResponse DeleteRecord(DeleteRecordRequest request)
        {
            return PerformRequest<DeleteRecordResponse, DeleteRecordRequest>("DeleteRecord", request);
        }

        /// <summary>
        /// Gets the ACD history.
        /// </summary>
        public GetACDHistoryResponse GetACDHistory(GetACDHistoryRequest request)
        {
            return PerformRequest<GetACDHistoryResponse, GetACDHistoryRequest>("GetACDHistory", request);
        }

        /// <summary>
        /// Gets the history of account changes.
        /// </summary>
        public GetAuditLogResponse GetAuditLog(GetAuditLogRequest request)
        {
            return PerformRequest<GetAuditLogResponse, GetAuditLogRequest>("GetAuditLog", request);
        }

        /// <summary>
        /// Add a new phone number to the PSTN blacklist. BlackList works for numbers that are purchased from Voximplant only. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        public AddPstnBlackListItemResponse AddPstnBlackListItem(AddPstnBlackListItemRequest request)
        {
            return PerformRequest<AddPstnBlackListItemResponse, AddPstnBlackListItemRequest>("AddPstnBlackListItem", request);
        }

        /// <summary>
        /// Update the PSTN blacklist item. BlackList works for numbers that are purchased from Voximplant only. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        public SetPstnBlackListItemResponse SetPstnBlackListItem(SetPstnBlackListItemRequest request)
        {
            return PerformRequest<SetPstnBlackListItemResponse, SetPstnBlackListItemRequest>("SetPstnBlackListItem", request);
        }

        /// <summary>
        /// Remove phone number from the PSTN blacklist.
        /// </summary>
        public DelPstnBlackListItemResponse DelPstnBlackListItem(DelPstnBlackListItemRequest request)
        {
            return PerformRequest<DelPstnBlackListItemResponse, DelPstnBlackListItemRequest>("DelPstnBlackListItem", request);
        }

        /// <summary>
        /// Get the whole PSTN blacklist.
        /// </summary>
        public GetPstnBlackListResponse GetPstnBlackList(GetPstnBlackListRequest request)
        {
            return PerformRequest<GetPstnBlackListResponse, GetPstnBlackListRequest>("GetPstnBlackList", request);
        }

        /// <summary>
        /// Adds a new network address to the SIP white list.
        /// </summary>
        public AddSipWhiteListItemResponse AddSipWhiteListItem(AddSipWhiteListItemRequest request)
        {
            return PerformRequest<AddSipWhiteListItemResponse, AddSipWhiteListItemRequest>("AddSipWhiteListItem", request);
        }

        /// <summary>
        /// Deletes the network address from the SIP white list.
        /// </summary>
        public DelSipWhiteListItemResponse DelSipWhiteListItem(DelSipWhiteListItemRequest request)
        {
            return PerformRequest<DelSipWhiteListItemResponse, DelSipWhiteListItemRequest>("DelSipWhiteListItem", request);
        }

        /// <summary>
        /// Edits the SIP white list.
        /// </summary>
        public SetSipWhiteListItemResponse SetSipWhiteListItem(SetSipWhiteListItemRequest request)
        {
            return PerformRequest<SetSipWhiteListItemResponse, SetSipWhiteListItemRequest>("SetSipWhiteListItem", request);
        }

        /// <summary>
        /// Gets the SIP white list.
        /// </summary>
        public GetSipWhiteListResponse GetSipWhiteList(GetSipWhiteListRequest request)
        {
            return PerformRequest<GetSipWhiteListResponse, GetSipWhiteListRequest>("GetSipWhiteList", request);
        }

        /// <summary>
        /// Create a new SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should set is_persistent=true if you specify the user_id or user_name. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public CreateSipRegistrationResponse CreateSipRegistration(CreateSipRegistrationRequest request)
        {
            return PerformRequest<CreateSipRegistrationResponse, CreateSipRegistrationRequest>("CreateSipRegistration", request);
        }

        /// <summary>
        /// Update SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public UpdateSipRegistrationResponse UpdateSipRegistration(UpdateSipRegistrationRequest request)
        {
            return PerformRequest<UpdateSipRegistrationResponse, UpdateSipRegistrationRequest>("UpdateSipRegistration", request);
        }

        /// <summary>
        /// Bind the SIP registration to the application/user or unbind the SIP registration from the application/user. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should specify the sip_registration_id if you set bind=true. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public BindSipRegistrationResponse BindSipRegistration(BindSipRegistrationRequest request)
        {
            return PerformRequest<BindSipRegistrationResponse, BindSipRegistrationRequest>("BindSipRegistration", request);
        }

        /// <summary>
        /// Delete SIP registration.
        /// </summary>
        public DeleteSipRegistrationResponse DeleteSipRegistration(DeleteSipRegistrationRequest request)
        {
            return PerformRequest<DeleteSipRegistrationResponse, DeleteSipRegistrationRequest>("DeleteSipRegistration", request);
        }

        /// <summary>
        /// Get active SIP registrations.
        /// </summary>
        public GetSipRegistrationsResponse GetSipRegistrations(GetSipRegistrationsRequest request)
        {
            return PerformRequest<GetSipRegistrationsResponse, GetSipRegistrationsRequest>("GetSipRegistrations", request);
        }

        /// <summary>
        /// Attach the phone number to the account. Note that phone numbers of some countries may require additional verification steps.
        /// </summary>
        public AttachPhoneNumberResponse AttachPhoneNumber(AttachPhoneNumberRequest request)
        {
            return PerformRequest<AttachPhoneNumberResponse, AttachPhoneNumberRequest>("AttachPhoneNumber", request);
        }

        /// <summary>
        /// Bind the phone number to the application or unbind the phone number from the application. You should specify the application_id or application_name if you specify the rule_name.
        /// </summary>
        public BindPhoneNumberToApplicationResponse BindPhoneNumberToApplication(BindPhoneNumberToApplicationRequest request)
        {
            return PerformRequest<BindPhoneNumberToApplicationResponse, BindPhoneNumberToApplicationRequest>("BindPhoneNumberToApplication", request);
        }

        /// <summary>
        /// Deactivates the phone number.
        /// </summary>
        public DeactivatePhoneNumberResponse DeactivatePhoneNumber(DeactivatePhoneNumberRequest request)
        {
            return PerformRequest<DeactivatePhoneNumberResponse, DeactivatePhoneNumberRequest>("DeactivatePhoneNumber", request);
        }

        /// <summary>
        /// Configure the phone number.
        /// </summary>
        public SetPhoneNumberInfoResponse SetPhoneNumberInfo(SetPhoneNumberInfoRequest request)
        {
            return PerformRequest<SetPhoneNumberInfoResponse, SetPhoneNumberInfoRequest>("SetPhoneNumberInfo", request);
        }

        /// <summary>
        /// Gets the account phone numbers.
        /// </summary>
        public GetPhoneNumbersResponse GetPhoneNumbers(GetPhoneNumbersRequest request)
        {
            return PerformRequest<GetPhoneNumbersResponse, GetPhoneNumbersRequest>("GetPhoneNumbers", request);
        }

        /// <summary>
        /// Gets the new phone numbers.
        /// </summary>
        public GetNewPhoneNumbersResponse GetNewPhoneNumbers(GetNewPhoneNumbersRequest request)
        {
            return PerformRequest<GetNewPhoneNumbersResponse, GetNewPhoneNumbersRequest>("GetNewPhoneNumbers", request);
        }

        /// <summary>
        /// Gets the phone number categories.
        /// </summary>
        public GetPhoneNumberCategoriesResponse GetPhoneNumberCategories(GetPhoneNumberCategoriesRequest request)
        {
            return PerformRequest<GetPhoneNumberCategoriesResponse, GetPhoneNumberCategoriesRequest>("GetPhoneNumberCategories", request);
        }

        /// <summary>
        /// Gets the phone number country states.
        /// </summary>
        public GetPhoneNumberCountryStatesResponse GetPhoneNumberCountryStates(GetPhoneNumberCountryStatesRequest request)
        {
            return PerformRequest<GetPhoneNumberCountryStatesResponse, GetPhoneNumberCountryStatesRequest>("GetPhoneNumberCountryStates", request);
        }

        /// <summary>
        /// Get the country regions of the phone numbers. The response will also contain the info about multiple numbers subscription for the child accounts.
        /// </summary>
        public GetPhoneNumberRegionsResponse GetPhoneNumberRegions(GetPhoneNumberRegionsRequest request)
        {
            return PerformRequest<GetPhoneNumberRegionsResponse, GetPhoneNumberRegionsRequest>("GetPhoneNumberRegions", request);
        }

        /// <summary>
        /// Get actual info the country region of the phone numbers. The response will also contain the info about multiple numbers subscription for the child accounts.
        /// </summary>
        public GetActualPhoneNumberRegionResponse GetActualPhoneNumberRegion(GetActualPhoneNumberRegionRequest request)
        {
            return PerformRequest<GetActualPhoneNumberRegionResponse, GetActualPhoneNumberRegionRequest>("GetActualPhoneNumberRegion", request);
        }

        /// <summary>
        /// Adds a new caller ID. Caller ID is the phone that will be displayed to the called user. This number can be used for call back.
        /// </summary>
        public AddCallerIDResponse AddCallerID(AddCallerIDRequest request)
        {
            return PerformRequest<AddCallerIDResponse, AddCallerIDRequest>("AddCallerID", request);
        }

        /// <summary>
        /// Activates the CallerID by the verification code.
        /// </summary>
        public ActivateCallerIDResponse ActivateCallerID(ActivateCallerIDRequest request)
        {
            return PerformRequest<ActivateCallerIDResponse, ActivateCallerIDRequest>("ActivateCallerID", request);
        }

        /// <summary>
        /// Deletes the CallerID. Note: you can't delete a CID permanently (the antispam defence).
        /// </summary>
        public DelCallerIDResponse DelCallerID(DelCallerIDRequest request)
        {
            return PerformRequest<DelCallerIDResponse, DelCallerIDRequest>("DelCallerID", request);
        }

        /// <summary>
        /// Gets the account callerIDs.
        /// </summary>
        public GetCallerIDsResponse GetCallerIDs(GetCallerIDsRequest request)
        {
            return PerformRequest<GetCallerIDsResponse, GetCallerIDsRequest>("GetCallerIDs", request);
        }

        /// <summary>
        /// Gets a verification code by make call to the callerID number.
        /// </summary>
        public VerifyCallerIDResponse VerifyCallerID(VerifyCallerIDRequest request)
        {
            return PerformRequest<VerifyCallerIDResponse, VerifyCallerIDRequest>("VerifyCallerID", request);
        }

        /// <summary>
        /// Adds a new ACD queue.
        /// </summary>
        public AddQueueResponse AddQueue(AddQueueRequest request)
        {
            return PerformRequest<AddQueueResponse, AddQueueRequest>("AddQueue", request);
        }

        /// <summary>
        /// Bind/unbind users to/from the specified ACD queues. Note that users and queues should be already bound to the same application.
        /// </summary>
        public BindUserToQueueResponse BindUserToQueue(BindUserToQueueRequest request)
        {
            return PerformRequest<BindUserToQueueResponse, BindUserToQueueRequest>("BindUserToQueue", request);
        }

        /// <summary>
        /// Deletes the ACD queue.
        /// </summary>
        public DelQueueResponse DelQueue(DelQueueRequest request)
        {
            return PerformRequest<DelQueueResponse, DelQueueRequest>("DelQueue", request);
        }

        /// <summary>
        /// Edits the ACD queue.
        /// </summary>
        public SetQueueInfoResponse SetQueueInfo(SetQueueInfoRequest request)
        {
            return PerformRequest<SetQueueInfoResponse, SetQueueInfoRequest>("SetQueueInfo", request);
        }

        /// <summary>
        /// Gets the ACD queues.
        /// </summary>
        public GetQueuesResponse GetQueues(GetQueuesRequest request)
        {
            return PerformRequest<GetQueuesResponse, GetQueuesRequest>("GetQueues", request);
        }

        /// <summary>
        /// Gets the current ACD queue state.
        /// </summary>
        public GetACDStateResponse GetACDState(GetACDStateRequest request)
        {
            return PerformRequest<GetACDStateResponse, GetACDStateRequest>("GetACDState", request);
        }

        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'ACD' module. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        public GetACDOperatorStatisticsResponse GetACDOperatorStatistics(GetACDOperatorStatisticsRequest request)
        {
            return PerformRequest<GetACDOperatorStatisticsResponse, GetACDOperatorStatisticsRequest>("GetACDOperatorStatistics", request);
        }

        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'queue' distribution system. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        public GetACDQueueStatisticsResponse GetACDQueueStatistics(GetACDQueueStatisticsRequest request)
        {
            return PerformRequest<GetACDQueueStatisticsResponse, GetACDQueueStatisticsRequest>("GetACDQueueStatistics", request);
        }

        /// <summary>
        /// Get statistics for the specified operators and ACD statuses. This method can filter statistics by operator ids and statuses. It can also group results by day/hour or users.
        /// </summary>
        public GetACDOperatorStatusStatisticsResponse GetACDOperatorStatusStatistics(GetACDOperatorStatusStatisticsRequest request)
        {
            return PerformRequest<GetACDOperatorStatusStatisticsResponse, GetACDOperatorStatusStatisticsRequest>("GetACDOperatorStatusStatistics", request);
        }

        /// <summary>
        /// Adds a new ACD operator skill.
        /// </summary>
        public AddSkillResponse AddSkill(AddSkillRequest request)
        {
            return PerformRequest<AddSkillResponse, AddSkillRequest>("AddSkill", request);
        }

        /// <summary>
        /// Deletes the skill.
        /// </summary>
        public DelSkillResponse DelSkill(DelSkillRequest request)
        {
            return PerformRequest<DelSkillResponse, DelSkillRequest>("DelSkill", request);
        }

        /// <summary>
        /// Edits the skill.
        /// </summary>
        public SetSkillInfoResponse SetSkillInfo(SetSkillInfoRequest request)
        {
            return PerformRequest<SetSkillInfoResponse, SetSkillInfoRequest>("SetSkillInfo", request);
        }

        /// <summary>
        /// Gets the skills.
        /// </summary>
        public GetSkillsResponse GetSkills(GetSkillsRequest request)
        {
            return PerformRequest<GetSkillsResponse, GetSkillsRequest>("GetSkills", request);
        }

        /// <summary>
        /// Binds the specified skills to the users (ACD operators) and/or the ACD queues.
        /// </summary>
        public BindSkillResponse BindSkill(BindSkillRequest request)
        {
            return PerformRequest<BindSkillResponse, BindSkillRequest>("BindSkill", request);
        }

        /// <summary>
        /// Gets the account documents and the verification states.
        /// </summary>
        public GetAccountDocumentsResponse GetAccountDocuments(GetAccountDocumentsRequest request)
        {
            return PerformRequest<GetAccountDocumentsResponse, GetAccountDocumentsRequest>("GetAccountDocuments", request);
        }

        /// <summary>
        /// Adds a new admin user into the specified parent or child account.
        /// </summary>
        public AddAdminUserResponse AddAdminUser(AddAdminUserRequest request)
        {
            return PerformRequest<AddAdminUserResponse, AddAdminUserRequest>("AddAdminUser", request);
        }

        /// <summary>
        /// Deletes the specified admin user.
        /// </summary>
        public DelAdminUserResponse DelAdminUser(DelAdminUserRequest request)
        {
            return PerformRequest<DelAdminUserResponse, DelAdminUserRequest>("DelAdminUser", request);
        }

        /// <summary>
        /// Edits the specified admin user.
        /// </summary>
        public SetAdminUserInfoResponse SetAdminUserInfo(SetAdminUserInfoRequest request)
        {
            return PerformRequest<SetAdminUserInfoResponse, SetAdminUserInfoRequest>("SetAdminUserInfo", request);
        }

        /// <summary>
        /// Gets the admin users of the specified account. Note that both account types - parent and child - could have its own admins.
        /// </summary>
        public GetAdminUsersResponse GetAdminUsers(GetAdminUsersRequest request)
        {
            return PerformRequest<GetAdminUsersResponse, GetAdminUsersRequest>("GetAdminUsers", request);
        }

        /// <summary>
        /// Adds a new admin role.
        /// </summary>
        public AddAdminRoleResponse AddAdminRole(AddAdminRoleRequest request)
        {
            return PerformRequest<AddAdminRoleResponse, AddAdminRoleRequest>("AddAdminRole", request);
        }

        /// <summary>
        /// Deletes the specified admin role.
        /// </summary>
        public DelAdminRoleResponse DelAdminRole(DelAdminRoleRequest request)
        {
            return PerformRequest<DelAdminRoleResponse, DelAdminRoleRequest>("DelAdminRole", request);
        }

        /// <summary>
        /// Edits the specified admin role.
        /// </summary>
        public SetAdminRoleInfoResponse SetAdminRoleInfo(SetAdminRoleInfoRequest request)
        {
            return PerformRequest<SetAdminRoleInfoResponse, SetAdminRoleInfoRequest>("SetAdminRoleInfo", request);
        }

        /// <summary>
        /// Gets the admin roles.
        /// </summary>
        public GetAdminRolesResponse GetAdminRoles(GetAdminRolesRequest request)
        {
            return PerformRequest<GetAdminRolesResponse, GetAdminRolesRequest>("GetAdminRoles", request);
        }

        /// <summary>
        /// Attaches the admin role(s) to the already existing admin(s).
        /// </summary>
        public AttachAdminRoleResponse AttachAdminRole(AttachAdminRoleRequest request)
        {
            return PerformRequest<AttachAdminRoleResponse, AttachAdminRoleRequest>("AttachAdminRole", request);
        }

        /// <summary>
        /// Gets the all available admin role entries.
        /// </summary>
        public GetAvailableAdminRoleEntriesResponse GetAvailableAdminRoleEntries(GetAvailableAdminRoleEntriesRequest request)
        {
            return PerformRequest<GetAvailableAdminRoleEntriesResponse, GetAvailableAdminRoleEntriesRequest>("GetAvailableAdminRoleEntries", request);
        }

        /// <summary>
        /// Adds a new authorized IP4 or network to the white/black list.
        /// </summary>
        public AddAuthorizedAccountIPResponse AddAuthorizedAccountIP(AddAuthorizedAccountIPRequest request)
        {
            return PerformRequest<AddAuthorizedAccountIPResponse, AddAuthorizedAccountIPRequest>("AddAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Removes the authorized IP4 or network from the white/black list.
        /// </summary>
        public DelAuthorizedAccountIPResponse DelAuthorizedAccountIP(DelAuthorizedAccountIPRequest request)
        {
            return PerformRequest<DelAuthorizedAccountIPResponse, DelAuthorizedAccountIPRequest>("DelAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Gets the authorized IP4 or network.
        /// </summary>
        public GetAuthorizedAccountIPsResponse GetAuthorizedAccountIPs(GetAuthorizedAccountIPsRequest request)
        {
            return PerformRequest<GetAuthorizedAccountIPsResponse, GetAuthorizedAccountIPsRequest>("GetAuthorizedAccountIPs", request);
        }

        /// <summary>
        /// Tests whether the IP4 is banned or allowed.
        /// </summary>
        public CheckAuthorizedAccountIPResponse CheckAuthorizedAccountIP(CheckAuthorizedAccountIPRequest request)
        {
            return PerformRequest<CheckAuthorizedAccountIPResponse, CheckAuthorizedAccountIPRequest>("CheckAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Link regulation address to phone
        /// </summary>
        public LinkregulationAddressResponse LinkregulationAddress(LinkregulationAddressRequest request)
        {
            return PerformRequest<LinkregulationAddressResponse, LinkregulationAddressRequest>("LinkregulationAddress", request);
        }

        /// <summary>
        /// Search available zip codes
        /// </summary>
        public GetZIPCodesResponse GetZIPCodes(GetZIPCodesRequest request)
        {
            return PerformRequest<GetZIPCodesResponse, GetZIPCodesRequest>("GetZIPCodes", request);
        }

        /// <summary>
        /// Search user's regulation address
        /// </summary>
        public GetRegulationsAddressResponse GetRegulationsAddress(GetRegulationsAddressRequest request)
        {
            return PerformRequest<GetRegulationsAddressResponse, GetRegulationsAddressRequest>("GetRegulationsAddress", request);
        }

        /// <summary>
        /// Search available regulation for link
        /// </summary>
        public GetAvailableRegulationsResponse GetAvailableRegulations(GetAvailableRegulationsRequest request)
        {
            return PerformRequest<GetAvailableRegulationsResponse, GetAvailableRegulationsRequest>("GetAvailableRegulations", request);
        }

        /// <summary>
        /// Get all countries
        /// </summary>
        public GetCountriesResponse GetCountries(GetCountriesRequest request)
        {
            return PerformRequest<GetCountriesResponse, GetCountriesRequest>("GetCountries", request);
        }

        /// <summary>
        /// Get available regions in country
        /// </summary>
        public GetRegionsResponse GetRegions(GetRegionsRequest request)
        {
            return PerformRequest<GetRegionsResponse, GetRegionsRequest>("GetRegions", request);
        }

        /// <summary>
        /// Add push credentials
        /// </summary>
        public AddPushCredentialResponse AddPushCredential(AddPushCredentialRequest request)
        {
            return PerformRequest<AddPushCredentialResponse, AddPushCredentialRequest>("AddPushCredential", request);
        }

        /// <summary>
        /// Modify push credentials
        /// </summary>
        public SetPushCredentialResponse SetPushCredential(SetPushCredentialRequest request)
        {
            return PerformRequest<SetPushCredentialResponse, SetPushCredentialRequest>("SetPushCredential", request);
        }

        /// <summary>
        /// Remove push credentials
        /// </summary>
        public DelPushCredentialResponse DelPushCredential(DelPushCredentialRequest request)
        {
            return PerformRequest<DelPushCredentialResponse, DelPushCredentialRequest>("DelPushCredential", request);
        }

        /// <summary>
        /// Get push credentials
        /// </summary>
        public GetPushCredentialResponse GetPushCredential(GetPushCredentialRequest request)
        {
            return PerformRequest<GetPushCredentialResponse, GetPushCredentialRequest>("GetPushCredential", request);
        }

        /// <summary>
        /// Bind push credentials to applications
        /// </summary>
        public BindPushCredentialResponse BindPushCredential(BindPushCredentialRequest request)
        {
            return PerformRequest<BindPushCredentialResponse, BindPushCredentialRequest>("BindPushCredential", request);
        }

        /// <summary>
        /// Add Dialogflow key
        /// </summary>
        public AddDialogflowKeyResponse AddDialogflowKey(AddDialogflowKeyRequest request)
        {
            return PerformRequest<AddDialogflowKeyResponse, AddDialogflowKeyRequest>("AddDialogflowKey", request);
        }

        /// <summary>
        /// Edit Dialogflow key
        /// </summary>
        public SetDialogflowKeyResponse SetDialogflowKey(SetDialogflowKeyRequest request)
        {
            return PerformRequest<SetDialogflowKeyResponse, SetDialogflowKeyRequest>("SetDialogflowKey", request);
        }

        /// <summary>
        /// Remove Dialogflow key
        /// </summary>
        public DelDialogflowKeyResponse DelDialogflowKey(DelDialogflowKeyRequest request)
        {
            return PerformRequest<DelDialogflowKeyResponse, DelDialogflowKeyRequest>("DelDialogflowKey", request);
        }

        /// <summary>
        /// Get Dialogflow keys
        /// </summary>
        public GetDialogflowKeysResponse GetDialogflowKeys(GetDialogflowKeysRequest request)
        {
            return PerformRequest<GetDialogflowKeysResponse, GetDialogflowKeysRequest>("GetDialogflowKeys", request);
        }

        /// <summary>
        /// Bind a Dialogflow key to the specified applications
        /// </summary>
        public BindDialogflowKeysResponse BindDialogflowKeys(BindDialogflowKeysRequest request)
        {
            return PerformRequest<BindDialogflowKeysResponse, BindDialogflowKeysRequest>("BindDialogflowKeys", request);
        }

        /// <summary>
        /// Send SMS message between two phone numbers. The source phone number should be purchased from Voximplant and support SMS (which is indicated by the <b>is_sms_supported</b> property in the objects returned by the <a href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbers'>/GetPhoneNumbers</a> HTTP API) and SMS should be enabled for it via the <a href='//voximplant.com/docs/references/httpapi/managing_sms#controlsms'>/ControlSms</a> HTTP API. SMS messages can be received via HTTP callbacks, see <a href='//voximplant.com/blog/http-api-callbacks'>this article</a> for details.
        /// </summary>
        public SendSmsMessageResponse SendSmsMessage(SendSmsMessageRequest request)
        {
            return PerformRequest<SendSmsMessageResponse, SendSmsMessageRequest>("SendSmsMessage", request);
        }

        /// <summary>
        /// Enable or disable SMS sending and receiving for the phone number. Can be used only for phone numbers with SMS support, which is indicated by the <b>is_sms_supported</b> property in the objects returned by the <a href='//voximplant.com/docs/references/httpapi/managing_phone_numbers#getphonenumbers'>/GetPhoneNumbers</a> HTTP API. Each inbound SMS message is billed according to the <a href='//voximplant.com/pricing'>pricing</a>. If enabled, SMS can be sent from this phone number using the <a href='//voximplant.com/docs/references/httpapi/managing_sms#sendsmsmessage'>/SendSmsMessage</a> HTTP API and received using the [InboundSmsCallback] property of the HTTP callback. See <a href='//voximplant.com/blog/http-api-callbacks'>this article</a> for HTTP callback details.
        /// </summary>
        public ControlSmsResponse ControlSms(ControlSmsRequest request)
        {
            return PerformRequest<ControlSmsResponse, ControlSmsRequest>("ControlSms", request);
        }

        /// <summary>
        /// Get the record storages.
        /// </summary>
        public GetRecordStoragesResponse GetRecordStorages(GetRecordStoragesRequest request)
        {
            return PerformRequest<GetRecordStoragesResponse, GetRecordStoragesRequest>("GetRecordStorages", request);
        }

        /// <summary>
        /// Creates a public/private key pair. You can optionally specify one or more roles for the key, see [this article](https://voximplant.com/blog/service-accounts-introduction) for details.
        /// </summary>
        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            return PerformRequest<CreateKeyResponse, CreateKeyRequest>("CreateKey", request);
        }

        /// <summary>
        /// Gets key info of the specified account.
        /// </summary>
        public GetKeysResponse GetKeys(GetKeysRequest request)
        {
            return PerformRequest<GetKeysResponse, GetKeysRequest>("GetKeys", request);
        }

        /// <summary>
        /// Updates info of the specified key.
        /// </summary>
        public UpdateKeyResponse UpdateKey(UpdateKeyRequest request)
        {
            return PerformRequest<UpdateKeyResponse, UpdateKeyRequest>("UpdateKey", request);
        }

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        public DeleteKeyResponse DeleteKey(DeleteKeyRequest request)
        {
            return PerformRequest<DeleteKeyResponse, DeleteKeyRequest>("DeleteKey", request);
        }

        /// <summary>
        /// Set roles for the specified key.
        /// </summary>
        public SetKeyRolesResponse SetKeyRoles(SetKeyRolesRequest request)
        {
            return PerformRequest<SetKeyRolesResponse, SetKeyRolesRequest>("SetKeyRoles", request);
        }

        /// <summary>
        /// Gets roles of the specified key.
        /// </summary>
        public GetKeyRolesResponse GetKeyRoles(GetKeyRolesRequest request)
        {
            return PerformRequest<GetKeyRolesResponse, GetKeyRolesRequest>("GetKeyRoles", request);
        }

        /// <summary>
        /// Removes the specified roles of a key.
        /// </summary>
        public RemoveKeyRolesResponse RemoveKeyRoles(RemoveKeyRolesRequest request)
        {
            return PerformRequest<RemoveKeyRolesResponse, RemoveKeyRolesRequest>("RemoveKeyRoles", request);
        }

        /// <summary>
        /// Creates a subuser.
        /// </summary>
        public AddSubUserResponse AddSubUser(AddSubUserRequest request)
        {
            return PerformRequest<AddSubUserResponse, AddSubUserRequest>("AddSubUser", request);
        }

        /// <summary>
        /// Gets subusers.
        /// </summary>
        public GetSubUsersResponse GetSubUsers(GetSubUsersRequest request)
        {
            return PerformRequest<GetSubUsersResponse, GetSubUsersRequest>("GetSubUsers", request);
        }

        /// <summary>
        /// Edits a subuser.
        /// </summary>
        public SetSubUserInfoResponse SetSubUserInfo(SetSubUserInfoRequest request)
        {
            return PerformRequest<SetSubUserInfoResponse, SetSubUserInfoRequest>("SetSubUserInfo", request);
        }

        /// <summary>
        /// Deletes a subuser.
        /// </summary>
        public DelSubUserResponse DelSubUser(DelSubUserRequest request)
        {
            return PerformRequest<DelSubUserResponse, DelSubUserRequest>("DelSubUser", request);
        }

        /// <summary>
        /// Adds the specified roles for a subuser.
        /// </summary>
        public SetSubUserRolesResponse SetSubUserRoles(SetSubUserRolesRequest request)
        {
            return PerformRequest<SetSubUserRolesResponse, SetSubUserRolesRequest>("SetSubUserRoles", request);
        }

        /// <summary>
        /// Gets the subuser's roles.
        /// </summary>
        public GetSubUserRolesResponse GetSubUserRoles(GetSubUserRolesRequest request)
        {
            return PerformRequest<GetSubUserRolesResponse, GetSubUserRolesRequest>("GetSubUserRoles", request);
        }

        /// <summary>
        /// Removes the specified roles of a subuser.
        /// </summary>
        public RemoveSubUserRolesResponse RemoveSubUserRoles(RemoveSubUserRolesRequest request)
        {
            return PerformRequest<RemoveSubUserRolesResponse, RemoveSubUserRolesRequest>("RemoveSubUserRoles", request);
        }

        /// <summary>
        /// Gets all roles.
        /// </summary>
        public GetRolesResponse GetRoles(GetRolesRequest request)
        {
            return PerformRequest<GetRolesResponse, GetRolesRequest>("GetRoles", request);
        }

        /// <summary>
        /// Gets role groups
        /// </summary>
        public GetRoleGroupsResponse GetRoleGroups(GetRoleGroupsRequest request)
        {
            return PerformRequest<GetRoleGroupsResponse, GetRoleGroupsRequest>("GetRoleGroups", request);
        }

        /// <summary>
        /// Adds a new subscription for the specified child account.
        /// </summary>
        public AddChildAccountSubscriptionResponse AddChildAccountSubscription(AddChildAccountSubscriptionRequest request)
        {
            return PerformRequest<AddChildAccountSubscriptionResponse, AddChildAccountSubscriptionRequest>("AddChildAccountSubscription", request);
        }

        /// <summary>
        /// Gets the active subscription(s) for the specified child account.
        /// </summary>
        public GetChildAccountSubscriptionsResponse GetChildAccountSubscriptions(GetChildAccountSubscriptionsRequest request)
        {
            return PerformRequest<GetChildAccountSubscriptionsResponse, GetChildAccountSubscriptionsRequest>("GetChildAccountSubscriptions", request);
        }

        /// <summary>
        /// Gets all the eligible subscription templates. A template is considered to be eligible if it is of a type that supports child accounts management.
        /// </summary>
        public GetChildAccountSubscriptionTemplatesResponse GetChildAccountSubscriptionTemplates(GetChildAccountSubscriptionTemplatesRequest request)
        {
            return PerformRequest<GetChildAccountSubscriptionTemplatesResponse, GetChildAccountSubscriptionTemplatesRequest>("GetChildAccountSubscriptionTemplates", request);
        }

        /// <summary>
        /// Deactivates the specified subscription(s).
        /// </summary>
        public DeactivateChildAccountSubscriptionResponse DeactivateChildAccountSubscription(DeactivateChildAccountSubscriptionRequest request)
        {
            return PerformRequest<DeactivateChildAccountSubscriptionResponse, DeactivateChildAccountSubscriptionRequest>("DeactivateChildAccountSubscription", request);
        }

        /// <summary>
        /// Get history of sent and/or received SMS.
        /// </summary>
        public GetSmsHistoryResponse GetSmsHistory(GetSmsHistoryRequest request)
        {
            return PerformRequest<GetSmsHistoryResponse, GetSmsHistoryRequest>("GetSmsHistory", request);
        }

    }
}