namespace FakeItEasy
{
    using System;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Represents a definition of how dummies of the specified type should be created.
    /// </summary>
    [InheritedExport]
    public interface IDummyDefinition
    {
        /// <summary>
        /// The type of fake object the definition is for.
        /// </summary>
        Type ForType { get; }

        /// <summary>
        /// Creates the fake.
        /// </summary>
        /// <returns>The fake object.</returns>
        object CreateDummy();
    }
}