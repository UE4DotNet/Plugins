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


namespace UE4.AIModule{
        ///<summary>
        ///AIDataProvider is an object that can provide collection of properties
        ///associated with bound pawn owner or request Id.
        ///</summary>
        ///<remarks>
        ///Editable properties are used to set up provider instance,
        ///creating additional filters or ways of accessing data (e.g. gameplay tag of ability)
        ///
        ///Non editable properties are holding data
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AIDataProviderValue {
            [FieldOffset(8)] 
            private IntPtr  CachedProperty_field;
            ///<summary>cached uproperty of provider</summary>
            public Property CachedProperty {
                get {return CachedProperty_field;}
                set {CachedProperty_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  DataBinding_field;
            ///<summary>(optional) provider for dynamic data binding</summary>
            public AIDataProvider DataBinding {
                get {return DataBinding_field;}
                set {DataBinding_field = value;}
            }

            [FieldOffset(24)] public Name DataField;

        }
}
