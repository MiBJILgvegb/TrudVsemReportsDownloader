﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrudVsemReportsDownloader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://opendata.trudvsem.ru/csv/vacancy_9.csv")]
        public string _link {
            get {
                return ((string)(this["_link"]));
            }
            set {
                this["_link"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vacancy_9_result.xlsx")]
        public string _resultsFilename {
            get {
                return ((string)(this["_resultsFilename"]));
            }
            set {
                this["_resultsFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\загрузки\\")]
        public string _destinationFolder {
            get {
                return ((string)(this["_destinationFolder"]));
            }
            set {
                this["_destinationFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("|")]
        public string _csvDelimiter {
            get {
                return ((string)(this["_csvDelimiter"]));
            }
            set {
                this["_csvDelimiter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("state_region_code")]
        public string _filterColumn {
            get {
                return ((string)(this["_filterColumn"]));
            }
            set {
                this["_filterColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3100000000000")]
        public string _filterValue {
            get {
                return ((string)(this["_filterValue"]));
            }
            set {
                this["_filterValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\загрузки\\")]
        public string _resultsFolder {
            get {
                return ((string)(this["_resultsFolder"]));
            }
            set {
                this["_resultsFolder"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("full_company_name,vacancy_name,work_places,vacancy_address,salary,salary_max,educ" +
            "ation,position_responsibilities,position_requirements,busy_type,company_inn")]
        public string _resultedColumns {
            get {
                return ((string)(this["_resultedColumns"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string _companyesInn {
            get {
                return ((string)(this["_companyesInn"]));
            }
            set {
                this["_companyesInn"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Наименование организации,Профессия,Количество свободных раб.мест,Адрес,Заработная" +
            " плата от,Заработная плата до,Образование,Должностные обязанности,Требования,Зан" +
            "ятость,ИНН")]
        public string _defaultHeaderRow {
            get {
                return ((string)(this["_defaultHeaderRow"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(";")]
        public string _defaultXLSDelimiter {
            get {
                return ((string)(this["_defaultXLSDelimiter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("company_inn")]
        public string _innColumnName {
            get {
                return ((string)(this["_innColumnName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("23,22,15,24,11,11,15,24,23,18,15")]
        public string _defaultResultColWidth {
            get {
                return ((string)(this["_defaultResultColWidth"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool _resultFilenameAppendDate {
            get {
                return ((bool)(this["_resultFilenameAppendDate"]));
            }
            set {
                this["_resultFilenameAppendDate"] = value;
            }
        }
    }
}
