﻿Random coin = new Random();
int side = coin.Next(0, 2);
Console.WriteLine((side == 0) ? "heads" : "tails");