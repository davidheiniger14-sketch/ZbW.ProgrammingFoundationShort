namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  //   Startet den Taschenrechner auf der Konsole.
  // <summary>

  // </summary>
  public static void Start()
  {
    Console.Write("Erste Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Zweite Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl2))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Operation (+, -, *, /): ");
    string operation = (Console.ReadLine() ?? "").Trim();

    double result;

    if (operation == "+")
    {
      result = zahl1 + zahl2;
    }
    else if (operation == "-")
    {
      result = zahl1 - zahl2;
    }
    else if (operation == "*")
    {
      result = zahl1 * zahl2;
    }
    else if (operation == "/")
    {
      if (zahl2 == 0)
      {
        Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
        return;
      }

      result = zahl1 / zahl2;
    }
    else
    {
      Console.WriteLine($"Unbekannte Operation: '{operation}'");
      return;
    }

    Console.WriteLine($"Ergebnis: {result:F2}");
  }
}

