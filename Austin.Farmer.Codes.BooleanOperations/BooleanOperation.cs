namespace Austin.Farmer.Codes.BooleanOperations;

public class BooleanOperation : IBooleanOperation
{
    private readonly Func<bool, bool, bool> Operation;

    public BooleanOperation(Func<bool, bool, bool> operation, string name, string operationStr)
    {
        Operation = operation;
        Name = name;
        OperationStr = operationStr;
    }

    public string Name { get; set; }
    private string OperationStr { get; set; }
    public bool Operate(bool left, bool right) => Operation.Invoke(left, right);
    public override string ToString() => $"{Name.ToUpper()} ( {OperationStr} )";
}