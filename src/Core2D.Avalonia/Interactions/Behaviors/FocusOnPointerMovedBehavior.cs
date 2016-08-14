﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Xaml.Interactivity;

namespace Core2D.Avalonia.Interactions.Behaviors
{
    /// <summary>
    /// Focuses the AssociatedObject on PointerMoved event.
    /// </summary>
    public class FocusOnPointerMovedBehavior : Behavior<Control>
    {
        /// <inheritdoc/>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PointerMoved += PointerMoved;
        }

        /// <inheritdoc/>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.PointerMoved -= PointerMoved;
        }

        private void PointerMoved(object sender, PointerEventArgs args)
        {
            AssociatedObject.Focus();
        }
    }
}
