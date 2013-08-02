Units.NET
========

Data structures and methods in C# .NET that make life working with units just a little bit better.

Everyone have written their share of trivial conversions between meters and centimeters, or less obvious conversions to units like Pascal and PSI where most mortals need a quick Google to find that magic constant.

Stop littering your code with unnecessary calculations. Units.NET gives you all the common units and conversions. It is light-weight, unit tested and supports [PCL](http://msdn.microsoft.com/en-us/library/gg597391.aspx "MSDN PCL").


Install
=======
To install Units.NET, run the following command in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console) or go to the [NuGet site](https://www.nuget.org/packages/UnitsNet/ "NuGet site").

![Install-Package UnitsNet](Docs/Images/install_package_unitsnet.png "Install-Package UnitsNet")

Build Targets:
* .NET 3.5 Client
* Silverlight 4
* WinRT / .NET Core 4.5
* Portable Class Library (.NET 4.0 + Silverlight 4 + Windows Phone 7 + Xbox 360)

Features
========

* Immutable structs for units of measurement, such as Length, Mass, Force and Pressure. See full list [here](https://github.com/InitialForce/UnitsNet/blob/master/Src/UnitsNet/ "Data structures").
* Convert between most popular units in the metric and imperial systems. See full list [here](https://github.com/InitialForce/UnitsNet/blob/master/Src/UnitsNet/Unit.cs "Unit.cs").
* Choose between static (struct) or dynamic (UnitValue) representations for units of measurement.
* Parse abbreviations to unit.
* Get abbreviations for units in different cultures.

Static Representation and Explicit Conversion
-----------------------------------------------
```C#
// Stop postfixing your variables and method names with the unit...
double weightKg = GetPersonWeightInKg();
double weightGrams = weightKg * 1000;
double weightTonnes = weightKg / 1000;

// ...and start using a static representation for the measurement then 
// explicitly convert to the unit of choice - when you need it.
Mass weight = GetPersonWeight();
double weightGrams = weight.Grams;
double weightTonnes = weight.Tonnes;

// Convert between compatible units of measurement...
Force scaleMeasurement = Force.FromNewtons(850);
Mass personWeight = Mass.FromGravitationalForce(scaleMeasurement);
double weightKg = personWeight.Kilograms;

// ...while avoiding confusing conversions, such as between weight and mass.
Mass weight = GetPersonWeight();
double weightNewtons = weight.Newtons; // No such thing.

// Some popular conversions.
Length meter = Length.FromMeters(1);
double cm = meter.Centimeters; // 100
double yards = meter.Yards; // 1.09361
double feet = meter.Feet; // 3.28084
double inches = meter.Inches; // 39.3701

Pressure p = Pressure.FromPascal(1);
double kpa = p.KiloPascals; // 1000
double bar = p.Bars; // 1 × 10-5
double atm = p.Atmosphere; // 9.86923267 × 10-6
double psi = p.Psi; // 1.45037738 × 10-4
```

Dynamic Representation and Conversion
------------------
```C#
// Explicitly
double m = UnitConverter.Convert(1, Unit.Kilometer, Unit.Meter); // 1000
double mi = UnitConverter.Convert(1, Unit.Kilometer, Unit.Mile); // 0.621371
double yds = UnitConverter.Convert(1, Unit.Meter, Unit.Yard); // 1.09361

// Or dynamically.
UnitValue val = GetUnknownValueAndUnit();

// Returns false if conversion was not possible.
double cm;
val.TryConvert(LengthUnit.Centimeter, out cm);
```

Helper Methods to Construct Measurements
----------------------------------------
```C#
var f = Force.FromPressureByArea(Pressure p, Length2d area);
var f = Force.FromMassAcceleration(Mass mass, double metersPerSecondSquared);
```

Parse and Get Culture-Specific Abbreviations
-------------------------------------------------
```C#
  var us = new CultureInfo("en-US");
  var norwegian = new CultureInfo("nb-NO");
  
  Unit.Tablespoon == UnitSystem.Create(us).Parse("tbsp")
  Unit.Tablespoon == UnitSystem.Create(norwegian).Parse("ss")  

  "T" == UnitSystem.GetDefaultAbbreviation(Unit.Tablespoon, us)
  "ss" == UnitSystem.GetDefaultAbbreviation(Unit.Tablespoon, norwegian)
```

What It Is Not
==============

* It is not an equation solver. 
* It does not figure out the units after a calculation.

Work In Progress
================
This project is still early and many units and conversions are not yet covered. If you are missing something, please help by contributing.

* Add more units.
* Not all conversions are unit tested yet.
* Parsing and getting textual representations not complete.
* Document all the data structures, units and conversions.

Want To Contribute?
===================
Please read the wiki on [Adding a New Unit](https://github.com/InitialForce/UnitsNet/wiki/Adding-a-New-Unit).<br>
For other things to do, see Work In Progress.


[Contact me](https://github.com/anjdreas) if you have any questions.
