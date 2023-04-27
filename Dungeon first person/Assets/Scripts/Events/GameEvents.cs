using System;

public class GameEvents
{ 
  public delegate void HandlePlayerTouchGround();
  public static HandlePlayerTouchGround OnPlayerTouchGround;
}

// use example
// GameEvents.OnPlayerTouchGround += FunctionName; //register event
// GameEvents.OnPlayerTouchGround -= FunctionName; //unregister event
// GameEvents.OnPlayerTouchGround?.Invoke(); //call event