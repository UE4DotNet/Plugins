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
using UE4.SourceCodeAccess.Native;

namespace UE4.SourceCodeAccess {
    ///<summary>Source Code Access Settings</summary>
    public unsafe partial class SourceCodeAccessSettings : UObject  {
         //TODO: string FString PreferredAccessor
        static SourceCodeAccessSettings() {
            StaticClass = Main.GetClass("SourceCodeAccessSettings");
        }
        internal unsafe SourceCodeAccessSettings_fields* SourceCodeAccessSettings_ptr => (SourceCodeAccessSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SourceCodeAccessSettings(IntPtr p) => UObject.Make<SourceCodeAccessSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SourceCodeAccessSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SourceCodeAccessSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
