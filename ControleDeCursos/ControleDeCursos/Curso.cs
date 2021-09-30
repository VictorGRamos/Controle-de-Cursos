using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {

        //propriedades
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;

        //variavel auxiliar
        string tabela = "tbl_curso";

        //objeto para acessar metodos de insercao, alteracao, eclusao ou busca de dados
        Conexao conexao = new Conexao();

        public void CadastrarCurso()
        {
         
            string inserir = $"insert into {tabela} values(null,'{nomeCurso}','{conteudoProgramatico}','{valorMensalidade}','{cargaHoraria}')";
            conexao.ExecutarComando(inserir);
        
        }

        public void AlterarCurso()
        {
            string alterar = $"UPDATE {tabela} SET nomeCurso = '{nomeCurso}', conteudo= '{conteudoProgramatico}', valorMensalidade = '{valorMensalidade}'," +
                $"cargaHoraria = '{cargaHoraria}' WHERE codigo = '{codigoCurso}'";
            conexao.ExecutarComando(alterar);
        }

        public void ExcluirCurso()
        {
            string deletar = $"delete from {tabela} where codigo = {codigoCurso}";
            conexao.ExecutarComando(deletar);
        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by codigo";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
