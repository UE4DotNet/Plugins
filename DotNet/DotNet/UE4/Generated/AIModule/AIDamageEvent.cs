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

using UE4.Engine;

namespace UE4.AIModule{
        ///<summary>AIDamage Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AIDamageEvent {
            [FieldOffset(0)] public float Amount;

            ///<summary>Event's "Location", or what will be later treated as the perceived location for this sense.</summary>
            ///<remarks>If not set, HitLocation will be used, if that is unset too DamagedActor's location</remarks>
            [FieldOffset(4)] Vector Location;

            ///<summary>
            ///Event's additional spatial information
            ///    @
            ///</summary>
            ///<remarks>TODO document</remarks>
            [FieldOffset(16)] Vector HitLocation;

            [FieldOffset(32)] 
            private IntPtr  DamagedActor_field;
            ///<summary>Damaged actor</summary>
            public Actor DamagedActor {
                get {return DamagedActor_field;}
                set {DamagedActor_field = value;}
            }

            [FieldOffset(40)] 
            private IntPtr  Instigator_field;
            ///<summary>Actor that instigated damage. Can be None</summary>
            public Actor Instigator {
                get {return Instigator_field;}
                set {Instigator_field = value;}
            }

        }
}
