float nota1, nota2, nota3, media; 
string aluno;


Console.WriteLine("Digite o nome do aluno");
aluno = (Console.ReadLine());

Console.WriteLine("Digite a nota1");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3");
nota3 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3) /3;

float[] nota = new float[3];
nota[0] = nota1;
nota[1] = nota2;
nota[2] = nota3;

if(media>=6){
    Console.WriteLine(aluno);
    Console.WriteLine("N1 " + nota1);
    Console.WriteLine("N2 " + nota2);
    Console.WriteLine("N3 " + nota3);
    Console.WriteLine("media " + media + " aprovado");

}
else if(media>=5){
    Console.WriteLine(aluno);
    Console.WriteLine("N1 " + nota1);
    Console.WriteLine("N2 " + nota2);
    Console.WriteLine("N3 " + nota3);
    Console.WriteLine("media " + media + " em recuperação");

}
else {
    Console.WriteLine(aluno);
    Console.WriteLine("N1 " + nota1);
    Console.WriteLine("N2 " + nota2);
    Console.WriteLine("N3 " + nota3);
    Console.WriteLine("media " + media + " reprovado");
    

}

