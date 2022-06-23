using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Controllers;
using Models;


public class AtualizarUsuario : Form
{
    private System.ComponentModel.IContainer components = null;
    Label lblNome;
    Label lblEmail;
    Label lblSenha;
    TextBox txtNome;
    TextBox txtEmail;
    TextBox txtSenha;
    Button btnConfirm;
    Button btnCancel;
    Usuarios formUsuario;
    int id;

    public AtualizarUsuario(Usuarios formUsuario)
    {
        this.formUsuario = formUsuario;
        int id = Convert.ToInt32(formUsuario.listView.SelectedItems[0].Text);
        this.id = id;
        Usuario usuario = UsuarioController.GetUsuario(id);


        this.lblNome = new Label();
        this.lblNome.Text = "Nome";
        this.lblNome.Location = new Point(10, 20);

        this.lblEmail = new Label();
        this.lblEmail.Text = "Email";
        this.lblEmail.Location = new Point(10, 75);

        this.lblSenha = new Label();
        this.lblSenha.Text = "Senha";
        this.lblSenha.Location = new Point(10, 125);

        this.txtNome = new TextBox();
        this.txtNome.Location = new Point(10, 45);
        this.txtNome.Size = new Size(280, 30);

        this.txtEmail = new TextBox();
        this.txtEmail.Location = new Point(10, 100);
        this.txtEmail.Size = new Size(280, 30);

        this.txtSenha = new TextBox();
        this.txtSenha.Location = new Point(10, 155);
        this.txtSenha.Size = new Size(280, 30);

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
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblSenha);

        this.Controls.Add(this.txtNome);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtSenha);

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
        try
        {
            UsuarioController.AlterarUsuario(this.id, this.txtNome.Text, this.txtEmail.Text, this.txtSenha.Text);
            MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK);
            this.formUsuario.updateList();
            this.Close();
        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message);
        }
    }
    private void handleCancelClick(object sender, EventArgs e)
    {
        this.Close();
    }
}