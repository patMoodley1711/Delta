﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Delta.CertXplorer.Logging {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Delta.CertXplorer.Logging.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Impossible de lire le fichier de configuration.
        ///Section : {0}.
        /// </summary>
        internal static string CantReadConfigurationFileSection {
            get {
                return ResourceManager.GetString("CantReadConfigurationFileSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : Can&apos;t read configuration key {1}..
        /// </summary>
        internal static string CantReadConfigurationWithTypeAndKey {
            get {
                return ResourceManager.GetString("CantReadConfigurationWithTypeAndKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An initialization error occurred: {0}..
        /// </summary>
        internal static string InitializationError {
            get {
                return ResourceManager.GetString("InitializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid log level: {0}, defaulting to {1}..
        /// </summary>
        internal static string InvalidTraceLevel {
            get {
                return ResourceManager.GetString("InvalidTraceLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid output path: {0}, defaulting to {1}..
        /// </summary>
        internal static string InvalidTracePath {
            get {
                return ResourceManager.GetString("InvalidTracePath", resourceCulture);
            }
        }
    }
}
