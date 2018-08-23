namespace Benutzeranmeldung.Interface
{
    public interface IAnmeldung
    {
        string Anmelden(string                             anmeldename, string passwort);
        bool   Ist_Anmeldung_gültig(string                 token);
        void   Rücksetzung_des_Passworts_beantragen(string email);
        void   Passwort_zurücksetzen(string                email);
    }
}