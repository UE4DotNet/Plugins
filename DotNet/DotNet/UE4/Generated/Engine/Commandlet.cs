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
    ///<summary>Commandlet</summary>
    public unsafe partial class Commandlet : UObject  {
         //TODO: string FString HelpDescription
         //TODO: string FString HelpUsage
         //TODO: string FString HelpWebLink
         //TODO: array not UObject TArray HelpParamNames
         //TODO: array not UObject TArray HelpParamDescriptions
        public bool IsServer {
            get {return Main.GetGetBoolPropertyByName(this, "IsServer"); }
            set {Main.SetGetBoolPropertyByName(this, "IsServer", value); }
        }
        public bool IsClient {
            get {return Main.GetGetBoolPropertyByName(this, "IsClient"); }
            set {Main.SetGetBoolPropertyByName(this, "IsClient", value); }
        }
        public bool IsEditor {
            get {return Main.GetGetBoolPropertyByName(this, "IsEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "IsEditor", value); }
        }
        public bool LogToConsole {
            get {return Main.GetGetBoolPropertyByName(this, "LogToConsole"); }
            set {Main.SetGetBoolPropertyByName(this, "LogToConsole", value); }
        }
        public bool ShowErrorCount {
            get {return Main.GetGetBoolPropertyByName(this, "ShowErrorCount"); }
            set {Main.SetGetBoolPropertyByName(this, "ShowErrorCount", value); }
        }
        public bool ShowProgress {
            get {return Main.GetGetBoolPropertyByName(this, "ShowProgress"); }
            set {Main.SetGetBoolPropertyByName(this, "ShowProgress", value); }
        }
        static Commandlet() {
            StaticClass = Main.GetClass("Commandlet");
        }
        internal unsafe Commandlet_fields* Commandlet_ptr => (Commandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Commandlet(IntPtr p) => UObject.Make<Commandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Commandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Commandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
