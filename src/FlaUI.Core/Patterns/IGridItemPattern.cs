﻿using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns.Infrastructure;

namespace FlaUI.Core.Patterns
{
    public interface IGridItemPattern : IPattern
    {
        IGridItemPatternProperties Properties { get; }
        int Column { get; }
        int ColumnSpan { get; }
        AutomationElement ContainingGrid { get; }
        int Row { get; }
        int RowSpan { get; }
    }

    public interface IGridItemPatternProperties
    {
        PropertyId ColumnProperty { get; }
        PropertyId ColumnSpanProperty { get; }
        PropertyId ContainingGridProperty { get; }
        PropertyId RowProperty { get; }
        PropertyId RowSpanProperty { get; }
    }
}
