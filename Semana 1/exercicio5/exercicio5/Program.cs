double lado1;
double lado2;
double lado3; 
double triangulo;

Console.WriteLine ("Qual o taamnho da lado1 do triângulo?");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Qual o tamanho do lado2 do triângulo?");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine ("Qual o tamanho do lado3 do triângulo?"); 
lado3 = double.Parse(Console.ReadLine());

if(lado1 + lado2 > lado3 && lado3 + lado2 > lado1 && lado3 + lado1 > lado2){
Console.WriteLine("é um triângulo");
if(lado1 == lado2 && lado1 ==lado3)
Console.WriteLine("Equilátero");
else
if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
Console.WriteLine("Isosceles");
else
Console.WriteLine("Escaleno");
}
else {
Console.WriteLine("Não forma um triângulo");
}










    





