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
        private int _playerHP;
        private int _playerAC;
        private int _weaponID;

        public Player(int playerID, string playerName, string playerRace, int playerHP, int playerAC, int weaponID)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            PlayerRace = playerRace;
            PlayerHP = playerHP;
            PlayerAC = playerAC;
            WeaponID = weaponID;
        }
        public int PlayerID { get { return _playerID; } set { _playerID = value; } }
        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int PlayerHP { get { return _playerHP; } set { _playerHP = value; } }
        public int PlayerAC { get { return _playerAC; } set { _playerAC = value; } }

        public int WeaponID { get { return _weaponID; } set { _weaponID = value; } }
    }
}
