﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Collections.Immutable;

namespace Core2D.Shapes.Interfaces
{
    /// <summary>
    /// Defines point shape contract.
    /// </summary>
    public interface IConnectableShape : IShape
    {
        /// <summary>
        /// Gets or sets connectors collection.
        /// </summary>
        ImmutableArray<IPointShape> Connectors { get; set; }
    }
}
