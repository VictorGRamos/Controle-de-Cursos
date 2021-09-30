
namespace ControleDeCursos
{
    partial class FrmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtValorMensalidade = new System.Windows.Forms.TextBox();
            this.lblValorMensalidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dtgCursos = new System.Windows.Forms.DataGridView();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(88, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Curso:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(116, 47);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(328, 20);
            this.txtNomeCurso.TabIndex = 2;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(12, 50);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(83, 13);
            this.lblNomeCurso.TabIndex = 2;
            this.lblNomeCurso.Text = "Nome do Curso:";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(344, 181);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 20);
            this.txtCargaHoraria.TabIndex = 5;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(240, 184);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(75, 13);
            this.lblCargaHoraria.TabIndex = 4;
            this.lblCargaHoraria.Text = "Carga Horária:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(116, 87);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(328, 74);
            this.txtConteudo.TabIndex = 3;
            // 
            // lblConteudo
            // 
            this.lblConteudo.Location = new System.Drawing.Point(12, 100);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(97, 32);
            this.lblConteudo.TabIndex = 6;
            this.lblConteudo.Text = "Conteúdo Programático:";
            // 
            // txtValorMensalidade
            // 
            this.txtValorMensalidade.Location = new System.Drawing.Point(116, 181);
            this.txtValorMensalidade.Name = "txtValorMensalidade";
            this.txtValorMensalidade.Size = new System.Drawing.Size(100, 20);
            this.txtValorMensalidade.TabIndex = 4;
            // 
            // lblValorMensalidade
            // 
            this.lblValorMensalidade.AutoSize = true;
            this.lblValorMensalidade.Location = new System.Drawing.Point(12, 184);
            this.lblValorMensalidade.Name = "lblValorMensalidade";
            this.lblValorMensalidade.Size = new System.Drawing.Size(97, 13);
            this.lblValorMensalidade.TabIndex = 8;
            this.lblValorMensalidade.Text = "Valor Mensalidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(27, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(123, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(222, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(318, 13);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 30);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dtgCursos
            // 
            this.dtgCursos.BackgroundColor = System.Drawing.Color.White;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Location = new System.Drawing.Point(12, 290);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.Size = new System.Drawing.Size(432, 175);
            this.dtgCursos.TabIndex = 10;
            this.dtgCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCursos_CellClick);
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnListar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 214);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(432, 57);
            this.pnlCRUD.TabIndex = 15;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 477);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.dtgCursos);
            this.Controls.Add(this.txtValorMensalidade);
            this.Controls.Add(this.lblValorMensalidade);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protótipo - CURSOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtValorMensalidade;
        private System.Windows.Forms.Label lblValorMensalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dtgCursos;
        private System.Windows.Forms.Panel pnlCRUD;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}