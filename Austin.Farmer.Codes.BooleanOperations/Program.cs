// See https://aka.ms/new-console-template for more information

using Austin.Farmer.Codes.BooleanOperations;

const string tblFormat = "| {0, 6} | {1, 6} | {2, 6} |";
BooleanOperation and = new((left, right) => left && right, nameof(and), "&&");
BooleanOperation or = new((left, right) => left || right, nameof(or), "||");
bool[] bools = {true, false};
BooleanOperation[] operations = {and, or};

foreach (BooleanOperation operation in operations)
{
    Console.WriteLine($"<<=== {operation} ===>>");
    Console.WriteLine(tblFormat, "Left", "Right", "Result");
    foreach (bool left in bools)
    {
        foreach (bool right in bools)
        {
            Console.WriteLine(tblFormat, left.ToString(), right.ToString(), operation.Operate(left, right).ToString());
        }
    }
    Console.WriteLine();
}