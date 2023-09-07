using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine.Classes
{
    class Player
    {
        private int _playerID;
        private string _playerName;
        private string _playerRace;
        private int _playerHP;
        private int _playerAC;
        private int _weaponID;

        public Player(int PlayerID, string PlayerName, string PlayerRace, int PlayerHP, int PlayerAC, int WeaponID)
        {
            PlayerID = _playerID;
            PlayerName = _playerName;
            PlayerRace = _playerRace;
            PlayerHP = _playerHP;
            PlayerAC = _playerAC;
            WeaponID = _weaponID;
        }
        public int PlayerID { get { return _playerID; } set { _playerID = value; } }
        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int PlayerHP { get { return _playerHP; } set { _playerHP = value; } }
        public int PlayerAC { get { return _playerAC; } set { _playerAC = value; } }

        public int WeaponID { get { return _weaponID; } set { _weaponID = value; } }
    }
}
