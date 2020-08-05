namespace CreationalPattern.Prototype
{
    using CorePattern.Core;
    using CreationalPattern.Properties;
    using System;

    /// <summary>
    /// Prototype Design Pattern
    /// </summary>
    public class PrototypeApp : IBubbleApp
    {
        /// <summary>
        /// Executes this pattern instance
        /// </summary>
        public void Execute()
        {
            Employee employee = new Employee
            {
                Name = "John",
                BloodGroup = BloodGroup.ABNegetive,
                DateOfBirth = new DateTime(2010, 1, 1),
                Department = new Department { Name = "ABC" },
                IsActive = true,
                TotalExperience = 2.4f
            };

            // Deep Copy
            var deep = employee.Clone() as Employee;
            deep.Department.Name = "XYZ";

            if (employee.Department.Name != deep.Department.Name)
            {
                BubbleDisplay.Info(Resources.NON_IDENTICAL_OBJECT);
            }

            // Shallow Copy
            var shallow = employee.Clone(false) as Employee;
            shallow.Department.Name = "JKL";

            if (employee.Department.Name == shallow.Department.Name)
            {
                BubbleDisplay.Info(Resources.IDENTICAL_OBJECT);
            }
        }
    }
}
