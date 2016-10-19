﻿//---------------------------------------------------------------------------
// <copyright file="RibbonQuickAccessToolBarCloneEventArgs.cs" company="Microsoft Corporation">
//     Copyright (C) Microsoft Corporation.  All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

using System;
using System.Windows;

namespace Microsoft.Windows.Controls.Ribbon
{
    /// <summary>
    ///     Event args for DismissPopup event.
    /// </summary>
    public class RibbonQuickAccessToolBarCloneEventArgs : RoutedEventArgs
    {
        /// <summary>
        ///   This is an instance constructor for the RibbonQuickAccessToolBarCloneEventArgs class.  It
        ///   is constructed with a reference to the UIElement being cloned.
        /// </summary>
        /// <param name="targetElement">UIElement to be cloned.</param>
        public RibbonQuickAccessToolBarCloneEventArgs(UIElement targetElement)
        {
            _instanceToBeCloned = targetElement;
            this.RoutedEvent = RibbonQuickAccessToolBar.CloneEvent;
        }

        public UIElement InstanceToBeCloned
        {
            get
            {
                return _instanceToBeCloned;
            }
        }

        public UIElement CloneInstance
        {
            get;
            set;
        }

        /// <summary>
        ///   This method is used to perform the proper type casting in order to
        ///   call the type-safe RibbonQuickAccessToolBarCloneEventArgs delegate for the RibbonQuickAccessToolBarCloneEvent event.
        /// </summary>
        /// <param name="genericHandler">The handler to invoke.</param>
        /// <param name="genericTarget">The current object along the event's route.</param>
        /// <returns>Nothing.</returns>
        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget)
        {
            RibbonQuickAccessToolBarCloneEventHandler handler = (RibbonQuickAccessToolBarCloneEventHandler)genericHandler;
            handler(genericTarget, this);
        }

        private UIElement _instanceToBeCloned;
    }
}