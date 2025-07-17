
double salario_anual, servicos_anual, capital_anual, medico_anual, educacao_anual;


Console.Write("Renda anual com salário: ");
salario_anual = double.Parse(Console.ReadLine());
Console.Write("Renda anual com prestção de serviço: ");
servicos_anual = double.Parse(Console.ReadLine());
Console.Write("Renda anual com ganho de capital: ");
capital_anual = double.Parse(Console.ReadLine());
Console.Write("Gastos médicos: ");
medico_anual = double.Parse(Console.ReadLine());
Console.Write("Gastos educacionais: ");
educacao_anual = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA");
Console.WriteLine();

Console.WriteLine("CONSOLIDADO DE RENDA:");
Console.WriteLine();
Console.Write("Imposto sobre salário: " + Imposto(salario_anual));
Console.WriteLine();
Console.Write("Imposto sobre serviços: " + ImpostoServicos(servicos_anual));
Console.WriteLine();
Console.Write("Imposto sobre ganho de capital: " + ImpostoCapital(capital_anual));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("DEDUÇÕES:");
Console.WriteLine();
Console.Write("Máximo dedutível: " + 0.3 * (Imposto(salario_anual) + ImpostoCapital(capital_anual) + ImpostoServicos(servicos_anual)));
Console.WriteLine();
Console.Write("Gastos dedutíveis: " + (medico_anual + educacao_anual));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("RESUMO:");
Console.WriteLine();
Console.Write("Imposto bruto total: " + (Imposto(salario_anual) + ImpostoCapital(capital_anual) + ImpostoServicos(servicos_anual)));
Console.WriteLine();
Console.Write("Abatimento: " + Deducao(medico_anual, educacao_anual, salario_anual, servicos_anual, capital_anual));
Console.WriteLine();
Console.Write("Imposto devido: " + (Imposto(salario_anual) + ImpostoCapital(capital_anual) + ImpostoServicos(servicos_anual)
    - Deducao(medico_anual, educacao_anual, salario_anual, servicos_anual, capital_anual)));







//Funções//
static double Imposto(double salario_anual)
{
    if (salario_anual > 60000)
    {
        return salario_anual * 0.2;
    }
    else if (salario_anual > 36000 && salario_anual <= 60000)
    {
        return salario_anual * 0.10;
    }
    else
    {
        return 0;
    }
}

static double ImpostoCapital(double capital_anual)
{
    return capital_anual * 0.2;
}

static double ImpostoServicos(double servicos_anual)
{
    return servicos_anual * 0.15;
}

static double Deducao(double medico_anual, double educacao_anual, double salario_anual, double servicos_anual, double capital_anual)
{
    if (medico_anual + educacao_anual > 0.3 * (Imposto(salario_anual) + ImpostoCapital(capital_anual) + ImpostoServicos(servicos_anual))){
        return 0.3 * (Imposto(salario_anual) + ImpostoCapital(capital_anual) + ImpostoServicos(servicos_anual));
    }
    else
    {
        return medico_anual + educacao_anual;
    }


}
