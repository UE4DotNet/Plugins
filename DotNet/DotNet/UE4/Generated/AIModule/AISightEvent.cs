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
        ///<summary>AISight Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AISightEvent {
            [FieldOffset(8)] 
            private IntPtr  SeenActor_field;
            ///<summary>Seen Actor</summary>
            public Actor SeenActor {
                get {return SeenActor_field;}
                set {SeenActor_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  Observer_field;
            ///<summary>Observer</summary>
            public Actor Observer {
                get {return Observer_field;}
                set {Observer_field = value;}
            }

        }
}
