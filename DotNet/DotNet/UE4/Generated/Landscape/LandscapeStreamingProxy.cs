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
using UE4.Landscape.Native;

namespace UE4.Landscape {
    ///<summary>Landscape Streaming Proxy</summary>
    public unsafe partial class LandscapeStreamingProxy : LandscapeProxy  {
         //TODO: lazy object TLazyObjectPtr<ALandscape> LandscapeActor
        static LandscapeStreamingProxy() {
            StaticClass = Main.GetClass("LandscapeStreamingProxy");
        }
        internal unsafe LandscapeStreamingProxy_fields* LandscapeStreamingProxy_ptr => (LandscapeStreamingProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeStreamingProxy(IntPtr p) => UObject.Make<LandscapeStreamingProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeStreamingProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeStreamingProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
