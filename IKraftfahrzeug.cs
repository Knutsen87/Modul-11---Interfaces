interface IKraftfahrzeug
{
    string Hersteller { get; set; }
    int MaxGeschwindigkeit { get; set; }

    void Fahren();
    void Bremsen();
}