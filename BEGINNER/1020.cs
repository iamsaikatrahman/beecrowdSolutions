namespace Beecrowd
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = Convert.ToInt32(Console.ReadLine());

			int ano = input / 365;
			int retrunAno = input % 365;
			int mes = retrunAno / 30;
			int returnMes = retrunAno % 30;
			int dia = returnMes % 30;

			Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");
		}
	}
}
