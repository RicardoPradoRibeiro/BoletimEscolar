using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    public class CadastroAlunos
    {
        public string Nome { get; set; }
        public double Serie { get; set; }
        public string Escola { get; set; }
        public static double MediaFinal { get; private set; }
        public static double Portugues { get; private set; }
        public static double Ciencias { get; private set; }
        public static double Matematica { get; private set; }
        public static double Geografia { get; private set; }
        public static double Ed_Fisica { get; private set; }
        public static double En_Religioso { get; private set; }
        public static double Historia { get; private set; }
        public static double Ingles { get; private set; }
        public static double Artes { get; private set; }


        public CadastroAlunos()
        {
        }

        public CadastroAlunos(string nome, int serie, string escola)
        {
            Nome = nome;
            Serie = serie;
            Escola = escola;

        }

        static List<CadastroAlunos> Notas = new List<CadastroAlunos>();

        public static void MenuPrincipal()
        {
            var aluno = new CadastroAlunos();

            Console.Write("Informe o Nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a Série que o aluno está: ");
            int serie = int.Parse(Console.ReadLine());
            Console.Write("Informe a Escola: ");
            string escola = Console.ReadLine();
            Notas.Add(new CadastroAlunos(nome, serie, escola)); 
            
            Console.WriteLine("------------------------------");


            Console.WriteLine("Informe as notas do Aluno por Bimestre: ");
            Console.WriteLine();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("---------Bimestre#"+i+ "---------");
                Console.WriteLine("Informe a nota do aluno em Matemática: ");
                double notaMat = double.Parse(Console.ReadLine() ?? "0");
                Matematica += notaMat;

                Console.WriteLine("Informe a nota do aluno em Português: ");
                double notaPort = double.Parse(Console.ReadLine() ?? "0");
                Portugues += notaPort;

                Console.WriteLine("Informe a nota do aluno em Ciências: ");
                double notaCiencias = double.Parse(Console.ReadLine() ?? "0");
                Ciencias += notaCiencias;

                Console.WriteLine("Informe a nota do aluno em Geografia: ");
                double notaGeo = double.Parse(Console.ReadLine() ?? "0");
                Geografia += notaGeo;
                Console.WriteLine("Informe a nota do aluno em História: ");
                double notaHist = double.Parse(Console.ReadLine() ?? "0");
                Historia += notaHist;
                Console.WriteLine("Informe a nota do aluno em Educação Física: ");
                double notaEdFisica = double.Parse(Console.ReadLine() ?? "0");
                Ed_Fisica += notaEdFisica;

                Console.WriteLine("Informe a nota do aluno em Ensino Religioso: ");
                double notaEnsReligioso = double.Parse(Console.ReadLine() ?? "0");
                En_Religioso += notaEnsReligioso;

                Console.WriteLine("Informe a nota do aluno em Inglês: ");
                double notaIngles = double.Parse(Console.ReadLine() ?? "0");
                Ingles += notaIngles;

                Console.WriteLine("Informe a nota do aluno em Artes: ");
                double notaArtes = double.Parse(Console.ReadLine() ?? "0");
                Artes += notaArtes;

                Console.WriteLine("________________________________");
                MediaFinal = ((notaMat + notaPort + notaCiencias + notaGeo + notaHist + notaEdFisica + notaEnsReligioso + notaIngles + notaArtes) / 9.0) / 10.0;

            }
            Console.WriteLine();
            MediasMaterias();
            Listagem();
            

            
            
            



        






        }

        public static void Listagem()
        {

            foreach(var aluno in Notas)
            {
                Console.WriteLine("Dados Do aluno: " + aluno.Nome +", da "+  aluno.Serie + "º Serie, do colégio " + aluno.Escola);
                Console.WriteLine("Medias Finais: ");
                Console.Write("Portugês: " + Portugues.ToString("F1"));
                Console.WriteLine();
                Console.Write("Matêmatica: " + Matematica.ToString("F1"));
                Console.WriteLine();
                Console.Write("ciências: " + Ciencias.ToString("F1"));
                Console.WriteLine();
                Console.Write("Geografia: " + Geografia.ToString("F1"));
                Console.WriteLine();
                Console.Write("Ed.Fisica: " + Ed_Fisica.ToString("F1"));
                Console.WriteLine();
                Console.Write("En. Religioso: " + En_Religioso.ToString("F1"));
                Console.WriteLine();
                Console.Write("História: " + Historia.ToString("F1"));
                Console.WriteLine();
                Console.Write("Inglês: " + Ingles.ToString("F1"));
                Console.WriteLine();
                Console.Write("Artes: " + Artes.ToString("F1"));
                Console.WriteLine();
                Console.WriteLine("Aproveitamento: ");
                Console.WriteLine(MediaFinal.ToString("F1"));



            }





        }

        public static void MediasMaterias()
        {
            Portugues = (Portugues / 4.0) / 10;
            Matematica = (Matematica / 4.0) / 10;
            Ciencias = (Ciencias / 4.0) / 10;
            Geografia = (Geografia / 4.0) / 10;
            Ed_Fisica = (Ed_Fisica / 4.0) / 10;
            En_Religioso = (En_Religioso / 4.0) / 10;
            Historia = (Historia / 4.0) / 10;
            Ingles = (Ingles / 4.0) / 10;
            Artes = (Artes / 4.0) / 10;
        }
        public static void Aproveitamento()
        {
            MediaFinal = (MediaFinal / 4.0) / 10.0;
        }































    }
}


















