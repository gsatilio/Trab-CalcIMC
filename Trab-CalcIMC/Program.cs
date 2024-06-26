﻿//6 - faça um programa que leia o peso, altura e sexo (m,f,0 1) de uma pessoa e calcule o seu IMC informando a situação da pessoa

int genero, i = 0;
double altura, peso, calculo;
string mensagem, n1, n2 , n3, n4, n5, sair;


sair = "N";

while (sair != "S" && sair != "s")
{
    //n1 = "";
    //n2 = "";
    //n3 = "";
    //n4 = "";
    //n5 = "";
    //mensagem = "";
    string[] msgfinal = new string[30];
    Console.WriteLine("Olá! Por favor, informe se você é:\n0 - Homem\n1 - Mulher");
    genero = int.Parse(Console.ReadLine());

    while (genero != 0 && genero != 1)
    {
        Console.WriteLine("Humm, você precisa informar se você é:\n0 - Homem\n1 - Mulher");
        genero = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Maravilha! Agora informe a sua altura em metros. Por exemplo, 1,8 para 1,80m.");
    altura = double.Parse(Console.ReadLine());

    while (altura <= 0)
    {
        Console.WriteLine("Você precisa ter alguma altura! Informe novamente, por gentileza.");
        altura = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("Obrigado. Agora informe o seu peso em kg. Por exemplo, 70 para 70kg.");
    peso = double.Parse(Console.ReadLine());

    while (peso <= 0)
    {
        Console.WriteLine("Ninguém é tão leve assim. Informe novamente, por gentileza.");
        peso = double.Parse(Console.ReadLine());
    }

    calculo = ((peso) / (altura * altura));
    mensagem = $" <--- Você está aqui (seu IMC: {calculo})";

    switch (calculo)
    {
        case <= 18.5:
            msgfinal[1] = mensagem;
            break;
        case <= 24.9:
            msgfinal[2] = mensagem;
            break;
        case <= 29.9:
            msgfinal[3] = mensagem;
            break;
        case <= 39.9:
            msgfinal[4] = mensagem;
            break;
        default:
            msgfinal[5] = mensagem;
            break;
    }

    switch (genero)
    {
        case 0:
            Console.WriteLine("Você é do gênero: Masculino");
            break;
        case 1:
            Console.WriteLine("Você é do gênero: Feminino");
            break;
        default:
            Console.WriteLine("Escolha uma das opções.");
            break;
    }
    /*
    if (calculo <= 18.5)
    {
        n1 = mensagem;
    }
    else if (calculo > 18.5 && calculo <= 24.9)
    {
        n2 = mensagem;
    }
    else if (calculo > 24.9 && calculo <= 29.9)
    {
        n3 = mensagem;
    }
    else if (calculo > 29.9 && calculo <= 39.9)
    {
        n4 = mensagem;
    }
    else
    {
        n5 = mensagem;
    }

    if (genero == 0)
    {
        Console.WriteLine("Você é do gênero: Masculino");
    }
    else
    {
        Console.WriteLine("Você é do gênero: Feminino");
    }
    */

    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("             IMC            | CLASSIFICAÇÃO     | OBESIDADE (GRAU)");
    Console.WriteLine($"MENOR QUE   18,5            | MAGREZA           |   0   {msgfinal[1]}");
    Console.WriteLine($"ENTRE       18,5 E 24,9     | NORMAL            |   0   {msgfinal[2]}");
    Console.WriteLine($"ENTRE       25,0 E 29,9     | SOBREPESO         |   I   {msgfinal[3]}");
    Console.WriteLine($"ENTRE       30,0 E 39,9     | OBESIDADE         |   II  {msgfinal[4]}");
    Console.WriteLine($"MAIOR QUE   40,0            | OBESIDADE GRAVE   |   III {msgfinal[5]}");
    Console.WriteLine("------------------------------------------------------------------");

    Console.WriteLine("Digite S para sair do programa ou aperte qualquer tecla para repetir.");
    sair = Console.ReadLine();
    if (sair != "S" && sair != "s")
    {
        Console.Clear();
    }
}

Console.ReadKey();