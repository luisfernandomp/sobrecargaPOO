namespace prjSobrecarga
{
    public class Calculo
    {
        public string calcularVida(){
            return "Não houve nenhum cálculo a ser aplicado";
        }
        public string calcularVida(int vida){
            return "A vida do jogador está com "+vida;
        }
        public string calcularVida(int vida, int escudo){
            return "A vida do jogador com escudo é "+(vida+escudo);
        }
        public string calcularVida(string nome, string sobrenome){
            return $"O nome completo do jogador: {nome} {sobrenome} ";
        }
    }
}