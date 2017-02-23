﻿using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.Core.Patterns.Infrastructure;
using FlaUI.UIA2.Identifiers;
using UIA = System.Windows.Automation;

namespace FlaUI.UIA2.Patterns
{
    public class TransformPattern : PatternBase<UIA.TransformPattern>, ITransformPattern
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.TransformPattern.Pattern.Id, "Transform", AutomationObjectIds.IsTransformPatternAvailableProperty);
        public static readonly PropertyId CanMoveProperty = PropertyId.Register(AutomationType.UIA2, UIA.TransformPattern.CanMoveProperty.Id, "CanMove");
        public static readonly PropertyId CanResizeProperty = PropertyId.Register(AutomationType.UIA2, UIA.TransformPattern.CanResizeProperty.Id, "CanResize");
        public static readonly PropertyId CanRotateProperty = PropertyId.Register(AutomationType.UIA2, UIA.TransformPattern.CanRotateProperty.Id, "CanRotate");

        public TransformPattern(BasicAutomationElementBase basicAutomationElement, UIA.TransformPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }
        
        public ITransformPatternProperties Properties => Automation.PropertyLibrary.Transform;

        public bool CanMove => Get<bool>(CanMoveProperty);

        public bool CanResize => Get<bool>(CanResizeProperty);

        public bool CanRotate => Get<bool>(CanRotateProperty);

        public void Move(double x, double y)
        {
            NativePattern.Move(x, y);
        }

        public void Resize(double width, double height)
        {
            NativePattern.Resize(width, height);
        }

        public void Rotate(double degrees)
        {
            NativePattern.Rotate(degrees);
        }
    }

    public class TransformPatternProperties : ITransformPatternProperties
    {
        public PropertyId CanMoveProperty => TransformPattern.CanMoveProperty;

        public PropertyId CanResizeProperty => TransformPattern.CanResizeProperty;

        public PropertyId CanRotateProperty => TransformPattern.CanRotateProperty;
    }
}
