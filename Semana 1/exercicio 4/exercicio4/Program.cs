double salario;
double desconto1;
double desconto2;
double desconto3;

Console.WriteLine("Entre com o valor do salário");
salario = double.Parse(Console.ReadLine());

if(salario <= 900){
    Console.WriteLine("0");
}

if((salario > 900) && (salario <= 1500)){
    desconto1 = (salario * 0.05);

Console.WriteLine(desconto1); 

}

if ((salario > 1500) && (salario <= 2500 )){
    desconto2 = (salario * 0.10);
    Console.WriteLine(desconto2);
}
else if ((salario > 2500)){
    desconto3 = (salario * 0.20);
    Console.WriteLine(desconto3);

}



