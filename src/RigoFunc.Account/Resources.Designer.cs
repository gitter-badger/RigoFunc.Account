﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RigoFunc.Account {
    using System;
    using System.Reflection;
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RigoFunc.Account.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Failed login with code [{0}] and phone number [{1}].
        /// </summary>
        internal static string LoginFailedWithCodeAndPhone {
            get {
                return ResourceManager.GetString("LoginFailedWithCodeAndPhone", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Cannot found the user by id [{0}].
        /// </summary>
        internal static string NotFoundUserById {
            get {
                return ResourceManager.GetString("NotFoundUserById", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Cannot found the user by phone number [{0}].
        /// </summary>
        internal static string NotFoundUserByPhoneNumber {
            get {
                return ResourceManager.GetString("NotFoundUserByPhoneNumber", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Failed to reset the password for user [{0}].
        /// </summary>
        internal static string PasswordResetFailed {
            get {
                return ResourceManager.GetString("PasswordResetFailed", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to The phone number [{0}] had been register.
        /// </summary>
        internal static string PhoneNumberHadBeenRegister {
            get {
                return ResourceManager.GetString("PhoneNumberHadBeenRegister", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Phone number or password error.
        /// </summary>
        internal static string PhoneNumberOrPasswordError {
            get {
                return ResourceManager.GetString("PhoneNumberOrPasswordError", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Cannot to register new user with phone [{0}] code [{1}].
        /// </summary>
        internal static string RegisterNewUserFailed {
            get {
                return ResourceManager.GetString("RegisterNewUserFailed", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Failed to send code to the phone [{0}], error message [{1}].
        /// </summary>
        internal static string SendCodeFailed {
            get {
                return ResourceManager.GetString("SendCodeFailed", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Failed to send the initial password to the phone [{0}].
        /// </summary>
        internal static string SendPasswordFailed {
            get {
                return ResourceManager.GetString("SendPasswordFailed", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Failed to update user.
        /// </summary>
        internal static string UpdateUserFailed {
            get {
                return ResourceManager.GetString("UpdateUserFailed", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to The code [{0}] is invalid or timeout with 3 minutes.
        /// </summary>
        internal static string VerifyCodeFailed {
            get {
                return ResourceManager.GetString("VerifyCodeFailed", resourceCulture);
            }
        }
    }
}