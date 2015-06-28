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
        public static string[] Tipos = new string[]
        {
            "Preparatória",
            "Ordinária",
            "Ordinária Deliberativa",
            "Ordinária Não Deliberativa",
            "Extraordinária",
            "Solene"
        };
                
        //Retorna uma string contendo a definição do enumerado
        public static string TextFor(TiposDeSessao tipo)
        {
            return Tipos[Convert.ToInt32(tipo)];
        }   
               
        public static TiposDeSessao EnumFor(string tipoText)
        {
            return (TiposDeSessao)Array.FindIndex<string>(Tipos, tipo => tipo == tipoText);
        }
    }
}
