﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34011.
// 
#pragma warning disable 1591

namespace TestWebService.WebService1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getLocationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAddress1OperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAddress2OperationCompleted;
        
        private System.Threading.SendOrPostCallback queryTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertReviewOperationCompleted;
        
        private System.Threading.SendOrPostCallback RemoveReviewOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCityNotesOperationCompleted;
        
        private System.Threading.SendOrPostCallback StoreRouteOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRoutesOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchRoutesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::TestWebService.Properties.Settings.Default.TestWebService_WebService1_WebService1;
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
        public event getLocationCompletedEventHandler getLocationCompleted;
        
        /// <remarks/>
        public event GetAddress1CompletedEventHandler GetAddress1Completed;
        
        /// <remarks/>
        public event GetAddress2CompletedEventHandler GetAddress2Completed;
        
        /// <remarks/>
        public event queryTableCompletedEventHandler queryTableCompleted;
        
        /// <remarks/>
        public event InsertReviewCompletedEventHandler InsertReviewCompleted;
        
        /// <remarks/>
        public event RemoveReviewCompletedEventHandler RemoveReviewCompleted;
        
        /// <remarks/>
        public event getCityNotesCompletedEventHandler getCityNotesCompleted;
        
        /// <remarks/>
        public event StoreRouteCompletedEventHandler StoreRouteCompleted;
        
        /// <remarks/>
        public event GetRoutesCompletedEventHandler GetRoutesCompleted;
        
        /// <remarks/>
        public event SearchRoutesCompletedEventHandler SearchRoutesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getLocation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getLocation() {
            object[] results = this.Invoke("getLocation", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getLocationAsync() {
            this.getLocationAsync(null);
        }
        
        /// <remarks/>
        public void getLocationAsync(object userState) {
            if ((this.getLocationOperationCompleted == null)) {
                this.getLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLocationOperationCompleted);
            }
            this.InvokeAsync("getLocation", new object[0], this.getLocationOperationCompleted, userState);
        }
        
        private void OngetLocationOperationCompleted(object arg) {
            if ((this.getLocationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLocationCompleted(this, new getLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAddress1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAddress1() {
            object[] results = this.Invoke("GetAddress1", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAddress1Async() {
            this.GetAddress1Async(null);
        }
        
        /// <remarks/>
        public void GetAddress1Async(object userState) {
            if ((this.GetAddress1OperationCompleted == null)) {
                this.GetAddress1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAddress1OperationCompleted);
            }
            this.InvokeAsync("GetAddress1", new object[0], this.GetAddress1OperationCompleted, userState);
        }
        
        private void OnGetAddress1OperationCompleted(object arg) {
            if ((this.GetAddress1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAddress1Completed(this, new GetAddress1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAddress2", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAddress2() {
            object[] results = this.Invoke("GetAddress2", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAddress2Async() {
            this.GetAddress2Async(null);
        }
        
        /// <remarks/>
        public void GetAddress2Async(object userState) {
            if ((this.GetAddress2OperationCompleted == null)) {
                this.GetAddress2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAddress2OperationCompleted);
            }
            this.InvokeAsync("GetAddress2", new object[0], this.GetAddress2OperationCompleted, userState);
        }
        
        private void OnGetAddress2OperationCompleted(object arg) {
            if ((this.GetAddress2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAddress2Completed(this, new GetAddress2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/queryTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Review[] queryTable() {
            object[] results = this.Invoke("queryTable", new object[0]);
            return ((Review[])(results[0]));
        }
        
        /// <remarks/>
        public void queryTableAsync() {
            this.queryTableAsync(null);
        }
        
        /// <remarks/>
        public void queryTableAsync(object userState) {
            if ((this.queryTableOperationCompleted == null)) {
                this.queryTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnqueryTableOperationCompleted);
            }
            this.InvokeAsync("queryTable", new object[0], this.queryTableOperationCompleted, userState);
        }
        
        private void OnqueryTableOperationCompleted(object arg) {
            if ((this.queryTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.queryTableCompleted(this, new queryTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertReview", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertReview(string name, string age, string city, string reviewText) {
            object[] results = this.Invoke("InsertReview", new object[] {
                        name,
                        age,
                        city,
                        reviewText});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertReviewAsync(string name, string age, string city, string reviewText) {
            this.InsertReviewAsync(name, age, city, reviewText, null);
        }
        
        /// <remarks/>
        public void InsertReviewAsync(string name, string age, string city, string reviewText, object userState) {
            if ((this.InsertReviewOperationCompleted == null)) {
                this.InsertReviewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertReviewOperationCompleted);
            }
            this.InvokeAsync("InsertReview", new object[] {
                        name,
                        age,
                        city,
                        reviewText}, this.InsertReviewOperationCompleted, userState);
        }
        
        private void OnInsertReviewOperationCompleted(object arg) {
            if ((this.InsertReviewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertReviewCompleted(this, new InsertReviewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RemoveReview", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RemoveReview(string reviewName) {
            object[] results = this.Invoke("RemoveReview", new object[] {
                        reviewName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RemoveReviewAsync(string reviewName) {
            this.RemoveReviewAsync(reviewName, null);
        }
        
        /// <remarks/>
        public void RemoveReviewAsync(string reviewName, object userState) {
            if ((this.RemoveReviewOperationCompleted == null)) {
                this.RemoveReviewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveReviewOperationCompleted);
            }
            this.InvokeAsync("RemoveReview", new object[] {
                        reviewName}, this.RemoveReviewOperationCompleted, userState);
        }
        
        private void OnRemoveReviewOperationCompleted(object arg) {
            if ((this.RemoveReviewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveReviewCompleted(this, new RemoveReviewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCityNotes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCityNotes(string City) {
            object[] results = this.Invoke("getCityNotes", new object[] {
                        City});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCityNotesAsync(string City) {
            this.getCityNotesAsync(City, null);
        }
        
        /// <remarks/>
        public void getCityNotesAsync(string City, object userState) {
            if ((this.getCityNotesOperationCompleted == null)) {
                this.getCityNotesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCityNotesOperationCompleted);
            }
            this.InvokeAsync("getCityNotes", new object[] {
                        City}, this.getCityNotesOperationCompleted, userState);
        }
        
        private void OngetCityNotesOperationCompleted(object arg) {
            if ((this.getCityNotesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCityNotesCompleted(this, new getCityNotesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StoreRoute", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string StoreRoute(string data) {
            object[] results = this.Invoke("StoreRoute", new object[] {
                        data});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void StoreRouteAsync(string data) {
            this.StoreRouteAsync(data, null);
        }
        
        /// <remarks/>
        public void StoreRouteAsync(string data, object userState) {
            if ((this.StoreRouteOperationCompleted == null)) {
                this.StoreRouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStoreRouteOperationCompleted);
            }
            this.InvokeAsync("StoreRoute", new object[] {
                        data}, this.StoreRouteOperationCompleted, userState);
        }
        
        private void OnStoreRouteOperationCompleted(object arg) {
            if ((this.StoreRouteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StoreRouteCompleted(this, new StoreRouteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRoutes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RouteInfo[] GetRoutes() {
            object[] results = this.Invoke("GetRoutes", new object[0]);
            return ((RouteInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetRoutesAsync() {
            this.GetRoutesAsync(null);
        }
        
        /// <remarks/>
        public void GetRoutesAsync(object userState) {
            if ((this.GetRoutesOperationCompleted == null)) {
                this.GetRoutesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRoutesOperationCompleted);
            }
            this.InvokeAsync("GetRoutes", new object[0], this.GetRoutesOperationCompleted, userState);
        }
        
        private void OnGetRoutesOperationCompleted(object arg) {
            if ((this.GetRoutesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRoutesCompleted(this, new GetRoutesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchRoutes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RouteInfo[] SearchRoutes(string routename) {
            object[] results = this.Invoke("SearchRoutes", new object[] {
                        routename});
            return ((RouteInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void SearchRoutesAsync(string routename) {
            this.SearchRoutesAsync(routename, null);
        }
        
        /// <remarks/>
        public void SearchRoutesAsync(string routename, object userState) {
            if ((this.SearchRoutesOperationCompleted == null)) {
                this.SearchRoutesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchRoutesOperationCompleted);
            }
            this.InvokeAsync("SearchRoutes", new object[] {
                        routename}, this.SearchRoutesOperationCompleted, userState);
        }
        
        private void OnSearchRoutesOperationCompleted(object arg) {
            if ((this.SearchRoutesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchRoutesCompleted(this, new SearchRoutesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Review {
        
        private string nameField;
        
        private string ageField;
        
        private string cityField;
        
        private string reviewTextField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string ReviewText {
            get {
                return this.reviewTextField;
            }
            set {
                this.reviewTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Position {
        
        private string latField;
        
        private string lngField;
        
        private string titleField;
        
        private string descriptionField;
        
        private string imageUrlField;
        
        /// <remarks/>
        public string Lat {
            get {
                return this.latField;
            }
            set {
                this.latField = value;
            }
        }
        
        /// <remarks/>
        public string Lng {
            get {
                return this.lngField;
            }
            set {
                this.lngField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ImageUrl {
            get {
                return this.imageUrlField;
            }
            set {
                this.imageUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RouteInfo {
        
        private string routeNameField;
        
        private string routeModeField;
        
        private string descriptionField;
        
        private bool isFreeField;
        
        private string imageUrlField;
        
        private Position[] markerListField;
        
        /// <remarks/>
        public string RouteName {
            get {
                return this.routeNameField;
            }
            set {
                this.routeNameField = value;
            }
        }
        
        /// <remarks/>
        public string RouteMode {
            get {
                return this.routeModeField;
            }
            set {
                this.routeModeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public bool IsFree {
            get {
                return this.isFreeField;
            }
            set {
                this.isFreeField = value;
            }
        }
        
        /// <remarks/>
        public string ImageUrl {
            get {
                return this.imageUrlField;
            }
            set {
                this.imageUrlField = value;
            }
        }
        
        /// <remarks/>
        public Position[] MarkerList {
            get {
                return this.markerListField;
            }
            set {
                this.markerListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getLocationCompletedEventHandler(object sender, getLocationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetAddress1CompletedEventHandler(object sender, GetAddress1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAddress1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAddress1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetAddress2CompletedEventHandler(object sender, GetAddress2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAddress2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAddress2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void queryTableCompletedEventHandler(object sender, queryTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class queryTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal queryTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Review[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Review[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void InsertReviewCompletedEventHandler(object sender, InsertReviewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertReviewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertReviewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void RemoveReviewCompletedEventHandler(object sender, RemoveReviewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RemoveReviewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RemoveReviewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getCityNotesCompletedEventHandler(object sender, getCityNotesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCityNotesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCityNotesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void StoreRouteCompletedEventHandler(object sender, StoreRouteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StoreRouteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StoreRouteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetRoutesCompletedEventHandler(object sender, GetRoutesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRoutesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRoutesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RouteInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RouteInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void SearchRoutesCompletedEventHandler(object sender, SearchRoutesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchRoutesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchRoutesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RouteInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RouteInfo[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591