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
        ///<summary>Nav Graph Node</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NavGraphNode {
            [FieldOffset(0)] 
            private IntPtr  Owner_field;
            ///<summary>Who's this node referring to? This will most commonly point to an actor or a component</summary>
            public UObject Owner {
                get {return Owner_field;}
                set {Owner_field = value;}
            }

        }
}
