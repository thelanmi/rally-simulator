﻿using System;
using RallySimulator.Application.Abstractions.Messaging;
using RallySimulator.Domain.Primitives.Result;

namespace RallySimulator.Application.Core.Vehicles.Commands.CreateVehicle
{
    /// <summary>
    /// Represents the command for creating a vehicle.
    /// </summary>
    public sealed class CreateVehicleCommand : ICommand<Result>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVehicleCommand"/> class.
        /// </summary>
        /// <param name="raceId">The race identifier.</param>
        /// <param name="teamName">The team name.</param>
        /// <param name="modelName">The model name.</param>
        /// <param name="manufacturingDate">The manufacturing date.</param>
        /// <param name="vehicleSubtype">The vehicle subtype.</param>
        public CreateVehicleCommand(int raceId, string teamName, string modelName, DateTime manufacturingDate, int vehicleSubtype)
        {
            RaceId = raceId;
            TeamName = teamName;
            ModelName = modelName;
            ManufacturingDate = manufacturingDate;
            VehicleSubtype = vehicleSubtype;
        }

        /// <summary>
        /// Gets the race identifier.
        /// </summary>
        public int RaceId { get; }

        /// <summary>
        /// Gets the team name.
        /// </summary>
        public string TeamName { get; }

        /// <summary>
        /// Gets the model name.
        /// </summary>
        public string ModelName { get; }

        /// <summary>
        /// Gets the manufacturing date.
        /// </summary>
        public DateTime ManufacturingDate { get; }

        /// <summary>
        /// Gets the vehicle subtype.
        /// </summary>
        public int VehicleSubtype { get; }
    }
}
