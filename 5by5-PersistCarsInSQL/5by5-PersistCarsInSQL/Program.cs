using Controllers;
using Models;

var lst = ReadFile.GetData();
Console.WriteLine(new CarController().Insert(lst) ? "Sucesso ao inserir os carros" : "Erro ao inserir");