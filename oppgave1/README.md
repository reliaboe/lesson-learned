# C# .NET - Grunnleggende programmering

## Mål
Bli kjent med dotnet CLI, prosjekt-oppsett, filer, filtyper

## Utforsk hvilke CLI kommandoer som finnes
```
// List alle tilgjengelige kommandoer
dotnet -h

// List alle tilgjengelige kommandoer for dotnet new
dotnet new -h

// List alle tilgjengelige templater du har for dotnet new
dotnet new list
```

## Opprett et nytt prosjekt ved hjelp av dotnet CLI
Naviger til mappen **oppgave1**

```
dotnet new console --framework net9.0 --use-program-main --name Demo

```

## Bygg og utforsk filer og mappestruktur

Naviger til mappen Demo

1. **Utforsk mappestruktur før bygging**
2. **Bygg kode for debug**

```
dotnet build -c Debug
```
3. **Utforsk mappestruktur etter bygging (debug)**

```
dotnet build -c Release
```
4. **Utforsk mappestruktur etter bygging (produksjon)**

```
dotnet clean -c Debug
dotnet clean -c Release
dotnet publish -c Release
```
5. **Utforsk mappestruktur etter publish produksjon**
6. **Slett mappene bin og obj og kjør build kommando på nytt**

```
dotnet run -c Debug
```

7. **Endre kode i Program.cs og gjør et nytt bygg**
```
namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var a = Console.ReadLine();
    }
}
```

8. **Naviger til kopilert kode og kjør filen Demo.exe**
9. **Utforsk prosjektfilen (åpne i notepad etc.) og se på hva som ligger i den**

Vi brukte --use-program-main som parameter på dotnet new... Dette for å vise hva som er oppstartsmetode. Nyere versjoner av .NET gjør dette implisitt. Slett hele demo-applikasjonen, og opprett prosjektet på nytt uten parameter --use-program-main.

9. **Åpne Program.cs og se hvordan denne ser ut uten parameter**
