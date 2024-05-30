﻿namespace DriveEase.Infrastructure.Persistance.Extensions
{
    static class ModelBuilderExtensionsCars
    {
        public static void SeedCars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Brand = "Audi",
                    Model = "Q7",
                    ImageURL = "content/images/audi-q7.jpg",
                    LogoURL = "content/images/Audi.PNG",
                    Year = 2023,
                    LicensePlate = "WW 12345",
                    VinNumber = "1HGBH41JXMN109186",
                    Color = "Black",
                    Mileage = "73621",
                    FuelType = Domain.Enums.FuelTypeEngines.Diesel,
                    Transmission = "Automatic",
                    Engine = "3.0 TDI",
                    InsurancePolicyNumber = "123456789",
                    IsAvailable = true,
                    Power = "300",
                    CarReviewDate = new DateTime(2025, 12, 12),
                    AddDate = new DateTime(2023, 3, 11),
                    Features = new List<string> { "Leather seats", "Navigation", "Parking sensors" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 2,
                    Brand = "BMW",
                    Model = "Series 7",
                    ImageURL = "content/images/bmw-series-7.jpg",
                    LogoURL = "content/images/BMW.PNG",
                    Year = 2024,
                    LicensePlate = "WH 54321",
                    VinNumber = "1HGBH41JXMN109187",
                    Color = "White",
                    Mileage = "3211",
                    FuelType = Domain.Enums.FuelTypeEngines.Petrol,
                    Transmission = "Automatic",
                    Engine = "2.0 TDI",
                    InsurancePolicyNumber = "987654321",
                    IsAvailable = true,
                    Power = "340",
                    CarReviewDate = new DateTime(2026, 10, 12),
                    AddDate = new DateTime(2024, 5, 11),
                    Features = new List<string> { "Air Conditioning", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 3,
                    Brand = "Mercedes",
                    Model = "S Class",
                    ImageURL = "content/images/mercedes-s-class.jpg",
                    LogoURL = "content/images/BMW.PNG",
                    Year = 2019,
                    LicensePlate = "WX 982733",
                    VinNumber = "1VWBH41JXMB109239",
                    Color = "Silver",
                    Mileage = "21402",
                    FuelType = Domain.Enums.FuelTypeEngines.Diesel,
                    Transmission = "Automatic",
                    Engine = "2.5 TDI",
                    InsurancePolicyNumber = "AB234BS2342",
                    IsAvailable = false,
                    Power = "140",
                    CarReviewDate = new DateTime(2024, 10, 12),
                    AddDate = new DateTime(2021, 5, 17),
                    Features = new List<string> { "Parking camera", "Heated seats", "Cruise control" },
                    Status = Domain.Enums.CarStatus.Reserved
                },
                new Car
                {
                    Id = 4,
                    Brand = "Volkswagen",
                    Model = "Golf V",
                    ImageURL = "content/images/vw-golf-V.jpg",
                    LogoURL = "content/images/VW.PNG",
                    Year = 2008,
                    LicensePlate = "WH 50230",
                    VinNumber = "VVWBH41JXMB109523",
                    Color = "Blue",
                    Mileage = "123456",
                    FuelType = Domain.Enums.FuelTypeEngines.Diesel,
                    Transmission = "Manual",
                    Engine = "1.9 TDI",
                    InsurancePolicyNumber = "XY234BS2452DS",
                    IsAvailable = false,
                    Power = "120",
                    CarReviewDate = new DateTime(2024, 06, 10),
                    AddDate = new DateTime(2018, 5, 17),
                    Features = new List<string> { "Navigation", "Heated seats", "Cruise control" },
                    Status = Domain.Enums.CarStatus.Rented
                },
                new Car
                {
                    Id = 5,
                    Brand = "Toyota",
                    Model = "Yaris",
                    ImageURL = "content/images/toyota-yaris.jpg",
                    LogoURL = "content/images/toyota.png",
                    Year = 2015,
                    LicensePlate = "SK 839032",
                    VinNumber = "TOYBH41JXMB109633",
                    Color = "Red",
                    Mileage = "65432",
                    FuelType = Domain.Enums.FuelTypeEngines.Petrol,
                    Transmission = "Manual",
                    Engine = "1.4 TSI",
                    InsurancePolicyNumber = "ZZ234BS2452776U",
                    IsAvailable = true,
                    Power = "80",
                    CarReviewDate = new DateTime(2024, 07, 13),
                    AddDate = new DateTime(2015, 11, 17),
                    Features = new List<string> { "Parking camera", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 6,
                    Brand = "Ford",
                    Model = "Mustang",
                    ImageURL = "content/images/ford-mustang.jpg",
                    LogoURL = "content/images/Ford.PNG",
                    Year = 2018,
                    LicensePlate = "LBI 50EK",
                    VinNumber = "FORDH41JXMB109544",
                    Color = "Yellow",
                    Mileage = "222332",
                    FuelType = Domain.Enums.FuelTypeEngines.Petrol,
                    Transmission = "Manual",
                    Engine = "5.0 V8",
                    InsurancePolicyNumber = "AA234BS24526SA",
                    IsAvailable = true,
                    Power = "280",
                    CarReviewDate = new DateTime(2025, 07, 13),
                    AddDate = new DateTime(2019, 09, 22),
                    Features = new List<string> { "Leather seats", "Parking camera", "ESP" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 7,
                    Brand = "Nissan",
                    Model = "Leaf",
                    ImageURL = "content/images/nissan-leaf.jpg",
                    LogoURL = "content/images/Ford.PNG",
                    Year = 2010,
                    LicensePlate = "KR 90332",
                    VinNumber = "NISANH41JXMB109555",
                    Color = "Green",
                    Mileage = "188222",
                    FuelType = Domain.Enums.FuelTypeEngines.Electric,
                    Transmission = "Manual",
                    Engine = "Electric",
                    InsurancePolicyNumber = "BB234BS2452DSD",
                    IsAvailable = false,
                    Power = "100",
                    CarReviewDate = new DateTime(2024, 08, 13),
                    AddDate = new DateTime(2019, 09, 22),
                    Features = new List<string> { "Parking camera", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.InService
                },
                new Car
                {
                    Id = 8,
                    Brand = "Hyundai",
                    Model = "Tuscon",
                    ImageURL = "content/images/hyundai_tucson_suv_ce11.jpg",
                    LogoURL = "content/images/Hyundai.PNG",
                    Year = 2023,
                    LicensePlate = "LBI 12345",
                    VinNumber = "HYUNH41JXMB109566",
                    Color = "Black",
                    Mileage = "5623",
                    FuelType = Domain.Enums.FuelTypeEngines.Petrol,
                    Transmission = "Automatic",
                    Engine = "2.0 TFSI",
                    InsurancePolicyNumber = "CC234BS245AS42",
                    IsAvailable = true,
                    Power = "160",
                    CarReviewDate = new DateTime(2026, 08, 13),
                    AddDate = new DateTime(2023, 09, 22),
                    Features = new List<string> { "ESP", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 9,
                    Brand = "Kia",
                    Model = "ProCeed",
                    ImageURL = "content/images/kia-proceed-gt.jpg",
                    LogoURL = "content/images/Hyundai.PNG",
                    Year = 2023,
                    LicensePlate = "WB 39883",
                    VinNumber = "KIAH41JXMB109577",
                    Color = "White",
                    Mileage = "1234",
                    FuelType = Domain.Enums.FuelTypeEngines.Diesel,
                    Transmission = "Manual",
                    Engine = "1.6 TDI",
                    InsurancePolicyNumber = "DD234BS2452DS",
                    IsAvailable = true,
                    Power = "190",
                    CarReviewDate = new DateTime(2026, 09, 11),
                    AddDate = new DateTime(2023, 03, 22),
                    Features = new List<string> { "Parking camera", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.Available
                },
                new Car
                {
                    Id = 10,
                    Brand = "Tesla",
                    Model = "Model S",
                    ImageURL = "content/images/tesla-model-S.jpg",
                    LogoURL = "content/images/Tesla.PNG",
                    Year = 2018,
                    LicensePlate = "KR 6721",
                    VinNumber = "TESANH41JXMB109SLA",
                    Color = "Green",
                    Mileage = "11222",
                    FuelType = Domain.Enums.FuelTypeEngines.Electric,
                    Transmission = "Manual",
                    Engine = "Electric",
                    InsurancePolicyNumber = "TE234BS24529876",
                    IsAvailable = false,
                    Power = "90",
                    CarReviewDate = new DateTime(2025, 09, 11),
                    AddDate = new DateTime(2021, 03, 22),
                    Features = new List<string> { "Parking camera", "ABS", "Rain sensors" },
                    Status = Domain.Enums.CarStatus.Reserved
                });
        }
    }
}
