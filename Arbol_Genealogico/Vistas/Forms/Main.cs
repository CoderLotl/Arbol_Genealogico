using Arbol_Genealogico.Presentadores.Controladores;
using Arbol_Genealogico.Vistas.Interfaces;

namespace Arbol_Genealogico
{
    public partial class Main : Form, iMain
    {
        readonly MainController _mainController;
        string filePath;


        public Main()
        {
            InitializeComponent();
            DisableAllButtons();

            this.Text = "Arbol Genealogico";
            _mainController = new MainController(this, this.Text);
        }
        public string FilePath { get => this.filePath; set => filePath = value; }
        public Button Cerrar { get => btn_Cerrar; set => btn_Cerrar = value; }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenDB.Invoke(this, EventArgs.Empty);            
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            CloseDB.Invoke(this, EventArgs.Empty);            
        }

        public void DisableAllButtons()
        {
            btn_Cerrar.Enabled = false;
        }

        public void EnableAllButtons()
        {
            btn_Cerrar.Enabled = true;
        }

        public event EventHandler OpenDB;
        public event EventHandler CloseDB;
    }
}