using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Professor
    {
        //propriedades
        public int codigoProfessor, telefone;
        public double valorHoraAula;
        public string nome;

        //variavel auxiliar para conexao
        string tabela = "tbl_professor";


        //objeto para acessar metodos de insercao, alteracao, eclusao ou busca de dados
        Conexao conexao = new Conexao();

        public void CadastrarProfessor()
        {
            string inserir = $"insert into {tabela} values(null,'{nome}','{valorHoraAula}','{telefone}')";
            conexao.ExecutarComando(inserir);

        }

        public void AlterarProfessor()
        {

            string alterar = $"UPDATE {tabela} SET nome = '{nome}', valorHoraAula = '{valorHoraAula}', telefone = '{telefone}' WHERE codigo = '{codigoProfessor}' ";
            conexao.ExecutarComando(alterar);
        }

        public void ExcluirProfessor()
        {
            string deletar = $"delete from {tabela} where codigo = {codigoProfessor}";
            conexao.ExecutarComando(deletar);
        }

        public DataTable ListarProfessor()
        {
            string sql = $"select * from {tabela} order by codigo";
            return conexao.ExecutarConsulta(sql);
        }

    }
}
