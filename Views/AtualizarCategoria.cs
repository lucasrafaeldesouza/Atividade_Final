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


  public class AtualizarCategoria : Form //Atualizar Categoria
    {
        private System.ComponentModel.IContainer components = null;

        Categorias formCategoria;
        int id;
        Label lblNome;
        Label lblDescricao;
        TextBox txtNome;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;

        public AtualizarCategoria(Categorias formCategoria)
        {
            int id = Convert.ToInt32(formCategoria.listView.SelectedItems[0].Text);
            this.id = id;
          
            this.formCategoria = formCategoria;
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(10, 75);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 45);
            this.txtNome.Size = new Size(280, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 100);
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
          try 
            {
                CategoriaController.AlterarCategoria(this.id, this.txtNome.Text, this.txtDescricao.Text);

                this.formCategoria.updateList();
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