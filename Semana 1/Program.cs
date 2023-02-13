int tabuada; 
int num = 0;
int resultado;

Console.WriteLine("Informe o número da tabuada: "); 
tabuada = int.Parse(Console.ReadLine());

for(num = 0; num <= 10; num++){
    resultado = (tabuada * num);
    Console.WriteLine($"O resultado da tabuada é  " + resultado);

}

