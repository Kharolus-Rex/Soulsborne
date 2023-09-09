using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Player
    {
        private int _playerID;
        private string _playerName;
        private string _playerRace;
        private int _location;
        private int _playerHP;
        private int _playerAC;
        private List<Weapon> _weapons;

        public Player(int playerID, string playerName, string playerRace, int location, int playerHP, int playerAC, List<Weapon> weapons)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            PlayerRace = playerRace;
            PlayerLocation = location;
            PlayerHP = playerHP;
            PlayerAC = playerAC;
            Weapons = weapons;
        }
        public int PlayerID { get { return _playerID; } set { _playerID = value; } }
        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int PlayerLocation { get { return _location; } set { _location = value; } }
        public int PlayerHP { get { return _playerHP; } set { _playerHP = value; } }
        public int PlayerAC { get { return _playerAC; } set { _playerAC = value; } }

        public List<Weapon> Weapons { get { return _weapons; } set { _weapons = value; } }
    }
}
