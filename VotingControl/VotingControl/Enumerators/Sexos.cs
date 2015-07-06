using System;

namespace VotingControl
{
    /// <summary>
    /// Enumerador com os tipos de sexo de uma pessoa
    /// </summary>
    public enum Sexos
    {
        Masculino,
        Feminino,
        Indefinido
    }

    public struct SexosHuman
    {
        public static string[] Types = new string[]
        {
            "Masculino",
            "Feminino",
            "Indefinido"
        };

        //Retorna uma string contendo a definição do enumerado
        public static string TextFor(Sexos sexo)
        {
            return Types[Convert.ToInt32(sexo)];
        }

        public static Sexos EnumFor(string genderText)
        {
            return (Sexos)Array.FindIndex<string>(Types, tipo => tipo == genderText);
        }
    }
}
