using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEngine;

namespace Interface
{

 public interface Items
{
  int ID { get; set; }
  string Name { get; set; }
  string Description { get; set; }
  bool Items { get; set; }
}
	public interface Monster
	{
		int ID { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string Race { get; set; }
		int HP { get; set; }
		int AC { get; set; }
		bool Monster { get; set; }

	public interface Player
		{
			int playerID { get; set; }
			string playerName { get; set; }
			string playerRace { get; set; }
			int location { get; set; }
			int playerHP { get; set; }
			int playerAC { get; set; }
			List<Weapon> _weapons { get; set; }
			List<Items> _items { get; set; }
			List<Potion> _potion { get; set; }
			List<Treasures> _treasures { get; set; }
			bool Player { get; set; }


		}
		public interface Potion { }

		int idNumber { get; set; }
		string name { get; set; }
		string description { get; set; }
		string value { get; set; }
		bool potion { get; set; }

		public interface Treasures
		{
			int IdNumber { get; set; }
			string Name { get; set; }
			string Value { get; set; }

		}
		

		




	}






}


	

