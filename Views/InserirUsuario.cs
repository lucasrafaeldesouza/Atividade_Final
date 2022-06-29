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


public class InserirUsuario : Form
{
    private System.ComponentModel.IContainer components = null;
    Usuarios formUsuario;
    Label lblNome;
    Label lblEmail;
    Label lblSenha;
    TextBox txtNome;
    TextBox txtEmail;
    TextBox txtSenha;
    Button btnConfirm;
    Button btnCancel;

    public InserirUsuario(Usuarios formUsuario)
    {
        this.formUsuario = formUsuario;

        this.lblNome = new Label();
        this.lblNome.Text = "Nome";
        this.lblNome.Location = new Point(10, 20);

        this.lblEmail = new Label();
        this.lblEmail.Text = "Email";
        this.lblEmail.Location = new Point(10, 90);

        this.lblSenha = new Label();
        this.lblSenha.Text = "Senha";
        this.lblSenha.Location = new Point(10, 150);

        this.txtNome = new TextBox();
        this.txtNome.Location = new Point(10, 50);
        this.txtNome.Size = new Size(280, 30);

        this.txtEmail = new TextBox();
        this.txtEmail.Location = new Point(10, 115);
        this.txtEmail.Size = new Size(280, 30);

        this.txtSenha = new TextBox();
        this.txtSenha.Location = new Point(10, 180);
        this.txtSenha.Size = new Size(280, 30);

        this.btnConfirm = new Button();
        this.btnConfirm.Text = "Confirmar";
        this.btnConfirm.Location = new Point(60, 215);
        this.btnConfirm.Size = new Size(80, 30);
        this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

        this.btnCancel = new Button();
        this.btnCancel.Text = "Cancelar";
        this.btnCancel.Location = new Point(160, 215);
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
        this.Text = "Inserir Usuario ";
        this.StartPosition = FormStartPosition.CenterScreen;
    }
    private void handleConfirmClick(object sender, EventArgs e)
    {
        try
        {
            UsuarioController.IncluirUsuario(this.txtNome.Text, this.txtEmail.Text, this.txtSenha.Text);
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