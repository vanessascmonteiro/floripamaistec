float nota1, nota2, nota3, media;

Console.WriteLine("Digite a nota1");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota2");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota3");
nota3 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3) /3;

if(media>=6){
Console.WriteLine("Você está aprovado");
}
else if(media>=5){
    Console.WriteLine("Você está em recuperação");
}
else {
Console.WriteLine("Você está reprovado");
}



