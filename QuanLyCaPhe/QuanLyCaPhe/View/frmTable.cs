using System;
using System.Windows.Forms;

namespace QuanLyCaPhe;

public partial class frmTable : Form
{
    public frmTable()
    {
        InitializeComponent();
       
    }

    private void button7_Click(object? sender, EventArgs e)
    {
        // Sự kiện mở chi tiết bàn khi click
        frmTableDetail detail = new frmTableDetail();
        detail.ShowDialog();
    }

    private void nướcUốngToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button2_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button4_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void flpTang1_Paint(object? sender, PaintEventArgs e)
    {
    }

    private void button31_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void FlpTang2Paint(object? sender, PaintEventArgs e)
    {
    }

    private void label1_Click(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void groupBox1_Enter(object? sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void panel1_Paint(object? sender, PaintEventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    
}
