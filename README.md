Således kommer jeg frem til dette resultat

Jeg opretter et nyt projekt som ASP.NET Core Web Application med template Web Application (Model-View-Controller).

Under Views/Home sletter jeg About.cshtml, Contact.cshtml og Privacy.cshtml
Under Views/Shared sletter jeg _CookieConsentPartial.cshtml og _ValidationScriptsPartial.cshtml
I _Layout.cshtml fjerner jeg referencer til _CookieConsentPartial.

Under Models opretter jeg en bønne ved navn Vurdering.cs med de nødvendige indtastningsfelter.

I HomeController vælger jeg Index metoden og tilføjer et MVC View ved navn Vurdering og med template Create til Model class Vurdering. Som layout vælger jeg Views/Shared/_Layout.cshtml.
Jeg sletter metoderne About, Contact og Privacy.

Jeg tømmer Index.cshtml for indhold og kopierer indholdet fra Vurdering.cshtml ind i Index.cshtml sammen med lidt ledetekst.
Denne tekst bliver lagt ind i bunden af Index.cshtml som dukumentation.
Herefter har jeg en kørende applikation som tillader indtastning af navn, produkt og karakter.

Der er ingen validering og ingen persistering, for det kan jeg ikke finde ud af endnu.
