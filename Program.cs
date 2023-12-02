﻿const string FraseParaSair = "tchau";
Console.WriteLine("---- Groot chat -----\n");
string pergunta;
do {
    Console.WriteLine("pergunta: ");
    pergunta = Console.ReadLine()!;
    string resposta = obtemrespostagroot(pergunta);
    exiberesposta(obtemrespostagroot(pergunta));
} 
while (pergunta.Trim().ToLower() != FraseParaSair);
void exiberesposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" Resposta: {resposta}");
    Console.ResetColor();
}
string obtemrespostagroot(string pergunta)
{
    return pergunta.Trim().ToLower()== FraseParaSair ?
    "Eu sou Groot!" :
    "Eu sou Groot.";
}
