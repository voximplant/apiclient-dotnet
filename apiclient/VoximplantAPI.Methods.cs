using System.Threading.Tasks;
using Voximplant.API.Request;
using Voximplant.API.Response;

namespace Voximplant.API {

    public partial class VoximplantAPI
    { 
        /// <summary>
        /// Gets the account's info such as account_id, account_name, account_email etc.
        /// </summary>
        public async Task<GetAccountInfoResponse> GetAccountInfo(GetAccountInfoRequest request)
        {
            return await PerformRequest<GetAccountInfoResponse, GetAccountInfoRequest>("GetAccountInfo", request);
        }

        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        public async Task<SetAccountInfoResponse> SetAccountInfo(SetAccountInfoRequest request)
        {
            return await PerformRequest<SetAccountInfoResponse, SetAccountInfoRequest>("SetAccountInfo", request);
        }

        /// <summary>
        /// Edits the account's profile.
        /// </summary>
        public async Task<SetChildAccountInfoResponse> SetChildAccountInfo(SetChildAccountInfoRequest request)
        {
            return await PerformRequest<SetChildAccountInfoResponse, SetChildAccountInfoRequest>("SetChildAccountInfo", request);
        }

        /// <summary>
        /// Gets the exchange rate on selected date (per USD).
        /// </summary>
        public async Task<GetCurrencyRateResponse> GetCurrencyRate(GetCurrencyRateRequest request)
        {
            return await PerformRequest<GetCurrencyRateResponse, GetCurrencyRateRequest>("GetCurrencyRate", request);
        }

        /// <summary>
        /// Gets the resource price.
        /// </summary>
        public async Task<GetResourcePriceResponse> GetResourcePrice(GetResourcePriceRequest request)
        {
            return await PerformRequest<GetResourcePriceResponse, GetResourcePriceRequest>("GetResourcePrice", request);
        }

        /// <summary>
        /// Gets the subscription template price.
        /// </summary>
        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPrice(GetSubscriptionPriceRequest request)
        {
            return await PerformRequest<GetSubscriptionPriceResponse, GetSubscriptionPriceRequest>("GetSubscriptionPrice", request);
        }

        /// <summary>
        /// Gets the info about all children accounts.
        /// </summary>
        public async Task<GetChildrenAccountsResponse> GetChildrenAccounts(GetChildrenAccountsRequest request)
        {
            return await PerformRequest<GetChildrenAccountsResponse, GetChildrenAccountsRequest>("GetChildrenAccounts", request);
        }

        /// <summary>
        /// Transfer the parent account's money to the child account or transfer the child's money to the parent account if the money amount is negative.
        /// </summary>
        public async Task<TransferMoneyToChildAccountResponse> TransferMoneyToChildAccount(TransferMoneyToChildAccountRequest request)
        {
            return await PerformRequest<TransferMoneyToChildAccountResponse, TransferMoneyToChildAccountRequest>("TransferMoneyToChildAccount", request);
        }

        /// <summary>
        /// Get the recommended money amount to charge.
        /// </summary>
        public async Task<GetMoneyAmountToChargeResponse> GetMoneyAmountToCharge(GetMoneyAmountToChargeRequest request)
        {
            return await PerformRequest<GetMoneyAmountToChargeResponse, GetMoneyAmountToChargeRequest>("GetMoneyAmountToCharge", request);
        }

        /// <summary>
        /// Charges the account in the manual mode. You should call the ChargeAccount function to charge the subscriptions having the auto_charge=false.
        /// </summary>
        public async Task<ChargeAccountResponse> ChargeAccount(ChargeAccountRequest request)
        {
            return await PerformRequest<ChargeAccountResponse, ChargeAccountRequest>("ChargeAccount", request);
        }

        /// <summary>
        /// Adds a new account's application.
        /// </summary>
        public async Task<AddApplicationResponse> AddApplication(AddApplicationRequest request)
        {
            return await PerformRequest<AddApplicationResponse, AddApplicationRequest>("AddApplication", request);
        }

        /// <summary>
        /// Deletes the account's application.
        /// </summary>
        public async Task<DelApplicationResponse> DelApplication(DelApplicationRequest request)
        {
            return await PerformRequest<DelApplicationResponse, DelApplicationRequest>("DelApplication", request);
        }

        /// <summary>
        /// Edits the account's application.
        /// </summary>
        public async Task<SetApplicationInfoResponse> SetApplicationInfo(SetApplicationInfoRequest request)
        {
            return await PerformRequest<SetApplicationInfoResponse, SetApplicationInfoRequest>("SetApplicationInfo", request);
        }

        /// <summary>
        /// Gets the account's applications.
        /// </summary>
        public async Task<GetApplicationsResponse> GetApplications(GetApplicationsRequest request)
        {
            return await PerformRequest<GetApplicationsResponse, GetApplicationsRequest>("GetApplications", request);
        }

        /// <summary>
        /// Adds a new user.
        /// </summary>
        public async Task<AddUserResponse> AddUser(AddUserRequest request)
        {
            return await PerformRequest<AddUserResponse, AddUserRequest>("AddUser", request);
        }

        /// <summary>
        /// Deletes the specified user(s).
        /// </summary>
        public async Task<DelUserResponse> DelUser(DelUserRequest request)
        {
            return await PerformRequest<DelUserResponse, DelUserRequest>("DelUser", request);
        }

        /// <summary>
        /// Edits the user.
        /// </summary>
        public async Task<SetUserInfoResponse> SetUserInfo(SetUserInfoRequest request)
        {
            return await PerformRequest<SetUserInfoResponse, SetUserInfoRequest>("SetUserInfo", request);
        }

        /// <summary>
        /// Shows the users of the specified account.
        /// </summary>
        public async Task<GetUsersResponse> GetUsers(GetUsersRequest request)
        {
            return await PerformRequest<GetUsersResponse, GetUsersRequest>("GetUsers", request);
        }

        /// <summary>
        /// Transfer the account's money to the user or transfer the user's money to the account if the money amount is negative.
        /// </summary>
        public async Task<TransferMoneyToUserResponse> TransferMoneyToUser(TransferMoneyToUserRequest request)
        {
            return await PerformRequest<TransferMoneyToUserResponse, TransferMoneyToUserRequest>("TransferMoneyToUser", request);
        }

        /// <summary>
        /// Adds a new CSV file for manual call list processing and bind it with the specified rule. To send a file, use the request body. To start processing calls, use the function [StartNextCallTask]. <b>IMPORTANT:</b> the account's balance should be equal or greater than 1 USD. If the balance is lower than 1 USD, the call list processing won't start, or it stops immediately if it was active.
        /// </summary>
        public async Task<CreateManualCallListResponse> CreateManualCallList(CreateManualCallListRequest request)
        {
            return await PerformRequest<CreateManualCallListResponse, CreateManualCallListRequest>("CreateManualCallList", request);
        }

        /// <summary>
        /// Start processing the next task.
        /// </summary>
        public async Task<StartNextCallTaskResponse> StartNextCallTask(StartNextCallTaskRequest request)
        {
            return await PerformRequest<StartNextCallTaskResponse, StartNextCallTaskRequest>("StartNextCallTask", request);
        }

        /// <summary>
        /// Get all call lists for the specified user.
        /// </summary>
        public async Task<GetCallListsResponse> GetCallLists(GetCallListsRequest request)
        {
            return await PerformRequest<GetCallListsResponse, GetCallListsRequest>("GetCallLists", request);
        }

        /// <summary>
        /// Get details of the specified call list. Returns a CSV file by default.
        /// </summary>
        public async Task<GetCallListDetailsResponse> GetCallListDetails(GetCallListDetailsRequest request)
        {
            return await PerformRequest<GetCallListDetailsResponse, GetCallListDetailsRequest>("GetCallListDetails", request);
        }

        /// <summary>
        /// Stop processing the specified call list.
        /// </summary>
        public async Task<StopCallListProcessingResponse> StopCallListProcessing(StopCallListProcessingRequest request)
        {
            return await PerformRequest<StopCallListProcessingResponse, StopCallListProcessingRequest>("StopCallListProcessing", request);
        }

        /// <summary>
        /// Resume processing the specified call list.
        /// </summary>
        public async Task<RecoverCallListResponse> RecoverCallList(RecoverCallListRequest request)
        {
            return await PerformRequest<RecoverCallListResponse, RecoverCallListRequest>("RecoverCallList", request);
        }

        /// <summary>
        /// Adds a new scenario. Please use the POST method.
        /// </summary>
        public async Task<AddScenarioResponse> AddScenario(AddScenarioRequest request)
        {
            return await PerformRequest<AddScenarioResponse, AddScenarioRequest>("AddScenario", request);
        }

        /// <summary>
        /// Deletes the scenario.
        /// </summary>
        public async Task<DelScenarioResponse> DelScenario(DelScenarioRequest request)
        {
            return await PerformRequest<DelScenarioResponse, DelScenarioRequest>("DelScenario", request);
        }

        /// <summary>
        /// Bind the scenario list to the rule. You should specify the application_id or application_name if you specify the rule_name.
        /// </summary>
        public async Task<BindScenarioResponse> BindScenario(BindScenarioRequest request)
        {
            return await PerformRequest<BindScenarioResponse, BindScenarioRequest>("BindScenario", request);
        }

        /// <summary>
        /// Gets the account's scenarios.
        /// </summary>
        public async Task<GetScenariosResponse> GetScenarios(GetScenariosRequest request)
        {
            return await PerformRequest<GetScenariosResponse, GetScenariosRequest>("GetScenarios", request);
        }

        /// <summary>
        /// Edits the scenario. Please use the POST method.
        /// </summary>
        public async Task<SetScenarioInfoResponse> SetScenarioInfo(SetScenarioInfoRequest request)
        {
            return await PerformRequest<SetScenarioInfoResponse, SetScenarioInfoRequest>("SetScenarioInfo", request);
        }

        /// <summary>
        /// Configures the order of scenarios that are assigned to the specified rule.
        /// </summary>
        public async Task<ReorderScenariosResponse> ReorderScenarios(ReorderScenariosRequest request)
        {
            return await PerformRequest<ReorderScenariosResponse, ReorderScenariosRequest>("ReorderScenarios", request);
        }

        /// <summary>
        /// Runs JavaScript scenarios on a Voximplant server. The scenarios run in a new media session.
        /// </summary>
        public async Task<StartScenariosResponse> StartScenarios(StartScenariosRequest request)
        {
            return await PerformRequest<StartScenariosResponse, StartScenariosRequest>("StartScenarios", request);
        }

        /// <summary>
        /// Runs a session for video conferencing or joins the existing video conference session.<br/><br/>When a session is created by calling this method, a scenario assigned to the specified **rule_id** will run on one of the servers dedicated to video conferencing. All further method calls with the same **rule_id** won't create a new video conference session, but join the already existing one.<br/><br/>Use the [StartScenarios] method for creating audio conferences.
        /// </summary>
        public async Task<StartConferenceResponse> StartConference(StartConferenceRequest request)
        {
            return await PerformRequest<StartConferenceResponse, StartConferenceRequest>("StartConference", request);
        }

        /// <summary>
        /// Adds a new rule for the application.
        /// </summary>
        public async Task<AddRuleResponse> AddRule(AddRuleRequest request)
        {
            return await PerformRequest<AddRuleResponse, AddRuleRequest>("AddRule", request);
        }

        /// <summary>
        /// Deletes the rule.
        /// </summary>
        public async Task<DelRuleResponse> DelRule(DelRuleRequest request)
        {
            return await PerformRequest<DelRuleResponse, DelRuleRequest>("DelRule", request);
        }

        /// <summary>
        /// Edits the rule.
        /// </summary>
        public async Task<SetRuleInfoResponse> SetRuleInfo(SetRuleInfoRequest request)
        {
            return await PerformRequest<SetRuleInfoResponse, SetRuleInfoRequest>("SetRuleInfo", request);
        }

        /// <summary>
        /// Gets the rules.
        /// </summary>
        public async Task<GetRulesResponse> GetRules(GetRulesRequest request)
        {
            return await PerformRequest<GetRulesResponse, GetRulesRequest>("GetRules", request);
        }

        /// <summary>
        /// Configures the rules' order in the <a href='//manage.voximplant.com/applications'>Applications</a> section of Control panel. Note: the rules must belong to the same application!
        /// </summary>
        public async Task<ReorderRulesResponse> ReorderRules(ReorderRulesRequest request)
        {
            return await PerformRequest<ReorderRulesResponse, ReorderRulesRequest>("ReorderRules", request);
        }

        /// <summary>
        /// Gets the call history.
        /// </summary>
        public async Task<GetCallHistoryResponse> GetCallHistory(GetCallHistoryRequest request)
        {
            return await PerformRequest<GetCallHistoryResponse, GetCallHistoryRequest>("GetCallHistory", request);
        }

        /// <summary>
        /// Gets the list of history reports and their statuses. The method returns info about reports made via [GetCallHistory] with the specified __output=csv__ and **is_async=true** parameters. Note that the **file_size** field in response is valid only for video calls.
        /// </summary>
        public async Task<GetHistoryReportsResponse> GetHistoryReports(GetHistoryReportsRequest request)
        {
            return await PerformRequest<GetHistoryReportsResponse, GetHistoryReportsRequest>("GetHistoryReports", request);
        }

        /// <summary>
        /// Gets the transaction history.
        /// </summary>
        public async Task<GetTransactionHistoryResponse> GetTransactionHistory(GetTransactionHistoryRequest request)
        {
            return await PerformRequest<GetTransactionHistoryResponse, GetTransactionHistoryRequest>("GetTransactionHistory", request);
        }

        /// <summary>
        /// Try to remove record and transcription files.
        /// </summary>
        public async Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest request)
        {
            return await PerformRequest<DeleteRecordResponse, DeleteRecordRequest>("DeleteRecord", request);
        }

        /// <summary>
        /// Gets the ACD history.
        /// </summary>
        public async Task<GetACDHistoryResponse> GetACDHistory(GetACDHistoryRequest request)
        {
            return await PerformRequest<GetACDHistoryResponse, GetACDHistoryRequest>("GetACDHistory", request);
        }

        /// <summary>
        /// Gets the history of account changes.
        /// </summary>
        public async Task<GetAuditLogResponse> GetAuditLog(GetAuditLogRequest request)
        {
            return await PerformRequest<GetAuditLogResponse, GetAuditLogRequest>("GetAuditLog", request);
        }

        /// <summary>
        /// Add a new phone number to the PSTN blacklist. BlackList works for numbers that are purchased from Voximplant only. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        public async Task<AddPstnBlackListItemResponse> AddPstnBlackListItem(AddPstnBlackListItemRequest request)
        {
            return await PerformRequest<AddPstnBlackListItemResponse, AddPstnBlackListItemRequest>("AddPstnBlackListItem", request);
        }

        /// <summary>
        /// Update the PSTN blacklist item. BlackList works for numbers that are purchased from Voximplant only. Since we have no control over exact phone number format for calls from SIP integrations, blacklisting such numbers should be done via JavaScript scenarios.
        /// </summary>
        public async Task<SetPstnBlackListItemResponse> SetPstnBlackListItem(SetPstnBlackListItemRequest request)
        {
            return await PerformRequest<SetPstnBlackListItemResponse, SetPstnBlackListItemRequest>("SetPstnBlackListItem", request);
        }

        /// <summary>
        /// Remove phone number from the PSTN blacklist.
        /// </summary>
        public async Task<DelPstnBlackListItemResponse> DelPstnBlackListItem(DelPstnBlackListItemRequest request)
        {
            return await PerformRequest<DelPstnBlackListItemResponse, DelPstnBlackListItemRequest>("DelPstnBlackListItem", request);
        }

        /// <summary>
        /// Get the whole PSTN blacklist.
        /// </summary>
        public async Task<GetPstnBlackListResponse> GetPstnBlackList(GetPstnBlackListRequest request)
        {
            return await PerformRequest<GetPstnBlackListResponse, GetPstnBlackListRequest>("GetPstnBlackList", request);
        }

        /// <summary>
        /// Adds a new network address to the SIP white list.
        /// </summary>
        public async Task<AddSipWhiteListItemResponse> AddSipWhiteListItem(AddSipWhiteListItemRequest request)
        {
            return await PerformRequest<AddSipWhiteListItemResponse, AddSipWhiteListItemRequest>("AddSipWhiteListItem", request);
        }

        /// <summary>
        /// Deletes the network address from the SIP white list.
        /// </summary>
        public async Task<DelSipWhiteListItemResponse> DelSipWhiteListItem(DelSipWhiteListItemRequest request)
        {
            return await PerformRequest<DelSipWhiteListItemResponse, DelSipWhiteListItemRequest>("DelSipWhiteListItem", request);
        }

        /// <summary>
        /// Edits the SIP white list.
        /// </summary>
        public async Task<SetSipWhiteListItemResponse> SetSipWhiteListItem(SetSipWhiteListItemRequest request)
        {
            return await PerformRequest<SetSipWhiteListItemResponse, SetSipWhiteListItemRequest>("SetSipWhiteListItem", request);
        }

        /// <summary>
        /// Gets the SIP white list.
        /// </summary>
        public async Task<GetSipWhiteListResponse> GetSipWhiteList(GetSipWhiteListRequest request)
        {
            return await PerformRequest<GetSipWhiteListResponse, GetSipWhiteListRequest>("GetSipWhiteList", request);
        }

        /// <summary>
        /// Create a new SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should set is_persistent=true if you specify the user_id or user_name. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public async Task<CreateSipRegistrationResponse> CreateSipRegistration(CreateSipRegistrationRequest request)
        {
            return await PerformRequest<CreateSipRegistrationResponse, CreateSipRegistrationRequest>("CreateSipRegistration", request);
        }

        /// <summary>
        /// Update SIP registration. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public async Task<UpdateSipRegistrationResponse> UpdateSipRegistration(UpdateSipRegistrationRequest request)
        {
            return await PerformRequest<UpdateSipRegistrationResponse, UpdateSipRegistrationRequest>("UpdateSipRegistration", request);
        }

        /// <summary>
        /// Bind the SIP registration to the application/user or unbind the SIP registration from the application/user. You should specify the application_id or application_name if you specify the rule_name or user_id, or user_name. You should specify the sip_registration_id if you set bind=true. You can bind only one SIP registration to the user (the previous SIP registration will be auto unbound).
        /// </summary>
        public async Task<BindSipRegistrationResponse> BindSipRegistration(BindSipRegistrationRequest request)
        {
            return await PerformRequest<BindSipRegistrationResponse, BindSipRegistrationRequest>("BindSipRegistration", request);
        }

        /// <summary>
        /// Delete SIP registration.
        /// </summary>
        public async Task<DeleteSipRegistrationResponse> DeleteSipRegistration(DeleteSipRegistrationRequest request)
        {
            return await PerformRequest<DeleteSipRegistrationResponse, DeleteSipRegistrationRequest>("DeleteSipRegistration", request);
        }

        /// <summary>
        /// Get active SIP registrations.
        /// </summary>
        public async Task<GetSipRegistrationsResponse> GetSipRegistrations(GetSipRegistrationsRequest request)
        {
            return await PerformRequest<GetSipRegistrationsResponse, GetSipRegistrationsRequest>("GetSipRegistrations", request);
        }

        /// <summary>
        /// Attach the phone number to the account. Note that phone numbers of some countries may require additional verification steps.
        /// </summary>
        public async Task<AttachPhoneNumberResponse> AttachPhoneNumber(AttachPhoneNumberRequest request)
        {
            return await PerformRequest<AttachPhoneNumberResponse, AttachPhoneNumberRequest>("AttachPhoneNumber", request);
        }

        /// <summary>
        /// Bind the phone number to the application or unbind the phone number from the application. You should specify the application_id or application_name if you specify the rule_name.
        /// </summary>
        public async Task<BindPhoneNumberToApplicationResponse> BindPhoneNumberToApplication(BindPhoneNumberToApplicationRequest request)
        {
            return await PerformRequest<BindPhoneNumberToApplicationResponse, BindPhoneNumberToApplicationRequest>("BindPhoneNumberToApplication", request);
        }

        /// <summary>
        /// Deactivates the phone number.
        /// </summary>
        public async Task<DeactivatePhoneNumberResponse> DeactivatePhoneNumber(DeactivatePhoneNumberRequest request)
        {
            return await PerformRequest<DeactivatePhoneNumberResponse, DeactivatePhoneNumberRequest>("DeactivatePhoneNumber", request);
        }

        /// <summary>
        /// Gets the account phone numbers.
        /// </summary>
        public async Task<GetPhoneNumbersResponse> GetPhoneNumbers(GetPhoneNumbersRequest request)
        {
            return await PerformRequest<GetPhoneNumbersResponse, GetPhoneNumbersRequest>("GetPhoneNumbers", request);
        }

        /// <summary>
        /// Gets the new phone numbers.
        /// </summary>
        public async Task<GetNewPhoneNumbersResponse> GetNewPhoneNumbers(GetNewPhoneNumbersRequest request)
        {
            return await PerformRequest<GetNewPhoneNumbersResponse, GetNewPhoneNumbersRequest>("GetNewPhoneNumbers", request);
        }

        /// <summary>
        /// Gets the phone number categories.
        /// </summary>
        public async Task<GetPhoneNumberCategoriesResponse> GetPhoneNumberCategories(GetPhoneNumberCategoriesRequest request)
        {
            return await PerformRequest<GetPhoneNumberCategoriesResponse, GetPhoneNumberCategoriesRequest>("GetPhoneNumberCategories", request);
        }

        /// <summary>
        /// Gets the phone number country states.
        /// </summary>
        public async Task<GetPhoneNumberCountryStatesResponse> GetPhoneNumberCountryStates(GetPhoneNumberCountryStatesRequest request)
        {
            return await PerformRequest<GetPhoneNumberCountryStatesResponse, GetPhoneNumberCountryStatesRequest>("GetPhoneNumberCountryStates", request);
        }

        /// <summary>
        /// Get the country regions of the phone numbers. The response will also contain the info about multiple numbers subscription for the child accounts.
        /// </summary>
        public async Task<GetPhoneNumberRegionsResponse> GetPhoneNumberRegions(GetPhoneNumberRegionsRequest request)
        {
            return await PerformRequest<GetPhoneNumberRegionsResponse, GetPhoneNumberRegionsRequest>("GetPhoneNumberRegions", request);
        }

        /// <summary>
        /// Get actual info the country region of the phone numbers. The response will also contain the info about multiple numbers subscription for the child accounts.
        /// </summary>
        public async Task<GetActualPhoneNumberRegionResponse> GetActualPhoneNumberRegion(GetActualPhoneNumberRegionRequest request)
        {
            return await PerformRequest<GetActualPhoneNumberRegionResponse, GetActualPhoneNumberRegionRequest>("GetActualPhoneNumberRegion", request);
        }

        /// <summary>
        /// Adds a new caller ID. Caller ID is the phone that will be displayed to the called user. This number can be used for call back.
        /// </summary>
        public async Task<AddCallerIDResponse> AddCallerID(AddCallerIDRequest request)
        {
            return await PerformRequest<AddCallerIDResponse, AddCallerIDRequest>("AddCallerID", request);
        }

        /// <summary>
        /// Activates the CallerID by the verification code.
        /// </summary>
        public async Task<ActivateCallerIDResponse> ActivateCallerID(ActivateCallerIDRequest request)
        {
            return await PerformRequest<ActivateCallerIDResponse, ActivateCallerIDRequest>("ActivateCallerID", request);
        }

        /// <summary>
        /// Deletes the CallerID. Note: you can't delete a CID permanently (the antispam defence).
        /// </summary>
        public async Task<DelCallerIDResponse> DelCallerID(DelCallerIDRequest request)
        {
            return await PerformRequest<DelCallerIDResponse, DelCallerIDRequest>("DelCallerID", request);
        }

        /// <summary>
        /// Gets the account callerIDs.
        /// </summary>
        public async Task<GetCallerIDsResponse> GetCallerIDs(GetCallerIDsRequest request)
        {
            return await PerformRequest<GetCallerIDsResponse, GetCallerIDsRequest>("GetCallerIDs", request);
        }

        /// <summary>
        /// Gets a verification code via phone call to the **callerid_number**.
        /// </summary>
        public async Task<VerifyCallerIDResponse> VerifyCallerID(VerifyCallerIDRequest request)
        {
            return await PerformRequest<VerifyCallerIDResponse, VerifyCallerIDRequest>("VerifyCallerID", request);
        }

        /// <summary>
        /// Adds a new ACD queue.
        /// </summary>
        public async Task<AddQueueResponse> AddQueue(AddQueueRequest request)
        {
            return await PerformRequest<AddQueueResponse, AddQueueRequest>("AddQueue", request);
        }

        /// <summary>
        /// Bind/unbind users to/from the specified ACD queues. Note that users and queues should be already bound to the same application.
        /// </summary>
        public async Task<BindUserToQueueResponse> BindUserToQueue(BindUserToQueueRequest request)
        {
            return await PerformRequest<BindUserToQueueResponse, BindUserToQueueRequest>("BindUserToQueue", request);
        }

        /// <summary>
        /// Deletes the ACD queue.
        /// </summary>
        public async Task<DelQueueResponse> DelQueue(DelQueueRequest request)
        {
            return await PerformRequest<DelQueueResponse, DelQueueRequest>("DelQueue", request);
        }

        /// <summary>
        /// Edits the ACD queue.
        /// </summary>
        public async Task<SetQueueInfoResponse> SetQueueInfo(SetQueueInfoRequest request)
        {
            return await PerformRequest<SetQueueInfoResponse, SetQueueInfoRequest>("SetQueueInfo", request);
        }

        /// <summary>
        /// Gets the ACD queues.
        /// </summary>
        public async Task<GetQueuesResponse> GetQueues(GetQueuesRequest request)
        {
            return await PerformRequest<GetQueuesResponse, GetQueuesRequest>("GetQueues", request);
        }

        /// <summary>
        /// Gets the current ACD queue state.
        /// </summary>
        public async Task<GetACDStateResponse> GetACDState(GetACDStateRequest request)
        {
            return await PerformRequest<GetACDStateResponse, GetACDStateRequest>("GetACDState", request);
        }

        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'ACD' module. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        public async Task<GetACDOperatorStatisticsResponse> GetACDOperatorStatistics(GetACDOperatorStatisticsRequest request)
        {
            return await PerformRequest<GetACDOperatorStatisticsResponse, GetACDOperatorStatisticsRequest>("GetACDOperatorStatistics", request);
        }

        /// <summary>
        /// Get statistics for calls distributed to users (referred as 'operators') via the 'queue' distribution system. This method can filter statistic based on operator ids, queue ids and date-time interval. It can also group results by day or hour.
        /// </summary>
        public async Task<GetACDQueueStatisticsResponse> GetACDQueueStatistics(GetACDQueueStatisticsRequest request)
        {
            return await PerformRequest<GetACDQueueStatisticsResponse, GetACDQueueStatisticsRequest>("GetACDQueueStatistics", request);
        }

        /// <summary>
        /// Get statistics for the specified operators and ACD statuses. This method can filter statistics by operator ids and statuses. It can also group results by day/hour or users.
        /// </summary>
        public async Task<GetACDOperatorStatusStatisticsResponse> GetACDOperatorStatusStatistics(GetACDOperatorStatusStatisticsRequest request)
        {
            return await PerformRequest<GetACDOperatorStatusStatisticsResponse, GetACDOperatorStatusStatisticsRequest>("GetACDOperatorStatusStatistics", request);
        }

        /// <summary>
        /// Adds a new ACD operator skill.
        /// </summary>
        public async Task<AddSkillResponse> AddSkill(AddSkillRequest request)
        {
            return await PerformRequest<AddSkillResponse, AddSkillRequest>("AddSkill", request);
        }

        /// <summary>
        /// Deletes the skill.
        /// </summary>
        public async Task<DelSkillResponse> DelSkill(DelSkillRequest request)
        {
            return await PerformRequest<DelSkillResponse, DelSkillRequest>("DelSkill", request);
        }

        /// <summary>
        /// Edits the skill.
        /// </summary>
        public async Task<SetSkillInfoResponse> SetSkillInfo(SetSkillInfoRequest request)
        {
            return await PerformRequest<SetSkillInfoResponse, SetSkillInfoRequest>("SetSkillInfo", request);
        }

        /// <summary>
        /// Gets the skills.
        /// </summary>
        public async Task<GetSkillsResponse> GetSkills(GetSkillsRequest request)
        {
            return await PerformRequest<GetSkillsResponse, GetSkillsRequest>("GetSkills", request);
        }

        /// <summary>
        /// Binds the specified skills to the users (ACD operators) and/or the ACD queues.
        /// </summary>
        public async Task<BindSkillResponse> BindSkill(BindSkillRequest request)
        {
            return await PerformRequest<BindSkillResponse, BindSkillRequest>("BindSkill", request);
        }

        /// <summary>
        /// Gets the account documents and the verification states.
        /// </summary>
        public async Task<GetAccountDocumentsResponse> GetAccountDocuments(GetAccountDocumentsRequest request)
        {
            return await PerformRequest<GetAccountDocumentsResponse, GetAccountDocumentsRequest>("GetAccountDocuments", request);
        }

        /// <summary>
        /// Adds a new admin user into the specified parent or child account.
        /// </summary>
        public async Task<AddAdminUserResponse> AddAdminUser(AddAdminUserRequest request)
        {
            return await PerformRequest<AddAdminUserResponse, AddAdminUserRequest>("AddAdminUser", request);
        }

        /// <summary>
        /// Deletes the specified admin user.
        /// </summary>
        public async Task<DelAdminUserResponse> DelAdminUser(DelAdminUserRequest request)
        {
            return await PerformRequest<DelAdminUserResponse, DelAdminUserRequest>("DelAdminUser", request);
        }

        /// <summary>
        /// Edits the specified admin user.
        /// </summary>
        public async Task<SetAdminUserInfoResponse> SetAdminUserInfo(SetAdminUserInfoRequest request)
        {
            return await PerformRequest<SetAdminUserInfoResponse, SetAdminUserInfoRequest>("SetAdminUserInfo", request);
        }

        /// <summary>
        /// Gets the admin users of the specified account. Note that both account types - parent and child - could have its own admins.
        /// </summary>
        public async Task<GetAdminUsersResponse> GetAdminUsers(GetAdminUsersRequest request)
        {
            return await PerformRequest<GetAdminUsersResponse, GetAdminUsersRequest>("GetAdminUsers", request);
        }

        /// <summary>
        /// Adds a new admin role.
        /// </summary>
        public async Task<AddAdminRoleResponse> AddAdminRole(AddAdminRoleRequest request)
        {
            return await PerformRequest<AddAdminRoleResponse, AddAdminRoleRequest>("AddAdminRole", request);
        }

        /// <summary>
        /// Deletes the specified admin role.
        /// </summary>
        public async Task<DelAdminRoleResponse> DelAdminRole(DelAdminRoleRequest request)
        {
            return await PerformRequest<DelAdminRoleResponse, DelAdminRoleRequest>("DelAdminRole", request);
        }

        /// <summary>
        /// Edits the specified admin role.
        /// </summary>
        public async Task<SetAdminRoleInfoResponse> SetAdminRoleInfo(SetAdminRoleInfoRequest request)
        {
            return await PerformRequest<SetAdminRoleInfoResponse, SetAdminRoleInfoRequest>("SetAdminRoleInfo", request);
        }

        /// <summary>
        /// Gets the admin roles.
        /// </summary>
        public async Task<GetAdminRolesResponse> GetAdminRoles(GetAdminRolesRequest request)
        {
            return await PerformRequest<GetAdminRolesResponse, GetAdminRolesRequest>("GetAdminRoles", request);
        }

        /// <summary>
        /// Attaches the admin role(s) to the already existing admin(s).
        /// </summary>
        public async Task<AttachAdminRoleResponse> AttachAdminRole(AttachAdminRoleRequest request)
        {
            return await PerformRequest<AttachAdminRoleResponse, AttachAdminRoleRequest>("AttachAdminRole", request);
        }

        /// <summary>
        /// Gets the all available admin role entries.
        /// </summary>
        public async Task<GetAvailableAdminRoleEntriesResponse> GetAvailableAdminRoleEntries(GetAvailableAdminRoleEntriesRequest request)
        {
            return await PerformRequest<GetAvailableAdminRoleEntriesResponse, GetAvailableAdminRoleEntriesRequest>("GetAvailableAdminRoleEntries", request);
        }

        /// <summary>
        /// Adds a new authorized IP4 or network to the white/black list.
        /// </summary>
        public async Task<AddAuthorizedAccountIPResponse> AddAuthorizedAccountIP(AddAuthorizedAccountIPRequest request)
        {
            return await PerformRequest<AddAuthorizedAccountIPResponse, AddAuthorizedAccountIPRequest>("AddAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Removes the authorized IP4 or network from the white/black list.
        /// </summary>
        public async Task<DelAuthorizedAccountIPResponse> DelAuthorizedAccountIP(DelAuthorizedAccountIPRequest request)
        {
            return await PerformRequest<DelAuthorizedAccountIPResponse, DelAuthorizedAccountIPRequest>("DelAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Gets the authorized IP4 or network.
        /// </summary>
        public async Task<GetAuthorizedAccountIPsResponse> GetAuthorizedAccountIPs(GetAuthorizedAccountIPsRequest request)
        {
            return await PerformRequest<GetAuthorizedAccountIPsResponse, GetAuthorizedAccountIPsRequest>("GetAuthorizedAccountIPs", request);
        }

        /// <summary>
        /// Tests whether the IP4 is banned or allowed.
        /// </summary>
        public async Task<CheckAuthorizedAccountIPResponse> CheckAuthorizedAccountIP(CheckAuthorizedAccountIPRequest request)
        {
            return await PerformRequest<CheckAuthorizedAccountIPResponse, CheckAuthorizedAccountIPRequest>("CheckAuthorizedAccountIP", request);
        }

        /// <summary>
        /// Link regulation address to phone
        /// </summary>
        public async Task<LinkregulationAddressResponse> LinkregulationAddress(LinkregulationAddressRequest request)
        {
            return await PerformRequest<LinkregulationAddressResponse, LinkregulationAddressRequest>("LinkregulationAddress", request);
        }

        /// <summary>
        /// Search available zip codes
        /// </summary>
        public async Task<GetZIPCodesResponse> GetZIPCodes(GetZIPCodesRequest request)
        {
            return await PerformRequest<GetZIPCodesResponse, GetZIPCodesRequest>("GetZIPCodes", request);
        }

        /// <summary>
        /// Search user's regulation address
        /// </summary>
        public async Task<GetRegulationsAddressResponse> GetRegulationsAddress(GetRegulationsAddressRequest request)
        {
            return await PerformRequest<GetRegulationsAddressResponse, GetRegulationsAddressRequest>("GetRegulationsAddress", request);
        }

        /// <summary>
        /// Search available regulation for link
        /// </summary>
        public async Task<GetAvailableRegulationsResponse> GetAvailableRegulations(GetAvailableRegulationsRequest request)
        {
            return await PerformRequest<GetAvailableRegulationsResponse, GetAvailableRegulationsRequest>("GetAvailableRegulations", request);
        }

        /// <summary>
        /// Get all countries
        /// </summary>
        public async Task<GetCountriesResponse> GetCountries(GetCountriesRequest request)
        {
            return await PerformRequest<GetCountriesResponse, GetCountriesRequest>("GetCountries", request);
        }

        /// <summary>
        /// Get available regions in country
        /// </summary>
        public async Task<GetRegionsResponse> GetRegions(GetRegionsRequest request)
        {
            return await PerformRequest<GetRegionsResponse, GetRegionsRequest>("GetRegions", request);
        }

        /// <summary>
        /// Add push credentials
        /// </summary>
        public async Task<AddPushCredentialResponse> AddPushCredential(AddPushCredentialRequest request)
        {
            return await PerformRequest<AddPushCredentialResponse, AddPushCredentialRequest>("AddPushCredential", request);
        }

        /// <summary>
        /// Modify push credentials
        /// </summary>
        public async Task<SetPushCredentialResponse> SetPushCredential(SetPushCredentialRequest request)
        {
            return await PerformRequest<SetPushCredentialResponse, SetPushCredentialRequest>("SetPushCredential", request);
        }

        /// <summary>
        /// Remove push credentials
        /// </summary>
        public async Task<DelPushCredentialResponse> DelPushCredential(DelPushCredentialRequest request)
        {
            return await PerformRequest<DelPushCredentialResponse, DelPushCredentialRequest>("DelPushCredential", request);
        }

        /// <summary>
        /// Get push credentials
        /// </summary>
        public async Task<GetPushCredentialResponse> GetPushCredential(GetPushCredentialRequest request)
        {
            return await PerformRequest<GetPushCredentialResponse, GetPushCredentialRequest>("GetPushCredential", request);
        }

        /// <summary>
        /// Bind push credentials to applications
        /// </summary>
        public async Task<BindPushCredentialResponse> BindPushCredential(BindPushCredentialRequest request)
        {
            return await PerformRequest<BindPushCredentialResponse, BindPushCredentialRequest>("BindPushCredential", request);
        }

        /// <summary>
        /// Add Dialogflow key.
        /// </summary>
        public async Task<AddDialogflowKeyResponse> AddDialogflowKey(AddDialogflowKeyRequest request)
        {
            return await PerformRequest<AddDialogflowKeyResponse, AddDialogflowKeyRequest>("AddDialogflowKey", request);
        }

        /// <summary>
        /// Edit Dialogflow key.
        /// </summary>
        public async Task<SetDialogflowKeyResponse> SetDialogflowKey(SetDialogflowKeyRequest request)
        {
            return await PerformRequest<SetDialogflowKeyResponse, SetDialogflowKeyRequest>("SetDialogflowKey", request);
        }

        /// <summary>
        /// Remove Dialogflow key.
        /// </summary>
        public async Task<DelDialogflowKeyResponse> DelDialogflowKey(DelDialogflowKeyRequest request)
        {
            return await PerformRequest<DelDialogflowKeyResponse, DelDialogflowKeyRequest>("DelDialogflowKey", request);
        }

        /// <summary>
        /// Get Dialogflow keys.
        /// </summary>
        public async Task<GetDialogflowKeysResponse> GetDialogflowKeys(GetDialogflowKeysRequest request)
        {
            return await PerformRequest<GetDialogflowKeysResponse, GetDialogflowKeysRequest>("GetDialogflowKeys", request);
        }

        /// <summary>
        /// Bind a Dialogflow key to the specified applications.
        /// </summary>
        public async Task<BindDialogflowKeysResponse> BindDialogflowKeys(BindDialogflowKeysRequest request)
        {
            return await PerformRequest<BindDialogflowKeysResponse, BindDialogflowKeysRequest>("BindDialogflowKeys", request);
        }

        /// <summary>
        /// Send SMS message between two phone numbers. The source phone number should be purchased from Voximplant and support SMS (which is indicated by the <b>is_sms_supported</b> property in the objects returned by the [GetPhoneNumbers] HTTP API) and SMS should be enabled for it via the [ControlSms] HTTP API. SMS messages can be received via HTTP callbacks, see <a href='/docs/howtos/integration/httpapi/callbacks'>this article</a> for details.
        /// </summary>
        public async Task<SendSmsMessageResponse> SendSmsMessage(SendSmsMessageRequest request)
        {
            return await PerformRequest<SendSmsMessageResponse, SendSmsMessageRequest>("SendSmsMessage", request);
        }

        /// <summary>
        /// Enable or disable SMS sending and receiving for the phone number. Can be used only for phone numbers with SMS support, which is indicated by the <b>is_sms_supported</b> property in the objects returned by the [GetPhoneNumbers] HTTP API. Each inbound SMS message is billed according to the <a href='//voximplant.com/pricing'>pricing</a>. If enabled, SMS can be sent from this phone number using the [SendSmsMessage] HTTP API and received using the [InboundSmsCallback] property of the HTTP callback. See <a href='/docs/howtos/integration/httpapi/callbacks'>this article</a> for HTTP callback details.
        /// </summary>
        public async Task<ControlSmsResponse> ControlSms(ControlSmsRequest request)
        {
            return await PerformRequest<ControlSmsResponse, ControlSmsRequest>("ControlSms", request);
        }

        /// <summary>
        /// Get the record storages.
        /// </summary>
        public async Task<GetRecordStoragesResponse> GetRecordStorages(GetRecordStoragesRequest request)
        {
            return await PerformRequest<GetRecordStoragesResponse, GetRecordStoragesRequest>("GetRecordStorages", request);
        }

        /// <summary>
        /// Creates a public/private key pair. You can optionally specify one or more roles for the key, see [this article](https://voximplant.com/blog/service-accounts-introduction) for details.
        /// </summary>
        public async Task<CreateKeyResponse> CreateKey(CreateKeyRequest request)
        {
            return await PerformRequest<CreateKeyResponse, CreateKeyRequest>("CreateKey", request);
        }

        /// <summary>
        /// Gets key info of the specified account.
        /// </summary>
        public async Task<GetKeysResponse> GetKeys(GetKeysRequest request)
        {
            return await PerformRequest<GetKeysResponse, GetKeysRequest>("GetKeys", request);
        }

        /// <summary>
        /// Updates info of the specified key.
        /// </summary>
        public async Task<UpdateKeyResponse> UpdateKey(UpdateKeyRequest request)
        {
            return await PerformRequest<UpdateKeyResponse, UpdateKeyRequest>("UpdateKey", request);
        }

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        public async Task<DeleteKeyResponse> DeleteKey(DeleteKeyRequest request)
        {
            return await PerformRequest<DeleteKeyResponse, DeleteKeyRequest>("DeleteKey", request);
        }

        /// <summary>
        /// Set roles for the specified key.
        /// </summary>
        public async Task<SetKeyRolesResponse> SetKeyRoles(SetKeyRolesRequest request)
        {
            return await PerformRequest<SetKeyRolesResponse, SetKeyRolesRequest>("SetKeyRoles", request);
        }

        /// <summary>
        /// Gets roles of the specified key.
        /// </summary>
        public async Task<GetKeyRolesResponse> GetKeyRoles(GetKeyRolesRequest request)
        {
            return await PerformRequest<GetKeyRolesResponse, GetKeyRolesRequest>("GetKeyRoles", request);
        }

        /// <summary>
        /// Removes the specified roles of a key.
        /// </summary>
        public async Task<RemoveKeyRolesResponse> RemoveKeyRoles(RemoveKeyRolesRequest request)
        {
            return await PerformRequest<RemoveKeyRolesResponse, RemoveKeyRolesRequest>("RemoveKeyRoles", request);
        }

        /// <summary>
        /// Creates a subuser.
        /// </summary>
        public async Task<AddSubUserResponse> AddSubUser(AddSubUserRequest request)
        {
            return await PerformRequest<AddSubUserResponse, AddSubUserRequest>("AddSubUser", request);
        }

        /// <summary>
        /// Gets subusers.
        /// </summary>
        public async Task<GetSubUsersResponse> GetSubUsers(GetSubUsersRequest request)
        {
            return await PerformRequest<GetSubUsersResponse, GetSubUsersRequest>("GetSubUsers", request);
        }

        /// <summary>
        /// Edits a subuser.
        /// </summary>
        public async Task<SetSubUserInfoResponse> SetSubUserInfo(SetSubUserInfoRequest request)
        {
            return await PerformRequest<SetSubUserInfoResponse, SetSubUserInfoRequest>("SetSubUserInfo", request);
        }

        /// <summary>
        /// Deletes a subuser.
        /// </summary>
        public async Task<DelSubUserResponse> DelSubUser(DelSubUserRequest request)
        {
            return await PerformRequest<DelSubUserResponse, DelSubUserRequest>("DelSubUser", request);
        }

        /// <summary>
        /// Adds the specified roles for a subuser.
        /// </summary>
        public async Task<SetSubUserRolesResponse> SetSubUserRoles(SetSubUserRolesRequest request)
        {
            return await PerformRequest<SetSubUserRolesResponse, SetSubUserRolesRequest>("SetSubUserRoles", request);
        }

        /// <summary>
        /// Gets the subuser's roles.
        /// </summary>
        public async Task<GetSubUserRolesResponse> GetSubUserRoles(GetSubUserRolesRequest request)
        {
            return await PerformRequest<GetSubUserRolesResponse, GetSubUserRolesRequest>("GetSubUserRoles", request);
        }

        /// <summary>
        /// Removes the specified roles of a subuser.
        /// </summary>
        public async Task<RemoveSubUserRolesResponse> RemoveSubUserRoles(RemoveSubUserRolesRequest request)
        {
            return await PerformRequest<RemoveSubUserRolesResponse, RemoveSubUserRolesRequest>("RemoveSubUserRoles", request);
        }

        /// <summary>
        /// Gets all roles.
        /// </summary>
        public async Task<GetRolesResponse> GetRoles(GetRolesRequest request)
        {
            return await PerformRequest<GetRolesResponse, GetRolesRequest>("GetRoles", request);
        }

        /// <summary>
        /// Gets role groups.
        /// </summary>
        public async Task<GetRoleGroupsResponse> GetRoleGroups(GetRoleGroupsRequest request)
        {
            return await PerformRequest<GetRoleGroupsResponse, GetRoleGroupsRequest>("GetRoleGroups", request);
        }

        /// <summary>
        /// Adds a new subscription for the specified child account.
        /// </summary>
        public async Task<AddChildAccountSubscriptionResponse> AddChildAccountSubscription(AddChildAccountSubscriptionRequest request)
        {
            return await PerformRequest<AddChildAccountSubscriptionResponse, AddChildAccountSubscriptionRequest>("AddChildAccountSubscription", request);
        }

        /// <summary>
        /// Gets the active subscription(s) for the specified child account.
        /// </summary>
        public async Task<GetChildAccountSubscriptionsResponse> GetChildAccountSubscriptions(GetChildAccountSubscriptionsRequest request)
        {
            return await PerformRequest<GetChildAccountSubscriptionsResponse, GetChildAccountSubscriptionsRequest>("GetChildAccountSubscriptions", request);
        }

        /// <summary>
        /// Gets all the eligible subscription templates. A template is considered to be eligible if it is of a type that supports child accounts management.
        /// </summary>
        public async Task<GetChildAccountSubscriptionTemplatesResponse> GetChildAccountSubscriptionTemplates(GetChildAccountSubscriptionTemplatesRequest request)
        {
            return await PerformRequest<GetChildAccountSubscriptionTemplatesResponse, GetChildAccountSubscriptionTemplatesRequest>("GetChildAccountSubscriptionTemplates", request);
        }

        /// <summary>
        /// Deactivates the specified subscription(s).
        /// </summary>
        public async Task<DeactivateChildAccountSubscriptionResponse> DeactivateChildAccountSubscription(DeactivateChildAccountSubscriptionRequest request)
        {
            return await PerformRequest<DeactivateChildAccountSubscriptionResponse, DeactivateChildAccountSubscriptionRequest>("DeactivateChildAccountSubscription", request);
        }

        /// <summary>
        /// Get history of sent and/or received SMS.
        /// </summary>
        public async Task<GetSmsHistoryResponse> GetSmsHistory(GetSmsHistoryRequest request)
        {
            return await PerformRequest<GetSmsHistoryResponse, GetSmsHistoryRequest>("GetSmsHistory", request);
        }

    }
}