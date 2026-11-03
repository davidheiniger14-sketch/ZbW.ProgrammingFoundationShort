namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"
    // TODO 3: LblNote.Text und LblBewertung.Text setzen

    if (int.TryParse(TxtPunkte.Text, out int punkte))
      if (punkte < 0 || punkte > 100)
      {
        MessageBox.Show("Bitte geben Sie eine Zahl zwischen 0 und 100 ein.", "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

    if(punkte >= 90)
    {
      LblNote.Text = "6";
      LblBewertung.Text = "Sehr gut";
    }
    else if (punkte >= 75)
    {
      LblNote.Text = "5";
      LblBewertung.Text = "Gut";
    }
    else if (punkte >= 60)
    {
      LblNote.Text = "4";
      LblBewertung.Text = "Genügend";
    }
    else
    {
      LblNote.Text = "3";
      LblBewertung.Text = "Ungenügend";
    }

    return;
  }
}
