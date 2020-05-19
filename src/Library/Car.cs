//--------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Template
{
    /// <summary>
    /// This class represents a Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="brand">The car brand.</param>
        public Car(string brand)
        {
            this.Brand = brand;
            this.IsOn = false;
        }

        /// <summary>
        /// Property for get the Car brand.
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Property for get if the cars ir working.
        /// </summary>
        public bool IsOn { get; private set; }

        /// <summary>
        /// Method for turn off the car.
        /// </summary>
        public void TurnOn()
        {
            this.IsOn = true;
        }

        /// <summary>
        /// Method for turn on the car.
        /// </summary>
        public void TurnOff()
        {
            this.IsOn = false;
        }
    }
}
