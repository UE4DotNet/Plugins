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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>Direct API interface for the Magic Leap Persistent AR Pin tracker system.</summary>
    public unsafe partial class MagicLeapARPinFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Returns the world position & orientation of the requested Pin.</summary>
        ///<remarks>
        ///@param PinID ID of the Pin to get the position and orientation for.
        ///@param Position Output param for the world position of the Pin. Valid only if return value is true.
        ///@param Orientation Output param for the world orientation of the Pin. Valid only if return value is true.
        ///@param PinFoundInEnvironment Output param for indicating ig the requested Pin was found user's current environment or not.
        ///@return true if the PinID was valid and the position & orientation were successfully retrieved.
        ///</remarks>
        public static (Vector, Rotator, bool, bool) GetARPinPositionAndOrientation(FGuid PinID)  => 
            MagicLeapARPinFunctionLibrary_methods.GetARPinPositionAndOrientation_method.Invoke(PinID);

        ///<summary>Returns all the AR Pins currently available.</summary>
        ///<remarks>
        ///@param NumRequested Max number of AR Pins to query. Pass in a negative integer to get all available Pins.
        ///@param Pins Output array containing IDs of the found Pins. Valid only if return value is EPassableWorldError::None.
        ///@return Error code representing specific success or failure cases.
        ///</remarks>
        public static (IReadOnlyCollection<FGuid>, EPassableWorldError) GetAvailableARPins(int NumRequested)  => 
            MagicLeapARPinFunctionLibrary_methods.GetAvailableARPins_method.Invoke(NumRequested);

        ///<summary>Returns the Pin closest to the target point passed in.</summary>
        ///<remarks>
        ///@param SearchPoint Position, in world space, to search the closest Pin to.
        ///@param PinID Output param for the ID of the closest Pin. Valid only if return value is EPassableWorldError::None.
        ///@return Error code representing specific success or failure cases.
        ///</remarks>
        public static (FGuid, EPassableWorldError) GetClosestARPin(Vector SearchPoint)  => 
            MagicLeapARPinFunctionLibrary_methods.GetClosestARPin_method.Invoke(SearchPoint);

        ///<summary>Returns the count of currently available AR Pins.</summary>
        ///<remarks>
        ///@param Count Output param for number of currently available AR Pins. Valid only if return value is EPassableWorldError::None.
        ///@return Error code representing specific success or failure cases.
        ///</remarks>
        public static (int, EPassableWorldError) GetNumAvailableARPins()  => 
            MagicLeapARPinFunctionLibrary_methods.GetNumAvailableARPins_method.Invoke();
        static MagicLeapARPinFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapARPinFunctionLibrary");
        }
        internal unsafe MagicLeapARPinFunctionLibrary_fields* MagicLeapARPinFunctionLibrary_ptr => (MagicLeapARPinFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapARPinFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapARPinFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapARPinFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapARPinFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
