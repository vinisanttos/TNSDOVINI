﻿using JOGONUM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGONUM.model
{
    internal class Usuario
    {
        public int CodUser { get; set; }
        public string User { get; set; }
        public string Pass {  get; set; }

        public Usuario(int coduser,string usuario, string senha) : this (usuario, senha)
        {
            CodUser = coduser;
        }

        public Usuario(string usuario, string senha)
        {
            User = usuario;
            Pass = senha;
        }
    }
}