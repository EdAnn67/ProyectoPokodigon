using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokodigon
{
    class Program
    {
        private static List<Pokemon> Pokemons = new List<Pokemon>();
        private static List<Pokemon> CaptPokes = new List<Pokemon>();
        static int Option, j = 6, Selection = 0, x = 0;
        static void Main(string[] args)
        {
            do
            {
                if(CaptPokes.Count == 0)
                {
                    
                    Pokemons.Clear();
                    SetPokemon();
                    int InitialPokemon;
                    Random Ran = new Random();
                    InitialPokemon = Ran.Next(6);
                    CaptPokes.Add(Pokemons[InitialPokemon]);
                    Pokemons.RemoveAt(InitialPokemon);
                }
                Menu();
            } while (Option != 3);

            Console.ReadKey();
        }
        static int SetAttack()
        {
            //Generamos la variable que genere un daño para el ataque de forma aleatoria
            System.Threading.Thread.Sleep(20);
            int Attack;
            Random Rand = new Random();
            Attack = 15 + Rand.Next(51);
            return Attack;
        }
        static void SetPokemon()
        {
            Pokemon Poke1 = new Pokemon();
            Poke1.Name = "Zapdos";
            Poke1.Type = "Eléctrico";
            Poke1.Attack1N = "ElectroCañon";
            Poke1.Attack1 = SetAttack();
            Poke1.Attack2N = "Trueno";
            Poke1.Attack2 = SetAttack();
            Poke1.HP = 150;
            Pokemons.Add(Poke1);

            Pokemon Poke2 = new Pokemon();
            Poke2.Name = "Raichu";
            Poke2.Type = "Eléctrico";
            Poke2.Attack1N = "Impactrueno";
            Poke2.Attack1 = SetAttack();
            Poke2.Attack2N = "Rayo";
            Poke2.Attack2 = SetAttack();
            Poke2.HP = 150;
            Pokemons.Add(Poke2);

            Pokemon Poke3 = new Pokemon();
            Poke3.Name = "Rayquaza";
            Poke3.Type = "Dragón";
            Poke3.Attack1N = "Cola Dragón";
            Poke3.Attack1 = SetAttack();
            Poke3.Attack2N = "Enfado";
            Poke3.Attack2 = SetAttack();
            Poke3.HP = 150;
            Pokemons.Add(Poke3);

            Pokemon Poke4 = new Pokemon();
            Poke4.Name = "Latias";
            Poke4.Type = "Dragón";
            Poke4.Attack1N = "DragoAliento";
            Poke4.Attack1 = SetAttack();
            Poke4.Attack2N = "Pulso Dragón";
            Poke4.Attack2 = SetAttack();
            Poke4.HP = 150;
            Pokemons.Add(Poke4);

            Pokemon Poke5 = new Pokemon();
            Poke5.Name = "Golem";
            Poke5.Type = "Roca";
            Poke5.Attack1N = "Pedrada";
            Poke5.Attack1 = SetAttack();
            Poke5.Attack2N = "Terremoto";
            Poke5.Attack2 = SetAttack();
            Poke5.HP = 150;
            Pokemons.Add(Poke5);

            Pokemon Poke6 = new Pokemon();
            Poke6.Name = "Onix";
            Poke6.Type = "Roca";
            Poke6.Attack1N = "Roca Afilada";
            Poke6.Attack1 = SetAttack();
            Poke6.Attack2N = "Tormenta de Arena";
            Poke6.Attack2 = SetAttack();
            Poke6.HP = 150;
            Pokemons.Add(Poke6);
        }
        static void Menu()
        {
            j = Pokemons.Count;
            Console.Clear();
            Console.WriteLine("---------- Menú ----------");
            Console.WriteLine("1 - Batalla Pokemon");
            Console.WriteLine("2 - Pokemones Capturados ");
            Console.WriteLine("3 - Salir");
            
            do
            {
                Console.Write("Ingrese La opcion a ejecutar: ");
                Option = int.Parse(Console.ReadLine());
            } while (Option < 1 || Option > 3);

            if(Option == 1)
            {
                PokBattle();
            }
            if(Option == 2)
            {
                Pokes();
            }
        }
        static void PokBattle()
        {
            j = Pokemons.Count;
            Random Ran = new Random();
            int Pok = Ran.Next(j);
            System.Threading.Thread.Sleep(20);
            int Attacker = Ran.Next(2);
            System.Threading.Thread.Sleep(20);
            int y = 0;
            do
            {
                if (Attacker % 2 == 0)
                {
                    Console.WriteLine("Es el turno del jugador: ");
                    Console.WriteLine("Datos del pokemon:");
                    Console.WriteLine("Nombre = {0}     HP = {1}", CaptPokes[x].Name, CaptPokes[x].HP);
                    Console.WriteLine("Ataque 1:{0}     Daño: {1}", CaptPokes[x].Attack1N, CaptPokes[x].Attack1);
                    Console.WriteLine("Ataque 2:{0}     Daño: {1}", CaptPokes[x].Attack2N, CaptPokes[x].Attack2);

                    Console.WriteLine("1 - Ataque 1");
                    Console.WriteLine("2 - Ataque 2");
                    Console.WriteLine("3 - Cambiar Pokemon");
                    Console.WriteLine("4 - Huida");

                    do
                    {
                        Console.Write("Ingrese la opcion a realizar: ");
                        Selection = int.Parse(Console.ReadLine());
                    } while (Selection < 1 || Selection > 4);
                    if(Selection == 1)
                    {
                        Console.WriteLine("{0} ha utilizado {1} con un daño de {2}", CaptPokes[x].Name, CaptPokes[x].Attack1N, CaptPokes[x].Attack1);
                        Pokemons[Pok].HP -= CaptPokes[x].Attack1;
                    }
                    if (Selection == 2)
                    {
                        Console.WriteLine("{0} ha utilizado {1} con un daño de {2}", CaptPokes[x].Name, CaptPokes[x].Attack2N, CaptPokes[x].Attack2);
                        Pokemons[Pok].HP -= CaptPokes[x].Attack2;
                    }
                    if (Selection == 3)
                    {
                        Pokes();
                        int z = 0;
                        do
                        {
                            Console.Write("Ingrese el id del pokemon que desea utilizar: ");
                            z = int.Parse(Console.ReadLine());
                        } while (z < 1 || z > CaptPokes.Count);
                        x = z;
                    }
                }
                else
                {
                    Console.Clear();
                    int Attack = Ran.Next(2);
                    Console.WriteLine("Es el turno del computador: ");
                    Console.WriteLine("Datos del pokemon:");
                    Console.WriteLine("Nombre = {0}     HP = {1}", Pokemons[Pok].Name, Pokemons[Pok].HP);
                    if (Attack == 0)
                    {
                        Console.WriteLine("{0} ha utilizado {1} con un daño de {2}", Pokemons[Pok].Name, Pokemons[Pok].Attack1N, Pokemons[Pok].Attack1);
                        CaptPokes[x].HP -= Pokemons[Pok].Attack1;
                    }
                    else
                    {
                        Console.WriteLine("{0} ha utilizado {1} con un daño de {2}", Pokemons[Pok].Name, Pokemons[Pok].Attack2N, Pokemons[Pok].Attack2);
                        CaptPokes[x].HP -= Pokemons[Pok].Attack2;
                    }
                    Console.ReadKey();
                }
                Attacker++;
                Console.Clear();
                if(CaptPokes[x].HP < 1)
                {
                    CaptPokes.RemoveAt(x);
                }
                
            } while (CaptPokes.Count != 0 && Pokemons[Pok].HP > 0 && Selection != 4);

            if(CaptPokes.Count == 0)
            {
                Console.WriteLine("Ha perdido todos sus pokemones. Iniciando una nueva partida.");
            }
            if(Selection == 4)
            {
                Console.WriteLine("El jugador ha huido. Escape exitoso.");
            }
            if (Pokemons[Pok].HP < 1)
                {
                    Capture(Pok);
                }

            j = Pokemons.Count; 
            Console.ReadKey();
            Console.Clear();
        }

        static void Pokes()
        {
            int i = 0;
            Console.WriteLine("    Pokemon    Tipo       Vida       Estado");
            foreach(var Poke in CaptPokes)
            {
                Console.WriteLine("{0} - {1}      {2}         {3}       Capturado", i + 1, Poke.Name, Poke.Type, Poke.HP);
                i++;
            }
            Console.WriteLine("\n\n");
            foreach (var Poke in Pokemons)
            {
                Console.WriteLine("{0} - {1}      {2}         {3}       No Capturado", i + 1, Poke.Name, Poke.Type, Poke.HP);
                i++;
            }
            Console.WriteLine("Pesione una tecla para volver al menu");
            Console.ReadKey();
        }

        
        static void Capture(int a)
        {
            Pokemons[a].HP = 150;
            Random x = new Random();
            int R = x.Next(2);
            if(R == 0)
            {
                Console.WriteLine("Has capturado a {0}", Pokemons[a].Name);
                CaptPokes.Add(Pokemons[a]);
                Pokemons.RemoveAt(a);
            }
            else
            {
                Console.WriteLine("No pudiste atrapar el pokemon");
            }
        }
    }
}
