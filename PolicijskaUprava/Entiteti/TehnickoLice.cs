﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
	public class TehnickoLice
	{
		
		public virtual AlarmniSistem Serijski_br_alarma { get; set; }
		public virtual string Ime { get; set; }
		public virtual int Id { get; set; }


		public override bool Equals(object Object)
		{

		

		return false;
		}
        public virtual string vratiIme()
        {
            return Ime;
        }
        public override string ToString()
        {
            return Ime;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
       }
    }
}
