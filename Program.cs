using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ExemploTela
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    public class Login : Form //Tela de Login
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPass;

        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;

        public Login()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(120, 20);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(10, 50);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10, 110);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void handleConfirmClick(object sender, EventArgs e)
        {

            if (this.txtUser.Text == "teste" && this.txtPass.Text == "123")
            {
                Home form = new Home();
                form.Size = new Size(320, 300);
                form.Show();
            }
            else
            {
                //Tags form = new Tags();
                //form.Show();

            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Home : Form //Tela de Home
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        Button btnCategorias;
        Button btnTags;
        Button btnSenhas;
        Button btnUsuario;
        Button btnCancel;

        public Home()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Olá Teste";
            this.lblLogin.Location = new Point(117, 20);

            this.btnCategorias = new Button();
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Location = new Point(40, 60);
            this.btnCategorias.Size = new Size(100, 30);
            this.btnCategorias.Click += new EventHandler(this.handleCategoriaClick);

            
            this.btnTags = new Button();
            this.btnTags.Text = "Tags";
            this.btnTags.Location = new Point(160, 60);
            this.btnTags.Size = new Size(100, 30);
            //this.btnTags.Click += new EventHandler(this.handleTagsClick);
            

            this.btnSenhas = new Button();
            this.btnSenhas.Text = "Senhas";
            this.btnSenhas.Location = new Point(40, 100);
            this.btnSenhas.Size = new Size(100, 30);
            this.btnSenhas.Click += new EventHandler(this.handleSenhasClick);

            this.btnUsuario = new Button();
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Location = new Point(160, 100);
            this.btnUsuario.Size = new Size(100, 30);
            this.btnUsuario.Click += new EventHandler(this.handleUsuarioClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Sair";
            this.btnCancel.Location = new Point(110, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLogin);

            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.btnSenhas);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCancel);

        }
        private void handleTagsClick(object sender, EventArgs e)
        {
            //Tags menu = new Tags();
            //menu.ShowDialog();
        }
        private void handleCategoriaClick(object sender, EventArgs e)
        {
            Categorias menu = new Categorias();
            menu.ShowDialog();
        }
        private void handleSenhasClick(object sender, EventArgs e)
        {
            //Senhas menu = new Senhas();
            //menu.ShowDialog();
        }
        private void handleUsuarioClick(object sender, EventArgs e)
        {
            //Usuario menu = new Usuario();
            //menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

/*
    public class Tags : Form //Tags
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Tags()
        {
            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Tags";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmPacienteInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmPacienteDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmPacienteAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmPacienteAtualizar(object sender, EventArgs e)
        {
            Form7 menu = new Form7();
            menu.Size = new Size(325, 550);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteDeletar(object sender, EventArgs e)
        {
            Form6 menu = new Form6();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteInserir(object sender, EventArgs e)
        {
            Form5 menu = new Form5();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        /*private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente confirmar o agendamento?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    */

    public class Categorias : Form //Categorias
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Categorias()
        {
            this.lblDentista = new Label();
            this.lblDentista.Text = "Categorias";
            this.lblDentista.Location = new Point(220, 10);

            this.Controls.Add(this.lblDentista);

            listView = new ListView();
            listView.Location = new Point(50, 70);
            listView.Size = new Size(400, 400);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Rafael");
            lista1.SubItems.Add("000.000.000-00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 500);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 500);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickCategoriaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 500);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickCategoriaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 500);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickCategoriaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 600);
        }

        private void handleConfirmClickCategoriaAtualizar(object sender, EventArgs e)
        {
            AtualizarCategoria menu = new AtualizarCategoria();
            menu.Size = new Size(325, 300);
            menu.ShowDialog();
        }
        private void handleConfirmClickCategoriaDeletar(object sender, EventArgs e)
        {
            DeletarCategoria menu = new DeletarCategoria();
            menu.Size = new Size(325, 300);
            menu.ShowDialog();
        }
        private void handleConfirmClickCategoriaInserir(object sender, EventArgs e)
        {
            InserirCategoria menu = new InserirCategoria();
            menu.Size = new Size(325, 300);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form5 : Form //Inserir Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblDescricao;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;

        TextBox txtNome;
        TextBox txtDescricao;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;

        Button btnConfirm;
        Button btnCancel;

        public Form5()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "CPF";
            this.lblDescricao.Location = new Point(135, 80);
            this.lblDescricao.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 110);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 430);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 430);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class Form6 : Form //Deletar Paciente
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form6()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(55, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(145, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form7 : Form //Atualizar Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblDescricao;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblId;

        TextBox txtNome;
        TextBox txtDescricao;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtId;

        Button btnConfirm;
        Button btnCancel;

        public Form7()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "CPF";
            this.lblDescricao.Location = new Point(135, 80);
            this.lblDescricao.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.lblId = new Label();
            this.lblId.Text = "ID de Alteração";
            this.lblId.Location = new Point(110, 380);
            this.lblId.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 110);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.txtId = new TextBox();
            this.txtId.Location = new Point(10, 410);
            this.txtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 460);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 460);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblId);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class InserirCategoria : Form //Inserir Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblDescricao;
        TextBox txtNome;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;

        public InserirCategoria()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(10, 110);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 135);
            this.txtDescricao.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 200);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDescricao);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);


            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Categoria ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DeletarCategoria : Form //Deletar Dentista
    {
     private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblDescricao;
        TextBox txtNome;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;

        public DeletarCategoria()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(10, 110);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 135);
            this.txtDescricao.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 200);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDescricao);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);


            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Categoria ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class AtualizarCategoria : Form //Atualizar Categoria
      {
     private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblDescricao;
        TextBox txtNome;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;

        public AtualizarCategoria()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(10, 110);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 135);
            this.txtDescricao.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 200);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDescricao);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);


            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Categoria ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*
    public class Senhas : Form //Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblProcedimento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Senhas()
        {
            this.lblProcedimento = new Label();
            this.lblProcedimento.Text = "Procedimento";
            this.lblProcedimento.Location = new Point(220, 10);

            this.Controls.Add(this.lblProcedimento);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Arrancar dente");
            lista1.SubItems.Add("R$ 50,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickProcedimentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickProcedimentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickProcedimentoAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickProcedimentoAtualizar(object sender, EventArgs e)
        {
            Login4 menu = new Login4();
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoDeletar(object sender, EventArgs e)
        {
            Login3 menu = new Login3();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoInserir(object sender, EventArgs e)
        {
            Login2 menu = new Login2();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class Login2 : Form //Inserir Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public Login2()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Login3 : Form //Deletar Procedimento
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Login3()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Procedimento";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Login4 : Form //Atualizar Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public Login4()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Usuario : Form //Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblEspecialidade;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Usuario()
        {
            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(220, 10);

            this.Controls.Add(this.lblEspecialidade);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickEspecialidadeInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickEspecialidadeDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickEspecialidadeAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickEspecialidadeAtualizar(object sender, EventArgs e)
        {
            Login8 menu = new Login8();
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeDeletar(object sender, EventArgs e)
        {
            Login7 menu = new Login7();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeInserir(object sender, EventArgs e)
        {
            Login6 menu = new Login6();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Login6 : Form //Inserir Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public Login6()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class Login7 : Form //Deletar Especialidade
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Login7()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Especialidade";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Login8 : Form // Atualizar Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public Login8()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Login9 : Form //Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblSala;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Login9()
        {
            this.lblSala = new Label();
            this.lblSala.Text = "Sala";
            this.lblSala.Location = new Point(220, 10);

            this.Controls.Add(this.lblSala);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("RA12");
            lista1.SubItems.Add("Raio-X");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Número", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickSalaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickSalaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickSalaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickSalaAtualizar(object sender, EventArgs e)
        {
            Home2 menu = new Home2();
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaDeletar(object sender, EventArgs e)
        {
            Home1 menu = new Home1();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaInserir(object sender, EventArgs e)
        {
            Home0 menu = new Home0();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Home0 : Form //Inserir Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public Home0()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Home1 : Form //Deletar Sala
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Home1()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Sala";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Home2 : Form //Atualizar Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public Home2()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

        public class Home3 : Form //Tela de agendamento - LUCAS
        {
        private System.ComponentModel.IContainer components = null;

        
        Label lblAgendamento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Home3()
        {
            this.lblAgendamento = new Label();
            this.lblAgendamento.Text = "Agendamento";
            this.lblAgendamento.Location = new Point(200, 10);

            this.Controls.Add(this.lblAgendamento);

            listView = new ListView();
            listView.Location = new Point(100, 70);
            listView.Size = new Size(280, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("2022/03/21");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("PacienteId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("DentistaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("SalaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            
            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmAgendamentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmAgendamentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmAgendamentoAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(480, 300);   
        }

        private void handleConfirmAgendamentoAtualizar(object sender, EventArgs e)
        {
            Home4 menu = new Home4();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoDeletar(object sender, EventArgs e)
        {
            Home5 menu = new Home5();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoInserir(object sender, EventArgs e)
        {
            Home6 menu = new Home6();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

        public class Home4 : Form //Atualizar Agendamento - LUCAS
        {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public Home4()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);

        }
         private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        public class Home5 : Form //Atualizar Deletar - LUCAS
        {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Home5()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(55, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(145, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e)
        {

        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        public class Home6 : Form //Atualizar Inserir - LUCAS
        {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public Home6()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);
        }
         private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
*/
