using CEntidades.Entidades;
using CLogica.Contracts;

namespace EjemploRepositorios
{
    public partial class Form1 : Form
    {
        private IAutorLogic _AutorLogic;

        public Form1(IAutorLogic AutorLogic)
        {
            _AutorLogic = AutorLogic;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Autor> examples = await _AutorLogic.GetAll();
        }
    }
}
