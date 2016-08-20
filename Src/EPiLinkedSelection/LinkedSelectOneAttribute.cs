﻿using System;

namespace EPiLinkedSelection
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="EPiLinkedSelection.LinkedSelectAttribute" />
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LinkedSelectOneAttribute : LinkedSelectAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedSelectOneAttribute" /> class.
        /// </summary>
        /// <param name="linkedSelectionFactoryType">Type of the linked selection factory.</param>
        public LinkedSelectOneAttribute(Type linkedSelectionFactoryType) 
            : base(linkedSelectionFactoryType, "epi-linked-selection/LinkedSelectionEditor")
        {
        }
    }
}
