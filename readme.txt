Drone state machine
States:
 - Created
 - Started
 - Initiated (Process action commands)

Transitions:
 - Created (Start) => Started
 - Started (SetBoundary) => Initiated
 - Initiated (Restart) => Started
 - Initiated (Shutdown) => Created
 - Initiated (SetInitialPosition) => Initiated