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
using UE4.SlateCore;
using UE4.Slate;
using UE4.Engine;

namespace UE4.UMG {
    ///<summary>The user widget is extensible by users through the WidgetBlueprint.</summary>
    public unsafe partial class UserWidget : Widget  {

        ///<summary>Called after the underlying slate widget is constructed.</summary>
        ///<remarks>
        ///Depending on how the slate object is used
        ///this event may be called multiple times due to adding and removing from the hierarchy.
        ///If you need a true called-once-when-created event, use OnInitialized.
        ///</remarks>
        public event Construct_delegate Construct;
        public delegate void Construct_delegate();
        internal void on_Construct() =>
            Construct?.Invoke();


        ///<summary>Called when a widget is no longer referenced causing the slate resource to destroyed.</summary>
        ///<remarks>
        ///Just like
        ///Construct this event can be called multiple times.
        ///</remarks>
        public event Destruct_delegate Destruct;
        public delegate void Destruct_delegate();
        internal void on_Destruct() =>
            Destruct?.Invoke();


        ///<summary>Gets a value indicating if the widget is interactive.</summary>
        public event IsInteractable_delegate IsInteractable;
        public delegate bool IsInteractable_delegate(bool ReturnValue);
        internal bool on_IsInteractable(bool ReturnValue) =>
            IsInteractable != null ? IsInteractable(ReturnValue) : ReturnValue;


        ///<summary>
        ///If focus is gained on on this widget or on a child widget and this widget is added
        ///to the focus path, and wasn't previously part of it, this event is called.
        ///</summary>
        ///<remarks>
        ///@param  InFocusEvent  FocusEvent
        ///</remarks>
        public event OnAddedToFocusPath_delegate OnAddedToFocusPath;
        public delegate void OnAddedToFocusPath_delegate(FocusEvent InFocusEvent);
        internal void on_OnAddedToFocusPath(FocusEvent InFocusEvent) =>
            OnAddedToFocusPath?.Invoke(InFocusEvent);


        ///<summary>
        ///Called when an analog value changes on a button that supports analog
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry The Geometry of the widget receiving the event
        ///@param  InAnalogInputEvent  Analog Event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnAnalogValueChanged_delegate OnAnalogValueChanged;
        public delegate EventReply OnAnalogValueChanged_delegate(Geometry MyGeometry, AnalogInputEvent InAnalogInputEvent, EventReply ReturnValue);
        internal EventReply on_OnAnalogValueChanged(Geometry MyGeometry, AnalogInputEvent InAnalogInputEvent, EventReply ReturnValue) =>
            OnAnalogValueChanged != null ? OnAnalogValueChanged(MyGeometry, InAnalogInputEvent, ReturnValue) : ReturnValue;


        ///<summary>
        ///Called when the user cancels the drag operation, typically when they simply release the mouse button after
        ///beginning a drag operation, but failing to complete the drag.
        ///</summary>
        ///<remarks>
        ///@param  PointerEvent  Last mouse event from when the drag was canceled.
        ///@param  Operation     The drag operation that was canceled.
        ///</remarks>
        public event OnDragCancelled_delegate OnDragCancelled;
        public delegate PointerEvent OnDragCancelled_delegate(PointerEvent PointerEvent, DragDropOperation Operation);
        internal PointerEvent on_OnDragCancelled(PointerEvent PointerEvent, DragDropOperation Operation) =>
            OnDragCancelled != null ? OnDragCancelled(PointerEvent, Operation) : PointerEvent;


        ///<summary>Called when Slate detects that a widget started to be dragged.</summary>
        ///<remarks>
        ///@param  InMyGeometry  Widget geometry
        ///@param  PointerEvent  MouseMove that triggered the drag
        ///@param  Operation     The drag operation that was detected.
        ///</remarks>
        public event OnDragDetected_delegate OnDragDetected;
        public delegate (PointerEvent, DragDropOperation) OnDragDetected_delegate(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation);
        internal (PointerEvent, DragDropOperation) on_OnDragDetected(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) =>
            OnDragDetected != null ? OnDragDetected(MyGeometry, PointerEvent, Operation) : (PointerEvent, Operation);


        ///<summary>Called during drag and drop when the drag enters the widget.</summary>
        ///<remarks>
        ///@param MyGeometry     The geometry of the widget receiving the event.
        ///@param PointerEvent   The mouse event from when the drag entered the widget.
        ///@param Operation      The drag operation that entered the widget.
        ///</remarks>
        public event OnDragEnter_delegate OnDragEnter;
        public delegate void OnDragEnter_delegate(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation);
        internal void on_OnDragEnter(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation) =>
            OnDragEnter?.Invoke(MyGeometry, PointerEvent, Operation);


        ///<summary>Called during drag and drop when the drag leaves the widget.</summary>
        ///<remarks>
        ///@param PointerEvent   The mouse event from when the drag left the widget.
        ///@param Operation      The drag operation that entered the widget.
        ///</remarks>
        public event OnDragLeave_delegate OnDragLeave;
        public delegate void OnDragLeave_delegate(PointerEvent PointerEvent, DragDropOperation Operation);
        internal void on_OnDragLeave(PointerEvent PointerEvent, DragDropOperation Operation) =>
            OnDragLeave?.Invoke(PointerEvent, Operation);


        ///<summary>Called during drag and drop when the the mouse is being dragged over a widget.</summary>
        ///<remarks>
        ///@param MyGeometry     The geometry of the widget receiving the event.
        ///@param PointerEvent   The mouse event from when the drag occurred over the widget.
        ///@param Operation      The drag operation over the widget.
        ///
        ///@return 'true' to indicate that you handled the drag over operation.  Returning 'false' will cause the operation to continue to bubble up.
        ///</remarks>
        public event OnDragOver_delegate OnDragOver;
        public delegate bool OnDragOver_delegate(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation, bool ReturnValue);
        internal bool on_OnDragOver(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation, bool ReturnValue) =>
            OnDragOver != null ? OnDragOver(MyGeometry, PointerEvent, Operation, ReturnValue) : ReturnValue;


        ///<summary>Called when the user is dropping something onto a widget.</summary>
        ///<remarks>
        ///Ends the drag and drop operation, even if no widget handles this.
        ///
        ///@param MyGeometry     The geometry of the widget receiving the event.
        ///@param PointerEvent   The mouse event from when the drag occurred over the widget.
        ///@param Operation      The drag operation over the widget.
        ///
        ///@return 'true' to indicate you handled the drop operation.
        ///</remarks>
        public event OnDrop_delegate OnDrop;
        public delegate bool OnDrop_delegate(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation, bool ReturnValue);
        internal bool on_OnDrop(Geometry MyGeometry, PointerEvent PointerEvent, DragDropOperation Operation, bool ReturnValue) =>
            OnDrop != null ? OnDrop(MyGeometry, PointerEvent, Operation, ReturnValue) : ReturnValue;


        ///<summary>Called when this widget loses focus.</summary>
        ///<remarks>
        ///This event does not bubble.
        ///
        ///@param  InFocusEvent  FocusEvent
        ///</remarks>
        public event OnFocusLost_delegate OnFocusLost;
        public delegate void OnFocusLost_delegate(FocusEvent InFocusEvent);
        internal void on_OnFocusLost(FocusEvent InFocusEvent) =>
            OnFocusLost?.Invoke(InFocusEvent);


        ///<summary>Called when keyboard focus is given to this widget.</summary>
        ///<remarks>
        ///This event does not bubble.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param InFocusEvent  FocusEvent
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnFocusReceived_delegate OnFocusReceived;
        public delegate EventReply OnFocusReceived_delegate(Geometry MyGeometry, FocusEvent InFocusEvent, EventReply ReturnValue);
        internal EventReply on_OnFocusReceived(Geometry MyGeometry, FocusEvent InFocusEvent, EventReply ReturnValue) =>
            OnFocusReceived != null ? OnFocusReceived(MyGeometry, InFocusEvent, ReturnValue) : ReturnValue;


        ///<summary>Called once only at game time on non-template instances.</summary>
        ///<remarks>
        ///While Construct/Destruct pertain to the underlying Slate, this is called only once for the UUserWidget.
        ///If you have one-time things to establish up-front (like binding callbacks to events on BindWidget properties), do so here.
        ///</remarks>
        public event OnInitialized_delegate OnInitialized;
        public delegate void OnInitialized_delegate();
        internal void on_OnInitialized() =>
            OnInitialized?.Invoke();


        ///<summary>
        ///Called after a character is entered while this widget has focus
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry The Geometry of the widget receiving the event
        ///@param  InCharacterEvent  Character event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnKeyChar_delegate OnKeyChar;
        public delegate EventReply OnKeyChar_delegate(Geometry MyGeometry, CharacterEvent InCharacterEvent, EventReply ReturnValue);
        internal EventReply on_OnKeyChar(Geometry MyGeometry, CharacterEvent InCharacterEvent, EventReply ReturnValue) =>
            OnKeyChar != null ? OnKeyChar(MyGeometry, InCharacterEvent, ReturnValue) : ReturnValue;


        ///<summary>Called after a key (keyboard, controller, .</summary>
        ///<remarks>
        ///..) is pressed when this widget has focus (this event bubbles if not handled)
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param  InKeyEvent  Key event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnKeyDown_delegate OnKeyDown;
        public delegate EventReply OnKeyDown_delegate(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue);
        internal EventReply on_OnKeyDown(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue) =>
            OnKeyDown != null ? OnKeyDown(MyGeometry, InKeyEvent, ReturnValue) : ReturnValue;


        ///<summary>Called after a key (keyboard, controller, .</summary>
        ///<remarks>
        ///..) is released when this widget has focus
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param  InKeyEvent  Key event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnKeyUp_delegate OnKeyUp;
        public delegate EventReply OnKeyUp_delegate(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue);
        internal EventReply on_OnKeyUp(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue) =>
            OnKeyUp != null ? OnKeyUp(MyGeometry, InKeyEvent, ReturnValue) : ReturnValue;


        ///<summary>
        ///Called when motion is detected (controller or device)
        ///e.
        ///</summary>
        ///<remarks>
        ///g. Someone tilts or shakes their controller.
        ///
        ///@param MyGeometry    The geometry of the widget receiving the event.
        ///@param MotionEvent   The motion event generated
        ///</remarks>
        public event OnMotionDetected_delegate OnMotionDetected;
        public delegate EventReply OnMotionDetected_delegate(Geometry MyGeometry, MotionEvent InMotionEvent, EventReply ReturnValue);
        internal EventReply on_OnMotionDetected(Geometry MyGeometry, MotionEvent InMotionEvent, EventReply ReturnValue) =>
            OnMotionDetected != null ? OnMotionDetected(MyGeometry, InMotionEvent, ReturnValue) : ReturnValue;


        ///<summary>Called when a mouse button is double clicked.</summary>
        ///<remarks>
        ///Override this in derived classes.
        ///
        ///@param  InMyGeometry  Widget geometry
        ///@param  InMouseEvent  Mouse button event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnMouseButtonDoubleClick_delegate OnMouseButtonDoubleClick;
        public delegate (PointerEvent, EventReply) OnMouseButtonDoubleClick_delegate(Geometry InMyGeometry, PointerEvent InMouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnMouseButtonDoubleClick(Geometry InMyGeometry, PointerEvent InMouseEvent, EventReply ReturnValue) =>
            OnMouseButtonDoubleClick != null ? OnMouseButtonDoubleClick(InMyGeometry, InMouseEvent, ReturnValue) : (InMouseEvent, ReturnValue);


        ///<summary>The system calls this method to notify the widget that a mouse button was pressed within it.</summary>
        ///<remarks>
        ///This event is bubbled.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param MouseEvent Information about the input event
        ///@return Whether the event was handled along with possible requests for the system to take action.
        ///</remarks>
        public event OnMouseButtonDown_delegate OnMouseButtonDown;
        public delegate (PointerEvent, EventReply) OnMouseButtonDown_delegate(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnMouseButtonDown(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue) =>
            OnMouseButtonDown != null ? OnMouseButtonDown(MyGeometry, MouseEvent, ReturnValue) : (MouseEvent, ReturnValue);


        ///<summary>The system calls this method to notify the widget that a mouse button was release within it.</summary>
        ///<remarks>
        ///This event is bubbled.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param MouseEvent Information about the input event
        ///@return Whether the event was handled along with possible requests for the system to take action.
        ///</remarks>
        public event OnMouseButtonUp_delegate OnMouseButtonUp;
        public delegate (PointerEvent, EventReply) OnMouseButtonUp_delegate(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnMouseButtonUp(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue) =>
            OnMouseButtonUp != null ? OnMouseButtonUp(MyGeometry, MouseEvent, ReturnValue) : (MouseEvent, ReturnValue);


        ///<summary>Called when mouse capture is lost if it was owned by this widget.</summary>
        public event OnMouseCaptureLost_delegate OnMouseCaptureLost;
        public delegate void OnMouseCaptureLost_delegate();
        internal void on_OnMouseCaptureLost() =>
            OnMouseCaptureLost?.Invoke();


        ///<summary>The system will use this event to notify a widget that the cursor has entered it.</summary>
        ///<remarks>
        ///This event is NOT bubbled.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param MouseEvent Information about the input event
        ///</remarks>
        public event OnMouseEnter_delegate OnMouseEnter;
        public delegate PointerEvent OnMouseEnter_delegate(Geometry MyGeometry, PointerEvent MouseEvent);
        internal PointerEvent on_OnMouseEnter(Geometry MyGeometry, PointerEvent MouseEvent) =>
            OnMouseEnter != null ? OnMouseEnter(MyGeometry, MouseEvent) : MouseEvent;


        ///<summary>The system will use this event to notify a widget that the cursor has left it.</summary>
        ///<remarks>
        ///This event is NOT bubbled.
        ///
        ///@param MouseEvent Information about the input event
        ///</remarks>
        public event OnMouseLeave_delegate OnMouseLeave;
        public delegate PointerEvent OnMouseLeave_delegate(PointerEvent MouseEvent);
        internal PointerEvent on_OnMouseLeave(PointerEvent MouseEvent) =>
            OnMouseLeave != null ? OnMouseLeave(MouseEvent) : MouseEvent;


        ///<summary>The system calls this method to notify the widget that a mouse moved within it.</summary>
        ///<remarks>
        ///This event is bubbled.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param MouseEvent Information about the input event
        ///@return Whether the event was handled along with possible requests for the system to take action.
        ///</remarks>
        public event OnMouseMove_delegate OnMouseMove;
        public delegate (PointerEvent, EventReply) OnMouseMove_delegate(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnMouseMove(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue) =>
            OnMouseMove != null ? OnMouseMove(MyGeometry, MouseEvent, ReturnValue) : (MouseEvent, ReturnValue);


        ///<summary>Called when the mouse wheel is spun.</summary>
        ///<remarks>
        ///This event is bubbled.
        ///
        ///@param  MouseEvent  Mouse event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnMouseWheel_delegate OnMouseWheel;
        public delegate (PointerEvent, EventReply) OnMouseWheel_delegate(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnMouseWheel(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue) =>
            OnMouseWheel != null ? OnMouseWheel(MyGeometry, MouseEvent, ReturnValue) : (MouseEvent, ReturnValue);


        ///<summary>On Paint</summary>
        public event OnPaint_delegate OnPaint;
        public delegate PaintContext OnPaint_delegate(PaintContext Context);
        internal PaintContext on_OnPaint(PaintContext Context) =>
            OnPaint != null ? OnPaint(Context) : Context;


        ///<summary>Called after a key (keyboard, controller, .</summary>
        ///<remarks>
        ///..) is pressed when this widget or a child of this widget has focus
        ///If a widget handles this event, OnKeyDown will *not* be passed to the focused widget.
        ///
        ///This event is primarily to allow parent widgets to consume an event before a child widget processes
        ///it and it should be used only when there is no better design alternative.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param  InKeyEvent  Key event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnPreviewKeyDown_delegate OnPreviewKeyDown;
        public delegate EventReply OnPreviewKeyDown_delegate(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue);
        internal EventReply on_OnPreviewKeyDown(Geometry MyGeometry, KeyEvent InKeyEvent, EventReply ReturnValue) =>
            OnPreviewKeyDown != null ? OnPreviewKeyDown(MyGeometry, InKeyEvent, ReturnValue) : ReturnValue;


        ///<summary>Just like OnMouseButtonDown, but tunnels instead of bubbling.</summary>
        ///<remarks>
        ///If this even is handled, OnMouseButtonDown will not be sent.
        ///
        ///Use this event sparingly as preview events generally make UIs more
        ///difficult to reason about.
        ///
        ///@param MyGeometry The Geometry of the widget receiving the event
        ///@param MouseEvent Information about the input event
        ///@return Whether the event was handled along with possible requests for the system to take action.
        ///</remarks>
        public event OnPreviewMouseButtonDown_delegate OnPreviewMouseButtonDown;
        public delegate (PointerEvent, EventReply) OnPreviewMouseButtonDown_delegate(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnPreviewMouseButtonDown(Geometry MyGeometry, PointerEvent MouseEvent, EventReply ReturnValue) =>
            OnPreviewMouseButtonDown != null ? OnPreviewMouseButtonDown(MyGeometry, MouseEvent, ReturnValue) : (MouseEvent, ReturnValue);


        ///<summary>
        ///If focus is lost on on this widget or on a child widget and this widget is
        ///no longer part of the focus path.
        ///</summary>
        ///<remarks>
        ///@param  InFocusEvent  FocusEvent
        ///</remarks>
        public event OnRemovedFromFocusPath_delegate OnRemovedFromFocusPath;
        public delegate void OnRemovedFromFocusPath_delegate(FocusEvent InFocusEvent);
        internal void on_OnRemovedFromFocusPath(FocusEvent InFocusEvent) =>
            OnRemovedFromFocusPath?.Invoke(InFocusEvent);


        ///<summary>
        ///Called when a touchpad touch is ended (finger lifted)
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry    The geometry of the widget receiving the event.
        ///@param InTouchEvent  The touch event generated
        ///</remarks>
        public event OnTouchEnded_delegate OnTouchEnded;
        public delegate (PointerEvent, EventReply) OnTouchEnded_delegate(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnTouchEnded(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue) =>
            OnTouchEnded != null ? OnTouchEnded(MyGeometry, InTouchEvent, ReturnValue) : (InTouchEvent, ReturnValue);


        ///<summary>
        ///Called when a touchpad force has changed (user pressed down harder or let up)
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry    The geometry of the widget receiving the event.
        ///@param InTouchEvent   The touch event generated
        ///</remarks>
        public event OnTouchForceChanged_delegate OnTouchForceChanged;
        public delegate (PointerEvent, EventReply) OnTouchForceChanged_delegate(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnTouchForceChanged(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue) =>
            OnTouchForceChanged != null ? OnTouchForceChanged(MyGeometry, InTouchEvent, ReturnValue) : (InTouchEvent, ReturnValue);


        ///<summary>Called when the user performs a gesture on trackpad.</summary>
        ///<remarks>
        ///This event is bubbled.
        ///
        ///@param MyGeometry     The geometry of the widget receiving the event.
        ///@param  GestureEvent  gesture event
        ///@return  Returns whether the event was handled, along with other possible actions
        ///</remarks>
        public event OnTouchGesture_delegate OnTouchGesture;
        public delegate (PointerEvent, EventReply) OnTouchGesture_delegate(Geometry MyGeometry, PointerEvent GestureEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnTouchGesture(Geometry MyGeometry, PointerEvent GestureEvent, EventReply ReturnValue) =>
            OnTouchGesture != null ? OnTouchGesture(MyGeometry, GestureEvent, ReturnValue) : (GestureEvent, ReturnValue);


        ///<summary>
        ///Called when a touchpad touch is moved  (finger moved)
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry    The geometry of the widget receiving the event.
        ///@param InTouchEvent  The touch event generated
        ///</remarks>
        public event OnTouchMoved_delegate OnTouchMoved;
        public delegate (PointerEvent, EventReply) OnTouchMoved_delegate(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnTouchMoved(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue) =>
            OnTouchMoved != null ? OnTouchMoved(MyGeometry, InTouchEvent, ReturnValue) : (InTouchEvent, ReturnValue);


        ///<summary>
        ///Called when a touchpad touch is started (finger down)
        ///@
        ///</summary>
        ///<remarks>
        ///param MyGeometry    The geometry of the widget receiving the event.
        ///@param InTouchEvent  The touch event generated
        ///</remarks>
        public event OnTouchStarted_delegate OnTouchStarted;
        public delegate (PointerEvent, EventReply) OnTouchStarted_delegate(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue);
        internal (PointerEvent, EventReply) on_OnTouchStarted(Geometry MyGeometry, PointerEvent InTouchEvent, EventReply ReturnValue) =>
            OnTouchStarted != null ? OnTouchStarted(MyGeometry, InTouchEvent, ReturnValue) : (InTouchEvent, ReturnValue);


        ///<summary>Called by both the game and the editor.</summary>
        ///<remarks>
        ///Allows users to run initial setup for their widgets to better preview
        ///the setup in the designer and since generally that same setup code is required at runtime, it's called there
        ///as well.
        ///
        ///**WARNING**
        ///This is intended purely for cosmetic updates using locally owned data, you can not safely access any game related
        ///state, if you call something that doesn't expect to be run at editor time, you may crash the editor.
        ///
        ///In the event you save the asset with blueprint code that causes a crash on evaluation.  You can turn off
        ///PreConstruct evaluation in the Widget Designer settings in the Editor Preferences.
        ///</remarks>
        public event PreConstruct_delegate PreConstruct;
        public delegate void PreConstruct_delegate(bool IsDesignTime);
        internal void on_PreConstruct(bool IsDesignTime) =>
            PreConstruct?.Invoke(IsDesignTime);


        ///<summary>Ticks this widget.</summary>
        ///<remarks>
        ///Override in derived classes, but always call the parent implementation.
        ///
        ///@param  MyGeometry The space allotted for this widget
        ///@param  InDeltaTime  Real time passed since last tick
        ///</remarks>
        public event Tick_delegate Tick;
        public delegate void Tick_delegate(Geometry MyGeometry, float InDeltaTime);
        internal void on_Tick(Geometry MyGeometry, float InDeltaTime) =>
            Tick?.Invoke(MyGeometry, InDeltaTime);


        ///<summary>
        ///Called when an animation has either played all the way through or is stopped
        ///@
        ///</summary>
        ///<remarks>param Animation The animation that has finished playing</remarks>
        public event OnAnimationFinished_delegate OnAnimationFinished;
        public delegate void OnAnimationFinished_delegate(WidgetAnimation Animation);
        internal void on_OnAnimationFinished(WidgetAnimation Animation) =>
            OnAnimationFinished?.Invoke(Animation);


        ///<summary>Called when an animation is started.</summary>
        ///<remarks>
        ///@param Animation the animation that started
        ///</remarks>
        public event OnAnimationStarted_delegate OnAnimationStarted;
        public delegate void OnAnimationStarted_delegate(WidgetAnimation Animation);
        internal void on_OnAnimationStarted(WidgetAnimation Animation) =>
            OnAnimationStarted?.Invoke(Animation);


        ///<summary>Adds the widget to the game's viewport in a section dedicated to the player.</summary>
        ///<remarks>
        ///This is valuable in a split screen
        ///game where you need to only show a widget over a player's portion of the viewport.
        ///
        ///@param ZOrder The higher the number, the more on top this widget will be.
        ///</remarks>
        public bool AddToPlayerScreen(int ZOrder)  => 
            UserWidget_methods.AddToPlayerScreen_method.Invoke(ObjPointer, ZOrder);

        ///<summary>
        ///Adds it to the game's viewport and fills the entire screen, unless SetDesiredSizeInViewport is called
        ///to explicitly set the size.
        ///</summary>
        ///<remarks>
        ///@param ZOrder The higher the number, the more on top this widget will be.
        ///</remarks>
        public void AddToViewport(int ZOrder)  => 
            UserWidget_methods.AddToViewport_method.Invoke(ObjPointer, ZOrder);

        ///<summary>Cancels any pending Delays or timer callbacks for this widget.</summary>
        public void CancelLatentActions()  => 
            UserWidget_methods.CancelLatentActions_method.Invoke(ObjPointer);

        ///<summary>Get Alignment in Viewport</summary>
        public Vector2D GetAlignmentInViewport()  => 
            UserWidget_methods.GetAlignmentInViewport_method.Invoke(ObjPointer);

        ///<summary>Get Anchors in Viewport</summary>
        public Anchors GetAnchorsInViewport()  => 
            UserWidget_methods.GetAnchorsInViewport_method.Invoke(ObjPointer);

        ///<summary>
        ///Gets the current time of the animation in this widget
        ///@
        ///</summary>
        ///<remarks>
        ///param The name of the animation to get the current time for
        ///@return the current time of the animation.
        ///</remarks>
        public float GetAnimationCurrentTime(WidgetAnimation InAnimation)  => 
            UserWidget_methods.GetAnimationCurrentTime_method.Invoke(ObjPointer, InAnimation);

        ///<summary>Get Is Visible</summary>
        public bool GetIsVisible()  => 
            UserWidget_methods.GetIsVisible_method.Invoke(ObjPointer);

        ///<summary>Gets the player pawn associated with this UI.</summary>
        ///<remarks>
        ///@return Gets the owning player pawn that's owned by the player controller assigned to this widget.
        ///</remarks>
        public Pawn GetOwningPlayerPawn()  => 
            UserWidget_methods.GetOwningPlayerPawn_method.Invoke(ObjPointer);

        ///<summary>Gets whether an animation is currently playing on this widget.</summary>
        ///<remarks>
        ///@param InAnimation The animation to check the playback status of
        ///@return True if the animation is currently playing
        ///</remarks>
        public bool IsAnimationPlaying(WidgetAnimation InAnimation)  => 
            UserWidget_methods.IsAnimationPlaying_method.Invoke(ObjPointer, InAnimation);

        ///<summary>returns true if the animation is currently playing forward, false otherwise.</summary>
        ///<remarks>
        ///@param InAnimation The playing animation that we want to know about
        ///</remarks>
        public bool IsAnimationPlayingForward(WidgetAnimation InAnimation)  => 
            UserWidget_methods.IsAnimationPlayingForward_method.Invoke(ObjPointer, InAnimation);

        ///<summary>@return True if any animation is currently playing</summary>
        public bool IsAnyAnimationPlaying()  => 
            UserWidget_methods.IsAnyAnimationPlaying_method.Invoke(ObjPointer);

        ///<summary>@return true if the widget was added to the viewport using AddToViewport.</summary>
        public bool IsInViewport()  => 
            UserWidget_methods.IsInViewport_method.Invoke(ObjPointer);

        ///<summary>Checks if the action has a registered callback with the input component.</summary>
        public bool IsListeningForInputAction(Name ActionName)  => 
            UserWidget_methods.IsListeningForInputAction_method.Invoke(ObjPointer, ActionName);

        ///<summary>Are we currently playing any animations?</summary>
        public bool IsPlayingAnimation()  => 
            UserWidget_methods.IsPlayingAnimation_method.Invoke(ObjPointer);

        ///<summary>Listens for a particular Player Input Action by name.</summary>
        ///<remarks>
        ///This requires that those actions are being executed, and
        ///that we're not currently in UI-Only Input Mode.
        ///</remarks>
        public void ListenForInputAction(Name ActionName, byte EventType, bool bConsume, byte Callback /*TODO: delegate FOnInputAction */)  => 
            UserWidget_methods.ListenForInputAction_method.Invoke(ObjPointer, ActionName, EventType, bConsume, Callback);

        ///<summary>
        ///Pauses an already running animation in this widget
        ///@
        ///</summary>
        ///<remarks>
        ///param The name of the animation to pause
        ///@return the time point the animation was at when it was paused, relative to its start position.  Use this as the StartAtTime when you trigger PlayAnimation.
        ///</remarks>
        public float PauseAnimation(WidgetAnimation InAnimation)  => 
            UserWidget_methods.PauseAnimation_method.Invoke(ObjPointer, InAnimation);

        ///<summary>
        ///Plays an animation in this widget a specified number of times
        ///@
        ///</summary>
        ///<remarks>
        ///param InAnimation The animation to play
        ///@param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
        ///@param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
        ///@param PlaybackSpeed The speed at which the animation should play
        ///@param PlayMode Specifies the playback mode
        ///</remarks>
        public void PlayAnimation(WidgetAnimation InAnimation, float StartAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed)  => 
            UserWidget_methods.PlayAnimation_method.Invoke(ObjPointer, InAnimation, StartAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed);

        ///<summary>
        ///Plays an animation in this widget a specified number of times stoping at a specified time
        ///@
        ///</summary>
        ///<remarks>
        ///param InAnimation The animation to play
        ///@param StartAtTime The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
        ///@param EndAtTime The absolute time in the animation where to stop, this is only considered in the last loop.
        ///@param NumLoopsToPlay The number of times to loop this animation (0 to loop indefinitely)
        ///@param PlaybackSpeed The speed at which the animation should play
        ///@param PlayMode Specifies the playback mode
        ///</remarks>
        public void PlayAnimationTo(WidgetAnimation InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed)  => 
            UserWidget_methods.PlayAnimationTo_method.Invoke(ObjPointer, InAnimation, StartAtTime, EndAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed);

        ///<summary>
        ///Plays a sound through the UI
        ///@
        ///</summary>
        ///<remarks>param The sound to play</remarks>
        public void PlaySound(SoundBase SoundToPlay)  => 
            UserWidget_methods.PlaySound_method.Invoke(ObjPointer, SoundToPlay);

        ///<summary>ListenForInputAction will automatically Register an Input Component with the player input system.</summary>
        ///<remarks>
        ///If you however, want to Pause and Resume, listening for a set of actions, the best way is to use
        ///UnregisterInputComponent to pause, and RegisterInputComponent to resume listening.
        ///</remarks>
        public void RegisterInputComponent()  => 
            UserWidget_methods.RegisterInputComponent_method.Invoke(ObjPointer);

        ///<summary>Removes the widget from the viewport.</summary>
        public void RemoveFromViewport()  => 
            UserWidget_methods.RemoveFromViewport_method.Invoke(ObjPointer);

        ///<summary>If an animation is playing, this function will reverse the playback.</summary>
        ///<remarks>
        ///@param InAnimation The playing animation that we want to reverse
        ///</remarks>
        public void ReverseAnimation(WidgetAnimation InAnimation)  => 
            UserWidget_methods.ReverseAnimation_method.Invoke(ObjPointer, InAnimation);

        ///<summary>Set Alignment in Viewport</summary>
        public void SetAlignmentInViewport(Vector2D Alignment)  => 
            UserWidget_methods.SetAlignmentInViewport_method.Invoke(ObjPointer, Alignment);

        ///<summary>Set Anchors in Viewport</summary>
        public void SetAnchorsInViewport(Anchors Anchors)  => 
            UserWidget_methods.SetAnchorsInViewport_method.Invoke(ObjPointer, Anchors);

        ///<summary>Sets the tint of the widget, this affects all child widgets.</summary>
        ///<remarks>
        ///@param InColorAndOpacity     The tint to apply to all child widgets.
        ///</remarks>
        public void SetColorAndOpacity(LinearColor InColorAndOpacity)  => 
            UserWidget_methods.SetColorAndOpacity_method.Invoke(ObjPointer, InColorAndOpacity);

        ///<summary>Set Desired Size in Viewport</summary>
        public void SetDesiredSizeInViewport(Vector2D Size)  => 
            UserWidget_methods.SetDesiredSizeInViewport_method.Invoke(ObjPointer, Size);

        ///<summary>Sets the foreground color of the widget, this is inherited by sub widgets.</summary>
        ///<remarks>
        ///Any color property
        ///that is marked as inherit will use this color.
        ///
        ///@param InForegroundColor     The foreground color.
        ///</remarks>
        public void SetForegroundColor(SlateColor InForegroundColor)  => 
            UserWidget_methods.SetForegroundColor_method.Invoke(ObjPointer, InForegroundColor);

        ///<summary>Set Input Action Blocking</summary>
        public void SetInputActionBlocking(bool bShouldBlock)  => 
            UserWidget_methods.SetInputActionBlocking_method.Invoke(ObjPointer, bShouldBlock);

        ///<summary>Set Input Action Priority</summary>
        public void SetInputActionPriority(int NewPriority)  => 
            UserWidget_methods.SetInputActionPriority_method.Invoke(ObjPointer, NewPriority);

        ///<summary>
        ///Changes the number of loops to play given a playing animation
        ///@
        ///</summary>
        ///<remarks>
        ///param InAnimation The animation that is already playing
        ///@param NumLoopsToPlay The number of loops to play. (0 to loop indefinitely)
        ///</remarks>
        public void SetNumLoopsToPlay(WidgetAnimation InAnimation, int NumLoopsToPlay)  => 
            UserWidget_methods.SetNumLoopsToPlay_method.Invoke(ObjPointer, InAnimation, NumLoopsToPlay);

        ///<summary>Sets the local player associated with this UI via PlayerController reference.</summary>
        ///<remarks>
        ///@param LocalPlayerController The PlayerController of the local player you want to be the conceptual owner of this UI.
        ///</remarks>
        public void SetOwningPlayer(PlayerController LocalPlayerController)  => 
            UserWidget_methods.SetOwningPlayer_method.Invoke(ObjPointer, LocalPlayerController);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            UserWidget_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>
        ///Changes the playback rate of a playing animation
        ///@
        ///</summary>
        ///<remarks>
        ///param InAnimation The animation that is already playing
        ///@param PlaybackRate Playback rate multiplier (1 is default)
        ///</remarks>
        public void SetPlaybackSpeed(WidgetAnimation InAnimation, float PlaybackSpeed)  => 
            UserWidget_methods.SetPlaybackSpeed_method.Invoke(ObjPointer, InAnimation, PlaybackSpeed);

        ///<summary>Sets the widgets position in the viewport.</summary>
        ///<remarks>
        ///@param Position The 2D position to set the widget to in the viewport.
        ///@param bRemoveDPIScale If you've already calculated inverse DPI, set this to false.
        ///Otherwise inverse DPI is applied to the position so that when the location is scaled
        ///by DPI, it ends up in the expected position.
        ///</remarks>
        public void SetPositionInViewport(Vector2D Position, bool bRemoveDPIScale)  => 
            UserWidget_methods.SetPositionInViewport_method.Invoke(ObjPointer, Position, bRemoveDPIScale);

        ///<summary>Stop All actively running animations.</summary>
        ///<remarks>
        ///@param The name of the animation to stop
        ///</remarks>
        public void StopAllAnimations()  => 
            UserWidget_methods.StopAllAnimations_method.Invoke(ObjPointer);

        ///<summary>
        ///Stops an already running animation in this widget
        ///@
        ///</summary>
        ///<remarks>param The name of the animation to stop</remarks>
        public void StopAnimation(WidgetAnimation InAnimation)  => 
            UserWidget_methods.StopAnimation_method.Invoke(ObjPointer, InAnimation);

        ///<summary>Cancels any pending Delays or timer callbacks for this widget, and stops all active animations on the widget.</summary>
        public void StopAnimationsAndLatentActions()  => 
            UserWidget_methods.StopAnimationsAndLatentActions_method.Invoke(ObjPointer);

        ///<summary>Stops listening to all input actions, and unregisters the input component with the player controller.</summary>
        public void StopListeningForAllInputActions()  => 
            UserWidget_methods.StopListeningForAllInputActions_method.Invoke(ObjPointer);

        ///<summary>Removes the binding for a particular action's callback.</summary>
        public void StopListeningForInputAction(Name ActionName, byte EventType)  => 
            UserWidget_methods.StopListeningForInputAction_method.Invoke(ObjPointer, ActionName, EventType);

        ///<summary>StopListeningForAllInputActions will automatically Register an Input Component with the player input system.</summary>
        ///<remarks>
        ///If you however, want to Pause and Resume, listening for a set of actions, the best way is to use
        ///UnregisterInputComponent to pause, and RegisterInputComponent to resume listening.
        ///</remarks>
        public void UnregisterInputComponent()  => 
            UserWidget_methods.UnregisterInputComponent_method.Invoke(ObjPointer);
        ///<summary>The color and opacity of this widget.  Tints all child widgets.</summary>
        public unsafe LinearColor ColorAndOpacity {
            get {return UserWidget_ptr->ColorAndOpacity;}
        }
         //TODO: delegate FGetLinearColor ColorAndOpacityDelegate
        ///<summary>The foreground color of the widget, this is inherited by sub widgets.</summary>
        ///<remarks>
        ///Any color property
        ///that is marked as inherit will use this color.
        ///</remarks>
        public unsafe SlateColor ForegroundColor {
            get {return UserWidget_ptr->ForegroundColor;}
        }
         //TODO: delegate FGetSlateColor ForegroundColorDelegate
        ///<summary>The padding area around the content.</summary>
        public unsafe Margin Padding {
            get {return UserWidget_ptr->Padding;}
        }
        ///<summary>All the sequence players currently playing</summary>
        public ObjectArrayField<UMGSequencePlayer> ActiveSequencePlayers{ get {
            if(ActiveSequencePlayers_store == null) ActiveSequencePlayers_store = new ObjectArrayField<UMGSequencePlayer> (&UserWidget_ptr->ActiveSequencePlayers);
            return ActiveSequencePlayers_store;
        } }
        private ObjectArrayField<UMGSequencePlayer> ActiveSequencePlayers_store;

        ///<summary>List of sequence players to cache and clean up when safe</summary>
        public ObjectArrayField<UMGSequencePlayer> StoppedSequencePlayers{ get {
            if(StoppedSequencePlayers_store == null) StoppedSequencePlayers_store = new ObjectArrayField<UMGSequencePlayer> (&UserWidget_ptr->StoppedSequencePlayers);
            return StoppedSequencePlayers_store;
        } }
        private ObjectArrayField<UMGSequencePlayer> StoppedSequencePlayers_store;

         //TODO: array not UObject TArray NamedSlotBindings
        ///<summary>The widget tree contained inside this user widget initialized by the blueprint</summary>
        public unsafe WidgetTree WidgetTree {
            get {return UserWidget_ptr->WidgetTree;}
            set {UserWidget_ptr->WidgetTree = value;}
        }
        ///<summary>Stores the design time desired size of the user widget</summary>
        public unsafe Vector2D DesignTimeSize {
            get {return UserWidget_ptr->DesignTimeSize;}
            set {UserWidget_ptr->DesignTimeSize = value;}
        }
         //TODO: enum EDesignPreviewSizeMode DesignSizeMode
         //TODO: text FText PaletteCategory
        ///<summary>A preview background that you can use when designing the UI to get a sense of scale on the screen.</summary>
        ///<remarks>
        ///Use
        ///a texture with a screenshot of your game in it, for example if you were designing a HUD.
        ///</remarks>
        public unsafe Texture2D PreviewBackground {
            get {return UserWidget_ptr->PreviewBackground;}
            set {UserWidget_ptr->PreviewBackground = value;}
        }
        ///<summary>Priority</summary>
        public unsafe int Priority {
            get {return UserWidget_ptr->Priority;}
        }
        public bool bIsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFocusable"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFocusable", value); }
        }
        public bool bStopAction {
            get {return Main.GetGetBoolPropertyByName(this, "bStopAction"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopAction", value); }
        }
        public bool bHasScriptImplementedTick {
            get {return Main.GetGetBoolPropertyByName(this, "bHasScriptImplementedTick"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasScriptImplementedTick", value); }
        }
        public bool bHasScriptImplementedPaint {
            get {return Main.GetGetBoolPropertyByName(this, "bHasScriptImplementedPaint"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasScriptImplementedPaint", value); }
        }
        public bool bCookedWidgetTree {
            get {return Main.GetGetBoolPropertyByName(this, "bCookedWidgetTree"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookedWidgetTree", value); }
        }
         //TODO: enum EWidgetTickFrequency TickFrequency
        ///<summary>Input Component</summary>
        public unsafe InputComponent InputComponent {
            get {return UserWidget_ptr->InputComponent;}
            set {UserWidget_ptr->InputComponent = value;}
        }
        static UserWidget() {
            StaticClass = Main.GetClass("UserWidget");
            UserWidget_events.Construct_event.Setup();
            UserWidget_events.Destruct_event.Setup();
            UserWidget_events.IsInteractable_event.Setup();
            UserWidget_events.OnAddedToFocusPath_event.Setup();
            UserWidget_events.OnAnalogValueChanged_event.Setup();
            UserWidget_events.OnDragCancelled_event.Setup();
            UserWidget_events.OnDragDetected_event.Setup();
            UserWidget_events.OnDragEnter_event.Setup();
            UserWidget_events.OnDragLeave_event.Setup();
            UserWidget_events.OnDragOver_event.Setup();
            UserWidget_events.OnDrop_event.Setup();
            UserWidget_events.OnFocusLost_event.Setup();
            UserWidget_events.OnFocusReceived_event.Setup();
            UserWidget_events.OnInitialized_event.Setup();
            UserWidget_events.OnKeyChar_event.Setup();
            UserWidget_events.OnKeyDown_event.Setup();
            UserWidget_events.OnKeyUp_event.Setup();
            UserWidget_events.OnMotionDetected_event.Setup();
            UserWidget_events.OnMouseButtonDoubleClick_event.Setup();
            UserWidget_events.OnMouseButtonDown_event.Setup();
            UserWidget_events.OnMouseButtonUp_event.Setup();
            UserWidget_events.OnMouseCaptureLost_event.Setup();
            UserWidget_events.OnMouseEnter_event.Setup();
            UserWidget_events.OnMouseLeave_event.Setup();
            UserWidget_events.OnMouseMove_event.Setup();
            UserWidget_events.OnMouseWheel_event.Setup();
            UserWidget_events.OnPaint_event.Setup();
            UserWidget_events.OnPreviewKeyDown_event.Setup();
            UserWidget_events.OnPreviewMouseButtonDown_event.Setup();
            UserWidget_events.OnRemovedFromFocusPath_event.Setup();
            UserWidget_events.OnTouchEnded_event.Setup();
            UserWidget_events.OnTouchForceChanged_event.Setup();
            UserWidget_events.OnTouchGesture_event.Setup();
            UserWidget_events.OnTouchMoved_event.Setup();
            UserWidget_events.OnTouchStarted_event.Setup();
            UserWidget_events.PreConstruct_event.Setup();
            UserWidget_events.Tick_event.Setup();
            UserWidget_events.OnAnimationFinished_event.Setup();
            UserWidget_events.OnAnimationStarted_event.Setup();
        }
        internal unsafe UserWidget_fields* UserWidget_ptr => (UserWidget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UserWidget(IntPtr p) => UObject.Make<UserWidget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UserWidget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UserWidget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
