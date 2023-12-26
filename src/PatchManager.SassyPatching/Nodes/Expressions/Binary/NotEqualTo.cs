﻿namespace PatchManager.SassyPatching.Nodes.Expressions.Binary;
/// <summary>
/// Represents a binary expression that returns true if both of its children are not equal
/// </summary>
public class NotEqualTo : Binary
{
    internal NotEqualTo(Coordinate c, Expression leftHandSide, Expression rightHandSide) : base(c, leftHandSide, rightHandSide)
    {
    }

    internal override DataValue GetResult(DataValue leftHandSide, DataValue rightHandSide) =>
        leftHandSide != rightHandSide;

    internal override bool ShortCircuitOn(DataValue dataValue) => false;

    internal override DataValue ShortCircuitDataValue => null;
}