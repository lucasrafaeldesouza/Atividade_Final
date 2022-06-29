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
public class Tags : Form
{
    private System.ComponentModel.IContainer components = null;
    Label lblTags;
    Button btnCancel;
    Button btnInsert;
    Button btnDeletar;
    Button btnUpdate;
    public ListView listView;
    public Tags()
    {
        this.lblTags = new Label();
        this.lblTags.Text = "Tags";
        this.lblTags.Location = new Point(220, 10);
        this.Controls.Add(this.lblTags);

        listView = new ListView();
        listView.Location = new Point(50, 70);
        listView.Size = new Size(400, 400);
        listView.View = View.Details;
        listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
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
        this.btnInsert.Click += new EventHandler(this.handleConfirmClickTagInserir);

        this.btnDeletar = new Button();
        this.btnDeletar.Text = "Deletar";
        this.btnDeletar.Location = new Point(160, 500);
        this.btnDeletar.Size = new Size(80, 30);
        this.btnDeletar.Click += new EventHandler(this.handleConfirmClickTagDeletar);

        this.btnUpdate = new Button();
        this.btnUpdate.Text = "Atualizar";
        this.btnUpdate.Location = new Point(260, 500);
        this.btnUpdate.Size = new Size(80, 30);
        this.btnUpdate.Click += new EventHandler(this.handleConfirmClickTagAtualizar);

        this.updateList();

        this.Controls.Add(listView);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnInsert);
        this.Controls.Add(this.btnDeletar);
        this.Controls.Add(this.btnUpdate);
        this.ClientSize = new System.Drawing.Size(500, 600);
    }
    private void handleConfirmClickTagAtualizar(object sender, EventArgs e)
    {
        if (listView.SelectedItems.Count > 0)
        {
            AtualizarTag menu = new AtualizarTag(this);
            menu.Size = new Size(325, 300);
            menu.ShowDialog();
        }
        else
        {
            MessageBox.Show("Não há itens selecionados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void handleConfirmClickTagInserir(object sender, EventArgs e)
    {
        InserirTag menu = new InserirTag(this);
        menu.Size = new Size(325, 300);
        menu.ShowDialog();
    }

    private void handleConfirmClickTagDeletar(object sender, EventArgs e)
    {
        ListViewItem selectedItem = listView.SelectedItems[0];
        DeletarTag menu = new DeletarTag(Convert.ToInt32(selectedItem.Text));
        menu.Size = new Size(222, 200);
        menu.ShowDialog();
    }
    private void handleCancelClick(object sender, EventArgs e)
    {
        this.Close();
    }
    public void updateList()
    {
        IEnumerable<Tag> tags = TagController.VisualizarTag();
        this.listView.Items.Clear();
        foreach (Tag tag in tags)
        {
            ListViewItem item = new ListViewItem(tag.Id.ToString());
            item.SubItems.Add(tag.Descricao);
            listView.Items.Add(item);
        }
    }
}
