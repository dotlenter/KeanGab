﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeanGabriel_RMS_SMS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=KeanGabrielHotlineDB;Integrated Se" +
            "curity=True")]
        public string KeanGabrielHotlineDBConnectionString {
            get {
                return ((string)(this["KeanGabrielHotlineDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=KGH_Logs;Integrated Security=True")]
        public string KGH_LogsConnectionString {
            get {
                return ((string)(this["KGH_LogsConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=keanGabrielDB;Integrated Security=" +
            "True")]
        public string keanGabrielDBConnectionString {
            get {
                return ((string)(this["keanGabrielDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MARC-MQ78R3B;Initial Catalog=keanGabrielDB;Integrated Security=True")]
        public string keanGabrielDBConnectionString1 {
            get {
                return ((string)(this["keanGabrielDBConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=JOHN-PC\\MSSSQLSERVER;Initial Catalog=keanGabrielDB;Integrated Securit" +
            "y=True")]
        public string keanGabrielDBConnectionString2 {
            get {
                return ((string)(this["keanGabrielDBConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=JOHN-PC\\MSSSQLSERVER;Initial Catalog=KGH_Logs;Integrated Security=Tru" +
            "e")]
        public string KGH_LogsConnectionString1 {
            get {
                return ((string)(this["KGH_LogsConnectionString1"]));
            }
        }
    }
}