int QteDias;
double maiorPeso = 0;
double menorPeso = 9999999;
double menorDiferenca = 9999999;
double maiorDiferenca = 0;
double TotalDiferenca = 0;
double Perda = 0;
double Ganho = 0;
double PerdaDia = 0;
double GanhoDia = 0;

Console.WriteLine("Digite a quantidade de dias em dieta");

QteDias = int.Parse(Console.ReadLine());

double[] PessoPessoaDia = new double[QteDias];

for (int i = 0; i < PessoPessoaDia.Length; i++) {
    Console.WriteLine("Digite seu peso nas seguintes datas, dia:" + (i+1));
    var valor = double.Parse(Console.ReadLine());
    PessoPessoaDia[i] = valor;

    if (valor > maiorPeso) { maiorPeso = valor; }

    if (valor < menorPeso) { menorPeso = valor; }  
}

Console.WriteLine("O maior peso de um dia para o outro é " + maiorPeso);
Console.WriteLine("O menor peso de um dia para o outro é " + menorPeso);

for (int i = 0; i < PessoPessoaDia.Length - 1; i++) {
    var resultado = PessoPessoaDia[i] - PessoPessoaDia[i + 1];
    if (menorDiferenca > Math.Abs(resultado)) { menorDiferenca = Math.Abs(resultado); }

    TotalDiferenca += resultado;

    if (maiorDiferenca < Math.Abs(resultado)) { maiorDiferenca = Math.Abs(resultado); }

    if (resultado > 0) { Perda += resultado; PerdaDia++; } 
    else { Ganho -= resultado; GanhoDia++; }
}

Console.WriteLine("A maior diferença foi: " + maiorDiferenca);
Console.WriteLine("A menor diferenca foi: " + menorDiferenca);
Console.WriteLine("O total da diferenca foi: " + TotalDiferenca);
Console.WriteLine("Media diaria de ganho de peso foi" + (Ganho/GanhoDia));
Console.WriteLine("Media diaria de perda de peso foi" + (Perda / PerdaDia));

if (TotalDiferenca > 0) { Console.WriteLine("Parabens voce perdeu " + TotalDiferenca + " de peso do inicio da dieta ate agora"); } 
else { Console.WriteLine("Infelizmente voce nao consegiu perde peso"); }



