using AutoMapper;
using PolizasVehiculos.Core.DTOs;
using PolizasVehiculos.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolizasVehiculos.Infraestructura.Mapeos
{
    public class PerfilesMapeo : Profile
    {
        public PerfilesMapeo() {
            CreateMap<Pais, PaisDTO>().ReverseMap();
            CreateMap<Seguridad, SeguridadDTO>().ReverseMap();
        }
    }
}
