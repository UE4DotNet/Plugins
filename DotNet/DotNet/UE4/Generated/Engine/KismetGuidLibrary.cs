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
    ///<summary>Kismet Guid Library</summary>
    public unsafe partial class KismetGuidLibrary : BlueprintFunctionLibrary  {

        ///<summary>Converts a GUID value to a string, in the form 'A-B-C-D'</summary>
        public static string Conv_GuidToString(FGuid InGuid)  => 
            KismetGuidLibrary_methods.Conv_GuidToString_method.Invoke(InGuid);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_GuidGuid(FGuid A, FGuid B)  => 
            KismetGuidLibrary_methods.EqualEqual_GuidGuid_method.Invoke(A, B);

        ///<summary>Invalidates the given GUID</summary>
        public static void Invalidate_Guid(FGuid InGuid)  => 
            KismetGuidLibrary_methods.Invalidate_Guid_method.Invoke(InGuid);

        ///<summary>Checks whether the given GUID is valid</summary>
        public static bool IsValid_Guid(FGuid InGuid)  => 
            KismetGuidLibrary_methods.IsValid_Guid_method.Invoke(InGuid);

        ///<summary>Returns a new unique GUID</summary>
        public static FGuid NewGuid()  => 
            KismetGuidLibrary_methods.NewGuid_method.Invoke();

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_GuidGuid(FGuid A, FGuid B)  => 
            KismetGuidLibrary_methods.NotEqual_GuidGuid_method.Invoke(A, B);

        ///<summary>Converts a String of format EGuidFormats to a Guid. Returns Guid OutGuid, Returns bool Success</summary>
        public static (FGuid, bool) Parse_StringToGuid(string GuidString)  => 
            KismetGuidLibrary_methods.Parse_StringToGuid_method.Invoke(GuidString);
        static KismetGuidLibrary() {
            StaticClass = Main.GetClass("KismetGuidLibrary");
        }
        internal unsafe KismetGuidLibrary_fields* KismetGuidLibrary_ptr => (KismetGuidLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetGuidLibrary(IntPtr p) => UObject.Make<KismetGuidLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetGuidLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetGuidLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
