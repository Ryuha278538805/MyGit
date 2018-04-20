﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.296 版自动生成。
// 
#pragma warning disable 1591

namespace UpLoadFileV2.com.haocw.images {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UpLoadSoap", Namespace="http://images.haocw.com")]
    public partial class UpLoad : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FileServerUrlOperationCompleted;
        
        private System.Threading.SendOrPostCallback FileServerDirOperationCompleted;
        
        private System.Threading.SendOrPostCallback FileFormatOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadFileOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UpLoad() {
            this.Url = global::UpLoadFileV2.Properties.Settings.Default.UpLoadFileV2_com_haocw_images_UpLoad;
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
        public event FileServerUrlCompletedEventHandler FileServerUrlCompleted;
        
        /// <remarks/>
        public event FileServerDirCompletedEventHandler FileServerDirCompleted;
        
        /// <remarks/>
        public event FileFormatCompletedEventHandler FileFormatCompleted;
        
        /// <remarks/>
        public event UploadFileCompletedEventHandler UploadFileCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://images.haocw.com/FileServerUrl", RequestNamespace="http://images.haocw.com", ResponseNamespace="http://images.haocw.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FileServerUrl() {
            object[] results = this.Invoke("FileServerUrl", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FileServerUrlAsync() {
            this.FileServerUrlAsync(null);
        }
        
        /// <remarks/>
        public void FileServerUrlAsync(object userState) {
            if ((this.FileServerUrlOperationCompleted == null)) {
                this.FileServerUrlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFileServerUrlOperationCompleted);
            }
            this.InvokeAsync("FileServerUrl", new object[0], this.FileServerUrlOperationCompleted, userState);
        }
        
        private void OnFileServerUrlOperationCompleted(object arg) {
            if ((this.FileServerUrlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FileServerUrlCompleted(this, new FileServerUrlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://images.haocw.com/FileServerDir", RequestNamespace="http://images.haocw.com", ResponseNamespace="http://images.haocw.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FileServerDir() {
            object[] results = this.Invoke("FileServerDir", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FileServerDirAsync() {
            this.FileServerDirAsync(null);
        }
        
        /// <remarks/>
        public void FileServerDirAsync(object userState) {
            if ((this.FileServerDirOperationCompleted == null)) {
                this.FileServerDirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFileServerDirOperationCompleted);
            }
            this.InvokeAsync("FileServerDir", new object[0], this.FileServerDirOperationCompleted, userState);
        }
        
        private void OnFileServerDirOperationCompleted(object arg) {
            if ((this.FileServerDirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FileServerDirCompleted(this, new FileServerDirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://images.haocw.com/FileFormat", RequestNamespace="http://images.haocw.com", ResponseNamespace="http://images.haocw.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FileFormat() {
            object[] results = this.Invoke("FileFormat", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FileFormatAsync() {
            this.FileFormatAsync(null);
        }
        
        /// <remarks/>
        public void FileFormatAsync(object userState) {
            if ((this.FileFormatOperationCompleted == null)) {
                this.FileFormatOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFileFormatOperationCompleted);
            }
            this.InvokeAsync("FileFormat", new object[0], this.FileFormatOperationCompleted, userState);
        }
        
        private void OnFileFormatOperationCompleted(object arg) {
            if ((this.FileFormatCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FileFormatCompleted(this, new FileFormatCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://images.haocw.com/UploadFile", RequestNamespace="http://images.haocw.com", ResponseNamespace="http://images.haocw.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UploadFile([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] fs, string Path, string FileName) {
            object[] results = this.Invoke("UploadFile", new object[] {
                        fs,
                        Path,
                        FileName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UploadFileAsync(byte[] fs, string Path, string FileName) {
            this.UploadFileAsync(fs, Path, FileName, null);
        }
        
        /// <remarks/>
        public void UploadFileAsync(byte[] fs, string Path, string FileName, object userState) {
            if ((this.UploadFileOperationCompleted == null)) {
                this.UploadFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadFileOperationCompleted);
            }
            this.InvokeAsync("UploadFile", new object[] {
                        fs,
                        Path,
                        FileName}, this.UploadFileOperationCompleted, userState);
        }
        
        private void OnUploadFileOperationCompleted(object arg) {
            if ((this.UploadFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadFileCompleted(this, new UploadFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void FileServerUrlCompletedEventHandler(object sender, FileServerUrlCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileServerUrlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FileServerUrlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void FileServerDirCompletedEventHandler(object sender, FileServerDirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileServerDirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FileServerDirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void FileFormatCompletedEventHandler(object sender, FileFormatCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileFormatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FileFormatCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void UploadFileCompletedEventHandler(object sender, UploadFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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