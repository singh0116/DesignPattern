namespace CreationalPattern.Prototype
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    /// <summary>
    /// Concrete Prototype
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    [Serializable]
    class Employee : ICloneable
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of employee.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this employee is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if employee is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the total experience.
        /// </summary>
        /// <value>
        /// The total experience.
        /// </value>
        public float TotalExperience { get; set; }

        /// <summary>
        /// Gets or sets the blood group.
        /// </summary>
        /// <value>
        /// The blood group.
        /// </value>
        public BloodGroup BloodGroup { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the department of employee.
        /// </summary>
        /// <value>
        /// Employee department.
        /// </value>
        public Department Department { get; set; }

        /// <summary>
        /// Creates an object that is a deep copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object of this instance.
        /// </returns>
        public object Clone()
        {
            return Clone(true);
        }

        /// <summary>
        /// Creates a copy of the current instance.
        /// </summary>
        /// <param name="deepCopy">Deep copy is required or not.</param>
        /// <returns>Returns deep copy or shallow copy of this instance based on the boolean parameter.</returns>
        public object Clone(bool deepCopy)
        {
            return deepCopy ? DeepCopy() : ShallowCopy();
        }

        /// <summary>
        /// Deep copy of this instance.
        /// </summary>
        /// <returns>Deep copy</returns>
        private object DeepCopy()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;

                    return formatter.Deserialize(stream);
                }

                return null;
            }
        }

        /// <summary>
        /// Shallow copy of this instance.
        /// </summary>
        /// <returns>Shallow copy</returns>
        private object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }

    /// <summary>
    /// Department
    /// </summary>
    [Serializable]
    public class Department
    {
        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        /// <value>
        /// The department name.
        /// </value>
        public string Name { get; set; }
    }

    /// <summary>
    /// Blood Group
    /// </summary>
    public enum BloodGroup
    {
        APositive,
        BPositive,
        ABPositive,
        OPositive,
        ANegetive,
        BNegetive,
        ABNegetive,
        ONegetive
    }
}
