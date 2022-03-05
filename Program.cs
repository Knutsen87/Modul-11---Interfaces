using Modul_11___Interfaces;

Auto auto = new Auto();
auto.Hersteller = "Supercars";
auto.MaxGeschwindigkeit = 300;

E_Auto e_Auto = new E_Auto();
e_Auto.Hersteller = "Porsche";
e_Auto.MaxGeschwindigkeit = 320;

Motorrad motorrad = new Motorrad();
motorrad.Hersteller = "Ducati";
motorrad.MaxGeschwindigkeit = 300;

IKraftfahrzeug[] fahrzeuge = new IKraftfahrzeug[3];
fahrzeuge[0] = auto;
fahrzeuge[1] = e_Auto;
fahrzeuge[2] = motorrad;

foreach(IKraftfahrzeug fahrzeug in fahrzeuge)
{
    Console.WriteLine(fahrzeug.Hersteller);
    Console.WriteLine("Max Geschwindigkeit ist: "+ fahrzeug.MaxGeschwindigkeit + "km/h!");
    fahrzeug.Fahren();
    fahrzeug.Bremsen();
    Console.WriteLine();
}