namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    // TODO 2: Wert aus TxtCelsius lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    // TODO 3: Prüfen ob Wert < AbsoluteZero
    //         → MessageBox mit Warnung, aber weiter rechnen
    // TODO 4: Formel anwenden: fahrenheit = celsius * 9.0 / 5.0 + 32
    // TODO 5: Ergebnis in TxtFahrenheit anzeigen ($"{fahrenheit:F2}")
    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0
    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung
    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")

    if (!double.TryParse(TxtCelsius.Text, out double celsius))
    {
      MessageBox.Show("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Warnung: Der eingegebene Wert liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    double fahrenheit = celsius * 9.0 / 5.0 + 32;

    TxtFahrenheit.Text = $"{fahrenheit:F2}";
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtFahrenheit.Text, out double fahrenheit))
    {
      MessageBox.Show("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    if (fahrenheit < AbsoluteZero * 9.0 / 5.0 + 32) // Check if fahrenheit is below absolute zero in Fahrenheit
    {
      MessageBox.Show($"Warnung: Der eingegebene Wert liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    if (fahrenheit < AbsoluteZero * 9.0 / 5.0 + 32)
    {
      MessageBox.Show($"Warnung: Der berechnete Wert liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
    TxtCelsius.Text = $"{celsius:F2}";
  }

  private void ClickTxtbCelsius(object sender, EventArgs e)
  {

  }

  private void ClickTxtbFahrenheit(object sender, EventArgs e)
  {

  }
}
