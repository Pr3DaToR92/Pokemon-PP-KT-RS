/*
 * 
 * Appen du skal lage må ha en pokemontrener. Brukeren skal få velge navn og startpokemon. Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp.
 * Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av).
 * Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat. Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.
 * 
 * 
 * 
 * 1. Opprette klassene - pokemon, pokemontrener, pokeshop og terreng.
 * 2. lage en meny hvor 1 = Lage ny pokemon trener - 2 Velge terreng - 3 pokeshop - 4 se hvilke pokemon man har - 5 se inventory som baller potions osv.
 * 3. Lage pokemontrener metodene - CreateNewTrainer
 * 4.
 * 
 * 
 */
using Pokemon_PP_KT_RS;
Pokemon starter1 = new Pokemon("Bulbasaur", 100, 5, "Grass", 1);
Pokemontrener trainer = null;
Terreng terreng1 = new Terreng("grass");
Terreng terreng2 = new Terreng("water");

Pokemon starter2 = new Pokemon("Pikachu", 100, 5, "Lightning", 2);
Pokemon starter3 = new Pokemon("Charmander", 100, 5, "Fire", 3);
Pokeshop shop = new Pokeshop(10, 10);


void Meny()
{
while (true)
{
    Console.Clear();
    if (trainer == null)
        Console.WriteLine("Hei og velkommen til pokemon appen, trykk 1 for å lage din trainer profil!");
    else
    {
        Console.WriteLine("Tast 2 for velge et terreng du vil gå i!");
        Console.WriteLine("Tast 3 for pokeshop");
    }

    var input = Console.ReadKey();
    switch (input.KeyChar)
    {
        case '1':
            MakeANewTrainer();
            break;
        case '2':
            ChooseTerrain();
            break;
        case '3':
            ChoosePokeShop();
            break;
        case '4':
            break;
        case '5':
            break;


    }
}
}



void MakeANewTrainer()
{

    string input;
    string name;
    

    Console.Clear();
    Console.WriteLine("Skriv inn ditt navn!");
    name = Console.ReadLine();
    Console.WriteLine("Velg en pokemon!");
    starter1.WriteInfo();
    starter2.WriteInfo();
    starter3.WriteInfo();
    Console.WriteLine("Velg en ID");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            trainer = new Pokemontrener(name, starter1, 1000);
            break;
        case "2":
            trainer = new Pokemontrener(name, starter2, 1000);
            break;
        case "3":
            trainer = new Pokemontrener(name, starter3, 1000);
            break;
        default:
            Meny();
            break;
    }
}



void ChooseTerrain()
{
    string input;

    Console.Clear();
    Console.WriteLine("Velg ett terreng du vil fange Pokemon i");
    Console.WriteLine("Tast 1 for gress, og 2 for vann");
    input = Console.ReadLine();
    if (input == "1")
    {
        terreng1.ShowPokemon("grass");
    }
    else
    {
        terreng1.ShowPokemon("water");
    }

    while (true)
    {
        
        Console.WriteLine("Tast 1 for å kjempe, 2 for å løpe, 3 for potion");
        input = Console.ReadLine();
        if(input == "1") 
        {
            terreng1.PokemonFight(trainer);
        }
    }
  
}

void ChoosePokeShop()
{
    string input;

    Console.Clear();
    Console.WriteLine("Trykk 1 for å kjøpe Pokeballs antall igjen" + shop._pokeballs);
    Console.WriteLine("Trykk 2 for å kjøpe Potions antall igjen" + shop._potion);
    Console.WriteLine("Trykk 3 for å ikke handle");
    input = Console.ReadLine();
    if (input == "1")
    {
        trainer.BuyPokeball();
        Meny();
    }

    if (input == "2")
    {
        trainer.BuyPotion();
        Meny();
    }
    if (input == "3")

    {
        Meny();
    }
}

Meny();