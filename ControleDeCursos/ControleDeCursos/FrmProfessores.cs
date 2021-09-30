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
    public partial class FrmProfessores : Form
    {

        Professor objProfessor = new Professor();
        public FrmProfessores()
        {
            InitializeComponent();
            dtg_Professores.DataSource = objProfessor.ListarProfessor();
        }

        public void Limpartxt()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txttelefone.Clear();
            txtvalorHoraAula.Clear();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //preenchimento do objeto
            objProfessor.nome = txtnome.Text;
            objProfessor.valorHoraAula = double.Parse(txtvalorHoraAula.Text);
            objProfessor.telefone = int.Parse(txttelefone.Text);

            objProfessor.CadastrarProfessor();

            MessageBox.Show("Registro realizado com sucesso", "PROFESSORES");

            //metodo para limpar as caixas de texto
            Limpartxt();

            dtg_Professores.DataSource = objProfessor.ListarProfessor();
            
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtcodigo.Text);
            objProfessor.nome = txtnome.Text;
            objProfessor.valorHoraAula = double.Parse(txtvalorHoraAula.Text);
            objProfessor.telefone = int.Parse(txttelefone.Text);

            objProfessor.AlterarProfessor();

            MessageBox.Show("Registro alterado com sucesso", "PROFESSOR");

            Limpartxt();

            dtg_Professores.DataSource = objProfessor.ListarProfessor();

        }

        private void dtg_Professores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //selecionando as informacoes ao clicar no datagrid
            txtcodigo.Text = dtg_Professores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtg_Professores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtvalorHoraAula.Text = dtg_Professores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttelefone.Text = dtg_Professores.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //Captura do id a ser excluido
            objProfessor.codigoProfessor = int.Parse(txtcodigo.Text);

            //chamada do metodo excluir
            objProfessor.ExcluirProfessor();

            MessageBox.Show("Registro excluido com sucesso", "PROFESSORES");

            //metodo de limpar as caixas de texto
            Limpartxt();

            //atualiza a data grid 
            dtg_Professores.DataSource = objProfessor.ListarProfessor();


        }
    }
}
