using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace Unplanetary_Wars
{
    public partial class MainWindow : Form
    {
        private Player _player;

        public MainWindow()
        {
            InitializeComponent();

            Item item = World.ItemByID(1);

            _player = new Player("Kawt", 10, 10, 20, 20, new Money(0, 20, 0), 0, 01);

            Location location = new Location(1, "Osasco", "Dominada por bandidos e atualmente amaldiçoada.");

            lblCharHP.Text = _player.CurrentHitPoints + "/" + _player.MaximumHitPoints;
            lblCharMP.Text = _player.CurrentManaPoints + "/" + _player.MaximumManaPoints;
            lblCharXP.Text = _player.ExperiencePoints + "/" + "100";
            lblCharMoney.Text = _player.Money.HexCoins + " | " + _player.Money.Silver + " | " + _player.Money.Scrap;
            lblCharLevel.Text = _player.Level.ToString();

            lblCurrentLocal.Text = location.Name.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _player.SetMoney(new Money(20, 0, 0));
            lblCharMoney.Text = _player.Money.HexCoins + " | " + _player.Money.Silver + " | " + _player.Money.Scrap;
        }
    }
}
