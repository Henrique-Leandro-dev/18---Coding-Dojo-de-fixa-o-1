using System;
namespace Aula18_dojo
{  

    public class Jogador
    {
        
   public string Nome { get;set; }
        public int Idade { get;set; }
        public string Nacionalidade { get;set; }
        public string Posicao { get;set; }
        public DateTime DataDeNascimento { get;set; }
        public float Peso { get;set; }
        public float Altura { get;set; }
        
        public int CalcularIdade(){

            int AnoAtual = Int32.Parse(DateTime.Now.ToString().Split ("/") [2].Split (" ") [0]);
            int DataNascimento = Int32.Parse(DataDeNascimento.ToString().Split("/")[2].Split(" ") [0]  );

            Idade = AnoAtual - DataNascimento;

            return Idade;
        
        }

        public string VerificarAposentadoria(string Posicao, string Nome){
            
            string Mensagem = "";

            if (Idade >= 35 && Posicao == "ATA")
            {
                Mensagem = $"{Nome} deve se aposentar";

            }else if (Idade >= 38 && Posicao == "MC"){

                Mensagem = $"{Nome} deve se aposentar";

            }else if (Idade >= 40 && Posicao == "DEF"){

                Mensagem = $"{Nome} deve se aposentar"; 

            }else if (Idade >= 0 && Idade <=16){

                Mensagem = $"{Nome} ainda não é um jogador profissional";

            }else{

                Mensagem = $"{Nome} não atingiu a idade suficiente para se aposentar!";
            }
            
            return Mensagem; 

        }


    }
}  
