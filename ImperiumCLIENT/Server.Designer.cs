﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImperiumCLIENT {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    internal sealed partial class Server : global::System.Configuration.ApplicationSettingsBase {
        
        private static Server defaultInstance = ((Server)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Server())));
        
        public static Server Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte ListenOnStartup {
            get {
                return ((byte)(this["ListenOnStartup"]));
            }
            set {
                this["ListenOnStartup"] = value;
            }
        }
    }
}
