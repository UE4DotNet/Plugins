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


namespace UE4.NavigationSystem{
        ///<summary>Navigation Filter Area</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NavigationFilterArea {
            ///<summary>navigation area class</summary>
            public SubclassOf<NavArea> AreaClass {
                get {return AreaClass_class; }
                set {AreaClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr AreaClass_class;

            [FieldOffset(8)] public float TravelCostOverride;

            [FieldOffset(12)] public float EnteringCostOverride;

            [FieldOffset(16)] public bool bIsExcluded;

            [FieldOffset(16)] public bool bOverrideTravelCost;

            [FieldOffset(16)] public bool bOverrideEnteringCost;

        }
}
