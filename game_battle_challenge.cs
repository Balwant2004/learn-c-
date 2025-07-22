/*
Code challenge - write code to implement the game rules
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/
using System;
namespace GameBattleChallenge
{
   class Battle{
    static void Main(string []args){
        int Herohealth = 10;
        int Monsterhealth = 10;
        Random random = new Random();
        do{
            // hero attacks first
            int heroAttack = random.Next(1,11);
            Monsterhealth -= heroAttack;
            Console.WriteLine($"Hero attacks! Monster loses {heroAttack} health. Monster's remaining health: {Monsterhealth}");
            int MonsterAttack = random.Next(1,11);
            Herohealth -= MonsterAttack;
            Console.WriteLine($"Monster attacks! Hero loses {MonsterAttack} health. Hero's remaining health: {Herohealth}");
        }
        while(Herohealth > 0&& Monsterhealth >0);
        Console.WriteLine(Herohealth > Monsterhealth ? "Hero wins!" : "Monster wins!");

    }
   }

}