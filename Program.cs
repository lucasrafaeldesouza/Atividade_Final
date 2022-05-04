/*
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
            menu.Size = new Size(222, 200);
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

    public class InserirCategoria : Form 
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

        int id;
        Label lblDeletar;
        Button btnConfirm;
        Button btnCancel;

        public DeletarCategoria()
        {
            lblDeletar= new Label();
            lblDeletar.Text = $"Deseja realmente excluir esse item? (ID: {id})";
            lblDeletar.Size = new Size(200,40);
            lblDeletar.TextAlign = ContentAlignment.MiddleCenter;
            lblDeletar.Location = new Point(0,20);

            btnConfirm = new Button();
            btnConfirm.Text = "Sim";
            btnConfirm.Size = new Size(80,30);
            btnConfirm.Location = new Point(15,90);
            btnConfirm.Click += new EventHandler(this.btnConfirmClick);

            btnCancel = new Button();
            btnCancel.Text = "Não";
            btnCancel.Size = new Size(80,30);
            btnCancel.Location = new Point(105,90);
            btnCancel.Click += new EventHandler(this.btnCancelClick);

            this.Controls.Add(this.lblDeletar);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 140);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir essa categoria?" +
                $"",
                "Inserir Categoria",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Categoria cadastrada com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }

        private void btnCancelClick(object sender, EventArgs e)
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
*/