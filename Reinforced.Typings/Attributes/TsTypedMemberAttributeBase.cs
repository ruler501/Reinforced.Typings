﻿namespace Reinforced.Typings.Attributes
{
    /// <summary>
    ///     Base attribute for class members and method parameters
    /// </summary>
    public abstract class TsTypedMemberAttributeBase : TsTypedAttributeBase
    {
        /// <summary>
        ///     When true them member name will be camelCased regardless configuration setting
        /// </summary>
        public bool ShouldBeCamelCased { get; set; }

        /// <summary>
        ///     When true them member name will be PascalCased regardless configuration setting
        /// </summary>
        public bool ShouldBePascalCased { get; set; }

        /// <summary>
        ///     Overrides member name
        /// </summary>
        public virtual string Name { get; set; }

        
    }
}