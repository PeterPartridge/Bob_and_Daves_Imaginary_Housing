﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataLayer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AddressId,adress number, lineOne,lineTwo,lineThree,lineFour,lineFive,Postcode,isUsed
        ///ff44378a-fe47-4526-bf23-6f7217e5f81f,10,Imag road,,,,Imagination City,890 -=+tr,true
        ///3f4e5491-f4e6-477a-a145-a12b990b29f1,12,Imag road,,,,Imagination City,890 -=+tr,true
        ///e3944055-9df7-4ad7-b36a-84bcd00ee1b4,34,Imag road,,,,Imagination City,890 -=+tr,true.
        /// </summary>
        internal static string OurAddresses {
            get {
                return ResourceManager.GetString("OurAddresses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PropertyId,AddressId,Property Type,Owner
        ///0788743a-c729-4d1b-9c8f-626ae48a0134,ff44378a-fe47-4526-bf23-6f7217e5f81f,FreeHold,Bob and Daves Imaginary Housing LTD
        ///6905f139-6705-4ed8-87d7-34b5bc3fb0d6,3f4e5491-f4e6-477a-a145-a12b990b29f1,FreeHold,Bob and Daves Imaginary Housing LTD
        ///909b2df6-ec3c-4f1b-a9c2-5725e8a9d2f8,e3944055-9df7-4ad7-b36a-84bcd00ee1b4,LeaseHold,Imagination Council.
        /// </summary>
        internal static string OurPropertis {
            get {
                return ResourceManager.GetString("OurPropertis", resourceCulture);
            }
        }
    }
}