using Models;
using System.Text.Json;

Random random = new();

GenerateJson(GenerateCar());

List<String> GenerateCar()
{
    List<String> cars = new();

    for (int i = 0; i <= 30; i++)
    {
        int carRandomYear = random.Next(1995, 2025);
        int carRandomModelYear = random.Next(carRandomYear, carRandomYear + 2);

        Car car = new()
        {
            CarPlate = GenerateCarPlate(),
            CarColor = GenerateCarColor(),
            ModelYear = carRandomModelYear,
            FabricationYear = carRandomYear,
            CarName = GenerateCarName()
        };

        cars.Add(car.ToString());

    }
    return cars;
}

string GenerateCarName()
{
    List<String> carName = new() { "Lamborghini", "Ferrari", "Fusca", "Marea", "Toro", "Argo", "Jeep", "Hilux" };
    string carNameRandom = carName[random.Next(0, carName.Count - 1)];

    return carNameRandom;
}

string GenerateCarPlate()
{
    string plateLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


    string carPlateLetters = "";
    for (int y = 0; y < 3; y++)
    {
        carPlateLetters += plateLetters[random.Next(0, plateLetters.Length)];
    }

    string carPlateNumbers = "";
    for (int j = 0; j < 4; j++)
    {
        carPlateNumbers += random.Next(0, 9);
    }

    string carPlate = carPlateLetters + carPlateNumbers;

    return carPlate;
}

string GenerateCarColor()
{
    List<String> carColor = new() { "Amarelo", "Vermelho", "Azul", "Branco", "Preto", "Creme", "Cinza", "Rosa" };
    string carColorRandom = carColor[random.Next(0, carColor.Count - 1)];

    return carColorRandom;
}

void GenerateJson(List<String> cars)
{
    List<Object> formattedDataList = new();
    foreach (var item in cars)
    {
        string carPlate = item.Split('.')[0];
        string carName = item.Split('.')[1];
        string carColor = item.Split('.')[2];
        string fabricationYear = item.Split('.')[3];
        string modelYear = item.Split('.')[4];

        var formattedData = new
        {
            car_plate = carPlate,
            car_name = carName,
            car_color = carColor,
            modelYear = fabricationYear,
            fabrication_year = modelYear
        };

        formattedDataList.Add(formattedData);

    }
    var jsonDataObject = new { car = formattedDataList };

    JsonSerializerOptions op = new()
    {
        WriteIndented = true
    };
    try
    {
        string jsonData = JsonSerializer.Serialize(jsonDataObject, op);

        string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\CarGarage\\";
        string file = "Cars.json";

        CreateFileAndDir(path, file);

        StreamWriter sw = new(path + file);
        sw.Write(jsonData);
        sw.Close();
    }
    catch (Exception)
    {
        throw;
    }
}

void CreateFileAndDir(string path, string file)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(file))
    {
        File.Create(file).Close();
    }
}