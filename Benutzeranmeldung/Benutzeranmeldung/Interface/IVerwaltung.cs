using Benutzeranmeldung.DTO;

namespace Benutzeranmeldung.Interface
{
    public interface IVerwaltung
    {
        Benutzer Aktueller_Benutzer(string token);
        void     Umbenennen(string         benutzerId, string email, string nickname);
        void     Passwort_ändern(string    benutzerId, string passwort);
        void     Löschen(string            benutzerId, string passwort);
    }
}