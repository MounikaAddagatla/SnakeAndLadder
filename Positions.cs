﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Positions
    {
        const int No_PLAY = 1, LADDER = 2, SNAKE = 3, MAX_PLAYER_POSITION = 100;
        int playerPosition = 0;
        public void Play()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            int options = random.Next(1, 4);
            while (playerPosition < MAX_PLAYER_POSITION)
            {
                switch (options)
                {

                    case LADDER:
                        Console.WriteLine("Ladder");
                        playerPosition += rollDie;
                        break;
                    case SNAKE:
                        Console.WriteLine("Snake");
                        playerPosition -= rollDie;
                        break;
                    case No_PLAY:
                        Console.WriteLine("No PLAY");
                        playerPosition = 0;
                        break;
                    default:
                        break;
                }
                //due to player position 0 or less than zero, the loop runs infine times
                if (playerPosition <= 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("Player position starts from zero");
                    break;
                }
                else
                {
                    Console.WriteLine("Player postion stays in same position");
                }
                Console.WriteLine("Afer rolls a die , the number get :" + rollDie);
            }
        }
    }
}
