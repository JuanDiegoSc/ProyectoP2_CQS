﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoResenas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResena.AccesoDatos.Data.Repositorio.IRepositorio
{
    public interface IResenaRepositorio : IRepositorio<Resena>
    {
        void Update(Resena Resena);

       
    }   

}
