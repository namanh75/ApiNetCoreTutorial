﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MISA.WEB07.TNANH.MultiLayer.Common.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MISA.WEB07.TNANH.MultiLayer.Common.Resources.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ngày được chọn không được lớn hơn ngày hiện tại.
        /// </summary>
        public static string Error_UserMessage_Date {
            get {
                return ResourceManager.GetString("Error_UserMessage_Date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số hiệu cán bộ đã tồn tại trong hệ thống.
        /// </summary>
        public static string Error_UserMessage_DuplicateCode {
            get {
                return ResourceManager.GetString("Error_UserMessage_DuplicateCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email sai định dạng.
        /// </summary>
        public static string Error_UserMessage_Email {
            get {
                return ResourceManager.GetString("Error_UserMessage_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã nhân viên không được để trống.
        /// </summary>
        public static string Error_UserMessage_EmptyCode {
            get {
                return ResourceManager.GetString("Error_UserMessage_EmptyCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Có lỗi xảy ra, vui lòng liên hệ MISA.
        /// </summary>
        public static string Error_UserMessage_Exception {
            get {
                return ResourceManager.GetString("Error_UserMessage_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dữ liệu đầu vào không hợp lệ.
        /// </summary>
        public static string Error_UserMessage_Invalid {
            get {
                return ResourceManager.GetString("Error_UserMessage_Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Họ tên nhân viên không được bỏ trống.
        /// </summary>
        public static string Error_UserMessage_OfficerName {
            get {
                return ResourceManager.GetString("Error_UserMessage_OfficerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại sai định dạng.
        /// </summary>
        public static string Error_UserMessage_PhoneNumber {
            get {
                return ResourceManager.GetString("Error_UserMessage_PhoneNumber", resourceCulture);
            }
        }
    }
}
