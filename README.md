# Operators Assignment

C# console application for Fariha's Operators Assignment.

`Employee` has `Id`, `FirstName`, and `LastName` properties. Its paired `==` and `!=` operators compare employee IDs and handle null references. `Equals` and `GetHashCode` follow the same equality rule. Comments explain each code block.

`Program.cs` creates two employees, assigns their properties, and displays both operator results for matching and different IDs.

## Run

With the .NET 8 SDK installed, run `dotnet run` in this folder.

## Expected output

```text
Same IDs:
firstEmployee == secondEmployee: True
firstEmployee != secondEmployee: False
Different IDs:
firstEmployee == secondEmployee: False
firstEmployee != secondEmployee: True
```
