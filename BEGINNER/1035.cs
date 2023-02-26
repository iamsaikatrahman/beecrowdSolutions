namespace Beecrowd
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputValues = Console.ReadLine().Split(' ');
			int A = int.Parse(inputValues[0]);
			int B = int.Parse(inputValues[1]);
			int C = int.Parse(inputValues[2]);
			int D = int.Parse(inputValues[3]);

			int sumCD = C + D;
			int SumAB = A + B;

			if (B > C && D > A && sumCD > SumAB && C > 0 && D > 0 && A % 2 == 0)
			{
				Console.WriteLine("Valores aceitos");
			}
			else
			{
				Console.WriteLine("Valores nao aceitos");
            }
		}
	}
}
