using Arbol_Genealogico.Modelo.Servicios;
using Arbol_Genealogico.Presentadores.Interfaces;
using Arbol_Genealogico.Vistas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Genealogico.Presentadores.Controladores
{
    public class MainController : iMainController
    {
        iMain _main;
        DataAccess dataAccess;
        bool loadedDB = false;
        string _mainTitle = "";

        public MainController(iMain main, string mainTitle)
        {
            _main = main;
            dataAccess = new DataAccess();
            loadedDB = false;
            _mainTitle = mainTitle;
            Subscribe();
        }

        private void Subscribe()
        {
            _main.OpenDB += (e, o) => OpenDB();
            _main.CloseDB += (e, o) => CloseDB();
        }

        public void OpenDB()
        {
            string path;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQLite DB Files( *.db)| *.db";

            if(fileDialog.ShowDialog() == DialogResult.OK && fileDialog.CheckPathExists == true && fileDialog.CheckFileExists == true)
            {
                path = fileDialog.FileName;
                dataAccess.Path = path;
                loadedDB = true;
                _main.Text += _mainTitle + "   " + path;
                _main.EnableAllButtons();
            }
        }

        public void CloseDB()
        {
            dataAccess.Path = "";
            loadedDB = false;
            _main.Text = _mainTitle;
            _main.DisableAllButtons();
        }

    }
}
