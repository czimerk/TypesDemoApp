
using TypeDemoApp.Types;
using TypesDemoApp.Types;

int MeaningOfLife;
bool IsOnline = false;
MeaningOfLife = 0;
IsOnline = true;


WitcherCharacter c0;
//unassigned variable! Az alábbi sor Fordítási hiba
//SceneRegister.PrintCharacter(c0);

var sr = new SceneRegister();
//NullReferenceException, ha a SceneRegister-osztályban
//nem adjuk meg az = new List<Scene>()-t. mert Scenes,
//mint referencia típus default értéke null!
sr.Scenes.Add(new Scene());

WitcherCharacter ciri = new WitcherCharacter("Cirilla Fiona Elen Riannon");
//var - implicit típus, az értékadás jobb oldalából a fordító kitalálja a típust
var ciri2 = new WitcherCharacter("Cirilla Fiona Elen Riannon");
var ciri1UjRef = ciri;
bool ref1Eq = ReferenceEquals(ciri, ciri2); //false
bool ref2Eq = ReferenceEquals(ciri, ciri1UjRef); //true


Console.WriteLine("Referencia egyezőség? ciri, ciri2:" + ref1Eq);
Console.WriteLine("Referencia egyezőség? ciri1UjRef, ciri:" + ReferenceEquals(ciri1UjRef, ciri));

//Referencia típusokra, az Equals metódust is lehet használni ami az object-en van
//Alap esetben ugyanaz mint a ReferenceEquals, ha nincs felülírva (virtual az object-ben)
Console.WriteLine("Equals ciri, ciri2: " + ciri.Equals(ciri2));
Console.WriteLine("Equals ciri, ciri1UjRef: " + ciri.Equals(ciri1UjRef));

WitcherCharacterPosition geralt = new WitcherCharacterPosition(1, 0, 0);
WitcherCharacterPosition geralt2 = new WitcherCharacterPosition(1, 0, 0);

//Console.WriteLine("Referencia egyezőség? Értelmetlen (Boxing miatt ld később mindig false):" + ReferenceEquals(geralt, geralt2));
Console.WriteLine("Equals geralt, geralt2: " + geralt.Equals(geralt2));

//memory snapshot
var comp = new SuperComputer();
//memory snapshot 2

//placeholder, hogy breakpoin-ot lehessen tenni. Bekér egy karaktert.
Console.ReadKey();
