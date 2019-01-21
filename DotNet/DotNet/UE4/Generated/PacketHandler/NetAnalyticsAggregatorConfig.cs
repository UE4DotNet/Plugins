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
using UE4.PacketHandler.Native;

namespace UE4.PacketHandler {
    ///<summary>Configuration for FNetAnalyticsAggregator - loaded PerObjectConfig, for each NetDriverName</summary>
    public unsafe partial class NetAnalyticsAggregatorConfig : UObject  {
         //TODO: array not UObject TArray NetAnalyticsData
        static NetAnalyticsAggregatorConfig() {
            StaticClass = Main.GetClass("NetAnalyticsAggregatorConfig");
        }
        internal unsafe NetAnalyticsAggregatorConfig_fields* NetAnalyticsAggregatorConfig_ptr => (NetAnalyticsAggregatorConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NetAnalyticsAggregatorConfig(IntPtr p) => UObject.Make<NetAnalyticsAggregatorConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NetAnalyticsAggregatorConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NetAnalyticsAggregatorConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
