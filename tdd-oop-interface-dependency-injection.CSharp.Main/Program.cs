﻿// See https://aka.ms/new-console-template for more information
using tdd_oop_interface_dependency_injection.CSharp.Main;

Console.WriteLine("Hello, World!");


Alphabet alphabet = new Alphabet();
Scrabble scrabble = new Scrabble(alphabet);
