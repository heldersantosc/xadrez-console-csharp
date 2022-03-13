﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrex
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
