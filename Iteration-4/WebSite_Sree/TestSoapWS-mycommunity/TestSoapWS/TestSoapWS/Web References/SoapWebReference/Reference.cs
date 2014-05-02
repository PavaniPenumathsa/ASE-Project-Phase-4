﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace TestSoapWS.SoapWebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUserDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertUserDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCurrentMonthYearOperationCompleted;
        
        private System.Threading.SendOrPostCallback selectCommunityOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertMyCommunityOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertUtilityBillOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateUtilityBillOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalculateRewardPointsOperationCompleted;
        
        private System.Threading.SendOrPostCallback CommunityRewardPointsOperationCompleted;
        
        private System.Threading.SendOrPostCallback RewardPointsByCommunityOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::TestSoapWS.Properties.Settings.Default.TestSoapWS_SoapWebReference_WebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetUserDataCompletedEventHandler GetUserDataCompleted;
        
        /// <remarks/>
        public event InsertUserDataCompletedEventHandler InsertUserDataCompleted;
        
        /// <remarks/>
        public event getCurrentMonthYearCompletedEventHandler getCurrentMonthYearCompleted;
        
        /// <remarks/>
        public event selectCommunityCompletedEventHandler selectCommunityCompleted;
        
        /// <remarks/>
        public event InsertMyCommunityCompletedEventHandler InsertMyCommunityCompleted;
        
        /// <remarks/>
        public event InsertUtilityBillCompletedEventHandler InsertUtilityBillCompleted;
        
        /// <remarks/>
        public event UpdateUtilityBillCompletedEventHandler UpdateUtilityBillCompleted;
        
        /// <remarks/>
        public event CalculateRewardPointsCompletedEventHandler CalculateRewardPointsCompleted;
        
        /// <remarks/>
        public event CommunityRewardPointsCompletedEventHandler CommunityRewardPointsCompleted;
        
        /// <remarks/>
        public event RewardPointsByCommunityCompletedEventHandler RewardPointsByCommunityCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUserData(string user_name1, string password) {
            object[] results = this.Invoke("GetUserData", new object[] {
                        user_name1,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserDataAsync(string user_name1, string password) {
            this.GetUserDataAsync(user_name1, password, null);
        }
        
        /// <remarks/>
        public void GetUserDataAsync(string user_name1, string password, object userState) {
            if ((this.GetUserDataOperationCompleted == null)) {
                this.GetUserDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserDataOperationCompleted);
            }
            this.InvokeAsync("GetUserData", new object[] {
                        user_name1,
                        password}, this.GetUserDataOperationCompleted, userState);
        }
        
        private void OnGetUserDataOperationCompleted(object arg) {
            if ((this.GetUserDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserDataCompleted(this, new GetUserDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertUserData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertUserData(string user_name1, string email, string password, string password_confirm, string address, string phonenumber) {
            object[] results = this.Invoke("InsertUserData", new object[] {
                        user_name1,
                        email,
                        password,
                        password_confirm,
                        address,
                        phonenumber});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertUserDataAsync(string user_name1, string email, string password, string password_confirm, string address, string phonenumber) {
            this.InsertUserDataAsync(user_name1, email, password, password_confirm, address, phonenumber, null);
        }
        
        /// <remarks/>
        public void InsertUserDataAsync(string user_name1, string email, string password, string password_confirm, string address, string phonenumber, object userState) {
            if ((this.InsertUserDataOperationCompleted == null)) {
                this.InsertUserDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertUserDataOperationCompleted);
            }
            this.InvokeAsync("InsertUserData", new object[] {
                        user_name1,
                        email,
                        password,
                        password_confirm,
                        address,
                        phonenumber}, this.InsertUserDataOperationCompleted, userState);
        }
        
        private void OnInsertUserDataOperationCompleted(object arg) {
            if ((this.InsertUserDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertUserDataCompleted(this, new InsertUserDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCurrentMonthYear", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCurrentMonthYear() {
            object[] results = this.Invoke("getCurrentMonthYear", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCurrentMonthYearAsync() {
            this.getCurrentMonthYearAsync(null);
        }
        
        /// <remarks/>
        public void getCurrentMonthYearAsync(object userState) {
            if ((this.getCurrentMonthYearOperationCompleted == null)) {
                this.getCurrentMonthYearOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCurrentMonthYearOperationCompleted);
            }
            this.InvokeAsync("getCurrentMonthYear", new object[0], this.getCurrentMonthYearOperationCompleted, userState);
        }
        
        private void OngetCurrentMonthYearOperationCompleted(object arg) {
            if ((this.getCurrentMonthYearCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCurrentMonthYearCompleted(this, new getCurrentMonthYearCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/selectCommunity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string selectCommunity(string user_name1) {
            object[] results = this.Invoke("selectCommunity", new object[] {
                        user_name1});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void selectCommunityAsync(string user_name1) {
            this.selectCommunityAsync(user_name1, null);
        }
        
        /// <remarks/>
        public void selectCommunityAsync(string user_name1, object userState) {
            if ((this.selectCommunityOperationCompleted == null)) {
                this.selectCommunityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnselectCommunityOperationCompleted);
            }
            this.InvokeAsync("selectCommunity", new object[] {
                        user_name1}, this.selectCommunityOperationCompleted, userState);
        }
        
        private void OnselectCommunityOperationCompleted(object arg) {
            if ((this.selectCommunityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.selectCommunityCompleted(this, new selectCommunityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertMyCommunity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertMyCommunity(string user_name1, int householdsize, int householdmembers, string housetype, string community, string street, string city, string state, string zipcode, string latitude, string longitude) {
            object[] results = this.Invoke("InsertMyCommunity", new object[] {
                        user_name1,
                        householdsize,
                        householdmembers,
                        housetype,
                        community,
                        street,
                        city,
                        state,
                        zipcode,
                        latitude,
                        longitude});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertMyCommunityAsync(string user_name1, int householdsize, int householdmembers, string housetype, string community, string street, string city, string state, string zipcode, string latitude, string longitude) {
            this.InsertMyCommunityAsync(user_name1, householdsize, householdmembers, housetype, community, street, city, state, zipcode, latitude, longitude, null);
        }
        
        /// <remarks/>
        public void InsertMyCommunityAsync(string user_name1, int householdsize, int householdmembers, string housetype, string community, string street, string city, string state, string zipcode, string latitude, string longitude, object userState) {
            if ((this.InsertMyCommunityOperationCompleted == null)) {
                this.InsertMyCommunityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertMyCommunityOperationCompleted);
            }
            this.InvokeAsync("InsertMyCommunity", new object[] {
                        user_name1,
                        householdsize,
                        householdmembers,
                        housetype,
                        community,
                        street,
                        city,
                        state,
                        zipcode,
                        latitude,
                        longitude}, this.InsertMyCommunityOperationCompleted, userState);
        }
        
        private void OnInsertMyCommunityOperationCompleted(object arg) {
            if ((this.InsertMyCommunityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertMyCommunityCompleted(this, new InsertMyCommunityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertUtilityBill", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertUtilityBill(string user_name1, string utilitybill, string month, int year) {
            object[] results = this.Invoke("InsertUtilityBill", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertUtilityBillAsync(string user_name1, string utilitybill, string month, int year) {
            this.InsertUtilityBillAsync(user_name1, utilitybill, month, year, null);
        }
        
        /// <remarks/>
        public void InsertUtilityBillAsync(string user_name1, string utilitybill, string month, int year, object userState) {
            if ((this.InsertUtilityBillOperationCompleted == null)) {
                this.InsertUtilityBillOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertUtilityBillOperationCompleted);
            }
            this.InvokeAsync("InsertUtilityBill", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year}, this.InsertUtilityBillOperationCompleted, userState);
        }
        
        private void OnInsertUtilityBillOperationCompleted(object arg) {
            if ((this.InsertUtilityBillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertUtilityBillCompleted(this, new InsertUtilityBillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateUtilityBill", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateUtilityBill(string user_name1, string utilitybill, string month, int year) {
            object[] results = this.Invoke("UpdateUtilityBill", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateUtilityBillAsync(string user_name1, string utilitybill, string month, int year) {
            this.UpdateUtilityBillAsync(user_name1, utilitybill, month, year, null);
        }
        
        /// <remarks/>
        public void UpdateUtilityBillAsync(string user_name1, string utilitybill, string month, int year, object userState) {
            if ((this.UpdateUtilityBillOperationCompleted == null)) {
                this.UpdateUtilityBillOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateUtilityBillOperationCompleted);
            }
            this.InvokeAsync("UpdateUtilityBill", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year}, this.UpdateUtilityBillOperationCompleted, userState);
        }
        
        private void OnUpdateUtilityBillOperationCompleted(object arg) {
            if ((this.UpdateUtilityBillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateUtilityBillCompleted(this, new UpdateUtilityBillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateRewardPoints", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int CalculateRewardPoints(string user_name1, string utilitybill, string month, int year) {
            object[] results = this.Invoke("CalculateRewardPoints", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void CalculateRewardPointsAsync(string user_name1, string utilitybill, string month, int year) {
            this.CalculateRewardPointsAsync(user_name1, utilitybill, month, year, null);
        }
        
        /// <remarks/>
        public void CalculateRewardPointsAsync(string user_name1, string utilitybill, string month, int year, object userState) {
            if ((this.CalculateRewardPointsOperationCompleted == null)) {
                this.CalculateRewardPointsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateRewardPointsOperationCompleted);
            }
            this.InvokeAsync("CalculateRewardPoints", new object[] {
                        user_name1,
                        utilitybill,
                        month,
                        year}, this.CalculateRewardPointsOperationCompleted, userState);
        }
        
        private void OnCalculateRewardPointsOperationCompleted(object arg) {
            if ((this.CalculateRewardPointsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalculateRewardPointsCompleted(this, new CalculateRewardPointsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CommunityRewardPoints", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CommunityRewardPoints(string username, string month, int year) {
            object[] results = this.Invoke("CommunityRewardPoints", new object[] {
                        username,
                        month,
                        year});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CommunityRewardPointsAsync(string username, string month, int year) {
            this.CommunityRewardPointsAsync(username, month, year, null);
        }
        
        /// <remarks/>
        public void CommunityRewardPointsAsync(string username, string month, int year, object userState) {
            if ((this.CommunityRewardPointsOperationCompleted == null)) {
                this.CommunityRewardPointsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCommunityRewardPointsOperationCompleted);
            }
            this.InvokeAsync("CommunityRewardPoints", new object[] {
                        username,
                        month,
                        year}, this.CommunityRewardPointsOperationCompleted, userState);
        }
        
        private void OnCommunityRewardPointsOperationCompleted(object arg) {
            if ((this.CommunityRewardPointsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CommunityRewardPointsCompleted(this, new CommunityRewardPointsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RewardPointsByCommunity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RewardPointsByCommunity(string month, int year) {
            object[] results = this.Invoke("RewardPointsByCommunity", new object[] {
                        month,
                        year});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RewardPointsByCommunityAsync(string month, int year) {
            this.RewardPointsByCommunityAsync(month, year, null);
        }
        
        /// <remarks/>
        public void RewardPointsByCommunityAsync(string month, int year, object userState) {
            if ((this.RewardPointsByCommunityOperationCompleted == null)) {
                this.RewardPointsByCommunityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRewardPointsByCommunityOperationCompleted);
            }
            this.InvokeAsync("RewardPointsByCommunity", new object[] {
                        month,
                        year}, this.RewardPointsByCommunityOperationCompleted, userState);
        }
        
        private void OnRewardPointsByCommunityOperationCompleted(object arg) {
            if ((this.RewardPointsByCommunityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RewardPointsByCommunityCompleted(this, new RewardPointsByCommunityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetUserDataCompletedEventHandler(object sender, GetUserDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void InsertUserDataCompletedEventHandler(object sender, InsertUserDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertUserDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertUserDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getCurrentMonthYearCompletedEventHandler(object sender, getCurrentMonthYearCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCurrentMonthYearCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCurrentMonthYearCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void selectCommunityCompletedEventHandler(object sender, selectCommunityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class selectCommunityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal selectCommunityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void InsertMyCommunityCompletedEventHandler(object sender, InsertMyCommunityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertMyCommunityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertMyCommunityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void InsertUtilityBillCompletedEventHandler(object sender, InsertUtilityBillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertUtilityBillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertUtilityBillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void UpdateUtilityBillCompletedEventHandler(object sender, UpdateUtilityBillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateUtilityBillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateUtilityBillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void CalculateRewardPointsCompletedEventHandler(object sender, CalculateRewardPointsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalculateRewardPointsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalculateRewardPointsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void CommunityRewardPointsCompletedEventHandler(object sender, CommunityRewardPointsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CommunityRewardPointsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CommunityRewardPointsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void RewardPointsByCommunityCompletedEventHandler(object sender, RewardPointsByCommunityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RewardPointsByCommunityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RewardPointsByCommunityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591