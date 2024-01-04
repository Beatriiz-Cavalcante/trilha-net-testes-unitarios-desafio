namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            //Where é usado para filtrar os elementos da lista de acordo com uma condição
            return listaSemNegativos.ToList();
            //ToList() converte a sequência filtrada em uma nova lista
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            //Contrains é usado para filtrar um caractere de uma lista e retorna um bool
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            //Select transforma cada elemento de uma lista de acordo com uma condição
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
            //Max retornar o maior elemento da sequência
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
            //Min retornar o menor elemento da sequência
        }
    }
}
