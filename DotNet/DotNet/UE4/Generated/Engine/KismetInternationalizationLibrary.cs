// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Kismet Internationalization Library</summary>
    public unsafe partial class KismetInternationalizationLibrary : BlueprintFunctionLibrary  {

        ///<summary>Clear the given asset group category culture.</summary>
        ///<remarks>
        ///@param AssetGroup The asset group to clear the culture for.
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///</remarks>
        public static void ClearCurrentAssetGroupCulture(Name AssetGroup, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.ClearCurrentAssetGroupCulture_method.Invoke(AssetGroup, SaveToConfig);

        ///<summary>Get the given asset group category culture.</summary>
        ///<remarks>
        ///@note Returns the current language if the group category doesn't have a culture override.
        ///@param AssetGroup The asset group to get the culture for.
        ///@return The culture as an IETF language tag (eg, "zh-Hans-CN").
        ///</remarks>
        public static string GetCurrentAssetGroupCulture(Name AssetGroup)  => 
            KismetInternationalizationLibrary_methods.GetCurrentAssetGroupCulture_method.Invoke(AssetGroup);

        ///<summary>
        ///Get the current culture as an IETF language tag:
        /// - A two-letter ISO 639-1 language code (eg, "zh").
        ///</summary>
        ///<remarks>
        ///- An optional four-letter ISO 15924 script code (eg, "Hans").
        /// - An optional two-letter ISO 3166-1 country code (eg, "CN").
        ///@note This function exists for legacy API parity with SetCurrentCulture and is equivalent to GetCurrentLanguage.
        ///@return The culture as an IETF language tag (eg, "zh-Hans-CN").
        ///</remarks>
        public static string GetCurrentCulture()  => 
            KismetInternationalizationLibrary_methods.GetCurrentCulture_method.Invoke();

        ///<summary>
        ///Get the current language (for localization) as an IETF language tag:
        /// - A two-letter ISO 639-1 language code (eg, "zh").
        ///</summary>
        ///<remarks>
        ///- An optional four-letter ISO 15924 script code (eg, "Hans").
        /// - An optional two-letter ISO 3166-1 country code (eg, "CN").
        ///@return The language as an IETF language tag (eg, "zh-Hans-CN").
        ///</remarks>
        public static string GetCurrentLanguage()  => 
            KismetInternationalizationLibrary_methods.GetCurrentLanguage_method.Invoke();

        ///<summary>
        ///Get the current locale (for internationalization) as an IETF language tag:
        /// - A two-letter ISO 639-1 language code (eg, "zh").
        ///</summary>
        ///<remarks>
        ///- An optional four-letter ISO 15924 script code (eg, "Hans").
        /// - An optional two-letter ISO 3166-1 country code (eg, "CN").
        ///@return The locale as an IETF language tag (eg, "zh-Hans-CN").
        ///</remarks>
        public static string GetCurrentLocale()  => 
            KismetInternationalizationLibrary_methods.GetCurrentLocale_method.Invoke();

        ///<summary>Set the given asset group category culture from an IETF language tag (eg, "zh-Hans-CN").</summary>
        ///<remarks>
        ///@param AssetGroup The asset group to set the culture for.
        ///@param Culture The culture to set, as an IETF language tag (eg, "zh-Hans-CN").
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///@return True if the culture was set, false otherwise.
        ///</remarks>
        public static bool SetCurrentAssetGroupCulture(Name AssetGroup, string Culture, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.SetCurrentAssetGroupCulture_method.Invoke(AssetGroup, Culture, SaveToConfig);

        ///<summary>Set the current culture.</summary>
        ///<remarks>
        ///@note This function is a sledgehammer, and will set both the language and locale, as well as clear out any asset group cultures that may be set.
        ///@param Culture The culture to set, as an IETF language tag (eg, "zh-Hans-CN").
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///@return True if the culture was set, false otherwise.
        ///</remarks>
        public static bool SetCurrentCulture(string Culture, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.SetCurrentCulture_method.Invoke(Culture, SaveToConfig);

        ///<summary>Set *only* the current language (for localization).</summary>
        ///<remarks>
        ///@note Unless you're doing something advanced, you likely want SetCurrentLanguageAndLocale or SetCurrentCulture instead.
        ///@param Culture The language to set, as an IETF language tag (eg, "zh-Hans-CN").
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///@return True if the language was set, false otherwise.
        ///</remarks>
        public static bool SetCurrentLanguage(string Culture, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.SetCurrentLanguage_method.Invoke(Culture, SaveToConfig);

        ///<summary>Set the current language (for localization) and locale (for internationalization).</summary>
        ///<remarks>
        ///@param Culture The language and locale to set, as an IETF language tag (eg, "zh-Hans-CN").
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///@return True if the language and locale were set, false otherwise.
        ///</remarks>
        public static bool SetCurrentLanguageAndLocale(string Culture, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.SetCurrentLanguageAndLocale_method.Invoke(Culture, SaveToConfig);

        ///<summary>Set *only* the current locale (for internationalization).</summary>
        ///<remarks>
        ///@note Unless you're doing something advanced, you likely want SetCurrentLanguageAndLocale or SetCurrentCulture instead.
        ///@param Culture The locale to set, as an IETF language tag (eg, "zh-Hans-CN").
        ///@param SaveToConfig If true, save the new setting to the users' "GameUserSettings" config so that it persists after a reload.
        ///@return True if the locale was set, false otherwise.
        ///</remarks>
        public static bool SetCurrentLocale(string Culture, bool SaveToConfig)  => 
            KismetInternationalizationLibrary_methods.SetCurrentLocale_method.Invoke(Culture, SaveToConfig);
        static KismetInternationalizationLibrary() {
            StaticClass = Main.GetClass("KismetInternationalizationLibrary");
        }
        internal unsafe KismetInternationalizationLibrary_fields* KismetInternationalizationLibrary_ptr => (KismetInternationalizationLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetInternationalizationLibrary(IntPtr p) => UObject.Make<KismetInternationalizationLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetInternationalizationLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetInternationalizationLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
