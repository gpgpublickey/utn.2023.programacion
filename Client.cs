using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{

	public class Client
    {
        public int Id { get; set; }

        private double balance;

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Client(int id, string name, double balance) {
			this.Id = id;
			this.balance = balance;
			this.name = name;
		}

	}
}
