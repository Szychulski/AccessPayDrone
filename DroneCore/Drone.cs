using DroneCore.Commands;
using DroneCore.Components;
using DroneCore.Navigation;
using DroneCore.States;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DroneTests")]

namespace DroneCore
{
    public class Drone : IDroneState
    {
        private readonly INavModule _navModule;
        private readonly IDroneLights _lights;
        private readonly IDroneHorn _horn;

        public Drone(INavModule navModule)
        {
            _navModule = navModule;
        }

        public Coordinates CurrentPosition { get; protected set; }

        public IDroneState State { get; set; }

        public IDroneLights Lights { get; protected set; }

        public IDroneHorn Horn { get; protected set; }

        public Coordinates InitialPosition => State.InitialPosition;

        public Coordinates Boundary => State.Boundary;

        public void SetBoundary(Coordinates coordinates)
        {
            State.SetBoundary(coordinates);
        }

        public void SetInitialPosition(Coordinates coordinates)
        {
            State.SetInitialPosition(coordinates);
        }

        public void Restart()
        {
            State.Restart();
        }

        public void Shutdown()
        {
            State.Shutdown();
        }

        public void Start()
        {
            State.Start();
        }

        public void ToggleLights()
        {
            _lights.Toggle();
        }

        public void Flash()
        {
            _lights.Flash();
        }

        public void Alert(int seconds)
        {
            _horn.Alert(TimeSpan.FromSeconds(seconds));
        }

        public void Move(int durationInSeconds, int directionAngle)
        {
            MoveResult moveResult = _navModule.Move(TimeSpan.FromSeconds(durationInSeconds), directionAngle);
            CurrentPosition = moveResult.CurrentPosition;

            if (moveResult.TriedToCrossBorder)
            {
                Alert(1);
                Alert(1);
                Alert(1);
            }
        }

        public void ExecuteCommands(IEnumerable<ICommand> commands)
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

    }
}
