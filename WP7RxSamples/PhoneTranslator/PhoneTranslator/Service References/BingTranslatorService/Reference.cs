﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace PhoneTranslator.BingTranslatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", ConfigurationName="BingTranslatorService.LanguageService")]
    public interface LanguageService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguages", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguagesRespon" +
            "se")]
        System.IAsyncResult BeginGetLanguages(PhoneTranslator.BingTranslatorService.GetLanguagesRequest request, System.AsyncCallback callback, object asyncState);
        
        PhoneTranslator.BingTranslatorService.GetLanguagesResponse EndGetLanguages(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNamesRe" +
            "sponse")]
        System.IAsyncResult BeginGetLanguageNames(PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request, System.AsyncCallback callback, object asyncState);
        
        PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse EndGetLanguageNames(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/DetectResponse")]
        System.IAsyncResult BeginDetect(PhoneTranslator.BingTranslatorService.DetectRequest request, System.AsyncCallback callback, object asyncState);
        
        PhoneTranslator.BingTranslatorService.DetectResponse EndDetect(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/TranslateResponse")]
        System.IAsyncResult BeginTranslate(PhoneTranslator.BingTranslatorService.TranslateRequest request, System.AsyncCallback callback, object asyncState);
        
        PhoneTranslator.BingTranslatorService.TranslateResponse EndTranslate(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguages", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        public GetLanguagesRequest() {
        }
        
        public GetLanguagesRequest(string appId) {
            this.appId = appId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguagesResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguagesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<string> GetLanguagesResult;
        
        public GetLanguagesResponse() {
        }
        
        public GetLanguagesResponse(System.Collections.ObjectModel.ObservableCollection<string> GetLanguagesResult) {
            this.GetLanguagesResult = GetLanguagesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguageNames", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguageNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string locale;
        
        public GetLanguageNamesRequest() {
        }
        
        public GetLanguageNamesRequest(string appId, string locale) {
            this.appId = appId;
            this.locale = locale;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguageNamesResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguageNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<string> GetLanguageNamesResult;
        
        public GetLanguageNamesResponse() {
        }
        
        public GetLanguageNamesResponse(System.Collections.ObjectModel.ObservableCollection<string> GetLanguageNamesResult) {
            this.GetLanguageNamesResult = GetLanguageNamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Detect", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class DetectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string text;
        
        public DetectRequest() {
        }
        
        public DetectRequest(string appId, string text) {
            this.appId = appId;
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DetectResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class DetectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string DetectResult;
        
        public DetectResponse() {
        }
        
        public DetectResponse(string DetectResult) {
            this.DetectResult = DetectResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Translate", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class TranslateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string text;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=2)]
        public string from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=3)]
        public string to;
        
        public TranslateRequest() {
        }
        
        public TranslateRequest(string appId, string text, string from, string to) {
            this.appId = appId;
            this.text = text;
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TranslateResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class TranslateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string TranslateResult;
        
        public TranslateResponse() {
        }
        
        public TranslateResponse(string TranslateResult) {
            this.TranslateResult = TranslateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LanguageServiceChannel : PhoneTranslator.BingTranslatorService.LanguageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetLanguagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetLanguagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public PhoneTranslator.BingTranslatorService.GetLanguagesResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((PhoneTranslator.BingTranslatorService.GetLanguagesResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetLanguageNamesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetLanguageNamesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DetectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DetectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public PhoneTranslator.BingTranslatorService.DetectResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((PhoneTranslator.BingTranslatorService.DetectResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TranslateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TranslateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public PhoneTranslator.BingTranslatorService.TranslateResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((PhoneTranslator.BingTranslatorService.TranslateResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LanguageServiceClient : System.ServiceModel.ClientBase<PhoneTranslator.BingTranslatorService.LanguageService>, PhoneTranslator.BingTranslatorService.LanguageService {
        
        private BeginOperationDelegate onBeginGetLanguagesDelegate;
        
        private EndOperationDelegate onEndGetLanguagesDelegate;
        
        private System.Threading.SendOrPostCallback onGetLanguagesCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetLanguageNamesDelegate;
        
        private EndOperationDelegate onEndGetLanguageNamesDelegate;
        
        private System.Threading.SendOrPostCallback onGetLanguageNamesCompletedDelegate;
        
        private BeginOperationDelegate onBeginDetectDelegate;
        
        private EndOperationDelegate onEndDetectDelegate;
        
        private System.Threading.SendOrPostCallback onDetectCompletedDelegate;
        
        private BeginOperationDelegate onBeginTranslateDelegate;
        
        private EndOperationDelegate onEndTranslateDelegate;
        
        private System.Threading.SendOrPostCallback onTranslateCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public LanguageServiceClient() {
        }
        
        public LanguageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetLanguagesCompletedEventArgs> GetLanguagesCompleted;
        
        public event System.EventHandler<GetLanguageNamesCompletedEventArgs> GetLanguageNamesCompleted;
        
        public event System.EventHandler<DetectCompletedEventArgs> DetectCompleted;
        
        public event System.EventHandler<TranslateCompletedEventArgs> TranslateCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneTranslator.BingTranslatorService.LanguageService.BeginGetLanguages(PhoneTranslator.BingTranslatorService.GetLanguagesRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetLanguages(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PhoneTranslator.BingTranslatorService.GetLanguagesResponse PhoneTranslator.BingTranslatorService.LanguageService.EndGetLanguages(System.IAsyncResult result) {
            return base.Channel.EndGetLanguages(result);
        }
        
        private System.IAsyncResult OnBeginGetLanguages(object[] inValues, System.AsyncCallback callback, object asyncState) {
            PhoneTranslator.BingTranslatorService.GetLanguagesRequest request = ((PhoneTranslator.BingTranslatorService.GetLanguagesRequest)(inValues[0]));
            return ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).BeginGetLanguages(request, callback, asyncState);
        }
        
        private object[] OnEndGetLanguages(System.IAsyncResult result) {
            PhoneTranslator.BingTranslatorService.GetLanguagesResponse retVal = ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).EndGetLanguages(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetLanguagesCompleted(object state) {
            if ((this.GetLanguagesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetLanguagesCompleted(this, new GetLanguagesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetLanguagesAsync(PhoneTranslator.BingTranslatorService.GetLanguagesRequest request) {
            this.GetLanguagesAsync(request, null);
        }
        
        public void GetLanguagesAsync(PhoneTranslator.BingTranslatorService.GetLanguagesRequest request, object userState) {
            if ((this.onBeginGetLanguagesDelegate == null)) {
                this.onBeginGetLanguagesDelegate = new BeginOperationDelegate(this.OnBeginGetLanguages);
            }
            if ((this.onEndGetLanguagesDelegate == null)) {
                this.onEndGetLanguagesDelegate = new EndOperationDelegate(this.OnEndGetLanguages);
            }
            if ((this.onGetLanguagesCompletedDelegate == null)) {
                this.onGetLanguagesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetLanguagesCompleted);
            }
            base.InvokeAsync(this.onBeginGetLanguagesDelegate, new object[] {
                        request}, this.onEndGetLanguagesDelegate, this.onGetLanguagesCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneTranslator.BingTranslatorService.LanguageService.BeginGetLanguageNames(PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetLanguageNames(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse PhoneTranslator.BingTranslatorService.LanguageService.EndGetLanguageNames(System.IAsyncResult result) {
            return base.Channel.EndGetLanguageNames(result);
        }
        
        private System.IAsyncResult OnBeginGetLanguageNames(object[] inValues, System.AsyncCallback callback, object asyncState) {
            PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request = ((PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest)(inValues[0]));
            return ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).BeginGetLanguageNames(request, callback, asyncState);
        }
        
        private object[] OnEndGetLanguageNames(System.IAsyncResult result) {
            PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse retVal = ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).EndGetLanguageNames(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetLanguageNamesCompleted(object state) {
            if ((this.GetLanguageNamesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetLanguageNamesCompleted(this, new GetLanguageNamesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetLanguageNamesAsync(PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request) {
            this.GetLanguageNamesAsync(request, null);
        }
        
        public void GetLanguageNamesAsync(PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request, object userState) {
            if ((this.onBeginGetLanguageNamesDelegate == null)) {
                this.onBeginGetLanguageNamesDelegate = new BeginOperationDelegate(this.OnBeginGetLanguageNames);
            }
            if ((this.onEndGetLanguageNamesDelegate == null)) {
                this.onEndGetLanguageNamesDelegate = new EndOperationDelegate(this.OnEndGetLanguageNames);
            }
            if ((this.onGetLanguageNamesCompletedDelegate == null)) {
                this.onGetLanguageNamesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetLanguageNamesCompleted);
            }
            base.InvokeAsync(this.onBeginGetLanguageNamesDelegate, new object[] {
                        request}, this.onEndGetLanguageNamesDelegate, this.onGetLanguageNamesCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneTranslator.BingTranslatorService.LanguageService.BeginDetect(PhoneTranslator.BingTranslatorService.DetectRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDetect(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PhoneTranslator.BingTranslatorService.DetectResponse PhoneTranslator.BingTranslatorService.LanguageService.EndDetect(System.IAsyncResult result) {
            return base.Channel.EndDetect(result);
        }
        
        private System.IAsyncResult OnBeginDetect(object[] inValues, System.AsyncCallback callback, object asyncState) {
            PhoneTranslator.BingTranslatorService.DetectRequest request = ((PhoneTranslator.BingTranslatorService.DetectRequest)(inValues[0]));
            return ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).BeginDetect(request, callback, asyncState);
        }
        
        private object[] OnEndDetect(System.IAsyncResult result) {
            PhoneTranslator.BingTranslatorService.DetectResponse retVal = ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).EndDetect(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDetectCompleted(object state) {
            if ((this.DetectCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DetectCompleted(this, new DetectCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DetectAsync(PhoneTranslator.BingTranslatorService.DetectRequest request) {
            this.DetectAsync(request, null);
        }
        
        public void DetectAsync(PhoneTranslator.BingTranslatorService.DetectRequest request, object userState) {
            if ((this.onBeginDetectDelegate == null)) {
                this.onBeginDetectDelegate = new BeginOperationDelegate(this.OnBeginDetect);
            }
            if ((this.onEndDetectDelegate == null)) {
                this.onEndDetectDelegate = new EndOperationDelegate(this.OnEndDetect);
            }
            if ((this.onDetectCompletedDelegate == null)) {
                this.onDetectCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDetectCompleted);
            }
            base.InvokeAsync(this.onBeginDetectDelegate, new object[] {
                        request}, this.onEndDetectDelegate, this.onDetectCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneTranslator.BingTranslatorService.LanguageService.BeginTranslate(PhoneTranslator.BingTranslatorService.TranslateRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTranslate(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PhoneTranslator.BingTranslatorService.TranslateResponse PhoneTranslator.BingTranslatorService.LanguageService.EndTranslate(System.IAsyncResult result) {
            return base.Channel.EndTranslate(result);
        }
        
        private System.IAsyncResult OnBeginTranslate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            PhoneTranslator.BingTranslatorService.TranslateRequest request = ((PhoneTranslator.BingTranslatorService.TranslateRequest)(inValues[0]));
            return ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).BeginTranslate(request, callback, asyncState);
        }
        
        private object[] OnEndTranslate(System.IAsyncResult result) {
            PhoneTranslator.BingTranslatorService.TranslateResponse retVal = ((PhoneTranslator.BingTranslatorService.LanguageService)(this)).EndTranslate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTranslateCompleted(object state) {
            if ((this.TranslateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TranslateCompleted(this, new TranslateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TranslateAsync(PhoneTranslator.BingTranslatorService.TranslateRequest request) {
            this.TranslateAsync(request, null);
        }
        
        public void TranslateAsync(PhoneTranslator.BingTranslatorService.TranslateRequest request, object userState) {
            if ((this.onBeginTranslateDelegate == null)) {
                this.onBeginTranslateDelegate = new BeginOperationDelegate(this.OnBeginTranslate);
            }
            if ((this.onEndTranslateDelegate == null)) {
                this.onEndTranslateDelegate = new EndOperationDelegate(this.OnEndTranslate);
            }
            if ((this.onTranslateCompletedDelegate == null)) {
                this.onTranslateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTranslateCompleted);
            }
            base.InvokeAsync(this.onBeginTranslateDelegate, new object[] {
                        request}, this.onEndTranslateDelegate, this.onTranslateCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override PhoneTranslator.BingTranslatorService.LanguageService CreateChannel() {
            return new LanguageServiceClientChannel(this);
        }
        
        private class LanguageServiceClientChannel : ChannelBase<PhoneTranslator.BingTranslatorService.LanguageService>, PhoneTranslator.BingTranslatorService.LanguageService {
            
            public LanguageServiceClientChannel(System.ServiceModel.ClientBase<PhoneTranslator.BingTranslatorService.LanguageService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetLanguages(PhoneTranslator.BingTranslatorService.GetLanguagesRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetLanguages", _args, callback, asyncState);
                return _result;
            }
            
            public PhoneTranslator.BingTranslatorService.GetLanguagesResponse EndGetLanguages(System.IAsyncResult result) {
                object[] _args = new object[0];
                PhoneTranslator.BingTranslatorService.GetLanguagesResponse _result = ((PhoneTranslator.BingTranslatorService.GetLanguagesResponse)(base.EndInvoke("GetLanguages", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetLanguageNames(PhoneTranslator.BingTranslatorService.GetLanguageNamesRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetLanguageNames", _args, callback, asyncState);
                return _result;
            }
            
            public PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse EndGetLanguageNames(System.IAsyncResult result) {
                object[] _args = new object[0];
                PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse _result = ((PhoneTranslator.BingTranslatorService.GetLanguageNamesResponse)(base.EndInvoke("GetLanguageNames", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDetect(PhoneTranslator.BingTranslatorService.DetectRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Detect", _args, callback, asyncState);
                return _result;
            }
            
            public PhoneTranslator.BingTranslatorService.DetectResponse EndDetect(System.IAsyncResult result) {
                object[] _args = new object[0];
                PhoneTranslator.BingTranslatorService.DetectResponse _result = ((PhoneTranslator.BingTranslatorService.DetectResponse)(base.EndInvoke("Detect", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginTranslate(PhoneTranslator.BingTranslatorService.TranslateRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Translate", _args, callback, asyncState);
                return _result;
            }
            
            public PhoneTranslator.BingTranslatorService.TranslateResponse EndTranslate(System.IAsyncResult result) {
                object[] _args = new object[0];
                PhoneTranslator.BingTranslatorService.TranslateResponse _result = ((PhoneTranslator.BingTranslatorService.TranslateResponse)(base.EndInvoke("Translate", _args, result)));
                return _result;
            }
        }
    }
}
