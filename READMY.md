# MathLibrary – Dokumentacja techniczna

## Cel projektu

MathLibrary to biblioteka C# zaprojektowana z myślą o łatwej integracji z innymi projektami. Łączy podstawowe i bardziej zaawansowane klasy oraz metody matematyczne, oferując gotowe narzędzia do obliczeń numerycznych i analizy danych.

## Struktura projektu

Projekt składa się z trzech głównych komponentów:

MathLibrary – właściwa biblioteka z klasami i metodami matematycznymi

MathLibrary.Tests – zestaw testów jednostkowych

MathLibrary.Demo.Console – aplikacja konsolowa demonstrująca użycie biblioteki

## Instalacja i użycie

Import biblioteki:

Dodaj projekt MathLibrary do swojego rozwiązania lub skompiluj jako DLL i załącz do projektu.

Przykład użycia:

using MathLibrary;

var wynik = Algebra.Add(5, 3);
Console.WriteLine($"Wynik dodawania: {wynik}");

## Dostępne moduły

Algebra

Add(a, b) – dodawanie

Subtract(a, b) – odejmowanie

Multiply(a, b) – mnożenie

Divide(a, b) – dzielenie z obsługą wyjątków

Geometry (planowane)

Obliczenia pól, obwodów, objętości

Statistics (planowane)

Średnia, mediana, odchylenie standardowe

## Testowanie

Projekt zawiera testy jednostkowe w folderze MathLibrary.Tests, które można uruchomić za pomocą dotnet test.

### Przykład testu

[TestMethod]
public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
{
    var result = Algebra.Add(2, 3);
    Assert.AreEqual(5, result);
}

## Plany rozwoju

Rozszerzenie o moduły geometryczne i statystyczne

Obsługa liczb zespolonych

Dokumentacja XML do automatycznego generowania pomocy

👤 Autor

Projekt stworzony przez Karol8284. Repozytorium: GitHub – Karol8284/MathLibrary

Biblioteka jest rozwijana hobbystycznie, ale z dbałością o jakość kodu i możliwość praktycznego zastosowania w projektach edukacyjnych i półprofesjonalnych.
