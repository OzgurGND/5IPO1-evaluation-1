﻿using System.Transactions;

Console.WriteLine("Bonhomme pendu");

string mot1 = "maison";
string mot2 = "camion";
string mot3 = "pomme";
string mot4 = "papier";
string mot5 = "carton";
string mot6 = "bouteille";

List<string> listMots = new List<string>() { "maison", "camion", "pomme", "papier", "carton", "bouteille"};

Random aleatoire = new Random();
int numero;
for(int i = 0; i<10; i++)
{
    numero = aleatoire.Next(1, 7); //numero allant de 1 -> 6
    Console.WriteLine(numero);
}

foreach(string mot in listMots)
{
    Console.WriteLine(mot);
}
