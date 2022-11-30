using System.Windows.Forms;

namespace BlackJack
{
    public partial class Rule : Form
    {
        private Game _Form1;
        public Rule(Game form1)
        {
            _Form1 = form1;
            InitializeComponent();
        }
    }
}
