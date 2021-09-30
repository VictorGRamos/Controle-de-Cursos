using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Turmas
    {
        //propriedades
        public int codigoTurma;
        public string horaInicio, horaTermino, professorID, cursoID;
        public DateTime dataInicio, dataTermino;


        //variavel auxiliar
        string tabela = "tbl_turma";

        //objeto para acessar metodos de insert, alterar, exlcuir e listar
        Conexao conexao = new Conexao();

        public void CadastrarTurma()
        {
            string inserir = $"insert into {tabela} values(null, '{cursoID}', '{dataInicio}', '{dataTermino}', '{horaInicio}', '{horaTermino}', '{professorID}')";
            conexao.ExecutarComando(inserir);

        }        

        public void AlterarTurma()
        {
            string alterar = $"UPDATE {tabela} SET idCurso ='{cursoID}', dataInicio = '{dataInicio}', dataTermino = '{dataTermino}', " +
                $"horaInicio = '{horaInicio}', horaTermino = '{horaTermino}', idProfessor = '{professorID}' WHERE codigo = '{codigoTurma}'";
            conexao.ExecutarComando(alterar);
        }

        public void ExcluirTurma()
        {
            string deletar = $"delete from {tabela} where codigo = {codigoTurma}";
            conexao.ExecutarComando(deletar);
        }

        public DataTable ListarCursos()   
        {
            string sql = $"select * from {tabela} order by codigo";
            return conexao.ExecutarConsulta(sql);
        }




    }
}
