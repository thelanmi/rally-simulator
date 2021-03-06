﻿using RallySimulator.Application.Abstractions.Messaging;
using RallySimulator.Domain.Core;
using RallySimulator.Domain.Primitives.Result;

namespace RallySimulator.Application.Core.Races.Commands.CreateRace
{
    /// <summary>
    /// Represents the command for creating a race.
    /// </summary>
    public sealed class CreateRaceCommand : ICommand<Result>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRaceCommand"/> class.
        /// </summary>
        /// <param name="year">The year.</param>
        public CreateRaceCommand(int year)
        {
            Year = year;
            Length = Race.DefaultLength;
        }

        /// <summary>
        /// Gets the year.
        /// </summary>
        public int Year { get; }

        /// <summary>
        /// Gets the length.
        /// </summary>
        public decimal Length { get; }
    }
}
