

//#region IF e ELSE

int idade = 9;

if (idade >= 13 && idade< 17)
{
    Console.WriteLine($"Faixa etaria adolecente {idade}");
}
else if (idade > 18 && idade < 35)
{
    Console.WriteLine($"Faixa etaria jovem/adulto {idade}");
}
else if (idade > 36 && idade <59)
{
    Console.WriteLine($"Faixa etaria adulto {idade}");
}
else if (idade == 60 || idade >60 )
{
    Console.WriteLine($"Faixa etaria idoso {idade}");
}
else if (idade < 13)
{
    Console.WriteLine($"Faixa etaria criança {idade}");
}
