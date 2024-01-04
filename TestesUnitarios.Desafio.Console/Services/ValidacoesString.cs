namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            //Length é usado para contar os caracteres de uma string
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
              //Contrains é usado para filtrar um caractere de uma lista/string e retorna um bool
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            //EndWith é usado para inspecionar se a string termina com o parâmetro especificado e retorna um bool
            return termina;
        }
    }
}