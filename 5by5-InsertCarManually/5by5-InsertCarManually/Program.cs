using Controllers;
using Models;
using Services;

Service service = new()
{
    Description = "Estetica automotiva"
};

CarServiceModel carServiceModel = new()
{
    Car = new Car { CarPlate = "KYU2531" },
    Service = new Service { Id = 4 },
    Status = true
};

Car car = new()
{
    CarPlate = new CarService().GenerateCarPlate(),
    CarName = "Corvette ZR1",
    ModelYear = 2025,
    FabricationYear = 2024,
    CarColor = "Preto fosco"
};

//Console.WriteLine(new ServiceController().InsertService(service) ? "Sucesso ao inserir servico!" : "Erro ao inserir servico!");
//Console.WriteLine(new CarServiceController().InsertCarService(carServiceModel) ? "Sucesso ao inserir carro-servico" : "Erro ao inserir carro-servico");
//Console.WriteLine(new CarController().InsertCar(car) ? "Sucesso ao inserir carro!" : "Erro ao inserir carro!");