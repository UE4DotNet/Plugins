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
using UE4.NUTUnrealEngine4.Native;
using UE4.NetcodeUnitTest;

namespace UE4.NUTUnrealEngine4 {
    ///<summary>
    ///Tests an RPC crash caused by empty FText's, as reported on the UDN here:
    ///https://udn.
    ///</summary>
    ///<remarks>
    ///unrealengine.com/questions/213120/using-empty-ftexts-within-rpcs.html
    ///
    ///UDN Post: "Using Empty FTexts within RPCs"
    ///Hey,
    ///we're using FTexts within RPCs functions (server -> client in my specific case) to pass localized strings.
    ///That works fine until the point when the server sends an empty FText.
    ///In that case both the FText members SourceString and DisplayString are null on client side which lead to crashes whenever you use
    ///something like ToString which assumes those are valid.
    ///
    ///Is this the intended behavior? I'm using FTextInspector::GetSourceString(text) to run checks on these replicated FTexts now to catch
    ///this case. FTexts that are not empty work just fine.
    ///
    ///Thanks, Oliver
    ///</remarks>
    public unsafe partial class FTextCrash : ClientUnitTest  {
        static FTextCrash() {
            StaticClass = Main.GetClass("FTextCrash");
        }
        internal unsafe FTextCrash_fields* FTextCrash_ptr => (FTextCrash_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FTextCrash(IntPtr p) => UObject.Make<FTextCrash>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FTextCrash DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FTextCrash New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
