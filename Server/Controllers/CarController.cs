using Microsoft.AspNetCore.Mvc;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{
    
    [Route("/carcontroller")]
    public class CarController 
    {
        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars()
        { 
            List<Car> cars = new List<Car>();
            cars.Add(new Car
            {
                CarId = 1,
                Image="Cars/golf.jpg",
                Brand = "vw",
                Model = "Golf",
                Year = 2007,
                Km = 170000,
                Price = 40000,
                Description = "steering gear shift,17 alloy wheels, fully automatic climate control, 2 zone climate control,fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, externaltemp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 2,
                Image = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000,
                Description = "auto., steering gear shift, 17 alloy wheels, fully automatic climate control, 2 zone climate control, fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, external temp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 2,
                Image = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000,
                Description = "auto., steering gear shift, 17 alloy wheels, fully automatic climate control, 2 zone climate control, fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, external temp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 2,
                Image = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000,
                Description = "auto., steering gear shift, 17 alloy wheels, fully automatic climate control, 2 zone climate control, fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, external temp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 2,
                Image = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000,
                Description = "auto., steering gear shift, 17 alloy wheels, fully automatic climate control, 2 zone climate control, fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, external temp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 2,
                Image = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000,
                Description = "auto., steering gear shift, 17 alloy wheels, fully automatic climate control, 2 zone climate control, fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, external temp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            cars.Add(new Car
            {
                CarId = 1,
                Image = "Cars/golf.jpg",
                Brand = "vw",
                Model = "Golf",
                Year = 2007,
                Km = 170000,
                Price = 40000,
                Description = "steering gear shift,17 alloy wheels, fully automatic climate control, 2 zone climate control,fridge in glove compartment, remote c. lock, keyless operation, cruise control, on - board computer, info center, immobilizer, auto. fold - down rear - view mirror, externaltemp. gauge, rain sensor, heated seats, height - adjustable front seats, height-adjustable driver's seat, sunroof, electric sunroof, glass roof, 4x electric windows, electric folding side mirrors with heating, rear camera, parking sensor (bag), parking sensor (on), adaptive cruise control, automatic start /stop, tire pressure gauge, electric parking brake, CD/radio, navigation, multifunction steering wheel, bluetooth, music streaming via bluetooth, android auto, apple carplay, sd card reader, usb connection, aux connection, armrests, isofix, cup holder, fabric upholstery, leather steering wheel, split rear seat, headlight washer , automatic lights, high beam assistant, cornering lights, led daytime running lights, full led headlights, 7 airbags, antispin, abs, esp, servo, automatic emergency braking system, dark-tinted rear windows, non-smoker, newly inspected, service ok, Please note that our prices include all delivery costs - Fee for number plates is NOK 1,380 subject to typing errors and car data, WE OFFER FINANCING...! WK Cars"
            });
            return cars; 
        }
    }
}
