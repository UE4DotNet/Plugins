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
using UE4.MagicLeapController.Native;
using UE4.InputCore;
using UE4.Engine;

namespace UE4.MagicLeapController {
    ///<summary>Magic Leap Controller Function Library</summary>
    public unsafe partial class MagicLeapControllerFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Match the position & orientation of the physical controller with an entity in the map and call this function
        ///with the position & orientation of that entity relative to the Player Pawn.
        ///</summary>
        ///<remarks>
        ///This would apply the correct offsets
        ///to the MotionController component's transform.
        ///</remarks>
        public static void CalibrateControllerNow(EControllerHand Hand, Vector StartPosition, Rotator StartOrientation)  => 
            MagicLeapControllerFunctionLibrary_methods.CalibrateControllerNow_method.Invoke(Hand, StartPosition, StartOrientation);

        ///<summary>Returns the hand to which given controller index has been mapped to in the device backend.</summary>
        ///<remarks>
        ///The native api does not have a concept of left vs right controller. They deal with indices. The first connected
        ///controller is index 0 and so on. By default, index 0 is mapped to the right hand in Unreal.
        ///You can invert these mappings by calling InvertControllerMapping() function.
        ///@param ControllerIndex Zero based controller index to get the hand mapping for. Should be less than MaxSupportedMagicLeapControllers().
        ///@param Hand Output parameter which is the hand the given index maps to. Valid only if the function returns true.
        ///@return true of the controller index maps to a valid hand, false otherwise
        ///</remarks>
        public static (EControllerHand, bool) GetControllerMapping(int ControllerIndex)  => 
            MagicLeapControllerFunctionLibrary_methods.GetControllerMapping_method.Invoke(ControllerIndex);

        ///<summary>Type of ML device being tracking the given hand.</summary>
        ///<remarks>
        ///@param Hand Controller hand to query.
        ///@return Type of ML device which maps to given Unreal controller hand.
        ///</remarks>
        public static EMLControllerType GetMLControllerType(EControllerHand Hand)  => 
            MagicLeapControllerFunctionLibrary_methods.GetMLControllerType_method.Invoke(Hand);

        ///<summary>Inverts the controller mapping i.</summary>
        ///<remarks>
        ///e. keys mapped to left hand controller will now be treated as right hand and vice-versa.
        ///@see GetControllerMapping()
        ///</remarks>
        public static void InvertControllerMapping()  => 
            MagicLeapControllerFunctionLibrary_methods.InvertControllerMapping_method.Invoke();

        ///<summary>Gets the maximum number of Magic Leap controllers supported at a time.</summary>
        ///<remarks>
        ///@return the maximum number of Magic Leap controllers supported at a time.
        ///</remarks>
        public static int MaxSupportedMagicLeapControllers()  => 
            MagicLeapControllerFunctionLibrary_methods.MaxSupportedMagicLeapControllers_method.Invoke();

        ///<summary>Play haptic feedback on the controller.</summary>
        ///<remarks>
        ///@param Hand Controller to play the haptic feedback on.
        ///@param HapticPattern Pattern to play on the controller.
        ///@param Intensity Intensity to play on the controller.
        ///@return True if the command to play the haptic feedback was successfully sent to the controller, false otherwise.
        ///</remarks>
        public static bool PlayControllerHapticFeedback(EControllerHand Hand, EMLControllerHapticPattern HapticPattern, EMLControllerHapticIntensity Intensity)  => 
            MagicLeapControllerFunctionLibrary_methods.PlayControllerHapticFeedback_method.Invoke(Hand, HapticPattern, Intensity);

        ///<summary>Light up the LED on the Magic Leap Controller in the given pattern for the specified duration.</summary>
        ///<remarks>
        ///@param Hand Controller to play the LED pattern on.
        ///@param LEDPattern Pattern to play on the controller.
        ///@param LEDColor Color of the LED.
        ///@param DurationInSec Duration (in seconds) to play the LED pattern.
        ///@return True if the command to play the LED pattern was successfully sent to the controller, false otherwise.
        ///</remarks>
        public static bool PlayControllerLED(EControllerHand Hand, EMLControllerLEDPattern LEDPattern, EMLControllerLEDColor LEDColor, float DurationInSec)  => 
            MagicLeapControllerFunctionLibrary_methods.PlayControllerLED_method.Invoke(Hand, LEDPattern, LEDColor, DurationInSec);

        ///<summary>Starts a LED feedback effect using the specified pattern on the specified controller.</summary>
        ///<remarks>
        ///@param Hand Controller to play the LED pattern on.
        ///@param LEDEffect Effect to play on the controller.
        ///@param LEDSpeed Effect speed.
        ///@param LEDPattern Pattern to play on the controller.
        ///@param LEDColor Color of the LED.
        ///@param DurationInSec Duration (in seconds) to play the LED pattern.
        ///@return True if the command to play the LED effect was successfully sent to the controller, false otherwise.
        ///</remarks>
        public static bool PlayControllerLEDEffect(EControllerHand Hand, EMLControllerLEDEffect LEDEffect, EMLControllerLEDSpeed LEDSpeed, EMLControllerLEDPattern LEDPattern, EMLControllerLEDColor LEDColor, float DurationInSec)  => 
            MagicLeapControllerFunctionLibrary_methods.PlayControllerLEDEffect_method.Invoke(Hand, LEDEffect, LEDSpeed, LEDPattern, LEDColor, DurationInSec);
        static MagicLeapControllerFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapControllerFunctionLibrary");
        }
        internal unsafe MagicLeapControllerFunctionLibrary_fields* MagicLeapControllerFunctionLibrary_ptr => (MagicLeapControllerFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapControllerFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapControllerFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapControllerFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapControllerFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
