namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }

        public List<int> RemoverNumero10(List<int> lista)
        {
            var listaSemNumero10 = lista.Where(x => x != 10);
            return listaSemNumero10.ToList();
        }

        public List<int> MultiplicarNumerosListaPor2(List<int> lista)
        {
            var listaMultiplicada = lista.Select(x => x * 2).ToList();
            return listaMultiplicada;
        }

        public List<int> Retornar9ComoMaiorNumeroLista(List<int> lista)
        {
            var maiorNumero = 0;
            foreach (var numero in lista)
            {
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }
             return new List<int> { maiorNumero };
        }

        public List<int> RetornarOitoComoMenorNumeroLista(List<int> lista)
        {
            var menorNumero = 0;
            foreach (var numero in lista)
            {
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }
             return new List<int> { menorNumero };
        }

    }
}
