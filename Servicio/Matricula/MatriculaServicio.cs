﻿using Repositorios.Matricula;

namespace Servicio.Matricula
{
    public class MatriculaServicio : IMatriculaServicio
    {
        private readonly IMatriculaRepositorio _matriculaRepositorio;

        public MatriculaServicio(IMatriculaRepositorio MatriculaRepositorio)
        {
            _matriculaRepositorio = MatriculaRepositorio;
        }

        public List<Datos.Models.ListaMatricula> ListaMatricula() => _matriculaRepositorio.ListaMatricula();

        public List<Datos.Models.Matricula> ListaMatriculaPorID(int MatriculaID) => _matriculaRepositorio.ListaMatriculaPorID(MatriculaID);

        public bool GuardarMatricula(Datos.Models.Matricula Matricula) => _matriculaRepositorio.GuardarMatricula(Matricula);

        public bool ActualizarMatricula(Datos.Models.Matricula Matricula) => _matriculaRepositorio.ActualizarMatricula(Matricula);
    }
}
