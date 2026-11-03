namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    //         var random = new Random();
    //         int geheimzahl = random.Next(1, 101);

    Random random = new Random();
    int geheimzahl = random.Next(1, 101);

    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int versuche = 0;
    bool geraten = false;

    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen

    while (!geraten)
    {
      Console.Write("Bitte eine Zahl zwischen 1 und 100 eingeben: ");
      string eingabe = Console.ReadLine();
      int benutzerZahl;
      if (int.TryParse(eingabe, out benutzerZahl))
      {
        versuche++;
        if (benutzerZahl < geheimzahl)
        {
          Console.WriteLine("Zu klein!");
        }
        else if (benutzerZahl > geheimzahl)
        {
          Console.WriteLine("Zu gross!");
        }
        else
        {
          geraten = true;
          Console.WriteLine($"Glückwunsch! Du hast die Zahl {geheimzahl} in {versuche} Versuchen erraten.");
        }
      }
      else
      {
        Console.WriteLine("Ungültige Eingabe. Bitte eine ganze Zahl eingeben.");
      }
    }

    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
  }
}
