﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
    
    private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
    
    public static Settings1 Default {
        get {
            return defaultInstance;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("")]
    public string EndpointID {
        get {
            return ((string)(this["EndpointID"]));
        }
        set {
            this["EndpointID"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("")]
    public string SubscriptionKey {
        get {
            return ((string)(this["SubscriptionKey"]));
        }
        set {
            this["SubscriptionKey"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool ShowConfidence {
        get {
            return ((bool)(this["ShowConfidence"]));
        }
        set {
            this["ShowConfidence"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("")]
    public string Region {
        get {
            return ((string)(this["Region"]));
        }
        set {
            this["Region"] = value;
        }
    }
}
