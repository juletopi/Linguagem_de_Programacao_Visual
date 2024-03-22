namespace AppExemploString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de Formatação de Caracteres

            // Exemplo 1: Substituindo caracteres na string
            string str = "Hello";
            string resultado = str.Replace("l", "w");

            Console.WriteLine(str); // <-- Texto original
            Console.WriteLine(resultado); // <-- Texto com caracteres substituídos
            Console.WriteLine();

            // Exemplo 2: Substituindo palavras na string
            string str1 = "Leite em pó";
            string resultado2 = str1.Replace("Leite", "Achocolatado");

            Console.WriteLine(str1); // <-- Texto original
            Console.WriteLine(resultado2); // <-- Texto com palavras substituídas
            Console.WriteLine();

            // Exemplo 3: Concatenando strings
            string str3 = "Olá";
            string textoadd = str3 + " Mundo!";

            Console.WriteLine(textoadd); // <-- Texto combinado
            Console.WriteLine();

            // Exemplo 4: Concatenando strings com números
            int n = 3;
            string textoadd2 = "A " + n + "º palavra";

            Console.WriteLine(textoadd2); // <-- Texto com número
            Console.WriteLine();

            // Exemplo 5: Convertendo para maiúsculas
            string str4 = "hello";
            string maiusculo = str4.ToUpper();

            Console.WriteLine(str4); // <-- Texto original
            Console.WriteLine(maiusculo); // <-- Texto em maiúsculo
            Console.WriteLine();

            // Exemplo 6: Convertendo para minúsculas
            string str5 = "HELLO";
            string minusculo = str5.ToLower();

            Console.WriteLine(str5); // <-- Texto original
            Console.WriteLine(minusculo); // <-- Texto em minúsculo
            Console.WriteLine();

            // Exemplo 7: Removendo espaços em branco
            string str6 = "Vamos aprender Java? >:) ";
            Console.WriteLine(str6); // <-- Texto original

            string res = str6.Trim();
            Console.WriteLine(res); // <-- Texto sem espaços em branco
            Console.WriteLine();

            // Exemplo 8: Comparando strings
            string str7 = "Hello";
            string str8 = "Hell0";

            bool bol1 = str7.Equals("Hello"); // <-- Comparando com uma string literal
            bool bol2 = str7.Equals(str8); // <-- Comparando com outra string

            Console.WriteLine("1: " + bol1);
            Console.WriteLine("2: " + bol2);
            Console.WriteLine();

            // Exemplo 9: Manipulando partes de uma string
            string tel = "6940028922";

            string ddd = tel.Substring(0, 2); // <-- Obtendo os primeiros dígitos
            string num1 = tel.Substring(2, 4); // <-- Obtendo parte do meio
            string num2 = tel.Substring(6); // <-- Obtendo os últimos dígitos

            string mask = $"({ddd}){num1}-{num2}";
            Console.WriteLine(mask); // <-- Texto formatado

            string tel2 = "(69) 4002-8922";

            string ddd2 = tel2.Substring(1, 2); // <-- Obtendo os primeiros dígitos
            string num3 = tel2.Substring(5, 4); // <-- Obtendo parte do meio
            string num4 = tel2.Substring(10); // <-- Obtendo os últimos dígitos

            string noMask = ddd2 + num3 + num4;
            Console.WriteLine(noMask); // <-- Texto sem máscara
            Console.WriteLine();

            // Exemplo 10: Separando e formatando informações
            string nome1 = "Carmen Gizelle/90/85/70";
            string nome2 = "Ruben Laerte/80/80/45";
            string nome3 = "Maxwell Kelvin/75/80/40";
            string nome4 = "Tobias Arruda/78/85/90";

            string[] nomes = { nome1, nome2, nome3, nome4 };

            foreach (string aluno in nomes)
            {
                string[] info = aluno.Split('/');

                string nome = info[0];
                string matematica = info[1];
                string portugues = info[2];
                string ciencias = info[3];

                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Matemática: {matematica}");
                Console.WriteLine($"L. Portuguesa: {portugues}");
                Console.WriteLine($"Ciências: {ciencias}");
                Console.WriteLine();
            }

            // Atividade proposta em sala: Conversão de data
            Console.Write("Digite a data no formato dd/mm/aaaa: ");
            string data = Console.ReadLine();

            string[] partesData = data.Split('/');
            string dia = partesData[0];
            string mes = partesData[1];
            string ano = partesData[2];

            string dataAmericana = $"{ano}/{mes}/{dia}";

            Console.WriteLine("\nData no formato americano: " + dataAmericana);

            Console.ReadKey();
        }
    }
}