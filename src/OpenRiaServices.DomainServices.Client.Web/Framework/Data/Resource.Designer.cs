﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.DomainServices.Client.Web {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.DomainServices.Client.Web.Data.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to The current application or application host is null and the host URI cannot be determined..
        /// </summary>
        internal static string DomainClient_UnableToDetermineHostUri {
            get {
                return ResourceManager.GetString("DomainClient_UnableToDetermineHostUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PoxBinaryMessageEncoder only supports content type {0}..
        /// </summary>
        internal static string PoxBinaryMessageEncoder_InvalidContentType {
            get {
                return ResourceManager.GetString("PoxBinaryMessageEncoder_InvalidContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message has MessageVersion {0} but the encoder is configured for MessageVersion {1}..
        /// </summary>
        internal static string PoxBinaryMessageEncoder_InvalidMessageVersion {
            get {
                return ResourceManager.GetString("PoxBinaryMessageEncoder_InvalidMessageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PoxBinaryMessageEncoder only supports MessageVersion.None..
        /// </summary>
        internal static string PoxBinaryMessageEncoder_MessageVersionNotSupported {
            get {
                return ResourceManager.GetString("PoxBinaryMessageEncoder_MessageVersionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service URI is not correctly formatted..
        /// </summary>
        internal static string WebDomainClient_InvalidServiceUri {
            get {
                return ResourceManager.GetString("WebDomainClient_InvalidServiceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum URI length of {0} was exceeded..
        /// </summary>
        internal static string WebDomainClient_MaximumUriLengthExceeded {
            get {
                return ResourceManager.GetString("WebDomainClient_MaximumUriLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string WebDomainClient_OperationDoesNotExist {
            get {
                return ResourceManager.GetString("WebDomainClient_OperationDoesNotExist", resourceCulture);
            }
        }
    }
}
