namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    string passwort = "";
    bool gueltig = false;

    do
    {
      Console.WriteLine("Bitte geben Sie ein Passwort ein (mindestens 8 Zeichen und mindestens eine Ziffer):");
      passwort = LeseMaskiertesPasswort();
      bool hatZiffer = false;
      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }
      gueltig = passwort.Length >= 8 && hatZiffer;
      if (!gueltig)
      {
        if (passwort.Length < 8)
        {
          Console.WriteLine("Fehler: Das Passwort muss mindestens 8 Zeichen lang sein.");
        }
        if (!hatZiffer)
        {
          Console.WriteLine("Fehler: Das Passwort muss mindestens eine Ziffer enthalten.");
        }
      }
    } while (!gueltig);
    Console.WriteLine("Passwort ist gültig!");
  }

  private static string LeseMaskiertesPasswort()
  {
    string passwort = "";
    ConsoleKeyInfo taste;

    do
    {
      taste = Console.ReadKey(intercept: true);

      // Backspace behandeln: letztes Zeichen entfernen und Sternchen löschen
      if (taste.Key == ConsoleKey.Backspace && passwort.Length > 0)
      {
        passwort = passwort.Substring(0, passwort.Length - 1);
        Console.Write("\b \b"); // Cursor zurück, Leerzeichen schreiben, Cursor wieder zurück
      }
      // Normale Zeichen hinzufügen (außer Enter und Backspace)
      else if (!char.IsControl(taste.KeyChar))
      {
        passwort += taste.KeyChar;
        Console.Write("*");
      }

    } while (taste.Key != ConsoleKey.Enter);

    Console.WriteLine(); // Nach Enter eine neue Zeile beginnen
    return passwort;
  }
}

    // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")

    // TODO 3: bool hatZiffer = false;
    //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

    // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
