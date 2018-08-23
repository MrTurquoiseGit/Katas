namespace Benutzeranmeldung.Interface
{
    public interface IRegistrierung
    {
        void Registrieren(string email, string passwort, string nickname);
        void Bestätigen(string   registrierungsnummer);
    }
}