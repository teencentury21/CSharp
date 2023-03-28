﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CSharpConsole.DARFON.GAIAGetEmp {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GetEmpWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class GetEmpWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private AuthHeader authHeaderValueField;
        
        private System.Threading.SendOrPostCallback GetEmpByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEmpByEmpNoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GetEmpWebService() {
            this.Url = global::CSharpConsole.Properties.Settings.Default.CSharpConsole_DARFON_GAIAGetEmp_GetEmpWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public AuthHeader AuthHeaderValue {
            get {
                return this.authHeaderValueField;
            }
            set {
                this.authHeaderValueField = value;
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
        public event GetEmpByNameCompletedEventHandler GetEmpByNameCompleted;
        
        /// <remarks/>
        public event GetEmpByEmpNoCompletedEventHandler GetEmpByEmpNoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmpByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EmpEntity[] GetEmpByName(string lang, string name) {
            object[] results = this.Invoke("GetEmpByName", new object[] {
                        lang,
                        name});
            return ((EmpEntity[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmpByNameAsync(string lang, string name) {
            this.GetEmpByNameAsync(lang, name, null);
        }
        
        /// <remarks/>
        public void GetEmpByNameAsync(string lang, string name, object userState) {
            if ((this.GetEmpByNameOperationCompleted == null)) {
                this.GetEmpByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmpByNameOperationCompleted);
            }
            this.InvokeAsync("GetEmpByName", new object[] {
                        lang,
                        name}, this.GetEmpByNameOperationCompleted, userState);
        }
        
        private void OnGetEmpByNameOperationCompleted(object arg) {
            if ((this.GetEmpByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmpByNameCompleted(this, new GetEmpByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEmpByEmpNo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EmpEntity GetEmpByEmpNo(string empNo) {
            object[] results = this.Invoke("GetEmpByEmpNo", new object[] {
                        empNo});
            return ((EmpEntity)(results[0]));
        }
        
        /// <remarks/>
        public void GetEmpByEmpNoAsync(string empNo) {
            this.GetEmpByEmpNoAsync(empNo, null);
        }
        
        /// <remarks/>
        public void GetEmpByEmpNoAsync(string empNo, object userState) {
            if ((this.GetEmpByEmpNoOperationCompleted == null)) {
                this.GetEmpByEmpNoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmpByEmpNoOperationCompleted);
            }
            this.InvokeAsync("GetEmpByEmpNo", new object[] {
                        empNo}, this.GetEmpByEmpNoOperationCompleted, userState);
        }
        
        private void OnGetEmpByEmpNoOperationCompleted(object arg) {
            if ((this.GetEmpByEmpNoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmpByEmpNoCompleted(this, new GetEmpByEmpNoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class AuthHeader : System.Web.Services.Protocols.SoapHeader {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EmpEntity {
        
        private string gAIAIdField;
        
        private string empIdField;
        
        private string empNoField;
        
        private string nameField;
        
        private string enNameField;
        
        private string emailField;
        
        private string siteField;
        
        private string extNoField;
        
        private string isDLField;
        
        private int isActiveField;
        
        private string remarkField;
        
        /// <remarks/>
        public string GAIAId {
            get {
                return this.gAIAIdField;
            }
            set {
                this.gAIAIdField = value;
            }
        }
        
        /// <remarks/>
        public string EmpId {
            get {
                return this.empIdField;
            }
            set {
                this.empIdField = value;
            }
        }
        
        /// <remarks/>
        public string EmpNo {
            get {
                return this.empNoField;
            }
            set {
                this.empNoField = value;
            }
        }
        
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
        public string EnName {
            get {
                return this.enNameField;
            }
            set {
                this.enNameField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Site {
            get {
                return this.siteField;
            }
            set {
                this.siteField = value;
            }
        }
        
        /// <remarks/>
        public string ExtNo {
            get {
                return this.extNoField;
            }
            set {
                this.extNoField = value;
            }
        }
        
        /// <remarks/>
        public string IsDL {
            get {
                return this.isDLField;
            }
            set {
                this.isDLField = value;
            }
        }
        
        /// <remarks/>
        public int IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        public string remark {
            get {
                return this.remarkField;
            }
            set {
                this.remarkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetEmpByNameCompletedEventHandler(object sender, GetEmpByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmpByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmpByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmpEntity[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmpEntity[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetEmpByEmpNoCompletedEventHandler(object sender, GetEmpByEmpNoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmpByEmpNoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmpByEmpNoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmpEntity Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmpEntity)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591