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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>The Safe-Zone widget is an essential part of developing a game UI that can run on lots of different non-PC platforms.</summary>
    ///<remarks>
    ///While a modern flat panel computer monitor may not have over scan issues, this is a common occurrence for Consoles.
    ///It's common for TVs to have extra pixels under the bezel, in addition to projectors and projection TVs having potentially
    ///several vertical and horizontal columns of pixels hidden behind or against a black border of the projection screen.
    ///
    ///Useful testing console commands to help, simulate the safe zone on PC,
    ///  r.DebugSafeZone.TitleRatio 0.96
    ///  r.DebugActionZone.ActionRatio 0.96
    ///
    ///To enable a red band to visualize the safe zone, use this console command,
    ///r.DebugSafeZone.Mode controls the debug visualization overlay (0..2, default 0).
    ///  0: Do not display the safe zone overlay.
    ///  1: Display the overlay for the title safe zone.
    ///  2: Display the overlay for the action safe zone.
    ///</remarks>
    public unsafe partial class SafeZone : ContentWidget  {

        ///<summary>Set Sides to Pad</summary>
        public void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom)  => 
            SafeZone_methods.SetSidesToPad_method.Invoke(ObjPointer, InPadLeft, InPadRight, InPadTop, InPadBottom);
        public bool PadLeft {
            get {return Main.GetGetBoolPropertyByName(this, "PadLeft"); }
        }
        public bool PadRight {
            get {return Main.GetGetBoolPropertyByName(this, "PadRight"); }
        }
        public bool PadTop {
            get {return Main.GetGetBoolPropertyByName(this, "PadTop"); }
        }
        public bool PadBottom {
            get {return Main.GetGetBoolPropertyByName(this, "PadBottom"); }
        }
        static SafeZone() {
            StaticClass = Main.GetClass("SafeZone");
        }
        internal unsafe SafeZone_fields* SafeZone_ptr => (SafeZone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SafeZone(IntPtr p) => UObject.Make<SafeZone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SafeZone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SafeZone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
