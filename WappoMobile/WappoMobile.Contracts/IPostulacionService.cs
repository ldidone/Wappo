﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WappoMobile.Contracts
{
    public interface IPostulacionService
    {
        Task<bool> Postularse(Postulacion postulacion);
    }
}
