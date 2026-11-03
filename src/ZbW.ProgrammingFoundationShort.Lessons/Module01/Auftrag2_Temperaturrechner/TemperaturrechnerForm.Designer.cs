namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

partial class TemperaturrechnerForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblCelsius = new Label();
    TxtCelsius = new TextBox();
    CmdCelsiusToFahrenheit = new Button();
    LblFahrenheit = new Label();
    TxtFahrenheit = new TextBox();
    CmdFahrenheitToCelsius = new Button();
    SuspendLayout();
    // 
    // LblCelsius
    // 
    LblCelsius.AutoSize = true;
    LblCelsius.Location = new Point(22, 43);
    LblCelsius.Margin = new Padding(6, 0, 6, 0);
    LblCelsius.Name = "LblCelsius";
    LblCelsius.Size = new Size(93, 32);
    LblCelsius.TabIndex = 0;
    LblCelsius.Text = "Celsius:";
    // 
    // TxtCelsius
    // 
    TxtCelsius.Location = new Point(223, 36);
    TxtCelsius.Margin = new Padding(6);
    TxtCelsius.Name = "TxtCelsius";
    TxtCelsius.Size = new Size(219, 39);
    TxtCelsius.TabIndex = 1;
    TxtCelsius.Click += ClickTxtbCelsius;
    // 
    // CmdCelsiusToFahrenheit
    // 
    CmdCelsiusToFahrenheit.Location = new Point(483, 34);
    CmdCelsiusToFahrenheit.Margin = new Padding(6);
    CmdCelsiusToFahrenheit.Name = "CmdCelsiusToFahrenheit";
    CmdCelsiusToFahrenheit.Size = new Size(260, 53);
    CmdCelsiusToFahrenheit.TabIndex = 2;
    CmdCelsiusToFahrenheit.Text = "→ Fahrenheit";
    CmdCelsiusToFahrenheit.Click += CmdCelsiusToFahrenheit_Click;
    // 
    // LblFahrenheit
    // 
    LblFahrenheit.AutoSize = true;
    LblFahrenheit.Location = new Point(22, 128);
    LblFahrenheit.Margin = new Padding(6, 0, 6, 0);
    LblFahrenheit.Name = "LblFahrenheit";
    LblFahrenheit.Size = new Size(132, 32);
    LblFahrenheit.TabIndex = 3;
    LblFahrenheit.Text = "Fahrenheit:";
    // 
    // TxtFahrenheit
    // 
    TxtFahrenheit.Location = new Point(223, 122);
    TxtFahrenheit.Margin = new Padding(6);
    TxtFahrenheit.Name = "TxtFahrenheit";
    TxtFahrenheit.Size = new Size(219, 39);
    TxtFahrenheit.TabIndex = 4;
    TxtFahrenheit.Click += ClickTxtbFahrenheit;
    // 
    // CmdFahrenheitToCelsius
    // 
    CmdFahrenheitToCelsius.Location = new Point(483, 119);
    CmdFahrenheitToCelsius.Margin = new Padding(6);
    CmdFahrenheitToCelsius.Name = "CmdFahrenheitToCelsius";
    CmdFahrenheitToCelsius.Size = new Size(260, 53);
    CmdFahrenheitToCelsius.TabIndex = 5;
    CmdFahrenheitToCelsius.Text = "→ Celsius";
    CmdFahrenheitToCelsius.Click += CmdFahrenheitToCelsius_Click;
    // 
    // TemperaturrechnerForm
    // 
    AutoScaleDimensions = new SizeF(13F, 32F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(799, 213);
    Controls.Add(LblCelsius);
    Controls.Add(TxtCelsius);
    Controls.Add(CmdCelsiusToFahrenheit);
    Controls.Add(LblFahrenheit);
    Controls.Add(TxtFahrenheit);
    Controls.Add(CmdFahrenheitToCelsius);
    Margin = new Padding(6);
    Name = "TemperaturrechnerForm";
    Text = "Temperaturrechner – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblCelsius;
  private TextBox TxtCelsius;
  private Button CmdCelsiusToFahrenheit;
  private Label LblFahrenheit;
  private TextBox TxtFahrenheit;
  private Button CmdFahrenheitToCelsius;
}
