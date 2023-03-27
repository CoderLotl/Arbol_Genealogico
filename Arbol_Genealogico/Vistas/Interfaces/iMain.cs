using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Genealogico.Vistas.Interfaces
{
    public interface iMain
    {
        string FilePath { get; set; }
        string Text { get; set; }
        public Button Cerrar { get; set; }

        public void DisableAllButtons();
        public void EnableAllButtons();

        event EventHandler OpenDB;
        event EventHandler CloseDB;
    }
}
