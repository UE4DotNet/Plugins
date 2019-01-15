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


namespace UE4.Engine{
        ///<summary>stores information on a viewer that actors need to be checked against for relevancy</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct NetViewer {
            [FieldOffset(0)] 
            private IntPtr  Connection_field;
            ///<summary>Connection</summary>
            public NetConnection Connection {
                get {return Connection_field;}
                set {Connection_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  InViewer_field;
            ///<summary>The "controlling net object" associated with this view (typically player controller)</summary>
            public Actor InViewer {
                get {return InViewer_field;}
                set {InViewer_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  ViewTarget_field;
            ///<summary>The actor that is being directly viewed, usually a pawn.  Could also be the net actor of consequence</summary>
            public Actor ViewTarget {
                get {return ViewTarget_field;}
                set {ViewTarget_field = value;}
            }

            ///<summary>Where the viewer is looking from</summary>
            [FieldOffset(24)] Vector ViewLocation;

            ///<summary>Direction the viewer is looking</summary>
            [FieldOffset(36)] Vector ViewDir;

        }
}
