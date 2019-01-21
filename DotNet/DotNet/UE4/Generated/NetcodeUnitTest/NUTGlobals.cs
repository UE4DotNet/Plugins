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
using UE4.NetcodeUnitTest.Native;
using UE4.Engine;

namespace UE4.NetcodeUnitTest {
    ///<summary>Stores globals/static-variables for NetcodeUnitTest - for compatibility with hot reload</summary>
    public unsafe partial class NUTGlobals : UObject  {
        ///<summary>For NUTActor - the UNetConnection that 'watch' events will be sent to</summary>
        public unsafe NetConnection EventWatcher {
            get {return NUTGlobals_ptr->EventWatcher;}
            set {NUTGlobals_ptr->EventWatcher = value;}
        }
        ///<summary>For ClientUnitTest - the (+10) incremented port number, for each server instance</summary>
        public unsafe int ServerPortOffset {
            get {return NUTGlobals_ptr->ServerPortOffset;}
            set {NUTGlobals_ptr->ServerPortOffset = value;}
        }
        ///<summary>For MinimalClient - counter for the number of unit test net drivers created</summary>
        public unsafe int UnitTestNetDriverCount {
            get {return NUTGlobals_ptr->UnitTestNetDriverCount;}
            set {NUTGlobals_ptr->UnitTestNetDriverCount = value;}
        }
         //TODO: array not UObject TArray DumpRPCMatches
         //TODO: array not UObject TArray UnitTestModules
         //TODO: array not UObject TArray UnloadedModules
        static NUTGlobals() {
            StaticClass = Main.GetClass("NUTGlobals");
        }
        internal unsafe NUTGlobals_fields* NUTGlobals_ptr => (NUTGlobals_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NUTGlobals(IntPtr p) => UObject.Make<NUTGlobals>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NUTGlobals DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NUTGlobals New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
