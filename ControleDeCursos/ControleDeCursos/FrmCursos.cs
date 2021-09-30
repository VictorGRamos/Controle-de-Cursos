using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmCursos : Form
    {

        Curso objCurso = new Curso();
        public FrmCursos()
        {
            InitializeComponent();
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        public void Limpartxt()
        {
            txtCodigo.Clear();
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtCargaHoraria.Clear();
            txtValorMensalidade.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Captura do Id a ser excluido 
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            //Chamada do metodo excluir
            objCurso.ExcluirCurso();

            MessageBox.Show("Registro excluído com sucesso", "CURSOS");
            
            //metodo para limpar as caixas de texto
            Limpartxt();

            //atualiza novamente o data grid para mostrar de forma atualizada
            dtgCursos.DataSource = objCurso.ListarCursos();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);

            //chamada metodo de cadastrar
            objCurso.CadastrarCurso();

            MessageBox.Show("Registro realizado com sucesso", "CURSOS");

            Limpartxt();

            //Atualiza o dada grid view para mostrar o dado inserido
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void dtgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ao clicar em um registro da datagrid os dados serao selecionado
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);

            objCurso.AlterarCurso();

            MessageBox.Show("Registro alterado com sucesso!", "CURSOS");

            Limpartxt();

            //Atualiza o dada grid view para mostrar o dado alterado
            dtgCursos.DataSource = objCurso.ListarCursos();
        }
    }
}
