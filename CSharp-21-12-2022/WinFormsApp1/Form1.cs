namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("hi", "C2109I1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        var result = MessageBox.Show("hi", "C2109I1", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (result == DialogResult.Yes)
        {


        }
        else
        {

        }
    }
}
