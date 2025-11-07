using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


//Pessoa edu = new Pessoa();
//edu.Nome = "Eduardo Mendes";
//edu.Idade = 43;
//edu.Altura = 166;

//edu.Falar();
//edu.Dormir();

/*
Garrafa Stanley = new Garrafa();
Stanley.Cor = "Azul Goiaba";
Stanley.Capacidade = 1000;
Stanley.Formato = "Cilindrico";
Stanley.Tamanho = 32;

Console.WriteLine($"Abrindo a Garrafa Stanley: ");
Stanley.Abrir();

Console.WriteLine($"Bebendo Agua da Garrafa Stanley: ");
Stanley.Beber();*/


Console.Clear();
Pessoa Edu = new Pessoa();
Edu.Nome = "Eduardo Mendes";
Edu.Altura = 166;
Edu.Envelhecer();//1
Console.WriteLine($"{Edu.Nome} tem {Edu.Idade} Ano(s)");
Edu.Envelhecer();
Console.WriteLine($"{Edu.Nome} tem {Edu.Idade} Ano(s)");

