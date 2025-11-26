using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista validacoesLista = new ValidacoesLista();

List<int> numeros = new List<int>{-8, -5, -3, -2, 0, 2, 5, 6, 10};

Console.WriteLine("==========NÚMEROS=========");
Console.WriteLine(
    $"{string.Join(", ", numeros)}"
);
Console.WriteLine("==========================\n");

Console.WriteLine(
    $"Lista sem números negativos: {string.Join(", ", validacoesLista.RemoverNumerosNegativos(numeros))}\n"
);

int numeroEscolhido = 5;

Console.WriteLine($"Número {numeroEscolhido} na lista? {validacoesLista.ListaContemDeterminadoNumero(numeros, numeroEscolhido)}\n");

int numeroMultiplicaLista = 2;

Console.WriteLine(
    $"Lista com números multiplicados por {numeroMultiplicaLista}: {string.Join(", ", validacoesLista.MultiplicarNumerosLista(numeros, numeroMultiplicaLista))}\n"
);

Console.WriteLine($"Maior número da lista: {validacoesLista.RetornarMaiorNumeroLista(numeros)}\n");

Console.WriteLine($"Menor número da lista: {validacoesLista.RetornarMenorNumeroLista(numeros)}\n");

// ==========================================================================================================

ValidacoesString validacoesString = new ValidacoesString();

string texto = "Hello, World!";

Console.WriteLine("==========TEXTO=========");
Console.WriteLine(
    $"  {texto}"
);
Console.WriteLine("==========================\n");

Console.WriteLine($"O texto '{texto}' possuí {validacoesString.RetornarQuantidadeCaracteres(texto)} caracteres.\n");

string caractereEscolhido = "l";

Console.WriteLine($"O caractere '{caractereEscolhido}' está presente no texto? {validacoesString.ContemCaractere(texto, caractereEscolhido)}.\n");

string fimTexto = "rld!";

Console.WriteLine($"O texto termina com {fimTexto}? {validacoesString.TextoTerminaCom(texto, fimTexto)}.\n");