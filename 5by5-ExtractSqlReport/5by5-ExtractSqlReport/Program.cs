using Controllers;
using Models;
using Services;

new CarQueryService().GenerateXML(new CarQueryController().GetCars(Car.SELECTCARSWITHTRUESERVICE), 1);
new CarQueryService().GenerateXML(new CarQueryController().GetCars(Car.SELECTCARSBETWEEN20102011), 2);
new CarQueryService().GenerateXML(new CarQueryController().GetCars(Car.SELECTRED), 3);