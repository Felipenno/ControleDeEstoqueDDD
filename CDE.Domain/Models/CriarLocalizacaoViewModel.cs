﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CDE.Domain.Models
{
    public class CriarLocalizacaoViewModel
    {
        public string Andar { get; private set; }
        public string Corredor { get; private set; }
        public string Prateleira { get; private set; }
        public string Vao { get; private set; }
    }
}
