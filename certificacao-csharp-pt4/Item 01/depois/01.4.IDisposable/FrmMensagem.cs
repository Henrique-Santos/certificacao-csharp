using System;
using System.Windows.Forms;

namespace _01._4.IDisposable_Finalizador
{
    public partial class FrmMensagem : Form
    {
        public FrmMensagem()
        {
            InitializeComponent();

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            //MensageiroNotepad mensageiro = new MensageiroNotepad();
            //mensageiro.EnviarMensagem(txtMensagem.Text);
            //mensageiro.Dispose();

            // A instrução using dispensa o uso do Dispose, ele só pode ser utilizado em classes que implementam IDisposable
            using (MensageiroNotepad mensageiro = new MensageiroNotepad())
            {
                mensageiro.EnviarMensagem(txtMensagem.Text);
            }

        }
    }
}
