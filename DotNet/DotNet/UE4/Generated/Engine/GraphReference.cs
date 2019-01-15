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
        ///<summary>Graph Reference</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct GraphReference {
            [FieldOffset(0)] 
            private IntPtr  MacroGraph_field;
            ///<summary>Reference to the actual graph</summary>
            public EdGraph MacroGraph {
                get {return MacroGraph_field;}
                set {MacroGraph_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  GraphBlueprint_field;
            ///<summary>The blueprint the graph is contained within</summary>
            public Blueprint GraphBlueprint {
                get {return GraphBlueprint_field;}
                set {GraphBlueprint_field = value;}
            }

            ///<summary>The graph GUID so we can refind it if it has been renamed</summary>
            [FieldOffset(16)] FGuid GraphGuid;

        }
}
