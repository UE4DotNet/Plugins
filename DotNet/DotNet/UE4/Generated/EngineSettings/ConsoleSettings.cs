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
using UE4.EngineSettings.Native;

namespace UE4.EngineSettings {
    ///<summary>Implements the settings for the UConsole class.</summary>
    public unsafe partial class ConsoleSettings : UObject  {
        ///<summary>Visible Console stuff</summary>
        public unsafe int MaxScrollbackSize {
            get {return ConsoleSettings_ptr->MaxScrollbackSize;}
            set {ConsoleSettings_ptr->MaxScrollbackSize = value;}
        }
         //TODO: array not UObject TArray ManualAutoCompleteList
         //TODO: array not UObject TArray AutoCompleteMapPaths
        ///<summary>Amount of transparency of the console background.</summary>
        public unsafe float BackgroundOpacityPercentage {
            get {return ConsoleSettings_ptr->BackgroundOpacityPercentage;}
            set {ConsoleSettings_ptr->BackgroundOpacityPercentage = value;}
        }
        public bool bOrderTopToBottom {
            get {return Main.GetGetBoolPropertyByName(this, "bOrderTopToBottom"); }
            set {Main.SetGetBoolPropertyByName(this, "bOrderTopToBottom", value); }
        }
        ///<summary>The color used for text input.</summary>
        public unsafe Color InputColor {
            get {return ConsoleSettings_ptr->InputColor;}
            set {ConsoleSettings_ptr->InputColor = value;}
        }
        ///<summary>The color used for the previously typed commands history.</summary>
        public unsafe Color HistoryColor {
            get {return ConsoleSettings_ptr->HistoryColor;}
            set {ConsoleSettings_ptr->HistoryColor = value;}
        }
        ///<summary>The autocomplete color used for executable commands.</summary>
        public unsafe Color AutoCompleteCommandColor {
            get {return ConsoleSettings_ptr->AutoCompleteCommandColor;}
            set {ConsoleSettings_ptr->AutoCompleteCommandColor = value;}
        }
        ///<summary>The autocomplete color used for mutable CVars.</summary>
        public unsafe Color AutoCompleteCVarColor {
            get {return ConsoleSettings_ptr->AutoCompleteCVarColor;}
            set {ConsoleSettings_ptr->AutoCompleteCVarColor = value;}
        }
        ///<summary>The autocomplete color used for command descriptions and read-only CVars.</summary>
        public unsafe Color AutoCompleteFadedColor {
            get {return ConsoleSettings_ptr->AutoCompleteFadedColor;}
            set {ConsoleSettings_ptr->AutoCompleteFadedColor = value;}
        }
        static ConsoleSettings() {
            StaticClass = Main.GetClass("ConsoleSettings");
        }
        internal unsafe ConsoleSettings_fields* ConsoleSettings_ptr => (ConsoleSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ConsoleSettings(IntPtr p) => UObject.Make<ConsoleSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ConsoleSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ConsoleSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
