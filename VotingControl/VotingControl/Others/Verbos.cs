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
    public struct Verbos
    {
        public static string Criar = "criar";
        public static string Atualizar = "atualizar";
        public static string Excluir = "excluir";
    }
}
