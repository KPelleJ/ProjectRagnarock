
namespace ProjectRagnarock.Models
{
    public class NationalMusesumRepository : IExpoRepository
    {
        private string _businessName;
        private string _logoImagePath;
        private string _businessDescription;
        private List<Expo> _expos;

        public NationalMusesumRepository()
        {
            _expos = new List<Expo>();
            _expos.Add(new Expo("Danmarkshistorien", "De første sikre beviser på bosættelse er fra omkring 10.000 år f.Kr., hvor de første beboere i Danmark levede af at jage, fiske og samle.[2] Ager- og husdyrbrug vandt indpas omkring 4000 år f.Kr., da landbruget kom til landet og det fik for alvor området til at udvikle sig, befolkningen voksede, og de første rigtige tegn på kultur og religionsdyrkelse begyndte at vise sig i form af stengrave og jættestuer.[3] Samtidig med indførelsen af bronze i Danmark omkring 2000 f.Kr. begyndte en overklasse at dominere samfundet. De meget store og rigt udsmykkede grave vidner om det. Bronze var et kostbart metal. Omkring 500 f. Kr.[4] blev samfundet ændret, da folk lærte at udvinde og anvende jern. Bønder kunne i mosen finde myremalm, der indeholdt jern, og selv frembringe gode, holdbare redskaber og våben. Jernalderen var præget af en markant befolkningstilvækst, da nye og bedre redskaber kunne opdyrke jorden bedre og bygge både. Handelen blomstrede, som fund af romerske smykker, mønter og våben vidner om.[5][6][7]\r\n\r\nGenetiske undersøgelser peger på flere migrationsbølger ind i det nuværende Danmark: I den mesolitiske periode blev der observeret en genetisk homogenitet blandt jæger-samlere, hovedsageligt af vesteuropæisk afstamning, i det nuværende Danmark over en periode på omkring 4.500 år.[8] Ved begyndelsen af den neolitiske periode omkring 5.900 f.Kr. førte ankomsten af bønder af anatolsk afstamning til en brat befolkningsændring, der næsten fuldstændigt erstattede disse jæger-samlere.[8] Omkring 1.000 år senere førte en anden stor migrationsbølge af mennesker af østeuropæisk steppeafstamning til en befolkning, der genetisk set var tættere på nutidens danskere, og til fremkomsten af enkeltgravskulturen.[8]", "danmark.mp4","Dannebrog.png"));
            _expos.Add(new Expo("Sverige er dum", "Sverige (svensk: Sverige), officielt Kongeriget Sverige (svensk: Konungariket Sverige), er et land i Nordeuropa. Det grænser op til Norge mod vest og Finland mod øst. Sverige er forbundet med Danmark via en bro- og tunnelforbindelse over Øresund i sydvest. Det er med sine 450.295 kvadratkilometer, heraf landareal 407.311 km², EU’s 3. største land. Med 10.555.448 indbyggere (1. november 2023) har Sverige dog en forholdsvis lav befolkningstæthed med 25,9 indbyggere pr. kvadratkilometer landareal (september 2022). Størstedelen af landets befolkning lever i den sydlige del af landet. Omkring 87 % af svenskerne lever i byområder på over 200 indbyggere. Efter OECDs definition bor 41% af indbyggerne i byområder på over 50.000 indbyggere.\r\n\r\nSiden forhistorisk tid har Sverige været befolket af de germanske folkeslag götere og sveere. Sydsverige er hovedsagelig landbrugsland, mens størstedelen af det nordlige Sverige er dækket af skov. Til trods for sin nordlige beliggenhed har Sverige et mildt klima. Det skyldes først og fremmest landets omfattende kystlinje. Sverige tilhører den geografiske region Skandinavien. Det konstitutionelle monarki Sverige er et parlamentarisk demokrati med en monark som statsoverhoved. Hovedstaden Stockholm er også landets største by. Den lovgivende magt udgøres af Riksdagen, der består af ét kammer med 349 medlemmer. Regeringen udgør med statsministeren i spidsen landets udøvende magt. Sverige er en enhedsstat bestående af 21 len og 290 kommuner.\r\n\r\nSverige opstod som en samlet nation i middelalderen. I det 17. århundrede nåede Sverige sin største udstrækning og blev en regulær stormagt. Landet bevarede sin stormagtsstatus indtil begyndelsen af det 18. århundrede. De svenske konger mistede gradvist deres territorier uden for Skandinavien i løbet af det 18. og 19. århundrede, og landets europæiske indflydelse nåede sin afslutning med Ruslands annektering af Finland i 1809. Sverige har ikke deltaget i krigshandlinger siden 1814, hvor Norge med militær magt blev tvunget ind i en personalunion under den svenske konge. Sverige forholdt sig sidenhen formelt set neutralt i udenrigspolitiske anliggender til ansøgningen om NATO-medlemskab i maj 2022. Personalunionen med Norge blev opløst i 1905 og de svenske grænser har ikke rykket sig siden da. Selvom Sverige formelt afholdt sig fra at vælge side under verdenskrigene, engagerede de svenske myndigheder sig i humanitære projekter. Svenskerne tog bl.a. imod flygtninge fra det tyskbesatte Europa under 2. verdenskrig.\r\n\r\nSverige blev optaget i EU den 1. januar 1995. Landet har dog afvist medlemskab af Eurozonen. Sverige er også medlem af FN, Nordisk Råd, Europarådet, WTO og OECD. Det svenske samfund baserer sig på den skandinaviske velfærdsmodel, der bl.a. yder offentlig sundhed og uddannelse til sine borgere. Landet er et af verdens rigeste lande og rangerer højt på mange internationale målinger over livskvalitet, sundhed, uddannelse, demokratiske rettigheder, økonomisk konkurrence, lighed, velstand og udvikling. Sverige har haft århundredelang tradition for neutralitet, men har i nyere tid blandt andet samarbejdet med NATO, og landet ansøgte i maj 2022 om optagelse i organisationen i lyset af Ruslands invasion af Ukraine, der var fundet sted nogle måneder forinden.", "Sverige.mp3", "SverigeFlag.jpg"));
            _expos.Add(new Expo("Norge", "Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge Norge ", "Norge.mp3", "NorgeFlag.jpg"));

            _businessName = "Nationalmuseet";
            _logoImagePath = "NationalMuseumLogo.jpg";
            _businessDescription = "Nationale ting til det nationale folk i nationen Danmark";

        }

        public string BusinessName
        { get { return _businessName; } }
        public string LogoImagePath
        {  get { return _logoImagePath; } }
        public string BusinessDescription
        { get { return _businessDescription; } }
        public List<Expo> Expos
        { get { return _expos; } }

        public void CreateExpo(string name, string description, string soundPath, string imagePath)
        {

        }

        public List<Expo> GetAll()
        {
            return _expos;
        }

        public void PlaySound()
        {
            throw new NotImplementedException();
        }

        public void PlaySound(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveExpo(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
