﻿using System;

namespace Reinforced.Typings.Attributes
{
    /// <summary>
    ///     Base attribute for so-called compilation unit (class, enum, interface etc)
    /// </summary>
    public abstract class TsDeclarationAttributeBase : TsAttributeBase
    {
        /// <summary>
        ///     Constructs new instance of TsDeclarationAttributeBase
        /// </summary>
        protected TsDeclarationAttributeBase()
        {
            // ReSharper disable VirtualMemberCallInConstructor
            IncludeNamespace = true;
            // ReSharper restore VirtualMemberCallInConstructor
            FlattenLimiter = typeof(object);
        }

        /// <summary>
        ///     Place to corresponding namespace
        /// </summary>
        public virtual bool IncludeNamespace { get; set; }

        /// <summary>
        ///     Overrides namespace
        /// </summary>
        public virtual string Namespace { get; set; }

        /// <summary>
        ///     Overrides name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Sets order this membter will be written to output file in
        /// </summary>
        public double Order { get; set; }

        /// <summary>
        /// Gets or sets whether to generate properties/methods flattering inheritance hierarchy
        /// </summary>
        public bool FlattenHierarchy { get; set; }

        /// <summary>
        /// Flattering limiter. 
        /// All types "deeper" than specified parent will not be considered as exporting members donors
        /// </summary>
        public Type FlattenLimiter { get; set; }
    }
}