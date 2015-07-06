using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingControl
{
    /// <summary>
    /// Ações executadas no banco, para definir qual será o atributo de mensagem de erro padrão
    /// </summary>
    public struct Verbs
    {
        public static string Create = "criar";
        public static string Update = "atualizar";
        public static string Delete = "excluir";
    }
}
