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
    public partial class FrmTurmas : Form
    {

        Turmas objTurmas = new Turmas();
        Professor objProfessor = new Professor();
        Curso objCurso = new Curso();
        public FrmTurmas()
        {
            InitializeComponent();
            dtgTurmas.DataSource = objTurmas.ListarCursos();
        }

        //FAZER METODO DE LIMPAR DEPOIS, POR ALGUM MOTIVO AS VARIAVEIS DE DATA NAO ESTAVAM PUBLICAS
        // MESMO ENTANDO PUBLICAS ??????????????????????

        public void limpartxt()
        {
            txtCodigo.Clear();
            txtHoraInicio.Clear();
            txtHoraTermino.Clear();
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            objTurmas.cursoID = comboBoxCurso.Text;
            objTurmas.dataInicio = DateTime.Parse(dateInicio.Text);
            objTurmas.dataTermino = DateTime.Parse(dateTermino.Text);
            objTurmas.horaInicio = txtHoraInicio.Text;
            objTurmas.horaTermino = txtHoraTermino.Text;
            objTurmas.professorID = comboboxProfessor.Text;

            //chamada metodo de cadastrar
            objTurmas.CadastrarTurma();

            MessageBox.Show("Registro cadastrado com sucesso", "TURMAS");

            limpartxt();

            //atualiza novamente o data grid para mostrar de forma atualizada
            dtgTurmas.DataSource = objTurmas.ListarCursos();



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Captura do Id a ser excluido 
            objTurmas.codigoTurma = int.Parse(txtCodigo.Text);
            //Chamada do metodo excluir
            objTurmas.ExcluirTurma();

            MessageBox.Show("Registro excluido com sucesso", "TURMA");

            limpartxt();

            //atualiza novamente o data grid para mostrar de forma atualizada
            dtgTurmas.DataSource = objTurmas.ListarCursos();

        }

        private void dtgTurmas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgTurmas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoraInicio.Text = dtgTurmas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtHoraTermino.Text = dtgTurmas.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Preenchimento do objeto
 
             objTurmas.codigoTurma = int.Parse(txtCodigo.Text);
            objTurmas.cursoID = comboBoxCurso.Text;
            objTurmas.dataInicio = DateTime.Parse(dateInicio.Text);
            objTurmas.dataTermino = DateTime.Parse(dateTermino.Text);
            objTurmas.horaInicio = txtHoraInicio.Text;
            objTurmas.horaTermino = txtHoraTermino.Text;
            objTurmas.professorID = comboboxProfessor.Text;

            //chamada metodo de alterar
            objTurmas.AlterarTurma();

            MessageBox.Show("Registro alterado com sucesso", "TURMA");

            //atualiza novamente o data grid para mostrar de forma atualizada
            dtgTurmas.DataSource = objTurmas.ListarCursos();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            comboboxProfessor.DataSource = objProfessor.ListarProfessor();
            comboboxProfessor.ValueMember = "codigo";
            comboboxProfessor.DisplayMember = "nome";
            comboBoxCurso.DataSource = objCurso.ListarCursos();
            comboBoxCurso.ValueMember = "codigo";
            comboBoxCurso.DisplayMember = "nome";

            //comboboxProfessor.DataSource = listarProfessor();
           //comboboxProfessor.ValueMember = "codigo";
           // comboboxProfessor.DisplayMember = "nome";
        }
    }
}
