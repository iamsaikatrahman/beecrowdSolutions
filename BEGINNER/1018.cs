namespace Beecrowd
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = Convert.ToInt32(Console.ReadLine());

			int hundredNotes = input / 100;
			int hundredModulo = input % 100;
			int fiftyNotes = hundredModulo / 50;
			int fiftyModulo = hundredModulo % 50;
			int twentyNotes = fiftyModulo / 20;
			int twentyModulo = fiftyModulo % 20;
			int tenNotes = twentyModulo / 10;
			int tenModulo = twentyModulo % 10;
			int fiveNotes = tenModulo / 5;
			int fiveModulo = tenModulo % 5;
			int twoNotes = fiveModulo / 2;
			int twoModulo = fiveModulo % 2;
			int oneNotes = twoModulo / 1;

			Console.WriteLine($"{input}\n{hundredNotes} nota(s) de R$ 100,00\n{fiftyNotes} nota(s) de R$ 50,00\n{twentyNotes} nota(s) de R$ 20,00\n{tenNotes} nota(s) de R$ 10,00\n{fiveNotes} nota(s) de R$ 5,00\n{twoNotes} nota(s) de R$ 2,00\n{oneNotes} nota(s) de R$ 1,00");
		}
	}
}
