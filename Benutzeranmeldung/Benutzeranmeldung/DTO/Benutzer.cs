using System;

namespace Benutzeranmeldung.DTO
{
    public class Benutzer
    {
        string   Id;
        string   Email;
        string   Nickname;
        DateTime Registrierungsdatum;
        DateTime LetzteAnmeldung;
        DateTime LetzteAktualisierung;
    }
}