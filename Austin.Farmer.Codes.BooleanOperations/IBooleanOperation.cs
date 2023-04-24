namespace Austin.Farmer.Codes.BooleanOperations;

/// <summary>
/// Represents something that can perform a boolean operation on two boolean values.
/// </summary>
public interface IBooleanOperation
{
    /// <summary>
    /// Operates on the <paramref name="left"/> and <paramref name="right"/> operands.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <returns>The result of the boolean operation.</returns>
    public bool Operate(bool left, bool right);

    public string Name { get; set; }
}