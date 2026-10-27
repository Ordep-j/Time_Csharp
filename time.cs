using System;
using static System.Console;
using static System.Convert;
					
public class Program
{
	public static void Main()
	{
		string time1;
		string time2;
		int titulo1;
		int titulo2;
		int opcao;
		
		do{
			WriteLine("Digite o nome do primeiro time:");
			time1 = ReadLine();
			WriteLine("Digite a quantidade de titulos de mundiais FIFA do primeiro time:");
			titulo1 = ToInt16(ReadLine());
		
			WriteLine("Digite o nome do segundo time:");
			time2 = ReadLine();
			WriteLine("Digite a quantidade de titulos de mundiais FIFA do segundoo time:");
			titulo2 = ToInt16(ReadLine());
			Clear();
			if (titulo1 > titulo2)
			{
				WriteLine("====================================");
				WriteLine("O " + time1 + " é maior que o " + time2);
			}
			else if (titulo1 < titulo2)
			{
				WriteLine("====================================");
				WriteLine("O " + time2 + " é maior que o " + time1);
			}
			else if (titulo1 == 0 && titulo2 == 0)
			{
				WriteLine("====================================");
				WriteLine("O " + time1 + " e o " + time2 + " são pequenos!");
			}
			else
			{
				WriteLine("====================================");
				WriteLine("O " + time1 + " é igual ao " + time2);
			}
			WriteLine("====================================");
			WriteLine("Deseja continuar? ");
			WriteLine("1 => Sim");
			WriteLine("2 => Não");
			opcao = ToInt16(ReadLine());
			WriteLine("====================================");
			Clear();
		} while(opcao == 1);
		WriteLine("Finalizado!");
		ReadKey();
	}
}