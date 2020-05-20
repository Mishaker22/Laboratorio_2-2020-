using Clase_8_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Library
{
    protected class Accionista: Persona
    {
        protected int _porcionAccionaria;
        
        public int PorcionAccionaria
        {
            get { return this._porcionAccionaria; }
            set
            {
                this._porcionAccionaria = -1;
                if (this._porcionAccionaria>0 && this._porcionAccionaria<100)
                {
                    this._porcionAccionaria = _porcionAccionaria;
                }
            }
        }

        public override string PosicionSocietaria()
        {
            throw new NotImplementedException();
        }

    }
}
