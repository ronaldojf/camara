using System;

namespace VotingControl
{
    public enum TiposDeSessao 
    {
        Preparatoria, 
        Ordinaria,
        OrdinariaDeliberativa, 
        OrdinariaNaoDeliberativa, 
        Extraordinaria,
        Solene 
    }
    
    public struct TiposDeSessaoHuman
    {
        public static string[] Types = new string[]
        {
            "Preparatória",
            "Ordinária",
            "Ordinária Deliberativa",
            "Ordinária Não Deliberativa",
            "Extraordinária",
            "Solene"
        };
                
        //Retorna uma string contendo a definição do enumerado
        public static string TextFor(TiposDeSessao type)
        {
            return Types[Convert.ToInt32(type)];
        }   
               
        public static TiposDeSessao EnumFor(string typeText)
        {
            return (TiposDeSessao)Array.FindIndex<string>(Types, tipo => tipo == typeText);
        }
    }
}
