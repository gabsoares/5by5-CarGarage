using Controllers;
using Models;
using Services;

Service service = new()
{
    Description = "Pintura"
};

CarServiceModel carServiceModel = new()
{
    Car = new Car { CarPlate = "VIN3836" },
    Service = new Service { Id = 2 },
    Status = true
};

Car car = new()
{
    CarPlate = new CarService().GenerateCarPlate(),
    CarName = "Corsa",
    ModelYear = 2012,
    FabricationYear = 2011,
    CarColor = "Preto"
};

//Console.WriteLine(new ServiceController().InsertService(service) ? "Sucesso ao inserir servico!" : "Erro ao inserir servico!");
//Console.WriteLine(new CarServiceController().InsertCarService(carServiceModel) ? "Sucesso ao inserir carro-servico" : "Erro ao inserir carro-servico");
Console.WriteLine(new CarController().InsertCar(car) ? "Sucesso ao inserir carro!" : "Erro ao inserir carro!");