﻿namespace PatchManager.SassyPatching.Nodes.Expressions.Binary;

public abstract class Binary : Expression
{
    public Expression LeftHandSide;
    public Expression RightHandSide;

    protected Binary(Coordinate c, Expression leftHandSide, Expression rightHandSide) : base(c)
    {
        LeftHandSide = leftHandSide;
        RightHandSide = rightHandSide;
    }

    public abstract Value GetResult(Value leftHandSide, Value rightHandSide);

    public abstract bool ShortCircuitOn(Value value);

    public abstract Value ShortCircuitValue { get; }
}