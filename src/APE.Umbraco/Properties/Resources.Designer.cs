﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APE.Umbraco.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APE.Umbraco.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SELECT Id, DatatypeNodeId, Value, Alias
        ///FROM cmsDataTypePreValues.
        /// </summary>
        internal static string CMSDataTypePreValuesSql {
            get {
                return ResourceManager.GetString("CMSDataTypePreValuesSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select un.Id, un.[Text] as ContentType,
        ///cpt.Alias as PropertyAlias,
        ///cpt.Description as PropertyDescription,
        ///un3.Text as PropertyType,
        ///cdt.PropertyEditorAlias as PropertyEditorAlias, cdt.nodeId as DataTypeId
        ///from umbracoNode un
        /// inner join cmspropertytype cpt on un.id = cpt.contentTypeId
        /// left join cmsdatatype cdt on cpt.dataTypeId = cdt.nodeId
        /// left join umbracoNode un3 on cpt.dataTypeId = un3.id
        ///where un.NodeObjectType = @contentTypeGuid
        ///and un.Id in ({0}).
        /// </summary>
        internal static string ContentTypePropertiesSql {
            get {
                return ResourceManager.GetString("ContentTypePropertiesSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select un.Id,
        ///un.ParentId as ParentId,
        ///un.[Text] as ContentType,
        ///cct.Alias as ContentTypeAlias,
        ///cct.Description as ContentTypeDescription
        ///from umbracoNode un
        ///inner join cmsContentType cct on un.id = cct.nodeId
        ///where un.NodeObjectType = @contentTypeGuid.
        /// </summary>
        internal static string ContentTypeSql {
            get {
                return ResourceManager.GetString("ContentTypeSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [key] FROM [cmsDictionary].
        /// </summary>
        internal static string DictionarySql {
            get {
                return ResourceManager.GetString("DictionarySql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select ct2ct.ChildContentTypeId, un.[Text] as ContentType, ct2ct.ParentContentTypeId as ParentId
        ///from umbracoNode un
        /// left join cmsContentType2ContentType ct2ct on un.id = ct2ct.ChildContentTypeId
        ///where un.NodeObjectType = @contentTypeGuid
        ///and un.Id = @id.
        /// </summary>
        internal static string InheritedContentTypeSql {
            get {
                return ResourceManager.GetString("InheritedContentTypeSql", resourceCulture);
            }
        }
    }
}
