using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ExemploLogin
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
        this.lblLogin.Text = "Olá Usuario";
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
        this.btnTags.Click += new EventHandler(this.handleTagsClick);

        this.btnUsuario = new Button();
        this.btnUsuario.Text = "Usuario";
        this.btnUsuario.Location = new Point(100, 100);
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
        Tags menu = new Tags();
        menu.ShowDialog();
    }
    private void handleCategoriaClick(object sender, EventArgs e)
    {
        Categorias menu = new Categorias();
        menu.ShowDialog();
    }
    private void handleUsuarioClick(object sender, EventArgs e)
    {
         Usuarios menu = new Usuarios();
         menu.ShowDialog();
    }
    private void handleCancelClick(object sender, EventArgs e)
    {
        this.Close();
    }
}