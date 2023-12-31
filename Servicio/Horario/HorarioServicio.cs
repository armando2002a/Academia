﻿using Repositorios.Horario;

namespace Servicio.Horario
{
    public class HorarioServicio : IHorarioServicio
    {
        private readonly IHorarioRepositorio _horarioRepositorio;

        public HorarioServicio(IHorarioRepositorio horarioRepositorio)
        {
            _horarioRepositorio = horarioRepositorio;
        }

        public List<Datos.Models.ListaHorario> ListaHorario() => _horarioRepositorio.ListaHorario();

        public List<Datos.Models.HorarioMatriculaDatos> ListaHorarioMatricula() => _horarioRepositorio.ListaHorarioMatricula();

        public List<Datos.Models.Horario> ListaHorarioPorID(int HorarioID) => _horarioRepositorio.ListaEstuHorarioPorID(HorarioID);

        public bool GuardarHorario(Datos.Models.Horario Horario) => _horarioRepositorio.GuardarHorario(Horario);

        public bool ActualizarHorario(Datos.Models.Horario Horario) => _horarioRepositorio.ActualizarHorario(Horario);
    }
}
