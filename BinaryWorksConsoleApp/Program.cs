using BinaryWorksConsoleApp;

BinaryWorks binaryWorks = new BinaryWorks();

for (int i = 0; i < 33; i++)
{
    Console.WriteLine($"* {i} - {binaryWorks.ToBinary(i)} - {binaryWorks.Cardinality(binaryWorks.ToBinary(i), '1')}");

    Console.WriteLine($"* {i} - {binaryWorks.ToDecimal(binaryWorks.ToBinary(i))}");
}
